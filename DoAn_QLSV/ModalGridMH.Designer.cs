namespace DoAn_QLSV
{
	partial class ModalGridMH
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
			this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.gridMH = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// modalEffect_Timer
			// 
			this.modalEffect_Timer.Enabled = true;
			this.modalEffect_Timer.Interval = 1;
			this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.gridMH);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(710, 248);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Danh Sách Môn Học";
			// 
			// gridMH
			// 
			this.gridMH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMH.Location = new System.Drawing.Point(2, 23);
			this.gridMH.MainView = this.gridView1;
			this.gridMH.Name = "gridMH";
			this.gridMH.Size = new System.Drawing.Size(706, 223);
			this.gridMH.TabIndex = 0;
			this.gridMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridMH;
			this.gridView1.Name = "gridView1";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(613, 265);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 33);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// ModalGridMH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 310);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupControl1);
			this.Name = "ModalGridMH";
			this.Text = "Chọn Môn Học Cho Lớp Tín Chỉ";
			this.Load += new System.EventHandler(this.ModalGridMH_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer modalEffect_Timer;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraGrid.GridControl gridMH;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton btnOK;
	}
}