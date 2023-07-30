using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btnDangNhap.PerformClick();
        }

        private Form CheckExist(Type ftype)
        {
            return Array.Find(MdiChildren, form => form.GetType() == ftype);
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap { MdiParent = this };
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan { MdiParent = this };
                f.Show();
            }
        }

        private void btnXoaTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmXoaTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmXoaTaiKhoan f = new frmXoaTaiKhoan { MdiParent = this };
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // RESET CÁC TRẠNG THÁI.
            MANV.Text = "MANV"; HOTEN.Text = "HOTEN"; NHOM.Text = "NHOM";
            btnDangNhap.Enabled = true; btnDangXuat.Enabled = false;
            rpgTaiKhoan.Visible = ribDanhMuc.Visible = ribNghiepVu.Visible = ribBaoCao.Visible = false;
            MdiChildren.ForEach(form => form.Dispose());
            // TẠO MỚI FORM ĐĂNG NHẬP.
            frmDangNhap f = new frmDangNhap { MdiParent = this };
            f.Show();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien { MdiParent = this };
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho { MdiParent = this };
                f.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu { MdiParent = this };
                f.Show();
            }
        }

        private void btnDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDatHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDatHang f = new frmDatHang { MdiParent = this };
                f.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuNhap f = new frmPhieuNhap { MdiParent = this };
                f.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat { MdiParent = this };
                f.Show();
            }
        }

        private void btnThongKeCTNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(Frpt_BangKeChiTietVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_BangKeChiTietVatTu f = new Frpt_BangKeChiTietVatTu { MdiParent = this };
                f.Show();
            }
        }

        private void btnThongKeDDHKhongCoPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ReportPrintTool(new Xrpt_DanhSachDatHangChuaNhap()).ShowPreviewDialog();
        }

        private void btnTinhHinhHoatDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(Frpt_HoatDongNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_HoatDongNhanVien f = new Frpt_HoatDongNhanVien { MdiParent = this };
                f.Show();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(Frpt_TongHopNhapXuat));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_TongHopNhapXuat f = new Frpt_TongHopNhapXuat { MdiParent = this };
                f.Show();
            }
        }
    }
}
