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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyMonHoc));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnSua = new DevExpress.XtraEditors.SimpleButton();
			this.btnReload = new DevExpress.XtraEditors.SimpleButton();
			this.btnThem = new DevExpress.XtraEditors.SimpleButton();
			this.gridMonHoc = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupControlThongTinMonHoc = new DevExpress.XtraEditors.GroupControl();
			this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.txtTietTH = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtTietLT = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinMonHoc)).BeginInit();
			this.groupControlThongTinMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTietTH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTietLT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
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
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(103, 33);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 6;
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(198, 33);
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
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// gridMonHoc
			// 
			this.gridMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMonHoc.Location = new System.Drawing.Point(0, 76);
			this.gridMonHoc.MainView = this.gridView1;
			this.gridMonHoc.Name = "gridMonHoc";
			this.gridMonHoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
			this.gridMonHoc.Size = new System.Drawing.Size(1095, 424);
			this.gridMonHoc.TabIndex = 6;
			this.gridMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH,
            this.colDelete});
			this.gridView1.GridControl = this.gridMonHoc;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			// 
			// colMAMH
			// 
			this.colMAMH.FieldName = "MAMH";
			this.colMAMH.Name = "colMAMH";
			this.colMAMH.OptionsColumn.ReadOnly = true;
			this.colMAMH.Visible = true;
			this.colMAMH.VisibleIndex = 0;
			this.colMAMH.Width = 214;
			// 
			// colTENMH
			// 
			this.colTENMH.FieldName = "TENMH";
			this.colTENMH.Name = "colTENMH";
			this.colTENMH.OptionsColumn.ReadOnly = true;
			this.colTENMH.Visible = true;
			this.colTENMH.VisibleIndex = 1;
			this.colTENMH.Width = 214;
			// 
			// colSOTIET_LT
			// 
			this.colSOTIET_LT.FieldName = "SOTIET_LT";
			this.colSOTIET_LT.Name = "colSOTIET_LT";
			this.colSOTIET_LT.OptionsColumn.ReadOnly = true;
			this.colSOTIET_LT.Visible = true;
			this.colSOTIET_LT.VisibleIndex = 2;
			this.colSOTIET_LT.Width = 214;
			// 
			// colSOTIET_TH
			// 
			this.colSOTIET_TH.FieldName = "SOTIET_TH";
			this.colSOTIET_TH.Name = "colSOTIET_TH";
			this.colSOTIET_TH.OptionsColumn.ReadOnly = true;
			this.colSOTIET_TH.Visible = true;
			this.colSOTIET_TH.VisibleIndex = 3;
			this.colSOTIET_TH.Width = 338;
			// 
			// colDelete
			// 
			this.colDelete.Caption = "Xóa";
			this.colDelete.ColumnEdit = this.btnDelete;
			this.colDelete.MinWidth = 10;
			this.colDelete.Name = "colDelete";
			this.colDelete.Visible = true;
			this.colDelete.VisibleIndex = 4;
			this.colDelete.Width = 90;
			// 
			// btnDelete
			// 
			this.btnDelete.AutoHeight = false;
			editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
			this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
			// 
			// mONHOCBindingSource
			// 
			this.mONHOCBindingSource.DataSource = typeof(DoAn_QLSV.MONHOC);
			// 
			// groupControlThongTinMonHoc
			// 
			this.groupControlThongTinMonHoc.Controls.Add(this.btnHuy);
			this.groupControlThongTinMonHoc.Controls.Add(this.btnLuu);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtTietTH);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl5);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtTietLT);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl4);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtTenMH);
			this.groupControlThongTinMonHoc.Controls.Add(this.labelControl3);
			this.groupControlThongTinMonHoc.Controls.Add(this.txtMaMH);
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
			this.btnHuy.Location = new System.Drawing.Point(526, 152);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 6;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(433, 152);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 5;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// txtTietTH
			// 
			this.txtTietTH.Location = new System.Drawing.Point(423, 100);
			this.txtTietTH.Name = "txtTietTH";
			this.txtTietTH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTietTH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTietTH.Size = new System.Drawing.Size(179, 20);
			this.txtTietTH.TabIndex = 4;
			this.txtTietTH.Leave += new System.EventHandler(this.txtTietTH_Leave);
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(325, 103);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(92, 13);
			this.labelControl5.TabIndex = 6;
			this.labelControl5.Text = "Số Tiết Thực Hành:";
			// 
			// txtTietLT
			// 
			this.txtTietLT.Location = new System.Drawing.Point(423, 56);
			this.txtTietLT.Name = "txtTietLT";
			this.txtTietLT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTietLT.Size = new System.Drawing.Size(179, 20);
			this.txtTietLT.TabIndex = 3;
			this.txtTietLT.Leave += new System.EventHandler(this.txtTietLT_Leave);
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(325, 59);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(88, 13);
			this.labelControl4.TabIndex = 4;
			this.labelControl4.Text = "Số Tiết Lý Thuyết:";
			// 
			// txtTenMH
			// 
			this.txtTenMH.Location = new System.Drawing.Point(116, 100);
			this.txtTenMH.Name = "txtTenMH";
			this.txtTenMH.Size = new System.Drawing.Size(179, 20);
			this.txtTenMH.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(47, 103);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(66, 13);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Tên Môn Học:";
			// 
			// txtMaMH
			// 
			this.txtMaMH.Location = new System.Drawing.Point(116, 56);
			this.txtMaMH.Name = "txtMaMH";
			this.txtMaMH.Size = new System.Drawing.Size(179, 20);
			this.txtMaMH.TabIndex = 1;
			this.txtMaMH.Leave += new System.EventHandler(this.txtMaMH_Leave);
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
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinMonHoc)).EndInit();
			this.groupControlThongTinMonHoc.ResumeLayout(false);
			this.groupControlThongTinMonHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTietTH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTietLT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnSua;
		private DevExpress.XtraEditors.SimpleButton btnReload;
		private DevExpress.XtraEditors.SimpleButton btnThem;
		private DevExpress.XtraGrid.GridControl gridMonHoc;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
		private DevExpress.XtraEditors.GroupControl groupControlThongTinMonHoc;
		private DevExpress.XtraEditors.SimpleButton btnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraEditors.TextEdit txtTietTH;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit txtTietLT;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtTenMH;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtMaMH;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.BindingSource mONHOCBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
		private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
		private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
		private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
		private DevExpress.XtraGrid.Columns.GridColumn colDelete;
	}
}