using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhVanDong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;


            if (username == "Quandm" && password == "123123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                Maincs form = new Maincs();
                form.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            txtPass.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
