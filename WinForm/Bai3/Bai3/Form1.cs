using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Bai3
{
    public partial class baitap03 : Form
    {
        public baitap03()
        {
            InitializeComponent();
        }
        private void nhapso()
        {
            if (int.TryParse(txtSo.Text, out int number))
            {
                cboSo.Items.Add(txtSo.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 1 số ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.txtSo.Clear();
            this.txtSo.Focus();
        }

        private void button1_Click(object sender, EventArgs e) {nhapso();}
        private void txtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { nhapso();}
        }
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            if (cboSo.SelectedItem != null && int.TryParse(cboSo.SelectedItem.ToString(), out int selectedNumber))
            {
                for (int i = 1; i <= selectedNumber; i++)
                {
                    if (selectedNumber % i == 0)
                    {
                        lstTinh.Items.Add(i);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstTinh.Items)
            {
                if (int.TryParse(item.ToString(), out int divisor))
                {
                    sum += divisor;
                }
            }
            MessageBox.Show("Tổng các ước số là: " + sum, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // dem sluong uoc chan
            int i = 0;
            foreach (var item in lstTinh.Items)
            {
                if (int.TryParse(item.ToString(), out int divisor) && divisor % 2 == 0)
                {
                    i++;
                }
            }
            MessageBox.Show("Số lượng ước số chẵn là: " + i, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ktra la so ngto
            bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
            // dem sluong uoc so ngto
            int count = 0;
            foreach (var item in lstTinh.Items)
            {
                if (int.TryParse(item.ToString(), out int divisor))
                {
                    if (IsPrime(divisor))
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("Số lượng ước số nguyên tố là: " + count, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
