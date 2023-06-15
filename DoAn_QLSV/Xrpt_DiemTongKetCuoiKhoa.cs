using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV
{
	public partial class Xrpt_DiemTongKetCuoiKhoa : DevExpress.XtraReports.UI.XtraReport
	{
		public Xrpt_DiemTongKetCuoiKhoa()
		{
			InitializeComponent();
		}

		public Xrpt_DiemTongKetCuoiKhoa(int cmbKhoaIndex, string maLop, string tenLop, string nienKhoa)
		{
			InitializeComponent();
			xr_lblKhoa.Text = cmbKhoaIndex == 0 ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG";
			xr_lblKhoaHoc.Text = nienKhoa.ToUpper();
			xr_lblLop.Text = tenLop.ToUpper();

			this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
			this.sqlDataSource1.Fill();
		}

		private void crossTab1_BeforePrint(object sender, CancelEventArgs e)
		{

			// Adjusts the generated cells.
			foreach (var c in crossTab1.ColumnDefinitions)
			{
				// Enables auto-width for all columns.
				c.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.GrowOnly;
			}

		}
	}
}
