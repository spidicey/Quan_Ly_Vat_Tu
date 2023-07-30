namespace QLVT
{
    partial class Xrpt_DanhSachDatHangChuaNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DanhSachDatHangChuaNhap));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TableContent = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableValueMASODDH = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueNGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueNHACC = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueHOTEN = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueSOLUONG = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueDONGIA = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTieuDeBaoCao = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableCellMASODDH = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellNGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellNHACC = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellHOTEN = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellSOLUONG = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellDONGIA = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.TableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHeader)).BeginInit();
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
            this.pageInfoNumber.LocationFloat = new DevExpress.Utils.PointFloat(362.5F, 0F);
            this.pageInfoNumber.Name = "pageInfoNumber";
            this.pageInfoNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.pageInfoNumber.SizeF = new System.Drawing.SizeF(362.4999F, 23F);
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
            this.pageInfoDate.SizeF = new System.Drawing.SizeF(362.5F, 23F);
            this.pageInfoDate.StylePriority.UseBackColor = false;
            this.pageInfoDate.StylePriority.UseFont = false;
            this.pageInfoDate.StylePriority.UsePadding = false;
            this.pageInfoDate.StylePriority.UseTextAlignment = false;
            this.pageInfoDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.pageInfoDate.TextFormatString = "{0:dddd, dd/MM/yyyy}";
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
            this.TableContent.BorderColor = System.Drawing.Color.Gray;
            this.TableContent.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableContent.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableContent.Name = "TableContent";
            this.TableContent.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableContent.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.TableContent.SizeF = new System.Drawing.SizeF(725F, 35F);
            this.TableContent.StylePriority.UseBackColor = false;
            this.TableContent.StylePriority.UseBorderColor = false;
            this.TableContent.StylePriority.UseFont = false;
            this.TableContent.StylePriority.UsePadding = false;
            this.TableContent.StylePriority.UseTextAlignment = false;
            this.TableContent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableValueMASODDH,
            this.TableValueNGAY,
            this.TableValueNHACC,
            this.TableValueHOTEN,
            this.TableValueTENVT,
            this.TableValueSOLUONG,
            this.TableValueDONGIA});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // TableValueMASODDH
            // 
            this.TableValueMASODDH.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableValueMASODDH.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MASODDH]")});
            this.TableValueMASODDH.Multiline = true;
            this.TableValueMASODDH.Name = "TableValueMASODDH";
            this.TableValueMASODDH.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TableValueMASODDH.StylePriority.UseBorders = false;
            this.TableValueMASODDH.Weight = 0.86776858453251449D;
            // 
            // TableValueNGAY
            // 
            this.TableValueNGAY.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueNGAY.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY]")});
            this.TableValueNGAY.Multiline = true;
            this.TableValueNGAY.Name = "TableValueNGAY";
            this.TableValueNGAY.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TableValueNGAY.StylePriority.UseBorders = false;
            this.TableValueNGAY.TextFormatString = "{0:dd/MM/yyyy}";
            this.TableValueNGAY.Weight = 0.86776858453251438D;
            // 
            // TableValueNHACC
            // 
            this.TableValueNHACC.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueNHACC.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NHACC]")});
            this.TableValueNHACC.Multiline = true;
            this.TableValueNHACC.Name = "TableValueNHACC";
            this.TableValueNHACC.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TableValueNHACC.StylePriority.UseBorders = false;
            this.TableValueNHACC.Weight = 1.253443515661991D;
            // 
            // TableValueHOTEN
            // 
            this.TableValueHOTEN.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueHOTEN.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HOTEN]")});
            this.TableValueHOTEN.Multiline = true;
            this.TableValueHOTEN.Name = "TableValueHOTEN";
            this.TableValueHOTEN.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TableValueHOTEN.StylePriority.UseBorders = false;
            this.TableValueHOTEN.Weight = 1.060606050097253D;
            // 
            // TableValueTENVT
            // 
            this.TableValueTENVT.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTENVT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENVT]")});
            this.TableValueTENVT.Multiline = true;
            this.TableValueTENVT.Name = "TableValueTENVT";
            this.TableValueTENVT.StylePriority.UseBorders = false;
            this.TableValueTENVT.Weight = 1.0606060500972527D;
            // 
            // TableValueSOLUONG
            // 
            this.TableValueSOLUONG.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueSOLUONG.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOLUONG]")});
            this.TableValueSOLUONG.Multiline = true;
            this.TableValueSOLUONG.Name = "TableValueSOLUONG";
            this.TableValueSOLUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueSOLUONG.StylePriority.UseBorders = false;
            this.TableValueSOLUONG.StylePriority.UsePadding = false;
            this.TableValueSOLUONG.StylePriority.UseTextAlignment = false;
            this.TableValueSOLUONG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueSOLUONG.Weight = 0.86776858453251426D;
            // 
            // TableValueDONGIA
            // 
            this.TableValueDONGIA.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueDONGIA.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DONGIA]")});
            this.TableValueDONGIA.Multiline = true;
            this.TableValueDONGIA.Name = "TableValueDONGIA";
            this.TableValueDONGIA.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueDONGIA.StylePriority.UseBorders = false;
            this.TableValueDONGIA.StylePriority.UsePadding = false;
            this.TableValueDONGIA.StylePriority.UseTextAlignment = false;
            this.TableValueDONGIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueDONGIA.TextFormatString = "{0:N0}";
            this.TableValueDONGIA.Weight = 1.0123967572677235D;
            // 
            // sqlDataSource
            // 
            this.sqlDataSource.ConnectionName = "QLVT.Properties.Settings.QLVTConnectionString";
            this.sqlDataSource.Name = "sqlDataSource";
            storedProcQuery1.Name = "SP_GET_UNIMPORTED_ORDERS_PARALLEL";
            queryParameter1.Name = "@ROLE";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "CONGTY";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "SP_GET_UNIMPORTED_ORDERS_PARALLEL";
            this.sqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource.ResultSchemaSerializable = resources.GetString("sqlDataSource.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTieuDeBaoCao});
            this.ReportHeader.HeightF = 75F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblTieuDeBaoCao
            // 
            this.lblTieuDeBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTieuDeBaoCao.Font = new DevExpress.Drawing.DXFont("Cambria", 18F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTieuDeBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTieuDeBaoCao.Multiline = true;
            this.lblTieuDeBaoCao.Name = "lblTieuDeBaoCao";
            this.lblTieuDeBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTieuDeBaoCao.SizeF = new System.Drawing.SizeF(725.9999F, 74.99999F);
            this.lblTieuDeBaoCao.StylePriority.UseBackColor = false;
            this.lblTieuDeBaoCao.StylePriority.UseFont = false;
            this.lblTieuDeBaoCao.StylePriority.UseTextAlignment = false;
            this.lblTieuDeBaoCao.Text = "DANH SÁCH CÁC ĐƠN ĐẶT HÀNG CHƯA CÓ PHIẾU NHẬP";
            this.lblTieuDeBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.TableHeader.SizeF = new System.Drawing.SizeF(725F, 40F);
            this.TableHeader.StylePriority.UseBackColor = false;
            this.TableHeader.StylePriority.UseBorderColor = false;
            this.TableHeader.StylePriority.UseBorders = false;
            this.TableHeader.StylePriority.UseFont = false;
            this.TableHeader.StylePriority.UsePadding = false;
            this.TableHeader.StylePriority.UseTextAlignment = false;
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableCellMASODDH,
            this.TableCellNGAY,
            this.TableCellNHACC,
            this.TableCellHOTEN,
            this.TableCellTENVT,
            this.TableCellSOLUONG,
            this.TableCellDONGIA});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TableCellMASODDH
            // 
            this.TableCellMASODDH.Multiline = true;
            this.TableCellMASODDH.Name = "TableCellMASODDH";
            this.TableCellMASODDH.Text = "ID";
            this.TableCellMASODDH.Weight = 0.8677687094223332D;
            // 
            // TableCellNGAY
            // 
            this.TableCellNGAY.Multiline = true;
            this.TableCellNGAY.Name = "TableCellNGAY";
            this.TableCellNGAY.Text = "NGÀY LẬP";
            this.TableCellNGAY.Weight = 0.86776870942233331D;
            // 
            // TableCellNHACC
            // 
            this.TableCellNHACC.Multiline = true;
            this.TableCellNHACC.Name = "TableCellNHACC";
            this.TableCellNHACC.Text = "NHÀ CUNG CẤP";
            this.TableCellNHACC.Weight = 1.2534437053995608D;
            // 
            // TableCellHOTEN
            // 
            this.TableCellHOTEN.Multiline = true;
            this.TableCellHOTEN.Name = "TableCellHOTEN";
            this.TableCellHOTEN.Text = "NHÂN VIÊN";
            this.TableCellHOTEN.Weight = 1.060606207410947D;
            // 
            // TableCellTENVT
            // 
            this.TableCellTENVT.Multiline = true;
            this.TableCellTENVT.Name = "TableCellTENVT";
            this.TableCellTENVT.Text = "VẬT TƯ";
            this.TableCellTENVT.Weight = 1.060606207410947D;
            // 
            // TableCellSOLUONG
            // 
            this.TableCellSOLUONG.Multiline = true;
            this.TableCellSOLUONG.Name = "TableCellSOLUONG";
            this.TableCellSOLUONG.Text = "SỐ LƯỢNG";
            this.TableCellSOLUONG.Weight = 0.8677687094223332D;
            // 
            // TableCellDONGIA
            // 
            this.TableCellDONGIA.Multiline = true;
            this.TableCellDONGIA.Name = "TableCellDONGIA";
            this.TableCellDONGIA.Text = "ĐƠN GIÁ";
            this.TableCellDONGIA.Weight = 1.0123970535987965D;
            // 
            // Xrpt_DanhSachDatHangChuaNhap
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource});
            this.DataMember = "SP_GET_UNIMPORTED_ORDERS_PARALLEL";
            this.DataSource = this.sqlDataSource;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(61F, 63F, 100F, 100F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.TableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTieuDeBaoCao;
        private DevExpress.XtraReports.UI.XRTable TableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TableCellMASODDH;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNGAY;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNHACC;
        private DevExpress.XtraReports.UI.XRTableCell TableCellHOTEN;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSOLUONG;
        private DevExpress.XtraReports.UI.XRTableCell TableCellDONGIA;
        private DevExpress.XtraReports.UI.XRTable TableContent;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell TableValueMASODDH;
        private DevExpress.XtraReports.UI.XRTableCell TableValueNGAY;
        private DevExpress.XtraReports.UI.XRTableCell TableValueNHACC;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableValueSOLUONG;
        private DevExpress.XtraReports.UI.XRTableCell TableValueDONGIA;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoNumber;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoDate;
        private DevExpress.XtraReports.UI.XRTableCell TableValueHOTEN;
    }
}
