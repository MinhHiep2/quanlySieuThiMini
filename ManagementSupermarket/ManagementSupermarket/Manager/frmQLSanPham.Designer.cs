﻿namespace ManagementSupermarket
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.dgv_ListProduct = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pic_Product = new System.Windows.Forms.PictureBox();
            this.btn_Upload = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NameProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.num_Count = new System.Windows.Forms.NumericUpDown();
            this.cbb_Supplier = new System.Windows.Forms.ComboBox();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.cbb_UnitCaculator = new System.Windows.Forms.ComboBox();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.cbb_TypeProduct = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.cbb_UnitTime = new System.Windows.Forms.ComboBox();
            this.num_ShelfLife = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_ProductStatus = new System.Windows.Forms.CheckBox();
            this.btnExport_ = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ShelfLife)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ListProduct
            // 
            this.dgv_ListProduct.AllowUserToAddRows = false;
            this.dgv_ListProduct.AllowUserToDeleteRows = false;
            this.dgv_ListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.HinhAnh,
            this.TenSP,
            this.TenNCC,
            this.GiaNhap,
            this.GiaBan,
            this.SoLuong,
            this.HanSuDung,
            this.DonViTinh,
            this.TrangThai});
            this.dgv_ListProduct.Location = new System.Drawing.Point(23, 325);
            this.dgv_ListProduct.MultiSelect = false;
            this.dgv_ListProduct.Name = "dgv_ListProduct";
            this.dgv_ListProduct.ReadOnly = true;
            this.dgv_ListProduct.RowHeadersWidth = 51;
            this.dgv_ListProduct.RowTemplate.Height = 24;
            this.dgv_ListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListProduct.Size = new System.Drawing.Size(1151, 394);
            this.dgv_ListProduct.TabIndex = 1;
            this.dgv_ListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListProduct_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            this.HanSuDung.HeaderText = "HSD";
            this.HanSuDung.MinimumWidth = 6;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "ĐV Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(226, 274);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(292, 45);
            this.txt_Search.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.ImageIndex = 4;
            this.btn_Search.ImageList = this.imageList1;
            this.btn_Search.Location = new System.Drawing.Point(533, 263);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 55);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(3, "plus.png");
            this.imageList1.Images.SetKeyName(4, "kinhlup.png");
            this.imageList1.Images.SetKeyName(5, "export.png");
            // 
            // pic_Product
            // 
            this.pic_Product.BackColor = System.Drawing.Color.White;
            this.pic_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Product.Location = new System.Drawing.Point(48, 16);
            this.pic_Product.Name = "pic_Product";
            this.pic_Product.Size = new System.Drawing.Size(253, 131);
            this.pic_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Product.TabIndex = 0;
            this.pic_Product.TabStop = false;
            // 
            // btn_Upload
            // 
            this.btn_Upload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_Upload.IconColor = System.Drawing.Color.Gray;
            this.btn_Upload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Upload.IconSize = 40;
            this.btn_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Upload.Location = new System.Drawing.Point(112, 159);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(120, 39);
            this.btn_Upload.TabIndex = 1;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(324, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.Silver;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.Black;
            this.txt_ID.Location = new System.Drawing.Point(329, 47);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(153, 32);
            this.txt_ID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(666, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giá Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(691, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txt_Price
            // 
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(671, 110);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(181, 32);
            this.txt_Price.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(849, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thời Hạn Sử Dụng";
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameProduct.Location = new System.Drawing.Point(696, 47);
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.Size = new System.Drawing.Size(258, 32);
            this.txt_NameProduct.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(500, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Giá Nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(967, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Loại Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(326, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số Lượng";
            // 
            // txt_Cost
            // 
            this.txt_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cost.Location = new System.Drawing.Point(505, 110);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(158, 32);
            this.txt_Cost.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(489, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chk_Status.ForeColor = System.Drawing.Color.White;
            this.chk_Status.Location = new System.Drawing.Point(468, 166);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(208, 33);
            this.chk_Status.TabIndex = 20;
            this.chk_Status.Text = "Trạng Thái Bán";
            this.chk_Status.UseVisualStyleBackColor = true;
            this.chk_Status.CheckedChanged += new System.EventHandler(this.chk_Status_CheckedChanged);
            // 
            // num_Count
            // 
            this.num_Count.Location = new System.Drawing.Point(331, 166);
            this.num_Count.Name = "num_Count";
            this.num_Count.Size = new System.Drawing.Size(131, 32);
            this.num_Count.TabIndex = 21;
            this.num_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_Count_KeyPress);
            // 
            // cbb_Supplier
            // 
            this.cbb_Supplier.BackColor = System.Drawing.Color.Silver;
            this.cbb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Supplier.FormattingEnabled = true;
            this.cbb_Supplier.Location = new System.Drawing.Point(494, 47);
            this.cbb_Supplier.Name = "cbb_Supplier";
            this.cbb_Supplier.Size = new System.Drawing.Size(196, 34);
            this.cbb_Supplier.TabIndex = 22;
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.ImageIndex = 3;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(716, 151);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbb_UnitCaculator
            // 
            this.cbb_UnitCaculator.BackColor = System.Drawing.Color.Silver;
            this.cbb_UnitCaculator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UnitCaculator.FormattingEnabled = true;
            this.cbb_UnitCaculator.Location = new System.Drawing.Point(330, 108);
            this.cbb_UnitCaculator.Name = "cbb_UnitCaculator";
            this.cbb_UnitCaculator.Size = new System.Drawing.Size(158, 34);
            this.cbb_UnitCaculator.TabIndex = 23;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.ImageIndex = 1;
            this.btn_Alter.ImageList = this.imageList1;
            this.btn_Alter.Location = new System.Drawing.Point(801, 151);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 7;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // cbb_TypeProduct
            // 
            this.cbb_TypeProduct.BackColor = System.Drawing.Color.DarkGray;
            this.cbb_TypeProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TypeProduct.FormattingEnabled = true;
            this.cbb_TypeProduct.Location = new System.Drawing.Point(972, 45);
            this.cbb_TypeProduct.Name = "cbb_TypeProduct";
            this.cbb_TypeProduct.Size = new System.Drawing.Size(180, 34);
            this.cbb_TypeProduct.TabIndex = 23;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(886, 151);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.ImageIndex = 2;
            this.btn_Refresh.ImageList = this.imageList1;
            this.btn_Refresh.Location = new System.Drawing.Point(971, 151);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbb_UnitTime
            // 
            this.cbb_UnitTime.BackColor = System.Drawing.Color.Silver;
            this.cbb_UnitTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UnitTime.FormattingEnabled = true;
            this.cbb_UnitTime.Location = new System.Drawing.Point(993, 108);
            this.cbb_UnitTime.Name = "cbb_UnitTime";
            this.cbb_UnitTime.Size = new System.Drawing.Size(106, 34);
            this.cbb_UnitTime.TabIndex = 23;
            // 
            // num_ShelfLife
            // 
            this.num_ShelfLife.Location = new System.Drawing.Point(855, 110);
            this.num_ShelfLife.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ShelfLife.Name = "num_ShelfLife";
            this.num_ShelfLife.Size = new System.Drawing.Size(117, 32);
            this.num_ShelfLife.TabIndex = 24;
            this.num_ShelfLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_ShelfLife.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chk_ProductStatus);
            this.panel1.Controls.Add(this.num_ShelfLife);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbb_UnitTime);
            this.panel1.Controls.Add(this.btnExport_);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.dgv_ListProduct);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.cbb_TypeProduct);
            this.panel1.Controls.Add(this.btn_Alter);
            this.panel1.Controls.Add(this.cbb_UnitCaculator);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.cbb_Supplier);
            this.panel1.Controls.Add(this.num_Count);
            this.panel1.Controls.Add(this.chk_Status);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Cost);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_NameProduct);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Upload);
            this.panel1.Controls.Add(this.pic_Product);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 833);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chk_ProductStatus
            // 
            this.chk_ProductStatus.AutoSize = true;
            this.chk_ProductStatus.Checked = true;
            this.chk_ProductStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ProductStatus.ForeColor = System.Drawing.Color.White;
            this.chk_ProductStatus.Location = new System.Drawing.Point(41, 274);
            this.chk_ProductStatus.Name = "chk_ProductStatus";
            this.chk_ProductStatus.Size = new System.Drawing.Size(179, 40);
            this.chk_ProductStatus.TabIndex = 28;
            this.chk_ProductStatus.Text = "Hoạt Động";
            this.chk_ProductStatus.UseVisualStyleBackColor = true;
            // 
            // btnExport_
            // 
            this.btnExport_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExport_.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExport_.IconColor = System.Drawing.Color.Black;
            this.btnExport_.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport_.ImageIndex = 5;
            this.btnExport_.ImageList = this.imageList1;
            this.btnExport_.Location = new System.Drawing.Point(1056, 150);
            this.btnExport_.Name = "btnExport_";
            this.btnExport_.Size = new System.Drawing.Size(79, 64);
            this.btnExport_.TabIndex = 9;
            this.btnExport_.UseVisualStyleBackColor = true;
            this.btnExport_.Click += new System.EventHandler(this.btnExport__Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 713);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Product";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ShelfLife)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ListProduct;
        private System.Windows.Forms.TextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.PictureBox pic_Product;
        private FontAwesome.Sharp.IconButton btn_Upload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_Status;
        private System.Windows.Forms.NumericUpDown num_Count;
        private System.Windows.Forms.ComboBox cbb_Supplier;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.ComboBox cbb_UnitCaculator;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private System.Windows.Forms.ComboBox cbb_TypeProduct;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private System.Windows.Forms.ComboBox cbb_UnitTime;
        private System.Windows.Forms.NumericUpDown num_ShelfLife;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_ProductStatus;
        private System.Windows.Forms.ImageList imageList1;
        private FontAwesome.Sharp.IconButton btnExport_;
    }
}