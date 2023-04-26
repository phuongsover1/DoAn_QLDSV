using DevExpress.XtraEditors;
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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e) { }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                XtraMessageBox.Show(
                    "Tài khoản hoặc mật khẩu không được để trống !!!",
                    "Lỗi Đăng Nhập",
                    MessageBoxButtons.OK
                );
                return;
            }

            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            //if (Program.KetNoi() == 0) return;

            Program.mKhoa = cmbKhoa.SelectedIndex;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(
                strLenh,
                Program.createConnectionString(
                    cmbKhoa.SelectedValue.ToString(),
                    Program.mlogin,
                    Program.password
                )
            );
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                XtraMessageBox.Show(
                    "Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password",
                    "",
                    MessageBoxButtons.OK
                );
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            HienThiMenu();
            this.Hide();
            this.Parent.Show();
            Program.connstr = Program.createConnectionString(
                Program.servername,
                Program.mlogin,
                Program.password
            );
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
            LayDSPM("SELECT * FROM dbo.Get_Subscribes");
            cmbKhoa.SelectedIndex = 0;
        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            sqlDataAdapter.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
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
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        public void HienThiMenu()
        {
            Program.formMain.lbHoTen.Text = "HOTEN: " + Program.mHoten;
            Program.formMain.lbMaNV.Text = "MAGV: " + Program.username;
            Program.formMain.lbNhom.Text = "NHOM: " + Program.mGroup;
            Program.formMain.ribGroupTaoTaiKhoan.Visible = true;
            Program.formMain.ribGroupLogout.Visible = true;
            Program.formMain.ribDanhMuc.Visible = true;
            Program.formMain.ribGroupDangNhap.Visible = false;
        }
    }
}
