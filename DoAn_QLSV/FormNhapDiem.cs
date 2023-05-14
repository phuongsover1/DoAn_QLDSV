using DevExpress.Utils.DirectXPaint.Svg;
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
	public partial class FormNhapDiem : DevExpress.XtraEditors.XtraForm
	{
		private SqlConnection conn_publisher = new SqlConnection();
		private readonly BindingSource lopTCBindingSource = new BindingSource();
		private readonly BindingSource sinhvienBindingSource = new BindingSource();
		private string maKhoa;
		public FormNhapDiem()
		{
			InitializeComponent();
		}

		private void FormNhapDiem_Load(object sender, EventArgs e)
		{
			groupControlSV.Visible = false;
			if (FormQuanLyLop.KetNoi_CSDLGOC(conn_publisher) == 0)
				return;
			FormQuanLyLop.LayDSPM("SELECT * FROM dbo.Get_Subscribes", conn_publisher, cmbKhoa);
			if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
			{
				cmbKhoa.Enabled = false;
			}

			cmbKhoa.SelectedIndex = Program.mKhoa;

		}

		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				maKhoa = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
				Lay_Danh_Sach_Nien_Khoa();
				Lay_Danh_Sach_Hoc_Ky();

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

		private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Hoc_Ky();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Nien_Khoa();
			Lay_Danh_Sach_Hoc_Ky();
		}

		private void btnNhapDiem_Click(object sender, EventArgs e)
		{
			if (gridView1.DataSource != null)
			{
				Lay_Danh_Sach_SV_CUA_LTC();
			}
			else
			{
				XtraMessageBox.Show("Bạn hãy tải lớp tín chỉ và chọn lớp tín chỉ muốn nhập điểm trước.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void Lay_Danh_Sach_SV_CUA_LTC()
		{


			object[] selectedRow = Program.GetSelectedRowGridControl(gridLTC);
			string maLTC = selectedRow[0].ToString();
			DataTable dt = new DataTable();
			string cmd = "EXEC SP_LAY_DANH_SACH_SINH_VIEN_DANG_KY_LTC " + maLTC;
			try
			{
				using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.connstr))
				{
					dataAdapter.Fill(dt);
					dt.Columns.Add("DIEM_HM", typeof(float));
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						string diem_cc_str = dt.Rows[i]["DIEM_CC"].ToString();
						string diem_gk_str = dt.Rows[i]["DIEM_GK"].ToString();
						string diem_ck_str = dt.Rows[i]["DIEM_CK"].ToString();
						int diem_cc = diem_cc_str != "" ? Convert.ToInt32(diem_cc_str) : 0;
						double diem_gk = diem_gk_str != "" ? Convert.ToDouble(diem_gk_str) : 0;
						double diem_ck = diem_ck_str != "" ? Convert.ToDouble(diem_ck_str) : 0;
						dt.Rows[i]["DIEM_HM"] = diem_cc * 0.1 + diem_gk * 0.3 + diem_ck * 0.6;
					}
					gridSV.DataSource = dt;
					groupControlSV.Visible = true;
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

		private void btnTaiLopTinChi_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			string cmd = "EXEC SP_LAY_DANH_SACH_LTC_THEO_KHOA_NIEN_KHOA_HOC_KY '" + maKhoa + "', '" + cmbNienKhoa.SelectedValue + "'," + cmbHocKy.SelectedValue.ToString();
			try
			{
				using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.connstr))
				{
					dataAdapter.Fill(dt);


					gridLTC.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
		{
			object[] selectedRow = Program.GetSelectedRowGridControl(gridSV);
			int diem_cc = 0;
			if (selectedRow[2].ToString() != "")
			{
				diem_cc = Convert.ToInt32(selectedRow[2].ToString());
			}

			double diem_gk = 0;
			if (selectedRow[3].ToString() != "")
			{
				diem_gk = Convert.ToDouble(selectedRow[3].ToString());
			}

			double diem_ck = 0;
			if (selectedRow[4].ToString() != "")
			{
				diem_ck = Convert.ToDouble(selectedRow[4].ToString());
			}
			double diem_hm = diem_cc * 0.1 + diem_gk * 0.3 + diem_ck * 0.6;

			gridView2.SetRowCellValue(gridView2.FocusedRowHandle, colDIEM_HM, diem_hm);


		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("MALTC", typeof(int));
			dt.Columns.Add("MASV", typeof(string));
			dt.Columns.Add("DIEM_CC", typeof(int));
			dt.Columns.Add("DIEM_GK", typeof(float));
			dt.Columns.Add("DIEM_CK", typeof(double));
			object[] selectedLTC = Program.GetSelectedRowGridControl(gridLTC);
			int maLTC = Convert.ToInt32(selectedLTC[0].ToString());
			DataTable sv_dt = ((DataView)gridView2.DataSource).Table;

			for (int i = 0; i < sv_dt.Rows.Count; ++i)
			{
				dt.Rows.Add(maLTC, sv_dt.Rows[i]["MASV"], sv_dt.Rows[i]["DIEM_CC"], sv_dt.Rows[i]["DIEM_GK"], sv_dt.Rows[i]["DIEM_CK"]);

			}
			SqlParameter para = new SqlParameter();
			para.SqlDbType = SqlDbType.Structured;
			para.TypeName = "dbo.TYPE_DANGKY";
			para.ParameterName = "@DIEMTHI";
			para.Value = dt;
			Program.KetNoi();

			SqlCommand sqlCmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);

			sqlCmd.Parameters.Clear();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.Parameters.Add(para);

			try
			{
				sqlCmd.ExecuteNonQuery();
				XtraMessageBox.Show("Đã cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Lay_Danh_Sach_SV_CUA_LTC();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}