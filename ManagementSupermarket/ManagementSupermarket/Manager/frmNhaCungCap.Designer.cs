﻿namespace ManagementSupermarket
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameSupplier = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.chk_StatusDGV = new System.Windows.Forms.CheckBox();
            this.cbb_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.AllowUserToAddRows = false;
            this.dgv_Supplier.AllowUserToDeleteRows = false;
            this.dgv_Supplier.AllowUserToOrderColumns = true;
            this.dgv_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Supplier.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.SDT,
            this.DiaChi,
            this.TrangThai});
            this.dgv_Supplier.Location = new System.Drawing.Point(20, 268);
            this.dgv_Supplier.MultiSelect = false;
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.ReadOnly = true;
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Supplier.Size = new System.Drawing.Size(1218, 629);
            this.dgv_Supplier.TabIndex = 13;
            this.dgv_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Supplier_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Status.ForeColor = System.Drawing.Color.Blue;
            this.chk_Status.Location = new System.Drawing.Point(12, 93);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(276, 33);
            this.chk_Status.TabIndex = 20;
            this.chk_Status.Text = "Trạng Thái Cung Cấp";
            this.chk_Status.UseVisualStyleBackColor = true;
            this.chk_Status.CheckedChanged += new System.EventHandler(this.chk_Status_CheckedChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(636, 41);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(248, 36);
            this.txt_Phone.TabIndex = 19;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(631, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số Điện Thoại";
            // 
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameSupplier.Location = new System.Drawing.Point(283, 41);
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            this.txt_NameSupplier.Size = new System.Drawing.Size(347, 36);
            this.txt_NameSupplier.TabIndex = 17;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(890, 41);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(258, 65);
            this.txt_Address.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(885, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa Chỉ";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(13, 39);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(249, 36);
            this.txt_ID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Nhà Cung Cấp";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(368, 217);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(238, 45);
            this.txt_Search.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_Address);
            this.panel1.Controls.Add(this.lbl_Phone);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.chk_Status);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NameSupplier);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 134);
            this.panel1.TabIndex = 12;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.ForeColor = System.Drawing.Color.Red;
            this.lbl_Address.Location = new System.Drawing.Point(885, 108);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(70, 26);
            this.lbl_Address.TabIndex = 21;
            this.lbl_Address.Text = "label4";
            this.lbl_Address.Visible = false;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phone.Location = new System.Drawing.Point(636, 80);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(70, 26);
            this.lbl_Phone.TabIndex = 21;
            this.lbl_Phone.Text = "label4";
            this.lbl_Phone.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(283, 80);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(70, 26);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "label4";
            this.lbl_Name.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(596, 130);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.ImageIndex = 1;
            this.btn_Alter.ImageList = this.imageList1;
            this.btn_Alter.Location = new System.Drawing.Point(511, 130);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 15;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.ImageIndex = 3;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(426, 130);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.ImageIndex = 2;
            this.btn_Refresh.ImageList = this.imageList1;
            this.btn_Refresh.Location = new System.Drawing.Point(681, 130);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.btn_Search.Location = new System.Drawing.Point(612, 204);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(74, 62);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chk_StatusDGV
            // 
            this.chk_StatusDGV.AutoSize = true;
            this.chk_StatusDGV.Checked = true;
            this.chk_StatusDGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_StatusDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_StatusDGV.ForeColor = System.Drawing.Color.Blue;
            this.chk_StatusDGV.Location = new System.Drawing.Point(16, 217);
            this.chk_StatusDGV.Name = "chk_StatusDGV";
            this.chk_StatusDGV.Size = new System.Drawing.Size(202, 43);
            this.chk_StatusDGV.TabIndex = 22;
            this.chk_StatusDGV.Text = "Hoạt Động";
            this.chk_StatusDGV.UseVisualStyleBackColor = true;
            // 
            // cbb_Search
            // 
            this.cbb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Search.FormattingEnabled = true;
            this.cbb_Search.Items.AddRange(new object[] {
            "MaNCC",
            "SDT",
            "DiaChi"});
            this.cbb_Search.Location = new System.Drawing.Point(235, 216);
            this.cbb_Search.Name = "cbb_Search";
            this.cbb_Search.Size = new System.Drawing.Size(131, 46);
            this.cbb_Search.TabIndex = 23;
            // 
            // frmSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.dgv_Supplier);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cbb_Search);
            this.Controls.Add(this.chk_StatusDGV);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSuppiler";
            this.Text = "frmSuppiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Supplier;
        private System.Windows.Forms.CheckBox chk_Status;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameSupplier;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.CheckBox chk_StatusDGV;
        private System.Windows.Forms.ComboBox cbb_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.ImageList imageList1;
    }
}