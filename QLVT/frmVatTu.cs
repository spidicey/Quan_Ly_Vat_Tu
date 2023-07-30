using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmVatTu : Form
    {
        private int viTri;
        private object[] oldDataRow;

        public frmVatTu()
        {
            InitializeComponent();
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI & TẢI DỮ LIỆU.
            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.DS.Vattu);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsVT.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = false;
            if (Program.mNhom == "CONGTY") btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            else if (Program.mNhom == "USER") btnInDanhSach.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // LƯU TRỮ VỊ TRÍ KHI THỰC HIỆN THAO TÁC.
            viTri = bdsVT.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsVT.AddNew();
            nudSOLUONGTON.Value = 0;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcVatTu.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // LƯU TRỮ VỊ TRÍ KHI THỰC HIỆN THAO TÁC.
            viTri = bdsVT.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcVatTu.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsVT.Current).Row.ItemArray;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrWhiteSpace(txtMAVT.Text))
            {
                Program.WarningMessage("Mã vật tư không thể trống!");
                txtMAVT.Focus();
                return;
            }
            
            if (oldDataRow == null || !Program.EqualString(oldDataRow[0].ToString(), txtMAVT.Text))
            {
                if (bdsVT.Find("MAVT", txtMAVT.Text) != -1)
                {
                    Program.WarningMessage("Mã vật tư đã tồn tại!");
                    txtMAVT.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTENVT.Text))
            {
                Program.WarningMessage("Tên vật tư không thể trống!");
                txtTENVT.Focus();
                return;
            }
            
            if (oldDataRow == null || !Program.EqualString(oldDataRow[1].ToString(), txtTENVT.Text))
            {
                if (bdsVT.Find("TENVT", txtTENVT.Text) != -1)
                {
                    Program.WarningMessage("Tên vật tư đã tồn tại!");
                    txtTENVT.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtDVT.Text))
            {
                Program.WarningMessage("Đơn vị tính không thể trống!");
                txtDVT.Focus();
                return;
            }
            // THỰC HIỆN GHI.
            try
            {
                bdsVT.EndEdit();
                bdsVT.ResetCurrentItem();
                VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                VATTUTableAdapter.Update(DS.Vattu);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            // THIẾT LẬP CHẾ ĐỘ KHI GHI.
            gcVatTu.Enabled = true; pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (Program.mNhom == "CHINHANH") btnInDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ XÓA.
            
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_MAVT '{txtMAVT.Text}'");
                try
                {
                    if (Program.myReader.Read())
                    {
                        Program.WarningMessage("Mã kho đã tồn tại!");
                        txtMAVT.Focus();
                        return;
                    }
                }
                finally
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maVT = string.Empty;
            try
            {
                maVT = (bdsVT.Current as DataRowView)["MAVT"].ToString();
                bdsVT.RemoveCurrent();
                VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                VATTUTableAdapter.Update(DS.Vattu);

            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                VATTUTableAdapter.Fill(DS.Vattu);
                bdsVT.Position = bdsVT.Find("MAVT", maVT);
                return;
            }
            if (bdsVT.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVT.CancelEdit();
            btnReload_ItemClick(sender, e);
            bdsVT.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            gcVatTu.Enabled = true; pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsVT.Count > 0) btnHieuChinh.Enabled = btnXoa.Enabled = true;
            if (Program.mNhom == "CHINHANH") btnInDanhSach.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                VATTUTableAdapter.Fill(DS.Vattu);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMAVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTENVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            || char.IsWhiteSpace(e.KeyChar) && (txtTENVT.SelectionStart == 0 || txtTENVT.Text[txtTENVT.SelectionStart - 1] == ' '
            || (txtTENVT.SelectionStart != txtTENVT.Text.Length && txtTENVT.Text[txtTENVT.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void txtDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || char.IsWhiteSpace(e.KeyChar) && (txtDVT.SelectionStart == 0 || txtDVT.Text[txtDVT.SelectionStart - 1] == ' '
                || (txtDVT.SelectionStart != txtDVT.Text.Length && txtDVT.Text[txtDVT.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnInDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ReportPrintTool(new Xrpt_DanhSachVatTu()).ShowPreviewDialog();
        }
    }
}
