using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormExample.Entity;

namespace WinFormExample
{
    public partial class frmBaiThiNewcs : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private const int duration = 5;
        private List<Question> listQuestion;
        public frmBaiThiNewcs()
        {
            InitializeComponent();
        }

        private void frmBaiThiNewcs_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (seconds == 0)
            {
                lblTime.Text = $"Thời gian còn lại {duration - minutes} phut {0} giây";
            }
            else
            {
                lblTime.Text = $"Thời gian còn lại {duration - minutes - 1} phut {60 - seconds} giây";
            }
            if (minutes == duration)
            {
                Submit();
            }
        }
        private void GenerateQuestionUI()
        {
            for (int i = 0; i < listQuestion.Count; i++)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = listQuestion[i].Title;
                groupBox.Width = 500;
                groupBox.Height = 350;
                groupBox.Name = $"Cau{i + 1}";
                if (i == 0) // Câu đầu tiên
                {
                    groupBox.Location = new Point(40, 50);
                }
                else //Câu tiếp theo
                {
                    GroupBox gPre = (GroupBox)this.Controls.Find($"Cau{i}", false)[0];

                    groupBox.Location = new Point(40, gPre.Location.Y + gPre.Height + 10);
                }
                for (int j = 0; j < 4; j++)
                {
                    RadioButton r = new RadioButton();
                    r.AutoSize = true;
                    r.Location = new Point(30, 30 + j * 50);
                    switch(j+1)
                    {
                        case 1:
                            r.Text = listQuestion[i].Anser1;
                            break;
                        case 2:
                            r.Text = listQuestion[i].Anser2;
                            break;
                        case 3:
                            r.Text = listQuestion[i].Anser3;
                            break;
                        case 4:
                            r.Text = listQuestion[i].Anser4;
                            break;
                        default:
                            throw new Exception("out of range");
                    }
                    groupBox.Controls.Add(r);
                }
                this.Controls.Add(groupBox);




            }
        }
        public void ReadQuestion()
        {
            //Về nhà thực hiện đọc từ file text
            listQuestion = new List<Question>();
            for (int i = 1; i <= 4; i++)
            {
                Question q = new Question();
                q.Title = $"Câu hỏi {i}";
                q.Anser1 = $"Trả lời câu {i} 1";
                q.Anser2 = $"Trả lời câu {i} 2";
                q.Anser3 = $"Trả lời câu {i} 3";
                q.Anser4 = $"Trả lời câu {i} 4";
                q.Result = $"Trả lời câu {i} {i}";
                listQuestion.Add(q);
            }


        }
        private void Submit()
        {

        }
        private void butLamBai_Click(object sender, EventArgs e)
        {
            if (butLamBai.Text == "Làm bài")
            {
                ReadQuestion();
                GenerateQuestionUI();
                butLamBai.Text = "Nộp bài";
                lblTime.Text = $"Thời gian còn lại: {duration - minutes - 1} phút {60 - seconds} giây";
                lblTime.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            else 
            {
                Submit();
                butLamBai.Enabled = false;
                timer1.Enabled= false;
                timer1.Stop();
            }
        }
    }
}
