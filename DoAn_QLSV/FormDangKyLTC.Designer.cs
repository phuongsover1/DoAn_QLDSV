
namespace DoAn_QLSV
{
    partial class FormDangKyLTC
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
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKyLTC));
			this.qLDSV_TCDataSet = new DoAn_QLSV.QLDSV_TCDataSet();
			this.sp_DSLTCCoTheDangKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sp_DSLTCCoTheDangKiTableAdapter = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.sp_DSLTCCoTheDangKiTableAdapter();
			this.tableAdapterManager = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
			this.sp_DSLTCCoTheDangKiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.fillToolStrip = new System.Windows.Forms.ToolStrip();
			this.nKToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.nKToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.hKToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.hKToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.sp_DSLTCCoTheDangKiGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.sp_ltc_sv_dangki_trong_ki_nayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.sp_ltc_sv_dangki_trong_ki_nayTableAdapter();
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Hoc = new System.Windows.Forms.GroupBox();
			this.btnHuy = new System.Windows.Forms.Button();
			this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
			this.txtMaLTC = new DevExpress.XtraEditors.TextEdit();
			this.txtNhom = new DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.TSMatKhau = new DevExpress.XtraEditors.TextEdit();
			this.TSMaSV = new DevExpress.XtraEditors.TextEdit();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiBindingNavigator)).BeginInit();
			this.sp_DSLTCCoTheDangKiBindingNavigator.SuspendLayout();
			this.fillToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_ltc_sv_dangki_trong_ki_nayBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_ltc_sv_dangki_trong_ki_nayGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.Hoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TSMatKhau.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TSMaSV.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(21, 100);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(34, 13);
			label4.TabIndex = 21;
			label4.Text = "Nhóm";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(21, 70);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(75, 13);
			label5.TabIndex = 20;
			label5.Text = "Tên môn học: ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(21, 37);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(49, 13);
			label6.TabIndex = 19;
			label6.Text = "Mã LTC: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(21, 70);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(51, 13);
			label2.TabIndex = 20;
			label2.Text = "Mật khẩu";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(21, 37);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(40, 13);
			label3.TabIndex = 19;
			label3.Text = "Mã SV:";
			// 
			// qLDSV_TCDataSet
			// 
			this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
			this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sp_DSLTCCoTheDangKiBindingSource
			// 
			this.sp_DSLTCCoTheDangKiBindingSource.DataMember = "sp_DSLTCCoTheDangKi";
			this.sp_DSLTCCoTheDangKiBindingSource.DataSource = this.qLDSV_TCDataSet;
			// 
			// sp_DSLTCCoTheDangKiTableAdapter
			// 
			this.sp_DSLTCCoTheDangKiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
			this.tableAdapterManager.DANGKYTableAdapter = null;
			this.tableAdapterManager.GIANGVIENTableAdapter = null;
			this.tableAdapterManager.HOCPHITableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.LOPTINCHITableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sp_DSLTCCoTheDangKiBindingNavigator
			// 
			this.sp_DSLTCCoTheDangKiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.BindingSource = this.sp_DSLTCCoTheDangKiBindingSource;
			this.sp_DSLTCCoTheDangKiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sp_DSLTCCoTheDangKiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem});
			this.sp_DSLTCCoTheDangKiBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sp_DSLTCCoTheDangKiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.Name = "sp_DSLTCCoTheDangKiBindingNavigator";
			this.sp_DSLTCCoTheDangKiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.sp_DSLTCCoTheDangKiBindingNavigator.Size = new System.Drawing.Size(815, 27);
			this.sp_DSLTCCoTheDangKiBindingNavigator.TabIndex = 0;
			this.sp_DSLTCCoTheDangKiBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(43, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// sp_DSLTCCoTheDangKiBindingNavigatorSaveItem
			// 
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Enabled = false;
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Image")));
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Name = "sp_DSLTCCoTheDangKiBindingNavigatorSaveItem";
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.sp_DSLTCCoTheDangKiBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// fillToolStrip
			// 
			this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nKToolStripLabel,
            this.nKToolStripTextBox,
            this.hKToolStripLabel,
            this.hKToolStripTextBox,
            this.fillToolStripButton});
			this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
			this.fillToolStrip.Name = "fillToolStrip";
			this.fillToolStrip.Size = new System.Drawing.Size(815, 25);
			this.fillToolStrip.TabIndex = 1;
			this.fillToolStrip.Text = "fillToolStrip";
			// 
			// nKToolStripLabel
			// 
			this.nKToolStripLabel.Name = "nKToolStripLabel";
			this.nKToolStripLabel.Size = new System.Drawing.Size(26, 22);
			this.nKToolStripLabel.Text = "NK:";
			// 
			// nKToolStripTextBox
			// 
			this.nKToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nKToolStripTextBox.Name = "nKToolStripTextBox";
			this.nKToolStripTextBox.Size = new System.Drawing.Size(86, 25);
			this.nKToolStripTextBox.Click += new System.EventHandler(this.nKToolStripTextBox_Click);
			// 
			// hKToolStripLabel
			// 
			this.hKToolStripLabel.Name = "hKToolStripLabel";
			this.hKToolStripLabel.Size = new System.Drawing.Size(26, 22);
			this.hKToolStripLabel.Text = "HK:";
			// 
			// hKToolStripTextBox
			// 
			this.hKToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hKToolStripTextBox.Name = "hKToolStripTextBox";
			this.hKToolStripTextBox.Size = new System.Drawing.Size(86, 25);
			// 
			// fillToolStripButton
			// 
			this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillToolStripButton.Name = "fillToolStripButton";
			this.fillToolStripButton.Size = new System.Drawing.Size(31, 22);
			this.fillToolStripButton.Text = "Tìm";
			this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
			// 
			// sp_DSLTCCoTheDangKiGridControl
			// 
			this.sp_DSLTCCoTheDangKiGridControl.DataSource = this.sp_DSLTCCoTheDangKiBindingSource;
			this.sp_DSLTCCoTheDangKiGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.sp_DSLTCCoTheDangKiGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sp_DSLTCCoTheDangKiGridControl.Location = new System.Drawing.Point(0, 52);
			this.sp_DSLTCCoTheDangKiGridControl.MainView = this.gridView1;
			this.sp_DSLTCCoTheDangKiGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sp_DSLTCCoTheDangKiGridControl.Name = "sp_DSLTCCoTheDangKiGridControl";
			this.sp_DSLTCCoTheDangKiGridControl.Size = new System.Drawing.Size(815, 213);
			this.sp_DSLTCCoTheDangKiGridControl.TabIndex = 2;
			this.sp_DSLTCCoTheDangKiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.sp_DSLTCCoTheDangKiGridControl.Click += new System.EventHandler(this.sp_DSLTCCoTheDangKiGridControl_Click);
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 284;
			this.gridView1.GridControl = this.sp_DSLTCCoTheDangKiGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// sp_ltc_sv_dangki_trong_ki_nayBindingSource
			// 
			this.sp_ltc_sv_dangki_trong_ki_nayBindingSource.DataMember = "sp_ltc_sv_dangki_trong_ki_nay";
			this.sp_ltc_sv_dangki_trong_ki_nayBindingSource.DataSource = this.qLDSV_TCDataSet;
			// 
			// sp_ltc_sv_dangki_trong_ki_nayTableAdapter
			// 
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.ClearBeforeFill = true;
			// 
			// sp_ltc_sv_dangki_trong_ki_nayGridControl
			// 
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.DataSource = this.sp_ltc_sv_dangki_trong_ki_nayBindingSource;
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.Location = new System.Drawing.Point(404, 275);
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.MainView = this.gridView2;
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.Name = "sp_ltc_sv_dangki_trong_ki_nayGridControl";
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.Size = new System.Drawing.Size(411, 193);
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.TabIndex = 4;
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			this.sp_ltc_sv_dangki_trong_ki_nayGridControl.Click += new System.EventHandler(this.sp_ltc_sv_dangki_trong_ki_nayGridControl_Click);
			// 
			// gridView2
			// 
			this.gridView2.DetailHeight = 284;
			this.gridView2.GridControl = this.sp_ltc_sv_dangki_trong_ki_nayGridControl;
			this.gridView2.Name = "gridView2";
			// 
			// Hoc
			// 
			this.Hoc.Controls.Add(this.btnHuy);
			this.Hoc.Controls.Add(this.txtTenMH);
			this.Hoc.Controls.Add(this.txtMaLTC);
			this.Hoc.Controls.Add(this.txtNhom);
			this.Hoc.Controls.Add(label4);
			this.Hoc.Controls.Add(label5);
			this.Hoc.Controls.Add(label6);
			this.Hoc.Location = new System.Drawing.Point(12, 402);
			this.Hoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Hoc.Name = "Hoc";
			this.Hoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Hoc.Size = new System.Drawing.Size(368, 123);
			this.Hoc.TabIndex = 8;
			this.Hoc.TabStop = false;
			this.Hoc.Text = "Hủy đăng kí";
			// 
			// btnHuy
			// 
			this.btnHuy.Enabled = false;
			this.btnHuy.Location = new System.Drawing.Point(253, 63);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(93, 31);
			this.btnHuy.TabIndex = 33;
			this.btnHuy.Text = "Hủy Đăng ký";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// txtTenMH
			// 
			this.txtTenMH.Enabled = false;
			this.txtTenMH.Location = new System.Drawing.Point(116, 67);
			this.txtTenMH.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenMH.Name = "txtTenMH";
			this.txtTenMH.Size = new System.Drawing.Size(112, 20);
			this.txtTenMH.TabIndex = 32;
			// 
			// txtMaLTC
			// 
			this.txtMaLTC.Enabled = false;
			this.txtMaLTC.Location = new System.Drawing.Point(116, 35);
			this.txtMaLTC.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaLTC.Name = "txtMaLTC";
			this.txtMaLTC.Size = new System.Drawing.Size(111, 20);
			this.txtMaLTC.TabIndex = 31;
			// 
			// txtNhom
			// 
			this.txtNhom.Enabled = false;
			this.txtNhom.Location = new System.Drawing.Point(116, 98);
			this.txtNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNhom.Name = "txtNhom";
			this.txtNhom.Size = new System.Drawing.Size(112, 20);
			this.txtNhom.TabIndex = 28;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Enabled = false;
			this.simpleButton1.Location = new System.Drawing.Point(378, 29);
			this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(81, 24);
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Đăng ký";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.TSMatKhau);
			this.groupBox1.Controls.Add(this.TSMaSV);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Controls.Add(label3);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(12, 282);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(368, 116);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Đăng nhập";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(253, 63);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 31);
			this.button1.TabIndex = 33;
			this.button1.Text = "Đăng nhập";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TSMatKhau
			// 
			this.TSMatKhau.Location = new System.Drawing.Point(116, 67);
			this.TSMatKhau.Margin = new System.Windows.Forms.Padding(4);
			this.TSMatKhau.Name = "TSMatKhau";
			this.TSMatKhau.Size = new System.Drawing.Size(112, 20);
			this.TSMatKhau.TabIndex = 32;
			// 
			// TSMaSV
			// 
			this.TSMaSV.Location = new System.Drawing.Point(116, 35);
			this.TSMaSV.Margin = new System.Windows.Forms.Padding(4);
			this.TSMaSV.Name = "TSMaSV";
			this.TSMaSV.Size = new System.Drawing.Size(111, 20);
			this.TSMaSV.TabIndex = 31;
			// 
			// FormDangKyLTC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 536);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.Hoc);
			this.Controls.Add(this.sp_ltc_sv_dangki_trong_ki_nayGridControl);
			this.Controls.Add(this.sp_DSLTCCoTheDangKiGridControl);
			this.Controls.Add(this.fillToolStrip);
			this.Controls.Add(this.sp_DSLTCCoTheDangKiBindingNavigator);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormDangKyLTC";
			this.Text = "XtraForm1";
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiBindingNavigator)).EndInit();
			this.sp_DSLTCCoTheDangKiBindingNavigator.ResumeLayout(false);
			this.sp_DSLTCCoTheDangKiBindingNavigator.PerformLayout();
			this.fillToolStrip.ResumeLayout(false);
			this.fillToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sp_DSLTCCoTheDangKiGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_ltc_sv_dangki_trong_ki_nayBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_ltc_sv_dangki_trong_ki_nayGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.Hoc.ResumeLayout(false);
			this.Hoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TSMatKhau.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TSMaSV.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource sp_DSLTCCoTheDangKiBindingSource;
        private QLDSV_TCDataSetTableAdapters.sp_DSLTCCoTheDangKiTableAdapter sp_DSLTCCoTheDangKiTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sp_DSLTCCoTheDangKiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sp_DSLTCCoTheDangKiBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nKToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nKToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel hKToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox hKToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sp_DSLTCCoTheDangKiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sp_ltc_sv_dangki_trong_ki_nayBindingSource;
        private QLDSV_TCDataSetTableAdapters.sp_ltc_sv_dangki_trong_ki_nayTableAdapter sp_ltc_sv_dangki_trong_ki_nayTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_ltc_sv_dangki_trong_ki_nayGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox Hoc;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtMaLTC;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private DevExpress.XtraEditors.TextEdit TSMatKhau;
		private DevExpress.XtraEditors.TextEdit TSMaSV;
	}
}