using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLSV
{
  public partial class FormHocPhi : DevExpress.XtraEditors.XtraForm
  {
    DataRowView drv;
    String connstr = Program.createConnectionString(
          Program.servername3,
          Program.remoteLogin,
          Program.remotePassword
      ); 
    public FormHocPhi()
    {
      InitializeComponent();

    }

    private SqlConnection connPublisher = new SqlConnection();


    private void fillToolStripButton_Click(object sender, EventArgs e)
    {

      try
      {
        lamMoiHocPhi();
        txtNienKhoa1.Enabled = true;
        txtHocKy1.Enabled = true;
        txtHocPhi.Enabled = true;
        btnThem.Enabled = true;
      }
      catch (System.Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.Message);
      }

    }



    private void sp_ds_hoc_phiGridControl_Click(object sender, EventArgs e)
    {

      lamMoiChiTietHocPhi();

      txtSTD.Enabled = true;
      dteNgay.Enabled = true;
      btnDong.Enabled = true;

    }


    private void btnDong_Click(object sender, EventArgs e)
    {

      dteNgay.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
      String statement = "INSERT INTO [dbo].[CT_DONGHOCPHI]([MASV],[NIENKHOA],[HOCKY],[NGAYDONG],[SOTIENDONG]) VALUES('" +
       masvToolStripTextBox.Text + "','" + txtNienKhoa.Text + "','" + txtHocKy.Text + "','" + dteNgay.DateTime.ToString("yyyy/MM/dd") + "','" + txtSTD.Text + "')";
      Program.ExecSqlNonQuery(statement, Program.connstr);
      this.sp_ds_hoc_phiBindingSource.ResetCurrentItem();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      
      String statement = "INSERT INTO [dbo].[HOCPHI]([MASV],[NIENKHOA],[HOCKY],[HOCPHI]) VALUES('" +
       masvToolStripTextBox.Text + "','" + txtNienKhoa1.Text + "','" + txtHocKy1.Text + "','" + txtHocPhi.Text + "')";
      Program.ExecSqlNonQuery(statement, connstr);
      this.sp_ds_hoc_phiBindingSource.ResetBindings(false);
      lamMoiHocPhi();
    }

    private void sp_ds_hoc_phiGridControl_Click_1(object sender, EventArgs e)
    {
      this.sp_ds_ct_hoc_phiTableAdapter.Connection.ConnectionString = connstr;
      //DataRowView drv;
      drv = ((DataRowView)sp_ds_hoc_phiBindingSource[sp_ds_hoc_phiBindingSource.Position]);

      this.sp_ds_ct_hoc_phiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ds_ct_hoc_phi, masvToolStripTextBox.Text, drv["NIENKHOA"].ToString(), Convert.ToInt32(drv["HOCKY"]));

      this.txtNienKhoa.Text = drv["NIENKHOA"].ToString();
      //this.txtNienKhoa1.Text = drv["NIENKHOA"].ToString();
      this.txtHocKy.Text = drv["HOCKY"].ToString();
      //this.txtHocKy1.Text = drv["HOCKY"].ToString();

      txtSTD.Enabled = true;
      dteNgay.Enabled = true;
      btnDong.Enabled = true;
    }

    private void lamMoiHocPhi()
    {
      this.sp_ds_hoc_phiTableAdapter.Connection.ConnectionString = connstr;
      this.sp_ds_hoc_phiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ds_hoc_phi, masvToolStripTextBox.Text);
    }
    private void lamMoiChiTietHocPhi()
    {
      this.sp_ds_ct_hoc_phiTableAdapter.Connection.ConnectionString = connstr;
      DataRowView drv;
      drv = ((DataRowView)sp_ds_hoc_phiBindingSource[sp_ds_hoc_phiBindingSource.Position]);
      this.txtNienKhoa.Text = drv["NIENKHOA"].ToString();
      this.txtHocKy.Text = drv["HOCKY"].ToString();
      this.sp_ds_ct_hoc_phiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ds_ct_hoc_phi, masvToolStripTextBox.Text, drv["NIENKHOA"].ToString(), Convert.ToInt32(drv["HOCKY"]));

    }

    private void btnDong_Click_1(object sender, EventArgs e)
    {
      if (Convert.ToInt32(txtSTD.Text) < Convert.ToInt32(drv["CONLAI"]))
      {
        dteNgay.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
        String statement = "INSERT INTO [dbo].[CT_DONGHOCPHI]([MASV],[NIENKHOA],[HOCKY],[NGAYDONG],[SOTIENDONG]) VALUES('" +
         masvToolStripTextBox.Text + "','" + txtNienKhoa.Text + "','" + txtHocKy.Text + "','" + dteNgay.DateTime.ToString("yyyy/MM/dd") + "','" + txtSTD.Text + "')";
        Program.ExecSqlNonQuery(statement, connstr);
        this.sp_ds_hoc_phiBindingSource.ResetCurrentItem();
        lamMoiChiTietHocPhi();
      }
      else
      {
        XtraMessageBox.Show(
                "Số tiền đóng không được vượt quá học phí",
                "",
                MessageBoxButtons.OK
        );
      }

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      lamMoiHocPhi();
      lamMoiChiTietHocPhi();
    }

    private void txtNienKhoa_EditValueChanged(object sender, EventArgs e)
    {

    }
  }
}