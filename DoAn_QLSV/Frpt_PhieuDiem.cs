using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class Frpt_PhieuDiem : DevExpress.XtraEditors.XtraForm
	{
		private Configuration config;
		private BindingSource SVBindingSource = new BindingSource();
		private SqlConnection conn_publisher = new SqlConnection();
		public static int cmbKhoaIndex = 0;
		public static object[] selectedLop;
		public static int parentX, parentY;
		public static object[] selectedSV;



		public Frpt_PhieuDiem()

		{
			InitializeComponent();
		}

		private void Frpt_PhieuDiem_Load(object sender, EventArgs e)
		{
			if (FormQuanLyLop.KetNoi_CSDLGOC(conn_publisher) == 0)
				return;
			FormQuanLyLop.LayDSPM("SELECT * FROM dbo.Get_Subscribes_Not_HP", conn_publisher, cmbKhoa);
			if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
			{
				cmbKhoa.Enabled = false;
			}

			cmbKhoa.SelectedIndex = Program.mKhoa;
			cmbKhoaIndex = cmbKhoa.SelectedIndex;

			if (Program.mGroup.Equals("SV"))
			{
				txtMaSV.Visible = true;
				lblMaSV.Visible = true;
				lblMatKhau.Visible = true;
				txtMatKhau.Visible = true;
				txtMaLop.Visible = false;
				lblMaLop.Visible = false;
				btnChonLop.Visible = false;
			}
			else
			{
				txtMaSV.Visible = false;
				lblMaSV.Visible = false;
				txtMaLop.Visible = true;
				lblMaLop.Visible = true;
				lblMatKhau.Visible = false;
				txtMatKhau.Visible = false;
				btnChonLop.Visible = true;
			}
		}


		private void Lay_Danh_Sach_SV_Theo_Lop(string maLop)
		{
			//string khoaDaChon = cmbKhoa.SelectedIndex == 0 ? "CNTT" : "VT";
			DataTable svDataTable = Program.ExecSqlQuery(
					"EXEC SP_DANH_SACH_SINH_VIEN '" + maLop + "'",
					Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);
			SVBindingSource.DataSource = svDataTable;
			gridSV.DataSource = SVBindingSource;
		}

		private void btnChonLop_Click(object sender, EventArgs e)
		{
			Mo_Modal_Lop();

			if (selectedLop != null)
			{
				txtMaLop.Text = selectedLop[0].ToString();
			}

			if (txtMaLop.Text.Equals(""))
			{
				XtraMessageBox.Show("Hãy chọn mã lớp trước", "Lỗi", MessageBoxButtons.OK);
				return;
			}
			Lay_Danh_Sach_SV_Theo_Lop(selectedLop[0].ToString());
		}

		private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbKhoaIndex = cmbKhoa.SelectedIndex;
			txtMaLop.Text = "";
		}

		private void btnInPhieuDiem_Click(object sender, EventArgs e)
		{
			if (!Program.mGroup.Equals("SV"))
			{
				selectedSV = Program.GetSelectedRowGridControl(gridSV);
				if (selectedSV == null)
				{
					XtraMessageBox.Show("Bạn chưa chọn sinh viên để in điểm!!", "Lỗi", MessageBoxButtons.OK);
					return;
				}

				Frpt_DanhSachLopTinChi.ChangeUserNameAndPasswordConnectionString(cmbKhoa.SelectedIndex, Program.mGroup, config);

				Xrpt_PhieuDiem rpt = new Xrpt_PhieuDiem(cmbKhoaIndex, selectedLop[0].ToString(), selectedSV[0].ToString(), selectedSV[1].ToString());

				ReportPrintTool print = new ReportPrintTool(rpt);
				print.ShowPreviewDialog();
			}
			else
			{

				String statement = "EXEC sp_sv_dang_nhap @MSV =" + txtMaSV.Text + ", @MK= '" + txtMatKhau.Text + "'";
				SqlDataReader temp = Program.ExecSqlDataReader(statement, Program.connstr);
				if (!temp.HasRows)
				{
					System.Windows.Forms.MessageBox.Show("Sai mật khẩu hoặc tài khoản");
					return;
				}
				temp.Read();

				Frpt_DanhSachLopTinChi.ChangeUserNameAndPasswordConnectionString(cmbKhoa.SelectedIndex, Program.mGroup, config);

				Xrpt_PhieuDiem rpt = new Xrpt_PhieuDiem(cmbKhoaIndex, temp.GetString(3), temp.GetString(0), temp.GetString(1) + " " + temp.GetString(2));

				ReportPrintTool print = new ReportPrintTool(rpt);
				print.ShowPreviewDialog();
			}



		}

		private void Mo_Modal_Lop()
		{
			XtraForm modalLopBackground = new XtraForm();
			using (ModalGridLop modalGridLop = new ModalGridLop())
			{
				modalLopBackground.StartPosition = FormStartPosition.Manual;
				modalLopBackground.FormBorderStyle = FormBorderStyle.None;
				modalLopBackground.Opacity = 0.50d;
				modalLopBackground.BackColor = Color.Black;
				modalLopBackground.Size = this.Size;
				modalLopBackground.Location = this.Location;
				modalLopBackground.WindowState = FormWindowState.Maximized;

				modalLopBackground.ShowInTaskbar = false;
				modalLopBackground.Show();
				modalGridLop.Owner = modalLopBackground;

				parentX = this.Location.X;
				parentY = this.Location.Y;

				modalGridLop.ShowDialog();
				modalLopBackground.Dispose();
			}
		}
	}
}