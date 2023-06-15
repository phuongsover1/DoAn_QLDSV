using DevExpress.Xpo;
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
	public partial class Frpt_DiemTongKetCuoiKhoa : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource lopBindingSource = new BindingSource();

		private Configuration config;

		private SqlConnection conn_publisher = new SqlConnection();
		public Frpt_DiemTongKetCuoiKhoa()
		{
			InitializeComponent();
		}

		private void Frpt_DiemTongKetCuoiKhoa_Load(object sender, EventArgs e)
		{

			if (FormQuanLyLop.KetNoi_CSDLGOC(conn_publisher) == 0)
				return;
			FormQuanLyLop.LayDSPM("SELECT * FROM dbo.Get_Subscribes", conn_publisher, cmbKhoa);
			if (Program.mGroup != GroupEnums.Quyen.PGV.ToString())
			{
				cmbKhoa.Enabled = false;
			}

			cmbKhoa.SelectedIndex = Program.mKhoa;
			Lay_Danh_Sach_Lop_Theo_Khoa();
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

		private void btnInDiemTKCK_Click(object sender, EventArgs e)
		{
			object[] selectedLop = Program.GetSelectedRowGridControl(gridLop);

			if (selectedLop == null)
			{
				XtraMessageBox.Show("Bạn chưa chọn lớp để in điểm!!", "Lỗi", MessageBoxButtons.OK);
				return;
			}

			Frpt_DanhSachLopTinChi.ChangeUserNameAndPasswordConnectionString(cmbKhoa.SelectedIndex, Program.mGroup, config);

			Xrpt_DiemTongKetCuoiKhoa rpt = new Xrpt_DiemTongKetCuoiKhoa(cmbKhoa.SelectedIndex, selectedLop[0].ToString(), selectedLop[1].ToString(), selectedLop[2].ToString());

			ReportPrintTool print = new ReportPrintTool(rpt);
			print.ShowPreviewDialog();

		}
	}
}