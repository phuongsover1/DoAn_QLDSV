﻿namespace DoAn_QLSV
{
	partial class Xrpt_PhieuDiem
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
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_PhieuDiem));
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.label1 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.table1 = new DevExpress.XtraReports.UI.XRTable();
			this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.table2 = new DevExpress.XtraReports.UI.XRTable();
			this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.lblKhoa = new DevExpress.XtraReports.UI.XRLabel();
			this.lblLop = new DevExpress.XtraReports.UI.XRLabel();
			this.lblMaSV = new DevExpress.XtraReports.UI.XRLabel();
			this.lblTenSV = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
			this.BottomMargin.Name = "BottomMargin";
			// 
			// pageInfo1
			// 
			this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.pageInfo1.Name = "pageInfo1";
			this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.pageInfo1.SizeF = new System.Drawing.SizeF(325F, 23F);
			this.pageInfo1.StyleName = "PageInfo";
			// 
			// pageInfo2
			// 
			this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
			this.pageInfo2.Name = "pageInfo2";
			this.pageInfo2.SizeF = new System.Drawing.SizeF(325F, 23F);
			this.pageInfo2.StyleName = "PageInfo";
			this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.pageInfo2.TextFormatString = "Page {0} of {1}";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTenSV,
            this.lblMaSV,
            this.lblLop,
            this.lblKhoa,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.label1});
			this.ReportHeader.HeightF = 125.625F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel3
			// 
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(85.00001F, 40.12502F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(46.875F, 23F);
			this.xrLabel3.Text = "Khoa:";
			// 
			// xrLabel2
			// 
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(337.7083F, 80.12502F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(114.5833F, 23F);
			this.xrLabel2.Text = "Họ Tên Sinh Viên:";
			// 
			// xrLabel1
			// 
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(85.00001F, 80.12502F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(89.5833F, 23F);
			this.xrLabel1.Text = "Mã Sinh Viên:";
			// 
			// label1
			// 
			this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.label1.Name = "label1";
			this.label1.SizeF = new System.Drawing.SizeF(650F, 24.19433F);
			this.label1.StyleName = "Title";
			this.label1.StylePriority.UseTextAlignment = false;
			this.label1.Text = "PHIẾU ĐIỂM";
			this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
			this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.GroupHeader1.HeightF = 28F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// table1
			// 
			this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.table1.Name = "table1";
			this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
			this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
			// 
			// tableRow1
			// 
			this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.tableCell1,
            this.tableCell2});
			this.tableRow1.Name = "tableRow1";
			this.tableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.BorderColor = System.Drawing.Color.White;
			this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StyleName = "DetailCaption1";
			this.xrTableCell1.StylePriority.UseBorderColor = false;
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.StylePriority.UseTextAlignment = false;
			this.xrTableCell1.Text = "STT";
			this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell1.Weight = 0.20526836413065322D;
			// 
			// tableCell1
			// 
			this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.tableCell1.Name = "tableCell1";
			this.tableCell1.StyleName = "DetailCaption1";
			this.tableCell1.StylePriority.UseBorders = false;
			this.tableCell1.StylePriority.UseTextAlignment = false;
			this.tableCell1.Text = "Tên Môn Học";
			this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.tableCell1.Weight = 0.96625889911768492D;
			// 
			// tableCell2
			// 
			this.tableCell2.Name = "tableCell2";
			this.tableCell2.StyleName = "DetailCaption1";
			this.tableCell2.StylePriority.UseTextAlignment = false;
			this.tableCell2.Text = "Điểm";
			this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.tableCell2.Weight = 0.20089512820298394D;
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			// 
			// table2
			// 
			this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.table2.Name = "table2";
			this.table2.OddStyleName = "DetailData3_Odd";
			this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
			this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
			// 
			// tableRow2
			// 
			this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.tableCell3,
            this.tableCell4});
			this.tableRow2.Name = "tableRow2";
			this.tableRow2.Weight = 11.5D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.BorderColor = System.Drawing.Color.White;
			this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.StyleName = "DetailData1";
			this.xrTableCell2.StylePriority.UseBorderColor = false;
			this.xrTableCell2.StylePriority.UseBorders = false;
			this.xrTableCell2.StylePriority.UseTextAlignment = false;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell2.Summary = xrSummary1;
			this.xrTableCell2.Text = "xrTableCell2";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell2.Weight = 0.20526836413065322D;
			// 
			// tableCell3
			// 
			this.tableCell3.BorderColor = System.Drawing.Color.White;
			this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.tableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENMH]")});
			this.tableCell3.Name = "tableCell3";
			this.tableCell3.StyleName = "DetailData1";
			this.tableCell3.StylePriority.UseBorderColor = false;
			this.tableCell3.StylePriority.UseBorders = false;
			this.tableCell3.StylePriority.UseTextAlignment = false;
			this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.tableCell3.Weight = 0.9662589313353831D;
			// 
			// tableCell4
			// 
			this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DIEMHETMON]")});
			this.tableCell4.Name = "tableCell4";
			this.tableCell4.StyleName = "DetailData1";
			this.tableCell4.StylePriority.UseTextAlignment = false;
			this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.tableCell4.Weight = 0.20089509598528582D;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "localhost_QLDSV_TC_Connection11";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "SP_XRPT_PHIEU_DIEM";
			queryParameter1.Name = "@MASV";
			queryParameter1.Type = typeof(string);
			queryParameter1.ValueInfo = "N19DCCN147";
			storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
			storedProcQuery1.StoredProcName = "SP_XRPT_PHIEU_DIEM";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
			this.Title.Name = "Title";
			this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// DetailCaption1
			// 
			this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
			this.DetailCaption1.BorderColor = System.Drawing.Color.White;
			this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailCaption1.BorderWidth = 2F;
			this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.DetailCaption1.ForeColor = System.Drawing.Color.White;
			this.DetailCaption1.Name = "DetailCaption1";
			this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData1
			// 
			this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailData1.BorderWidth = 2F;
			this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData1.ForeColor = System.Drawing.Color.Black;
			this.DetailData1.Name = "DetailData1";
			this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3_Odd
			// 
			this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
			this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailData3_Odd.BorderWidth = 1F;
			this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
			this.DetailData3_Odd.Name = "DetailData3_Odd";
			this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// xrLabel4
			// 
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(337.7083F, 40.12502F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(34.37503F, 23F);
			this.xrLabel4.Text = "Lớp:";
			// 
			// lblKhoa
			// 
			this.lblKhoa.LocationFloat = new DevExpress.Utils.PointFloat(131.875F, 40.12502F);
			this.lblKhoa.Multiline = true;
			this.lblKhoa.Name = "lblKhoa";
			this.lblKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.lblKhoa.SizeF = new System.Drawing.SizeF(193.125F, 23F);
			this.lblKhoa.Text = "####";
			// 
			// lblLop
			// 
			this.lblLop.LocationFloat = new DevExpress.Utils.PointFloat(372.0833F, 40.12502F);
			this.lblLop.Multiline = true;
			this.lblLop.Name = "lblLop";
			this.lblLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblLop.SizeF = new System.Drawing.SizeF(151.0416F, 23F);
			this.lblLop.Text = "#####";
			// 
			// lblMaSV
			// 
			this.lblMaSV.LocationFloat = new DevExpress.Utils.PointFloat(174.5833F, 80.12502F);
			this.lblMaSV.Multiline = true;
			this.lblMaSV.Name = "lblMaSV";
			this.lblMaSV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblMaSV.SizeF = new System.Drawing.SizeF(150.4167F, 23F);
			this.lblMaSV.Text = "#####";
			// 
			// lblTenSV
			// 
			this.lblTenSV.LocationFloat = new DevExpress.Utils.PointFloat(452.2916F, 80.12502F);
			this.lblTenSV.Multiline = true;
			this.lblTenSV.Name = "lblTenSV";
			this.lblTenSV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblTenSV.SizeF = new System.Drawing.SizeF(151.0416F, 23F);
			this.lblTenSV.Text = "#####";
			// 
			// Xrpt_PhieuDiem
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "SP_XRPT_PHIEU_DIEM";
			this.DataSource = this.sqlDataSource1;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
			this.Version = "22.2";
			((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
		private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel label1;
		private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		private DevExpress.XtraReports.UI.XRTable table1;
		private DevExpress.XtraReports.UI.XRTableRow tableRow1;
		private DevExpress.XtraReports.UI.XRTableCell tableCell1;
		private DevExpress.XtraReports.UI.XRTableCell tableCell2;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRTable table2;
		private DevExpress.XtraReports.UI.XRTableRow tableRow2;
		private DevExpress.XtraReports.UI.XRTableCell tableCell3;
		private DevExpress.XtraReports.UI.XRTableCell tableCell4;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.UI.XRControlStyle Title;
		private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
		private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel lblLop;
		private DevExpress.XtraReports.UI.XRLabel lblKhoa;
		private DevExpress.XtraReports.UI.XRLabel lblMaSV;
		private DevExpress.XtraReports.UI.XRLabel lblTenSV;
	}
}
