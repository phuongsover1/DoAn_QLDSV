namespace DoAn_QLSV
{
	partial class Frpt_DiemTongKetCuoiKhoa
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
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridLop = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.btnInDiemTKCK = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnInDiemTKCK);
			this.groupControl1.Controls.Add(this.cmbKhoa);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
			this.groupControl1.Size = new System.Drawing.Size(916, 85);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Điều Khiển";
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Location = new System.Drawing.Point(46, 39);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(224, 21);
			this.cmbKhoa.TabIndex = 5;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(11, 42);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Khoa:";
			// 
			// gridLop
			// 
			this.gridLop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridLop.Location = new System.Drawing.Point(0, 85);
			this.gridLop.MainView = this.gridView1;
			this.gridLop.Name = "gridLop";
			this.gridLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
			this.gridLop.Size = new System.Drawing.Size(916, 362);
			this.gridLop.TabIndex = 6;
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
			// btnInDiemTKCK
			// 
			this.btnInDiemTKCK.Location = new System.Drawing.Point(320, 37);
			this.btnInDiemTKCK.Name = "btnInDiemTKCK";
			this.btnInDiemTKCK.Size = new System.Drawing.Size(153, 23);
			this.btnInDiemTKCK.TabIndex = 6;
			this.btnInDiemTKCK.Text = "In Điểm Tổng Kết Cuối Khóa";
			this.btnInDiemTKCK.Click += new System.EventHandler(this.btnInDiemTKCK_Click);
			// 
			// Frpt_DiemTongKetCuoiKhoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(916, 447);
			this.Controls.Add(this.gridLop);
			this.Controls.Add(this.groupControl1);
			this.Name = "Frpt_DiemTongKetCuoiKhoa";
			this.Text = "Frpt_DiemTongKetCuoiKhoa";
			this.Load += new System.EventHandler(this.Frpt_DiemTongKetCuoiKhoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.ComboBox cmbKhoa;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraGrid.GridControl gridLop;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
		private DevExpress.XtraEditors.SimpleButton btnInDiemTKCK;
	}
}