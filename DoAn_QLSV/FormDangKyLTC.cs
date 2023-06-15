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
	public partial class FormDangKyLTC : DevExpress.XtraEditors.XtraForm
	{
		DataRowView drv_Huy_DK;
		public FormDangKyLTC()
		{
			InitializeComponent();
		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				String statement = "EXEC sp_sv_dang_nhap @MSV =" + TSMaSV.Text + ", @MK= '" + TSMatKhau.Text + "'";
				if (Program.ExecSqlQuery(statement, Program.connstr).Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show("Sai mật khẩu hoặc tài khoản");

				}
				else
				{
					lamMoi();
				}

				//this.sp_DSLTCCoTheDangKiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_DSLTCCoTheDangKi, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private SqlConnection connPublisher = new SqlConnection();


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

			this.sp_DSLTCCoTheDangKiTableAdapter.Connection.ConnectionString = Program.connstr;
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Connection.ConnectionString = Program.connstr;
			this.sp_DSLTCCoTheDangKiTableAdapter.Fill(this.qLDSV_TCDataSet.sp_DSLTCCoTheDangKi, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
			this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ltc_sv_dangki_trong_ki_nay, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))), TSMaSV.Text);

		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{

		}

		private void nKToolStripTextBox_Click(object sender, EventArgs e)
		{

		}

		private void sp_DSLTCCoTheDangKiGridControl_Click(object sender, EventArgs e)
		{

		}

		private void simpleButton1_Click(object sender, EventArgs e)
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
					String statement = "EXEC dangky_ltc @MALTC =" + drv["MALTC"] + ", @MASV = '" + TSMaSV.Text + "',@MAMH ='" + drv["MAMH"] + "'";
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

		private void btnHuy_Click(object sender, EventArgs e)
		{

			//bool check = ValidateInfoMONHOC();
			//if (check)
			//{
			//drv_Huy_DK = ((DataRowView)sp_DSLTCCoTheDangKiBindingSource[sp_DSLTCCoTheDangKiBindingSource.Position]);
			DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn Hủy đăng ký?", "Thông báo",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dr == DialogResult.OK)
			{

				try
				{
					String statement = "EXEC sp_huy_dkltc @MALTC =" + drv_Huy_DK["MALTC"] + ", @MASV = '" + TSMaSV.Text + "'";
					Program.ExecSqlNonQuery(statement, Program.connstr);
					this.sp_ltc_sv_dangki_trong_ki_nayTableAdapter.Fill(this.qLDSV_TCDataSet.sp_ltc_sv_dangki_trong_ki_nay, nKToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))), Program.username);
					this.sp_DSLTCCoTheDangKiBindingSource.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
					this.sp_ltc_sv_dangki_trong_ki_nayBindingSource.ResetCurrentItem();

					lamMoi();
				}

				catch (Exception ex)
				{
					//sp_DSLTCCoTheDangKiBindingSource.RemoveCurrent();
					XtraMessageBox.Show("Hủy đăng ký thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void sp_ltc_sv_dangki_trong_ki_nayGridControl_Click(object sender, EventArgs e)
		{
			btnHuy.Enabled = true;

			drv_Huy_DK = ((DataRowView)sp_ltc_sv_dangki_trong_ki_nayBindingSource[sp_ltc_sv_dangki_trong_ki_nayBindingSource.Position]);
			this.txtMaLTC.Text = drv_Huy_DK["MALTC"].ToString();
			this.txtTenMH.Text = drv_Huy_DK["TENMH"].ToString();
			this.txtNhom.Text = drv_Huy_DK["NHOM"].ToString();
		}
	}


}