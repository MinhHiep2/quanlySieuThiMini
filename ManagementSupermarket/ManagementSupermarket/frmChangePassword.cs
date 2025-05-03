using BLL;
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
    public partial class frmChangePassword : Form
    {
        private string idEmployee;
        private string nameForm = "Form Change Password";
        BLL_Account account = new BLL_Account();
        Event eventConfig = new Event();
        public frmChangePassword(string id)
        {
            InitializeComponent();
            idEmployee = id;
        }
        private bool TextboxIsNullOrEmpty()
        {
            string oldPassword, newPassword, confirmNewPassword;
            oldPassword = txtMKHienTai.Text.Trim();
            newPassword = txtMKMoi.Text.Trim();
            confirmNewPassword = txtNhapLai.Text.Trim();
            bool IsEmpty = string.IsNullOrEmpty(oldPassword)
                        || string.IsNullOrEmpty(newPassword)
                        || string.IsNullOrEmpty(confirmNewPassword);
            if (IsEmpty)
            {
                return true;
            }
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMKHienTai.Clear();
            txtNhapLai.Clear();
            txtMKMoi.Clear();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword, newPassword, confirmNewPassword;
                oldPassword = txtMKHienTai.Text.Trim();
                newPassword = txtMKMoi.Text.Trim();
                confirmNewPassword = txtNhapLai.Text.Trim();

                bool passwordIsNotSame = string.Compare(newPassword, confirmNewPassword) != 0 ? true : false;

                if (TextboxIsNullOrEmpty())
                {
                    lblError.Visible = true;
                    lblError.Text = "*Vui lòng nhập đầy đủ thông tin";
                    return;
                }

                if (passwordIsNotSame)
                {
                    lblError.Visible = true;
                    lblError.Text = "*Mật khẩu mới và mật khẩu xác nhận khác nhau";
                    return;
                }
                DataTable tblAccount = account.IsAccount(idEmployee, oldPassword);

                if (tblAccount.Rows.Count <= 0)
                {
                    lblError.Text = "*Mật khẩu cũ không chính xác";
                    lblError.Visible = true;
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool finsihUpdate = account.UpdatePasswordAccount(idEmployee, newPassword);
                    if (finsihUpdate)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (btnHidePassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtMKHienTai.UseSystemPasswordChar = false;
                btnHidePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHidePassword.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtMKHienTai.UseSystemPasswordChar = true;
                btnHidePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;


            }
        }

        private void btnHidePassword2_Click(object sender, EventArgs e)
        {
            if (btnHidePassword2.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtMKMoi.UseSystemPasswordChar = false;
                btnHidePassword2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHidePassword2.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtMKMoi.UseSystemPasswordChar = true;
                btnHidePassword2.IconChar = FontAwesome.Sharp.IconChar.Eye;


            }
        }

        private void btnHidePassword3_Click(object sender, EventArgs e)
        {
            if (btnHidePassword3.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtNhapLai.UseSystemPasswordChar = false;
                btnHidePassword3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHidePassword3.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtNhapLai.UseSystemPasswordChar = true;
                btnHidePassword3.IconChar = FontAwesome.Sharp.IconChar.Eye;


            }
        }
    }
}
