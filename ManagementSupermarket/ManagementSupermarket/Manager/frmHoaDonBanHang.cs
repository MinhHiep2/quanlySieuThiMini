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
using System.Globalization;

namespace ManagementSupermarket.Manager
{
    public partial class frmHoaDonBanHang : Form
    {
       public frmHoaDonBanHang()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }
        private string s_IdInvoice;
        private string s_NameEmployee;
        private string s_NameCustomer;
        private DateTime dt_CreatedTime;
        private double d_TotalCash;
        public frmHoaDonBanHang(string idInvoice, string nameEmployee, DateTime createdTime, string nameCustomer, double totalCash)
        {
            InitializeComponent();
            this.s_IdInvoice = idInvoice;
            this.s_NameEmployee = nameEmployee;
            this.s_NameCustomer = nameCustomer;
            this.dt_CreatedTime = createdTime;
            this.d_TotalCash = totalCash;
        }
        public static string formatPrice(decimal price, string unit = "VNĐ")
        {
            if (price >= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            else if (price <= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            return Convert.ToInt64(price).ToString() + $" {unit}";
        }

        private void frmDetailInvoiceSelling_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_idInvoice.Text = s_IdInvoice;
                lbl_idEmployee.Text = s_NameEmployee;
                lbl_NameCustomer.Text = "";

                if (!string.IsNullOrEmpty(s_NameCustomer))
                {
                    lbl_NameCustomer.Text = s_NameCustomer;
                }

                lbl_CreateTime.Text = dt_CreatedTime.ToString("dd/MM/yyyy HH:mm:ss");
                lbl_TotalCash.Text = formatPrice((decimal)d_TotalCash);
                DataTable tblDetailInvoice = (new BLL_Detail_InvoiceSelling()).GetDetailInvoiceSelling("MaHD", s_IdInvoice);
                dgv_Detail_InvoiceSelling.DataSource = tblDetailInvoice;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
