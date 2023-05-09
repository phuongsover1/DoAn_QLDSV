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

namespace DoAn_QLSV
{
	public partial class ModalGridGV : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource gvBindingSource = new BindingSource();
		public ModalGridGV()
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
		private int i;
		private void ModalGridGV_Load(object sender, EventArgs e)
		{
			i = FormQuanLyLopTinChi.parentY + 150;
			this.Location = new Point(FormQuanLyLopTinChi.parentX + 220, FormQuanLyLopTinChi.parentY + 150);

			Lay_Danh_Sach_GV();
		}

		private void Lay_Danh_Sach_GV()
		{
			try
			{
				DataTable GVDataTable = Program.ExecSqlQuery("EXEC SP_LAY_DANH_SACH_GIANG_VIEN_MODAL", Program.connstr);

				gvBindingSource.DataSource = GVDataTable;
				gridGV.DataSource = gvBindingSource;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			FormQuanLyLopTinChi.selectedRowGV = Program.GetSelectedRowGridControl(gridGV);
			this.Hide();
		}
	}
}