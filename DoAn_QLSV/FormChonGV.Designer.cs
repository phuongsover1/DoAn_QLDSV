
namespace DoAn_QLSV
{
    partial class FormChonGV
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
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnCHON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Red;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(415, 433);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(122, 32);
            this.btnTHOAT.TabIndex = 10;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnCHON
            // 
            this.btnCHON.BackColor = System.Drawing.Color.Blue;
            this.btnCHON.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHON.ForeColor = System.Drawing.Color.White;
            this.btnCHON.Location = new System.Drawing.Point(126, 433);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(122, 32);
            this.btnCHON.TabIndex = 9;
            this.btnCHON.Text = "CHỌN";
            this.btnCHON.UseVisualStyleBackColor = false;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(220, 54);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(8);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(432, 24);
            this.cmbKhoa.TabIndex = 11;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(64, 102);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(560, 325);
            this.gIANGVIENGridControl.TabIndex = 1;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FormChonGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Name = "FormChonGV";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.FormChonGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
    }
}