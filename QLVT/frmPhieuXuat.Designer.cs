namespace QLVT
{
    partial class frmPhieuXuat
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
            System.Windows.Forms.Label lblHOTENKH;
            System.Windows.Forms.Label lblNGAY;
            System.Windows.Forms.Label lblMAPX;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
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
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUXUATTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.KHOTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.HOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.cmbHOTENNV = new System.Windows.Forms.ComboBox();
            this.bdsHOTENNV = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTENKHO = new System.Windows.Forms.ComboBox();
            this.bdsKHO = new System.Windows.Forms.BindingSource(this.components);
            this.txtHOTENKH = new System.Windows.Forms.TextBox();
            this.detNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPX = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.VATTUTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.cmsChucNangVT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.CTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            lblMAKHO = new System.Windows.Forms.Label();
            lblMANV = new System.Windows.Forms.Label();
            lblHOTENKH = new System.Windows.Forms.Label();
            lblNGAY = new System.Windows.Forms.Label();
            lblMAPX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            this.cmsChucNangVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemVT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMAKHO
            // 
            lblMAKHO.AutoSize = true;
            lblMAKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAKHO.Location = new System.Drawing.Point(50, 162);
            lblMAKHO.Name = "lblMAKHO";
            lblMAKHO.Size = new System.Drawing.Size(36, 17);
            lblMAKHO.TabIndex = 0;
            lblMAKHO.Text = "Kho:";
            // 
            // lblMANV
            // 
            lblMANV.AutoSize = true;
            lblMANV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMANV.Location = new System.Drawing.Point(50, 129);
            lblMANV.Name = "lblMANV";
            lblMANV.Size = new System.Drawing.Size(71, 17);
            lblMANV.TabIndex = 0;
            lblMANV.Text = "Nhân viên:";
            // 
            // lblHOTENKH
            // 
            lblHOTENKH.AutoSize = true;
            lblHOTENKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHOTENKH.Location = new System.Drawing.Point(50, 99);
            lblHOTENKH.Name = "lblHOTENKH";
            lblHOTENKH.Size = new System.Drawing.Size(82, 17);
            lblHOTENKH.TabIndex = 0;
            lblHOTENKH.Text = "Khách hàng:";
            // 
            // lblNGAY
            // 
            lblNGAY.AutoSize = true;
            lblNGAY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNGAY.Location = new System.Drawing.Point(383, 58);
            lblNGAY.Name = "lblNGAY";
            lblNGAY.Size = new System.Drawing.Size(101, 17);
            lblNGAY.TabIndex = 0;
            lblNGAY.Text = "Ngày thực hiện:";
            // 
            // lblMAPX
            // 
            lblMAPX.AutoSize = true;
            lblMAPX.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAPX.Location = new System.Drawing.Point(50, 58);
            lblMAPX.Name = "lblMAPX";
            lblMAPX.Size = new System.Drawing.Size(61, 17);
            lblMAPX.TabIndex = 0;
            lblMAPX.Text = "Số phiếu:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1062, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 729);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Size = new System.Drawing.Size(1062, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 684);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1062, 45);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 684);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.DS;
            this.bdsPX.Sort = "";
            // 
            // PHIEUXUATTableAdapter
            // 
            this.PHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.KHOTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.PHIEUXUATTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // KHOTableAdapter
            // 
            this.KHOTableAdapter.ClearBeforeFill = true;
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.bdsPX;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuXuat.Location = new System.Drawing.Point(0, 101);
            this.gcPhieuXuat.MainView = this.gvPhieuXuat;
            this.gcPhieuXuat.MenuManager = this.bmrChucNang;
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(1062, 152);
            this.gcPhieuXuat.TabIndex = 0;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuXuat});
            // 
            // gvPhieuXuat
            // 
            this.gvPhieuXuat.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhieuXuat.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPhieuXuat.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhieuXuat.Appearance.Row.Options.UseFont = true;
            this.gvPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gvPhieuXuat.DetailHeight = 367;
            this.gvPhieuXuat.GridControl = this.gcPhieuXuat;
            this.gvPhieuXuat.Name = "gvPhieuXuat";
            this.gvPhieuXuat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPhieuXuat_FocusedRowChanged);
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Số phiếu";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
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
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
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
            this.pncNhapLieu.Controls.Add(this.txtMANV);
            this.pncNhapLieu.Controls.Add(this.txtMAKHO);
            this.pncNhapLieu.Controls.Add(this.cmbHOTENNV);
            this.pncNhapLieu.Controls.Add(this.cmbTENKHO);
            this.pncNhapLieu.Controls.Add(lblMAKHO);
            this.pncNhapLieu.Controls.Add(lblMANV);
            this.pncNhapLieu.Controls.Add(lblHOTENKH);
            this.pncNhapLieu.Controls.Add(this.txtHOTENKH);
            this.pncNhapLieu.Controls.Add(lblNGAY);
            this.pncNhapLieu.Controls.Add(this.detNGAY);
            this.pncNhapLieu.Controls.Add(lblMAPX);
            this.pncNhapLieu.Controls.Add(this.txtMAPX);
            this.pncNhapLieu.Controls.Add(this.lblTieuDe);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pncNhapLieu.Enabled = false;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 253);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(733, 476);
            this.pncNhapLieu.TabIndex = 0;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.txtMANV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(469, 125);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(139, 24);
            this.txtMANV.TabIndex = 0;
            this.txtMANV.TabStop = false;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.txtMAKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHO.Location = new System.Drawing.Point(469, 155);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.ReadOnly = true;
            this.txtMAKHO.Size = new System.Drawing.Size(139, 24);
            this.txtMAKHO.TabIndex = 0;
            this.txtMAKHO.TabStop = false;
            // 
            // cmbHOTENNV
            // 
            this.cmbHOTENNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MANV", true));
            this.cmbHOTENNV.DataSource = this.bdsHOTENNV;
            this.cmbHOTENNV.DisplayMember = "HOTEN";
            this.cmbHOTENNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOTENNV.Enabled = false;
            this.cmbHOTENNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHOTENNV.FormattingEnabled = true;
            this.cmbHOTENNV.Location = new System.Drawing.Point(175, 125);
            this.cmbHOTENNV.Name = "cmbHOTENNV";
            this.cmbHOTENNV.Size = new System.Drawing.Size(254, 24);
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
            this.cmbTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MAKHO", true));
            this.cmbTENKHO.DataSource = this.bdsKHO;
            this.cmbTENKHO.DisplayMember = "TENKHO";
            this.cmbTENKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENKHO.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENKHO.FormattingEnabled = true;
            this.cmbTENKHO.Location = new System.Drawing.Point(175, 155);
            this.cmbTENKHO.Name = "cmbTENKHO";
            this.cmbTENKHO.Size = new System.Drawing.Size(254, 24);
            this.cmbTENKHO.TabIndex = 3;
            this.cmbTENKHO.ValueMember = "MAKHO";
            this.cmbTENKHO.SelectedIndexChanged += new System.EventHandler(this.cmbTENKHO_SelectedIndexChanged);
            // 
            // bdsKHO
            // 
            this.bdsKHO.DataMember = "Kho";
            this.bdsKHO.DataSource = this.DS;
            // 
            // txtHOTENKH
            // 
            this.txtHOTENKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtHOTENKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTENKH.Location = new System.Drawing.Point(175, 95);
            this.txtHOTENKH.Name = "txtHOTENKH";
            this.txtHOTENKH.Size = new System.Drawing.Size(254, 24);
            this.txtHOTENKH.TabIndex = 2;
            this.txtHOTENKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHOTENKH_KeyPress);
            // 
            // detNGAY
            // 
            this.detNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.detNGAY.EditValue = null;
            this.detNGAY.Location = new System.Drawing.Point(518, 55);
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
            this.detNGAY.Size = new System.Drawing.Size(164, 22);
            this.detNGAY.TabIndex = 0;
            this.detNGAY.TabStop = false;
            // 
            // txtMAPX
            // 
            this.txtMAPX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMAPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txtMAPX.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAPX.Location = new System.Drawing.Point(175, 54);
            this.txtMAPX.Name = "txtMAPX";
            this.txtMAPX.Size = new System.Drawing.Size(164, 24);
            this.txtMAPX.TabIndex = 1;
            this.txtMAPX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAPX_KeyPress);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(231, 29);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(221, 22);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN PHIẾU XUẤT";
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
            this.cmsChucNangVT.Size = new System.Drawing.Size(153, 74);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Enabled = false;
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnThemVT.Size = new System.Drawing.Size(152, 25);
            this.btnThemVT.Text = "Thêm vật tư";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Enabled = false;
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnXoaVT.Size = new System.Drawing.Size(152, 25);
            this.btnXoaVT.Text = "Xóa vật tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Enabled = false;
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Padding = new System.Windows.Forms.Padding(0);
            this.btnSuaVT.Size = new System.Drawing.Size(152, 20);
            this.btnSuaVT.Text = "Sửa vật tư";
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 45);
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
            this.cmbChiNhanh.Size = new System.Drawing.Size(320, 24);
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
            this.lblChiNhanh.Size = new System.Drawing.Size(73, 16);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPX.Enabled = false;
            this.gcCTPX.Location = new System.Drawing.Point(733, 253);
            this.gcCTPX.MainView = this.gvCTPX;
            this.gcCTPX.MenuManager = this.bmrChucNang;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemVT});
            this.gcCTPX.Size = new System.Drawing.Size(329, 476);
            this.gcCTPX.TabIndex = 1;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "CTPX";
            this.bdsCTPX.DataSource = this.DS;
            this.bdsCTPX.Filter = "";
            // 
            // gvCTPX
            // 
            this.gvCTPX.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTPX.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCTPX.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTPX.Appearance.Row.Options.UseFont = true;
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPX.DetailHeight = 367;
            this.gvCTPX.GridControl = this.gcCTPX;
            this.gvCTPX.Name = "gvCTPX";
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Số phiếu";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 25;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.OptionsColumn.AllowEdit = false;
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 94;
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
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 749);
            this.ContextMenuStrip = this.cmsChucNangVT;
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcPhieuXuat);
            this.Controls.Add(this.pncChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuXuat";
            this.Text = "Quản lý xuất hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            this.cmsChucNangVT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsPX;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter PHIEUXUATTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.ComboBox cmbHOTENNV;
        private System.Windows.Forms.ComboBox cmbTENKHO;
        private System.Windows.Forms.TextBox txtHOTENKH;
        private DevExpress.XtraEditors.DateEdit detNGAY;
        private System.Windows.Forms.TextBox txtMAPX;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private System.Windows.Forms.BindingSource bdsHOTENNV;
        private DSTableAdapters.KhoTableAdapter KHOTableAdapter;
        private System.Windows.Forms.BindingSource bdsKHO;
        private System.Windows.Forms.BindingSource bdsVT;
        private DSTableAdapters.VattuTableAdapter VATTUTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsChucNangVT;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private DSTableAdapters.CTPXTableAdapter CTPXTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
    }
}