namespace DoAn_QLSV
{
    partial class FormQuanLyLop
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControlThongTinLop = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinLop)).BeginInit();
            this.groupControlThongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(8, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(282, 252);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(282, 252);
            this.Root.TextVisible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.cmbKhoa);
            this.groupControl1.Controls.Add(this.btnReload);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnGhi);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
            this.groupControl1.Size = new System.Drawing.Size(1134, 123);
            this.groupControl1.TabIndex = 4;
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
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(47, 82);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(224, 21);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(196, 33);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Khoa:";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(277, 33);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 23);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "Ghi";
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
            // gridLop
            // 
            this.gridLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLop.Location = new System.Drawing.Point(0, 123);
            this.gridLop.MainView = this.gridView1;
            this.gridLop.Name = "gridLop";
            this.gridLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.gridLop.Size = new System.Drawing.Size(1134, 371);
            this.gridLop.TabIndex = 4;
            this.gridLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridLop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdit.Name = "btnEdit";
            // 
            // groupControlThongTinLop
            // 
            this.groupControlThongTinLop.Controls.Add(this.btnLuu);
            this.groupControlThongTinLop.Controls.Add(this.txtMaKhoa);
            this.groupControlThongTinLop.Controls.Add(this.labelControl5);
            this.groupControlThongTinLop.Controls.Add(this.txtKhoaHoc);
            this.groupControlThongTinLop.Controls.Add(this.labelControl4);
            this.groupControlThongTinLop.Controls.Add(this.txtTenLop);
            this.groupControlThongTinLop.Controls.Add(this.labelControl3);
            this.groupControlThongTinLop.Controls.Add(this.txtMaLop);
            this.groupControlThongTinLop.Controls.Add(this.labelControl2);
            this.groupControlThongTinLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlThongTinLop.Location = new System.Drawing.Point(0, 278);
            this.groupControlThongTinLop.Name = "groupControlThongTinLop";
            this.groupControlThongTinLop.Size = new System.Drawing.Size(1134, 216);
            this.groupControlThongTinLop.TabIndex = 6;
            this.groupControlThongTinLop.Text = "Thông Tin Của Lớp";
            this.groupControlThongTinLop.Visible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(484, 135);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(380, 100);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(179, 20);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(325, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Mã Khoa:";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(380, 56);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(179, 20);
            this.txtKhoaHoc.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(325, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Khóa Học:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(92, 100);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(179, 20);
            this.txtTenLop.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(92, 56);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(179, 20);
            this.txtMaLop.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Lớp:";
            // 
            // FormQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 494);
            this.Controls.Add(this.groupControlThongTinLop);
            this.Controls.Add(this.gridLop);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormQuanLyLop";
            this.Text = "Quản Lý Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinLop)).EndInit();
            this.groupControlThongTinLop.ResumeLayout(false);
            this.groupControlThongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}