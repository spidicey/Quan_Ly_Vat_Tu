namespace QLVT
{
    partial class Xrpt_DanhSachVatTu
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DanhSachVatTu));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTieuDeBaoCao = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TableContent = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableValueSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueMAVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueDVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueSOLUONGTON = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceVT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableCellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellMAVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellDVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellSOLUONGTON = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.pageInfoDate,
            this.pageInfoNumber});
            this.BottomMargin.Name = "BottomMargin";
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
            // pageInfoNumber
            // 
            this.pageInfoNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageInfoNumber.Font = new DevExpress.Drawing.DXFont("Cambria", 10F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.pageInfoNumber.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
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
            this.lblTieuDeBaoCao.Font = new DevExpress.Drawing.DXFont("Cambria", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTieuDeBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTieuDeBaoCao.Name = "lblTieuDeBaoCao";
            this.lblTieuDeBaoCao.SizeF = new System.Drawing.SizeF(650F, 75F);
            this.lblTieuDeBaoCao.StyleName = "Title";
            this.lblTieuDeBaoCao.StylePriority.UseBackColor = false;
            this.lblTieuDeBaoCao.StylePriority.UseFont = false;
            this.lblTieuDeBaoCao.StylePriority.UseTextAlignment = false;
            this.lblTieuDeBaoCao.Text = "DANH SÁCH VẬT TƯ";
            this.lblTieuDeBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableContent});
            this.Detail.HeightF = 35F;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TENVT", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // TableContent
            // 
            this.TableContent.BackColor = System.Drawing.Color.White;
            this.TableContent.BorderColor = System.Drawing.Color.Gray;
            this.TableContent.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([SOLUONGTON]  > 0, \'White\', \'LightGray\')")});
            this.TableContent.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableContent.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableContent.Name = "TableContent";
            this.TableContent.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableContent.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.TableContent.SizeF = new System.Drawing.SizeF(650F, 35F);
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
            this.TableValueSTT,
            this.TableValueMAVT,
            this.TableValueTENVT,
            this.TableValueDVT,
            this.TableValueSOLUONGTON});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // TableValueSTT
            // 
            this.TableValueSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueSTT.CanGrow = false;
            this.TableValueSTT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.TableValueSTT.Name = "TableValueSTT";
            this.TableValueSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableValueSTT.StylePriority.UseBorders = false;
            this.TableValueSTT.StylePriority.UsePadding = false;
            this.TableValueSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.TableValueSTT.Summary = xrSummary1;
            this.TableValueSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableValueSTT.TextFormatString = "{0:#}";
            this.TableValueSTT.Weight = 0.43056210367364911D;
            // 
            // TableValueMAVT
            // 
            this.TableValueMAVT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueMAVT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MAVT]")});
            this.TableValueMAVT.Multiline = true;
            this.TableValueMAVT.Name = "TableValueMAVT";
            this.TableValueMAVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueMAVT.StylePriority.UseBorders = false;
            this.TableValueMAVT.StylePriority.UsePadding = false;
            this.TableValueMAVT.Weight = 1.0046449206130752D;
            // 
            // TableValueTENVT
            // 
            this.TableValueTENVT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTENVT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENVT]")});
            this.TableValueTENVT.Multiline = true;
            this.TableValueTENVT.Name = "TableValueTENVT";
            this.TableValueTENVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueTENVT.StylePriority.UseBorders = false;
            this.TableValueTENVT.StylePriority.UsePadding = false;
            this.TableValueTENVT.Weight = 1.4352070581013809D;
            // 
            // TableValueDVT
            // 
            this.TableValueDVT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueDVT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVT]")});
            this.TableValueDVT.Multiline = true;
            this.TableValueDVT.Name = "TableValueDVT";
            this.TableValueDVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueDVT.StylePriority.UseBorders = false;
            this.TableValueDVT.StylePriority.UsePadding = false;
            this.TableValueDVT.Weight = 0.82524406915168436D;
            // 
            // TableValueSOLUONGTON
            // 
            this.TableValueSOLUONGTON.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueSOLUONGTON.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOLUONGTON]")});
            this.TableValueSOLUONGTON.Multiline = true;
            this.TableValueSOLUONGTON.Name = "TableValueSOLUONGTON";
            this.TableValueSOLUONGTON.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueSOLUONGTON.StylePriority.UseBorders = false;
            this.TableValueSOLUONGTON.StylePriority.UsePadding = false;
            this.TableValueSOLUONGTON.StylePriority.UseTextAlignment = false;
            this.TableValueSOLUONGTON.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueSOLUONGTON.Weight = 0.96876473609304581D;
            // 
            // sqlDataSourceVT
            // 
            this.sqlDataSourceVT.ConnectionName = "QLVT.Properties.Settings.QLVTConnectionString";
            this.sqlDataSourceVT.Name = "sqlDataSourceVT";
            customSqlQuery1.Name = "Vattu";
            customSqlQuery1.Sql = "select \"Vattu\".\"MAVT\", \"Vattu\".\"TENVT\",\r\n       \"Vattu\".\"DVT\", \"Vattu\".\"SOLUONGTO" +
    "N\"\r\n  from \"dbo\".\"Vattu\" \"Vattu\"";
            this.sqlDataSourceVT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceVT.ResultSchemaSerializable = resources.GetString("sqlDataSourceVT.ResultSchemaSerializable");
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
            this.TableHeader.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.TableHeader.SizeF = new System.Drawing.SizeF(650F, 40F);
            this.TableHeader.StylePriority.UseBackColor = false;
            this.TableHeader.StylePriority.UseBorderColor = false;
            this.TableHeader.StylePriority.UseFont = false;
            this.TableHeader.StylePriority.UsePadding = false;
            this.TableHeader.StylePriority.UseTextAlignment = false;
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableCellSTT,
            this.TableCellMAVT,
            this.TableCellTENVT,
            this.TableCellDVT,
            this.TableCellSOLUONGTON});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TableCellSTT
            // 
            this.TableCellSTT.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableCellSTT.Multiline = true;
            this.TableCellSTT.Name = "TableCellSTT";
            this.TableCellSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableCellSTT.StylePriority.UseBorders = false;
            this.TableCellSTT.StylePriority.UsePadding = false;
            this.TableCellSTT.StylePriority.UseTextAlignment = false;
            this.TableCellSTT.Text = "STT";
            this.TableCellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableCellSTT.Weight = 0.437396436684038D;
            // 
            // TableCellMAVT
            // 
            this.TableCellMAVT.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableCellMAVT.Multiline = true;
            this.TableCellMAVT.Name = "TableCellMAVT";
            this.TableCellMAVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellMAVT.StylePriority.UseBorders = false;
            this.TableCellMAVT.StylePriority.UsePadding = false;
            this.TableCellMAVT.Text = "ID";
            this.TableCellMAVT.Weight = 1.0205916514802531D;
            // 
            // TableCellTENVT
            // 
            this.TableCellTENVT.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableCellTENVT.Multiline = true;
            this.TableCellTENVT.Name = "TableCellTENVT";
            this.TableCellTENVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellTENVT.StylePriority.UseBorders = false;
            this.TableCellTENVT.StylePriority.UsePadding = false;
            this.TableCellTENVT.Text = "TÊN";
            this.TableCellTENVT.Weight = 1.457988122515689D;
            // 
            // TableCellDVT
            // 
            this.TableCellDVT.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableCellDVT.Multiline = true;
            this.TableCellDVT.Name = "TableCellDVT";
            this.TableCellDVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellDVT.StylePriority.UseBorders = false;
            this.TableCellDVT.StylePriority.UsePadding = false;
            this.TableCellDVT.Text = "ĐƠN VỊ TÍNH";
            this.TableCellDVT.Weight = 0.83834318136044128D;
            // 
            // TableCellSOLUONGTON
            // 
            this.TableCellSOLUONGTON.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableCellSOLUONGTON.Multiline = true;
            this.TableCellSOLUONGTON.Name = "TableCellSOLUONGTON";
            this.TableCellSOLUONGTON.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellSOLUONGTON.StylePriority.UseBorders = false;
            this.TableCellSOLUONGTON.StylePriority.UsePadding = false;
            this.TableCellSOLUONGTON.Text = "SỐ LƯỢNG TỒN";
            this.TableCellSOLUONGTON.Weight = 0.98414195412626859D;
            // 
            // Xrpt_DanhSachVatTu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSourceVT});
            this.DataMember = "Vattu";
            this.DataSource = this.sqlDataSourceVT;
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoNumber;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTieuDeBaoCao;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceVT;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable TableContent;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell TableValueMAVT;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableValueDVT;
        private DevExpress.XtraReports.UI.XRTable TableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TableCellMAVT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellDVT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSOLUONGTON;
        private DevExpress.XtraReports.UI.XRTableCell TableValueSOLUONGTON;
        private DevExpress.XtraReports.UI.XRTableCell TableValueSTT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSTT;
    }
}
