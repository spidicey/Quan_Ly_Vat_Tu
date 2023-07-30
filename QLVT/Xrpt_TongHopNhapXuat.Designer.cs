namespace QLVT
{
    partial class Xrpt_TongHopNhapXuat
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_TongHopNhapXuat));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pnlThongTinBaoCao = new DevExpress.XtraReports.UI.XRPanel();
            this.lblNgayKetThuc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNgayBatDau = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDenNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTuNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTieuDeBaoCao = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TableContent = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableValueNGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueNHAP = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTYLENHAP = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueXUAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTYLEXUAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableCellNGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellNHAP = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTYLENHAP = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellXUAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTYLEXUAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TYLENHAP = new DevExpress.XtraReports.UI.CalculatedField();
            this.TYLEXUAT = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.TableFooter = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableFooterTieuDe = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTONGNHAP = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueEmpty1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTONGXUAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueEmpty2 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.TableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfoNumber,
            this.pageInfoDate});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfoNumber
            // 
            this.pageInfoNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageInfoNumber.Font = new DevExpress.Drawing.DXFont("Cambria", 10F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.pageInfoNumber.LocationFloat = new DevExpress.Utils.PointFloat(324.9999F, 0F);
            this.pageInfoNumber.Name = "pageInfoNumber";
            this.pageInfoNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.pageInfoNumber.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfoNumber.StyleName = "PageInfo";
            this.pageInfoNumber.StylePriority.UseBackColor = false;
            this.pageInfoNumber.StylePriority.UseFont = false;
            this.pageInfoNumber.StylePriority.UsePadding = false;
            this.pageInfoNumber.StylePriority.UseTextAlignment = false;
            this.pageInfoNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pageInfoNumber.TextFormatString = "Page {0} / {1}";
            // 
            // pageInfoDate
            // 
            this.pageInfoDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageInfoDate.Font = new DevExpress.Drawing.DXFont("Cambria", 10F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.pageInfoDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfoDate.Name = "pageInfoDate";
            this.pageInfoDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.pageInfoDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoDate.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfoDate.StyleName = "PageInfo";
            this.pageInfoDate.StylePriority.UseBackColor = false;
            this.pageInfoDate.StylePriority.UseFont = false;
            this.pageInfoDate.StylePriority.UsePadding = false;
            this.pageInfoDate.StylePriority.UseTextAlignment = false;
            this.pageInfoDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.pageInfoDate.TextFormatString = "{0:dddd, dd/MM/yyyy}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.BackColor = System.Drawing.Color.Transparent;
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pnlThongTinBaoCao,
            this.lblTieuDeBaoCao});
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBackColor = false;
            // 
            // pnlThongTinBaoCao
            // 
            this.pnlThongTinBaoCao.BackColor = System.Drawing.Color.White;
            this.pnlThongTinBaoCao.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNgayKetThuc,
            this.lblNgayBatDau,
            this.lblDenNgay,
            this.lblTuNgay});
            this.pnlThongTinBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(2.543131E-05F, 45F);
            this.pnlThongTinBaoCao.Name = "pnlThongTinBaoCao";
            this.pnlThongTinBaoCao.SizeF = new System.Drawing.SizeF(650F, 55F);
            this.pnlThongTinBaoCao.StylePriority.UseBackColor = false;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lblNgayKetThuc.LocationFloat = new DevExpress.Utils.PointFloat(418F, 0F);
            this.lblNgayKetThuc.Multiline = true;
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.lblNgayKetThuc.SizeF = new System.Drawing.SizeF(100F, 34.99999F);
            this.lblNgayKetThuc.StylePriority.UseFont = false;
            this.lblNgayKetThuc.StylePriority.UsePadding = false;
            this.lblNgayKetThuc.StylePriority.UseTextAlignment = false;
            this.lblNgayKetThuc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lblNgayBatDau.LocationFloat = new DevExpress.Utils.PointFloat(207F, 0F);
            this.lblNgayBatDau.Multiline = true;
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.lblNgayBatDau.SizeF = new System.Drawing.SizeF(100F, 34.99999F);
            this.lblNgayBatDau.StylePriority.UseFont = false;
            this.lblNgayBatDau.StylePriority.UsePadding = false;
            this.lblNgayBatDau.StylePriority.UseTextAlignment = false;
            this.lblNgayBatDau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lblDenNgay.LocationFloat = new DevExpress.Utils.PointFloat(343F, 0F);
            this.lblDenNgay.Multiline = true;
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.lblDenNgay.SizeF = new System.Drawing.SizeF(75F, 35F);
            this.lblDenNgay.StylePriority.UseFont = false;
            this.lblDenNgay.StylePriority.UsePadding = false;
            this.lblDenNgay.StylePriority.UseTextAlignment = false;
            this.lblDenNgay.Text = "Đến ngày:";
            this.lblDenNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lblTuNgay.LocationFloat = new DevExpress.Utils.PointFloat(132F, 0F);
            this.lblTuNgay.Multiline = true;
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.lblTuNgay.SizeF = new System.Drawing.SizeF(75F, 35F);
            this.lblTuNgay.StylePriority.UseFont = false;
            this.lblTuNgay.StylePriority.UsePadding = false;
            this.lblTuNgay.StylePriority.UseTextAlignment = false;
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTieuDeBaoCao
            // 
            this.lblTieuDeBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTieuDeBaoCao.Font = new DevExpress.Drawing.DXFont("Cambria", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTieuDeBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTieuDeBaoCao.Name = "lblTieuDeBaoCao";
            this.lblTieuDeBaoCao.SizeF = new System.Drawing.SizeF(650F, 45F);
            this.lblTieuDeBaoCao.StyleName = "Title";
            this.lblTieuDeBaoCao.StylePriority.UseBackColor = false;
            this.lblTieuDeBaoCao.StylePriority.UseFont = false;
            this.lblTieuDeBaoCao.StylePriority.UseTextAlignment = false;
            this.lblTieuDeBaoCao.Text = "BẢNG TỔNG HỢP NHẬP XUẤT";
            this.lblTieuDeBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableContent});
            this.Detail.HeightF = 35F;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NGAY", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            // 
            // TableContent
            // 
            this.TableContent.BackColor = System.Drawing.Color.White;
            this.TableContent.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableContent.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableContent.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableContent.Name = "TableContent";
            this.TableContent.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableContent.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.TableContent.SizeF = new System.Drawing.SizeF(650F, 35F);
            this.TableContent.StylePriority.UseBackColor = false;
            this.TableContent.StylePriority.UseBorders = false;
            this.TableContent.StylePriority.UseFont = false;
            this.TableContent.StylePriority.UsePadding = false;
            this.TableContent.StylePriority.UseTextAlignment = false;
            this.TableContent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableValueNGAY,
            this.TableValueNHAP,
            this.TableValueTYLENHAP,
            this.TableValueXUAT,
            this.TableValueTYLEXUAT});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // TableValueNGAY
            // 
            this.TableValueNGAY.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueNGAY.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY]")});
            this.TableValueNGAY.Multiline = true;
            this.TableValueNGAY.Name = "TableValueNGAY";
            this.TableValueNGAY.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueNGAY.StylePriority.UseBorders = false;
            this.TableValueNGAY.StylePriority.UsePadding = false;
            this.TableValueNGAY.TextFormatString = "{0:dd/MM/yyyy}";
            this.TableValueNGAY.Weight = 1D;
            // 
            // TableValueNHAP
            // 
            this.TableValueNHAP.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueNHAP.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NHAP]")});
            this.TableValueNHAP.Multiline = true;
            this.TableValueNHAP.Name = "TableValueNHAP";
            this.TableValueNHAP.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueNHAP.StylePriority.UseBorders = false;
            this.TableValueNHAP.StylePriority.UsePadding = false;
            this.TableValueNHAP.StylePriority.UseTextAlignment = false;
            this.TableValueNHAP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueNHAP.TextFormatString = "{0:N0}";
            this.TableValueNHAP.Weight = 1D;
            // 
            // TableValueTYLENHAP
            // 
            this.TableValueTYLENHAP.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTYLENHAP.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TYLENHAP]")});
            this.TableValueTYLENHAP.Multiline = true;
            this.TableValueTYLENHAP.Name = "TableValueTYLENHAP";
            this.TableValueTYLENHAP.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTYLENHAP.StylePriority.UseBorders = false;
            this.TableValueTYLENHAP.StylePriority.UsePadding = false;
            this.TableValueTYLENHAP.StylePriority.UseTextAlignment = false;
            this.TableValueTYLENHAP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableValueTYLENHAP.TextFormatString = "{0:0.00%}";
            this.TableValueTYLENHAP.Weight = 1D;
            // 
            // TableValueXUAT
            // 
            this.TableValueXUAT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueXUAT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[XUAT]")});
            this.TableValueXUAT.Multiline = true;
            this.TableValueXUAT.Name = "TableValueXUAT";
            this.TableValueXUAT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueXUAT.StylePriority.UseBorders = false;
            this.TableValueXUAT.StylePriority.UsePadding = false;
            this.TableValueXUAT.StylePriority.UseTextAlignment = false;
            this.TableValueXUAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueXUAT.TextFormatString = "{0:N0}";
            this.TableValueXUAT.Weight = 1D;
            // 
            // TableValueTYLEXUAT
            // 
            this.TableValueTYLEXUAT.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTYLEXUAT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TYLEXUAT]")});
            this.TableValueTYLEXUAT.Multiline = true;
            this.TableValueTYLEXUAT.Name = "TableValueTYLEXUAT";
            this.TableValueTYLEXUAT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTYLEXUAT.StylePriority.UseBorders = false;
            this.TableValueTYLEXUAT.StylePriority.UsePadding = false;
            this.TableValueTYLEXUAT.StylePriority.UseTextAlignment = false;
            this.TableValueTYLEXUAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableValueTYLEXUAT.TextFormatString = "{0:0.00%}";
            this.TableValueTYLEXUAT.Weight = 1D;
            // 
            // sqlDataSource
            // 
            this.sqlDataSource.ConnectionName = "QLVT.Properties.Settings.QLVTConnectionString";
            this.sqlDataSource.Name = "sqlDataSource";
            storedProcQuery1.Name = "SP_GET_IMPORTED_EXPORTED_SUMMARY";
            queryParameter1.Name = "@DATEFROM";
            queryParameter1.Type = typeof(System.DateTime);
            queryParameter1.ValueInfo = "2023-01-01";
            queryParameter2.Name = "@DATETO";
            queryParameter2.Type = typeof(System.DateTime);
            queryParameter2.ValueInfo = "2024-01-01";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "SP_GET_IMPORTED_EXPORTED_SUMMARY";
            this.sqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource.ResultSchemaSerializable = resources.GetString("sqlDataSource.ResultSchemaSerializable");
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
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableHeader});
            this.PageHeader.HeightF = 40F;
            this.PageHeader.Name = "PageHeader";
            // 
            // TableHeader
            // 
            this.TableHeader.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TableHeader.BorderColor = System.Drawing.Color.Gray;
            this.TableHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableHeader.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.TableHeader.SizeF = new System.Drawing.SizeF(649.9999F, 40F);
            this.TableHeader.StylePriority.UseBackColor = false;
            this.TableHeader.StylePriority.UseBorderColor = false;
            this.TableHeader.StylePriority.UseBorders = false;
            this.TableHeader.StylePriority.UseFont = false;
            this.TableHeader.StylePriority.UsePadding = false;
            this.TableHeader.StylePriority.UseTextAlignment = false;
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableCellNGAY,
            this.TableCellNHAP,
            this.TableCellTYLENHAP,
            this.TableCellXUAT,
            this.TableCellTYLEXUAT});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TableCellNGAY
            // 
            this.TableCellNGAY.Multiline = true;
            this.TableCellNGAY.Name = "TableCellNGAY";
            this.TableCellNGAY.Text = "NGÀY";
            this.TableCellNGAY.Weight = 1D;
            // 
            // TableCellNHAP
            // 
            this.TableCellNHAP.Multiline = true;
            this.TableCellNHAP.Name = "TableCellNHAP";
            this.TableCellNHAP.Text = "NHẬP";
            this.TableCellNHAP.Weight = 1D;
            // 
            // TableCellTYLENHAP
            // 
            this.TableCellTYLENHAP.Multiline = true;
            this.TableCellTYLENHAP.Name = "TableCellTYLENHAP";
            this.TableCellTYLENHAP.Text = "TỶ LỆ";
            this.TableCellTYLENHAP.Weight = 1D;
            // 
            // TableCellXUAT
            // 
            this.TableCellXUAT.Multiline = true;
            this.TableCellXUAT.Name = "TableCellXUAT";
            this.TableCellXUAT.Text = "XUẤT";
            this.TableCellXUAT.Weight = 1D;
            // 
            // TableCellTYLEXUAT
            // 
            this.TableCellTYLEXUAT.Multiline = true;
            this.TableCellTYLEXUAT.Name = "TableCellTYLEXUAT";
            this.TableCellTYLEXUAT.Text = "TỶ LỆ";
            this.TableCellTYLEXUAT.Weight = 1D;
            // 
            // TYLENHAP
            // 
            this.TYLENHAP.DataMember = "SP_GET_IMPORTED_EXPORTED_SUMMARY";
            this.TYLENHAP.Expression = "[NHAP] / ([NHAP] + [XUAT])";
            this.TYLENHAP.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.TYLENHAP.Name = "TYLENHAP";
            // 
            // TYLEXUAT
            // 
            this.TYLEXUAT.DataMember = "SP_GET_IMPORTED_EXPORTED_SUMMARY";
            this.TYLEXUAT.Expression = "[XUAT] / ([NHAP] + [XUAT])";
            this.TYLEXUAT.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.TYLEXUAT.Name = "TYLEXUAT";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableFooter});
            this.ReportFooter.HeightF = 35F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // TableFooter
            // 
            this.TableFooter.BackColor = System.Drawing.Color.White;
            this.TableFooter.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableFooter.LocationFloat = new DevExpress.Utils.PointFloat(2.543131E-05F, 0F);
            this.TableFooter.Name = "TableFooter";
            this.TableFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableFooter.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.TableFooter.SizeF = new System.Drawing.SizeF(650F, 35F);
            this.TableFooter.StylePriority.UseBackColor = false;
            this.TableFooter.StylePriority.UseFont = false;
            this.TableFooter.StylePriority.UsePadding = false;
            this.TableFooter.StylePriority.UseTextAlignment = false;
            this.TableFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableFooterTieuDe,
            this.TableValueTONGNHAP,
            this.TableValueEmpty1,
            this.TableValueTONGXUAT,
            this.TableValueEmpty2});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // TableFooterTieuDe
            // 
            this.TableFooterTieuDe.BorderColor = System.Drawing.Color.Gray;
            this.TableFooterTieuDe.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableFooterTieuDe.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableFooterTieuDe.Multiline = true;
            this.TableFooterTieuDe.Name = "TableFooterTieuDe";
            this.TableFooterTieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableFooterTieuDe.StylePriority.UseBorderColor = false;
            this.TableFooterTieuDe.StylePriority.UseBorders = false;
            this.TableFooterTieuDe.StylePriority.UseFont = false;
            this.TableFooterTieuDe.StylePriority.UsePadding = false;
            this.TableFooterTieuDe.StylePriority.UseTextAlignment = false;
            this.TableFooterTieuDe.Text = "CỘNG";
            this.TableFooterTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.TableFooterTieuDe.Weight = 1.0023131716809621D;
            // 
            // TableValueTONGNHAP
            // 
            this.TableValueTONGNHAP.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTONGNHAP.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTONGNHAP.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([NHAP])")});
            this.TableValueTONGNHAP.Multiline = true;
            this.TableValueTONGNHAP.Name = "TableValueTONGNHAP";
            this.TableValueTONGNHAP.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTONGNHAP.StylePriority.UseBorderColor = false;
            this.TableValueTONGNHAP.StylePriority.UseBorders = false;
            this.TableValueTONGNHAP.StylePriority.UsePadding = false;
            this.TableValueTONGNHAP.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.TableValueTONGNHAP.Summary = xrSummary1;
            this.TableValueTONGNHAP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueTONGNHAP.TextFormatString = "{0:N0}";
            this.TableValueTONGNHAP.Weight = 1.0023131716809621D;
            // 
            // TableValueEmpty1
            // 
            this.TableValueEmpty1.BorderColor = System.Drawing.Color.Gray;
            this.TableValueEmpty1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueEmpty1.Multiline = true;
            this.TableValueEmpty1.Name = "TableValueEmpty1";
            this.TableValueEmpty1.StylePriority.UseBorderColor = false;
            this.TableValueEmpty1.StylePriority.UseBorders = false;
            this.TableValueEmpty1.Weight = 1.0023131716809621D;
            // 
            // TableValueTONGXUAT
            // 
            this.TableValueTONGXUAT.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTONGXUAT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTONGXUAT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([XUAT])")});
            this.TableValueTONGXUAT.Multiline = true;
            this.TableValueTONGXUAT.Name = "TableValueTONGXUAT";
            this.TableValueTONGXUAT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTONGXUAT.StylePriority.UseBorderColor = false;
            this.TableValueTONGXUAT.StylePriority.UseBorders = false;
            this.TableValueTONGXUAT.StylePriority.UsePadding = false;
            this.TableValueTONGXUAT.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.TableValueTONGXUAT.Summary = xrSummary2;
            this.TableValueTONGXUAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueTONGXUAT.TextFormatString = "{0:N0}";
            this.TableValueTONGXUAT.Weight = 1.0023131716809621D;
            // 
            // TableValueEmpty2
            // 
            this.TableValueEmpty2.BorderColor = System.Drawing.Color.Gray;
            this.TableValueEmpty2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueEmpty2.Multiline = true;
            this.TableValueEmpty2.Name = "TableValueEmpty2";
            this.TableValueEmpty2.StylePriority.UseBorderColor = false;
            this.TableValueEmpty2.StylePriority.UseBorders = false;
            this.TableValueEmpty2.Weight = 1.0023134069745925D;
            // 
            // Xrpt_TongHopNhapXuat
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.PageHeader,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TYLENHAP,
            this.TYLEXUAT});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource});
            this.DataMember = "SP_GET_IMPORTED_EXPORTED_SUMMARY";
            this.DataSource = this.sqlDataSource;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.GroupFooterBackground3,
            this.PageInfo});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.TableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoNumber;
        private DevExpress.XtraReports.UI.XRLabel lblTieuDeBaoCao;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable TableContent;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell TableValueNGAY;
        private DevExpress.XtraReports.UI.XRTableCell TableValueNHAP;
        private DevExpress.XtraReports.UI.XRTableCell TableValueXUAT;
        private DevExpress.XtraReports.UI.XRTable TableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNGAY;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNHAP;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTYLENHAP;
        private DevExpress.XtraReports.UI.XRTableCell TableCellXUAT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTYLEXUAT;
        private DevExpress.XtraReports.UI.CalculatedField TYLENHAP;
        private DevExpress.XtraReports.UI.CalculatedField TYLEXUAT;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable TableFooter;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell TableFooterTieuDe;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTONGNHAP;
        private DevExpress.XtraReports.UI.XRTableCell TableValueEmpty1;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTONGXUAT;
        private DevExpress.XtraReports.UI.XRTableCell TableValueEmpty2;
        private DevExpress.XtraReports.UI.XRPanel pnlThongTinBaoCao;
        private DevExpress.XtraReports.UI.XRLabel lblNgayKetThuc;
        private DevExpress.XtraReports.UI.XRLabel lblNgayBatDau;
        private DevExpress.XtraReports.UI.XRLabel lblDenNgay;
        private DevExpress.XtraReports.UI.XRLabel lblTuNgay;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoDate;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTYLENHAP;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTYLEXUAT;
    }
}
