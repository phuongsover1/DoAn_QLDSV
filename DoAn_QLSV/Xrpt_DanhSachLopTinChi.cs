using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV
{
	public partial class Xrpt_DanhSachLopTinChi : DevExpress.XtraReports.UI.XtraReport
	{
		public Xrpt_DanhSachLopTinChi()
		{
			InitializeComponent();
		}

		public Xrpt_DanhSachLopTinChi(int makhoa, string nienKhoa, string hocky)
		{
			InitializeComponent();
			xr_lblNienKhoa.Text = nienKhoa;
			xr_lblHocky.Text = hocky;
			string tenKhoa = makhoa == 0 ? "Công Nghệ Thông Tin" : "Viễn Thông";
			lblHeader.Text = "KHOA " + tenKhoa.ToUpper();
			//  this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
			this.sqlDataSource2.Queries[0].Parameters[0].Value = nienKhoa;
			this.sqlDataSource2.Queries[0].Parameters[1].Value = hocky;
			this.sqlDataSource2.Queries[0].Parameters[2].Value = makhoa == 0 ? "CNTT" : "VT";
			this.sqlDataSource1.Fill();


		}


	}
}
