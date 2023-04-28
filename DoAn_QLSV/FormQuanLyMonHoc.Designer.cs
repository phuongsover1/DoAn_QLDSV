namespace DoAn_QLSV
{
	partial class FormQuanLyMonHoc
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
			this.btnSua = new DevExpress.XtraEditors.SimpleButton();
			this.btnReload = new DevExpress.XtraEditors.SimpleButton();
			this.btnThem = new DevExpress.XtraEditors.SimpleButton();
			this.gridMonHoc = new DevExpress.XtraGrid.GridControl();
			this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.groupControlThongTinMonHoc = new DevExpress.XtraEditors.GroupControl();
			this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinMonHoc)).BeginInit();
			this.groupControlThongTinMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnXoa);
			this.groupControl1.Controls.Add(this.btnSua);
			this.groupControl1.Controls.Add(this.btnReload);
			this.groupControl1.Controls.Add(this.btnThem);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
			this.groupControl1.Size = new System.Drawing.Size(1095, 76);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Điều Khiển";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(196, 33);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 7;
			this.btnXoa.Text = "Xóa";
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(103, 33);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 6;
			this.btnSua.Text = "Sửa";
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(286, 33);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 4;
			this.btnReload.Text = "Reload";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(12, 33);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			// 
			// gridMonHoc
			// 
			this.gridMonHoc.DataSource = this.mONHOCBindingSource;
			this.gridMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMonHoc.Location = new System.Drawing.Point(0, 76);
			this.gridMonHoc.MainView = this.gridView1;
			this.gridMonHoc.Name = "gridMonHoc";
			this.gridMonHoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
			this.gridMonHoc.Size = new System.Drawing.Size(1095, 424);
			this.gridMonHoc.TabIndex = 6;
			this.gridMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// mONHOCBindingSource
			// 
			this.mONHOCBindingSource.DataSource = typeof(DoAn_QLSV.MONHOC);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
			this.gridView1.GridControl = this.gridMonHoc;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.ReadOnly = true;
			// 
			// colMAMH
			// 
			this.colMAMH.FieldName = "MAMH";
			this.colMAMH.Name = "colMAMH";
			this.colMAMH.Visible = true;
			this.colMAMH.VisibleIndex = 0;
			// 
			// colTENMH
			// 
			this.colTENMH.FieldName = "TENMH";
			this.colTENMH.Name = "colTENMH";
			this.colTENMH.Visible = true;
			this.colTENMH.VisibleIndex = 1;
			// 
			// colSOTIET_LT
			// 
			this.colSOTIET_LT.FieldName = "SOTIET_LT";
			this.colSOTIET_LT.Name = "colSOTIET_LT";
			this.colSOTIET_LT.Visible = true;
			this.colSOTIET_LT.VisibleIndex = 2;
			// 
			// colSOTIET_TH
			// 
			this.colSOTIET_TH.FieldName = "SOTIET_TH";
			this.colSOTIET_TH.Name = "colSOTIET_TH";
			this.colSOTIET_TH.Visible = true;
			this.colSOTIET_TH.VisibleIndex = 3;
			// 
			// btnEdit
			// 
			this.btnEdit.AutoHeight = false;
			this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.btnEdit.Name = "btnEdit";
			// 
			// groupControlThongTinMonHoc
			// 
			this.groupControlThongTinMonHoc.Controls.Add(this.btnHuy);
			this.groupControlThongTinMonHoc.Controls.Add(this.btnLuu);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtMaKhoa);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl5);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtKhoaHoc);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl4);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtTenLop);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl3);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtMaLop);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl2);
			this.groupControlThongTinMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControlThongTinMonHoc.Location = new System.Drawing.Point(0, 284);
			this.groupControlThongTinMonHoc.Name = "groupControlThongTinMonHoc";
			this.groupControlThongTinMonHoc.Size = new System.Drawing.Size(1095, 216);
			this.groupControlThongTinMonHoc.TabIndex = 7;
			this.groupControlThongTinMonHoc.Text = "Thông Tin Của Lớp";
			this.groupControlThongTinMonHoc.Visible = false;
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(484, 151);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 8;
			this.btnHuy.Text = "Hủy";
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(391, 151);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 6;
			this.btnLuu.Text = "Lưu";
			// 
			// txtMaKhoa
			// 
			this.txtMaKhoa.Location = new System.Drawing.Point(423, 100);
			this.txtMaKhoa.Name = "txtMaKhoa";
			this.txtMaKhoa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtMaKhoa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtMaKhoa.Properties.ReadOnly = true;
			this.txtMaKhoa.Size = new System.Drawing.Size(179, 20);
			this.txtMaKhoa.TabIndex = 7;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(325, 103);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(92, 13);
			this.labelControl5.TabIndex = 6;
			this.labelControl5.Text = "Số Tiết Thực Hành:";
			// 
			// txtKhoaHoc
			// 
			this.txtKhoaHoc.Location = new System.Drawing.Point(423, 56);
			this.txtKhoaHoc.Name = "txtKhoaHoc";
			this.txtKhoaHoc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtKhoaHoc.Size = new System.Drawing.Size(179, 20);
			this.txtKhoaHoc.TabIndex = 5;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(325, 59);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(88, 13);
			this.labelControl4.TabIndex = 4;
			this.labelControl4.Text = "Số Tiết Lý Thuyết:";
			// 
			// txtTenLop
			// 
			this.txtTenLop.Location = new System.Drawing.Point(116, 100);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.Size = new System.Drawing.Size(179, 20);
			this.txtTenLop.TabIndex = 3;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(47, 103);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(66, 13);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Tên Môn Học:";
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(116, 56);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Size = new System.Drawing.Size(179, 20);
			this.txtMaLop.TabIndex = 1;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(48, 59);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(62, 13);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "Mã Môn Học:";
			// 
			// FormQuanLyMonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 500);
			this.Controls.Add(this.groupControlThongTinMonHoc);
			this.Controls.Add(this.gridMonHoc);
			this.Controls.Add(this.groupControl1);
			this.Name = "FormQuanLyMonHoc";
			this.Text = "Quản Lý Môn Học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormQuanLyMonHoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinMonHoc)).EndInit();
			this.groupControlThongTinMonHoc.ResumeLayout(false);
			this.groupControlThongTinMonHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnXoa;
		private DevExpress.XtraEditors.SimpleButton btnSua;
		private DevExpress.XtraEditors.SimpleButton btnReload;
		private DevExpress.XtraEditors.SimpleButton btnThem;
		private DevExpress.XtraGrid.GridControl gridMonHoc;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
		private DevExpress.XtraEditors.GroupControl groupControlThongTinMonHoc;
		private DevExpress.XtraEditors.SimpleButton btnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraEditors.TextEdit txtMaKhoa;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtTenLop;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtMaLop;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.BindingSource mONHOCBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
		private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
		private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
		private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
	}
}