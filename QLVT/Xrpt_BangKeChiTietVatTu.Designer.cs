namespace QLVT
{
    partial class Xrpt_BangKeChiTietVatTu
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_BangKeChiTietVatTu));
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
            this.TableValueTHANGNAM = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTONGSOLUONG = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableValueTONGTRIGIA = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceCTVT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.TableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TableCellNGAY = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTENVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellSOLUONG = new DevExpress.XtraReports.UI.XRTableCell();
            this.TableCellTONGTRIGIA = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.pnlThongTinBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 45F);
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
            this.lblTieuDeBaoCao.Text = "CHI TIẾT ... VẬT TƯ";
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
            this.TableContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableContent.Font = new DevExpress.Drawing.DXFont("Cambria", 11F);
            this.TableContent.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableContent.Name = "TableContent";
            this.TableContent.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableContent.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.TableContent.SizeF = new System.Drawing.SizeF(650F, 35F);
            this.TableContent.StylePriority.UseBackColor = false;
            this.TableContent.StylePriority.UseFont = false;
            this.TableContent.StylePriority.UsePadding = false;
            this.TableContent.StylePriority.UseTextAlignment = false;
            this.TableContent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableValueTHANGNAM,
            this.TableValueTENVT,
            this.TableValueTONGSOLUONG,
            this.TableValueTONGTRIGIA});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // TableValueTHANGNAM
            // 
            this.TableValueTHANGNAM.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTHANGNAM.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTHANGNAM.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[THANGNAM]")});
            this.TableValueTHANGNAM.Multiline = true;
            this.TableValueTHANGNAM.Name = "TableValueTHANGNAM";
            this.TableValueTHANGNAM.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TableValueTHANGNAM.StylePriority.UseBorderColor = false;
            this.TableValueTHANGNAM.StylePriority.UseBorders = false;
            this.TableValueTHANGNAM.Weight = 1D;
            // 
            // TableValueTENVT
            // 
            this.TableValueTENVT.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTENVT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTENVT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENVT]")});
            this.TableValueTENVT.Multiline = true;
            this.TableValueTENVT.Name = "TableValueTENVT";
            this.TableValueTENVT.StylePriority.UseBorderColor = false;
            this.TableValueTENVT.StylePriority.UseBorders = false;
            this.TableValueTENVT.Weight = 1D;
            // 
            // TableValueTONGSOLUONG
            // 
            this.TableValueTONGSOLUONG.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTONGSOLUONG.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTONGSOLUONG.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TONGSOLUONG]")});
            this.TableValueTONGSOLUONG.Multiline = true;
            this.TableValueTONGSOLUONG.Name = "TableValueTONGSOLUONG";
            this.TableValueTONGSOLUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTONGSOLUONG.StylePriority.UseBorderColor = false;
            this.TableValueTONGSOLUONG.StylePriority.UseBorders = false;
            this.TableValueTONGSOLUONG.StylePriority.UsePadding = false;
            this.TableValueTONGSOLUONG.StylePriority.UseTextAlignment = false;
            this.TableValueTONGSOLUONG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueTONGSOLUONG.Weight = 1D;
            // 
            // TableValueTONGTRIGIA
            // 
            this.TableValueTONGTRIGIA.BorderColor = System.Drawing.Color.Gray;
            this.TableValueTONGTRIGIA.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TableValueTONGTRIGIA.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TONGTRIGIA]")});
            this.TableValueTONGTRIGIA.Multiline = true;
            this.TableValueTONGTRIGIA.Name = "TableValueTONGTRIGIA";
            this.TableValueTONGTRIGIA.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.TableValueTONGTRIGIA.StylePriority.UseBorderColor = false;
            this.TableValueTONGTRIGIA.StylePriority.UseBorders = false;
            this.TableValueTONGTRIGIA.StylePriority.UsePadding = false;
            this.TableValueTONGTRIGIA.StylePriority.UseTextAlignment = false;
            this.TableValueTONGTRIGIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TableValueTONGTRIGIA.TextFormatString = "{0:N0}";
            this.TableValueTONGTRIGIA.Weight = 1D;
            // 
            // sqlDataSourceCTVT
            // 
            this.sqlDataSourceCTVT.ConnectionName = "QLVT.Properties.Settings.QLVTConnectionString";
            this.sqlDataSourceCTVT.Name = "sqlDataSourceCTVT";
            storedProcQuery1.Name = "SP_GET_IMPORTED_EXPORTED_GOODS_PARALLEL";
            queryParameter1.Name = "@ROLE";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "CONGTY";
            queryParameter2.Name = "@TYPE";
            queryParameter2.Type = typeof(char);
            queryParameter2.ValueInfo = "N";
            queryParameter3.Name = "@DATEFROM";
            queryParameter3.Type = typeof(System.DateTime);
            queryParameter3.ValueInfo = "2023-01-01";
            queryParameter4.Name = "@DATETO";
            queryParameter4.Type = typeof(System.DateTime);
            queryParameter4.ValueInfo = "2024-01-01";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4});
            storedProcQuery1.StoredProcName = "SP_GET_IMPORTED_OR_EXPORTED_GOODS_PARALLEL";
            this.sqlDataSourceCTVT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSourceCTVT.ResultSchemaSerializable = resources.GetString("sqlDataSourceCTVT.ResultSchemaSerializable");
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
            this.TableHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TableHeader.Font = new DevExpress.Drawing.DXFont("Cambria", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.TableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.TableHeader.SizeF = new System.Drawing.SizeF(650F, 40F);
            this.TableHeader.StylePriority.UseBackColor = false;
            this.TableHeader.StylePriority.UseBorders = false;
            this.TableHeader.StylePriority.UseFont = false;
            this.TableHeader.StylePriority.UsePadding = false;
            this.TableHeader.StylePriority.UseTextAlignment = false;
            this.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TableCellNGAY,
            this.TableCellTENVT,
            this.TableCellSOLUONG,
            this.TableCellTONGTRIGIA});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TableCellNGAY
            // 
            this.TableCellNGAY.Multiline = true;
            this.TableCellNGAY.Name = "TableCellNGAY";
            this.TableCellNGAY.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellNGAY.StylePriority.UsePadding = false;
            this.TableCellNGAY.Text = "THÁNG/NĂM";
            this.TableCellNGAY.Weight = 1D;
            // 
            // TableCellTENVT
            // 
            this.TableCellTENVT.Multiline = true;
            this.TableCellTENVT.Name = "TableCellTENVT";
            this.TableCellTENVT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellTENVT.StylePriority.UsePadding = false;
            this.TableCellTENVT.Text = "VẬT TƯ";
            this.TableCellTENVT.Weight = 1D;
            // 
            // TableCellSOLUONG
            // 
            this.TableCellSOLUONG.Multiline = true;
            this.TableCellSOLUONG.Name = "TableCellSOLUONG";
            this.TableCellSOLUONG.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellSOLUONG.StylePriority.UsePadding = false;
            this.TableCellSOLUONG.Text = "TỔNG SỐ LƯỢNG";
            this.TableCellSOLUONG.Weight = 1D;
            // 
            // TableCellTONGTRIGIA
            // 
            this.TableCellTONGTRIGIA.Multiline = true;
            this.TableCellTONGTRIGIA.Name = "TableCellTONGTRIGIA";
            this.TableCellTONGTRIGIA.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TableCellTONGTRIGIA.StylePriority.UsePadding = false;
            this.TableCellTONGTRIGIA.Text = "TỔNG TRỊ GIÁ";
            this.TableCellTONGTRIGIA.Weight = 1D;
            // 
            // Xrpt_BangKeChiTietVatTu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSourceCTVT});
            this.DataMember = "SP_GET_IMPORTED_EXPORTED_GOODS_PARALLEL";
            this.DataSource = this.sqlDataSourceCTVT;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(99F, 100F, 100F, 100F);
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
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceCTVT;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoNumber;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoDate;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable TableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TableCellNGAY;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableCellSOLUONG;
        private DevExpress.XtraReports.UI.XRTableCell TableCellTONGTRIGIA;
        private DevExpress.XtraReports.UI.XRLabel lblTieuDeBaoCao;
        private DevExpress.XtraReports.UI.XRPanel pnlThongTinBaoCao;
        private DevExpress.XtraReports.UI.XRLabel lblNgayKetThuc;
        private DevExpress.XtraReports.UI.XRLabel lblNgayBatDau;
        private DevExpress.XtraReports.UI.XRLabel lblDenNgay;
        private DevExpress.XtraReports.UI.XRLabel lblTuNgay;
        private DevExpress.XtraReports.UI.XRTable TableContent;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTHANGNAM;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTENVT;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTONGSOLUONG;
        private DevExpress.XtraReports.UI.XRTableCell TableValueTONGTRIGIA;
    }
}
