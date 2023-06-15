using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_QLSV
{
	public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
	{
		private SqlConnection conn_publisher = new SqlConnection();
		private string taiKhoan = "";
		private string matKhau = "";
		private string maGV = "";
		private string vaiTro = "";
		public FormTaoTaiKhoan()
		{
			InitializeComponent();
			FormTaoTaiKhoan_Load();
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			bool ketQua = kiemTraDuLieuDauVao();
			if (ketQua == false) return;

			taiKhoan = Program.maGVDuocChon;
			matKhau = txtMatKhau.Text;
			maGV = Program.maGVDuocChon;
			if (rdKhoa.Checked == true)
				vaiTro = "KHOA";
			else if (rdKeToan.Checked == true)
				vaiTro = "PKT";
			else
				vaiTro = "PGV";

			Console.WriteLine(taiKhoan);
			Console.WriteLine(matKhau);
			Console.WriteLine(maGV);
			Console.WriteLine(vaiTro);

			/*declare @returnedResult int
			 exec @returnedResult = sp_TraCuu_KiemTraMaNhanVien '20'
			 select @returnedResult*/
			String cauTruyVan =
							"EXEC sp_TaoTaiKhoan '" + taiKhoan + "' , '" + matKhau + "', '"
							+ maGV + "', '" + vaiTro + "'";
			if (rdKeToan.Checked == true)
			{
				taoTK(cauTruyVan, Program.servername3);
			}

			else if (Program.khoaDaChonDeTaoTaiKhoan == "VT")
			{
				taoTK(cauTruyVan, Program.servername2);
			}
			else if (Program.khoaDaChonDeTaoTaiKhoan == "CNTT")
			{
				taoTK(cauTruyVan, Program.servername1);
			}

		}

		private void taoTK(String cauTruyVan, String khoa)
		{
			SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
			try
			{
				Program.myReader = Program.ExecSqlDataReader(cauTruyVan, Program.createConnectionString(khoa, Program.remoteLogin, Program.remotePassword));
				/*khong co ket qua tra ve thi ket thuc luon*/
				if (Program.myReader == null)
				{
					return;
				}

				MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maGV + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex.Message);
				return;
			}
		}
		private void btnChonNhanVien_Click(object sender, EventArgs e)
		{
			FormChonGV form = new FormChonGV();
			form.ShowDialog();

			txtMaNhanVien.Text = Program.maGVDuocChon;
		}

		private bool kiemTraDuLieuDauVao()
		{
			if (txtMaNhanVien.Text == "")
			{
				MessageBox.Show("Thiếu mã giảng viên", "Thông báo", MessageBoxButtons.OK);
				return false;
			}

			if (txtMatKhau.Text == "")
			{
				MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
				return false;
			}

			if (txtXacNhanMatKhau.Text == "")
			{
				MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
				return false;
			}

			if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
			{
				MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
				return false;
			}

			return true;
		}
		private void FormTaoTaiKhoan_Load()
		{
			if (Program.mGroup == "KHOA")
			{
				vaiTro = "KHOA";
				rdKhoa.Enabled = false;
				rdPGV.Enabled = false;
				rdKeToan.Enabled = false;
			}
			if (Program.mGroup == "PKT")
			{
				rdKeToan.Checked = true;
				vaiTro = "PKT";
				rdKhoa.Enabled = false;
				rdPGV.Enabled = false;
				rdKeToan.Enabled = false;
			}
			if (Program.mGroup == "PGV")
			{
				rdPGV.Checked = true;
				vaiTro = "PGV";
				rdKhoa.Enabled = true;
				rdPGV.Enabled = true;
				rdKeToan.Enabled = true;
			}

		}
	}
}