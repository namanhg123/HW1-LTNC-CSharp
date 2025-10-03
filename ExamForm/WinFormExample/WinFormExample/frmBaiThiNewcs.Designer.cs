namespace WinFormExample
{
    partial class frmBaiThiNewcs
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            butLamBai = new Button();
            panel1 = new Panel();
            panelQuestions = new Panel();
            CButton = new Button();
            CLabel = new Label();
            panel1.SuspendLayout();
            panelQuestions.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(290, 9);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(51, 20);
            lblTime.TabIndex = 0;
            lblTime.Text = "label1";
            lblTime.Visible = false;
            // 
            // butLamBai
            // 
            butLamBai.Location = new Point(769, 9);
            butLamBai.Margin = new Padding(4, 3, 4, 3);
            butLamBai.Name = "butLamBai";
            butLamBai.Size = new Size(141, 42);
            butLamBai.TabIndex = 0;
            butLamBai.Text = "Làm bài";
            butLamBai.UseVisualStyleBackColor = true;
            butLamBai.Visible = false;
            butLamBai.Click += butLamBai_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(butLamBai);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 60);
            panel1.TabIndex = 1;
            // 
            // panelQuestions
            // 
            panelQuestions.AutoScroll = true;
            panelQuestions.Controls.Add(CButton);
            panelQuestions.Controls.Add(CLabel);
            panelQuestions.Dock = DockStyle.Fill;
            panelQuestions.Location = new Point(0, 60);
            panelQuestions.Margin = new Padding(4, 3, 4, 3);
            panelQuestions.Name = "panelQuestions";
            panelQuestions.Size = new Size(1000, 390);
            panelQuestions.TabIndex = 2;
            // 
            // CButton
            // 
            CButton.Location = new Point(410, 179);
            CButton.Name = "CButton";
            CButton.Size = new Size(105, 51);
            CButton.TabIndex = 1;
            CButton.Text = "Bắt đầu";
            CButton.UseVisualStyleBackColor = true;
            CButton.Click += CButton_Click;
            // 
            // CLabel
            // 
            CLabel.AutoSize = true;
            CLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            CLabel.Location = new Point(290, 118);
            CLabel.Margin = new Padding(4, 0, 4, 0);
            CLabel.Name = "CLabel";
            CLabel.Size = new Size(358, 32);
            CLabel.TabIndex = 0;
            CLabel.Text = "Nhấn nút bắt đầu để làm bài\r\n";
            // 
            // frmBaiThiNewcs
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(panelQuestions);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBaiThiNewcs";
            Text = "frmBaiThiNewcs";
            Load += frmBaiThiNewcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelQuestions.ResumeLayout(false);
            panelQuestions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Button butLamBai;
        private Panel panel1;
        private Panel panelQuestions;
        private Label CLabel;
        private Button CButton;
    }
}
