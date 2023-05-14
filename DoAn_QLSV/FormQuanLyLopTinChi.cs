using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DoAn_QLSV.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class FormQuanLyLopTinChi : DevExpress.XtraEditors.XtraForm
	{
		public static object[] selectedRowGV = null;

		public static int parentX, parentY;
		private bool isUpdate;
		private SqlConnection conn_publisher = new SqlConnection();
		private BindingSource ltcBindingSource = new BindingSource();

		public FormQuanLyLopTinChi()
		{
			InitializeComponent();
		}

		private void btnChonMonHoc_Click(object sender, EventArgs e)
		{
			Mo_Modal_MH();
			if (ModalGridMH.selectedRowMH != null)
			{
				txtMaMH.Text = ModalGridMH.selectedRowMH[0].ToString();
			}
		}

		private void btnChonGiangVien_Click(object sender, EventArgs e)
		{
			Mo_Modal_GV();

			if (selectedRowGV != null)
			{
				txtGiangVien.Text = selectedRowGV[0].ToString();
			}
		}
		private void Mo_Modal_GV()
		{
			XtraForm modalGVBackground = new XtraForm();
			using (ModalGridGV modalGridGV = new ModalGridGV())
			{
				modalGVBackground.StartPosition = FormStartPosition.Manual;
				modalGVBackground.FormBorderStyle = FormBorderStyle.None;
				modalGVBackground.Opacity = 0.50d;
				modalGVBackground.BackColor = Color.Black;
				modalGVBackground.Size = this.Size;
				modalGVBackground.Location = this.Location;
				modalGVBackground.WindowState = FormWindowState.Maximized;

				modalGVBackground.ShowInTaskbar = false;
				modalGVBackground.Show();
				modalGridGV.Owner = modalGVBackground;

				parentX = this.Location.X;
				parentY = this.Location.Y;

				modalGridGV.ShowDialog();
				modalGVBackground.Dispose();
			}
		}
		private void Mo_Modal_MH()
		{
			XtraForm modalMHBackground = new XtraForm();
			using (ModalGridMH modalGridMH = new ModalGridMH("SP_LAY_DANH_SACH_MON_HOC_MODAL"))
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


		private void btnThem_Click(object sender, EventArgs e)
		{
			isUpdate = false;
			txtLTC.Visible = false;
			txtNienKhoa.Text = "";
			txtHocKy.Text = "";
			txtNhom.Text = "";
			txtSoSVToiThieu.Text = "";
			txtMaMH.Text = "";
			txtGiangVien.Text = "";
			Hien_Control_Nhap_Thong_Tin(true);

		}

		private void Hien_Control_Nhap_Thong_Tin(bool enable)
		{
			groupControl1.Enabled = !enable;
			gridLTC.Enabled = !enable;
			groupControlThongTinMonHoc.Visible = enable;

		}

		private void FormQuanLyLopTinChi_Load(object sender, EventArgs e)
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

		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_LTC_Theo_Khoa();
			txtMaKhoa.Text = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";

		}


		private void Lay_Danh_Sach_LTC_Theo_Khoa()
		{
			string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
			try
			{
				DataTable ltcDataTable = Program.ExecSqlQuery(
						"EXEC SP_LAY_DANH_SACH_LOP_TIN_CHI_THEO_KHOA '" + khoaDaChon + "'",
						Program.connstr
				);
				ltcBindingSource.DataSource = ltcDataTable;
				gridLTC.DataSource = ltcBindingSource;

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			object[] selectedRow = Program.GetSelectedRowGridControl(gridLTC);

			// Kiểm tra xem lớp tín chỉ đã có sinh viên ? 
			DialogResult result = DialogResult.None;
			ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[] { new ParameterStoredProcedure() { ParamName = "@MALTC", ParamValue = selectedRow[0]?.ToString() } };
			OutputParameterStoredProcedure[] outputParameters = new OutputParameterStoredProcedure[]
			{
				new OutputParameterStoredProcedure() { Name = "@TONTAI", Type= SqlDbType.Bit }
			};
			string storedProcedureName = "SP_KIEM_TRA_LTC_CO_SINH_VIEN";
			SqlCommand cmd = new SqlCommand();
			try
			{
				cmd = Program.GetResultFromStoredProcedured(cmd, storedProcedureName, Program.connstr, parameters, outputParameters);
				bool tontai = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);


				if (tontai)

					result = XtraMessageBox.Show("Đã có sinh viên đăng kí lớp tín chỉ này. Bạn có thực sự muốn xóa lớp tín chỉ có mã lớp: " + selectedRow[0]?.ToString() + "? Sau khi hủy lớp tín chỉ thì sẽ hủy đăng ký của tất cả sinh viên mà đăng kí lớp tín chỉ này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				else
					result = XtraMessageBox.Show("Bạn có thực sự muốn xóa lớp tín chỉ có mã lớp: " + selectedRow[0]?.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cmd.Dispose();
			}

			if (result == DialogResult.Yes)
			{
				// gọi sp xóa
				cmd = new SqlCommand();

				storedProcedureName = "SP_XOA_LOP_TIN_CHI";
				parameters = new ParameterStoredProcedure[]
				{
						new ParameterStoredProcedure() { ParamName = "@MALTC", ParamValue = selectedRow[0]?.ToString()},

				};
				outputParameters = new OutputParameterStoredProcedure[]
				{
						new OutputParameterStoredProcedure() { Name= "@THANHCONG" , Type = SqlDbType.Bit},
						new OutputParameterStoredProcedure() {Name = "@LOI", Type = SqlDbType.NVarChar, Length = 200}
				};

				try
				{
					cmd = Program.GetResultFromStoredProcedured(cmd, storedProcedureName, Program.connstr, parameters, outputParameters);
					bool thanhcong = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);

					if (thanhcong)
					{
						XtraMessageBox.Show("Xóa lớp tín chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Lay_Danh_Sach_LTC_Theo_Khoa();
					}
					else
					{
						string loi = Convert.ToString(cmd.Parameters[outputParameters[1].Name].Value);
						XtraMessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}

				}
				catch (Exception ex)
				{
					XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
				finally
				{
					cmd.Dispose();
				}
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			Hien_Control_Nhap_Thong_Tin(false);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (!isInputValid())
				return;


			string storedProcedure_Name;

			SqlCommand cmd = new SqlCommand();
			try
			{
				List<ParameterStoredProcedure> listParameters = new List<ParameterStoredProcedure>();
				if (isUpdate)
					listParameters.Add(new ParameterStoredProcedure() { ParamName = "@MALTC", ParamValue = txtLTC.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@NIENKHOA", ParamValue = txtNienKhoa.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@HOCKY", ParamValue = txtHocKy.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@NHOM", ParamValue = txtNhom.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@SOSVTOITHIEU", ParamValue = txtSoSVToiThieu.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@MAMH", ParamValue = txtMaMH.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@MAGV", ParamValue = txtGiangVien.Text });
				listParameters.Add(new ParameterStoredProcedure() { ParamName = "@MAKHOA", ParamValue = txtMaKhoa.Text });

				OutputParameterStoredProcedure[] outputParameters = new OutputParameterStoredProcedure[]
				{
					new OutputParameterStoredProcedure() { Name = "@THANHCONG", Type = SqlDbType.Bit },
					new OutputParameterStoredProcedure() {Name = "@LOI", Type = SqlDbType.NVarChar, Length = 1000 }
				};

				storedProcedure_Name = isUpdate ? "SP_SUA_LOP_TIN_CHI" : "SP_THEM_LOP_TIN_CHI";
				// gọi sp 
				cmd = Program.GetResultFromStoredProcedured(cmd, storedProcedure_Name, Program.connstr, listParameters.ToArray(), outputParameters);

				bool thanhcong = Convert.ToBoolean(cmd.Parameters[outputParameters[0].Name].Value);
				string loi = Convert.ToString(cmd.Parameters[outputParameters[1].Name].Value);
				if (thanhcong)
				{
					string text;
					if (isUpdate)
						text = "Cập nhật lớp tín chỉ thành công";
					else text = "Thêm lớp tín chỉ thành công";

					XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					XtraMessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Hien_Control_Nhap_Thong_Tin(false);
				Lay_Danh_Sach_LTC_Theo_Khoa();
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

		private bool isInputValid()
		{
			try
			{
				// NIÊN KHÓA
				txtNienKhoa.Text = txtNienKhoa.Text.Trim();
				txtHocKy.Text = txtHocKy.Text.Trim();
				txtNhom.Text = txtNhom.Text.Trim();
				txtSoSVToiThieu.Text = txtSoSVToiThieu.Text.Trim();
				if (txtNienKhoa.Text == "")
				{
					XtraMessageBox.Show("Niên khóa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtNienKhoa.Focus();
					return false;
				}
				// HỌC KỲ
				if (txtHocKy.Text == "")
				{
					XtraMessageBox.Show("Học kỳ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtHocKy.Focus();
					return false;
				}

				try
				{
					int hocKy = Convert.ToInt32(txtHocKy.Text);
				}
				catch (FormatException ex)
				{
					XtraMessageBox.Show("Học kỳ phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtHocKy.Focus();
					return false;

				}
				// NHÓM
				if (txtNhom.Text == "")
				{
					XtraMessageBox.Show("Nhóm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtNhom.Focus();
					return false;
				}
				try
				{
					int nhom = Convert.ToInt32(txtNhom.Text);
				}
				catch (FormatException ex)
				{
					XtraMessageBox.Show("Nhóm phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtNhom.Focus();
					return false;
				}

				// SỐ SV TỐI THIỂU

				if (txtSoSVToiThieu.Text == "")
				{
					XtraMessageBox.Show("Số sinh viên tối thiểu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtSoSVToiThieu.Focus();
					return false;
				}
				try
				{
					int soSVToiThieu = Convert.ToInt32(txtSoSVToiThieu.Text);
				}
				catch (FormatException ex)
				{
					XtraMessageBox.Show("Số sinh viên tối thiểu phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtSoSVToiThieu.Focus();
					return false;
				}


			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;



		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			isUpdate = true;
			txtLTC.Visible = true;
			groupControlThongTinMonHoc.Text = "Sửa Thông Tin Môn Học";

			object[] selectedRow = Program.GetSelectedRowGridControl(gridLTC);
			try
			{
				if (selectedRow != null)
				{
					txtLTC.Text = selectedRow[0]?.ToString();
					txtNienKhoa.Text = selectedRow[1]?.ToString();
					txtHocKy.Text = selectedRow[2]?.ToString();
					txtNhom.Text = selectedRow[3]?.ToString();
					txtMaMH.Text = selectedRow[4]?.ToString();
					txtGiangVien.Text = selectedRow[5]?.ToString();
					txtSoSVToiThieu.Text = selectedRow[6]?.ToString();
					txtMaKhoa.Text = selectedRow[7]?.ToString();
				}
				else
					return;
				Hien_Control_Nhap_Thong_Tin(true);

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string Lay_Ma_Lop_Tin_Chi()
		{
			string maLTC = "NULL";
			SqlDataReader reader = null;
			try
			{
				reader = Program.ExecSqlDataReader("EXEC SP_LAY_MA_LOP_TIN_CHI", Program.connstr);

				if (reader == null)
					return "NULL";
				reader.Read();
				maLTC = reader.GetInt32(0).ToString();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
			return maLTC;
		}

	}
}
