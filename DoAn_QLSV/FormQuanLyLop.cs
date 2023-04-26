using DevExpress.DirectX.NativeInterop;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace DoAn_QLSV
{
    public partial class FormQuanLyLop : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public FormQuanLyLop()
        {
            InitializeComponent();
        }

        private void FormQuanLyLop_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM dbo.Get_Subscribes");
            if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
            {
                cmbKhoa.Enabled = false;
            }

            cmbKhoa.SelectedIndex = Program.mKhoa;
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            sqlDataAdapter.Fill(dt);
            conn_publisher.Close();
            cmbKhoa.DataSource = dt;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

        }

        private int KetNoi_CSDLGOC()
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
                XtraMessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\n Bạn nên xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void Lay_Danh_Sach_Lop_Theo_Khoa()
        {
            string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery("EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + khoaDaChon + "'", Program.createConnectionString(Program.servername, Program.mlogin, Program.password));
            gridLop.DataSource = lopDataTable;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Program.servername);
            Lay_Danh_Sach_Lop_Theo_Khoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
            txtMaLop.Text = selectedRow[0].ToString();
            txtTenLop.Text = selectedRow[1].ToString();
            txtKhoaHoc.Text = selectedRow[2].ToString();
            txtMaKhoa.Text = selectedRow[3].ToString();
            txtMaLop.ReadOnly = true;
            groupControlThongTinLop.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "";
            object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
            txtMaKhoa.Text = selectedRow[3].ToString();
            groupControlThongTinLop.Visible = true;
        }
    }
}