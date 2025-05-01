using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
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
            string username = txt_Username.Text.Trim(), password = txt_Password.Text.Trim();

            //Process if username or password empty
            bool isEmpty = string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password);

            BLL_Account account= new BLL_Account();
            DataTable tblAccount = account.IsAccount(username, password);
            bool isNotAccount = true;

            if (tblAccount.Rows.Count > 0)
            {
                isNotAccount = false;
            }

            if (isEmpty || isNotAccount)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "*Tài khoản hoặc mật khẩu không chính xác";
            }
            else
            {
                string role = tblAccount.Rows[0][1].ToString();
                string idEmployee = txt_Username.Text.Trim();
                frmHomeOfManager frmHomeOfManager = new frmHomeOfManager(idEmployee, role);
                this.Hide();
                frmHomeOfManager.Show();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với phần mềm quản lý siêu thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
