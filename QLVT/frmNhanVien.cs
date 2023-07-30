using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmNhanVien : Form
    {
        private string maCN;
        private int viTri;
        private object[] oldDataRow;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TẢI DỮ LIỆU VÀO COMBOBOX CHI NHÁNH.
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            // THIẾT LẬP KẾT NỐI & TẢI DỮ LIỆU.
            CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            CHINHANHTableAdapter.Fill(DS.ChiNhanh);

            NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            NHANVIENTableAdapter.Fill(DS.NHANVIEN);

            DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            DATHANGTableAdapter.Fill(DS.DatHang);

            PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

            PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);
            // LƯU TRỮ MÃ CHI NHÁNH.
            maCN = (bdsCN[0] as DataRowView)["MACN"].ToString();
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsNV.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = false;
            if (Program.mNhom == "CONGTY") btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = false;
            else
            {
                cmbChiNhanh.Enabled = false;
                if (Program.mNhom == "USER") btnInDanhSach.Enabled = false;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            // LẤY THÔNG TIN KẾT NỐI.
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            // THỰC HIỆN KẾT NỐI.
            if (!Program.KetNoi()) Program.ErrorMessage("Lỗi kết nối sang chi nhánh khác!");
            else
            {
                // THIẾT LẬP KẾT NỐI & TẢI DỮ LIỆU.
                NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                NHANVIENTableAdapter.Fill(DS.NHANVIEN);

                DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                DATHANGTableAdapter.Fill(DS.DatHang);

                PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

                PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // LƯU TRỮ VỊ TRÍ KHI THỰC HIỆN THAO TÁC.
            viTri = bdsNV.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsNV.AddNew();
            txtMACN.Text = maCN;
            detNGAYSINH.EditValue = "";
            nudLUONG.Value = nudLUONG.Minimum;
            ckbTRANGTHAIXOA.Checked = false;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcNhanVien.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // LƯU TRỮ VỊ TRÍ KHI THỰC HIỆN THAO TÁC.
            viTri = bdsNV.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcNhanVien.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = (bdsNV.Current as DataRowView).Row.ItemArray;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrEmpty(txtMANV.Text))
            {
                Program.WarningMessage("Mã nhân viên không thể trống!");
                txtMANV.Focus();
                return;
            }
            
            if (oldDataRow == null || oldDataRow[0].ToString() != txtMANV.Text)
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_STAFF_CODE '{txtMANV.Text}'");
                try
                {
                    if (Program.myReader.Read())
                    {
                        Program.WarningMessage("Mã nhân viên đã tồn tại!");
                        txtMANV.Focus();
                        return;
                    }
                }
                finally
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }

            if (string.IsNullOrWhiteSpace(txtHO.Text))
            {
                Program.WarningMessage("Họ nhân viên không thể trống!");
                txtHO.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTEN.Text))
            {
                Program.WarningMessage("Tên nhân viên không thể trống!");
                txtTEN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                Program.WarningMessage("Số CMND không thể trống!");
                txtCMND.Focus();
                return;
            }
            
            if (oldDataRow == null || oldDataRow[3].ToString() != txtCMND.Text)
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_ID_CARD '{txtCMND.Text}'");
                try
                {
                    if (Program.myReader.Read())
                    {
                        Program.WarningMessage("Số CMND đã tồn tại!");
                        txtCMND.Focus();
                        return;
                    }
                }
                finally
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
            // THỰC HIỆN GHI.
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                NHANVIENTableAdapter.Update(DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            // THIẾT LẬP CHẾ ĐỘ KHI GHI.
            gcNhanVien.Enabled = true; pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (Program.mNhom == "CHINHANH") btnInDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ XÓA.
            if (bdsDH.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Nhân viên này đã lập đơn đặt hàng!");
                return;
            }

            if (bdsPN.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Nhân viên này đã lập phiếu nhập hàng!");
                return;
            }

            if (bdsPX.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Nhân viên này đã lập phiếu xuất hàng!");
                return;
            }
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            int maNV = 0;
            try
            {
                maNV = int.Parse((bdsNV.Current as DataRowView)["MANV"].ToString());
                bdsNV.RemoveCurrent();
                NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                NHANVIENTableAdapter.Update(DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                NHANVIENTableAdapter.Fill(DS.NHANVIEN);
                bdsNV.Position = bdsNV.Find("MANV", maNV);
                return;
            }
            if (bdsNV.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.EndEdit();
            btnReload_ItemClick(sender, e);
            bdsNV.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false; gcNhanVien.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (Program.mNhom == "CHINHANH") btnInDanhSach.Enabled = true;
            if (bdsNV.Count > 0) btnHieuChinh.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NHANVIENTableAdapter.Fill(DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oldDataRow = (bdsNV.Current as DataRowView).Row.ItemArray;
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ CHUYỂN CHI NHÁNH.
            if (Convert.ToBoolean(oldDataRow[8]))
            {
                Program.WarningMessage("Nhân viên này hiện không còn làm việc!");
                return;
            }

            if (Program.EqualString(oldDataRow[0].ToString(), Program.username))
            {
                Program.WarningMessage("Bạn không thể tự chuyển bản thân!");
                return;
            }
            // THỰC HIỆN CHUYỂN CHI NHÁNH.
            new frmChuyenChiNhanh(Convert.ToInt32(oldDataRow[0]), $"{oldDataRow[1]} {oldDataRow[2]}", this).Show();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMANV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtHO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || char.IsWhiteSpace(e.KeyChar) && (txtHO.SelectionStart == 0 || txtHO.Text[txtHO.SelectionStart - 1] == ' '
                || (txtHO.SelectionStart != txtHO.Text.Length && txtHO.Text[txtHO.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void txtTEN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtDIACHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (txtDIACHI.SelectionStart == 0 || txtDIACHI.Text[txtDIACHI.SelectionStart - 1] == ' '
                || (txtDIACHI.SelectionStart != txtDIACHI.Text.Length && txtDIACHI.Text[txtDIACHI.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnInDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ReportPrintTool(new Xrpt_DanhSachNhanVien()).ShowPreviewDialog();
        }

        private void detNGAYSINH_DisableCalendarDate(object sender, DevExpress.XtraEditors.Calendar.DisableCalendarDateEventArgs e)
        {
            double isValidDate = DateTime.Today.Subtract(e.Date).TotalDays / 365.2425;
            if (isValidDate < 18 || isValidDate > 65) e.IsDisabled = true;
        }
    }
}
