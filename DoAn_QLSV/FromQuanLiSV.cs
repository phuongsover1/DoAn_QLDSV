using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLSV.Utils;

namespace DoAn_QLSV
{
	public partial class FromQuanLiSV : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource lopBindingSource = new BindingSource();
		private SqlConnection conn_publisher = new SqlConnection();
		private bool isAddNew;


		public FromQuanLiSV()
		{
			InitializeComponent();
			Lay_Danh_Sach_Nien_Khoa();
		}
		private void FormQuanSV_Load(object sender, EventArgs e)
		{
			//if (KetNoi_CSDLGOC(conn_publisher) == 0)
			//return;
			//LayDSPM("SELECT * FROM dbo.Get_Subscribes", conn_publisher, cmbKhoa);
			if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
			{
				cmbKhoa.Enabled = false;
			}
			if (Program.servername == "DESKTOP-OM4F2K5\\MSSQLSERVER1")
				this.cmbKhoa.Text = "CNTT";
			else
				this.cmbKhoa.Text = "VT";

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

		private void btnThem_Click(object sender, EventArgs e)
		{
			checkNghi.Enabled = false;
			if (kiemTraDuLieu() == false)
				return;
			List<string> phai = new List<string>();
			phai.Add("Nam");
			phai.Add("Nữ");
			cbPhai.DataSource = phai;
			isAddNew = true;
			txtMaSV.Enabled = true;
			txtMaSV.Text = "";
			//txtTenLop.Text = "";
			txtHo.Text = "";
			object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
			txtMaLop.Text = cbLop.Text;

			groupControlThongTinLop.Text = "Thêm Lớp Học";
			groupControlThongTinLop.Visible = true;
			SetEnabledCacButton(false);
		}



		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Lop_Theo_Khoa();

			if (Program.servername == "DESKTOP-OM4F2K5\\MSSQLSERVER1")
				this.cmbKhoa.Text = "CNTT";
			else
				this.cmbKhoa.Text = "VT";
		}

		private void Lay_Danh_Sach_Lop_Theo_Khoa()
		{
			string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
			DataTable lopDataTable = Program.ExecSqlQuery(
							"EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + khoaDaChon + "'",
							Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);
			//lopBindingSource.DataSource = lopDataTable;
			//gridLop.DataSource = lopBindingSource;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Lay_Danh_Sach_Nien_Khoa();

			Lay_Danh_Sach_Lop_Theo_Khoa_Va_Nien_Khoa();

		}
		private void Lay_Danh_Sach_Lop_Theo_Khoa_Va_Nien_Khoa()
		{
			string khoaDaChon = cmbKhoa.Text;
			DataTable lopDataTable = Program.ExecSqlQuery(
					"EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA_VA_NIEN_KHOA '" + khoaDaChon + "','" + cbNK.Text + "'",
					Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);

			cbLop.DataSource = lopDataTable;
			cbLop.DisplayMember = "malop";

		}

		private void Lay_Danh_Sach_Nien_Khoa()
		{
			string khoaDaChon = cmbKhoa.Text;
			DataTable lopDataTable = Program.ExecSqlQuery(
				"SELECT DISTINCT khoahoc INTO #TEMP FROM LOP where makhoa ='" + khoaDaChon + "' " +
				"if (not exists(select 1 from #TEMP)) begin " +
				" SELECT DISTINCT khoahoc FROM LINK1.QLDSV_TC.DBO.LOP" +
				" end else begin SELECT* FROM #TEMP end "
				,
				Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);

			// Set the DataSource and DisplayMember properties of the ComboBox
			cbNK.DataSource = lopDataTable;
			cbNK.DisplayMember = "khoahoc";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Lay_Danh_Sach_SV();
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;

		}
		private void Lay_Danh_Sach_SV()
		{
			string khoaDaChon = cbNK.SelectedIndex == 0 ? "CNTT" : "VT";
			DataTable lopDataTable = Program.ExecSqlQuery(
					" SELECT MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, MALOP, DANGHIHOC INTO #TEMP FROM SINHVIEN WHERE MALOP='" + cbLop.Text + "' " +
					" if (not exists(select 1 from #TEMP)) begin " +
					" SELECT MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, MALOP, DANGHIHOC FROM LINK1.QLDSV_TC.DBO.SINHVIEN WHERE MALOP='" + cbLop.Text + "' " +
					" end else begin SELECT* FROM #TEMP end ",
					Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);
			lopBindingSource.DataSource = lopDataTable;
			gridLop.DataSource = lopBindingSource;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (kiemTraDuLieu())
				checkNghi.Enabled = true;
			isAddNew = false;
			object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
			txtMaSV.Text = selectedRow[0].ToString();
			txtHo.Text = selectedRow[1].ToString();
			txtTen.Text = selectedRow[2].ToString();
			//phai 4
			List<string> phai = new List<string>();
			phai.Add("Nam");
			phai.Add("Nữ");
			cbPhai.DataSource = phai;
			bool value = (bool)selectedRow[3];
			Console.WriteLine(selectedRow[3].GetType());
			Console.WriteLine(selectedRow[3].ToString());
			//XtraMessageBox.Show(a, "Lỗi", MessageBoxButtons.OK);
			if (value)
				cbPhai.SelectedIndex = 1;
			else
				cbPhai.SelectedIndex = 0;
			txtDiachi.Text = selectedRow[4].ToString();
			//date 5

			//nghihoc 6

			//password


			txtMaLop.Text = cbLop.Text;
			//txtMaKhoa.Text = selectedRow[3].ToString();
			SetEnabledCacButton(false);

			txtMaSV.Enabled = false;
			//txtMaKhoa.Enabled = false;
			groupControlThongTinLop.Text = "Sửa Thông Tin Lớp";
			groupControlThongTinLop.Visible = true;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			object[] selectedRow = Program.GetSelectedRowGridControl(gridLop);
			string maSV = selectedRow[0].ToString();
			SqlCommand cmd = new SqlCommand();
			try
			{
				ParameterStoredProcedure[] parameters = new ParameterStoredProcedure[]
				{
										new ParameterStoredProcedure() { ParamName = "@MASV", ParamValue = maSV }
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
						"SP_XOA_SINHVIEN",
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

		private void btnReload_Click(object sender, EventArgs e)
		{
			Lay_Danh_Sach_SV();

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
				//btnThem.Enabled = true;
				//btnSua.Enabled = true;
				btnReload.Enabled = true;
			}
			else
			{
				//btnThem.Enabled = false;
				//btnSua.Enabled = false;
				btnReload.Enabled = false;
				cmbKhoa.Enabled = false;
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string maLop = txtMaLop.Text.Trim().ToUpper();
			//string tenLop = txtTenLop.Text.Trim();
			string maSV = txtMaSV.Text.Trim();
			string ho = txtHo.Text.Trim();
			string ten = txtTen.Text.Trim();
			bool phai = true;
			if (cbPhai.SelectedIndex == 0)
				phai = false;

			string diaChi = txtDiachi.Text.Trim();
			DateTime ngaySinh = deNgaySinh.DateTime;
			bool nghi = checkNghi.Checked;
			string password = txtMK.Text.Trim();
			//string maKhoa = txtMaKhoa.Text;
			if (isAddNew)
			{
				string cmd = $"EXEC SP_THEM_SINH_VIEN '{maLop}','{maSV}',N'{ho}',N'{ten}',{phai}, N'{diaChi}','{ngaySinh}','{nghi}','{password}'";
				int result = Program.ExecSqlNonQuery(cmd, Program.connstr);

				if (result == 1)
				{
					XtraMessageBox.Show(
							"Đã thêm sinh viên thành công.",
							"Thông báo",
							MessageBoxButtons.OK
					);
				}
				else
				{
					XtraMessageBox.Show(
							"Thêm sinh viên thất bại. Mã lỗi: " + result.ToString(),
							"Lỗi",
							MessageBoxButtons.OK
					);
					return;
				}
			}
			else
			{
				string cmd = $"EXEC SP_SUA_SINH_VIEN '{maSV}','{ho}','{ten}','{phai}','{diaChi}','{ngaySinh}','{nghi}','{password}'";
				int result = Program.ExecSqlNonQuery(cmd, Program.connstr);
				if (result == 1)
				{
					XtraMessageBox.Show(
							"Đã chỉnh sửa thông tin sinh viên thành công.",
							"Thông báo",
							MessageBoxButtons.OK
					);
				}
				else
				{
					XtraMessageBox.Show(
							"Chỉnh sửa thông tin của sinh viên thất bại. Mã lỗi: " + result.ToString(),
							"Lỗi",
							MessageBoxButtons.OK
					);
				}
			}
			Lay_Danh_Sach_Lop_Theo_Khoa();
			SetEnabledCacButton(true);
			//txtMaKhoa.Enabled = false;
			txtMaSV.Enabled = false;
			groupControlThongTinLop.Visible = false;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			SetEnabledCacButton(true);
			groupControlThongTinLop.Visible = false;
		}

		private bool kiemTraDuLieu()
		{
			if (CalculateAge(deNgaySinh.DateTime) < 16)
			{
				MessageBox.Show("Vui lòng nhập độ tuổi hợp lệ >16t", "Thông báo", MessageBoxButtons.OK);
				deNgaySinh.Focus();
				return false;
			}
			return true;
		}
		private static int CalculateAge(DateTime dateOfBirth)
		{
			int age = 0;
			age = DateTime.Now.Year - dateOfBirth.Year;
			if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
				age = age - 1;

			return age;
		}

		private void labelControl11_Click(object sender, EventArgs e)
		{

		}


		private void textEdit1_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void gridLop_Click(object sender, EventArgs e)
		{

		}

		private void labelControl3_Click(object sender, EventArgs e)
		{

		}

		private void deNgaySinh_EditValueChanged(object sender, EventArgs e)
		{

		}
	}
}