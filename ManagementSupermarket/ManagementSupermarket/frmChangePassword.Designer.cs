namespace ManagementSupermarket
{
    partial class frmChangePassword
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
            this.txtMKHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnHidePassword = new FontAwesome.Sharp.IconButton();
            this.btnHidePassword2 = new FontAwesome.Sharp.IconButton();
            this.btnHidePassword3 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtMKHienTai
            // 
            this.txtMKHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKHienTai.Location = new System.Drawing.Point(516, 114);
            this.txtMKHienTai.Multiline = true;
            this.txtMKHienTai.Name = "txtMKHienTai";
            this.txtMKHienTai.PasswordChar = '*';
            this.txtMKHienTai.Size = new System.Drawing.Size(274, 51);
            this.txtMKHienTai.TabIndex = 0;
            this.txtMKHienTai.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(516, 200);
            this.txtMKMoi.Multiline = true;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(274, 51);
            this.txtMKMoi.TabIndex = 2;
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLai.Location = new System.Drawing.Point(516, 294);
            this.txtNhapLai.Multiline = true;
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(274, 51);
            this.txtNhapLai.TabIndex = 2;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(609, 418);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(150, 58);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(414, 418);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 58);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(447, 369);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(65, 29);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "error";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnHidePassword.IconColor = System.Drawing.Color.Black;
            this.btnHidePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHidePassword.Location = new System.Drawing.Point(797, 114);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(68, 51);
            this.btnHidePassword.TabIndex = 6;
            this.btnHidePassword.UseVisualStyleBackColor = true;
            this.btnHidePassword.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnHidePassword2
            // 
            this.btnHidePassword2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnHidePassword2.IconColor = System.Drawing.Color.Black;
            this.btnHidePassword2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHidePassword2.Location = new System.Drawing.Point(797, 196);
            this.btnHidePassword2.Name = "btnHidePassword2";
            this.btnHidePassword2.Size = new System.Drawing.Size(68, 51);
            this.btnHidePassword2.TabIndex = 6;
            this.btnHidePassword2.UseVisualStyleBackColor = true;
            this.btnHidePassword2.Click += new System.EventHandler(this.btnHidePassword2_Click);
            // 
            // btnHidePassword3
            // 
            this.btnHidePassword3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnHidePassword3.IconColor = System.Drawing.Color.Black;
            this.btnHidePassword3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHidePassword3.Location = new System.Drawing.Point(797, 294);
            this.btnHidePassword3.Name = "btnHidePassword3";
            this.btnHidePassword3.Size = new System.Drawing.Size(68, 51);
            this.btnHidePassword3.TabIndex = 6;
            this.btnHidePassword3.UseVisualStyleBackColor = true;
            this.btnHidePassword3.Click += new System.EventHandler(this.btnHidePassword3_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1023, 551);
            this.Controls.Add(this.btnHidePassword3);
            this.Controls.Add(this.btnHidePassword2);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMKHienTai);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePasswordcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMKHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblError;
        private FontAwesome.Sharp.IconButton btnHidePassword;
        private FontAwesome.Sharp.IconButton btnHidePassword2;
        private FontAwesome.Sharp.IconButton btnHidePassword3;
    }
}