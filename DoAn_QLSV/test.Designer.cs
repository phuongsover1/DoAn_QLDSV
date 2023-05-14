namespace DoAn_QLSV
{
	partial class test
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
			this.qLDSV_TCDataSet = new DoAn_QLSV.QLDSV_TCDataSet();
			this.sP_LAY_DSSV_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sP_LAY_DSSV_DANGKYTableAdapter = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.SP_LAY_DSSV_DANGKYTableAdapter();
			this.tableAdapterManager = new DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
			this.sP_LAY_DSSV_DANGKYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.fillToolStrip = new System.Windows.Forms.ToolStrip();
			this.mALTCToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.mALTCToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.sP_LAY_DSSV_DANGKYGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingNavigator)).BeginInit();
			this.sP_LAY_DSSV_DANGKYBindingNavigator.SuspendLayout();
			this.fillToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// qLDSV_TCDataSet
			// 
			this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
			this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sP_LAY_DSSV_DANGKYBindingSource
			// 
			this.sP_LAY_DSSV_DANGKYBindingSource.DataMember = "SP_LAY_DSSV_DANGKY";
			this.sP_LAY_DSSV_DANGKYBindingSource.DataSource = this.qLDSV_TCDataSet;
			// 
			// sP_LAY_DSSV_DANGKYTableAdapter
			// 
			this.sP_LAY_DSSV_DANGKYTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.DANGKYTableAdapter = null;
			this.tableAdapterManager.GIANGVIENTableAdapter = null;
			this.tableAdapterManager.KHOATableAdapter = null;
			this.tableAdapterManager.LOPTableAdapter = null;
			this.tableAdapterManager.LOPTINCHITableAdapter = null;
			this.tableAdapterManager.MONHOCTableAdapter = null;
			this.tableAdapterManager.SINHVIENTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DoAn_QLSV.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sP_LAY_DSSV_DANGKYBindingNavigator
			// 
			this.sP_LAY_DSSV_DANGKYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.BindingSource = this.sP_LAY_DSSV_DANGKYBindingSource;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem});
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Name = "sP_LAY_DSSV_DANGKYBindingNavigator";
			this.sP_LAY_DSSV_DANGKYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Size = new System.Drawing.Size(491, 25);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.TabIndex = 0;
			this.sP_LAY_DSSV_DANGKYBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// fillToolStrip
			// 
			this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mALTCToolStripLabel,
            this.mALTCToolStripTextBox,
            this.fillToolStripButton});
			this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
			this.fillToolStrip.Name = "fillToolStrip";
			this.fillToolStrip.Size = new System.Drawing.Size(491, 25);
			this.fillToolStrip.TabIndex = 1;
			this.fillToolStrip.Text = "fillToolStrip";
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
			// fillToolStripButton
			// 
			this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillToolStripButton.Name = "fillToolStripButton";
			this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
			this.fillToolStripButton.Text = "Fill";
			this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
			// 
			// sP_LAY_DSSV_DANGKYGridControl
			// 
			this.sP_LAY_DSSV_DANGKYGridControl.DataSource = this.sP_LAY_DSSV_DANGKYBindingSource;
			this.sP_LAY_DSSV_DANGKYGridControl.Location = new System.Drawing.Point(171, 160);
			this.sP_LAY_DSSV_DANGKYGridControl.MainView = this.gridView1;
			this.sP_LAY_DSSV_DANGKYGridControl.Name = "sP_LAY_DSSV_DANGKYGridControl";
			this.sP_LAY_DSSV_DANGKYGridControl.Size = new System.Drawing.Size(300, 220);
			this.sP_LAY_DSSV_DANGKYGridControl.TabIndex = 2;
			this.sP_LAY_DSSV_DANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.sP_LAY_DSSV_DANGKYGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 400);
			this.Controls.Add(this.sP_LAY_DSSV_DANGKYGridControl);
			this.Controls.Add(this.fillToolStrip);
			this.Controls.Add(this.sP_LAY_DSSV_DANGKYBindingNavigator);
			this.Name = "test";
			this.Text = "test";
			((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYBindingNavigator)).EndInit();
			this.sP_LAY_DSSV_DANGKYBindingNavigator.ResumeLayout(false);
			this.sP_LAY_DSSV_DANGKYBindingNavigator.PerformLayout();
			this.fillToolStrip.ResumeLayout(false);
			this.fillToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSSV_DANGKYGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLDSV_TCDataSet qLDSV_TCDataSet;
		private System.Windows.Forms.BindingSource sP_LAY_DSSV_DANGKYBindingSource;
		private QLDSV_TCDataSetTableAdapters.SP_LAY_DSSV_DANGKYTableAdapter sP_LAY_DSSV_DANGKYTableAdapter;
		private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator sP_LAY_DSSV_DANGKYBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton sP_LAY_DSSV_DANGKYBindingNavigatorSaveItem;
		private System.Windows.Forms.ToolStrip fillToolStrip;
		private System.Windows.Forms.ToolStripLabel mALTCToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox mALTCToolStripTextBox;
		private System.Windows.Forms.ToolStripButton fillToolStripButton;
		private DevExpress.XtraGrid.GridControl sP_LAY_DSSV_DANGKYGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}