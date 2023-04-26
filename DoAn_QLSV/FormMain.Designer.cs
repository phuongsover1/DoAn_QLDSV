namespace DoAn_QLSV
{
    partial class FormMain
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DoAn_QLSV.SplashScreen1), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroupDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroupTaoTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroupLogout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroupLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribMonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbNhom = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaNV = new DevExpress.XtraEditors.LabelControl();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnLop,
            this.btnSinhVien,
            this.btnMonHoc,
            this.btnDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribTaiKhoan,
            this.ribDanhMuc});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 158);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 4;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.btnTaoTaiKhoan.Id = 10;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.LargeWidth = 80;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 11;
            this.btnLop.ImageOptions.Image = global::DoAn_QLSV.Properties.Resources.class1;
            this.btnLop.ImageOptions.LargeImage = global::DoAn_QLSV.Properties.Resources._class;
            this.btnLop.LargeWidth = 70;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 12;
            this.btnSinhVien.ImageOptions.Image = global::DoAn_QLSV.Properties.Resources.students;
            this.btnSinhVien.ImageOptions.LargeImage = global::DoAn_QLSV.Properties.Resources.students;
            this.btnSinhVien.LargeWidth = 70;
            this.btnSinhVien.Name = "btnSinhVien";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Id = 13;
            this.btnMonHoc.ImageOptions.Image = global::DoAn_QLSV.Properties.Resources.subjects;
            this.btnMonHoc.ImageOptions.LargeImage = global::DoAn_QLSV.Properties.Resources.subjects;
            this.btnMonHoc.LargeWidth = 70;
            this.btnMonHoc.Name = "btnMonHoc";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 14;
            this.btnDangXuat.ImageOptions.Image = global::DoAn_QLSV.Properties.Resources.logout;
            this.btnDangXuat.ImageOptions.LargeImage = global::DoAn_QLSV.Properties.Resources.logout;
            this.btnDangXuat.LargeWidth = 70;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroupDangNhap,
            this.ribGroupTaoTaiKhoan,
            this.ribGroupLogout});
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "Tài Khoản";
            // 
            // ribGroupDangNhap
            // 
            this.ribGroupDangNhap.ItemLinks.Add(this.btnDangNhap);
            this.ribGroupDangNhap.Name = "ribGroupDangNhap";
            this.ribGroupDangNhap.Text = "ModuleDangNhap";
            // 
            // ribGroupTaoTaiKhoan
            // 
            this.ribGroupTaoTaiKhoan.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribGroupTaoTaiKhoan.Name = "ribGroupTaoTaiKhoan";
            this.ribGroupTaoTaiKhoan.Text = "ModuleTaoTaiKhoan";
            // 
            // ribGroupLogout
            // 
            this.ribGroupLogout.ItemLinks.Add(this.btnDangXuat);
            this.ribGroupLogout.Name = "ribGroupLogout";
            this.ribGroupLogout.Text = "Logout";
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroupLop,
            this.ribLop,
            this.ribMonHoc});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "Danh Mục";
            // 
            // ribGroupLop
            // 
            this.ribGroupLop.ItemLinks.Add(this.btnLop);
            this.ribGroupLop.Name = "ribGroupLop";
            this.ribGroupLop.Text = "Lớp";
            // 
            // ribLop
            // 
            this.ribLop.ItemLinks.Add(this.btnSinhVien);
            this.ribLop.Name = "ribLop";
            this.ribLop.Text = "Sinh Viên";
            // 
            // ribMonHoc
            // 
            this.ribMonHoc.ItemLinks.Add(this.btnMonHoc);
            this.ribMonHoc.Name = "ribMonHoc";
            this.ribMonHoc.Text = "Môn Học";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lbNhom);
            this.panelControl1.Controls.Add(this.lbHoTen);
            this.panelControl1.Controls.Add(this.lbMaNV);
            this.panelControl1.Location = new System.Drawing.Point(0, 411);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(758, 35);
            this.panelControl1.TabIndex = 4;
            // 
            // lbNhom
            // 
            this.lbNhom.Location = new System.Drawing.Point(315, 10);
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(53, 13);
            this.lbNhom.TabIndex = 2;
            this.lbNhom.Text = "Nhóm: PGV";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(137, 10);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(154, 13);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên: Lê Nguyễn Duy Phương";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Location = new System.Drawing.Point(12, 10);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(102, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã NV: N19DCCN147";
            // 
            // defaultBarAndDockingController1
            // 
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 446);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTaiKhoan;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        public DevExpress.XtraEditors.LabelControl lbNhom;
        public DevExpress.XtraEditors.LabelControl lbMaNV;
        public DevExpress.XtraEditors.LabelControl lbHoTen;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupTaoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupLop;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupLogout;
    }
}

