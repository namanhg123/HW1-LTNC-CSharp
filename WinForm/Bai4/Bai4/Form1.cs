namespace Bai4
{
    public partial class baitap4 : Form
    {
        public baitap4()
        {
            InitializeComponent();
            txtSo1.TextChanged += XuLyTinhToan;
            txtSo2.TextChanged += XuLyTinhToan;
            radCong.CheckedChanged += XuLyTinhToan;
            radTru.CheckedChanged += XuLyTinhToan;
            radNhan.CheckedChanged += XuLyTinhToan;
            radChia.CheckedChanged += XuLyTinhToan;

        }


        private void XuLyTinhToan(object sender, EventArgs e)
        {
            double so1, so2, kq = 0;

            // Kiểm tra nhập liệu
            if (!double.TryParse(txtSo1.Text, out so1) || !double.TryParse(txtSo2.Text, out so2))
            {
                txtKQ.Text = "";
                return;
            }

            // Tính toán theo phép chọn
            if (radCong.Checked) kq = so1 + so2;
            else if (radTru.Checked) kq = so1 - so2;
            else if (radNhan.Checked) kq = so1 * so2;
            else if (radChia.Checked)
            {
                if (so2 == 0)
                {
                    txtKQ.Text = "Lỗi chia 0";
                    return;
                }
                kq = so1 / so2;
            }

            txtKQ.Text = kq.ToString();
        }
    }
}
