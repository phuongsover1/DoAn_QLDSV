using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class ModalGridMH : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource mhBindingSource = new BindingSource();
		public ModalGridMH()
		{
			InitializeComponent();
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
				DataTable MHDataTable = Program.ExecSqlQuery("EXEC SP_LAY_DANH_SACH_MON_HOC_MODAL", Program.connstr);

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
			FormQuanLyLopTinChi.selectedRowMH = Program.GetSelectedRowGridControl(gridMH);
			this.Hide();
		}
	}
}