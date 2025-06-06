﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using Image = System.Drawing.Image;

namespace ManagementSupermarket
{
    public partial class frmQLSanPham : Form
    {
       
        public frmQLSanPham()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            //AddColumnImageDGV();
            LoadDataGridView(status: chk_ProductStatus.Checked);
            LoadDataComboBox();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
            cbb_UnitCaculator.SelectedIndex = 0;
            cbb_UnitTime.SelectedIndex = 0;
                 
        }
        private string nameForm = "Form Product";
        private void LoadDataComboBoxUnitItem()
        {
            object[] nameUnit = { "Cái", "Hộp", "Lon", "Kg", "Gói", "Chai", "Hủ" };
            cbb_UnitCaculator.Items.AddRange(nameUnit);
            cbb_UnitCaculator.SelectedIndex = 0;
        }
        private void LoadDataComboBoxUnitTime()
        {
            object[] nameUnit = { "Ngày", "Tháng", "Năm" };
            object[] idUnit = { "D", "M", "Y" };
            DataTable tblUnitTime = new DataTable();
            tblUnitTime.Columns.Add("TenNgay");
            tblUnitTime.Columns.Add("MaNgay");

            for (int i = 0; i < nameUnit.Length; i++)
            {
                DataRow newRow = tblUnitTime.NewRow();
                newRow["TenNgay"] = nameUnit[i];
                newRow["MaNgay"] = idUnit[i];
                tblUnitTime.Rows.Add(newRow);
            }

            cbb_UnitTime.DataSource = tblUnitTime;
            cbb_UnitTime.ValueMember = "MaNgay";
            cbb_UnitTime.DisplayMember = "TenNgay";
            cbb_UnitTime.SelectedIndex = 0;
        }
        private void LoadDataComboBox()
        {
            BLL_Supplier dataSupplier = new BLL_Supplier();
            BLL_TypeProduct dataTypeProduct = new BLL_TypeProduct();

            //SUPPLIER
            cbb_Supplier.DataSource = dataSupplier.GetSupplier("TrangThai", "1");
            cbb_Supplier.DisplayMember = "TenNCC";
            cbb_Supplier.ValueMember = "MaNCC";
            //TYPE PRODUCT
            cbb_TypeProduct.DataSource = dataTypeProduct.GetTypeProduct("MaLoaiSP");
            cbb_TypeProduct.DisplayMember = "TenLoai";
            cbb_TypeProduct.ValueMember = "MaLoaiSP";
            //UNIT TIME
            LoadDataComboBoxUnitTime();
            //UNIT ITEM
            LoadDataComboBoxUnitItem();
        }

        private void chk_Status_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView(status: chk_ProductStatus.Checked);
        }
        private void LoadDataGridView(string nameProdut = null, bool? status = null)
        {
            dgv_ListProduct.DataSource = (new BLL_Product()).GetProduct("TenSP", nameProdut, status);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_ListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_ListProduct.SelectedRows.Count > 0)
                {
                    DataGridViewCellCollection rowSelected = dgv_ListProduct.SelectedRows[0].Cells;

                    pic_Product.ImageLocation = Path.Combine(Application.StartupPath, "Image", "Products", rowSelected["HinhAnh"].Value.ToString());

                    txt_ID.Text = rowSelected["MaSP"].Value.ToString();

                    string nameSupplier = rowSelected["TenNCC"].Value.ToString();
                    cbb_Supplier.SelectedIndex = cbb_Supplier.FindString(nameSupplier);


                    txt_NameProduct.Text = rowSelected["TenSP"].Value.ToString();

                    string nameTypeProduct = rowSelected["TenLoai"].Value.ToString();
                    cbb_TypeProduct.SelectedIndex = cbb_TypeProduct.FindString(nameTypeProduct);

                    string unitCaculator = rowSelected["DonViTinh"].Value.ToString();
                    cbb_UnitCaculator.SelectedIndex = cbb_UnitCaculator.FindString(unitCaculator);

                    txt_Cost.Text = rowSelected["GiaNhap"].Value.ToString();
                    txt_Price.Text = rowSelected["GiaBan"].Value.ToString();

                    string date = rowSelected["HanSuDung"].Value.ToString();
                    if (date.Length > 0)
                    {
                        num_ShelfLife.Value = decimal.Parse(date[0].ToString());
                        string unitTime = date[date.Length - 1].ToString();
                        int index = -1;
                        if (unitTime == "D")
                            index = 0;
                        else if (unitTime == "M")
                            index = 1;
                        else if (unitTime == "Y")
                            index = 2;
                        cbb_UnitTime.SelectedIndex = index;
                    }
                    else
                    {
                        num_ShelfLife.Value = 99;
                        cbb_UnitTime.Text = "";
                    }
                    num_Count.Text = rowSelected["SoLuong"].Value.ToString();
                    chk_Status.Checked = (bool)rowSelected["TrangThai"].Value;

                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                DialogResult result = openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fileName))
                {
                    string tmp = fileName;
                    pic_Product.ImageLocation = tmp;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private void CopyImageToFolderProject(string pathImage)
        {
            try
            {
                if (string.IsNullOrEmpty(pathImage))
                {
                    return;
                }
                // Chuỗi bắt đầu để chứa ảnh
                //string destFolder = Path.Combine(Application.StartupPath, "..", "..", "Image", "Products");
                string destFolder = Path.Combine(Application.StartupPath, "Resources", "Image", "Products");
                // Tạo đường dẫn đến nơi chưa ảnh
                string destFileName = Path.Combine(destFolder, Path.GetFileName(pathImage));

                //Nếu chưua có ảnh thì tiến hành copy
                if (!File.Exists(destFileName))
                {
                    File.Copy(pathImage, destFileName);
                }
            }
            catch (Exception )
            {
               // MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        //CHECK ERROR INPUT
        private double emtyToZero_Money(string money)
        {
            if (string.IsNullOrEmpty(money))
            {
                return 0;
            }
            return double.Parse(money);
        }
        private bool IsErrorInput()
        {
            bool errorName = string.IsNullOrEmpty(txt_NameProduct.Text.Trim());
            bool errSupplier = string.IsNullOrEmpty(cbb_Supplier.Text.Trim());
            bool errTypeProduct = string.IsNullOrEmpty(cbb_TypeProduct.Text.Trim());
            string cost = txt_Cost.Text.Trim();
            string price = txt_Price.Text.Trim();
            bool errorEmptyMoney = string.IsNullOrEmpty(cost) || string.IsNullOrEmpty(price);
            bool errorCost_Larger_Price = emtyToZero_Money(cost) > emtyToZero_Money(price);
            bool flag = true;

            string mess = "";
            if (errorName)
            {
                mess = "Tên không được để trống!";
                flag = false;
            }
            else if (errSupplier)
            {
                mess = "Vui lòng chọn một nhà cung cấp";
                flag = false;
            }
            else if (errTypeProduct)
            {
                mess = "Vui lòng chọn một loại sản phẩm";
                flag = false;
            }
            else if (errorEmptyMoney)
            {
                mess = "Giá nhập và giá bán không được để trống!";
                flag = false;
            }
            else if (errorCost_Larger_Price)
            {
                mess = "Giá bán phải lớn hơn giá nhập!";
                flag = false;
            }

            if (flag == false)
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;

        }
        private double GetNumberShelfLife(string shelfLife)
        {
            string num = "";
            for (int i = 0; i < shelfLife.Length - 1; i++)
            {
                num += shelfLife[i];
            }
            return double.Parse(num);
        }
        private bool IsNotId()
        {
            if (dgv_ListProduct.SelectedRows.Count > 0)
            {
                return false;
            }
            MessageBox.Show("Vui lòng chọn sản phẩm cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsErrorInput())
                {
                    return;
                }
                string pathImage, nameProduct, idSupplier, idType, unitItem, unitTime, shelfLife;
                double cost, price;
                int count;
                byte status;
                
                string fullPathImage = pic_Product.ImageLocation ?? "";
                pathImage = Path.GetFileName(pic_Product.ImageLocation) ?? "";
                idSupplier = cbb_Supplier.SelectedValue.ToString();
                nameProduct = txt_NameProduct.Text.Trim();
                idType = cbb_TypeProduct.SelectedValue.ToString();
                unitItem = cbb_UnitCaculator.Text.ToString();
                unitTime = cbb_UnitTime.SelectedValue.ToString();

                cost = double.Parse(txt_Cost.Text);
                price = double.Parse(txt_Price.Text);
                shelfLife = num_ShelfLife.Text + unitTime;

                count = (int)num_Count.Value;
                status = (byte)(chk_Status.Checked ? 1 : 0);

                DTO_Product product = new DTO_Product(pathImage, nameProduct, idSupplier, idType, cost, price, count, shelfLife, unitItem, status);

                int affectedRows = (new BLL_Product()).InsertProduct(product);

                string mess = "";
                if (affectedRows > 0)
                {
                    mess = $"Thêm sản phẩm {nameProduct} thành công!!";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView(status: chk_ProductStatus.Checked);

                    CopyImageToFolderProject(fullPathImage);
                    return;
                }
                else
                {
                    mess = $"Thêm sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception )
            {
               // MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {

            if (IsNotId())
            {
                return;
            }
            else if (IsErrorInput())
            {
                return;
            }

            try
            {
                string pathImage, idProduct, nameProduct, idSupplier, idType, unitItem, unitTime, shelfLife;
                double cost, price;
                int count;
                byte status;

                string fullPathImage = pic_Product.ImageLocation;
                pathImage = Path.GetFileName(pic_Product.ImageLocation);
                idProduct = txt_ID.Text;
                nameProduct = txt_NameProduct.Text.Trim();
                idSupplier = cbb_Supplier.SelectedValue.ToString();
                idType = cbb_TypeProduct.SelectedValue.ToString();
                unitItem = cbb_UnitCaculator.Text.ToString();
                unitTime = cbb_UnitTime.SelectedValue.ToString();

                cost = double.Parse(txt_Cost.Text);
                price = double.Parse(txt_Price.Text);
                shelfLife = num_ShelfLife.Text + unitTime;

                count = (int)num_Count.Value;
                status = (byte)(chk_Status.Checked ? 1 : 0);

                DTO_Product product = new DTO_Product(pathImage, nameProduct, idSupplier, idType, cost, price, count, shelfLife, unitItem, status, idProduct);

                int affectedRows = (new BLL_Product()).UpdateProduct(product);

                string mess = "";
                if (affectedRows > 0)
                {
                    mess = $"Chỉnh sủa thông tin sản phẩm {nameProduct} thành công!!";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView(status: chk_ProductStatus.Checked);
                    CopyImageToFolderProject(fullPathImage);
                    return;
                }
                else
                {
                    mess = $"Chỉnh sủa thông tin sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
              //  MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (IsNotId())
            {
                return;
            }
            try
            {
                string idProduct, nameProduct;
                idProduct = txt_ID.Text;
                nameProduct = txt_NameProduct.Text;

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sản phẩm {nameProduct}?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int affectedRows = (new BLL_Product()).UpdateStatusProduct(idProduct);
                        string mess = "";
                        if (affectedRows > 0)
                        {
                            mess = $"Xoá sản phẩm {nameProduct} thành công!!";
                            MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView(status: chk_ProductStatus.Checked);
                            return;
                        }
                        else
                        {
                            mess = $"Xoá sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                            MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            pic_Product.ImageLocation = null;
            txt_ID.Clear();
            txt_NameProduct.Clear();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
            cbb_UnitCaculator.SelectedIndex = 0;
            cbb_UnitTime.SelectedIndex = 0;

            txt_Cost.Clear();
            txt_Price.Clear();

            LoadDataGridView(status: chk_ProductStatus.Checked);

            txt_Search.Clear();


            num_Count.Value = 0;
            chk_Status.Checked = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string nameProduct = txt_Search.Text.Trim();
                LoadDataGridView(nameProduct, chk_ProductStatus.Checked);
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: " + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btnExport__Click(object sender, EventArgs e)
        {

            try
            {
                DataTable tblProduct = (DataTable)dgv_ListProduct.DataSource;
                ConfigExcel_PDF.ExportToExcel(tblProduct, "Product");
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!. Lỗi: "+err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void num_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
