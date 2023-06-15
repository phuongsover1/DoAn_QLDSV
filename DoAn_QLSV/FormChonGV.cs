using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
    public partial class FormChonGV : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource gIANGVIENBindingSource = new BindingSource();
        private SqlConnection conn_publisher = new SqlConnection();
        public FormChonGV()
        {
            InitializeComponent();
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
        }


        private void FormChonGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.

                if (KetNoi_CSDLGOC(conn_publisher) == 0)
                    return;
                LayDSPM("SELECT * FROM dbo.Get_Subscribes", conn_publisher, cmbKhoa);
                if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
                {
                    cmbKhoa.Enabled = false;
                }

                cmbKhoa.SelectedIndex = Program.mKhoa;
            
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
        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(gIANGVIENBindingSource.Current));
            string maGV = drv["MAGV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + " " + ten;

            
            

            Program.maGVDuocChon = maGV;
            Program.hoTen = hoTen;
            
            //Console.WriteLine(Program.hoTen);


            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

            string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT" ;
            Program.khoaDaChonDeTaoTaiKhoan = khoaDaChon;
            DataTable lopDataTable = Program.ExecSqlQuery(
                    " SELECT MAGV, MAKHOA, HO, TEN, HOCVI, HOCHAM, CHUYENMON FROM GIANGVIEN WHERE MAKHOA='"+ khoaDaChon + "'",
                    Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );
            gIANGVIENBindingSource.DataSource = lopDataTable;
            
            gIANGVIENGridControl.DataSource = gIANGVIENBindingSource;


        }
    }
}