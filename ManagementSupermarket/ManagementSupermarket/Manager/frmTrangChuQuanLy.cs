using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;
using BLL;
using DTO;
using ManagementSupermarket.Manager;
namespace ManagementSupermarket
{
    public partial class frmTrangChuQuanLy : Form
    {
        private string s_role;
        private string s_idEmployee;
        private Form frmChild;
        private object buttonCurrency = "-1";
        private IconButton lastClickedButton;
        public frmTrangChuQuanLy(string idEmployee, string role)
        {
            s_idEmployee = idEmployee;
            s_role = role;
            InitializeComponent();
           
        }
        private void RoleAccess()
        {
            if (s_role == "NV")
            {
                btnAccounts.Visible = false;
                btnProducts.Visible = false;
                btnKhoHang.Visible = false;
                btnNhanVien.Visible = false;
                btnNhaCungCap.Visible = false;
                btnLoaiSanPham.Visible = false;
                btnKhuyenMai.Visible = false;
                btnThongKe.Visible = false;                
            }
        }
       
        private void OpenfrmChild(Form Child, IconButton btn)
        {
            if (buttonCurrency == btn.Tag)
            {
                return;
            }

            buttonCurrency = btn.Tag;

            if (frmChild != null)
            {
                frmChild.Close();
            }
            frmChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(Child);
            panel_body.Tag = Child;
            Child.BringToFront();
            Child.Show();

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.FromArgb(200, 200, 200);
                lastClickedButton.ForeColor = Color.Black;
                lastClickedButton.IconColor = Color.Black;
            }
            IconButton clickedButton = btn;
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.FromArgb(57, 65, 107);
                clickedButton.ForeColor = Color.Yellow;
                clickedButton.IconColor = Color.White;
                // Lưu trữ tham chiếu của nút mới được nhấn vào biến theo dõi
                lastClickedButton = clickedButton;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            IconButton banhang = sender as IconButton;
            OpenfrmChild(new frmBanHang(s_idEmployee,s_role), banhang);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            IconButton account = sender as IconButton;
            OpenfrmChild(new frmTaiKhoan(s_idEmployee, s_role), account);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            IconButton khohang = sender as IconButton;
            OpenfrmChild(new frmKhoHang(s_idEmployee), khohang);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            IconButton information = sender as IconButton;
            OpenfrmChild(new frmInfomation(s_idEmployee), information);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            IconButton contact = sender as IconButton;
            OpenfrmChild(new frmThongTinLienHe(), contact);
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            IconButton loaisanpham = sender as IconButton;
            OpenfrmChild(new frmLoaiSanPham(), loaisanpham);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            IconButton nhacungcap = sender as IconButton;
            OpenfrmChild(new frmNhaCungCap(), nhacungcap);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            IconButton khachhang = sender as IconButton;
            OpenfrmChild(new frmKhachHang(), khachhang);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            IconButton khuyenmai = sender as IconButton;
            OpenfrmChild(new frmGiamGia(), khuyenmai);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            IconButton thongke = sender as IconButton;
            OpenfrmChild(new frmThongKe(), thongke);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            IconButton icon = sender as IconButton;
            OpenfrmChild(new frmChangePassword(s_idEmployee), icon);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmHomeOfManager_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            IconButton nhanvien = sender as IconButton;
            OpenfrmChild(new frmQuanLyNhanVien(), nhanvien);
             
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            IconButton sanpham = sender as IconButton;
            OpenfrmChild(new frmQLSanPham(), sanpham);
        }

        private void ptbAnhDaiDien_Click(object sender, EventArgs e)
        {
            
        }

        private void frmHomeOfManager_Load_1(object sender, EventArgs e)
        {

            RoleAccess();
            var dt = new BLL_Employee().GetEmployeeTo("MaNV", s_idEmployee);
            if (dt.Rows.Count > 0)
            {
                // Thử kiểm tra tên cột
                var row = dt.Rows[0];

                if (dt.Columns.Contains("HoTen"))
                    lblName.Text = row["HoTen"].ToString();
                else if (dt.Columns.Contains("Ten"))
                    lblName.Text = row["Ten"].ToString();
                else
                    lblName.Text = "Không tìm thấy cột tên";


            }
            else
            {
                lblName.Text = "Không tìm thấy nhân viên!";
            }
        }

        
    }
}
