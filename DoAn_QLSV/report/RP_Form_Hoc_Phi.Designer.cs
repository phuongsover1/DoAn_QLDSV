
namespace DoAn_QLSV.report
{
    partial class RP_Form_Hoc_Phi
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(442, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 53);
            this.button2.TabIndex = 34;
            this.button2.Text = "XUẤT BẢN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(134, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 33;
            this.button1.Text = "XEM TRƯỚC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 32;
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
            this.cmbKhoa.Location = new System.Drawing.Point(224, 132);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(8);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(432, 24);
            this.cmbKhoa.TabIndex = 31;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh sách học phí";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Enabled = false;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(224, 186);
            this.cbLop.Margin = new System.Windows.Forms.Padding(8);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(432, 24);
            this.cbLop.TabIndex = 35;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nien Khoa";
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNienKhoa.Enabled = false;
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Location = new System.Drawing.Point(224, 226);
            this.cbNienKhoa.Margin = new System.Windows.Forms.Padding(8);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(432, 24);
            this.cbNienKhoa.TabIndex = 38;
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
            this.cbHK.Location = new System.Drawing.Point(224, 266);
            this.cbHK.Margin = new System.Windows.Forms.Padding(8);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(432, 24);
            this.cbHK.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Hoc Ky";
            // 
            // RP_Form_Hoc_Phi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 464);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNienKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "RP_Form_Hoc_Phi";
            this.Text = "RP_Form_Hoc_Phi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label label5;
    }
}