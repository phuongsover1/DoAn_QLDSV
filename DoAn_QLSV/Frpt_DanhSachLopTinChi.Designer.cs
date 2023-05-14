namespace DoAn_QLSV
{
	partial class Frpt_DanhSachLopTinChi
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnInDSLTC = new DevExpress.XtraEditors.SimpleButton();
			this.cmbHocKy = new System.Windows.Forms.ComboBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.groupControl1.Controls.Add(this.btnInDSLTC);
			this.groupControl1.Controls.Add(this.cmbHocKy);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.cmbNienKhoa);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.cmbKhoa);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
			this.groupControl1.Size = new System.Drawing.Size(918, 398);
			this.groupControl1.TabIndex = 5;
			// 
			// btnInDSLTC
			// 
			this.btnInDSLTC.Location = new System.Drawing.Point(699, 21);
			this.btnInDSLTC.Name = "btnInDSLTC";
			this.btnInDSLTC.Size = new System.Drawing.Size(94, 23);
			this.btnInDSLTC.TabIndex = 12;
			this.btnInDSLTC.Text = "Xem Báo Cáo";
			this.btnInDSLTC.Click += new System.EventHandler(this.btnInDSLTC_Click);
			// 
			// cmbHocKy
			// 
			this.cmbHocKy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHocKy.FormattingEnabled = true;
			this.cmbHocKy.Location = new System.Drawing.Point(569, 23);
			this.cmbHocKy.Name = "cmbHocKy";
			this.cmbHocKy.Size = new System.Drawing.Size(91, 21);
			this.cmbHocKy.TabIndex = 11;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(526, 26);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(37, 13);
			this.labelControl3.TabIndex = 10;
			this.labelControl3.Text = "Học Kỳ:";
			// 
			// cmbNienKhoa
			// 
			this.cmbNienKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNienKhoa.FormattingEnabled = true;
			this.cmbNienKhoa.Location = new System.Drawing.Point(417, 23);
			this.cmbNienKhoa.Name = "cmbNienKhoa";
			this.cmbNienKhoa.Size = new System.Drawing.Size(89, 21);
			this.cmbNienKhoa.TabIndex = 9;
			this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(359, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(52, 13);
			this.labelControl2.TabIndex = 8;
			this.labelControl2.Text = "Niên Khóa:";
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Location = new System.Drawing.Point(137, 23);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(193, 21);
			this.cmbKhoa.TabIndex = 5;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(103, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Khoa:";
			// 
			// Frpt_DanhSachLopTinChi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 398);
			this.Controls.Add(this.groupControl1);
			this.Name = "Frpt_DanhSachLopTinChi";
			this.Text = "In Danh Sách Lớp Tín Chỉ";
			this.Load += new System.EventHandler(this.Frpt_DanhSachLopTinChi_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.SimpleButton btnInDSLTC;
		public System.Windows.Forms.ComboBox cmbKhoa;
		public System.Windows.Forms.ComboBox cmbNienKhoa;
		public System.Windows.Forms.ComboBox cmbHocKy;
	}
}