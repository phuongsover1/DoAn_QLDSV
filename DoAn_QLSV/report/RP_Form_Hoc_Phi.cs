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
    public partial class RP_Form_Hoc_Phi : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource lopBindingSource = new BindingSource();
        private SqlConnection conn_publisher = new SqlConnection();
        private string khoa = "";
        public RP_Form_Hoc_Phi()
        {
            InitializeComponent();
            cmbKhoa.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //string chiNhanh = cmbKhoa.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";
            //Program.servername = Program.servername3;



            Xtr_Hoc_Phi report = new Xtr_Hoc_Phi(cbLop.Text, cbNienKhoa.Text, cbHK.SelectedIndex+1);
            //Xtr_Hoc_Phi report = new Xtr_Hoc_Phi("D15CQCP01", "2021-2022", 1);
            //report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            //report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();
            //report.txtChiNhanh.Text = chiNhanh;

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
            /*
/*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbKhoa.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }

            khoa = cmbKhoa.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";


            //this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Lay_Danh_Sach_Lop_Theo_Khoa();
            Lay_Danh_Sach_Nien_Khoa();
            
        }

        private void Lay_Danh_Sach_Lop_Theo_Khoa()
        {
            string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                    "EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + khoaDaChon + "'",
                    Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );
            cbLop.Enabled = true;
            cbHK.Enabled = true;
            cbNienKhoa.Enabled = true;
            cbLop.DataSource = lopDataTable;
            cbLop.DisplayMember = "malop";
            //lopBindingSource.DataSource = lopDataTable;
            //gridLop.DataSource = lopBindingSource;
        }

        private void Lay_Danh_Sach_Nien_Khoa()
        {
            string khoaDaChon = cbNienKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                "SELECT DISTINCT nienkhoa INTO #TEMP FROM LOPTINCHI where makhoa ='" + khoaDaChon + "' " +
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
                "SELECT DISTINCT nhom INTO #TEMP FROM LOPTINCHI where makhoa ='" + khoaDaChon + "' " +
                "if (not exists(select 1 from #TEMP)) begin " +
                " SELECT DISTINCT nhom FROM LINK1.QLDSV_TC.DBO.LOPTINCHI" +
                " end else begin SELECT* FROM #TEMP end "
                ,
                Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );

            // Set the DataSource and DisplayMember properties of the ComboBox
            cbHK.DataSource = lopDataTable;
            cbHK.DisplayMember = "nhom";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}