using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraEditors;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DoAn_QLSV
{
	public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.IsMdiContainer = true;
			ResetForm();
		}

		public void ResetForm()
		{
			ribGroupTaoTaiKhoan.Visible = false;
			ribGroupLogout.Visible = false;
			lbHoTen.Text = lbMaNV.Text = lbNhom.Text = "";
			ribDanhMuc.Visible = false;
			ribGroupDangNhap.Visible = true;
			Program.servername = "";
			Program.username = "";
			Program.password = "";
		}

		private XtraForm CheckExists(Type ftype)
		{
			foreach (XtraForm f in this.MdiChildren)
				if (f.GetType() == ftype)
					return f;
			return null;
		}

		private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			XtraForm form = CheckExists(typeof(FormDangNhap));
			if (form != null)
			{
				form.Activate();
				return;
			}
			FormDangNhap formDangNhap = new FormDangNhap();
			formDangNhap.MdiParent = this;
			formDangNhap.Show();
		}

		private void btnTaoTaiKhoan_ItemClick(
				object sender,
				DevExpress.XtraBars.ItemClickEventArgs e
		)
		{
			XtraForm form = CheckExists(typeof(FormTaoTaiKhoan));
			if (form != null)
			{
				form.Activate();
				return;
			}
			FormTaoTaiKhoan formTaoTaiKhoan = new FormTaoTaiKhoan();
			formTaoTaiKhoan.MdiParent = this;
			formTaoTaiKhoan.Show();
		}

		private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			XtraForm form = CheckExists(typeof(FormQuanLyLop));
			if (form != null)
			{
				form.Activate();
				return;
			}
			FormQuanLyLop formQuanLyLop = new FormQuanLyLop();
			formQuanLyLop.MdiParent = this;
			formQuanLyLop.Show();
		}

		private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ResetForm();
			closeAllForm();
			ribGroupDangNhap.Visible = true;
			FormDangNhap formDangNhap = new FormDangNhap();
			formDangNhap.MdiParent = this;
			formDangNhap.Show();
		}

		public void closeAllForm()
		{
			foreach (XtraForm f in this.MdiChildren)
			{
				f.Close();
			}
		}

		private void ribbonControl1_Click(object sender, EventArgs e) { }

		private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			XtraForm form = CheckExists(typeof(FormQuanLyMonHoc));
			if (form != null)
			{
				form.Activate();
				return;
			}

			form = new FormQuanLyMonHoc();
			form.MdiParent = this;
			form.Show();
		}

		private void btnLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			XtraForm form = CheckExists(typeof(FormQuanLyLopTinChi));
			if (form != null)
			{
				form.Activate();
				return;
			}
			form = new FormQuanLyLopTinChi();
			form.MdiParent = this;
			form.Show();

		}
	}
}
