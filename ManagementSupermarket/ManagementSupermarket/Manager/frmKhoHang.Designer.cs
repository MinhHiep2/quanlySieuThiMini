﻿namespace ManagementSupermarket.Manager
{
    partial class frmKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lbl_ErrorCbbSuppiler = new System.Windows.Forms.Label();
            this.lbl_ErrorPrice = new System.Windows.Forms.Label();
            this.cbb_ProductImportWarehouse = new System.Windows.Forms.ComboBox();
            this.cbb_NameSupplierCreate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_CreatedTime = new System.Windows.Forms.DateTimePicker();
            this.btn_RefreshCreate = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.num_CountProductCreate = new System.Windows.Forms.NumericUpDown();
            this.btn_DeleteCreate = new FontAwesome.Sharp.IconButton();
            this.btn_AddCreate = new FontAwesome.Sharp.IconButton();
            this.txt_IntoMoney = new System.Windows.Forms.TextBox();
            this.txt_PriceCreate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AlterCreate = new FontAwesome.Sharp.IconButton();
            this.btn_Finish = new FontAwesome.Sharp.IconButton();
            this.lst_ToReceive = new System.Windows.Forms.ListView();
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayNhapKho1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_TotalCashCreate = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.cbb_SearchRole = new System.Windows.Forms.ComboBox();
            this.btn_SeeDetailWarehouse = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.txt_SearchOrderToReceive = new System.Windows.Forms.TextBox();
            this.btn_SearchOrderToReceive = new FontAwesome.Sharp.IconButton();
            this.dgv_ListOrder = new System.Windows.Forms.DataGridView();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_NameSuplier = new System.Windows.Forms.ComboBox();
            this.txt_TotalCash = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_CreatedTime_List = new System.Windows.Forms.DateTimePicker();
            this.txt_IdEmployee = new System.Windows.Forms.TextBox();
            this.txt_IdToReceive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOrder)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 731);
            this.tabControl1.TabIndex = 34;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.grpInfo);
            this.tabPage1.Controls.Add(this.btn_Finish);
            this.tabPage1.Controls.Add(this.lst_ToReceive);
            this.tabPage1.Controls.Add(this.txt_TotalCashCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lập Hoá Đơn Nhập Kho";
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.lbl_ErrorCbbSuppiler);
            this.grpInfo.Controls.Add(this.lbl_ErrorPrice);
            this.grpInfo.Controls.Add(this.cbb_ProductImportWarehouse);
            this.grpInfo.Controls.Add(this.cbb_NameSupplierCreate);
            this.grpInfo.Controls.Add(this.groupBox2);
            this.grpInfo.Controls.Add(this.btn_RefreshCreate);
            this.grpInfo.Controls.Add(this.num_CountProductCreate);
            this.grpInfo.Controls.Add(this.btn_DeleteCreate);
            this.grpInfo.Controls.Add(this.btn_AddCreate);
            this.grpInfo.Controls.Add(this.txt_IntoMoney);
            this.grpInfo.Controls.Add(this.txt_PriceCreate);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.btn_AlterCreate);
            this.grpInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpInfo.Location = new System.Drawing.Point(8, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1052, 199);
            this.grpInfo.TabIndex = 33;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin";
            // 
            // lbl_ErrorCbbSuppiler
            // 
            this.lbl_ErrorCbbSuppiler.AutoSize = true;
            this.lbl_ErrorCbbSuppiler.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCbbSuppiler.Location = new System.Drawing.Point(18, 103);
            this.lbl_ErrorCbbSuppiler.Name = "lbl_ErrorCbbSuppiler";
            this.lbl_ErrorCbbSuppiler.Size = new System.Drawing.Size(0, 26);
            this.lbl_ErrorCbbSuppiler.TabIndex = 44;
            this.lbl_ErrorCbbSuppiler.Visible = false;
            // 
            // lbl_ErrorPrice
            // 
            this.lbl_ErrorPrice.AutoSize = true;
            this.lbl_ErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPrice.Location = new System.Drawing.Point(1, 170);
            this.lbl_ErrorPrice.Name = "lbl_ErrorPrice";
            this.lbl_ErrorPrice.Size = new System.Drawing.Size(70, 26);
            this.lbl_ErrorPrice.TabIndex = 43;
            this.lbl_ErrorPrice.Text = "label4";
            this.lbl_ErrorPrice.Visible = false;
            // 
            // cbb_ProductImportWarehouse
            // 
            this.cbb_ProductImportWarehouse.BackColor = System.Drawing.Color.Silver;
            this.cbb_ProductImportWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ProductImportWarehouse.FormattingEnabled = true;
            this.cbb_ProductImportWarehouse.Location = new System.Drawing.Point(285, 54);
            this.cbb_ProductImportWarehouse.Name = "cbb_ProductImportWarehouse";
            this.cbb_ProductImportWarehouse.Size = new System.Drawing.Size(240, 34);
            this.cbb_ProductImportWarehouse.TabIndex = 42;
            this.cbb_ProductImportWarehouse.SelectionChangeCommitted += new System.EventHandler(this.cbb_ProductImportWarehouse_SelectionChangeCommitted);
            // 
            // cbb_NameSupplierCreate
            // 
            this.cbb_NameSupplierCreate.BackColor = System.Drawing.Color.Silver;
            this.cbb_NameSupplierCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NameSupplierCreate.FormattingEnabled = true;
            this.cbb_NameSupplierCreate.Location = new System.Drawing.Point(18, 54);
            this.cbb_NameSupplierCreate.Name = "cbb_NameSupplierCreate";
            this.cbb_NameSupplierCreate.Size = new System.Drawing.Size(240, 34);
            this.cbb_NameSupplierCreate.TabIndex = 41;
            this.cbb_NameSupplierCreate.SelectedIndexChanged += new System.EventHandler(this.cbb_NameSupplierCreate_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_CreatedTime);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(215, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày Nhập";
            // 
            // dtp_CreatedTime
            // 
            this.dtp_CreatedTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_CreatedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreatedTime.Location = new System.Drawing.Point(11, 31);
            this.dtp_CreatedTime.Name = "dtp_CreatedTime";
            this.dtp_CreatedTime.Size = new System.Drawing.Size(253, 32);
            this.dtp_CreatedTime.TabIndex = 11;
            // 
            // btn_RefreshCreate
            // 
            this.btn_RefreshCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RefreshCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RefreshCreate.IconColor = System.Drawing.Color.Black;
            this.btn_RefreshCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RefreshCreate.ImageIndex = 2;
            this.btn_RefreshCreate.ImageList = this.imageList1;
            this.btn_RefreshCreate.Location = new System.Drawing.Point(987, 24);
            this.btn_RefreshCreate.Name = "btn_RefreshCreate";
            this.btn_RefreshCreate.Size = new System.Drawing.Size(79, 64);
            this.btn_RefreshCreate.TabIndex = 38;
            this.btn_RefreshCreate.UseVisualStyleBackColor = true;
            this.btn_RefreshCreate.Click += new System.EventHandler(this.btn_RefreshCreate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(3, "plus.png");
            this.imageList1.Images.SetKeyName(4, "export.png");
            this.imageList1.Images.SetKeyName(5, "kinhlup.png");
            // 
            // num_CountProductCreate
            // 
            this.num_CountProductCreate.Location = new System.Drawing.Point(532, 54);
            this.num_CountProductCreate.Name = "num_CountProductCreate";
            this.num_CountProductCreate.Size = new System.Drawing.Size(148, 32);
            this.num_CountProductCreate.TabIndex = 16;
            this.num_CountProductCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_CountProductCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_CountProductCreate_KeyPress);
            // 
            // btn_DeleteCreate
            // 
            this.btn_DeleteCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeleteCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DeleteCreate.IconColor = System.Drawing.Color.Black;
            this.btn_DeleteCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteCreate.ImageIndex = 0;
            this.btn_DeleteCreate.ImageList = this.imageList1;
            this.btn_DeleteCreate.Location = new System.Drawing.Point(905, 25);
            this.btn_DeleteCreate.Name = "btn_DeleteCreate";
            this.btn_DeleteCreate.Size = new System.Drawing.Size(79, 64);
            this.btn_DeleteCreate.TabIndex = 35;
            this.btn_DeleteCreate.UseVisualStyleBackColor = true;
            this.btn_DeleteCreate.Click += new System.EventHandler(this.btn_DeleteCreate_Click);
            // 
            // btn_AddCreate
            // 
            this.btn_AddCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AddCreate.IconColor = System.Drawing.Color.Black;
            this.btn_AddCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddCreate.ImageIndex = 3;
            this.btn_AddCreate.ImageList = this.imageList1;
            this.btn_AddCreate.Location = new System.Drawing.Point(722, 22);
            this.btn_AddCreate.Name = "btn_AddCreate";
            this.btn_AddCreate.Size = new System.Drawing.Size(92, 68);
            this.btn_AddCreate.TabIndex = 3;
            this.btn_AddCreate.UseVisualStyleBackColor = true;
            this.btn_AddCreate.Click += new System.EventHandler(this.btn_AddCreate_Click);
            // 
            // txt_IntoMoney
            // 
            this.txt_IntoMoney.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_IntoMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IntoMoney.Location = new System.Drawing.Point(529, 129);
            this.txt_IntoMoney.Name = "txt_IntoMoney";
            this.txt_IntoMoney.ReadOnly = true;
            this.txt_IntoMoney.Size = new System.Drawing.Size(203, 32);
            this.txt_IntoMoney.TabIndex = 15;
            // 
            // txt_PriceCreate
            // 
            this.txt_PriceCreate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_PriceCreate.Location = new System.Drawing.Point(18, 129);
            this.txt_PriceCreate.Name = "txt_PriceCreate";
            this.txt_PriceCreate.ReadOnly = true;
            this.txt_PriceCreate.Size = new System.Drawing.Size(191, 32);
            this.txt_PriceCreate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(288, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(535, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thành Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn Giá";
            // 
            // btn_AlterCreate
            // 
            this.btn_AlterCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AlterCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AlterCreate.IconColor = System.Drawing.Color.Black;
            this.btn_AlterCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AlterCreate.ImageIndex = 1;
            this.btn_AlterCreate.ImageList = this.imageList1;
            this.btn_AlterCreate.Location = new System.Drawing.Point(821, 26);
            this.btn_AlterCreate.Name = "btn_AlterCreate";
            this.btn_AlterCreate.Size = new System.Drawing.Size(79, 64);
            this.btn_AlterCreate.TabIndex = 22;
            this.btn_AlterCreate.UseVisualStyleBackColor = true;
            this.btn_AlterCreate.Click += new System.EventHandler(this.btn_AlterCreate_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.Transparent;
            this.btn_Finish.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btn_Finish.IconColor = System.Drawing.Color.Black;
            this.btn_Finish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Finish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Finish.Location = new System.Drawing.Point(791, 328);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(154, 67);
            this.btn_Finish.TabIndex = 36;
            this.btn_Finish.Text = "Tính Tiền";
            this.btn_Finish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // lst_ToReceive
            // 
            this.lst_ToReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenNCC,
            this.TenSP,
            this.SoLuong,
            this.DonGiaNhap,
            this.NgayNhapKho1,
            this.TongTien1});
            this.lst_ToReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lst_ToReceive.FullRowSelect = true;
            this.lst_ToReceive.GridLines = true;
            this.lst_ToReceive.HideSelection = false;
            this.lst_ToReceive.Location = new System.Drawing.Point(26, 244);
            this.lst_ToReceive.Name = "lst_ToReceive";
            this.lst_ToReceive.Size = new System.Drawing.Size(749, 422);
            this.lst_ToReceive.TabIndex = 34;
            this.lst_ToReceive.UseCompatibleStateImageBehavior = false;
            this.lst_ToReceive.View = System.Windows.Forms.View.Details;
            this.lst_ToReceive.Click += new System.EventHandler(this.lst_ToReceive_Click);
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên NCC";
            this.TenNCC.Width = 122;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên Sản Phẩm";
            this.TenSP.Width = 155;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "SL";
            this.SoLuong.Width = 59;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.Text = "Đơn Giá";
            this.DonGiaNhap.Width = 95;
            // 
            // NgayNhapKho1
            // 
            this.NgayNhapKho1.Text = "Ngày Nhập";
            this.NgayNhapKho1.Width = 103;
            // 
            // TongTien1
            // 
            this.TongTien1.Text = "Thành Tiền";
            this.TongTien1.Width = 126;
            // 
            // txt_TotalCashCreate
            // 
            this.txt_TotalCashCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TotalCashCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txt_TotalCashCreate.Location = new System.Drawing.Point(791, 244);
            this.txt_TotalCashCreate.Name = "txt_TotalCashCreate";
            this.txt_TotalCashCreate.ReadOnly = true;
            this.txt_TotalCashCreate.Size = new System.Drawing.Size(228, 68);
            this.txt_TotalCashCreate.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.btn_ExportExcel);
            this.tabPage2.Controls.Add(this.cbb_SearchRole);
            this.tabPage2.Controls.Add(this.btn_SeeDetailWarehouse);
            this.tabPage2.Controls.Add(this.btn_Refresh);
            this.tabPage2.Controls.Add(this.btn_Delete);
            this.tabPage2.Controls.Add(this.txt_SearchOrderToReceive);
            this.tabPage2.Controls.Add(this.btn_SearchOrderToReceive);
            this.tabPage2.Controls.Add(this.dgv_ListOrder);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Sách Nhập Kho";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExportExcel.ImageIndex = 4;
            this.btn_ExportExcel.ImageList = this.imageList1;
            this.btn_ExportExcel.Location = new System.Drawing.Point(204, 230);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(66, 68);
            this.btn_ExportExcel.TabIndex = 39;
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // cbb_SearchRole
            // 
            this.cbb_SearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SearchRole.FormattingEnabled = true;
            this.cbb_SearchRole.Items.AddRange(new object[] {
            "MaNK",
            "MaNV",
            "MaNCC"});
            this.cbb_SearchRole.Location = new System.Drawing.Point(619, 264);
            this.cbb_SearchRole.Name = "cbb_SearchRole";
            this.cbb_SearchRole.Size = new System.Drawing.Size(131, 34);
            this.cbb_SearchRole.TabIndex = 38;
            // 
            // btn_SeeDetailWarehouse
            // 
            this.btn_SeeDetailWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.btn_SeeDetailWarehouse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SeeDetailWarehouse.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btn_SeeDetailWarehouse.IconColor = System.Drawing.Color.Black;
            this.btn_SeeDetailWarehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeeDetailWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeeDetailWarehouse.Location = new System.Drawing.Point(317, 247);
            this.btn_SeeDetailWarehouse.Name = "btn_SeeDetailWarehouse";
            this.btn_SeeDetailWarehouse.Size = new System.Drawing.Size(287, 53);
            this.btn_SeeDetailWarehouse.TabIndex = 27;
            this.btn_SeeDetailWarehouse.Text = "Xem Chi Tiết Hóa Đơn";
            this.btn_SeeDetailWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SeeDetailWarehouse.UseVisualStyleBackColor = false;
            this.btn_SeeDetailWarehouse.Click += new System.EventHandler(this.btn_SeeDetailWarehouse_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.ImageIndex = 2;
            this.btn_Refresh.ImageList = this.imageList1;
            this.btn_Refresh.Location = new System.Drawing.Point(122, 230);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 68);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(40, 230);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(76, 68);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_SearchOrderToReceive
            // 
            this.txt_SearchOrderToReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchOrderToReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_SearchOrderToReceive.Location = new System.Drawing.Point(756, 264);
            this.txt_SearchOrderToReceive.Name = "txt_SearchOrderToReceive";
            this.txt_SearchOrderToReceive.Size = new System.Drawing.Size(202, 36);
            this.txt_SearchOrderToReceive.TabIndex = 17;
            // 
            // btn_SearchOrderToReceive
            // 
            this.btn_SearchOrderToReceive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SearchOrderToReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchOrderToReceive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_SearchOrderToReceive.IconColor = System.Drawing.Color.Black;
            this.btn_SearchOrderToReceive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SearchOrderToReceive.ImageIndex = 5;
            this.btn_SearchOrderToReceive.ImageList = this.imageList1;
            this.btn_SearchOrderToReceive.Location = new System.Drawing.Point(974, 252);
            this.btn_SearchOrderToReceive.Name = "btn_SearchOrderToReceive";
            this.btn_SearchOrderToReceive.Size = new System.Drawing.Size(65, 48);
            this.btn_SearchOrderToReceive.TabIndex = 16;
            this.btn_SearchOrderToReceive.UseVisualStyleBackColor = true;
            this.btn_SearchOrderToReceive.Click += new System.EventHandler(this.btn_SearchOrderToReceive_Click);
            // 
            // dgv_ListOrder
            // 
            this.dgv_ListOrder.AllowUserToAddRows = false;
            this.dgv_ListOrder.AllowUserToDeleteRows = false;
            this.dgv_ListOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNK,
            this.MaNV,
            this.MaNCC,
            this.NgayNhapKho,
            this.TongTien});
            this.dgv_ListOrder.Location = new System.Drawing.Point(49, 316);
            this.dgv_ListOrder.Name = "dgv_ListOrder";
            this.dgv_ListOrder.ReadOnly = true;
            this.dgv_ListOrder.RowHeadersWidth = 51;
            this.dgv_ListOrder.RowTemplate.Height = 24;
            this.dgv_ListOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListOrder.Size = new System.Drawing.Size(990, 370);
            this.dgv_ListOrder.TabIndex = 23;
            this.dgv_ListOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListOrder_CellClick);
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã NK";
            this.MaNK.MinimumWidth = 6;
            this.MaNK.Name = "MaNK";
            this.MaNK.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.DataPropertyName = "NgayNhapKho";
            this.NgayNhapKho.HeaderText = "Ngày Nhập Kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            this.NgayNhapKho.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbb_NameSuplier);
            this.groupBox3.Controls.Add(this.txt_TotalCash);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.txt_IdEmployee);
            this.groupBox3.Controls.Add(this.txt_IdToReceive);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(24, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1172, 223);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Hoá Đơn Nhập Kho";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(742, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tổng Tiền";
            // 
            // cbb_NameSuplier
            // 
            this.cbb_NameSuplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb_NameSuplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NameSuplier.FormattingEnabled = true;
            this.cbb_NameSuplier.Location = new System.Drawing.Point(60, 162);
            this.cbb_NameSuplier.Name = "cbb_NameSuplier";
            this.cbb_NameSuplier.Size = new System.Drawing.Size(240, 34);
            this.cbb_NameSuplier.TabIndex = 28;
            this.cbb_NameSuplier.SelectionChangeCommitted += new System.EventHandler(this.cbb_NameSuplier_SelectionChangeCommitted);
            // 
            // txt_TotalCash
            // 
            this.txt_TotalCash.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_TotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_TotalCash.Location = new System.Drawing.Point(736, 117);
            this.txt_TotalCash.Name = "txt_TotalCash";
            this.txt_TotalCash.ReadOnly = true;
            this.txt_TotalCash.Size = new System.Drawing.Size(234, 45);
            this.txt_TotalCash.TabIndex = 27;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_CreatedTime_List);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(394, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 76);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ngày Tạo";
            // 
            // dtp_CreatedTime_List
            // 
            this.dtp_CreatedTime_List.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_CreatedTime_List.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreatedTime_List.Location = new System.Drawing.Point(6, 31);
            this.dtp_CreatedTime_List.Name = "dtp_CreatedTime_List";
            this.dtp_CreatedTime_List.Size = new System.Drawing.Size(243, 32);
            this.dtp_CreatedTime_List.TabIndex = 11;
            // 
            // txt_IdEmployee
            // 
            this.txt_IdEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_IdEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdEmployee.Location = new System.Drawing.Point(400, 73);
            this.txt_IdEmployee.Name = "txt_IdEmployee";
            this.txt_IdEmployee.ReadOnly = true;
            this.txt_IdEmployee.Size = new System.Drawing.Size(220, 32);
            this.txt_IdEmployee.TabIndex = 17;
            // 
            // txt_IdToReceive
            // 
            this.txt_IdToReceive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_IdToReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdToReceive.Location = new System.Drawing.Point(60, 73);
            this.txt_IdToReceive.Name = "txt_IdToReceive";
            this.txt_IdToReceive.ReadOnly = true;
            this.txt_IdToReceive.Size = new System.Drawing.Size(240, 32);
            this.txt_IdToReceive.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(63, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Nhập Kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(405, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã Nhân Viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(63, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên Nhà Cung Cấp";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1083, 714);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKhoHang";
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOrder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_CreatedTime;
        private FontAwesome.Sharp.IconButton btn_RefreshCreate;
        private System.Windows.Forms.NumericUpDown num_CountProductCreate;
        private FontAwesome.Sharp.IconButton btn_AddCreate;
        private System.Windows.Forms.TextBox txt_IntoMoney;
        private System.Windows.Forms.TextBox txt_PriceCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_AlterCreate;
        private FontAwesome.Sharp.IconButton btn_Finish;
        private System.Windows.Forms.ListView lst_ToReceive;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGiaNhap;
        private System.Windows.Forms.ColumnHeader NgayNhapKho1;
        private System.Windows.Forms.ColumnHeader TongTien1;
        private System.Windows.Forms.TextBox txt_TotalCashCreate;
        private FontAwesome.Sharp.IconButton btn_DeleteCreate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ListOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_TotalCash;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_CreatedTime_List;
        private System.Windows.Forms.TextBox txt_IdEmployee;
        private System.Windows.Forms.TextBox txt_IdToReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbb_NameSuplier;
        private System.Windows.Forms.ComboBox cbb_NameSupplierCreate;
        private System.Windows.Forms.TextBox txt_SearchOrderToReceive;
        private FontAwesome.Sharp.IconButton btn_SearchOrderToReceive;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.ComboBox cbb_ProductImportWarehouse;
        private FontAwesome.Sharp.IconButton btn_SeeDetailWarehouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_SearchRole;
        private System.Windows.Forms.Label lbl_ErrorCbbSuppiler;
        private System.Windows.Forms.Label lbl_ErrorPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.ImageList imageList1;
    }
}