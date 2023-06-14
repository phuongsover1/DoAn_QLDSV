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
	public partial class ModalGridLop : DevExpress.XtraEditors.XtraForm
	{
		private BindingSource lopBindingSource = new BindingSource();

		public ModalGridLop()
		{
			InitializeComponent();
		}


		private void Lay_Danh_Sach_Lop_Theo_Khoa()
		{
			string khoaDaChon = Frpt_PhieuDiem.cmbKhoaIndex == 0 ? "CNTT" : "VT";
			DataTable lopDataTable = Program.ExecSqlQuery(
					"EXEC SP_LAY_DANH_SACH_LOP_THEO_KHOA '" + khoaDaChon + "'",
					Program.createConnectionString(Program.servername, Program.mlogin, Program.password)
			);
			lopBindingSource.DataSource = lopDataTable;
			gridLop.DataSource = lopBindingSource;
		}

		private void ModalGridLop_Load(object sender, EventArgs e)
		{
			Lay_Danh_Sach_Lop_Theo_Khoa();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Frpt_PhieuDiem.selectedLop = Program.GetSelectedRowGridControl(gridLop);
			this.Close();
		}
	}
}