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
    public partial class frmHomeOfManager : Form
    {
        private string s_role;
        private string s_idEmployee;
        private Form frmChild;
        private object buttonCurrency = "-1";
        private IconButton lastClickedButton;
        bool sidebarExpand;
        public frmHomeOfManager(string idEmployee, string role)
        {
            s_idEmployee = idEmployee;
            s_role = role;
            InitializeComponent();
        }
        private Form childForm;
        private object numCurrency;
        private void RoleAccess()
        {
            if (s_role == "NV")
            {
                btnAccounts.Visible = false;
                btnBanHang.Visible = false;
                btnProducts.Visible = false;
                btnKhoHang.Visible = false;
                btnNhanVien.Visible = false;
                btnNhaCungCap.Visible = false;
                btnLoaiSanPham.Visible = false;
                btnOut.Visible = false;
                btnKhuyenMai.Visible = false;
                btnThongKe.Visible = false;
                btnInformation.Visible = false;
            }
        }
        private void frmHomeOfManager_Load(object sender, EventArgs e)
        {
           // lblName.Text = (new BLL_Employee()).GetEmployeeTo("MaNV", s_idEmployee).Rows[0]["HoTen"].ToString();

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
            OpenfrmChild(new frmOrder(), banhang);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            IconButton account = sender as IconButton;
            OpenfrmChild(new frmAccounts(s_idEmployee, s_role), account);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            IconButton khohang = sender as IconButton;
            OpenfrmChild(new frmKhoHang(), khohang);
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
            OpenfrmChild(new frmTypeProduct(), loaisanpham);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            IconButton nhacungcap = sender as IconButton;
            OpenfrmChild(new frmSuppiler(), nhacungcap);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            IconButton khachhang = sender as IconButton;
            OpenfrmChild(new frmCustomer(), khachhang);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            IconButton khuyenmai = sender as IconButton;
            OpenfrmChild(new frmDiscount(), khuyenmai);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            IconButton thongke = sender as IconButton;
            OpenfrmChild(new frm_Revenue(), thongke);
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
            OpenfrmChild(new frmManagementEmployees(), nhanvien);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            IconButton sanpham = sender as IconButton;
            OpenfrmChild(new frmManagementProducts(), sanpham);
        }



        //private void CheckProductExpire()
        //{
        //    DataTable tblProduct = (new BLL_Product()).GetProductExpire();

        //    if (tblProduct.Rows.Count > 0)
        //    {
        //        string mess = "Sản phẩm: ";
        //        DataRowCollection rows = tblProduct.Rows;
        //        foreach (DataRow item in rows)
        //        {
        //            mess += $"\n- {item["TenSP"].ToString()} với số lượng {item["SoLuong"].ToString()} đã hết hạn.";
        //        }

        //        DialogResult result = MessageBox.Show($"{mess}\nXác nhận xoá sản phẩm đã hết hạn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        //        if (result == DialogResult.Yes)
        //        {
        //            int count = 0;
        //            foreach (DataRow item in rows)
        //            {
        //                string idImport, idProduct;
        //                idImport = item["MaNK"].ToString();
        //                idProduct = item["MaSP"].ToString();

        //                count += (new BLL_Detail_InvoiceWarehouse()).DeleteProductExpire(idImport, idProduct);
        //            }

        //            if (count > 0)
        //            {
        //                MessageBox.Show($"Đã xoá {count} sản phẩm hết hạn!");
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show($"Xoá sản phẩm hết hạn thất bại !");
        //            }

        //        }
        //    }
        //}
    }
}
