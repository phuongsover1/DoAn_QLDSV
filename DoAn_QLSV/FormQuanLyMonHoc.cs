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
    public partial class FormQuanLyMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public FormQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            QLDSV_TCEntities_SV1 db = new QLDSV_TCEntities_SV1();
            mONHOCBindingSource.DataSource = db.MONHOCs.ToList();
        }
    }
}
