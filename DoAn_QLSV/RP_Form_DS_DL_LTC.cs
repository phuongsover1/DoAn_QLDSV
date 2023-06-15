using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV.report
{
    public partial class RP_Form_DS_DL_LTC : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource lopBindingSource = new BindingSource();
        private SqlConnection conn_publisher = new SqlConnection();
        private string khoa = "";
        public RP_Form_DS_DL_LTC()
        {
            InitializeComponent();

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            if (Program.servername == "DESKTOP-OM4F2K5\\MSSQLSERVER1")
                cmbKhoa.Text = "CNTT";
            else
                cmbKhoa.Text = "VT";

            //this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
            cbHK.Enabled = true;
            cbMonHoc.Enabled = true;
            cbNhom.Enabled = true;
            cbNienKhoa.Enabled = true;
            Lay_Danh_Sach_Nhom();
            Lay_Danh_Sach_Nien_Khoa();
            Lay_Danh_Sach_Mon_Hoc();
        }
        public static void LayDSPM(String cmd, SqlConnection conn_publisher, System.Windows.Forms.ComboBox cmbKhoa)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, conn_publisher))
            {
                sqlDataAdapter.Fill(dt);
                conn_publisher.Close();
                cmbKhoa.DataSource = dt;
                cmbKhoa.DisplayMember = "TENCN";
                cmbKhoa.ValueMember = "TENSERVER";
            }

        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {
            /*Step 2
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER"; 
            cmbCHINHANH.SelectedIndex = Program.brand;

            dteTuNgay.EditValue = "01-05-2000";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
            }
            */
        }



        private void button1_Click(object sender, EventArgs e)
        {

            // string chiNhanh = cmbCHINHANH.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";



            Xtr_DS_DK_LTC report = new Xtr_DS_DK_LTC(cbNienKhoa.Text, cbHK.SelectedIndex+1, cbMonHoc.Text, Int32.Parse(cbNhom.Text), cmbKhoa.Text);

            report.lbHocKy.Text = cbHK.Text;
            report.lbMonHoc.Text = cbMonHoc.Text;
            report.lbNhom.Text = cbNhom.Text;
            report.lbNienKhoa.Text = cbNienKhoa.Text;
            report.lbKhoa.Text = cmbKhoa.Text;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public static int KetNoi_CSDLGOC(SqlConnection conn_publisher)
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                        "Lỗi kết nối về cơ sở dữ liệu gốc.\n Bạn nên xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n "
                                + ex.Message,
                        "Lỗi kết nối",
                        MessageBoxButtons.OK
                );
                return 0;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else if (Program.servername == "DESKTOP-OM4F2K5\\MSSQLSERVER1")
                cmbKhoa.Text = "CNTT";
            else
                cmbKhoa.Text = "VT";

            //this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
            cbHK.Enabled = true;
            cbMonHoc.Enabled = true;
            cbNhom.Enabled = true;
            cbNienKhoa.Enabled = true;
            Lay_Danh_Sach_Nhom();
            Lay_Danh_Sach_Nien_Khoa();
            Lay_Danh_Sach_Mon_Hoc();
        }

        private void Lay_Danh_Sach_Lop_Theo_Khoa()
        {
            string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                    "EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + cmbKhoa.Text + "'",
                    Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );
            cbMonHoc.Enabled = true;
            cbNhom.Enabled = true;
            cbNienKhoa.Enabled = true;
            cbMonHoc.DataSource = lopDataTable;
            cbMonHoc.DisplayMember = "malop";
            //lopBindingSource.DataSource = lopDataTable;
            //gridLop.DataSource = lopBindingSource;
        }
        private void Lay_Danh_Sach_Mon_Hoc()
        {
            string khoaDaChon = cbNienKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                "SELECT tenmh  FROM MONHOC "
                ,
                Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );

            // Set the DataSource and DisplayMember properties of the ComboBox
            cbMonHoc.DataSource = lopDataTable;
            cbMonHoc.DisplayMember = "tenmh";
        }

        private void Lay_Danh_Sach_Nien_Khoa()
        {
            string khoaDaChon = cbNienKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                "SELECT DISTINCT nienkhoa INTO #TEMP FROM LOPTINCHI where makhoa ='" + cmbKhoa.Text + "' " +
                "if (not exists(select 1 from #TEMP)) begin " +
                " SELECT DISTINCT nienkhoa FROM LINK1.QLDSV_TC.DBO.LOPTINCHI" +
                " end else begin SELECT* FROM #TEMP end "
                ,
                Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );

            // Set the DataSource and DisplayMember properties of the ComboBox
            cbNienKhoa.DataSource = lopDataTable;
            cbNienKhoa.DisplayMember = "nienkhoa";

        }
        private void Lay_Danh_Sach_Nhom()
        {
            string khoaDaChon = cbNienKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                "SELECT DISTINCT nhom INTO #TEMP FROM LOPTINCHI where makhoa ='" + cmbKhoa.Text + "' " +
                "if (not exists(select 1 from #TEMP)) begin " +
                " SELECT DISTINCT nhom FROM LINK1.QLDSV_TC.DBO.LOPTINCHI" +
                " end else begin SELECT* FROM #TEMP end "
                ,
                Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );

            // Set the DataSource and DisplayMember properties of the ComboBox
            cbNhom.DataSource = lopDataTable;
            cbNhom.DisplayMember = "nhom";
        }

        private void cbHK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}