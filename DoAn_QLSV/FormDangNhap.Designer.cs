namespace DoAn_QLSV
{
	partial class FormDangNhap
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
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
			this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(26, 82);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(51, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Tài Khoản:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(26, 125);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(49, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Mật Khẩu:";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Location = new System.Drawing.Point(83, 167);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(134, 23);
			this.btnDangNhap.TabIndex = 4;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(255, 167);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(137, 23);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.AutoSize = true;
			this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.groupControl1.Controls.Add(this.cmbKhoa);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtTaiKhoan);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.btnThoat);
			this.groupControl1.Controls.Add(this.btnDangNhap);
			this.groupControl1.Controls.Add(this.txtMatKhau);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.ShowCaption = false;
			this.groupControl1.Size = new System.Drawing.Size(731, 434);
			this.groupControl1.TabIndex = 6;
			this.groupControl1.Text = "groupControl1";
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Location = new System.Drawing.Point(83, 34);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(418, 21);
			this.cmbKhoa.TabIndex = 7;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(26, 37);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(28, 13);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Khoa:";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.EditValue = "kt";
			this.txtTaiKhoan.Location = new System.Drawing.Point(83, 79);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(418, 20);
			this.txtTaiKhoan.TabIndex = 1;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.EditValue = "1234";
			this.txtMatKhau.Location = new System.Drawing.Point(83, 122);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Properties.UseSystemPasswordChar = true;
			this.txtMatKhau.Size = new System.Drawing.Size(418, 20);
			this.txtMatKhau.TabIndex = 3;
			// 
			// FormDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(731, 434);
			this.Controls.Add(this.groupControl1);
			this.Name = "FormDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.FormDangNhap_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
		private DevExpress.XtraEditors.TextEdit txtMatKhau;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton btnDangNhap;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		public System.Windows.Forms.ComboBox cmbKhoa;
		public DevExpress.XtraEditors.GroupControl groupControl1;
	}
}