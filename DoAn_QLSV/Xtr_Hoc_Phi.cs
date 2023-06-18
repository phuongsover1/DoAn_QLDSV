using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV.report
{
	public partial class Xtr_Hoc_Phi : DevExpress.XtraReports.UI.XtraReport
	{
		public Xtr_Hoc_Phi(string maLop, string nk, int hk)
		{
			InitializeComponent();

			this.sqlDataSource2.Queries[0].Parameters[0].Value = maLop;
			this.sqlDataSource2.Queries[0].Parameters[1].Value = nk;
			this.sqlDataSource2.Queries[0].Parameters[2].Value = hk;

			this.sqlDataSource2.Fill();
		}

	}
}
