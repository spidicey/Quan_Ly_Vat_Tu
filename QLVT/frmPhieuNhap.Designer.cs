namespace QLVT
{
    partial class frmPhieuNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblMAKHO;
            System.Windows.Forms.Label lblMANV;
            System.Windows.Forms.Label lblMASODDH;
            System.Windows.Forms.Label lblNGAY;
            System.Windows.Forms.Label lblMAPN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLVT.DS();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASODDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtMASODDH = new System.Windows.Forms.TextBox();
            this.cmbNHACC = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.cmbHOTENNV = new System.Windows.Forms.ComboBox();
            this.bdsHOTENNV = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTENKHO = new System.Windows.Forms.ComboBox();
            this.bdsKHO = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAPN = new System.Windows.Forms.TextBox();
            this.detNGAY = new DevExpress.XtraEditors.DateEdit();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.HOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.KHOTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.DATHANGTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.VATTUTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.cmsChucNangVT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            lblMAKHO = new System.Windows.Forms.Label();
            lblMANV = new System.Windows.Forms.Label();
            lblMASODDH = new System.Windows.Forms.Label();
            lblNGAY = new System.Windows.Forms.Label();
            lblMAPN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            this.cmsChucNangVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemVT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMAKHO
            // 
            lblMAKHO.AutoSize = true;
            lblMAKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAKHO.Location = new System.Drawing.Point(50, 329);
            lblMAKHO.Name = "lblMAKHO";
            lblMAKHO.Size = new System.Drawing.Size(44, 20);
            lblMAKHO.TabIndex = 0;
            lblMAKHO.Text = "Kho:";
            // 
            // lblMANV
            // 
            lblMANV.AutoSize = true;
            lblMANV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMANV.Location = new System.Drawing.Point(50, 254);
            lblMANV.Name = "lblMANV";
            lblMANV.Size = new System.Drawing.Size(87, 20);
            lblMANV.TabIndex = 0;
            lblMANV.Text = "Nhân viên:";
            // 
            // lblMASODDH
            // 
            lblMASODDH.AutoSize = true;
            lblMASODDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMASODDH.Location = new System.Drawing.Point(50, 179);
            lblMASODDH.Name = "lblMASODDH";
            lblMASODDH.Size = new System.Drawing.Size(103, 20);
            lblMASODDH.TabIndex = 0;
            lblMASODDH.Text = "Số phiếu đặt:";
            // 
            // lblNGAY
            // 
            lblNGAY.AutoSize = true;
            lblNGAY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNGAY.Location = new System.Drawing.Point(383, 104);
            lblNGAY.Name = "lblNGAY";
            lblNGAY.Size = new System.Drawing.Size(123, 20);
            lblNGAY.TabIndex = 0;
            lblNGAY.Text = "Ngày thực hiện:";
            // 
            // lblMAPN
            // 
            lblMAPN.AutoSize = true;
            lblMAPN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAPN.Location = new System.Drawing.Point(50, 104);
            lblMAPN.Name = "lblMAPN";
            lblMAPN.Size = new System.Drawing.Size(116, 20);
            lblMAPN.TabIndex = 0;
            lblMAPN.Text = "Số phiếu nhập:";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.bmrChucNang.DockControls.Add(this.barDockControlTop);
            this.bmrChucNang.DockControls.Add(this.barDockControlBottom);
            this.bmrChucNang.DockControls.Add(this.barDockControlLeft);
            this.bmrChucNang.DockControls.Add(this.barDockControlRight);
            this.bmrChucNang.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmrChucNang.Form = this;
            this.bmrChucNang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChiTiet,
            this.btnThoat});
            this.bmrChucNang.MainMenu = this.bar2;
            this.bmrChucNang.MaxItemId = 7;
            this.bmrChucNang.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChiTiet),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "Chi tiết";
            this.btnChiTiet.Id = 5;
            this.btnChiTiet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTiet.ImageOptions.SvgImage")));
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTiet_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmrChucNang;
            this.barDockControlTop.Size = new System.Drawing.Size(1062, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 733);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Size = new System.Drawing.Size(1062, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 682);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1062, 51);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 682);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.DS;
            this.bdsPN.Sort = "";
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.PHIEUNHAPTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPN;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 107);
            this.gcPhieuNhap.MainView = this.gvPhieuNhap;
            this.gcPhieuNhap.MenuManager = this.bmrChucNang;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1062, 234);
            this.gcPhieuNhap.TabIndex = 0;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNhap});
            // 
            // gvPhieuNhap
            // 
            this.gvPhieuNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhieuNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.gvPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMASODDH,
            this.colMANV,
            this.colMAKHO});
            this.gvPhieuNhap.DetailHeight = 367;
            this.gvPhieuNhap.GridControl = this.gcPhieuNhap;
            this.gvPhieuNhap.Name = "gvPhieuNhap";
            this.gvPhieuNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPhieuNhap_FocusedRowChanged);
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Số phiếu nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.OptionsColumn.AllowEdit = false;
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày thực hiện";
            this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMASODDH
            // 
            this.colMASODDH.Caption = "Số phiếu đặt";
            this.colMASODDH.FieldName = "MASODDH";
            this.colMASODDH.MinWidth = 25;
            this.colMASODDH.Name = "colMASODDH";
            this.colMASODDH.OptionsColumn.AllowEdit = false;
            this.colMASODDH.Visible = true;
            this.colMASODDH.VisibleIndex = 2;
            this.colMASODDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pncNhapLieu.Controls.Add(this.txtMASODDH);
            this.pncNhapLieu.Controls.Add(this.cmbNHACC);
            this.pncNhapLieu.Controls.Add(this.txtMANV);
            this.pncNhapLieu.Controls.Add(this.txtMAKHO);
            this.pncNhapLieu.Controls.Add(this.cmbHOTENNV);
            this.pncNhapLieu.Controls.Add(this.cmbTENKHO);
            this.pncNhapLieu.Controls.Add(this.txtMAPN);
            this.pncNhapLieu.Controls.Add(this.detNGAY);
            this.pncNhapLieu.Controls.Add(lblMAKHO);
            this.pncNhapLieu.Controls.Add(lblMANV);
            this.pncNhapLieu.Controls.Add(lblMASODDH);
            this.pncNhapLieu.Controls.Add(lblNGAY);
            this.pncNhapLieu.Controls.Add(lblMAPN);
            this.pncNhapLieu.Controls.Add(this.lblTieuDe);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pncNhapLieu.Enabled = false;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 341);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(733, 392);
            this.pncNhapLieu.TabIndex = 0;
            // 
            // txtMASODDH
            // 
            this.txtMASODDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MASODDH", true));
            this.txtMASODDH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASODDH.Location = new System.Drawing.Point(469, 175);
            this.txtMASODDH.Name = "txtMASODDH";
            this.txtMASODDH.ReadOnly = true;
            this.txtMASODDH.Size = new System.Drawing.Size(139, 28);
            this.txtMASODDH.TabIndex = 0;
            this.txtMASODDH.TabStop = false;
            // 
            // cmbNHACC
            // 
            this.cmbNHACC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MASODDH", true));
            this.cmbNHACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNHACC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNHACC.FormattingEnabled = true;
            this.cmbNHACC.Location = new System.Drawing.Point(175, 175);
            this.cmbNHACC.Name = "cmbNHACC";
            this.cmbNHACC.Size = new System.Drawing.Size(254, 28);
            this.cmbNHACC.TabIndex = 2;
            this.cmbNHACC.SelectedIndexChanged += new System.EventHandler(this.cmbNHACC_SelectedIndexChanged);
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MANV", true));
            this.txtMANV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(469, 250);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(139, 28);
            this.txtMANV.TabIndex = 0;
            this.txtMANV.TabStop = false;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAKHO", true));
            this.txtMAKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHO.Location = new System.Drawing.Point(469, 325);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.ReadOnly = true;
            this.txtMAKHO.Size = new System.Drawing.Size(139, 28);
            this.txtMAKHO.TabIndex = 0;
            this.txtMAKHO.TabStop = false;
            // 
            // cmbHOTENNV
            // 
            this.cmbHOTENNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MANV", true));
            this.cmbHOTENNV.DataSource = this.bdsHOTENNV;
            this.cmbHOTENNV.DisplayMember = "HOTEN";
            this.cmbHOTENNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOTENNV.Enabled = false;
            this.cmbHOTENNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHOTENNV.FormattingEnabled = true;
            this.cmbHOTENNV.Location = new System.Drawing.Point(175, 250);
            this.cmbHOTENNV.Name = "cmbHOTENNV";
            this.cmbHOTENNV.Size = new System.Drawing.Size(254, 28);
            this.cmbHOTENNV.TabIndex = 0;
            this.cmbHOTENNV.TabStop = false;
            this.cmbHOTENNV.ValueMember = "MANV";
            this.cmbHOTENNV.SelectedIndexChanged += new System.EventHandler(this.cmbHOTENNV_SelectedIndexChanged);
            // 
            // bdsHOTENNV
            // 
            this.bdsHOTENNV.DataMember = "HOTENNV";
            this.bdsHOTENNV.DataSource = this.DS;
            // 
            // cmbTENKHO
            // 
            this.cmbTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MAKHO", true));
            this.cmbTENKHO.DataSource = this.bdsKHO;
            this.cmbTENKHO.DisplayMember = "TENKHO";
            this.cmbTENKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENKHO.FormattingEnabled = true;
            this.cmbTENKHO.Location = new System.Drawing.Point(175, 325);
            this.cmbTENKHO.Name = "cmbTENKHO";
            this.cmbTENKHO.Size = new System.Drawing.Size(254, 28);
            this.cmbTENKHO.TabIndex = 3;
            this.cmbTENKHO.ValueMember = "MAKHO";
            this.cmbTENKHO.SelectedIndexChanged += new System.EventHandler(this.cmbTENKHO_SelectedIndexChanged);
            // 
            // bdsKHO
            // 
            this.bdsKHO.DataMember = "Kho";
            this.bdsKHO.DataSource = this.DS;
            // 
            // txtMAPN
            // 
            this.txtMAPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMAPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAPN", true));
            this.txtMAPN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAPN.Location = new System.Drawing.Point(175, 100);
            this.txtMAPN.Name = "txtMAPN";
            this.txtMAPN.Size = new System.Drawing.Size(164, 28);
            this.txtMAPN.TabIndex = 1;
            this.txtMAPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAPN_KeyPress);
            // 
            // detNGAY
            // 
            this.detNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.detNGAY.EditValue = null;
            this.detNGAY.Location = new System.Drawing.Point(518, 101);
            this.detNGAY.MenuManager = this.bmrChucNang;
            this.detNGAY.Name = "detNGAY";
            this.detNGAY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNGAY.Properties.Appearance.Options.UseFont = true;
            this.detNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNGAY.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.detNGAY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNGAY.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.detNGAY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNGAY.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.detNGAY.Properties.ReadOnly = true;
            this.detNGAY.Size = new System.Drawing.Size(164, 26);
            this.detNGAY.TabIndex = 0;
            this.detNGAY.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(229, 29);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(275, 27);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // KHOTableAdapter
            // 
            this.KHOTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.DS;
            // 
            // DATHANGTableAdapter
            // 
            this.DATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.DS;
            // 
            // VATTUTableAdapter
            // 
            this.VATTUTableAdapter.ClearBeforeFill = true;
            // 
            // cmsChucNangVT
            // 
            this.cmsChucNangVT.Enabled = false;
            this.cmsChucNangVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsChucNangVT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsChucNangVT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnXoaVT,
            this.btnSuaVT});
            this.cmsChucNangVT.Name = "cmsChucNangVT";
            this.cmsChucNangVT.Size = new System.Drawing.Size(211, 120);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Enabled = false;
            this.btnThemVT.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(210, 26);
            this.btnThemVT.Text = "Thêm vật tư";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Enabled = false;
            this.btnXoaVT.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(210, 26);
            this.btnXoaVT.Text = "Xóa vật tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Enabled = false;
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(210, 26);
            this.btnSuaVT.Text = "Sửa vật tư";
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.pncChiNhanh.Name = "pncChiNhanh";
            this.pncChiNhanh.Size = new System.Drawing.Size(1062, 56);
            this.pncChiNhanh.TabIndex = 0;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(135, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(320, 29);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.TabStop = false;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(28, 18);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(92, 20);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "CTPN";
            this.bdsCTPN.DataSource = this.DS;
            this.bdsCTPN.Filter = "";
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.Enabled = false;
            this.gcCTPN.Location = new System.Drawing.Point(733, 341);
            this.gcCTPN.MainView = this.gvCTPN;
            this.gcCTPN.MenuManager = this.bmrChucNang;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemVT});
            this.gcCTPN.Size = new System.Drawing.Size(329, 392);
            this.gcCTPN.TabIndex = 1;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            // 
            // gvCTPN
            // 
            this.gvCTPN.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTPN.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCTPN.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTPN.Appearance.Row.Options.UseFont = true;
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPN.DetailHeight = 367;
            this.gvCTPN.GridControl = this.gcCTPN;
            this.gvCTPN.Name = "gvCTPN";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Số phiếu";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.AllowEdit = false;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Vật tư";
            this.colMAVT.ColumnEdit = this.repositoryItemVT;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // repositoryItemVT
            // 
            this.repositoryItemVT.AutoHeight = false;
            this.repositoryItemVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemVT.Name = "repositoryItemVT";
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "n0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.ContextMenuStrip = this.cmsChucNangVT;
            this.Controls.Add(this.gcCTPN);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.pncChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhap";
            this.Text = "Quản lý nhập hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            this.cmsChucNangVT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS DS;
        private DSTableAdapters.PhieuNhapTableAdapter PHIEUNHAPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMASODDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtMAPN;
        private DevExpress.XtraEditors.DateEdit detNGAY;
        private System.Windows.Forms.ComboBox cmbHOTENNV;
        private System.Windows.Forms.ComboBox cmbTENKHO;
        private System.Windows.Forms.BindingSource bdsHOTENNV;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private System.Windows.Forms.BindingSource bdsKHO;
        private DSTableAdapters.KhoTableAdapter KHOTableAdapter;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.ComboBox cmbNHACC;
        private System.Windows.Forms.BindingSource bdsDH;
        private DSTableAdapters.DatHangTableAdapter DATHANGTableAdapter;
        private System.Windows.Forms.TextBox txtMASODDH;
        private System.Windows.Forms.BindingSource bdsVT;
        private DSTableAdapters.VattuTableAdapter VATTUTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsChucNangVT;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemVT;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
    }
}