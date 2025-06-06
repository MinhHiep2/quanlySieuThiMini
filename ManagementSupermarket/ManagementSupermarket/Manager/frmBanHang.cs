﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.ListViewItem;
using System.Windows.Documents;
using System.Windows.Controls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Windows.Media.Animation;
using System.Diagnostics;
using System.Security.Permissions;
using ComboBox = System.Windows.Forms.ComboBox;
using ManagementSupermarket.Manager;
using Button = System.Windows.Forms.Button;
using Image = System.Drawing.Image;
using System.IO;
using System.Windows.Media.Media3D;
using System.Text.RegularExpressions;
using System.Globalization;
using Panel = System.Windows.Forms.Panel;
using Label = System.Windows.Forms.Label;
using NUnit.Framework.Internal.Execution;

namespace ManagementSupermarket
{
    public partial class frmBanHang : Form
    {
        private string s_idEmployee;
        private string s_role;
        private decimal TotalMoney = 0;
        private string nameForm = "Form Order";
        public frmBanHang(string idEmployee)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.s_idEmployee = idEmployee;

        }
        
        public frmBanHang(string idEmployee, string role)
        {
            InitializeComponent();
            this.s_idEmployee = idEmployee;
            this.s_role = role;            
        }  
  
        Event eventConfig = new Event();
        public static string formatPrice(decimal price, string unit = "VNĐ")
        {
            if (price >= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            else if (price <= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            return Convert.ToInt64(price).ToString() + $" {unit}";
        }
       

        private void txt_CashCustomerCreate_TextChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void txt_CashCustomerCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        //LOAD DATA COMBO BOX
        private void LoadComboBoxSearch()
        {

            object[] nameSearch;
            object[] idSearch;

            if (s_role == "NV")
            {
                nameSearch = new object[] { "Mã HD" };
                idSearch = new object[] { "MaHD" };
            }
            else
            {
                nameSearch = new object[] { "Mã NV", "Mã HD" };
                idSearch = new object[] { "MaNV", "MaHD" };
            }
            DataTable tblSearch = new DataTable();
            tblSearch.Columns.Add("NoiDungTimKiem");
            tblSearch.Columns.Add("MaTimKiem");

            for (int i = 0; i < nameSearch.Length; i++)
            {
                DataRow newRow = tblSearch.NewRow();
                newRow["NoiDungTimKiem"] = nameSearch[i];
                newRow["MaTimKiem"] = idSearch[i];
                tblSearch.Rows.Add(newRow);
            }

            cbo_Search.DataSource = tblSearch;
            cbo_Search.ValueMember = "MaTimKiem";
            cbo_Search.DisplayMember = "NoiDungTimKiem";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int count = (int)num_CountProductCreate.Value;
                if (count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng ít nhất là 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (ErrorProductInWarehouse())
                {
                    return;
                }

                lbl_ErrorCashCustomer.Visible = false;

                string idProduct, idDiscount, nameProduct;
                float price, discount, amount;

                idProduct = cbo_NameProductCreate.SelectedValue.ToString();
                nameProduct = cbo_NameProductCreate.Text;
                price = float.Parse(txt_PriceCreate.Text);


                idDiscount = cbo_DiscountCreate.SelectedValue?.ToString();

                //Discount price use to show user. Don't Insert Database. Insert Database is Id Discount
                if (string.IsNullOrEmpty(idDiscount) == false)
                {
                    DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", idDiscount);
                    string value = tblDiscount.Rows[0]["GiaKhuyenMai"].ToString();
                    discount = float.Parse(value);
                    amount = price * count * (1 - discount);
                }
                else
                {
                    discount = 0;
                    amount = price * count;
                }

                ListViewItem item = new ListViewItem(idProduct);
                item.Name = idProduct;
                item.SubItems.Add(nameProduct);
                item.SubItems.Add(count.ToString());
                item.SubItems.Add(price.ToString());
                item.SubItems.Add(idDiscount);
                item.SubItems.Add($"{discount * 100}%");
                item.SubItems.Add(amount.ToString());

                //Check If have product, sum Product old and new
                int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                if (indexItemExist >= 0)
                {
                    ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;
                    int newCount = int.Parse(subItem[2].Text) + count;
                    float newAmount = float.Parse(subItem[6].Text) + amount;

                    lst_OrderCurrency.Items[indexItemExist].SubItems[2].Text = newCount.ToString();
                    lst_OrderCurrency.Items[indexItemExist].SubItems[6].Text = newAmount.ToString();
                }
                else
                {
                    lst_OrderCurrency.Items.Add(item);
                }
                this.TotalMoney += (decimal)amount;
                txt_TotalCashCreate.Text = formatPrice(this.TotalMoney);
                CapNhatTien();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                int count = (int)num_CountProductCreate.Value;
                if (count < 1)
                {
                    btn_Delete_Click(sender, e);
                }
                else if (ErrorProductInWarehouse())
                {
                    return;
                }

                lbl_ErrorCashCustomer.Visible = false;

                string idProduct, idDiscount, nameProduct;
                float price, discount, amount;

                idProduct = cbo_NameProductCreate.SelectedValue.ToString();
                nameProduct = cbo_NameProductCreate.Text;
                price = float.Parse(txt_PriceCreate.Text);


                idDiscount = cbo_DiscountCreate.SelectedValue?.ToString();
                DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", idDiscount);

                //Discount price use to show user. Don't Insert Database. Insert Database is Id Discount
                if (tblDiscount.Rows.Count > 0)
                {
                    string value = tblDiscount.Rows[0]["GiaKhuyenMai"].ToString();
                    discount = 1 - float.Parse(value);
                    amount = price * count * discount;
                }
                else
                {
                    discount = 0;
                    amount = price * count;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin bán hàng của {nameProduct}??", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                    if (indexItemExist >= 0)
                    {
                        ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;

                        this.TotalMoney = TotalMoney - (decimal)((int.Parse(subItem[2].Text) - count) * price * (discount == 0 ? 1 : discount));

                        subItem[2].Text = count.ToString();
                        subItem[3].Text = price.ToString();
                        subItem[5].Text = $"{discount * 100}%";
                        subItem[6].Text = amount.ToString();

                        //Set Total Money after update Product
                        MessageBox.Show($"Chỉnh sửa thông tin {nameProduct} thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Có lõi trong quá trình chỉnh sửa thông tin {nameProduct}. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    txt_TotalCashCreate.Text = formatPrice(this.TotalMoney);
                    CapNhatTien();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        //ham xoa di nhung ky tu và chữ không cần thiết
        //Ex: "1.000.000 VNĐ" => "1000000"
        private string moneyToNumber(string money)
        {
            return Regex.Replace(money, @"[^0-9]", "");
        }
        //ham kiem tra xem so tien khach dua co hop le hay khong
        private bool ErrorMoneyCashCustomer()
        {
            bool cashEmpty = string.IsNullOrEmpty(txt_CashCustomerCreate.Text.Trim());
            double cash = 0;
            if (cashEmpty == false)
            {
                cash = double.Parse(txt_CashCustomerCreate.Text);
            }
            bool errMoney = cash < double.Parse(moneyToNumber(txt_TotalCashCreate.Text));
            if (cashEmpty)
            {
                lbl_ErrorCashCustomer.Text = "*Vui lòng nhập tiền của khách hàng!";
                lbl_ErrorCashCustomer.Visible = true;
                return true;
            }
            else if (errMoney)
            {
                lbl_ErrorCashCustomer.Text = "*Tiền của khách hàng phải \n lớn hơn hoặc bằng tổng đơn hàng!";
                lbl_ErrorCashCustomer.Visible = true;
                return true;
            }
            return false;
        }
        private void CapNhatTien()
        {
            try
            {
                decimal cashCustomer = decimal.Parse(txt_CashCustomerCreate.Text == "" ? "0" : txt_CashCustomerCreate.Text);
                decimal total = decimal.Parse(moneyToNumber(txt_TotalCashCreate.Text));
                decimal changeMoney = cashCustomer - total;
                txt_ChangeCreate.Text = formatPrice(changeMoney);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void LoadDataComboBox_NameProduct(ComboBox cbbProduct)
        {
            cbbProduct.DataSource = (new BLL_Product()).GetProduct("MaSP");

            cbbProduct.DisplayMember = "TenSP";
            cbbProduct.ValueMember = "MaSP";

            if (cbbProduct.Items.Count > 0)
            {
                cbbProduct.SelectedIndex = -1;
            }
        }

        private void LoadDataComboBox_Discount(ComboBox cbbDiscount)
        {
            cbbDiscount.DataSource = (new BLL_Discount()).GetDiscountToday();

            cbbDiscount.DisplayMember = "TenKM";
            cbbDiscount.ValueMember = "MaKM";

            if (cbbDiscount.Items.Count > 0)
            {
                cbbDiscount.SelectedIndex = 0;
            }
        }
         private void LoadDataGridView_InvoiceSelling()
        {
            string idEmployee = null;
            if (s_role == "NV")
            {
                idEmployee = this.s_idEmployee;
            }
            dgv_InvoiceSelling.DataSource = (new BLL_InvoiceSelling()).GetInvoiceSelling("MaNV", idEmployee);
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
        }

        private void lst_OrderCurrency_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_OrderCurrency.SelectedItems.Count > 0)
                {

                    ListViewSubItemCollection itemSelected = lst_OrderCurrency.SelectedItems[0].SubItems;

                    cbo_NameProductCreate.Text = itemSelected[1].Text;

                    DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", itemSelected[4].Text);
                    bool issetNameDiscount = tblDiscount.Rows.Count > 0;
                    if (issetNameDiscount)
                    {
                        cbo_DiscountCreate.Text = tblDiscount.Rows[0]["TenKM"].ToString();
                    }
                    else
                    {
                        cbo_DiscountCreate.Text = "";
                    }
                    num_CountProductCreate.Text = itemSelected[2].Text;
                    txt_PriceCreate.Text = itemSelected[3].Text;
                    txt_AmountCreate.Text = itemSelected[6].Text;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
             private void ClearControl()
             {

                cbo_NameProductCreate.SelectedIndex = 0;
                num_CountProductCreate.Value = 0;
                txt_PriceCreate.Text = "0";
                if (cbo_DiscountCreate.Items.Count > 0)
                {
                    cbo_DiscountCreate.SelectedIndex = 0;
                }
                txt_AmountCreate.Clear();
                chk_PhoneCustomer.Checked = false;
                txt_ChangeCreate.Text = "0";
                txt_TotalCashCreate.Text = "0";
                lst_OrderCurrency.Items.Clear();

                txtSearch.Clear();
                txt_CashCustomerCreate.Clear();
                txt_ProductInWarehouse.Clear();
                txt_PhoneCustomerCreate.Clear();

                this.TotalMoney = 0;
             }


        private void cbo_NameProductCreate_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                string idProduct = cbo_NameProductCreate.SelectedValue.ToString();
                txt_PriceCreate.Text = (new BLL_Product()).GetProduct("MaSP", idProduct).Rows[0]["GiaBan"].ToString();
                txt_ProductInWarehouse.Text = (new BLL_Product()).GetProduct("MaSP", idProduct).Rows[0]["SoLuong"].ToString() ?? "0";
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //BLL_ManagementError.InsertError(err.Message, nameForm + " - Thay đổi combobox - Create Bill");
            }
        }
      
        private bool ErrorProductInWarehouse()
        {
            if (num_CountProductCreate.Value > decimal.Parse(txt_ProductInWarehouse.Text))
            {
                string mess = $"Số lượng sản phẩm {cbo_NameProductCreate.Text} trong kho ít hơn số lượng khách hàng mua!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }
            return false;
        }

        private void num_CountProductCreate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_AmountCreate.Text = (num_CountProductCreate.Value * decimal.Parse(txt_PriceCreate.Text)).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string idProduct = cbo_NameProductCreate.SelectedValue.ToString();
                string nameProduct = cbo_NameProductCreate.Text;

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn xoá sản phẩm {nameProduct} khỏi giỏ hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                    if (indexItemExist >= 0)
                    {
                        this.TotalMoney = this.TotalMoney - decimal.Parse(lst_OrderCurrency.Items[indexItemExist].SubItems[6].Text);
                        lst_OrderCurrency.Items.RemoveAt(indexItemExist);

                        MessageBox.Show($"Xoá sản phẩm {nameProduct} khỏi giỏ hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Có lõi trong quá trình xoá {nameProduct}. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    txt_TotalCashCreate.Text = formatPrice(this.TotalMoney);
                    CapNhatTien();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txt_PhoneCustomerCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void btn_RefreshCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới hoá đơn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ClearControl();
                LoadDataComboBox_NameProduct(cbo_NameProductCreate);
                LoadDataComboBox_Discount(cbo_DiscountCreate);
                LoadDataGridView_InvoiceSelling();
            }
        }

        private void chk_PhoneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PhoneCustomer.Checked == true)
            {
                txt_PhoneCustomerCreate.Enabled = true;
                txt_PhoneCustomerCreate.BackColor = Color.White;
            }
            else
            {
                txt_PhoneCustomerCreate.Enabled = false;
                txt_PhoneCustomerCreate.BackColor = Color.Gray;
            }
        }

        private void btn_ShowDetailInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_InvoiceSelling.SelectedRows.Count > 0)
                {
                    DataGridViewRow rowSelected = dgv_InvoiceSelling.SelectedRows[0];
                    string idInvoice = rowSelected.Cells["MaHD"].Value.ToString();
                    string idEmployee = rowSelected.Cells["MaNV"].Value.ToString();
                    string nameEmployee = (new BLL_Employee()).GetEmployeeTo("MaNV", idEmployee).Rows[0]["HoTen"].ToString();
                    string idCustomer = rowSelected.Cells["MaKH"].Value.ToString();
                    DateTime createdTime = (DateTime)rowSelected.Cells["NgayLapHD"].Value;

                    idCustomer = string.IsNullOrEmpty(idCustomer) ? "" : idCustomer;
                    string nameCustomer = "";
                    if (idCustomer != "")
                    {
                        nameCustomer = (new BLL_Customer()).GetCustomerTo("MaKH", idCustomer).Rows[0]["HoTen"].ToString();
                    }
                    double totalCash = double.Parse(rowSelected.Cells["TongTien"].Value.ToString());
                    frmHoaDonBanHang frmDetail = new frmHoaDonBanHang(idInvoice, nameEmployee, createdTime, nameCustomer, totalCash);
                    frmDetail.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (s_role == "NV")
            {
                dgv_InvoiceSelling.DataSource = (new BLL_InvoiceSelling()).GetInvoiceSellingToEmployee(s_idEmployee, cbo_Search.SelectedValue.ToString(), txtSearch.Text);
            }
            else
            {
                dgv_InvoiceSelling.DataSource = (new BLL_InvoiceSelling()).GetInvoiceSelling(cbo_Search.SelectedValue.ToString(), txtSearch.Text);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cbo_Search.SelectedIndex = 0;
            txtSearch.Clear();
            LoadDataGridView_InvoiceSelling();

        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tblInvoiceSelling = (DataTable)dgv_InvoiceSelling.DataSource;
                ConfigExcel_PDF.ExportToExcel(tblInvoiceSelling, $"Invoice Selling");
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //BLL_ManagementError.InsertError(err.Message, nameForm + " - Nút xuất file Excel");
            }
        }

        private void btn_ExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_InvoiceSelling.SelectedRows.Count > 0)
                {
                    DataGridViewRow rowSelected = dgv_InvoiceSelling.SelectedRows[0];

                    string idInvoice, idEmployee, idCustomer;
                    double total, cash;

                    idInvoice = rowSelected.Cells["MaHD"].Value.ToString();
                    idEmployee = rowSelected.Cells["MaNV"].Value.ToString();
                    idCustomer = rowSelected.Cells["MaKH"].Value.ToString();
                    total = double.Parse(rowSelected.Cells["TongTien"].Value.ToString());
                    cash = double.Parse(rowSelected.Cells["TienKhachDua"].Value.ToString());

                    DTO_InvoiceSelling bill = new DTO_InvoiceSelling(idEmployee, total, cash, idCustomer, idInvoice);
                    if (ConfigExcel_PDF.PrintInvoicePDF(bill))
                    {
                        MessageBox.Show($"In hoá đơn {idInvoice} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show($"In hoá đơn {idInvoice} thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void num_CountProductCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_FinishOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbl_ErrorCashCustomer.Visible = false;
                lbl_ErrorPhone.Visible = false;
                if (lst_OrderCurrency.Items.Count <= 0)
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm trước khi lập hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (ErrorMoneyCashCustomer())
                {
                    return;
                }


                string idInvoice, idProduct, idDiscount, idEmployee, idCustomer = null, phone;
                float price, totalMoney, cashCustomer;
                int countProduct;

                //Process: Insert Invoice => Get Id Invoice => Check Condition Insert Invoice => Before Use Loop To Insert Detail Invoice

                //@MaNV varchar(10),
                //@MaKH varchar(10) = null,
                //@TongTien decimal,
                //@TienKhachDua decimal = 0
                //var dt = new BLL_Employee().GetEmployeeTo("MaNV", s_idEmployee);
                idEmployee = this.s_idEmployee;
                if (string.IsNullOrEmpty(idEmployee))
                    MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo");

                if (chk_PhoneCustomer.Checked)
                {
                    phone = txt_PhoneCustomerCreate.Text.Trim();
                    DataTable tblCustomer = (new BLL_Customer()).GetCustomerToPhone(phone);
                    if (tblCustomer.Rows.Count > 0)
                    {
                        idCustomer = tblCustomer.Rows[0]["MaKH"].ToString();

                    }
                    else
                    {
                        lbl_ErrorPhone.Text = "*Số điện thoại khách hàng không tồn tại!";
                        lbl_ErrorPhone.Visible = true;
                        return;
                    }
                }

                totalMoney = (float)this.TotalMoney;

                cashCustomer = string.IsNullOrEmpty(txt_CashCustomerCreate.Text) ? 0 : float.Parse(txt_CashCustomerCreate.Text);

                DialogResult result = MessageBox.Show("Xác nhận lập hoá đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DTO_InvoiceSelling invoiceSelling = new DTO_InvoiceSelling(idEmployee, totalMoney, cashCustomer, idCustomer);
                    idInvoice = (new BLL_InvoiceSelling()).InsertInvoiceSelling(invoiceSelling).Rows[0][0].ToString();
                    //FINISH INSERT INVOICE

                    int countInsertDetail = 0;
                    foreach (ListViewItem row in lst_OrderCurrency.Items)
                    {
                        idProduct = row.SubItems[0].Text;
                        countProduct = int.Parse(row.SubItems[2].Text);
                        idDiscount = string.IsNullOrEmpty(row.SubItems[4].Text) ? null : row.SubItems[4].Text;

                        countInsertDetail += countProduct;

                        price = int.Parse(row.SubItems[3].Text);

                        DTO_Detail_InvoiceSelling detailInvoice = new DTO_Detail_InvoiceSelling(idInvoice, idProduct, idDiscount, countProduct, price);
                        int numOfRows = (new BLL_Detail_InvoiceSelling()).InsertDetailInvoiceSelling(detailInvoice);
                        if (numOfRows > 0)
                        {
                            countInsertDetail++;
                        }
                    }

                    if (countInsertDetail > 0)
                    {
                        MessageBox.Show($"Đã bán {countInsertDetail} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = MessageBox.Show("Bạn có muốn in PDF hoá đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            invoiceSelling.Dt_CreatedTime = DateTime.Now;

                            invoiceSelling.S_IdInvoice = idInvoice;
                            if (ConfigExcel_PDF.PrintInvoicePDF(invoiceSelling))
                            {
                                MessageBox.Show($"Xuất PDF hoá đơn {idInvoice} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        btn_RefreshCreate_Click(sender, e);
                        return;
                    }
                    MessageBox.Show($"Xảy ra sai sót trong quá trình bán hàng. Vui lòng thử lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            tab_HomeInvoiceSelling.SelectedIndex = 0;
            try
            {
                //LOAD DATA TAB 1
                LoadDataComboBox_NameProduct(cbo_NameProductCreate);
                LoadDataComboBox_Discount(cbo_DiscountCreate);

                //LOAD DATA TAB 2
                LoadDataGridView_InvoiceSelling();
                LoadComboBoxSearch();
                cbo_Search.SelectedIndex = 0;

                //LoadButtonProduct(Panel_Product);
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
