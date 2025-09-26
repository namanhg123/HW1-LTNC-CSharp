namespace Bai1
{
    public partial class Baitap01 : Form
    {
        public Baitap01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){ }
        private void label2_Click(object sender, EventArgs e){ }

        private void textBox1_TextChanged(object sender, EventArgs e){ }

        private void textBox3_TextChanged(object sender, EventArgs e){ }

        private void textBox4_TextChanged(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true) { thongbao += "\n\rBạn đã chọn nhớ mật khẩu"; }
            else { thongbao += "\n\rBạn không chọn nhớ mật khẩu"; }
            MessageBox.Show(thongbao, "Thông báo");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
