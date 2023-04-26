using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAn_QLSV.Utils;

namespace DoAn_QLSV
{
    public partial class FormQuanLyLop : DevExpress.XtraEditors.XtraForm
    {
        //DataView dv = lopBindingSource.List as DataView;
        //Lop lop = new Lop() { MaLop = "TEST", TenLop = "TEST", KhoaHoc = "TEST", MaKhoa = "TEST" };
        //dv.Table.Rows.Add(lop.MaLop, lop.TenLop, lop.KhoaHoc, lop.MaKhoa);
        //groupControlThongTinLop.Visible = false;
        //foreach (DataRow dataRow in dv.Table.Rows)
        //{
        //    XtraMessageBox.Show(dataRow["MALOP"].ToString(), "", MessageBoxButtons.OK);
        //}
        private BindingSource lopBindingSource = new BindingSource();
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isAddNew;

        public FormQuanLyLop()
        {
            InitializeComponent();
        }

        private void FormQuanLyLop_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
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
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
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
                XtraMessageBox.Show(
                    "Lỗi kết nối về cơ sở dữ liệu gốc.\n Bạn nên xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n "
                        + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK
                );
                return 0;
            }
        }

        private void Lay_Danh_Sach_Lop_Theo_Khoa()
        {
            string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
            DataTable lopDataTable = Program.ExecSqlQuery(
                "EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + khoaDaChon + "'",
                Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
            );
            lopBindingSource.DataSource = lopDataTable;
            gridLop.DataSource = lopBindingSource;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lay_Danh_Sach_Lop_Theo_Khoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAddNew = false;
            object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
            txtMaLop.Text = selectedRow[0].ToString();
            txtTenLop.Text = selectedRow[1].ToString();
            txtKhoaHoc.Text = selectedRow[2].ToString();
            txtMaKhoa.Text = selectedRow[3].ToString();
            SetEnabledCacButton(false);

            txtMaLop.Enabled = false;
            txtMaKhoa.Enabled = false;
            groupControlThongTinLop.Text = "Sửa Thông Tin Lớp";
            groupControlThongTinLop.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddNew = true;
            txtMaLop.Enabled = true;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "";
            object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
            txtMaKhoa.Text = selectedRow[3].ToString();

            groupControlThongTinLop.Text = "Thêm Lớp Học";
            groupControlThongTinLop.Visible = true;
            SetEnabledCacButton(false);

            //lopBindingSource.List.Add(new Model.Lop() { MaLop = "123", TenLop = "Test", KhoaHoc = "TEST", MaKhoa = "TEST" });
            //DataView dv = lopBindingSource.List as DataView;
            //Lop lop = new Lop() { MaLop = "TEST", TenLop = "TEST", KhoaHoc = "TEST", MaKhoa = "TEST" };
            //dv.Table.Rows.Add(lop.MaLop, lop.TenLop, lop.KhoaHoc, lop.MaKhoa);
            //groupControlThongTinLop.Visible = false;
            //foreach (DataRow dataRow in dv.Table.Rows)
            //{
            //    XtraMessageBox.Show(dataRow["MALOP"].ToString(), "", MessageBoxButtons.OK);
            //}
        }

        private void txtMaLop_Leave(object sender, EventArgs e)
        {
            String maLopDaNhap = txtMaLop.Text.Trim().ToUpper();
            SqlDataReader reader = Program.ExecSqlDataReader(
                "EXEC SP_KIEM_TRA_ID_LOP '" + maLopDaNhap + "'",
                Program.connstr
            );
            reader.Read();
            int id = reader.GetInt32(0);
            if (id == 0)
            {
                XtraMessageBox.Show(
                    "Mã lớp đã tồn tại trong hệ thống!",
                    "Lỗi",
                    MessageBoxButtons.OK
                );
                txtMaLop.Focus();
            }
        }

        private void SetEnabledCacButton(bool isOn)
        {
            if (isOn)
            {
                if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
                {
                    cmbKhoa.Enabled = false;
                }
                else
                    cmbKhoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnReload.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnReload.Enabled = false;
                cmbKhoa.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim().ToUpper();
            string tenLop = txtTenLop.Text.Trim();
            string khoaHoc = txtKhoaHoc.Text.Trim();
            string maKhoa = txtMaKhoa.Text;
            if (isAddNew)
            {
                string cmd = $"EXEC SP_THEM_LOP '{maKhoa}','{maLop}',N'{tenLop}','{khoaHoc}'";
                int result = Program.ExecSqlNonQuery(cmd, Program.connstr);

                if (result == 1)
                {
                    XtraMessageBox.Show(
                        "Đã thêm lớp thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK
                    );
                }
                else
                {
                    XtraMessageBox.Show(
                        "Thêm lớp thất bại. Mã lỗi: " + result.ToString(),
                        "Lỗi",
                        MessageBoxButtons.OK
                    );
                    return;
                }
            }
            else
            {
                string cmd = $"EXEC SP_CHINH_SUA_LOP '{maLop}',N'{tenLop}','{khoaHoc}'";
                int result = Program.ExecSqlNonQuery(cmd, Program.connstr);
                if (result == 1)
                {
                    XtraMessageBox.Show(
                        "Đã chỉnh sửa thông tin lớp thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK
                    );
                }
                else
                {
                    XtraMessageBox.Show(
                        "Chỉnh sửa thông tin của lớp thất bại. Mã lỗi: " + result.ToString(),
                        "Lỗi",
                        MessageBoxButtons.OK
                    );
                }
            }
            Lay_Danh_Sach_Lop_Theo_Khoa();
            SetEnabledCacButton(true);
            txtMaKhoa.Enabled = false;
            txtMaLop.Enabled = false;
            groupControlThongTinLop.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEnabledCacButton(true);
            groupControlThongTinLop.Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Lay_Danh_Sach_Lop_Theo_Khoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
            string maLop = selectedRow[0].ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[]
                {
                    new ParameterStoredProcedure() { ParamName = "@MALOP", ParamValue = maLop }
                };
                OutputParameterStoredProcedure[] outputParameters =
                    new OutputParameterStoredProcedure[]
                    {
                        new OutputParameterStoredProcedure()
                        {
                            Name = "@KETQUA",
                            Type = SqlDbType.NVarChar,
                            Length = 100
                        }
                    };
                cmd = Program.GetResultFromStoredProcedured(
                    cmd,
                    "SP_XOA_LOP",
                    Program.connstr,
                    parameters,
                    outputParameters
                );
                string ketqua = Convert.ToString(cmd.Parameters[outputParameters[0].Name].Value);
                XtraMessageBox.Show(ketqua, "Kết Quả", MessageBoxButtons.OK);
                Lay_Danh_Sach_Lop_Theo_Khoa();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            finally
            {
                cmd.Dispose();
            }
        }
    }
}
