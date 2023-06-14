using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class Frpt_BangDiemMonHocCuaLTC : DevExpress.XtraEditors.XtraForm
	{
		public static int parentX, parentY;
		private SqlConnection conn_publisher = new SqlConnection();
		private Configuration config;
		public static string maKhoa;
		public static string nienkhoa;
		public static string hocky;
		public static string nhom;
		public static object[] selectedRowMH;

		public Frpt_BangDiemMonHocCuaLTC()
		{
			InitializeComponent();
		}

		private void Frpt_BangDiemMonHocCuaLTC_Load(object sender, EventArgs e)
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

		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			maKhoa = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
			Lay_Danh_Sach_Nien_Khoa();
			Lay_Danh_Sach_Hoc_Ky();
			Lay_Danh_Sach_Nhom_Thuoc_NienKhoa_HocKy();
			txtMaMH.Text = "";

		}

		private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Hoc_Ky();
			Lay_Danh_Sach_Nhom_Thuoc_NienKhoa_HocKy();

			nienkhoa = cmbNienKhoa.SelectedValue.ToString();
			txtMaMH.Text = "";
		}

		private void btnChonMH_Click(object sender, EventArgs e)
		{
			Mo_Modal_MH();

			if (ModalGridMH.selectedRowMH != null)
			{
				txtMaMH.Text = ModalGridMH.selectedRowMH[0].ToString();
			}
		}

		private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
		{

			hocky = cmbHocKy.SelectedValue.ToString();
			Lay_Danh_Sach_Nhom_Thuoc_NienKhoa_HocKy();
			txtMaMH.Text = "";
		}

		private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
		{

			nhom = cmbNhom.SelectedValue.ToString();
			txtMaMH.Text = "";
		}

		private void Lay_Danh_Sach_Nhom_Thuoc_NienKhoa_HocKy()
		{
			if (cmbNienKhoa.SelectedValue != null && cmbHocKy.SelectedValue != null)
			{
				DataTable dt = new DataTable();
				string cmd = $"EXEC SP_LAY_DANH_SACH_NHOM_THEO_NIENKHOA_HOCKY '{maKhoa}', '{cmbNienKhoa.SelectedValue}', {cmbHocKy.SelectedValue}";
				try
				{
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, Program.connstr))
					{
						sqlDataAdapter.Fill(dt);
						cmbNhom.DataSource = dt;
						cmbNhom.DisplayMember = "NHOM";
						cmbNhom.ValueMember = "NHOM";
					}


				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}




		}

		private void btnInBangDiemLTC_Click(object sender, EventArgs e)
		{
			Frpt_DanhSachLopTinChi.ChangeUserNameAndPasswordConnectionString(cmbKhoa.SelectedIndex, Program.mGroup, config);
			Xrpt_BangDiemMonHocLTC rpt = new Xrpt_BangDiemMonHocLTC(cmbKhoa.SelectedIndex, cmbNienKhoa.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString(), cmbNhom.SelectedValue.ToString(), ModalGridMH.selectedRowMH[0].ToString(), ModalGridMH.selectedRowMH[1].ToString());

			ReportPrintTool printTool = new ReportPrintTool(rpt);
			printTool.ShowPreviewDialog();


		}

		private void Mo_Modal_MH()
		{
			XtraForm modalMHBackground = new XtraForm();
			using (ModalGridMH modalGridMH = new ModalGridMH("SP_LAY_MON_HOC_LTC_THUOC_NIENKHOA_HOCKY_NHOM"))
			{
				modalMHBackground.StartPosition = FormStartPosition.Manual;
				modalMHBackground.FormBorderStyle = FormBorderStyle.None;
				modalMHBackground.Opacity = 0.50d;
				modalMHBackground.BackColor = Color.Black;
				modalMHBackground.Size = this.Size;
				modalMHBackground.Location = this.Location;
				modalMHBackground.WindowState = FormWindowState.Maximized;

				modalMHBackground.ShowInTaskbar = false;
				modalMHBackground.Show();
				modalGridMH.Owner = modalMHBackground;

				parentX = this.Location.X;
				parentY = this.Location.Y;

				modalGridMH.ShowDialog();
				modalMHBackground.Dispose();
			}
		}
	}
}