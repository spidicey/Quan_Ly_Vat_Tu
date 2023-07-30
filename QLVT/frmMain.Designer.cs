namespace QLVT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribChucNang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeCTNX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeDDHKhongCoPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhHinhHoatDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgKetNoi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgNhanSu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSanPham = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDatHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTongHop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtmTrinhBay = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.stsThongTinNhanVien = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtmTrinhBay)).BeginInit();
            this.stsThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribChucNang
            // 
            this.ribChucNang.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(50, 46, 50, 46);
            this.ribChucNang.ExpandCollapseItem.Id = 0;
            this.ribChucNang.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribChucNang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribChucNang.ExpandCollapseItem,
            this.ribChucNang.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnNhanVien,
            this.btnKho,
            this.btnVatTu,
            this.btnDonDatHang,
            this.btnPhieuNhap,
            this.btnPhieuXuat,
            this.btnXoaTaiKhoan,
            this.btnThongKeCTNX,
            this.btnThongKeDDHKhongCoPN,
            this.btnTinhHinhHoatDong,
            this.btnTongHopNhapXuat});
            this.ribChucNang.Location = new System.Drawing.Point(0, 0);
            this.ribChucNang.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribChucNang.MaxItemId = 19;
            this.ribChucNang.Name = "ribChucNang";
            this.ribChucNang.OptionsMenuMinWidth = 550;
            this.ribChucNang.OptionsStubGlyphs.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribChucNang.OptionsStubGlyphs.UseFont = true;
            this.ribChucNang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.ribDanhMuc,
            this.ribNghiepVu,
            this.ribBaoCao});
            this.ribChucNang.Size = new System.Drawing.Size(1078, 194);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.ItemAppearance.Disabled.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDangNhap.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDangNhap.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDangNhap.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDangNhap.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDangNhap.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDangNhap.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDangNhap.LargeWidth = 80;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 2;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnTaoTaiKhoan.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnTaoTaiKhoan.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTaoTaiKhoan.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnTaoTaiKhoan.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnTaoTaiKhoan.LargeWidth = 80;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.ItemAppearance.Disabled.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDangXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDangXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDangXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDangXuat.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDangXuat.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDangXuat.LargeWidth = 80;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnNhanVien.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnNhanVien.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnNhanVien.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNhanVien.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnNhanVien.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnNhanVien.LargeWidth = 100;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho hàng";
            this.btnKho.Id = 6;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnKho.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnKho.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnKho.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKho.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnKho.LargeWidth = 80;
            this.btnKho.Name = "btnKho";
            this.btnKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật tư";
            this.btnVatTu.Id = 8;
            this.btnVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVatTu.ImageOptions.SvgImage")));
            this.btnVatTu.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnVatTu.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnVatTu.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnVatTu.ItemAppearance.Normal.Options.UseFont = true;
            this.btnVatTu.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnVatTu.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnVatTu.LargeWidth = 80;
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Caption = "Đơn đặt hàng";
            this.btnDonDatHang.Id = 9;
            this.btnDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonDatHang.ImageOptions.SvgImage")));
            this.btnDonDatHang.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDonDatHang.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDonDatHang.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDonDatHang.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDonDatHang.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnDonDatHang.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDonDatHang.LargeWidth = 100;
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonDatHang_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu nhập";
            this.btnPhieuNhap.Id = 10;
            this.btnPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuNhap.ImageOptions.SvgImage")));
            this.btnPhieuNhap.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuNhap.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPhieuNhap.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuNhap.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhieuNhap.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuNhap.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPhieuNhap.LargeWidth = 80;
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu xuất";
            this.btnPhieuXuat.Id = 11;
            this.btnPhieuXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuXuat.ImageOptions.SvgImage")));
            this.btnPhieuXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPhieuXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuXuat.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhieuXuat.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPhieuXuat.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPhieuXuat.LargeWidth = 80;
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Caption = "Xóa tài khoản";
            this.btnXoaTaiKhoan.Id = 12;
            this.btnXoaTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTaiKhoan.ImageOptions.SvgImage")));
            this.btnXoaTaiKhoan.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnXoaTaiKhoan.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnXoaTaiKhoan.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoaTaiKhoan.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnXoaTaiKhoan.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnXoaTaiKhoan.LargeWidth = 80;
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTaiKhoan_ItemClick);
            // 
            // btnThongKeCTNX
            // 
            this.btnThongKeCTNX.Caption = "Bảng kê chi tiết số lượng - giá trị hàng nhập/xuất";
            this.btnThongKeCTNX.Id = 15;
            this.btnThongKeCTNX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeCTNX.ImageOptions.SvgImage")));
            this.btnThongKeCTNX.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnThongKeCTNX.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnThongKeCTNX.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeCTNX.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThongKeCTNX.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnThongKeCTNX.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnThongKeCTNX.Name = "btnThongKeCTNX";
            this.btnThongKeCTNX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnThongKeCTNX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeCTNX_ItemClick);
            // 
            // btnThongKeDDHKhongCoPN
            // 
            this.btnThongKeDDHKhongCoPN.Caption = "Danh sách đơn đặt hàng chưa có phiếu nhập";
            this.btnThongKeDDHKhongCoPN.Id = 16;
            this.btnThongKeDDHKhongCoPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeDDHKhongCoPN.ImageOptions.SvgImage")));
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnThongKeDDHKhongCoPN.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnThongKeDDHKhongCoPN.Name = "btnThongKeDDHKhongCoPN";
            this.btnThongKeDDHKhongCoPN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnThongKeDDHKhongCoPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeDDHKhongCoPN_ItemClick);
            // 
            // btnTinhHinhHoatDong
            // 
            this.btnTinhHinhHoatDong.Caption = "Tình hình hoạt động của nhân viên";
            this.btnTinhHinhHoatDong.Id = 17;
            this.btnTinhHinhHoatDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhHinhHoatDong.ImageOptions.SvgImage")));
            this.btnTinhHinhHoatDong.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnTinhHinhHoatDong.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnTinhHinhHoatDong.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnTinhHinhHoatDong.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTinhHinhHoatDong.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnTinhHinhHoatDong.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnTinhHinhHoatDong.Name = "btnTinhHinhHoatDong";
            this.btnTinhHinhHoatDong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnTinhHinhHoatDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhHinhHoatDong_ItemClick);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "Tổng hợp nhập xuất";
            this.btnTongHopNhapXuat.Id = 18;
            this.btnTongHopNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTongHopNhapXuat.ImageOptions.SvgImage")));
            this.btnTongHopNhapXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnTongHopNhapXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnTongHopNhapXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnTongHopNhapXuat.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTongHopNhapXuat.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnTongHopNhapXuat.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnTongHopNhapXuat.LargeWidth = 80;
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongHopNhapXuat_ItemClick);
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpHeThong.Appearance.Options.UseFont = true;
            this.rbpHeThong.AppearanceSelected.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpHeThong.AppearanceSelected.Options.UseFont = true;
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgKetNoi,
            this.rpgTaiKhoan});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "HỆ THỐNG";
            // 
            // rpgKetNoi
            // 
            this.rpgKetNoi.ItemLinks.Add(this.btnDangNhap);
            this.rpgKetNoi.ItemLinks.Add(this.btnDangXuat);
            this.rpgKetNoi.Name = "rpgKetNoi";
            this.rpgKetNoi.Text = "Quản lý kết nối";
            // 
            // rpgTaiKhoan
            // 
            this.rpgTaiKhoan.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.rpgTaiKhoan.ItemLinks.Add(this.btnXoaTaiKhoan);
            this.rpgTaiKhoan.Name = "rpgTaiKhoan";
            this.rpgTaiKhoan.Text = "Quản lý tài khoản";
            this.rpgTaiKhoan.Visible = false;
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribDanhMuc.Appearance.Options.UseFont = true;
            this.ribDanhMuc.AppearanceSelected.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribDanhMuc.AppearanceSelected.Options.UseFont = true;
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgNhanSu,
            this.rpgSanPham});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "DANH MỤC";
            this.ribDanhMuc.Visible = false;
            // 
            // rpgNhanSu
            // 
            this.rpgNhanSu.ItemLinks.Add(this.btnNhanVien);
            this.rpgNhanSu.Name = "rpgNhanSu";
            this.rpgNhanSu.Text = "Quản lý nhân sự";
            // 
            // rpgSanPham
            // 
            this.rpgSanPham.ItemLinks.Add(this.btnKho);
            this.rpgSanPham.ItemLinks.Add(this.btnVatTu);
            this.rpgSanPham.Name = "rpgSanPham";
            this.rpgSanPham.Text = "Quản lý sản phẩm";
            // 
            // ribNghiepVu
            // 
            this.ribNghiepVu.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribNghiepVu.Appearance.Options.UseFont = true;
            this.ribNghiepVu.AppearanceSelected.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribNghiepVu.AppearanceSelected.Options.UseFont = true;
            this.ribNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDatHang,
            this.rpgNhapXuat});
            this.ribNghiepVu.Name = "ribNghiepVu";
            this.ribNghiepVu.Text = "NGHIỆP VỤ";
            this.ribNghiepVu.Visible = false;
            // 
            // rpgDatHang
            // 
            this.rpgDatHang.ItemLinks.Add(this.btnDonDatHang);
            this.rpgDatHang.Name = "rpgDatHang";
            this.rpgDatHang.Text = "Đặt hàng";
            // 
            // rpgNhapXuat
            // 
            this.rpgNhapXuat.ItemLinks.Add(this.btnPhieuNhap);
            this.rpgNhapXuat.ItemLinks.Add(this.btnPhieuXuat);
            this.rpgNhapXuat.Name = "rpgNhapXuat";
            this.rpgNhapXuat.Text = "Nhập/Xuất hàng";
            // 
            // ribBaoCao
            // 
            this.ribBaoCao.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribBaoCao.Appearance.Options.UseFont = true;
            this.ribBaoCao.AppearanceSelected.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribBaoCao.AppearanceSelected.Options.UseFont = true;
            this.ribBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgThongKe,
            this.rpgTongHop});
            this.ribBaoCao.Name = "ribBaoCao";
            this.ribBaoCao.Text = "BÁO CÁO";
            this.ribBaoCao.Visible = false;
            // 
            // rpgThongKe
            // 
            this.rpgThongKe.ItemLinks.Add(this.btnThongKeCTNX);
            this.rpgThongKe.ItemLinks.Add(this.btnThongKeDDHKhongCoPN);
            this.rpgThongKe.ItemLinks.Add(this.btnTinhHinhHoatDong);
            this.rpgThongKe.Name = "rpgThongKe";
            this.rpgThongKe.Text = "Thống kê";
            // 
            // rpgTongHop
            // 
            this.rpgTongHop.ItemLinks.Add(this.btnTongHopNhapXuat);
            this.rpgTongHop.Name = "rpgTongHop";
            this.rpgTongHop.Text = "Tổng hợp";
            // 
            // xtmTrinhBay
            // 
            this.xtmTrinhBay.Appearance.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtmTrinhBay.Appearance.Options.UseFont = true;
            this.xtmTrinhBay.AppearancePage.Header.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtmTrinhBay.AppearancePage.Header.Options.UseFont = true;
            this.xtmTrinhBay.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic);
            this.xtmTrinhBay.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtmTrinhBay.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.xtmTrinhBay.MdiParent = this;
            // 
            // stsThongTinNhanVien
            // 
            this.stsThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsThongTinNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsThongTinNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.stsThongTinNhanVien.Location = new System.Drawing.Point(0, 723);
            this.stsThongTinNhanVien.Name = "stsThongTinNhanVien";
            this.stsThongTinNhanVien.Size = new System.Drawing.Size(1078, 26);
            this.stsThongTinNhanVien.TabIndex = 0;
            this.stsThongTinNhanVien.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Enabled = false;
            this.MANV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV.Margin = new System.Windows.Forms.Padding(0, 4, 5, 2);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(62, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.Margin = new System.Windows.Forms.Padding(0, 4, 5, 2);
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(71, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHOM.Margin = new System.Windows.Forms.Padding(0, 4, 5, 2);
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(64, 20);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 749);
            this.Controls.Add(this.stsThongTinNhanVien);
            this.Controls.Add(this.ribChucNang);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMain.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribChucNang;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLVT";
            ((System.ComponentModel.ISupportInitialize)(this.ribChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtmTrinhBay)).EndInit();
            this.stsThongTinNhanVien.ResumeLayout(false);
            this.stsThongTinNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgKetNoi;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtmTrinhBay;
        private System.Windows.Forms.StatusStrip stsThongTinNhanVien;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDatHang;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribNghiepVu;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribBaoCao;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        public DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDonDatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSanPham;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNhanSu;
        private DevExpress.XtraBars.BarButtonItem btnXoaTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgThongKe;
        private DevExpress.XtraBars.BarButtonItem btnThongKeCTNX;
        private DevExpress.XtraBars.BarButtonItem btnThongKeDDHKhongCoPN;
        private DevExpress.XtraBars.BarButtonItem btnTinhHinhHoatDong;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTongHop;
    }
}

