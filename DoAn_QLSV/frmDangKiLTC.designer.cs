
using DoAn_QLSV;

namespace QLDSV_TC
{
	partial class frmDangKiLTC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKiLTC));
			this.qLDSV_TCDataSet1 = new DoAn_QLSV.QLDSV_TCDataSet();
			this.sP_LAY_DSSV_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sP_LAY_DSSV_DANGKYTableAdapter = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.SP_LAY_DSSV_DANGKYTableAdapter();
			this.tableAdapterManager1 = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
			this.sP_LAY_DSSV_DANGKYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.mALTCToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.mALTCToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.sP_LAY_DSSV_DANGKYGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingNavigator)).BeginInit();
			this.sP_LAY_DSSV_DANGKYBindingNavigator.SuspendLayout();
			this.fillToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// qLDSV_TCDataSet1
			// 
			this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet";
			this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sP_LAY_DSSV_DANGKYBindingSource
			// 
			this.sP_LAY_DSSV_DANGKYBindingSource.DataMember = "SP_LAY_DSSV_DANGKY";
			this.sP_LAY_DSSV_DANGKYBindingSource.DataSource = this.qLDSV_TCDataSet1;
			// 
			// sP_LAY_DSSV_DANGKYTableAdapter
			// 
			this.sP_LAY_DSSV_DANGKYTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.Connection = null;
			this.tableAdapterManager1.DANGKYTableAdapter = null;
			this.tableAdapterManager1.GIANGVIENTableAdapter = null;
			this.tableAdapterManager1.KHOATableAdapter = null;
			this.tableAdapterManager1.LOPTableAdapter = null;
			this.tableAdapterManager1.LOPTINCHITableAdapter = null;
			this.tableAdapterManager1.MONHOCTableAdapter = null;
			this.tableAdapterManager1.SINHVIENTableAdapter = null;
			this.tableAdapterManager1.UpdateOrder = DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sP_LAY_DSSV_DANGKYBindingNavigator
			// 
			this.sP_LAY_DSSV_DANGKYBindingNavigator.AddNewItem = this.toolStripButton5;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.BindingSource = this.sP_LAY_DSSV_DANGKYBindingSource;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.CountItem = this.toolStripLabel1;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.DeleteItem = this.toolStripButton6;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripButton1,
						this.toolStripButton2,
						this.toolStripSeparator1,
						this.toolStripTextBox1,
						this.toolStripLabel1,
						this.toolStripSeparator2,
						this.toolStripButton3,
						this.toolStripButton4,
						this.toolStripSeparator3,
						this.toolStripButton5,
						this.toolStripButton6,
						this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem});
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveFirstItem = this.toolStripButton1;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveLastItem = this.toolStripButton4;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveNextItem = this.toolStripButton3;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MovePreviousItem = this.toolStripButton2;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Name = "sP_LAY_DSSV_DANGKYBindingNavigator";
			this.sP_LAY_DSSV_DANGKYBindingNavigator.PositionItem = this.toolStripTextBox1;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Size = new System.Drawing.Size(472, 25);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.TabIndex = 0;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Text = "bindingNavigator1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
			this.toolStripButton1.RightToLeftAutoMirrorImage = true;
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Move first";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
			this.toolStripButton2.RightToLeftAutoMirrorImage = true;
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "Move previous";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.AccessibleName = "Position";
			this.toolStripTextBox1.AutoSize = false;
			this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
			this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
			this.toolStripTextBox1.Text = "0";
			this.toolStripTextBox1.ToolTipText = "Current position";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "bindingNavigatorCountItem";
			this.toolStripLabel1.Size = new System.Drawing.Size(35, 15);
			this.toolStripLabel1.Text = "of {0}";
			this.toolStripLabel1.ToolTipText = "Total number of items";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
			this.toolStripButton3.RightToLeftAutoMirrorImage = true;
			this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton3.Text = "Move next";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
			this.toolStripButton4.RightToLeftAutoMirrorImage = true;
			this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton4.Text = "Move last";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
			this.toolStripButton5.RightToLeftAutoMirrorImage = true;
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "Add new";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
			this.toolStripButton6.RightToLeftAutoMirrorImage = true;
			this.toolStripButton6.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton6.Text = "Delete";
			// 
			// sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem
			// 
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Enabled = false;
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Image")));
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Name = "sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem";
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// fillToolStrip1
			// 
			this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.mALTCToolStripLabel,
						this.mALTCToolStripTextBox,
						this.fillToolStripButton1});
			this.fillToolStrip1.Location = new System.Drawing.Point(0, 25);
			this.fillToolStrip1.Name = "fillToolStrip1";
			this.fillToolStrip1.Size = new System.Drawing.Size(472, 25);
			this.fillToolStrip1.TabIndex = 1;
			this.fillToolStrip1.Text = "fillToolStrip1";
			// 
			// mALTCToolStripLabel
			// 
			this.mALTCToolStripLabel.Name = "mALTCToolStripLabel";
			this.mALTCToolStripLabel.Size = new System.Drawing.Size(47, 22);
			this.mALTCToolStripLabel.Text = "MALTC:";
			// 
			// mALTCToolStripTextBox
			// 
			this.mALTCToolStripTextBox.Name = "mALTCToolStripTextBox";
			this.mALTCToolStripTextBox.Size = new System.Drawing.Size(100, 23);
			// 
			// fillToolStripButton1
			// 
			this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillToolStripButton1.Name = "fillToolStripButton1";
			this.fillToolStripButton1.Size = new System.Drawing.Size(26, 19);
			this.fillToolStripButton1.Text = "Fill";
			this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click_1);
			// 
			// sP_LAY_DSSV_DANGKYGridControl
			// 
			this.sP_LAY_DSSV_DANGKYGridControl.DataSource = this.sP_LAY_DSSV_DANGKYBindingSource;
			this.sP_LAY_DSSV_DANGKYGridControl.Location = new System.Drawing.Point(152, 108);
			this.sP_LAY_DSSV_DANGKYGridControl.MainView = this.gridView3;
			this.sP_LAY_DSSV_DANGKYGridControl.Name = "sP_LAY_DSSV_DANGKYGridControl";
			this.sP_LAY_DSSV_DANGKYGridControl.Size = new System.Drawing.Size(300, 220);
			this.sP_LAY_DSSV_DANGKYGridControl.TabIndex = 2;
			this.sP_LAY_DSSV_DANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
						this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.sP_LAY_DSSV_DANGKYGridControl;
			this.gridView3.Name = "gridView3";
			// 
			// frmDangKiLTC
			// 
			this.ClientSize = new System.Drawing.Size(472, 348);
			this.Controls.Add(this.sP_LAY_DSSV_DANGKYGridControl);
			this.Controls.Add(this.fillToolStrip1);
			this.Controls.Add(this.sP_LAY_DSSV_DANGKYBindingNavigator);
			this.Name = "frmDangKiLTC";
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingNavigator)).EndInit();
			this.sP_LAY_DSSV_DANGKYBindingNavigator.ResumeLayout(false);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.PerformLayout();
			this.fillToolStrip1.ResumeLayout(false);
			this.fillToolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLDSV_TCDataSet qLDSV_TCDataSet;
		private DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button btnDangKiLTC;
		private System.Windows.Forms.BindingSource sp_DSLTCCoTheDangKiBindingSource;
		private DoAn_QLSV.QLDSV_TCDataSetTableAdapters.sp_DSLTCCoTheDangKiTableAdapter DanhSachLTCDangKiTableAdapter;
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
		private System.Windows.Forms.Button btnDangKyLTC;
		private DevExpress.XtraGrid.GridControl sp_DSLTCCoTheDangKiGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colmaltc;
		private DevExpress.XtraGrid.Columns.GridColumn colmamh;
		private DevExpress.XtraGrid.Columns.GridColumn coltenmh;
		private DevExpress.XtraGrid.Columns.GridColumn colnhom;
		private DevExpress.XtraGrid.Columns.GridColumn colhoten;
		private DevExpress.XtraGrid.Columns.GridColumn coldadangki;
		private System.Windows.Forms.BindingSource qLDSVTCDataSetBindingSource;
		private System.Windows.Forms.BindingSource qLDSVTCDataSetBindingSource1;
		private System.Windows.Forms.BindingSource sp_ltc_sv_dangki_trong_ki_nayBindingSource;
		private DoAn_QLSV.QLDSV_TCDataSetTableAdapters.sp_ltc_sv_dangki_trong_ki_nayTableAdapter sp_ltc_sv_dangki_trong_ki_nayTableAdapter;
		private DevExpress.XtraGrid.GridControl sp_ltc_sv_dangki_trong_ki_nayGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private System.Windows.Forms.Button btnLamMoi;
		private DoAn_QLSV.QLDSV_TCDataSet qLDSV_TCDataSet1;
		private System.Windows.Forms.BindingSource sP_LAY_DSSV_DANGKYBindingSource;
		private DoAn_QLSV.QLDSV_TCDataSetTableAdapters.SP_LAY_DSSV_DANGKYTableAdapter sP_LAY_DSSV_DANGKYTableAdapter;
		private DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.BindingNavigator sP_LAY_DSSV_DANGKYBindingNavigator;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem;
		private System.Windows.Forms.ToolStrip fillToolStrip1;
		private System.Windows.Forms.ToolStripLabel mALTCToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox mALTCToolStripTextBox;
		private System.Windows.Forms.ToolStripButton fillToolStripButton1;
		private DevExpress.XtraGrid.GridControl sP_LAY_DSSV_DANGKYGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}