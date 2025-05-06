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

namespace ManagementSupermarket.Manager
{
    public partial class frmHoaDonNhapKho : Form
    {
        public frmHoaDonNhapKho()
        {
            InitializeComponent();
            
        }
      
        // Khai báo các thuộc tính để lưu trữ giá trị từ Form kho hàng
        public string MaNhapKho { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhaCungCap { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public string TongTien { get; set; }
      
       
        private void LoadDetailInvoice(string maNhapKho)
        {
            // Sử dụng mã nhập kho để truy vấn và lấy chi tiết hóa đơn từ cơ sở dữ liệu
            DataTable detailInvoice = (new BLL_Detail_InvoiceWarehouse()).GetDetailInvoiceImportWareHouse("MaNK", maNhapKho);

            // Hiển thị chi tiết hóa đơn trong DataGridView
            dgv_DetailWarehouse.DataSource = detailInvoice;
            
        }

        private void frmDetailWarehouse_Load_1(object sender, EventArgs e)
        {
            // Gán các giá trị từ các thuộc tính vào các Label tương ứng
            LoadDetailInvoice(MaNhapKho);
            lbl_idReceive.Text = MaNhapKho;
            lbl_idEmployee.Text = MaNhanVien;
            lbl_NameSuppiler.Text = TenNhaCungCap;
            lbl_CreateTime.Text = NgayNhapKho.ToString("dd/MM/yyyy hh:mm:ss tt");
            lbl_TotalCash.Text = TongTien;

        }
    }
}
