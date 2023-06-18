namespace DoAn_QLSV
{
    partial class FormTaoTaiKhoan
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
			this.rdPGV = new System.Windows.Forms.RadioButton();
			this.rdKhoa = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
			this.txtXacNhanMatKhau = new DevExpress.XtraEditors.TextEdit();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnChonNhanVien = new System.Windows.Forms.Button();
			this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rdKeToan = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.teTK = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teTK.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// rdPGV
			// 
			this.rdPGV.AutoSize = true;
			this.rdPGV.Location = new System.Drawing.Point(412, 316);
			this.rdPGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdPGV.Name = "rdPGV";
			this.rdPGV.Size = new System.Drawing.Size(44, 17);
			this.rdPGV.TabIndex = 41;
			this.rdPGV.Text = "PGV";
			this.rdPGV.UseVisualStyleBackColor = true;
			// 
			// rdKhoa
			// 
			this.rdKhoa.AutoSize = true;
			this.rdKhoa.Checked = true;
			this.rdKhoa.Location = new System.Drawing.Point(285, 316);
			this.rdKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdKhoa.Name = "rdKhoa";
			this.rdKhoa.Size = new System.Drawing.Size(49, 17);
			this.rdKhoa.TabIndex = 40;
			this.rdKhoa.TabStop = true;
			this.rdKhoa.Text = "Khoa";
			this.rdKhoa.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(124, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 39;
			this.label2.Text = "Vai Trò";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Red;
			this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(399, 388);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(131, 36);
			this.btnThoat.TabIndex = 38;
			this.btnThoat.Text = "THOÁT";
			this.btnThoat.UseVisualStyleBackColor = false;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
			this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXacNhan.ForeColor = System.Drawing.Color.White;
			this.btnXacNhan.Location = new System.Drawing.Point(128, 388);
			this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(131, 36);
			this.btnXacNhan.TabIndex = 37;
			this.btnXacNhan.Text = "XÁC NHẬN";
			this.btnXacNhan.UseVisualStyleBackColor = false;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.EditValue = "123456";
			this.txtMatKhau.Location = new System.Drawing.Point(285, 222);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Properties.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(107, 20);
			this.txtMatKhau.TabIndex = 36;
			// 
			// txtXacNhanMatKhau
			// 
			this.txtXacNhanMatKhau.EditValue = "123456";
			this.txtXacNhanMatKhau.Location = new System.Drawing.Point(285, 270);
			this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
			this.txtXacNhanMatKhau.Properties.PasswordChar = '*';
			this.txtXacNhanMatKhau.Size = new System.Drawing.Size(107, 20);
			this.txtXacNhanMatKhau.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(124, 269);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 17);
			this.label5.TabIndex = 34;
			this.label5.Text = "Xác Nhận Mật Khẩu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(124, 225);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 17);
			this.label4.TabIndex = 33;
			this.label4.Text = "Mật Khẩu";
			// 
			// btnChonNhanVien
			// 
			this.btnChonNhanVien.Location = new System.Drawing.Point(412, 150);
			this.btnChonNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnChonNhanVien.Name = "btnChonNhanVien";
			this.btnChonNhanVien.Size = new System.Drawing.Size(118, 27);
			this.btnChonNhanVien.TabIndex = 32;
			this.btnChonNhanVien.Text = "Chọn Giảng Viên";
			this.btnChonNhanVien.UseVisualStyleBackColor = true;
			this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
			// 
			// txtMaNhanVien
			// 
			this.txtMaNhanVien.Enabled = false;
			this.txtMaNhanVien.Location = new System.Drawing.Point(285, 150);
			this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaNhanVien.Name = "txtMaNhanVien";
			this.txtMaNhanVien.Size = new System.Drawing.Size(107, 20);
			this.txtMaNhanVien.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(124, 153);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 17);
			this.label3.TabIndex = 30;
			this.label3.Text = "Mã Giảng Viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(226, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 29);
			this.label1.TabIndex = 29;
			this.label1.Text = "TẠO TÀI KHOẢN";
			// 
			// rdKeToan
			// 
			this.rdKeToan.AutoSize = true;
			this.rdKeToan.Location = new System.Drawing.Point(498, 316);
			this.rdKeToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdKeToan.Name = "rdKeToan";
			this.rdKeToan.Size = new System.Drawing.Size(62, 17);
			this.rdKeToan.TabIndex = 42;
			this.rdKeToan.Text = "Kế toán";
			this.rdKeToan.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(124, 190);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 17);
			this.label6.TabIndex = 43;
			this.label6.Text = "Tài khoản";
			// 
			// teTK
			// 
			this.teTK.Location = new System.Drawing.Point(285, 190);
			this.teTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.teTK.Name = "teTK";
			this.teTK.Size = new System.Drawing.Size(107, 20);
			this.teTK.TabIndex = 44;
			// 
			// FormTaoTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 492);
			this.Controls.Add(this.teTK);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.rdKeToan);
			this.Controls.Add(this.rdPGV);
			this.Controls.Add(this.rdKhoa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtXacNhanMatKhau);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnChonNhanVien);
			this.Controls.Add(this.txtMaNhanVien);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "FormTaoTaiKhoan";
			this.Text = "Tạo Tài Khoản";
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teTK.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdPGV;
        private System.Windows.Forms.RadioButton rdKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChonNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdKeToan;
		private System.Windows.Forms.Label label6;
		private DevExpress.XtraEditors.TextEdit teTK;
	}
}