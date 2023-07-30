namespace QLVT
{
    partial class frmVatTu
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
            System.Windows.Forms.Label lblSOLUONGTON;
            System.Windows.Forms.Label lblTENVT;
            System.Windows.Forms.Label lblDVT;
            System.Windows.Forms.Label lblMAVT;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLVT.DS();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.VATTUTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.CTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gvVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.nudSOLUONGTON = new System.Windows.Forms.NumericUpDown();
            this.txtTENVT = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtMAVT = new System.Windows.Forms.TextBox();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            lblSOLUONGTON = new System.Windows.Forms.Label();
            lblTENVT = new System.Windows.Forms.Label();
            lblDVT = new System.Windows.Forms.Label();
            lblMAVT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSOLUONGTON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSOLUONGTON
            // 
            lblSOLUONGTON.AutoSize = true;
            lblSOLUONGTON.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOLUONGTON.Location = new System.Drawing.Point(56, 152);
            lblSOLUONGTON.Name = "lblSOLUONGTON";
            lblSOLUONGTON.Size = new System.Drawing.Size(121, 21);
            lblSOLUONGTON.TabIndex = 0;
            lblSOLUONGTON.Text = "Số lượng tồn:";
            // 
            // lblTENVT
            // 
            lblTENVT.AutoSize = true;
            lblTENVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTENVT.Location = new System.Drawing.Point(432, 32);
            lblTENVT.Name = "lblTENVT";
            lblTENVT.Size = new System.Drawing.Size(102, 21);
            lblTENVT.TabIndex = 0;
            lblTENVT.Text = "Tên vật tư:";
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDVT.Location = new System.Drawing.Point(56, 92);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new System.Drawing.Size(110, 21);
            lblDVT.TabIndex = 0;
            lblDVT.Text = "Đơn vị tính:";
            // 
            // lblMAVT
            // 
            lblMAVT.AutoSize = true;
            lblMAVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAVT.Location = new System.Drawing.Point(56, 32);
            lblMAVT.Name = "lblMAVT";
            lblMAVT.Size = new System.Drawing.Size(95, 21);
            lblMAVT.TabIndex = 0;
            lblMAVT.Text = "Mã vật tư:";
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
            this.bmrChucNang.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmrChucNang.Form = this;
            this.bmrChucNang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnInDanhSach});
            this.bmrChucNang.MainMenu = this.bar2;
            this.bmrChucNang.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInDanhSach),
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
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
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
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Id = 7;
            this.btnInDanhSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDanhSach.ImageOptions.SvgImage")));
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnInDanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSach_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 683);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Size = new System.Drawing.Size(1062, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 632);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1062, 51);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 632);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.CTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = this.CTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.VATTUTableAdapter;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVT;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 51);
            this.gcVatTu.MainView = this.gvVatTu;
            this.gcVatTu.MenuManager = this.bmrChucNang;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(1062, 290);
            this.gcVatTu.TabIndex = 5;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVatTu});
            // 
            // gvVatTu
            // 
            this.gvVatTu.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVatTu.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVatTu.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.gvVatTu.Appearance.Row.Options.UseFont = true;
            this.gvVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVatTu.GridControl = this.gcVatTu;
            this.gvVatTu.Name = "gvVatTu";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 22;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 85;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 22;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 85;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 22;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 85;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 22;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 85;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(this.nudSOLUONGTON);
            this.pncNhapLieu.Controls.Add(lblSOLUONGTON);
            this.pncNhapLieu.Controls.Add(lblTENVT);
            this.pncNhapLieu.Controls.Add(this.txtTENVT);
            this.pncNhapLieu.Controls.Add(lblDVT);
            this.pncNhapLieu.Controls.Add(this.txtDVT);
            this.pncNhapLieu.Controls.Add(lblMAVT);
            this.pncNhapLieu.Controls.Add(this.txtMAVT);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Enabled = false;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 341);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1062, 342);
            this.pncNhapLieu.TabIndex = 6;
            // 
            // nudSOLUONGTON
            // 
            this.nudSOLUONGTON.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsVT, "SOLUONGTON", true));
            this.nudSOLUONGTON.Enabled = false;
            this.nudSOLUONGTON.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSOLUONGTON.Location = new System.Drawing.Point(200, 148);
            this.nudSOLUONGTON.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSOLUONGTON.Name = "nudSOLUONGTON";
            this.nudSOLUONGTON.Size = new System.Drawing.Size(148, 29);
            this.nudSOLUONGTON.TabIndex = 4;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "TENVT", true));
            this.txtTENVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENVT.Location = new System.Drawing.Point(561, 28);
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(201, 29);
            this.txtTENVT.TabIndex = 2;
            this.txtTENVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTENVT_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "DVT", true));
            this.txtDVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(200, 88);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(148, 29);
            this.txtDVT.TabIndex = 3;
            this.txtDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDVT_KeyPress);
            // 
            // txtMAVT
            // 
            this.txtMAVT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "MAVT", true));
            this.txtMAVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAVT.Location = new System.Drawing.Point(200, 28);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(148, 29);
            this.txtMAVT.TabIndex = 1;
            this.txtMAVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAVT_KeyPress);
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVT;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVT;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVT;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 703);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVatTu";
            this.Text = "Quản lý vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSOLUONGTON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsVT;
        private DS DS;
        private DSTableAdapters.VattuTableAdapter VATTUTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.TextBox txtTENVT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtMAVT;
        private DSTableAdapters.CTPXTableAdapter CTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private System.Windows.Forms.NumericUpDown nudSOLUONGTON;
    }
}