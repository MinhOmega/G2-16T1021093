using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2
{
    public partial class frmTinhToanCoBan : Form
    {
        public frmTinhToanCoBan()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                float temp = 0;
                if (!float.TryParse(txtA.Text, out temp)) // out nay giong dau &
                {
                    errorProvider.SetError(txtA, "Vui lòng nhập lại giá trị a");
                    return;
                }
                var a = float.Parse(txtA.Text); //kieu var thi ben phai gia tri gi thi ben trai gia tri nhu vay

                if (!float.TryParse(txtB.Text, out temp)) 
                {
                    MessageBox.Show("Lỗi rồi vui lòng nhập lại giá trị b");
                    return;
                }
                
                var b = float.Parse(txtB.Text);
                var c = a + b;
                string data = String.Format("{0} + {1} = {2}", a, b, c);
                MessageBox.Show(data, "kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi rồi, chi tiết lỗi : " + ex.Message);
            }
        }
    }
}
