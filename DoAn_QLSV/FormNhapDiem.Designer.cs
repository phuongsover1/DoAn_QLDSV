namespace DoAn_QLSV
{
	partial class FormNhapDiem
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
			this.btnReload = new DevExpress.XtraEditors.SimpleButton();
			this.cmbHocKy = new System.Windows.Forms.ComboBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.btnNhapDiem = new DevExpress.XtraEditors.SimpleButton();
			this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
			this.btnTaiLopTinChi = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.gridLTC = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControlSV = new DevExpress.XtraEditors.GroupControl();
			this.gridSV = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTenSV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIEM_HM = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			this.groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLTC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlSV)).BeginInit();
			this.groupControlSV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.groupControl1.Controls.Add(this.btnReload);
			this.groupControl1.Controls.Add(this.cmbHocKy);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.cmbNienKhoa);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.cmbKhoa);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.btnNhapDiem);
			this.groupControl1.Controls.Add(this.btnGhi);
			this.groupControl1.Controls.Add(this.btnTaiLopTinChi);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
			this.groupControl1.Size = new System.Drawing.Size(1074, 62);
			this.groupControl1.TabIndex = 7;
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(987, 21);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 13;
			this.btnReload.Text = "Reload Form";
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// cmbHocKy
			// 
			this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHocKy.FormattingEnabled = true;
			this.cmbHocKy.Location = new System.Drawing.Point(510, 23);
			this.cmbHocKy.Name = "cmbHocKy";
			this.cmbHocKy.Size = new System.Drawing.Size(80, 21);
			this.cmbHocKy.TabIndex = 12;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(467, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(37, 13);
			this.labelControl2.TabIndex = 11;
			this.labelControl2.Text = "Học Kỳ:";
			// 
			// cmbNienKhoa
			// 
			this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNienKhoa.FormattingEnabled = true;
			this.cmbNienKhoa.Location = new System.Drawing.Point(330, 23);
			this.cmbNienKhoa.Name = "cmbNienKhoa";
			this.cmbNienKhoa.Size = new System.Drawing.Size(106, 21);
			this.cmbNienKhoa.TabIndex = 10;
			this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(272, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(52, 13);
			this.labelControl1.TabIndex = 9;
			this.labelControl1.Text = "Niên Khóa:";
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Location = new System.Drawing.Point(42, 23);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(197, 21);
			this.cmbKhoa.TabIndex = 8;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(8, 26);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(28, 13);
			this.labelControl9.TabIndex = 7;
			this.labelControl9.Text = "Khoa:";
			// 
			// btnNhapDiem
			// 
			this.btnNhapDiem.Location = new System.Drawing.Point(769, 21);
			this.btnNhapDiem.Name = "btnNhapDiem";
			this.btnNhapDiem.Size = new System.Drawing.Size(75, 23);
			this.btnNhapDiem.TabIndex = 6;
			this.btnNhapDiem.Text = "Nhập Điểm";
			this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Location = new System.Drawing.Point(881, 21);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(75, 23);
			this.btnGhi.TabIndex = 4;
			this.btnGhi.Text = "Ghi Điểm";
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnTaiLopTinChi
			// 
			this.btnTaiLopTinChi.Location = new System.Drawing.Point(635, 21);
			this.btnTaiLopTinChi.Name = "btnTaiLopTinChi";
			this.btnTaiLopTinChi.Size = new System.Drawing.Size(96, 23);
			this.btnTaiLopTinChi.TabIndex = 0;
			this.btnTaiLopTinChi.Text = "Tải Lớp Tín Chỉ";
			this.btnTaiLopTinChi.Click += new System.EventHandler(this.btnTaiLopTinChi_Click);
			// 
			// groupControl2
			// 
			this.groupControl2.Location = new System.Drawing.Point(522, 207);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(8, 8);
			this.groupControl2.TabIndex = 8;
			this.groupControl2.Text = "groupControl2";
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.gridLTC);
			this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl3.Location = new System.Drawing.Point(0, 62);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(1074, 170);
			this.groupControl3.TabIndex = 9;
			this.groupControl3.Text = "Danh Sách Lớp Tín Chỉ Đã Tải Được";
			// 
			// gridLTC
			// 
			this.gridLTC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridLTC.Location = new System.Drawing.Point(2, 23);
			this.gridLTC.MainView = this.gridView1;
			this.gridLTC.Name = "gridLTC";
			this.gridLTC.Size = new System.Drawing.Size(1070, 145);
			this.gridLTC.TabIndex = 0;
			this.gridLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridLTC;
			this.gridView1.Name = "gridView1";
			// 
			// groupControlSV
			// 
			this.groupControlSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControlSV.Controls.Add(this.gridSV);
			this.groupControlSV.Location = new System.Drawing.Point(0, 233);
			this.groupControlSV.Name = "groupControlSV";
			this.groupControlSV.Size = new System.Drawing.Size(1074, 243);
			this.groupControlSV.TabIndex = 10;
			this.groupControlSV.Text = "Danh Sách Sinh Viên Trong Lớp Tín Chỉ Đã Chọn";
			// 
			// gridSV
			// 
			this.gridSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSV.Location = new System.Drawing.Point(2, 23);
			this.gridSV.MainView = this.gridView2;
			this.gridSV.Name = "gridSV";
			this.gridSV.Size = new System.Drawing.Size(1070, 218);
			this.gridSV.TabIndex = 0;
			this.gridSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSV,
            this.colTenSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_HM});
			this.gridView2.GridControl = this.gridSV;
			this.gridView2.Name = "gridView2";
			this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
			// 
			// colMaSV
			// 
			this.colMaSV.Caption = "Mã Sinh Viên";
			this.colMaSV.FieldName = "MASV";
			this.colMaSV.Name = "colMaSV";
			this.colMaSV.OptionsColumn.ReadOnly = true;
			this.colMaSV.Visible = true;
			this.colMaSV.VisibleIndex = 0;
			// 
			// colTenSV
			// 
			this.colTenSV.Caption = "Họ Tên Sinh Viên";
			this.colTenSV.FieldName = "HOTENSV";
			this.colTenSV.Name = "colTenSV";
			this.colTenSV.OptionsColumn.ReadOnly = true;
			this.colTenSV.Visible = true;
			this.colTenSV.VisibleIndex = 1;
			// 
			// colDIEM_CC
			// 
			this.colDIEM_CC.Caption = "Điểm Chuyên Cần";
			this.colDIEM_CC.FieldName = "DIEM_CC";
			this.colDIEM_CC.Name = "colDIEM_CC";
			this.colDIEM_CC.Visible = true;
			this.colDIEM_CC.VisibleIndex = 2;
			// 
			// colDIEM_GK
			// 
			this.colDIEM_GK.Caption = "Điểm Giữa Kỳ";
			this.colDIEM_GK.FieldName = "DIEM_GK";
			this.colDIEM_GK.Name = "colDIEM_GK";
			this.colDIEM_GK.Visible = true;
			this.colDIEM_GK.VisibleIndex = 3;
			// 
			// colDIEM_CK
			// 
			this.colDIEM_CK.Caption = "Điểm Cuối Kỳ";
			this.colDIEM_CK.FieldName = "DIEM_CK";
			this.colDIEM_CK.Name = "colDIEM_CK";
			this.colDIEM_CK.Visible = true;
			this.colDIEM_CK.VisibleIndex = 4;
			// 
			// colDIEM_HM
			// 
			this.colDIEM_HM.Caption = "Điểm Hết Môn";
			this.colDIEM_HM.FieldName = "DIEM_HM";
			this.colDIEM_HM.Name = "colDIEM_HM";
			this.colDIEM_HM.OptionsColumn.ReadOnly = true;
			this.colDIEM_HM.Visible = true;
			this.colDIEM_HM.VisibleIndex = 5;
			// 
			// FormNhapDiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 522);
			this.Controls.Add(this.groupControlSV);
			this.Controls.Add(this.groupControl3);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Name = "FormNhapDiem";
			this.Text = "Nhập Điểm";
			this.Load += new System.EventHandler(this.FormNhapDiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			this.groupControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridLTC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlSV)).EndInit();
			this.groupControlSV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.ComboBox cmbKhoa;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.SimpleButton btnNhapDiem;
		private DevExpress.XtraEditors.SimpleButton btnGhi;
		private DevExpress.XtraEditors.SimpleButton btnTaiLopTinChi;
		private System.Windows.Forms.ComboBox cmbHocKy;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.ComboBox cmbNienKhoa;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraGrid.GridControl gridLTC;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControlSV;
		private DevExpress.XtraGrid.GridControl gridSV;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.SimpleButton btnReload;
		private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
		private DevExpress.XtraGrid.Columns.GridColumn colTenSV;
		private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
		private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
		private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
		private DevExpress.XtraGrid.Columns.GridColumn colDIEM_HM;
	}
}