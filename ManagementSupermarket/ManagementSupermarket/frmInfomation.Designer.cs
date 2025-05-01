namespace ManagementSupermarket
{
    partial class frmInfomation
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_RoleName = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.rad_Female = new System.Windows.Forms.RadioButton();
            this.rad_Male = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.pic_Avatar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ID.Location = new System.Drawing.Point(690, 20);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(37, 29);
            this.lbl_ID.TabIndex = 33;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_RoleName
            // 
            this.lbl_RoleName.AutoSize = true;
            this.lbl_RoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_RoleName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_RoleName.Location = new System.Drawing.Point(690, 152);
            this.lbl_RoleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RoleName.Name = "lbl_RoleName";
            this.lbl_RoleName.Size = new System.Drawing.Size(56, 29);
            this.lbl_RoleName.TabIndex = 32;
            this.lbl_RoleName.Text = "Tên";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Phone.Location = new System.Drawing.Point(697, 401);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(257, 36);
            this.txt_Phone.TabIndex = 31;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Address.Location = new System.Drawing.Point(697, 336);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(417, 36);
            this.txt_Address.TabIndex = 30;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_CCCD.Location = new System.Drawing.Point(697, 206);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.MaxLength = 12;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(313, 36);
            this.txt_CCCD.TabIndex = 29;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_FullName.Location = new System.Drawing.Point(697, 81);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(313, 36);
            this.txt_FullName.TabIndex = 28;
            // 
            // rad_Female
            // 
            this.rad_Female.AutoSize = true;
            this.rad_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rad_Female.ForeColor = System.Drawing.Color.White;
            this.rad_Female.Location = new System.Drawing.Point(839, 274);
            this.rad_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Female.Name = "rad_Female";
            this.rad_Female.Size = new System.Drawing.Size(66, 33);
            this.rad_Female.TabIndex = 20;
            this.rad_Female.TabStop = true;
            this.rad_Female.Text = "Nữ";
            this.rad_Female.UseVisualStyleBackColor = true;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rad_Male.ForeColor = System.Drawing.Color.White;
            this.rad_Male.Location = new System.Drawing.Point(697, 274);
            this.rad_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.Size = new System.Drawing.Size(88, 33);
            this.rad_Male.TabIndex = 19;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "Nam";
            this.rad_Male.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(545, 278);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "Giới Tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(570, 343);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 29);
            this.label13.TabIndex = 24;
            this.label13.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(596, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(574, 213);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "CCCD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(542, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chức Vụ: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(471, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tên Nhân Viên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(479, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã Nhân Viên: ";
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(697, 463);
            this.btn_Alter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(95, 65);
            this.btn_Alter.TabIndex = 34;
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackColor = System.Drawing.Color.White;
            this.pic_Avatar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_Avatar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pic_Avatar.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_Avatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pic_Avatar.IconSize = 395;
            this.pic_Avatar.Location = new System.Drawing.Point(6, 10);
            this.pic_Avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(395, 533);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Avatar.TabIndex = 18;
            this.pic_Avatar.TabStop = false;
            // 
            // frmInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1121, 552);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_RoleName);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.rad_Female);
            this.Controls.Add(this.rad_Male);
            this.Controls.Add(this.pic_Avatar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmInfomation";
            this.Text = "frmInfomation";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Alter;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_RoleName;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.RadioButton rad_Female;
        private System.Windows.Forms.RadioButton rad_Male;
        private FontAwesome.Sharp.IconPictureBox pic_Avatar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}