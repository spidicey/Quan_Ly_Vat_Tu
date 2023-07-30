namespace QLVT
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label lblMANV;
            System.Windows.Forms.Label lblMACN;
            System.Windows.Forms.Label lblNGAYSINH;
            System.Windows.Forms.Label lblLUONG;
            System.Windows.Forms.Label lblDIACHI;
            System.Windows.Forms.Label lblTRANGTHAIXOA;
            System.Windows.Forms.Label lblCMND;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QLVT.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAIXOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.nudLUONG = new System.Windows.Forms.NumericUpDown();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.ckbTRANGTHAIXOA = new System.Windows.Forms.CheckBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.detNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.lblHOTEN = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUXUATTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.DATHANGTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.CHINHANHTableAdapter = new QLVT.DSTableAdapters.ChiNhanhTableAdapter();
            lblMANV = new System.Windows.Forms.Label();
            lblMACN = new System.Windows.Forms.Label();
            lblNGAYSINH = new System.Windows.Forms.Label();
            lblLUONG = new System.Windows.Forms.Label();
            lblDIACHI = new System.Windows.Forms.Label();
            lblTRANGTHAIXOA = new System.Windows.Forms.Label();
            lblCMND = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMANV
            // 
            lblMANV.AutoSize = true;
            lblMANV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMANV.Location = new System.Drawing.Point(36, 33);
            lblMANV.Name = "lblMANV";
            lblMANV.Size = new System.Drawing.Size(66, 21);
            lblMANV.TabIndex = 0;
            lblMANV.Text = "Mã NV:";
            // 
            // lblMACN
            // 
            lblMACN.AutoSize = true;
            lblMACN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMACN.Location = new System.Drawing.Point(812, 33);
            lblMACN.Name = "lblMACN";
            lblMACN.Size = new System.Drawing.Size(100, 21);
            lblMACN.TabIndex = 0;
            lblMACN.Text = "Chi nhánh:";
            // 
            // lblNGAYSINH
            // 
            lblNGAYSINH.AutoSize = true;
            lblNGAYSINH.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNGAYSINH.Location = new System.Drawing.Point(36, 82);
            lblNGAYSINH.Name = "lblNGAYSINH";
            lblNGAYSINH.Size = new System.Drawing.Size(95, 21);
            lblNGAYSINH.TabIndex = 0;
            lblNGAYSINH.Text = "Ngày sinh:";
            // 
            // lblLUONG
            // 
            lblLUONG.AutoSize = true;
            lblLUONG.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLUONG.Location = new System.Drawing.Point(36, 181);
            lblLUONG.Name = "lblLUONG";
            lblLUONG.Size = new System.Drawing.Size(70, 21);
            lblLUONG.TabIndex = 0;
            lblLUONG.Text = "Lương:";
            // 
            // lblDIACHI
            // 
            lblDIACHI.AutoSize = true;
            lblDIACHI.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDIACHI.Location = new System.Drawing.Point(36, 229);
            lblDIACHI.Name = "lblDIACHI";
            lblDIACHI.Size = new System.Drawing.Size(73, 21);
            lblDIACHI.TabIndex = 0;
            lblDIACHI.Text = "Địa chỉ:";
            // 
            // lblTRANGTHAIXOA
            // 
            lblTRANGTHAIXOA.AutoSize = true;
            lblTRANGTHAIXOA.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTRANGTHAIXOA.Location = new System.Drawing.Point(36, 280);
            lblTRANGTHAIXOA.Name = "lblTRANGTHAIXOA";
            lblTRANGTHAIXOA.Size = new System.Drawing.Size(135, 21);
            lblTRANGTHAIXOA.TabIndex = 0;
            lblTRANGTHAIXOA.Text = "Trạng thái xóa:";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCMND.Location = new System.Drawing.Point(36, 132);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new System.Drawing.Size(65, 21);
            lblCMND.TabIndex = 0;
            lblCMND.Text = "CMND:";
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
            this.btnChuyenChiNhanh,
            this.btnInDanhSach});
            this.bmrChucNang.MainMenu = this.bar2;
            this.bmrChucNang.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenChiNhanh),
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
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 7;
            this.btnChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            this.btnChuyenChiNhanh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenChiNhanh_ItemClick);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Id = 8;
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
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            this.bdsNV.Sort = "";
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 107);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.MenuManager = this.bmrChucNang;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1062, 234);
            this.gcNhanVien.TabIndex = 0;
            this.gcNhanVien.TabStop = false;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNhanVien.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNhanVien.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNhanVien.Appearance.Row.Options.UseFont = true;
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHO,
            this.colMANV,
            this.colTEN,
            this.colSOCMND,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTRANGTHAIXOA});
            this.gvNhanVien.DetailHeight = 368;
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 28;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 104;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 28;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 104;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 28;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 104;
            // 
            // colSOCMND
            // 
            this.colSOCMND.Caption = "Số CMND";
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 28;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.OptionsColumn.AllowEdit = false;
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            this.colSOCMND.Width = 104;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 28;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 104;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 28;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 104;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.DisplayFormat.FormatString = "n0";
            this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 28;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            this.colLUONG.Width = 104;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 28;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 104;
            // 
            // colTRANGTHAIXOA
            // 
            this.colTRANGTHAIXOA.Caption = "Đã nghỉ";
            this.colTRANGTHAIXOA.FieldName = "TRANGTHAIXOA";
            this.colTRANGTHAIXOA.MinWidth = 28;
            this.colTRANGTHAIXOA.Name = "colTRANGTHAIXOA";
            this.colTRANGTHAIXOA.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAIXOA.Visible = true;
            this.colTRANGTHAIXOA.VisibleIndex = 8;
            this.colTRANGTHAIXOA.Width = 104;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.AccessibleName = "";
            this.pncNhapLieu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pncNhapLieu.Controls.Add(this.nudLUONG);
            this.pncNhapLieu.Controls.Add(lblCMND);
            this.pncNhapLieu.Controls.Add(this.txtCMND);
            this.pncNhapLieu.Controls.Add(lblTRANGTHAIXOA);
            this.pncNhapLieu.Controls.Add(this.ckbTRANGTHAIXOA);
            this.pncNhapLieu.Controls.Add(lblDIACHI);
            this.pncNhapLieu.Controls.Add(this.txtDIACHI);
            this.pncNhapLieu.Controls.Add(lblLUONG);
            this.pncNhapLieu.Controls.Add(lblNGAYSINH);
            this.pncNhapLieu.Controls.Add(this.detNGAYSINH);
            this.pncNhapLieu.Controls.Add(lblMACN);
            this.pncNhapLieu.Controls.Add(this.txtMACN);
            this.pncNhapLieu.Controls.Add(this.txtTEN);
            this.pncNhapLieu.Controls.Add(this.txtHO);
            this.pncNhapLieu.Controls.Add(this.lblHOTEN);
            this.pncNhapLieu.Controls.Add(lblMANV);
            this.pncNhapLieu.Controls.Add(this.txtMANV);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Enabled = false;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 341);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1062, 342);
            this.pncNhapLieu.TabIndex = 2;
            // 
            // nudLUONG
            // 
            this.nudLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsNV, "LUONG", true));
            this.nudLUONG.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLUONG.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLUONG.Location = new System.Drawing.Point(154, 177);
            this.nudLUONG.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLUONG.Minimum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.nudLUONG.Name = "nudLUONG";
            this.nudLUONG.Size = new System.Drawing.Size(220, 29);
            this.nudLUONG.TabIndex = 6;
            this.nudLUONG.ThousandsSeparator = true;
            this.nudLUONG.Value = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "SOCMND", true));
            this.txtCMND.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(154, 127);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(220, 29);
            this.txtCMND.TabIndex = 5;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // ckbTRANGTHAIXOA
            // 
            this.ckbTRANGTHAIXOA.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNV, "TRANGTHAIXOA", true));
            this.ckbTRANGTHAIXOA.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTRANGTHAIXOA.Location = new System.Drawing.Point(196, 278);
            this.ckbTRANGTHAIXOA.Name = "ckbTRANGTHAIXOA";
            this.ckbTRANGTHAIXOA.Size = new System.Drawing.Size(104, 25);
            this.ckbTRANGTHAIXOA.TabIndex = 8;
            this.ckbTRANGTHAIXOA.UseVisualStyleBackColor = true;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "DIACHI", true));
            this.txtDIACHI.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Location = new System.Drawing.Point(154, 226);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(599, 29);
            this.txtDIACHI.TabIndex = 7;
            this.txtDIACHI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIACHI_KeyPress);
            // 
            // detNGAYSINH
            // 
            this.detNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.detNGAYSINH.EditValue = null;
            this.detNGAYSINH.Location = new System.Drawing.Point(154, 78);
            this.detNGAYSINH.MenuManager = this.bmrChucNang;
            this.detNGAYSINH.Name = "detNGAYSINH";
            this.detNGAYSINH.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNGAYSINH.Properties.Appearance.Options.UseFont = true;
            this.detNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNGAYSINH.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.detNGAYSINH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNGAYSINH.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.detNGAYSINH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNGAYSINH.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.detNGAYSINH.Size = new System.Drawing.Size(220, 28);
            this.detNGAYSINH.TabIndex = 4;
            this.detNGAYSINH.DisableCalendarDate += new DevExpress.XtraEditors.Calendar.DisableCalendarDateEventHandler(this.detNGAYSINH_DisableCalendarDate);
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MACN", true));
            this.txtMACN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACN.Location = new System.Drawing.Point(926, 29);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.ReadOnly = true;
            this.txtMACN.Size = new System.Drawing.Size(100, 29);
            this.txtMACN.TabIndex = 0;
            this.txtMACN.TabStop = false;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.txtTEN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEN.Location = new System.Drawing.Point(657, 29);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 29);
            this.txtTEN.TabIndex = 3;
            this.txtTEN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTEN_KeyPress);
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.txtHO.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHO.Location = new System.Drawing.Point(406, 29);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(232, 29);
            this.txtHO.TabIndex = 2;
            this.txtHO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHO_KeyPress);
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.AutoSize = true;
            this.lblHOTEN.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOTEN.Location = new System.Drawing.Point(316, 33);
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(70, 21);
            this.lblHOTEN.TabIndex = 0;
            this.lblHOTEN.Text = "Họ tên:";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.txtMANV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(154, 29);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(119, 29);
            this.txtMANV.TabIndex = 1;
            this.txtMANV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMANV_KeyPress);
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "FK_PX_NhanVien";
            this.bdsPX.DataSource = this.bdsNV;
            // 
            // PHIEUXUATTableAdapter
            // 
            this.PHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdsPN.DataSource = this.bdsNV;
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "FK_DatHang_NhanVien";
            this.bdsDH.DataSource = this.bdsNV;
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
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 703);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.pncChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNGAYSINH.Properties)).EndInit();
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
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAIXOA;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.Label lblHOTEN;
        private System.Windows.Forms.TextBox txtMACN;
        private DevExpress.XtraEditors.DateEdit detNGAYSINH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.CheckBox ckbTRANGTHAIXOA;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.BindingSource bdsPX;
        private DSTableAdapters.PhieuXuatTableAdapter PHIEUXUATTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.PhieuNhapTableAdapter PHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource bdsDH;
        private DSTableAdapters.DatHangTableAdapter DATHANGTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdsCN;
        private DSTableAdapters.ChiNhanhTableAdapter CHINHANHTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private System.Windows.Forms.NumericUpDown nudLUONG;
        public DevExpress.XtraBars.BarCheckItem btnReload;
    }
}