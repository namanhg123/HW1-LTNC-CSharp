namespace Bai4
{
    partial class baitap4
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
            label3 = new Label();
            label4 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKQ = new TextBox();
            radCong = new RadioButton();
            radTru = new RadioButton();
            radNhan = new RadioButton();
            radChia = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Số 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 96);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Số 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 342);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Phép tính";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(216, 42);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(180, 27);
            txtSo1.TabIndex = 4;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(216, 96);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(180, 27);
            txtSo2.TabIndex = 5;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(216, 339);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(180, 27);
            txtKQ.TabIndex = 6;
            // 
            // radCong
            // 
            radCong.AutoSize = true;
            radCong.Location = new Point(157, 231);
            radCong.Name = "radCong";
            radCong.Size = new Size(65, 24);
            radCong.TabIndex = 7;
            radCong.TabStop = true;
            radCong.Text = "Cộng";
            radCong.UseVisualStyleBackColor = true;
            // 
            // radTru
            // 
            radTru.AutoSize = true;
            radTru.Location = new Point(291, 231);
            radTru.Name = "radTru";
            radTru.Size = new Size(51, 24);
            radTru.TabIndex = 8;
            radTru.TabStop = true;
            radTru.Text = "Trừ";
            radTru.UseVisualStyleBackColor = true;
            // 
            // radNhan
            // 
            radNhan.AutoSize = true;
            radNhan.Location = new Point(409, 231);
            radNhan.Name = "radNhan";
            radNhan.Size = new Size(65, 24);
            radNhan.TabIndex = 9;
            radNhan.TabStop = true;
            radNhan.Text = "Nhân";
            radNhan.UseVisualStyleBackColor = true;
            // 
            // radChia
            // 
            radChia.AutoSize = true;
            radChia.Location = new Point(520, 231);
            radChia.Name = "radChia";
            radChia.Size = new Size(59, 24);
            radChia.TabIndex = 10;
            radChia.TabStop = true;
            radChia.Text = "Chia";
            radChia.UseVisualStyleBackColor = true;
            // 
            // baitap4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 406);
            Controls.Add(radChia);
            Controls.Add(radNhan);
            Controls.Add(radTru);
            Controls.Add(radCong);
            Controls.Add(txtKQ);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "baitap4";
            Text = "Phép Tính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKQ;
        private RadioButton radCong;
        private RadioButton radTru;
        private RadioButton radNhan;
        private RadioButton radChia;
    }
}
