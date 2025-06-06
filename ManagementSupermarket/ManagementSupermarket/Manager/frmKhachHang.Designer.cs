﻿namespace ManagementSupermarket
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_ListCustomer = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_Female = new System.Windows.Forms.RadioButton();
            this.rad_Male = new System.Windows.Forms.RadioButton();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_CreatedTime = new System.Windows.Forms.DateTimePicker();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lbl_ErrorAddress = new System.Windows.Forms.Label();
            this.lbl_ErrorPhone = new System.Windows.Forms.Label();
            this.lbl_ErrorCCCD = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.chk_CustomerStatus = new System.Windows.Forms.CheckBox();
            this.cbb_SearchRole = new System.Windows.Forms.ComboBox();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Location = new System.Drawing.Point(924, 315);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(164, 32);
            this.txt_Search.TabIndex = 15;
            // 
            // dgv_ListCustomer
            // 
            this.dgv_ListCustomer.AllowUserToAddRows = false;
            this.dgv_ListCustomer.AllowUserToDeleteRows = false;
            this.dgv_ListCustomer.AllowUserToOrderColumns = true;
            this.dgv_ListCustomer.AllowUserToResizeColumns = false;
            this.dgv_ListCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListCustomer.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_ListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.CCCD,
            this.SDT,
            this.GioiTinh,
            this.DiaChi,
            this.NgayDangKy,
            this.TrangThai});
            this.dgv_ListCustomer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ListCustomer.Location = new System.Drawing.Point(6, 351);
            this.dgv_ListCustomer.MultiSelect = false;
            this.dgv_ListCustomer.Name = "dgv_ListCustomer";
            this.dgv_ListCustomer.ReadOnly = true;
            this.dgv_ListCustomer.RowHeadersWidth = 51;
            this.dgv_ListCustomer.RowTemplate.Height = 24;
            this.dgv_ListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListCustomer.Size = new System.Drawing.Size(1189, 373);
            this.dgv_ListCustomer.TabIndex = 9;
            this.dgv_ListCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListCustomer_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.DataPropertyName = "NgayDangKy";
            this.NgayDangKy.HeaderText = "Ngày Thêm";
            this.NgayDangKy.MinimumWidth = 6;
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(701, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(226, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(476, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ";
            // 
            // rad_Female
            // 
            this.rad_Female.AutoSize = true;
            this.rad_Female.ForeColor = System.Drawing.Color.Black;
            this.rad_Female.Location = new System.Drawing.Point(139, 32);
            this.rad_Female.Name = "rad_Female";
            this.rad_Female.Size = new System.Drawing.Size(61, 30);
            this.rad_Female.TabIndex = 1;
            this.rad_Female.Text = "Nữ";
            this.rad_Female.UseVisualStyleBackColor = true;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.Checked = true;
            this.rad_Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rad_Male.Location = new System.Drawing.Point(10, 32);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.Size = new System.Drawing.Size(80, 30);
            this.rad_Male.TabIndex = 0;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "Nam";
            this.rad_Male.UseVisualStyleBackColor = true;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Location = new System.Drawing.Point(20, 162);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(604, 73);
            this.txt_Address.TabIndex = 14;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(20, 70);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(177, 32);
            this.txt_ID.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Female);
            this.groupBox1.Controls.Add(this.rad_Male);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(915, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // dtp_CreatedTime
            // 
            this.dtp_CreatedTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_CreatedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreatedTime.Location = new System.Drawing.Point(6, 32);
            this.dtp_CreatedTime.Name = "dtp_CreatedTime";
            this.dtp_CreatedTime.Size = new System.Drawing.Size(228, 32);
            this.dtp_CreatedTime.TabIndex = 11;
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Checked = true;
            this.chk_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Status.Location = new System.Drawing.Point(928, 162);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(138, 30);
            this.chk_Status.TabIndex = 21;
            this.chk_Status.Text = "Hoạt Động";
            this.chk_Status.UseVisualStyleBackColor = true;
            this.chk_Status.CheckedChanged += new System.EventHandler(this.chk_Status_CheckedChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Location = new System.Drawing.Point(706, 70);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(203, 32);
            this.txt_Phone.TabIndex = 19;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Location = new System.Drawing.Point(481, 70);
            this.txt_CCCD.MaxLength = 12;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(203, 32);
            this.txt_CCCD.TabIndex = 18;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FullName.Location = new System.Drawing.Point(231, 70);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(203, 32);
            this.txt_FullName.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_CreatedTime);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(624, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 76);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày Tạo";
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.lbl_ErrorAddress);
            this.grpInfo.Controls.Add(this.lbl_ErrorPhone);
            this.grpInfo.Controls.Add(this.lbl_ErrorCCCD);
            this.grpInfo.Controls.Add(this.lbl_ErrorName);
            this.grpInfo.Controls.Add(this.chk_Status);
            this.grpInfo.Controls.Add(this.txt_Phone);
            this.grpInfo.Controls.Add(this.txt_CCCD);
            this.grpInfo.Controls.Add(this.txt_FullName);
            this.grpInfo.Controls.Add(this.groupBox2);
            this.grpInfo.Controls.Add(this.txt_Address);
            this.grpInfo.Controls.Add(this.txt_ID);
            this.grpInfo.Controls.Add(this.groupBox1);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1198, 241);
            this.grpInfo.TabIndex = 8;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin";
            // 
            // lbl_ErrorAddress
            // 
            this.lbl_ErrorAddress.AutoSize = true;
            this.lbl_ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorAddress.Location = new System.Drawing.Point(97, 139);
            this.lbl_ErrorAddress.Name = "lbl_ErrorAddress";
            this.lbl_ErrorAddress.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorAddress.TabIndex = 25;
            this.lbl_ErrorAddress.Text = "label9";
            this.lbl_ErrorAddress.Visible = false;
            // 
            // lbl_ErrorPhone
            // 
            this.lbl_ErrorPhone.AutoSize = true;
            this.lbl_ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPhone.Location = new System.Drawing.Point(702, 105);
            this.lbl_ErrorPhone.Name = "lbl_ErrorPhone";
            this.lbl_ErrorPhone.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorPhone.TabIndex = 24;
            this.lbl_ErrorPhone.Text = "label7";
            this.lbl_ErrorPhone.Visible = false;
            // 
            // lbl_ErrorCCCD
            // 
            this.lbl_ErrorCCCD.AutoSize = true;
            this.lbl_ErrorCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCCCD.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCCCD.Location = new System.Drawing.Point(477, 105);
            this.lbl_ErrorCCCD.Name = "lbl_ErrorCCCD";
            this.lbl_ErrorCCCD.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorCCCD.TabIndex = 23;
            this.lbl_ErrorCCCD.Text = "label3";
            this.lbl_ErrorCCCD.Visible = false;
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.Location = new System.Drawing.Point(227, 105);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorName.TabIndex = 22;
            this.lbl_ErrorName.Text = "label1";
            this.lbl_ErrorName.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.ImageIndex = 5;
            this.btn_Search.ImageList = this.imageList1;
            this.btn_Search.Location = new System.Drawing.Point(1125, 297);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(59, 48);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "export.png");
            this.imageList1.Images.SetKeyName(3, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(4, "plus.png");
            this.imageList1.Images.SetKeyName(5, "kinhlup.png");
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.ImageIndex = 3;
            this.btn_Refresh.ImageList = this.imageList1;
            this.btn_Refresh.Location = new System.Drawing.Point(352, 283);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 13;
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
            this.btn_Delete.Location = new System.Drawing.Point(177, 283);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.ImageIndex = 4;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(7, 283);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.ImageIndex = 1;
            this.btn_Alter.ImageList = this.imageList1;
            this.btn_Alter.Location = new System.Drawing.Point(92, 283);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 11;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // chk_CustomerStatus
            // 
            this.chk_CustomerStatus.AutoSize = true;
            this.chk_CustomerStatus.Checked = true;
            this.chk_CustomerStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_CustomerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CustomerStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_CustomerStatus.Location = new System.Drawing.Point(437, 305);
            this.chk_CustomerStatus.Name = "chk_CustomerStatus";
            this.chk_CustomerStatus.Size = new System.Drawing.Size(351, 40);
            this.chk_CustomerStatus.TabIndex = 17;
            this.chk_CustomerStatus.Text = "Khách Hàng Hoạt Động";
            this.chk_CustomerStatus.UseVisualStyleBackColor = true;
            // 
            // cbb_SearchRole
            // 
            this.cbb_SearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SearchRole.FormattingEnabled = true;
            this.cbb_SearchRole.Location = new System.Drawing.Point(787, 313);
            this.cbb_SearchRole.Name = "cbb_SearchRole";
            this.cbb_SearchRole.Size = new System.Drawing.Size(131, 34);
            this.cbb_SearchRole.TabIndex = 18;
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExportExcel.ImageIndex = 2;
            this.btn_ExportExcel.ImageList = this.imageList1;
            this.btn_ExportExcel.Location = new System.Drawing.Point(262, 283);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(82, 64);
            this.btn_ExportExcel.TabIndex = 29;
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1307, 736);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.cbb_SearchRole);
            this.Controls.Add(this.chk_CustomerStatus);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ListCustomer);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.DataGridView dgv_ListCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_Female;
        private System.Windows.Forms.RadioButton rad_Male;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_CreatedTime;
        private System.Windows.Forms.CheckBox chk_Status;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lbl_ErrorAddress;
        private System.Windows.Forms.Label lbl_ErrorPhone;
        private System.Windows.Forms.Label lbl_ErrorCCCD;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.CheckBox chk_CustomerStatus;
        private System.Windows.Forms.ComboBox cbb_SearchRole;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.ImageList imageList1;
    }
}