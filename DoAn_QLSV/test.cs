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
	public partial class test : DevExpress.XtraEditors.XtraForm
	{
		public test()
		{
			InitializeComponent();
		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
            try
            {
                this.sP_LAY_DSSV_DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.SP_LAY_DSSV_DANGKY, new System.Nullable<int>(((int)(System.Convert.ChangeType(mALTCToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}