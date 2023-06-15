namespace DoAn_QLSV
{
	partial class Xrpt_DiemTongKetCuoiKhoa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F);
			DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
			DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
			DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DiemTongKetCuoiKhoa));
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xr_lblKhoa1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xr_lblKhoa = new DevExpress.XtraReports.UI.XRLabel();
			this.xr_lblKhoaHoc = new DevExpress.XtraReports.UI.XRLabel();
			this.xr_lblKhoaHoc1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xr_lblLop = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.label1 = new DevExpress.XtraReports.UI.XRLabel();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
			this.xrCrossTabCell13 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.xrCrossTabCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.xrCrossTabCell15 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.xrCrossTabCell16 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.xrCrossTabCell22 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.crossTabGeneralStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.crossTabHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.crossTabDataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.crossTabTotalStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
						this.xr_lblKhoa1,
						this.xr_lblKhoa,
						this.xr_lblKhoaHoc,
						this.xr_lblKhoaHoc1,
						this.xr_lblLop,
						this.xrLabel1,
						this.label1});
			this.ReportHeader.HeightF = 114.388F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xr_lblKhoa1
			// 
			this.xr_lblKhoa1.LocationFloat = new DevExpress.Utils.PointFloat(139.7917F, 81.38803F);
			this.xr_lblKhoa1.Multiline = true;
			this.xr_lblKhoa1.Name = "xr_lblKhoa1";
			this.xr_lblKhoa1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xr_lblKhoa1.SizeF = new System.Drawing.SizeF(47.91667F, 23F);
			this.xr_lblKhoa1.Text = "KHOA:";
			// 
			// xr_lblKhoa
			// 
			this.xr_lblKhoa.LocationFloat = new DevExpress.Utils.PointFloat(187.7083F, 81.38803F);
			this.xr_lblKhoa.Multiline = true;
			this.xr_lblKhoa.Name = "xr_lblKhoa";
			this.xr_lblKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xr_lblKhoa.SizeF = new System.Drawing.SizeF(227.0834F, 23F);
			this.xr_lblKhoa.Text = "####";
			// 
			// xr_lblKhoaHoc
			// 
			this.xr_lblKhoaHoc.LocationFloat = new DevExpress.Utils.PointFloat(467.2918F, 40.42969F);
			this.xr_lblKhoaHoc.Multiline = true;
			this.xr_lblKhoaHoc.Name = "xr_lblKhoaHoc";
			this.xr_lblKhoaHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xr_lblKhoaHoc.SizeF = new System.Drawing.SizeF(188.5417F, 23F);
			this.xr_lblKhoaHoc.Text = "####";
			// 
			// xr_lblKhoaHoc1
			// 
			this.xr_lblKhoaHoc1.LocationFloat = new DevExpress.Utils.PointFloat(380.8333F, 40.42969F);
			this.xr_lblKhoaHoc1.Multiline = true;
			this.xr_lblKhoaHoc1.Name = "xr_lblKhoaHoc1";
			this.xr_lblKhoaHoc1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xr_lblKhoaHoc1.SizeF = new System.Drawing.SizeF(86.45834F, 23F);
			this.xr_lblKhoaHoc1.Text = " KHÓA HỌC:";
			// 
			// xr_lblLop
			// 
			this.xr_lblLop.LocationFloat = new DevExpress.Utils.PointFloat(86.45835F, 40.42969F);
			this.xr_lblLop.Multiline = true;
			this.xr_lblLop.Name = "xr_lblLop";
			this.xr_lblLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xr_lblLop.SizeF = new System.Drawing.SizeF(272.5F, 23F);
			this.xr_lblLop.Text = "####";
			// 
			// xrLabel1
			// 
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(47.91667F, 40.42969F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(38.54168F, 23F);
			this.xrLabel1.Text = "LỚP:";
			// 
			// label1
			// 
			this.label1.LocationFloat = new DevExpress.Utils.PointFloat(115.625F, 0F);
			this.label1.Name = "label1";
			this.label1.SizeF = new System.Drawing.SizeF(426.2659F, 30.01302F);
			this.label1.StyleName = "TitleStyle";
			this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
						this.crossTab1});
			this.Detail.Name = "Detail";
			this.Detail.StylePriority.UseTextAlignment = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// crossTab1
			// 
			this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
						this.xrCrossTabCell13,
						this.xrCrossTabCell14,
						this.xrCrossTabCell15,
						this.xrCrossTabCell16,
						this.xrCrossTabCell22,
						this.crossTabHeaderCell1});
			crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
			this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
						crossTabColumnDefinition1,
						new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F)});
			this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
			crossTabDataField1.FieldName = "Cấu trúc dữ liệu & Giải thuật";
			this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
						crossTabDataField1});
			this.crossTab1.DataMember = "SP_XRPT_DIEM_CUOI_KHOA";
			this.crossTab1.DataSource = this.sqlDataSource1;
			this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
			this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
			this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.crossTab1.Name = "crossTab1";
			crossTabRowDefinition1.Visible = false;
			this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
						new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
						new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
						crossTabRowDefinition1});
			crossTabRowField1.FieldName = "MASV_TENSV";
			this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
						crossTabRowField1});
			this.crossTab1.Scripts.OnBeforePrint = "crossTab1_BeforePrint";
			this.crossTab1.SizeF = new System.Drawing.SizeF(200F, 75F);
			this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
			this.crossTab1.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.crossTab1_BeforePrint);
			// 
			// xrCrossTabCell13
			// 
			this.xrCrossTabCell13.ColumnIndex = 1;
			this.xrCrossTabCell13.Name = "xrCrossTabCell13";
			this.xrCrossTabCell13.RowIndex = 1;
			// 
			// xrCrossTabCell14
			// 
			this.xrCrossTabCell14.ColumnIndex = 1;
			this.xrCrossTabCell14.Name = "xrCrossTabCell14";
			this.xrCrossTabCell14.RowIndex = 0;
			this.xrCrossTabCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrCrossTabCell15
			// 
			this.xrCrossTabCell15.ColumnIndex = 0;
			this.xrCrossTabCell15.Name = "xrCrossTabCell15";
			this.xrCrossTabCell15.RowIndex = 1;
			// 
			// xrCrossTabCell16
			// 
			this.xrCrossTabCell16.ColumnIndex = 0;
			this.xrCrossTabCell16.Name = "xrCrossTabCell16";
			this.xrCrossTabCell16.RowIndex = 2;
			this.xrCrossTabCell16.Text = "Grand Total";
			// 
			// xrCrossTabCell22
			// 
			this.xrCrossTabCell22.ColumnIndex = 1;
			this.xrCrossTabCell22.Name = "xrCrossTabCell22";
			this.xrCrossTabCell22.RowIndex = 2;
			// 
			// crossTabHeaderCell1
			// 
			this.crossTabHeaderCell1.ColumnIndex = 0;
			this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
			this.crossTabHeaderCell1.RowIndex = 0;
			this.crossTabHeaderCell1.Text = "MASV_TENSV";
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "localhost_QLDSV_TC_Connection11";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "SP_XRPT_DIEM_CUOI_KHOA";
			queryParameter1.Name = "@MALOP";
			queryParameter1.Type = typeof(string);
			queryParameter1.ValueInfo = "D19CQCN01";
			storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
						queryParameter1});
			storedProcQuery1.StoredProcName = "SP_XRPT_DIEM_CUOI_KHOA";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
						storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// TopMargin
			// 
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Name = "BottomMargin";
			// 
			// TitleStyle
			// 
			this.TitleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 18F);
			this.TitleStyle.Name = "TitleStyle";
			this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			// 
			// crossTabGeneralStyle
			// 
			this.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
			this.crossTabGeneralStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
						| DevExpress.XtraPrinting.BorderSide.Right)
						| DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.crossTabGeneralStyle.BorderWidth = 1F;
			this.crossTabGeneralStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
			this.crossTabGeneralStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// crossTabHeaderStyle
			// 
			this.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
			this.crossTabHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
			this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
			this.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// crossTabDataStyle
			// 
			this.crossTabDataStyle.Name = "crossTabDataStyle";
			this.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// crossTabTotalStyle
			// 
			this.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.crossTabTotalStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
			this.crossTabTotalStyle.Name = "crossTabTotalStyle";
			this.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// Xrpt_DiemTongKetCuoiKhoa
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
						this.ReportHeader,
						this.Detail,
						this.TopMargin,
						this.BottomMargin});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
						this.sqlDataSource1});
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
			this.Landscape = true;
			this.PageHeight = 1169;
			this.PageWidth = 1654;
			this.PaperKind = System.Drawing.Printing.PaperKind.A3;
			this.ScriptsSource = "\r\nprivate void crossTab1_BeforePrint(object sender, System.ComponentModel.CancelE" +
		"ventArgs e) {\r\n    \r\n}\r\n";
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
						this.TitleStyle,
						this.crossTabGeneralStyle,
						this.crossTabHeaderStyle,
						this.crossTabDataStyle,
						this.crossTabTotalStyle});
			this.Version = "22.2";
			this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
			((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel label1;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell13;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell14;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell15;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell16;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell22;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
		private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle;
		private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle;
		private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle;
		private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle;
		private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xr_lblLop;
		private DevExpress.XtraReports.UI.XRLabel xr_lblKhoaHoc;
		private DevExpress.XtraReports.UI.XRLabel xr_lblKhoaHoc1;
		private DevExpress.XtraReports.UI.XRLabel xr_lblKhoa1;
		private DevExpress.XtraReports.UI.XRLabel xr_lblKhoa;
	}
}
