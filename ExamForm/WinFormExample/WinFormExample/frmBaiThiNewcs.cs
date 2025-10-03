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
        private int minutes = 5;
        private List<Question> listQuestion = new List<Question>();

        public frmBaiThiNewcs()
        {
            InitializeComponent();
        }

        private void frmBaiThiNewcs_Load(object sender, EventArgs e)
        {
            //this.AutoScroll = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }
            lblTime.Text = $"Thời gian còn lại {minutes} phút {seconds} giây";
            if (minutes == 0 && seconds == 0)
            {
                Submit();
            }
        }

        private void CButton_Click(object sender, EventArgs e)
        {
                CLabel.Text = "Nhấn nút làm bài để bắt đầu";
                butLamBai.Visible = true;
                CButton.Visible = false;
        }

        private void butLamBai_Click(object sender, EventArgs e)
        {

            if (butLamBai.Text == "Làm bài")
            {
                GenerateQuestionUI();
                butLamBai.Text = "Nộp bài";
                lblTime.Text = $"Thời gian còn lại: {minutes} phút {seconds} giây";
                lblTime.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                Submit();
                butLamBai.Enabled = false;
                timer1.Enabled = false;
                timer1.Stop();
            }
        }
        private void Submit()
        {
            timer1.Stop();

            int correctAnswersCount = 0;

            for (int i = 0; i < listQuestion.Count; i++)
            {
                string groupName = $"Cau{i + 1}";
                // question panel scroll
                Control[] foundControls = panelQuestions.Controls.Find(groupName, false);

                if (foundControls.Length > 0 && foundControls[0] is GroupBox groupBox)
                {
                    int userAnswer = 0;
                    var radioButtons = groupBox.Controls.OfType<RadioButton>().ToList();

                    for (int j = 0; j < radioButtons.Count; j++)
                    {
                        if (radioButtons[j].Checked)
                        {
                            userAnswer = j + 1;
                            break;
                        }
                    }

                    int correctAnswer = int.Parse(listQuestion[i].Result);

                    if (userAnswer == correctAnswer)
                    {
                        correctAnswersCount++;
                    }
                }
            }

            double scorePerQuestion = 10.0 / listQuestion.Count;
            double finalScore = correctAnswersCount * scorePerQuestion;

            MessageBox.Show($"Bạn đã trả lời đúng {correctAnswersCount}/{listQuestion.Count} câu.\n\nĐiểm của bạn là: {finalScore:F2}/10", "Kết quả bài thi");

            butLamBai.Enabled = false;
        }

        private void GenerateQuestionUI()
        {
            ReadQuestion();
            if (listQuestion.Count == 0) return;

            // Xóa các câu hỏi cũ (nếu có) trước khi tạo mới
            panelQuestions.Controls.Clear();

            for (int i = 0; i < listQuestion.Count; i++)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = $"Câu {i + 1}: {listQuestion[i].Title}";
                groupBox.Name = $"Cau{i + 1}";
                groupBox.Width = panelQuestions.Width - 60; // Tự động co giãn theo chiều rộng của Panel
                groupBox.Height = 200;

                if (i == 0)
                {
                    // Vị trí câu đầu tiên, cách lề panel một chút
                    groupBox.Location = new Point(20, 20);
                }
                else
                {
                    string previousGroupName = $"Cau{i}";
                    // <<< THAY ĐỔI: Tìm control bên trong panelQuestions, không phải 'this'
                    Control[] foundControls = panelQuestions.Controls.Find(previousGroupName, false);

                    if (foundControls.Length > 0)
                    {
                        GroupBox gPre = (GroupBox)foundControls[0];
                        groupBox.Location = new Point(20, gPre.Location.Y + gPre.Height + 10);
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    RadioButton r = new RadioButton();
                    r.AutoSize = true;
                    r.Location = new Point(30, 50 + j * 30);
                    switch (j + 1)
                    {
                        case 1: r.Text = listQuestion[i].Anser1; break;
                        case 2: r.Text = listQuestion[i].Anser2; break;
                        case 3: r.Text = listQuestion[i].Anser3; break;
                        case 4: r.Text = listQuestion[i].Anser4; break;
                    }
                    groupBox.Controls.Add(r);
                }

                // <<< THAY ĐỔI: Thêm GroupBox vào panelQuestions, không phải 'this'
                panelQuestions.Controls.Add(groupBox);
            }
        }
        public void ReadQuestion()
        {
            listQuestion.Clear();
            string filePath = @"Cauhoi.txt";
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("File Cauhoi.txt không tồn tại trong thư mục chương trình.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 6)
                {
                    Question q = new Question();
                    q.Title = parts[0];
                    q.Anser1 = $"A." + parts[1];
                    q.Anser2 = $"B." + parts[2];
                    q.Anser3 = $"C." + parts[3];
                    q.Anser4 = $"D." + parts[4];
                    q.Result = parts[5];
                    listQuestion.Add(q);
                }
            }
        }

    }
}