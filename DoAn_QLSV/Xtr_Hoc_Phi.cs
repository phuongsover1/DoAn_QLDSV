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
			this.sqlDataSource1.Connection.ConnectionString = "Data Source="
							+ Program.servername3
							+ ";Initial Catalog="
							+ Program.database
							+ ";User ID=sa"
							+ ";password=1234";
			this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
			this.sqlDataSource1.Queries[0].Parameters[1].Value = nk;
			this.sqlDataSource1.Queries[0].Parameters[2].Value = hk;

			this.sqlDataSource1.Fill();
		}

	}
}
