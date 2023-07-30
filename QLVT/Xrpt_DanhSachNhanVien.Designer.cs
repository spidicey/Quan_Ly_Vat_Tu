namespace QLVT
{
    partial class Xrpt_DanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DanhSachNhanVien));
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
            this.TableValueMANV = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueHO = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTEN = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueSOCMND = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueNGAYSINH = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueLUONG = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceNV = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableCellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellMANV = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellHO = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTEN = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellSOCMND = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellNGAYSINH = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellLUONG = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.pageInfoDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoDate.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfoDate.StyleName = "PageInfo";
            this.pageInfoDate.StylePriority.UseBackColor = false;
            this.pageInfoDate.StylePriority.UseFont = false;
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
            this.pageInfoNumber.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfoNumber.StyleName = "PageInfo";
            this.pageInfoNumber.StylePriority.UseBackColor = false;
            this.pageInfoNumber.StylePriority.UseFont = false;
            this.pageInfoNumber.StylePriority.UseTextAlignment = false;
            this.pageInfoNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pageInfoNumber.TextFormatString = "Page {0} / {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTieuDeBaoCao});
            this.ReportHeader.Font = new DevExpress.Drawing.DXFont("Cambria", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportHeader.HeightF = 75F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
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
            this.lblTieuDeBaoCao.Text = "DANH SÁCH NHÂN VIÊN";
            this.lblTieuDeBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableContent});
            this.Detail.HeightF = 35F;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TEN", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("HO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // TableContent
            // 
            this.TableContent.BackColor = System.Drawing.Color.White;
            this.TableContent.BorderColor = System.Drawing.Color.Gray;
            this.TableContent.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableContent.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([TRANGTHAIXOA], \'LightGray\', \'White\')")});
            this.TableContent.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableContent.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableContent.Name = "TableContent";
            this.TableContent.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableContent.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.TableContent.SizeF = new System.Drawing.SizeF(650F, 35F);
            this.TableContent.StylePriority.UseBackColor = false;
            this.TableContent.StylePriority.UseBorderColor = false;
            this.TableContent.StylePriority.UseBorders = false;
            this.TableContent.StylePriority.UseFont = false;
            this.TableContent.StylePriority.UsePadding = false;
            this.TableContent.StylePriority.UseTextAlignment = false;
            this.TableContent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableValueSTT,
            this.TableValueMANV,
            this.TableValueHO,
            this.TableValueTEN,
            this.TableValueSOCMND,
            this.TableValueNGAYSINH,
            this.TableValueLUONG});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // TableValueSTT
            // 
            this.TableValueSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueSTT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.TableValueSTT.Multiline = true;
            this.TableValueSTT.Name = "TableValueSTT";
            this.TableValueSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableValueSTT.StylePriority.UseBorders = false;
            this.TableValueSTT.StylePriority.UsePadding = false;
            this.TableValueSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.TableValueSTT.Summary = xrSummary1;
            this.TableValueSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableValueSTT.TextFormatString = "{0:#}";
            this.TableValueSTT.Weight = 0.6220118204595938D;
            // 
            // TableValueMANV
            // 
            this.TableValueMANV.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueMANV.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MANV]")});
            this.TableValueMANV.Multiline = true;
            this.TableValueMANV.Name = "TableValueMANV";
            this.TableValueMANV.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueMANV.StylePriority.UseBorders = false;
            this.TableValueMANV.StylePriority.UsePadding = false;
            this.TableValueMANV.Weight = 0.82934917693668775D;
            // 
            // TableValueHO
            // 
            this.TableValueHO.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueHO.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HO]")});
            this.TableValueHO.Multiline = true;
            this.TableValueHO.Name = "TableValueHO";
            this.TableValueHO.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueHO.StylePriority.UseBorders = false;
            this.TableValueHO.StylePriority.UsePadding = false;
            this.TableValueHO.Weight = 1.3476923100274454D;
            // 
            // TableValueTEN
            // 
            this.TableValueTEN.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTEN.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TEN]")});
            this.TableValueTEN.Multiline = true;
            this.TableValueTEN.Name = "TableValueTEN";
            this.TableValueTEN.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueTEN.StylePriority.UseBorders = false;
            this.TableValueTEN.StylePriority.UsePadding = false;
            this.TableValueTEN.Weight = 0.77751477502719446D;
            // 
            // TableValueSOCMND
            // 
            this.TableValueSOCMND.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueSOCMND.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOCMND]")});
            this.TableValueSOCMND.Multiline = true;
            this.TableValueSOCMND.Name = "TableValueSOCMND";
            this.TableValueSOCMND.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueSOCMND.StylePriority.UseBorders = false;
            this.TableValueSOCMND.StylePriority.UsePadding = false;
            this.TableValueSOCMND.Weight = 1.0366863648163458D;
            // 
            // TableValueNGAYSINH
            // 
            this.TableValueNGAYSINH.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueNGAYSINH.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAYSINH]")});
            this.TableValueNGAYSINH.Multiline = true;
            this.TableValueNGAYSINH.Name = "TableValueNGAYSINH";
            this.TableValueNGAYSINH.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableValueNGAYSINH.StylePriority.UseBorders = false;
            this.TableValueNGAYSINH.StylePriority.UsePadding = false;
            this.TableValueNGAYSINH.TextFormatString = "{0:dd/MM/yyyy}";
            this.TableValueNGAYSINH.Weight = 1.0366863648163458D;
            // 
            // TableValueLUONG
            // 
            this.TableValueLUONG.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueLUONG.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LUONG]")});
            this.TableValueLUONG.Multiline = true;
            this.TableValueLUONG.Name = "TableValueLUONG";
            this.TableValueLUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueLUONG.StylePriority.UseBorders = false;
            this.TableValueLUONG.StylePriority.UsePadding = false;
            this.TableValueLUONG.StylePriority.UseTextAlignment = false;
            this.TableValueLUONG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueLUONG.TextFormatString = "{0:N0}";
            this.TableValueLUONG.Weight = 1.0885207029028654D;
            // 
            // sqlDataSourceNV
            // 
            this.sqlDataSourceNV.ConnectionName = "QLVT.Properties.Settings.QLVTConnectionString";
            this.sqlDataSourceNV.Name = "sqlDataSourceNV";
            customSqlQuery1.Name = "NHANVIEN";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSourceNV.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceNV.ResultSchemaSerializable = resources.GetString("sqlDataSourceNV.ResultSchemaSerializable");
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
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
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
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.TableHeader.SizeF = new System.Drawing.SizeF(650F, 40F);
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
            this.TableCellSTT,
            this.TableCellMANV,
            this.TableCellHO,
            this.TableCellTEN,
            this.TableCellSOCMND,
            this.TableCellNGAYSINH,
            this.TableCellLUONG});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TableCellSTT
            // 
            this.TableCellSTT.Multiline = true;
            this.TableCellSTT.Name = "TableCellSTT";
            this.TableCellSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableCellSTT.StylePriority.UsePadding = false;
            this.TableCellSTT.StylePriority.UseTextAlignment = false;
            this.TableCellSTT.Text = "STT";
            this.TableCellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TableCellSTT.Weight = 0.6220118204595938D;
            // 
            // TableCellMANV
            // 
            this.TableCellMANV.Multiline = true;
            this.TableCellMANV.Name = "TableCellMANV";
            this.TableCellMANV.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellMANV.StylePriority.UsePadding = false;
            this.TableCellMANV.Text = "ID";
            this.TableCellMANV.Weight = 0.82934917693668775D;
            // 
            // TableCellHO
            // 
            this.TableCellHO.Multiline = true;
            this.TableCellHO.Name = "TableCellHO";
            this.TableCellHO.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellHO.StylePriority.UsePadding = false;
            this.TableCellHO.Text = "HỌ";
            this.TableCellHO.Weight = 1.3476923100274458D;
            // 
            // TableCellTEN
            // 
            this.TableCellTEN.Multiline = true;
            this.TableCellTEN.Name = "TableCellTEN";
            this.TableCellTEN.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellTEN.StylePriority.UsePadding = false;
            this.TableCellTEN.Text = "TÊN";
            this.TableCellTEN.Weight = 0.77751477502719446D;
            // 
            // TableCellSOCMND
            // 
            this.TableCellSOCMND.Multiline = true;
            this.TableCellSOCMND.Name = "TableCellSOCMND";
            this.TableCellSOCMND.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellSOCMND.StylePriority.UsePadding = false;
            this.TableCellSOCMND.Text = "CMND";
            this.TableCellSOCMND.Weight = 1.0366863648163456D;
            // 
            // TableCellNGAYSINH
            // 
            this.TableCellNGAYSINH.Multiline = true;
            this.TableCellNGAYSINH.Name = "TableCellNGAYSINH";
            this.TableCellNGAYSINH.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellNGAYSINH.StylePriority.UsePadding = false;
            this.TableCellNGAYSINH.Text = "NGÀY SINH";
            this.TableCellNGAYSINH.Weight = 1.0366863648163458D;
            // 
            // TableCellLUONG
            // 
            this.TableCellLUONG.Multiline = true;
            this.TableCellLUONG.Name = "TableCellLUONG";
            this.TableCellLUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellLUONG.StylePriority.UsePadding = false;
            this.TableCellLUONG.Text = "LƯƠNG";
            this.TableCellLUONG.Weight = 1.0885207029028656D;
            // 
            // Xrpt_DanhSachNhanVien
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSourceNV});
            this.DataMember = "NHANVIEN";
            this.DataSource = this.sqlDataSourceNV;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceNV;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable TableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TableCellMANV;
        private DevExpress.XtraReports.UI.XRTableCell TableCellHO;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTEN;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSOCMND;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNGAYSINH;
        private DevExpress.XtraReports.UI.XRTableCell TableCellLUONG;
        private DevExpress.XtraReports.UI.XRTable TableContent;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell TableValueMANV;
        private DevExpress.XtraReports.UI.XRTableCell TableValueHO;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTEN;
        private DevExpress.XtraReports.UI.XRTableCell TableValueSOCMND;
        private DevExpress.XtraReports.UI.XRTableCell TableValueNGAYSINH;
        private DevExpress.XtraReports.UI.XRTableCell TableValueLUONG;
        private DevExpress.XtraReports.UI.XRTableCell TableValueSTT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSTT;
    }
}
