using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV
{
	public partial class Xrpt_PhieuDiem : DevExpress.XtraReports.UI.XtraReport
	{
		public Xrpt_PhieuDiem()
		{
			InitializeComponent();
		}


		public Xrpt_PhieuDiem(int cmbKhoaIndex, string maLop, string maSV, string tenSV)
		{
			InitializeComponent();
			lblKhoa.Text = cmbKhoaIndex == 0 ? "Công Nghệ Thông Tin" : "Viễn Thông";
			lblLop.Text = maLop;
			lblMaSV.Text = maSV;
			lblTenSV.Text = tenSV;
			this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
			this.sqlDataSource1.Fill();

		}

	}
}
