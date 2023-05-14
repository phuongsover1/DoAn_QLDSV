using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class Frpt_DanhSachLopTinChi : DevExpress.XtraEditors.XtraForm
	{
		private Configuration config;
		private SqlConnection conn_publisher = new SqlConnection();
		private string maKhoa;

		public Frpt_DanhSachLopTinChi()
		{
			InitializeComponent();
		}

		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			maKhoa = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
			Lay_Danh_Sach_Nien_Khoa();
			Lay_Danh_Sach_Hoc_Ky();
		}

		private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Hoc_Ky();

		}

		private void Lay_Danh_Sach_Hoc_Ky()
		{
			DataTable dt = new DataTable();
			string cmd = "EXEC SP_LAY_DANH_SACH_HOC_KY_THEO_NIEN_KHOA '" + maKhoa + "', '" + cmbNienKhoa.SelectedValue + "'";
			try
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, Program.connstr))
				{
					sqlDataAdapter.Fill(dt);
					cmbHocKy.DataSource = dt;
					cmbHocKy.DisplayMember = "HOCKY";
					cmbHocKy.ValueMember = "HOCKY";
				}


			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Lay_Danh_Sach_Nien_Khoa()
		{
			DataTable dt = new DataTable();
			string cmd = "EXEC SP_LAY_DANH_SACH_NIEN_KHOA '" + maKhoa + "'";
			try
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, Program.connstr))
				{
					sqlDataAdapter.Fill(dt);
					cmbNienKhoa.DataSource = dt;
					cmbNienKhoa.DisplayMember = "NIENKHOA";
					cmbNienKhoa.ValueMember = "NIENKHOA";

				}

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void Frpt_DanhSachLopTinChi_Load(object sender, EventArgs e)
		{
			if (FormQuanLyLop.KetNoi_CSDLGOC(conn_publisher) == 0)
				return;
			FormQuanLyLop.LayDSPM("SELECT * FROM dbo.Get_Subscribes", conn_publisher, cmbKhoa);
			if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
			{
				cmbKhoa.Enabled = false;
			}

			cmbKhoa.SelectedIndex = Program.mKhoa;
		}

		private void btnInDSLTC_Click(object sender, EventArgs e)
		{
			ChangeUserNameAndPasswordConnectionString(cmbKhoa.SelectedIndex, Program.mGroup, config);
			Xrpt_DanhSachLopTinChi rpt = new Xrpt_DanhSachLopTinChi(cmbKhoa.SelectedIndex, cmbNienKhoa.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString());

			ReportPrintTool print = new ReportPrintTool(rpt);
			print.ShowPreviewDialog();
		}

		public static void ChangeUserNameAndPasswordConnectionString(int mKhoa, string mGroup, Configuration config)
		{
			config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			string connectionString = "";

			if (mKhoa == 0)
			{
				if (
						mGroup == GroupEnums.Quyen.KHOA.ToString()
						|| mGroup == GroupEnums.Quyen.PGV.ToString()
				)
				{
					connectionString = ConfigurationManager.ConnectionStrings[
							"localhost_QLDSV_TC_Connection11"
					].ConnectionString;
					connectionString = connectionString.Replace("MSSQLSERVER2", "MSSQLSERVER1");
					connectionString = connectionString.Replace("sa", "HTKN");


					/// thay đổi lại trong app config
					config.ConnectionStrings.ConnectionStrings[
							"localhost_QLDSV_TC_Connection11"
					].ConnectionString = connectionString;
				}
			}
			else
			{
				if (
						mGroup == GroupEnums.Quyen.KHOA.ToString()
						|| mGroup == GroupEnums.Quyen.PGV.ToString()
				)
				{
					connectionString = ConfigurationManager.ConnectionStrings[
							"localhost_QLDSV_TC_Connection11"
					].ConnectionString;
					connectionString = connectionString.Replace("MSSQLSERVER1", "MSSQLSERVER2");

					/// thay đổi lại trong app config
					config.ConnectionStrings.ConnectionStrings[
							"localhost_QLDSV_TC_Connection11"
					].ConnectionString = connectionString;
				}
			}

			// để ở ngoài cùng
			config.Save(ConfigurationSaveMode.Modified);
		}
	}
}