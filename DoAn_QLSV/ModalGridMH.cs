using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class ModalGridMH : DevExpress.XtraEditors.XtraForm
	{
		private string storedProcedureName;
		private BindingSource mhBindingSource = new BindingSource();
		public static object[] selectedRowMH;
		public ModalGridMH()
		{
			InitializeComponent();
		}
		public ModalGridMH(string storedProcedureName)
		{
			InitializeComponent();
			this.storedProcedureName = storedProcedureName;
		}

		private void modalEffect_Timer_Tick(object sender, EventArgs e)
		{
			if (Opacity == 1)
			{
				modalEffect_Timer.Stop();
			}
			else
			{
				Opacity += .03;
			}

		}

		private void ModalGridMH_Load(object sender, EventArgs e)
		{

			this.Location = new Point(FormQuanLyLopTinChi.parentX + 220, FormQuanLyLopTinChi.parentY + 150);

			Lay_Danh_Sach_MH();
		}

		private void Lay_Danh_Sach_MH()
		{
			try
			{
				DataTable MHDataTable = new DataTable();
				if (storedProcedureName == "SP_LAY_DANH_SACH_MON_HOC_MODAL")
				{
					MHDataTable = Program.ExecSqlQuery("EXEC " + storedProcedureName, Program.connstr);

				}
				else if (storedProcedureName == "SP_LAY_MON_HOC_LTC_THUOC_NIENKHOA_HOCKY_NHOM")
				{
					string cmd = $"EXEC {storedProcedureName} '{Frpt_BangDiemMonHocCuaLTC.nienkhoa}', {Frpt_BangDiemMonHocCuaLTC.hocky}, {Frpt_BangDiemMonHocCuaLTC.nhom},'{Frpt_BangDiemMonHocCuaLTC.maKhoa}'";


					MHDataTable = Program.ExecSqlQuery(cmd, Program.connstr);
				}

				mhBindingSource.DataSource = MHDataTable;
				gridMH.DataSource = mhBindingSource;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			selectedRowMH = Program.GetSelectedRowGridControl(gridMH);
			this.Hide();
		}
	}
}