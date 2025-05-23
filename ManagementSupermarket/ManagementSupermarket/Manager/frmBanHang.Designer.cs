﻿namespace ManagementSupermarket
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ExportPDF = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.cbo_Search = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_InvoiceSelling = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKhachDua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTraKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ShowDetailInvoice = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.tab_FormCreateInvoice = new System.Windows.Forms.TabPage();
            this.chk_PhoneCustomer = new System.Windows.Forms.CheckBox();
            this.lbl_ErrorPhone = new System.Windows.Forms.Label();
            this.lbl_ErrorCashCustomer = new System.Windows.Forms.Label();
            this.btn_RefreshCreate = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.txt_ChangeCreate = new System.Windows.Forms.TextBox();
            this.txt_PhoneCustomerCreate = new System.Windows.Forms.TextBox();
            this.txt_CashCustomerCreate = new System.Windows.Forms.TextBox();
            this.txt_TotalCashCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FinishOrder = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.lst_OrderCurrency = new System.Windows.Forms.ListView();
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txt_AmountCreate = new System.Windows.Forms.TextBox();
            this.cbo_DiscountCreate = new System.Windows.Forms.ComboBox();
            this.cbo_NameProductCreate = new System.Windows.Forms.ComboBox();
            this.num_CountProductCreate = new System.Windows.Forms.NumericUpDown();
            this.txt_ProductInWarehouse = new System.Windows.Forms.TextBox();
            this.txt_PriceCreate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_HomeInvoiceSelling = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceSelling)).BeginInit();
            this.tab_FormCreateInvoice.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).BeginInit();
            this.tab_HomeInvoiceSelling.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.btn_ExportPDF);
            this.tabPage2.Controls.Add(this.btn_ExportExcel);
            this.tabPage2.Controls.Add(this.cbo_Search);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.dgv_InvoiceSelling);
            this.tabPage2.Controls.Add(this.btn_ShowDetailInvoice);
            this.tabPage2.Controls.Add(this.btn_Refresh);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Sách Hoá Đơn";
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExportPDF.ImageIndex = 5;
            this.btn_ExportPDF.ImageList = this.imageList1;
            this.btn_ExportPDF.Location = new System.Drawing.Point(539, 43);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.Size = new System.Drawing.Size(98, 70);
            this.btn_ExportPDF.TabIndex = 31;
            this.btn_ExportPDF.UseVisualStyleBackColor = true;
            this.btn_ExportPDF.Click += new System.EventHandler(this.btn_ExportPDF_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "kinhlup.png");
            this.imageList1.Images.SetKeyName(3, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(4, "plus.png");
            this.imageList1.Images.SetKeyName(5, "download.png");
            this.imageList1.Images.SetKeyName(6, "export.png");
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExportExcel.ImageIndex = 6;
            this.btn_ExportExcel.ImageList = this.imageList1;
            this.btn_ExportExcel.Location = new System.Drawing.Point(426, 44);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(98, 70);
            this.btn_ExportExcel.TabIndex = 31;
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // cbo_Search
            // 
            this.cbo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbo_Search.FormattingEnabled = true;
            this.cbo_Search.Location = new System.Drawing.Point(670, 69);
            this.cbo_Search.Name = "cbo_Search";
            this.cbo_Search.Size = new System.Drawing.Size(153, 37);
            this.cbo_Search.TabIndex = 23;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(829, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 36);
            this.txtSearch.TabIndex = 21;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.ImageIndex = 2;
            this.btn_Search.ImageList = this.imageList1;
            this.btn_Search.Location = new System.Drawing.Point(1024, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(67, 50);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_InvoiceSelling
            // 
            this.dgv_InvoiceSelling.AllowUserToAddRows = false;
            this.dgv_InvoiceSelling.AllowUserToDeleteRows = false;
            this.dgv_InvoiceSelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_InvoiceSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InvoiceSelling.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_InvoiceSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InvoiceSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaKH,
            this.NgayLapHD,
            this.TongTien,
            this.TienKhachDua,
            this.TienTraKhach});
            this.dgv_InvoiceSelling.Location = new System.Drawing.Point(10, 132);
            this.dgv_InvoiceSelling.MultiSelect = false;
            this.dgv_InvoiceSelling.Name = "dgv_InvoiceSelling";
            this.dgv_InvoiceSelling.ReadOnly = true;
            this.dgv_InvoiceSelling.RowHeadersWidth = 51;
            this.dgv_InvoiceSelling.RowTemplate.Height = 24;
            this.dgv_InvoiceSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InvoiceSelling.Size = new System.Drawing.Size(1118, 609);
            this.dgv_InvoiceSelling.TabIndex = 5;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày Lập HD";
            this.NgayLapHD.MinimumWidth = 6;
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TienKhachDua
            // 
            this.TienKhachDua.DataPropertyName = "TienKhachDua";
            this.TienKhachDua.HeaderText = "Tiền Trả";
            this.TienKhachDua.MinimumWidth = 6;
            this.TienKhachDua.Name = "TienKhachDua";
            this.TienKhachDua.ReadOnly = true;
            // 
            // TienTraKhach
            // 
            this.TienTraKhach.DataPropertyName = "TienTraKhach";
            this.TienTraKhach.HeaderText = "Tiền Thừa";
            this.TienTraKhach.MinimumWidth = 6;
            this.TienTraKhach.Name = "TienTraKhach";
            this.TienTraKhach.ReadOnly = true;
            // 
            // btn_ShowDetailInvoice
            // 
            this.btn_ShowDetailInvoice.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btn_ShowDetailInvoice.IconColor = System.Drawing.Color.Black;
            this.btn_ShowDetailInvoice.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_ShowDetailInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowDetailInvoice.Location = new System.Drawing.Point(10, 55);
            this.btn_ShowDetailInvoice.Name = "btn_ShowDetailInvoice";
            this.btn_ShowDetailInvoice.Size = new System.Drawing.Size(281, 52);
            this.btn_ShowDetailInvoice.TabIndex = 22;
            this.btn_ShowDetailInvoice.Text = "Xem Chi Tiết Hoá Đơn";
            this.btn_ShowDetailInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowDetailInvoice.UseVisualStyleBackColor = true;
            this.btn_ShowDetailInvoice.Click += new System.EventHandler(this.btn_ShowDetailInvoice_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.ImageIndex = 3;
            this.btn_Refresh.ImageList = this.imageList1;
            this.btn_Refresh.Location = new System.Drawing.Point(307, 43);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(95, 71);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tab_FormCreateInvoice
            // 
            this.tab_FormCreateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tab_FormCreateInvoice.Controls.Add(this.chk_PhoneCustomer);
            this.tab_FormCreateInvoice.Controls.Add(this.lbl_ErrorPhone);
            this.tab_FormCreateInvoice.Controls.Add(this.lbl_ErrorCashCustomer);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_RefreshCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_Add);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_ChangeCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_PhoneCustomerCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_CashCustomerCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_TotalCashCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.label4);
            this.tab_FormCreateInvoice.Controls.Add(this.label1);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_FinishOrder);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_Alter);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_Delete);
            this.tab_FormCreateInvoice.Controls.Add(this.lst_OrderCurrency);
            this.tab_FormCreateInvoice.Controls.Add(this.grpInfo);
            this.tab_FormCreateInvoice.Location = new System.Drawing.Point(4, 35);
            this.tab_FormCreateInvoice.Name = "tab_FormCreateInvoice";
            this.tab_FormCreateInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_FormCreateInvoice.Size = new System.Drawing.Size(1200, 698);
            this.tab_FormCreateInvoice.TabIndex = 0;
            this.tab_FormCreateInvoice.Text = "Lập Hoá Đơn";
            // 
            // chk_PhoneCustomer
            // 
            this.chk_PhoneCustomer.AutoSize = true;
            this.chk_PhoneCustomer.BackColor = System.Drawing.Color.Transparent;
            this.chk_PhoneCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_PhoneCustomer.ForeColor = System.Drawing.Color.Black;
            this.chk_PhoneCustomer.Location = new System.Drawing.Point(727, 221);
            this.chk_PhoneCustomer.Name = "chk_PhoneCustomer";
            this.chk_PhoneCustomer.Size = new System.Drawing.Size(273, 29);
            this.chk_PhoneCustomer.TabIndex = 34;
            this.chk_PhoneCustomer.Text = "Số Điện Thoại Khách Hàng";
            this.chk_PhoneCustomer.UseVisualStyleBackColor = false;
            this.chk_PhoneCustomer.CheckedChanged += new System.EventHandler(this.chk_PhoneCustomer_CheckedChanged);
            // 
            // lbl_ErrorPhone
            // 
            this.lbl_ErrorPhone.AutoSize = true;
            this.lbl_ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPhone.Location = new System.Drawing.Point(722, 304);
            this.lbl_ErrorPhone.Name = "lbl_ErrorPhone";
            this.lbl_ErrorPhone.Size = new System.Drawing.Size(82, 26);
            this.lbl_ErrorPhone.TabIndex = 33;
            this.lbl_ErrorPhone.Text = "label18";
            this.lbl_ErrorPhone.Visible = false;
            // 
            // lbl_ErrorCashCustomer
            // 
            this.lbl_ErrorCashCustomer.AutoSize = true;
            this.lbl_ErrorCashCustomer.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCashCustomer.Location = new System.Drawing.Point(722, 414);
            this.lbl_ErrorCashCustomer.Name = "lbl_ErrorCashCustomer";
            this.lbl_ErrorCashCustomer.Size = new System.Drawing.Size(82, 26);
            this.lbl_ErrorCashCustomer.TabIndex = 33;
            this.lbl_ErrorCashCustomer.Text = "label18";
            this.lbl_ErrorCashCustomer.Visible = false;
            // 
            // btn_RefreshCreate
            // 
            this.btn_RefreshCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RefreshCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RefreshCreate.IconColor = System.Drawing.Color.Black;
            this.btn_RefreshCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RefreshCreate.ImageIndex = 3;
            this.btn_RefreshCreate.ImageList = this.imageList1;
            this.btn_RefreshCreate.Location = new System.Drawing.Point(942, 156);
            this.btn_RefreshCreate.Name = "btn_RefreshCreate";
            this.btn_RefreshCreate.Size = new System.Drawing.Size(79, 64);
            this.btn_RefreshCreate.TabIndex = 26;
            this.btn_RefreshCreate.UseVisualStyleBackColor = true;
            this.btn_RefreshCreate.Click += new System.EventHandler(this.btn_RefreshCreate_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.ImageIndex = 4;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(1062, 156);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_ChangeCreate
            // 
            this.txt_ChangeCreate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_ChangeCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ChangeCreate.Enabled = false;
            this.txt_ChangeCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_ChangeCreate.Location = new System.Drawing.Point(727, 499);
            this.txt_ChangeCreate.Name = "txt_ChangeCreate";
            this.txt_ChangeCreate.ReadOnly = true;
            this.txt_ChangeCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_ChangeCreate.TabIndex = 30;
            this.txt_ChangeCreate.Text = "0";
            // 
            // txt_PhoneCustomerCreate
            // 
            this.txt_PhoneCustomerCreate.BackColor = System.Drawing.Color.Gray;
            this.txt_PhoneCustomerCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_PhoneCustomerCreate.Location = new System.Drawing.Point(727, 256);
            this.txt_PhoneCustomerCreate.Name = "txt_PhoneCustomerCreate";
            this.txt_PhoneCustomerCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_PhoneCustomerCreate.TabIndex = 31;
            this.txt_PhoneCustomerCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhoneCustomerCreate_KeyPress);
            // 
            // txt_CashCustomerCreate
            // 
            this.txt_CashCustomerCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CashCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_CashCustomerCreate.Location = new System.Drawing.Point(727, 366);
            this.txt_CashCustomerCreate.Name = "txt_CashCustomerCreate";
            this.txt_CashCustomerCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_CashCustomerCreate.TabIndex = 32;
            this.txt_CashCustomerCreate.TextChanged += new System.EventHandler(this.txt_CashCustomerCreate_TextChanged);
            this.txt_CashCustomerCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CashCustomerCreate_KeyPress);
            // 
            // txt_TotalCashCreate
            // 
            this.txt_TotalCashCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txt_TotalCashCreate.Location = new System.Drawing.Point(717, 621);
            this.txt_TotalCashCreate.Name = "txt_TotalCashCreate";
            this.txt_TotalCashCreate.ReadOnly = true;
            this.txt_TotalCashCreate.Size = new System.Drawing.Size(283, 68);
            this.txt_TotalCashCreate.TabIndex = 25;
            this.txt_TotalCashCreate.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(722, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tiền Thối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(722, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tiền Khách Đưa";
            // 
            // btn_FinishOrder
            // 
            this.btn_FinishOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_FinishOrder.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btn_FinishOrder.IconColor = System.Drawing.Color.Black;
            this.btn_FinishOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_FinishOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FinishOrder.Location = new System.Drawing.Point(1006, 619);
            this.btn_FinishOrder.Name = "btn_FinishOrder";
            this.btn_FinishOrder.Size = new System.Drawing.Size(168, 67);
            this.btn_FinishOrder.TabIndex = 24;
            this.btn_FinishOrder.Text = "Tổng Tiền";
            this.btn_FinishOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FinishOrder.UseVisualStyleBackColor = false;
            this.btn_FinishOrder.Click += new System.EventHandler(this.btn_FinishOrder_Click_1);
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.ImageIndex = 1;
            this.btn_Alter.ImageList = this.imageList1;
            this.btn_Alter.Location = new System.Drawing.Point(680, 159);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(85, 59);
            this.btn_Alter.TabIndex = 22;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(809, 159);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 59);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lst_OrderCurrency
            // 
            this.lst_OrderCurrency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSP,
            this.TenSP,
            this.SL,
            this.Gia,
            this.MaKM,
            this.GiaKM,
            this.ThanhTien});
            this.lst_OrderCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lst_OrderCurrency.FullRowSelect = true;
            this.lst_OrderCurrency.GridLines = true;
            this.lst_OrderCurrency.HideSelection = false;
            this.lst_OrderCurrency.Location = new System.Drawing.Point(18, 219);
            this.lst_OrderCurrency.MultiSelect = false;
            this.lst_OrderCurrency.Name = "lst_OrderCurrency";
            this.lst_OrderCurrency.Size = new System.Drawing.Size(687, 469);
            this.lst_OrderCurrency.TabIndex = 21;
            this.lst_OrderCurrency.UseCompatibleStateImageBehavior = false;
            this.lst_OrderCurrency.View = System.Windows.Forms.View.Details;
            this.lst_OrderCurrency.Click += new System.EventHandler(this.lst_OrderCurrency_Click);
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã Sản Phẩm";
            this.MaSP.Width = 130;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên Sản Phẩm";
            this.TenSP.Width = 135;
            // 
            // SL
            // 
            this.SL.Text = "SL";
            this.SL.Width = 57;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            this.Gia.Width = 95;
            // 
            // MaKM
            // 
            this.MaKM.Text = "Mã KM";
            this.MaKM.Width = 83;
            // 
            // GiaKM
            // 
            this.GiaKM.Text = "Giá KM";
            this.GiaKM.Width = 93;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Th.Tiền";
            this.ThanhTien.Width = 132;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.txt_AmountCreate);
            this.grpInfo.Controls.Add(this.cbo_DiscountCreate);
            this.grpInfo.Controls.Add(this.cbo_NameProductCreate);
            this.grpInfo.Controls.Add(this.num_CountProductCreate);
            this.grpInfo.Controls.Add(this.txt_ProductInWarehouse);
            this.grpInfo.Controls.Add(this.txt_PriceCreate);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.ForeColor = System.Drawing.Color.Black;
            this.grpInfo.Location = new System.Drawing.Point(6, -1);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1146, 151);
            this.grpInfo.TabIndex = 20;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin hoá đơn";
            // 
            // txt_AmountCreate
            // 
            this.txt_AmountCreate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_AmountCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AmountCreate.Location = new System.Drawing.Point(951, 59);
            this.txt_AmountCreate.Name = "txt_AmountCreate";
            this.txt_AmountCreate.ReadOnly = true;
            this.txt_AmountCreate.Size = new System.Drawing.Size(184, 32);
            this.txt_AmountCreate.TabIndex = 34;
            // 
            // cbo_DiscountCreate
            // 
            this.cbo_DiscountCreate.DisplayMember = " ";
            this.cbo_DiscountCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DiscountCreate.FormattingEnabled = true;
            this.cbo_DiscountCreate.Location = new System.Drawing.Point(758, 58);
            this.cbo_DiscountCreate.Name = "cbo_DiscountCreate";
            this.cbo_DiscountCreate.Size = new System.Drawing.Size(154, 34);
            this.cbo_DiscountCreate.TabIndex = 33;
            // 
            // cbo_NameProductCreate
            // 
            this.cbo_NameProductCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NameProductCreate.FormattingEnabled = true;
            this.cbo_NameProductCreate.Location = new System.Drawing.Point(17, 60);
            this.cbo_NameProductCreate.Name = "cbo_NameProductCreate";
            this.cbo_NameProductCreate.Size = new System.Drawing.Size(207, 34);
            this.cbo_NameProductCreate.TabIndex = 33;
            this.cbo_NameProductCreate.SelectionChangeCommitted += new System.EventHandler(this.cbo_NameProductCreate_SelectionChangeCommitted_1);
            // 
            // num_CountProductCreate
            // 
            this.num_CountProductCreate.Location = new System.Drawing.Point(437, 60);
            this.num_CountProductCreate.Name = "num_CountProductCreate";
            this.num_CountProductCreate.Size = new System.Drawing.Size(139, 32);
            this.num_CountProductCreate.TabIndex = 18;
            this.num_CountProductCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_CountProductCreate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CountProductCreate.ValueChanged += new System.EventHandler(this.num_CountProductCreate_ValueChanged);
            this.num_CountProductCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_CountProductCreate_KeyPress);
            // 
            // txt_ProductInWarehouse
            // 
            this.txt_ProductInWarehouse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_ProductInWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductInWarehouse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ProductInWarehouse.Location = new System.Drawing.Point(260, 60);
            this.txt_ProductInWarehouse.Name = "txt_ProductInWarehouse";
            this.txt_ProductInWarehouse.ReadOnly = true;
            this.txt_ProductInWarehouse.Size = new System.Drawing.Size(139, 32);
            this.txt_ProductInWarehouse.TabIndex = 14;
            this.txt_ProductInWarehouse.Text = " 0";
            // 
            // txt_PriceCreate
            // 
            this.txt_PriceCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PriceCreate.Location = new System.Drawing.Point(597, 60);
            this.txt_PriceCreate.Name = "txt_PriceCreate";
            this.txt_PriceCreate.ReadOnly = true;
            this.txt_PriceCreate.Size = new System.Drawing.Size(139, 32);
            this.txt_PriceCreate.TabIndex = 14;
            this.txt_PriceCreate.Text = " 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(946, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thành Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(257, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tồn Kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(432, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(753, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khuyến Mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(592, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn Giá";
            // 
            // tab_HomeInvoiceSelling
            // 
            this.tab_HomeInvoiceSelling.Controls.Add(this.tab_FormCreateInvoice);
            this.tab_HomeInvoiceSelling.Controls.Add(this.tabPage2);
            this.tab_HomeInvoiceSelling.Location = new System.Drawing.Point(-1, -2);
            this.tab_HomeInvoiceSelling.Name = "tab_HomeInvoiceSelling";
            this.tab_HomeInvoiceSelling.SelectedIndex = 0;
            this.tab_HomeInvoiceSelling.Size = new System.Drawing.Size(1208, 737);
            this.tab_HomeInvoiceSelling.TabIndex = 0;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 731);
            this.Controls.Add(this.tab_HomeInvoiceSelling);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load_1);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceSelling)).EndInit();
            this.tab_FormCreateInvoice.ResumeLayout(false);
            this.tab_FormCreateInvoice.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).EndInit();
            this.tab_HomeInvoiceSelling.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.ComboBox cbo_Search;
        private FontAwesome.Sharp.IconButton btn_ShowDetailInvoice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_Search;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_InvoiceSelling;
        private System.Windows.Forms.TabPage tab_FormCreateInvoice;
        private System.Windows.Forms.CheckBox chk_PhoneCustomer;
        private System.Windows.Forms.Label lbl_ErrorCashCustomer;
        private FontAwesome.Sharp.IconButton btn_RefreshCreate;
        private System.Windows.Forms.TextBox txt_ChangeCreate;
        private System.Windows.Forms.TextBox txt_PhoneCustomerCreate;
        private System.Windows.Forms.TextBox txt_CashCustomerCreate;
        private System.Windows.Forms.TextBox txt_TotalCashCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_FinishOrder;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.ListView lst_OrderCurrency;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader MaKM;
        private System.Windows.Forms.ColumnHeader GiaKM;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txt_AmountCreate;
        private System.Windows.Forms.ComboBox cbo_DiscountCreate;
        private System.Windows.Forms.ComboBox cbo_NameProductCreate;
        private System.Windows.Forms.NumericUpDown num_CountProductCreate;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.TextBox txt_PriceCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab_HomeInvoiceSelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKhachDua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTraKhach;
        private System.Windows.Forms.TextBox txt_ProductInWarehouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ErrorPhone;
        private System.Windows.Forms.Button btn_ExportPDF;
        private System.Windows.Forms.ImageList imageList1;
    }
}