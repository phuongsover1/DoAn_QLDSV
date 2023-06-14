namespace DoAn_QLSV
{
	partial class Frpt_PhieuDiem
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
			this.btnInPhieuDiem = new DevExpress.XtraEditors.SimpleButton();
			this.btnChonLop = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridSV = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnInPhieuDiem);
			this.groupControl1.Controls.Add(this.btnChonLop);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Controls.Add(this.txtMaLop);
			this.groupControl1.Controls.Add(this.cmbKhoa);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(20);
			this.groupControl1.Size = new System.Drawing.Size(1004, 93);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Điều Khiển";
			// 
			// btnInPhieuDiem
			// 
			this.btnInPhieuDiem.Location = new System.Drawing.Point(661, 44);
			this.btnInPhieuDiem.Name = "btnInPhieuDiem";
			this.btnInPhieuDiem.Size = new System.Drawing.Size(80, 23);
			this.btnInPhieuDiem.TabIndex = 11;
			this.btnInPhieuDiem.Text = "In Phiếu Điểm";
			this.btnInPhieuDiem.Click += new System.EventHandler(this.btnInPhieuDiem_Click);
			// 
			// btnChonLop
			// 
			this.btnChonLop.Location = new System.Drawing.Point(544, 45);
			this.btnChonLop.Name = "btnChonLop";
			this.btnChonLop.Size = new System.Drawing.Size(75, 23);
			this.btnChonLop.TabIndex = 9;
			this.btnChonLop.Text = "Chọn Lớp";
			this.btnChonLop.Click += new System.EventHandler(this.btnChonLop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(314, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Mã Lớp:";
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(372, 47);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Properties.ReadOnly = true;
			this.txtMaLop.Size = new System.Drawing.Size(152, 20);
			this.txtMaLop.TabIndex = 7;
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Location = new System.Drawing.Point(53, 46);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(224, 21);
			this.cmbKhoa.TabIndex = 5;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(18, 49);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Khoa:";
			// 
			// gridSV
			// 
			this.gridSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSV.Location = new System.Drawing.Point(0, 93);
			this.gridSV.MainView = this.gridView1;
			this.gridSV.Name = "gridSV";
			this.gridSV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
			this.gridSV.Size = new System.Drawing.Size(1004, 269);
			this.gridSV.TabIndex = 6;
			this.gridSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridSV;
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
			// Frpt_PhieuDiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 362);
			this.Controls.Add(this.gridSV);
			this.Controls.Add(this.groupControl1);
			this.Name = "Frpt_PhieuDiem";
			this.Text = "Frpt_PhieuDiem";
			this.Load += new System.EventHandler(this.Frpt_PhieuDiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraGrid.GridControl gridSV;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
		public System.Windows.Forms.ComboBox cmbKhoa;
		private DevExpress.XtraEditors.SimpleButton btnChonLop;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtMaLop;
		private DevExpress.XtraEditors.SimpleButton btnInPhieuDiem;
	}
}