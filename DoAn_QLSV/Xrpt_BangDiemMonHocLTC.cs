using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV
{
	public partial class Xrpt_BangDiemMonHocLTC : DevExpress.XtraReports.UI.XtraReport
	{
		public Xrpt_BangDiemMonHocLTC()
		{
			InitializeComponent();
		}
		public Xrpt_BangDiemMonHocLTC(int maKhoa, string nienKhoa, string hocKi, string nhom, string maMH, string tenMH)
		{
			InitializeComponent();
			xrLblKhoa.Text = "KHOA " + (maKhoa == 0 ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG");
			xrLblNienKhoa.Text = "Niên khóa: " + nienKhoa;
			xrLblHocKi.Text = "Học kì:" + hocKi;
			xrLblMonHoc.Text = "Môn học: " + tenMH;
			xrLblNhom.Text = "Nhóm:" + nhom;

			this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
			this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKi;
			this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
			this.sqlDataSource1.Queries[0].Parameters[3].Value = maMH;
			this.sqlDataSource1.Queries[0].Parameters[4].Value = maKhoa == 0 ? "CNTT" : "VT";
			this.sqlDataSource1.Fill();
		}

	}
}
