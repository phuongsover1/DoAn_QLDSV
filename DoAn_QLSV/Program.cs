using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLSV
{
    internal static class Program
    {




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String database = "QLDSV_TC";
        public static String connstr_publisher = "Data Source=DESKTOP-GUM00GB;Initial Catalog=" + database + ";Integrated Security=True";
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String servername1 = "DESKTOP-GUM00GB\\MSSQLSERVER1";
        public static String servername2 = "DESKTOP-GUM00GB\\MSSQLSERVER2";
        public static String username;
        public static String password = "1234";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123456";
        public static String mlogin = "sa";
        public static String mGroup;
        public static String mHoten;
        public static int mKhoa = 0;

        public static BindingSource bds_dspm = new BindingSource(); // giu binding source phan manh khi dang nhap
        public static FormMain formMain;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static String createConnectionString(String serverName, String userId, String password)
        {
            return "Data Source=" + serverName + ";Initial Catalog=" + Program.database + ";User ID=" + userId + ";password=" + password;
        }

        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;
            Program.conn = new SqlConnection(connectionstring);

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                myreader = sqlcmd.ExecuteReader();

                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }


        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trạng thái lỗi gởi về từ sql server raise error
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {
            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        public static object[] GetSelectedRowGridControl(GridControl gridControl)
        {
            GridView gridView = gridControl.FocusedView as GridView;
            object selectedRow = gridView.GetRow(gridView.FocusedRowHandle);
            object[] result = ((System.Data.DataRowView)(selectedRow)).Row.ItemArray;
            return result;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
            //Application.Run(new FormMain());
        }
    }
}
