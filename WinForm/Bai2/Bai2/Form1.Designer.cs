namespace Bai2
{
    partial class baitap02
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            txtHoTen = new TextBox();
            txtKQ = new TextBox();
            btnKQ = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 1;
            label2.Text = "Chọn kiểu chữ";
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(48, 108);
            rad1.Name = "rad1";
            rad1.Size = new Size(119, 26);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(48, 140);
            rad2.Name = "rad2";
            rad2.Size = new Size(146, 26);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(226, 28);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(312, 30);
            txtHoTen.TabIndex = 4;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(226, 189);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(312, 30);
            txtKQ.TabIndex = 5;
            // 
            // btnKQ
            // 
            btnKQ.Location = new Point(48, 189);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(94, 29);
            btnKQ.TabIndex = 6;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(474, 73);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(55, 96);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(226, 73);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(215, 96);
            btnDung.TabIndex = 8;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // baitap02
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(550, 231);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnKQ);
            Controls.Add(txtKQ);
            Controls.Add(txtHoTen);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "baitap02";
            Text = "Đổi kiểu chữ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rad1;
        private RadioButton rad2;
        private TextBox txtHoTen;
        private TextBox txtKQ;
        private Button btnKQ;
        private Button btnXoa;
        private Button btnDung;
    }
}
