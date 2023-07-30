using DevExpress.Utils.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmKho : Form
    {
        private string maCN;
        private int viTri;
        private object[] oldDataRow;

        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TẢI DỮ LIỆU VÀO COMBOBOX CHI NHÁNH.
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            // THIẾT LẬP KẾT NỐI & TẢI DỮ LIỆU.
            CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            CHINHANHTableAdapter.Fill(DS.ChiNhanh);

            KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            KHOTableAdapter.Fill(DS.Kho);

            DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            DATHANGTableAdapter.Fill(DS.DatHang);

            PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

            PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);
            // LƯU TRỮ MÃ CHI NHÁNH.
            maCN = ((DataRowView)bdsCN[0])["MACN"].ToString();
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsKHO.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = false;
            if (Program.mNhom == "CONGTY") btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            else cmbChiNhanh.Enabled = false;
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
            if (!Program.KetNoi()) Program.ErrorMessage("Lỗi kết nối về chi nhánh khác!");
            else
            {
                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Fill(DS.Kho);

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
            viTri = bdsKHO.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsKHO.AddNew();
            txtMACN.Text = maCN;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcKho.Enabled = false;
            pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // LƯU TRỮ VỊ TRÍ KHI THỰC HIỆN THAO TÁC.
            viTri = bdsKHO.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcKho.Enabled = false;
            pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = (bdsKHO.Current as DataRowView).Row.ItemArray;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrEmpty(txtMAKHO.Text))
            {
                Program.WarningMessage("Mã kho không thể trống!");
                txtMAKHO.Focus();
                return;
            }

            if (oldDataRow == null || !Program.EqualString(oldDataRow[0].ToString(), txtMAKHO.Text))
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_DEPOT_CODE '{txtMAKHO.Text}'");
                try
                {
                    if (Program.myReader.Read())
                    {
                        Program.WarningMessage("Mã kho đã tồn tại!");
                        txtMAKHO.Focus();
                        return;
                    }
                }
                finally
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }

            if (string.IsNullOrEmpty(txtTENKHO.Text))
            {
                Program.WarningMessage("Tên kho không thể trống!");
                txtMAKHO.Focus();
                return;
            }
            // KIỂM TRA TÊN KHO ĐÃ TỒN TẠI.
            if (oldDataRow == null || !Program.EqualString(oldDataRow[1].ToString(), txtTENKHO.Text))
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_DEPOT_NAME '{txtTENKHO.Text}'");
                try
                {
                    if (Program.myReader.Read())
                    {
                        Program.WarningMessage("Tên đã tồn tại!");
                        txtTENKHO.Focus();
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
                bdsKHO.EndEdit();
                bdsKHO.ResetCurrentItem();
                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Update(DS.Kho);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcKho.Enabled = true; pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ XÓA.
            if (bdsDH.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Kho này đã được lập đơn đặt hàng!");
                return;
            }

            if (bdsPN.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Kho này đã được lập phiếu nhập hàng!");
                return;
            }

            if (bdsPX.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Kho này đã được lập phiếu xuất hàng!");
                return;
            }
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maKHO = "";
            try
            {
                maKHO = (bdsKHO.Current as DataRowView)["MAKHO"].ToString();
                bdsKHO.RemoveCurrent();
                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Update(DS.Kho);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                KHOTableAdapter.Fill(DS.Kho);
                bdsKHO.Position = bdsKHO.Find("MAKHO", maKHO);
                return;
            }
            if (bdsKHO.Count == 0) btnHieuChinh.Enabled = btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKHO.EndEdit();
            btnReload_ItemClick(sender, e);
            bdsKHO.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            gcKho.Enabled = true; pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsKHO.Count > 0) btnHieuChinh.Enabled = btnXoa.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KHOTableAdapter.Fill(DS.Kho);
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

        private void txtMAKHO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTENKHO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || char.IsWhiteSpace(e.KeyChar) && (txtTENKHO.SelectionStart == 0 || txtTENKHO.Text[txtTENKHO.SelectionStart - 1] == ' '
                || (txtTENKHO.SelectionStart != txtTENKHO.Text.Length && txtTENKHO.Text[txtTENKHO.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void txtDIACHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (txtDIACHI.SelectionStart == 0 || txtDIACHI.Text[txtDIACHI.SelectionStart - 1] == ' '
                || (txtDIACHI.SelectionStart != txtDIACHI.Text.Length && txtDIACHI.Text[txtDIACHI.SelectionStart] == ' ')))
                e.Handled = true;
        }
    }
}
