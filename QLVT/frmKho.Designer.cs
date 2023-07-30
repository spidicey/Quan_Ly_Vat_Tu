namespace QLVT
{
    partial class frmKho
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
            System.Windows.Forms.Label lblTENKHO;
            System.Windows.Forms.Label lblDIACHI;
            System.Windows.Forms.Label lblMACN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsKHO = new System.Windows.Forms.BindingSource(this.components);
            this.KHOTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtTENKHO = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUXUATTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.DATHANGTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.CHINHANHTableAdapter = new QLVT.DSTableAdapters.ChiNhanhTableAdapter();
            lblMAKHO = new System.Windows.Forms.Label();
            lblTENKHO = new System.Windows.Forms.Label();
            lblDIACHI = new System.Windows.Forms.Label();
            lblMACN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMAKHO
            // 
            lblMAKHO.AutoSize = true;
            lblMAKHO.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMAKHO.Location = new System.Drawing.Point(56, 32);
            lblMAKHO.Name = "lblMAKHO";
            lblMAKHO.Size = new System.Drawing.Size(76, 21);
            lblMAKHO.TabIndex = 0;
            lblMAKHO.Text = "Mã kho:";
            // 
            // lblTENKHO
            // 
            lblTENKHO.AutoSize = true;
            lblTENKHO.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTENKHO.Location = new System.Drawing.Point(56, 94);
            lblTENKHO.Name = "lblTENKHO";
            lblTENKHO.Size = new System.Drawing.Size(83, 21);
            lblTENKHO.TabIndex = 0;
            lblTENKHO.Text = "Tên kho:";
            // 
            // lblDIACHI
            // 
            lblDIACHI.AutoSize = true;
            lblDIACHI.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDIACHI.Location = new System.Drawing.Point(56, 157);
            lblDIACHI.Name = "lblDIACHI";
            lblDIACHI.Size = new System.Drawing.Size(73, 21);
            lblDIACHI.TabIndex = 0;
            lblDIACHI.Text = "Địa chỉ:";
            // 
            // lblMACN
            // 
            lblMACN.AutoSize = true;
            lblMACN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMACN.Location = new System.Drawing.Point(492, 32);
            lblMACN.Name = "lblMACN";
            lblMACN.Size = new System.Drawing.Size(100, 21);
            lblMACN.TabIndex = 0;
            lblMACN.Text = "Chi nhánh:";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
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
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.pncChiNhanh.Name = "pncChiNhanh";
            this.pncChiNhanh.Size = new System.Drawing.Size(1062, 56);
            this.pncChiNhanh.TabIndex = 1;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(135, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(320, 29);
            this.cmbChiNhanh.TabIndex = 1;
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKHO
            // 
            this.bdsKHO.DataMember = "Kho";
            this.bdsKHO.DataSource = this.DS;
            // 
            // KHOTableAdapter
            // 
            this.KHOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.bdsKHO;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKho.Location = new System.Drawing.Point(0, 107);
            this.gcKho.MainView = this.gvKho;
            this.gcKho.MenuManager = this.bmrChucNang;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(1062, 234);
            this.gcKho.TabIndex = 2;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKho.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvKho.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKho.Appearance.Row.Options.UseFont = true;
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gvKho.DetailHeight = 369;
            this.gvKho.GridControl = this.gcKho;
            this.gvKho.Name = "gvKho";
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 94;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.MinWidth = 25;
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHO, "MAKHO", true));
            this.txtMAKHO.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHO.Location = new System.Drawing.Point(148, 29);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(158, 29);
            this.txtMAKHO.TabIndex = 1;
            this.txtMAKHO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAKHO_KeyPress);
            // 
            // txtTENKHO
            // 
            this.txtTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHO, "TENKHO", true));
            this.txtTENKHO.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENKHO.Location = new System.Drawing.Point(148, 90);
            this.txtTENKHO.Name = "txtTENKHO";
            this.txtTENKHO.Size = new System.Drawing.Size(158, 29);
            this.txtTENKHO.TabIndex = 2;
            this.txtTENKHO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTENKHO_KeyPress);
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHO, "DIACHI", true));
            this.txtDIACHI.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Location = new System.Drawing.Point(148, 152);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(551, 29);
            this.txtDIACHI.TabIndex = 3;
            this.txtDIACHI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIACHI_KeyPress);
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHO, "MACN", true));
            this.txtMACN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACN.Location = new System.Drawing.Point(599, 29);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.ReadOnly = true;
            this.txtMACN.Size = new System.Drawing.Size(100, 29);
            this.txtMACN.TabIndex = 0;
            this.txtMACN.TabStop = false;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(lblMAKHO);
            this.pncNhapLieu.Controls.Add(lblMACN);
            this.pncNhapLieu.Controls.Add(this.txtMACN);
            this.pncNhapLieu.Controls.Add(this.txtMAKHO);
            this.pncNhapLieu.Controls.Add(lblTENKHO);
            this.pncNhapLieu.Controls.Add(lblDIACHI);
            this.pncNhapLieu.Controls.Add(this.txtDIACHI);
            this.pncNhapLieu.Controls.Add(this.txtTENKHO);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Enabled = false;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 341);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1062, 342);
            this.pncNhapLieu.TabIndex = 0;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "FK_PhieuXuat_Kho";
            this.bdsPX.DataSource = this.bdsKHO;
            // 
            // PHIEUXUATTableAdapter
            // 
            this.PHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_Kho";
            this.bdsPN.DataSource = this.bdsKHO;
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "FK_DatHang_Kho";
            this.bdsDH.DataSource = this.bdsKHO;
            // 
            // DATHANGTableAdapter
            // 
            this.DATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCN
            // 
            this.bdsCN.DataMember = "ChiNhanh";
            this.bdsCN.DataSource = this.DS;
            // 
            // CHINHANHTableAdapter
            // 
            this.CHINHANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 703);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcKho);
            this.Controls.Add(this.pncChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKho";
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.BindingSource bdsKHO;
        private DS DS;
        private DSTableAdapters.KhoTableAdapter KHOTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENKHO;
        private System.Windows.Forms.TextBox txtMAKHO;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.BindingSource bdsPX;
        private DSTableAdapters.PhieuXuatTableAdapter PHIEUXUATTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.PhieuNhapTableAdapter PHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource bdsDH;
        private DSTableAdapters.DatHangTableAdapter DATHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsCN;
        private DSTableAdapters.ChiNhanhTableAdapter CHINHANHTableAdapter;
    }
}