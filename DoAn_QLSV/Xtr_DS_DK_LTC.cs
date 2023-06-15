using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DoAn_QLSV.report
{
    public partial class Xtr_DS_DK_LTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtr_DS_DK_LTC(string nk, int hk, string tenmh, int nhom, String khoa)
        {
            String svname;
            if (khoa == "CNTT")
                svname = Program.servername1;
            else
                svname = Program.servername2;
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "Data Source="
                    + svname
                    + ";Initial Catalog="
                    + Program.database
                    + ";User ID=sa"
                    + ";password=1234";
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hk;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = tenmh;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;



            this.sqlDataSource1.Fill();
        }

    }
}
