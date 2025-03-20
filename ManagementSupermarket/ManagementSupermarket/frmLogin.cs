using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSupermarket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnHidePassWord_Click(object sender, EventArgs e)
        {
            if (btnHidePassWord.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txt_Password.UseSystemPasswordChar = false;
                btnHidePassWord.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHidePassWord.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txt_Password.UseSystemPasswordChar = true;
                btnHidePassWord.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "admin" && txt_Password.Text == "admin")
            {
                frmLogin frmMain = new frmLogin();
                frmMain.Show();
                this.Hide();
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHidePassWord_Click_1(object sender, EventArgs e)
        {
            if (btnHidePassWord.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txt_Password.UseSystemPasswordChar = false;
                btnHidePassWord.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHidePassWord.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txt_Password.UseSystemPasswordChar = true;
                btnHidePassWord.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
    }
}
