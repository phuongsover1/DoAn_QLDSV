namespace DoAn_QLSV
{
	partial class ModalGridGV
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
			this.gridGV = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridGV
			// 
			this.gridGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridGV.Location = new System.Drawing.Point(2, 23);
			this.gridGV.MainView = this.gridView1;
			this.gridGV.Name = "gridGV";
			this.gridGV.Size = new System.Drawing.Size(818, 223);
			this.gridGV.TabIndex = 0;
			this.gridGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridGV;
			this.gridView1.Name = "gridView1";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(734, 271);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 33);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.gridGV);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(822, 248);
			this.groupControl1.TabIndex = 4;
			this.groupControl1.Text = "Danh Sách Giảng Viên";
			// 
			// modalEffect_Timer
			// 
			this.modalEffect_Timer.Enabled = true;
			this.modalEffect_Timer.Interval = 1;
			this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
			// 
			// ModalGridGV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 323);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.btnOK);
			this.Name = "ModalGridGV";
			this.Text = "Chọn Giảng Viên Cho Lớp Tín Chỉ";
			this.Load += new System.EventHandler(this.ModalGridGV_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridGV;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton btnOK;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.Timer modalEffect_Timer;
	}
}