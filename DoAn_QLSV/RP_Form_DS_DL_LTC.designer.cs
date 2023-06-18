
namespace DoAn_QLSV.report
{
    partial class RP_Form_DS_DL_LTC
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbKhoa = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbHK = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbNienKhoa = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbMonHoc = new System.Windows.Forms.ComboBox();
			this.cbNhom = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(455, 367);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 43);
			this.button2.TabIndex = 25;
			this.button2.Text = "XUẤT BẢN";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(182, 349);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 43);
			this.button1.TabIndex = 24;
			this.button1.Text = "XEM TRƯỚC";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(147, 167);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "Khoa";
			// 
			// cmbKhoa
			// 
			this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKhoa.Enabled = false;
			this.cmbKhoa.FormattingEnabled = true;
			this.cmbKhoa.Items.AddRange(new object[] {
            "CNTT",
            "VT"});
			this.cmbKhoa.Location = new System.Drawing.Point(277, 165);
			this.cmbKhoa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.cmbKhoa.Name = "cmbKhoa";
			this.cmbKhoa.Size = new System.Drawing.Size(371, 21);
			this.cmbKhoa.TabIndex = 22;
			this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(165, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(475, 29);
			this.label1.TabIndex = 21;
			this.label1.Text = "Danh sách sinh viên đăng ký lớp tín chỉ";
			// 
			// cbHK
			// 
			this.cbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHK.Enabled = false;
			this.cbHK.FormattingEnabled = true;
			this.cbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbHK.Location = new System.Drawing.Point(277, 264);
			this.cbHK.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.cbHK.Name = "cbHK";
			this.cbHK.Size = new System.Drawing.Size(371, 21);
			this.cbHK.TabIndex = 46;
			this.cbHK.SelectedIndexChanged += new System.EventHandler(this.cbHK_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(147, 268);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 17);
			this.label5.TabIndex = 45;
			this.label5.Text = "Học kỳ";
			// 
			// cbNienKhoa
			// 
			this.cbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNienKhoa.Enabled = false;
			this.cbNienKhoa.FormattingEnabled = true;
			this.cbNienKhoa.Location = new System.Drawing.Point(277, 230);
			this.cbNienKhoa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.cbNienKhoa.Name = "cbNienKhoa";
			this.cbNienKhoa.Size = new System.Drawing.Size(371, 21);
			this.cbNienKhoa.TabIndex = 44;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(147, 234);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 17);
			this.label4.TabIndex = 43;
			this.label4.Text = "Niên Khóa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 197);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 42;
			this.label3.Text = "Môn học";
			// 
			// cbMonHoc
			// 
			this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonHoc.Enabled = false;
			this.cbMonHoc.FormattingEnabled = true;
			this.cbMonHoc.Location = new System.Drawing.Point(277, 197);
			this.cbMonHoc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.cbMonHoc.Name = "cbMonHoc";
			this.cbMonHoc.Size = new System.Drawing.Size(371, 21);
			this.cbMonHoc.TabIndex = 41;
			// 
			// cbNhom
			// 
			this.cbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNhom.Enabled = false;
			this.cbNhom.FormattingEnabled = true;
			this.cbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbNhom.Location = new System.Drawing.Point(277, 306);
			this.cbNhom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.cbNhom.Name = "cbNhom";
			this.cbNhom.Size = new System.Drawing.Size(371, 21);
			this.cbNhom.TabIndex = 48;
			this.cbNhom.SelectedIndexChanged += new System.EventHandler(this.cbNhom_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(147, 310);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 17);
			this.label6.TabIndex = 47;
			this.label6.Text = "Nhóm";
			// 
			// RP_Form_DS_DL_LTC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 431);
			this.Controls.Add(this.cbNhom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbHK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbNienKhoa);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbMonHoc);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbKhoa);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "RP_Form_DS_DL_LTC";
			this.Text = "RP_Form_DS_DL_LTC";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.Label label6;
    }
}