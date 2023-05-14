using DevExpress.XtraEditors;
using DoAn_QLSV;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
	public partial class frmDangKiLTC : DevExpress.XtraEditors.XtraForm
	{

		private SqlConnection connPublisher = new SqlConnection();
		public frmDangKiLTC()
		{
			InitializeComponent();
		}

		private void FormNhanVien_Load(object sender, EventArgs e)
		{


		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.DanhSachLTCDangKiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_DSLTCCoTheDangKi, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillToolStripButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				lamMoi();

				//this.DanhSachLTCDangKiTableAdapter.Connection.ConnectionString = Program.connstr;
				//this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Connection.ConnectionString = Program.connstr;
				//this.DanhSachLTCDangKiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_DSLTCCoTheDangKi, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
				//this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ltc_sv_dangki_trong_ki_nay, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))), Program.userName);

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void btnDangKyLTC_Click_1(object sender, EventArgs e)
		{
			DataRowView drv;
			//bool check = ValidateInfoMONHOC();
			//if (check)
			//{
			drv = ((DataRowView)sp_DSLTCCoTheDangKiBindingSource[sp_DSLTCCoTheDangKiBindingSource.Position]);
			DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dr == DialogResult.OK)
			{

				try
				{
					String statement = "EXEC dangky_ltc @MALTC =" + drv["MALTC"] + ", @MASV = '" + Program.username + "'";
					Program.ExecSqlNonQuery(statement, Program.connstr);
					this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ltc_sv_dangki_trong_ki_nay, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))), Program.username);
					this.sp_DSLTCCoTheDangKiBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
					this.sp_ltc_sv_dangki_trong_ki_nayBindingSource.ResetCurrentItem();

					lamMoi();
				}

				catch (Exception ex)
				{
					//sp_DSLTCCoTheDangKiBindingSource.RemoveCurrent();
					XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// }
			//else
			//{
			//  return;
			// }
		}



		private void btnLamMoi_Click(object sender, EventArgs e)
		{

			this.sp_DSLTCCoTheDangKiBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
			this.sp_ltc_sv_dangki_trong_ki_nayBindingSource.ResetCurrentItem();
		}

		private void lamMoi()
		{
			this.DanhSachLTCDangKiTableAdapter.Connection.ConnectionString = Program.connstr;
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Connection.ConnectionString = Program.connstr;
			this.DanhSachLTCDangKiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_DSLTCCoTheDangKi, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ltc_sv_dangki_trong_ki_nay, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))), Program.username);

		}

		private void fillToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				this.sP_LAY_DSSV_DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.SP_LAY_DSSV_DANGKY, new System.Nullable<int>(((int)(System.Convert.ChangeType(mALTCToolStripTextBox.Text, typeof(int))))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillToolStripButton1_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.sP_LAY_DSSV_DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.SP_LAY_DSSV_DANGKY, new System.Nullable<int>(((int)(System.Convert.ChangeType(mALTCToolStripTextBox.Text, typeof(int))))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}

}