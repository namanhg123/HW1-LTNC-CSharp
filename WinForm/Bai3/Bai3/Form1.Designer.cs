namespace Bai3
{
    partial class baitap03
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
            txtSo = new TextBox();
            cboSo = new ComboBox();
            lstTinh = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 22);
            label2.TabIndex = 1;
            label2.Text = "Danh sách các ước số";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(32, 79);
            txtSo.Margin = new Padding(4, 3, 4, 3);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(170, 30);
            txtSo.TabIndex = 2;
            txtSo.KeyDown += txtSo_KeyDown;
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(32, 133);
            cboSo.Margin = new Padding(4, 3, 4, 3);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(227, 30);
            cboSo.TabIndex = 3;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // lstTinh
            // 
            lstTinh.FormattingEnabled = true;
            lstTinh.ItemHeight = 22;
            lstTinh.Location = new Point(404, 68);
            lstTinh.Margin = new Padding(4, 3, 4, 3);
            lstTinh.Name = "lstTinh";
            lstTinh.Size = new Size(222, 114);
            lstTinh.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(227, 79);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 5;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 358);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 32);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 209);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(255, 42);
            button3.TabIndex = 7;
            button3.Text = "Tổng các ước số";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(395, 272);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(255, 42);
            button4.TabIndex = 8;
            button4.Text = "Số lượng các ước số chẵn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(395, 333);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(255, 42);
            button5.TabIndex = 9;
            button5.Text = "Số lượng các ước số nguyên tố";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // baitap03
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 420);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstTinh);
            Controls.Add(cboSo);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "baitap03";
            Text = "Combobox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo;
        private ComboBox cboSo;
        private ListBox lstTinh;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
