using DevExpress.Emf;
using DevExpress.XtraEditors;
using DoAn_QLSV.Utils;
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
	public partial class FormQuanLyMonHoc : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource monHocBindingSource = new BindingSource();
		private bool isUpdate;

		public FormQuanLyMonHoc()
		{
			InitializeComponent();
		}

		private void FormQuanLyMonHoc_Load(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Mon_Hoc();
		}

		private void Lay_Danh_Sach_Mon_Hoc()
		{
			DataTable monHocDataTable = Program.ExecSqlQuery("EXEC SP_LAY_DANH_SACH_MON_HOC", Program.connstr);
			monHocBindingSource.DataSource = monHocDataTable;
			gridMonHoc.DataSource = monHocBindingSource;
		}

		private void btnDelete_ButtonClick(
				object sender,
				DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e
		)
		{
			object[] selectedRow = Program.GetSelectedRowGridControl(gridMonHoc);
			MONHOC monHoc = new MONHOC() { MAMH = selectedRow[0].ToString(), TENMH = selectedRow[1].ToString(), SOTIET_LT = Convert.ToInt32(selectedRow[2].ToString()), SOTIET_TH = Convert.ToInt32(selectedRow[3].ToString()) };

			DialogResult result = XtraMessageBox.Show(
					"Bạn có thực sự muốn xóa môn học: " + monHoc.TENMH,
					"Thông báo",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning
			);
			if (result == DialogResult.Yes)
			{
				// chạy sp xóa môn
				SqlCommand cmd = new SqlCommand();
				ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[]
				{
					new ParameterStoredProcedure() { ParamName = "@MAMH", ParamValue= monHoc.MAMH } };

				OutputParameterStoredProcedure[] outputParameters = new OutputParameterStoredProcedure[]
				{
					new OutputParameterStoredProcedure() { Name = "@KETQUA", Type = SqlDbType.Bit }, new OutputParameterStoredProcedure() {Name = "@LOI", Type= SqlDbType.NVarChar, Length= 100}
				};


				try
				{
					cmd = Program.GetResultFromStoredProcedured(cmd, "SP_XOA_MON_HOC", Program.connstr, parameters, outputParameters);
					bool ketqua = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);
					string loi = Convert.ToString(cmd.Parameters[outputParameters[1].Name].Value);
					if (ketqua)
					{
						XtraMessageBox.Show("Xóa môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Lay_Danh_Sach_Mon_Hoc();
					}
					else XtraMessageBox.Show(loi, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					cmd.Dispose();
				}
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			isUpdate = false;
			HienGiaoDien(false);
			groupControlThongTinMonHoc.Text = "Thêm thông tin môn học";
			txtMaMH.Text = "";
			txtTenMH.Text = "";
			txtTietLT.Text = "";
			txtTietTH.Text = "";
		}

		private void HienGiaoDien(bool booleanValue)
		{
			btnThem.Enabled = booleanValue;
			btnSua.Enabled = booleanValue;
			btnReload.Enabled = booleanValue;
			gridMonHoc.Enabled = booleanValue;
			groupControlThongTinMonHoc.Visible = !booleanValue;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			HienGiaoDien(true);
		}

		private void txtMaMH_Leave(object sender, EventArgs e)
		{
			string maMH = txtMaMH.Text;
			SqlCommand cmd = new SqlCommand();
			try
			{
				ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[]
				{
										new ParameterStoredProcedure() { ParamName = "@MAMH", ParamValue = maMH },

				};
				OutputParameterStoredProcedure[] outputParameters =
						new OutputParameterStoredProcedure[]
						{
												new OutputParameterStoredProcedure()
												{
														Name = "@KETQUA",
														Type = SqlDbType.Bit
												},
												new OutputParameterStoredProcedure()
												{
														Name = "@LOI",
														Type = SqlDbType.NVarChar,
														Length = 100
												}
						};
				cmd = Program.GetResultFromStoredProcedured(
						cmd,
						"SP_KIEM_TRA_MA_MON_HOC",
						Program.connstr,
						parameters,
						outputParameters
				);
				bool ketqua = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);
				string loi = Convert.ToString(cmd.Parameters[outputParameters[1].Name].Value);
				if (!ketqua)
				{
					XtraMessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK);
					txtMaMH.Focus();
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cmd.Dispose();
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string maMH = txtMaMH.Text;
			string tenMH = txtTenMH.Text;
			string tietLT = txtTietLT.Text;
			string tietTH = txtTietTH.Text;
			string errorMessage = KiemTraTruongDuLieu(maMH, tenMH, tietLT, tietTH);
			if (errorMessage != null)
			{
				XtraMessageBox.Show(
						errorMessage,
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
				);
				return;
			}
			SqlCommand cmd = new SqlCommand();
			ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[]
		{
						new ParameterStoredProcedure() {ParamName = "@MAMH", ParamValue = maMH },
						new ParameterStoredProcedure() {ParamName = "@TENMONHOC", ParamValue = tenMH },
						new ParameterStoredProcedure() {ParamName = "@SOTIET_LT", ParamValue = tietLT},
						new ParameterStoredProcedure() {ParamName = "@SOTIET_TH", ParamValue = tietTH },


		};
			OutputParameterStoredProcedure[] outputParameters = new OutputParameterStoredProcedure[]
	{
						new OutputParameterStoredProcedure() { Name = "@KETQUA", Type = SqlDbType.Bit },
						new OutputParameterStoredProcedure() {Name = "@LOI", Type = SqlDbType.NVarChar, Length = 100}
	};
			try
			{
				string storedProcedureName = null;
				if (!isUpdate) // thêm mới
					storedProcedureName = "SP_THEM_MON_HOC";
				else // update
					storedProcedureName = "SP_SUA_MON_HOC";

				cmd = Program.GetResultFromStoredProcedured(cmd, storedProcedureName, Program.connstr, parameters, outputParameters);
				string loi = Convert.ToString(cmd.Parameters[outputParameters[1].Name].Value);
				bool ketqua = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);
				if (ketqua)
				{
					if (!isUpdate)
						XtraMessageBox.Show("Thêm môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						XtraMessageBox.Show("Sửa môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					XtraMessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cmd.Dispose();
			}

			HienGiaoDien(true);
			txtMaMH.Text = "";
			txtMaMH.Enabled = true;
			Lay_Danh_Sach_Mon_Hoc();

		}

		private string KiemTraTruongDuLieu(string maMH, string tenMH, string tietLT, string tietTH)
		{
			string errorMessage = null;
			if (maMH.Trim() == "")
			{
				errorMessage = "Mã môn học không được để trống";
				return errorMessage;
			}
			if (tenMH.Trim() == "")
			{
				errorMessage = "Tên môn học không được để trống";
				return errorMessage;
			}
			if (tietLT.Trim() == "")
			{
				errorMessage = "Số tiết lý thuyết không được để trống";
				return errorMessage;
			}
			if (tietTH.Trim() == "")
			{
				errorMessage = "Số tiết thực hành không được để trống";
				return errorMessage;
			}
			return errorMessage;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			isUpdate = true;
			HienGiaoDien(false);
			groupControlThongTinMonHoc.Text = "Sửa thông tin môn học";

			object[] selectedRow = Program.GetSelectedRowGridControl(gridMonHoc);
			txtMaMH.Text = selectedRow[0].ToString();
			txtTenMH.Text = selectedRow[1].ToString();
			txtTietLT.Text = selectedRow[2].ToString();
			txtTietTH.Text = selectedRow[3].ToString();
			txtMaMH.Enabled = false;


		}

		private void txtTietLT_Leave(object sender, EventArgs e)
		{
			try
			{
				int tietLT = Convert.ToInt32(txtTietLT.Text);
			}
			catch (System.FormatException ex)
			{
				XtraMessageBox.Show(
						"Số tiết lý thuyết phải là số !!!",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
				);
				txtTietLT.Focus();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTietTH_Leave(object sender, EventArgs e)
		{
			try
			{
				int tietTH = Convert.ToInt32(txtTietTH.Text);
			}
			catch (FormatException ex)
			{
				XtraMessageBox.Show(
						"Số tiết thực hành phải là số !!!",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
				);
				txtTietTH.Focus();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
