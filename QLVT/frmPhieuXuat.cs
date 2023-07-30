using DevExpress.CodeParser.Diagnostics;
using DevExpress.Utils.Extensions;
using QLVT.DSTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmPhieuXuat : Form, IFormThongTinVatTu
    {
        private int viTri;

        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            KHOTableAdapter.Fill(DS.Kho);

            HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            HOTENNVTableAdapter.Fill(DS.HOTENNV);

            PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);

            VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            VATTUTableAdapter.Fill(DS.Vattu);

            CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            CTPXTableAdapter.Fill(DS.CTPX);
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsPX.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
            if (Program.mNhom == "CONGTY") btnThem.Enabled = btnXoa.Enabled = btnChiTiet.Enabled = false;
            else cmbChiNhanh.Enabled = false;
            // TẢI DỮ LIỆU VÀO REPOSITORY-ITEM.
            repositoryItemVT.DataSource = bdsVT;
            repositoryItemVT.DisplayMember = "TENVT";
            repositoryItemVT.ValueMember = "MAVT";
            // TẢI DỮ LIỆU VÀO COMBOBOX CHI NHÁNH.
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        private void cmbHOTENNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHOTENNV.SelectedIndex != -1 && cmbHOTENNV.SelectedValue.ToString() != "System.Data.DataRowView")
                txtMANV.Text = cmbHOTENNV.SelectedValue.ToString();
        }

        private void cmbTENKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTENKHO.SelectedIndex != -1 && cmbTENKHO.SelectedValue.ToString() != "System.Data.DataRowView")
                txtMAKHO.Text = cmbTENKHO.SelectedValue.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKHO.Count == 0)
            {
                Program.WarningMessage("Không thể lập phiếu. Hiện tại chi nhánh không có kho hàng nào!");
                return;
            }
            // LƯU TRỮ VỊ TRÍ TRƯỚC KHI THAO TÁC.
            viTri = bdsPX.Position;
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH KHI THÊM.
            bdsPX.AddNew();
            detNGAY.DateTime = DateTime.Today;
            cmbHOTENNV.SelectedValue = Program.username;
            cmbTENKHO.SelectedIndex = -1; cmbTENKHO.SelectedIndex = 0;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcPhieuXuat.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrWhiteSpace(txtMAPX.Text))
            {
                Program.WarningMessage("Số phiếu không thể trống!");
                txtMAPX.Focus();
                return;
            }

            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_CARD_CODE '{txtMAPX.Text}', 'X'");
            try
            {
                if (Program.myReader.Read())
                {
                    Program.WarningMessage("Số phiếu đã tồn tại!");
                    txtMAPX.Focus();
                    return;
                }
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }

            if (string.IsNullOrEmpty(txtHOTENKH.Text))
            {
                Program.WarningMessage("Họ tên khách hàng không thể trống!");
                txtHOTENKH.Focus();
                return;
            }
            // THỰC HIỆN GHI.
            try
            {
                bdsPX.EndEdit();
                bdsPX.ResetCurrentItem();
                PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUXUATTableAdapter.Update(DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcPhieuXuat.Enabled = true;
            pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            bdsCTPX.Filter = $"MAPX = '{gvPhieuXuat.GetFocusedRowCellValue("MAPX")}'";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Phiếu xuất này đã được lập vật tư!");
                return;
            }
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maPX = "";
            try
            {
                maPX = (bdsPX.Current as DataRowView)["MAPX"].ToString();
                bdsPX.RemoveCurrent();
                PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUXUATTableAdapter.Update(DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);
                bdsPX.Position = bdsPX.Find("MAPX", maPX);
                return;
            }
            if (bdsPX.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPX.EndEdit();
            btnReload_ItemClick(sender, e);
            bdsPX.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            gcPhieuXuat.Enabled = true; pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsPX.Count > 0) btnXoa.Enabled = btnChiTiet.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                HOTENNVTableAdapter.Fill(DS.HOTENNV);
                KHOTableAdapter.Fill(DS.Kho);
                PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);

                VATTUTableAdapter.Fill(DS.Vattu);
                CTPXTableAdapter.Fill(DS.CTPX);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.Today.CompareTo(detNGAY.DateTime) > 0)
            {
                Program.WarningMessage("Vật tư trong phiếu chỉ có thể hiệu chỉnh trong ngày lập phiếu!");
                return;
            }
            gcPhieuXuat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = gcCTPX.Enabled;
            gcCTPX.Enabled = cmsChucNangVT.Enabled = !gcCTPX.Enabled;
            if (cmsChucNangVT.Enabled)
            {
                btnThemVT.Enabled = true;
                if (bdsCTPX.Count > 0) btnXoaVT.Enabled = btnSuaVT.Enabled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMAPX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtHOTENKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || char.IsWhiteSpace(e.KeyChar) && (txtHOTENKH.SelectionStart == 0 || txtHOTENKH.Text[txtHOTENKH.SelectionStart - 1] == ' '
                || (txtHOTENKH.SelectionStart != txtHOTENKH.Text.Length && txtHOTENKH.Text[txtHOTENKH.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (bdsCTPX.Count == bdsVT.Count)
            {
                Program.WarningMessage("Toàn bộ vật tư đã được xuất hàng!");
                return;
            }

            bdsVT.Filter = "SOLUONGTON > 0";
            if (bdsVT.Count == 0)
            {
                Program.WarningMessage("Kho hiện đang trống!");
                bdsVT.Filter = null;
                return;
            }

            string maPX = (bdsPX.Current as DataRowView).Row["MAPX"].ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("MAVT"); dt.Columns.Add("TENVT"); dt.Columns.Add("SOLUONG");
            foreach (DataRowView dr in bdsVT)
            {
                if (bdsCTPX.Find("MAVT", dr["MAVT"].ToString()) == -1) 
                    dt.Rows.Add(dr["MAVT"], dr["TENVT"], dr["SOLUONGTON"]);
            }
            dt.DefaultView.Sort = "TENVT ASC";
            bdsVT.Filter = null;

            bdsCTPX.AddNew();
            new frmNhapXuatVatTu(maPX, dt, this).Show();
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maVT = (bdsCTPX.Current as DataRowView)["MAVT"].ToString(),
                soLuong = (bdsCTPX.Current as DataRowView)["SOLUONG"].ToString();
            try
            {
                bdsCTPX.RemoveCurrent();
                CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPXTableAdapter.Update(DS.CTPX);
                Program.ExecSqlNonQuery($"EXEC SP_UPDATE_INVENTORY '{maVT}', {soLuong}");
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                CTPXTableAdapter.Fill(DS.CTPX);
                return;
            }
            if (bdsCTPX.Count == 0) btnXoaVT.Enabled = btnSuaVT.Enabled = false;
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            object[] oldData = (bdsCTPX.Current as DataRowView).Row.ItemArray;
            new frmHieuChinhVatTu(oldData,
                Convert.ToInt32(oldData[2]) + Convert.ToInt32((bdsVT[bdsVT.Find("MAVT", oldData[1])] as DataRowView)["SOLUONGTON"]), this).Show();
        }

        public void Confirm(object[] data)
        {
            (bdsCTPX.Current as DataRowView).Row.ItemArray = data;
            // THỰC HIỆN GHI.
            try
            {
                bdsCTPX.EndEdit();
                bdsCTPX.ResetCurrentItem();
                CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPXTableAdapter.Update(DS.CTPX);
                updateSoLuongVatTu(data[1].ToString(), -Convert.ToInt32(data[2]));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            btnXoaVT.Enabled = btnSuaVT.Enabled = true;
        }

        public void Destroy()
        {
            bdsCTPX.CancelEdit();
        }

        public void Change(object[] data)
        {
            object[] oldData = (bdsCTPX.Current as DataRowView).Row.ItemArray;
            // KIỂM TRA SỰ THAY ĐỔI
            if (Convert.ToInt32(oldData[2]) != Convert.ToInt32(data[2]) || Convert.ToDecimal(oldData[3]) != Convert.ToDecimal(data[3]))
            {
                (bdsCTPX.Current as DataRowView).Row.ItemArray = data;
                // THỰC HIỆN GHI.
                try
                {
                    bdsCTPX.EndEdit();
                    bdsCTPX.ResetCurrentItem();
                    CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    CTPXTableAdapter.Update(DS.CTPX);
                    // KIỂM TRA SỰ THAY ĐỔI SỐ LƯỢNG TỒN.
                    int luongChenhLech = Convert.ToInt32(oldData[2]) - Convert.ToInt32(data[2]);
                    if (luongChenhLech != 0) updateSoLuongVatTu(data[1].ToString(), luongChenhLech);
                }
                catch (Exception ex)
                {
                    Program.ErrorMessage(ex.Message);
                    return;
                }
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
            if (!Program.KetNoi()) Program.ErrorMessage("Lỗi kết nối về chi nhánh khác!");
            else
            {
                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Fill(DS.Kho);

                HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                HOTENNVTableAdapter.Fill(DS.HOTENNV);

                PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUXUATTableAdapter.Fill(DS.PhieuXuat);

                VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                VATTUTableAdapter.Fill(DS.Vattu);

                CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPXTableAdapter.Fill(DS.CTPX);
            }
        }

        private void gvPhieuXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bdsCTPX.Filter = $"MAPX = '{gvPhieuXuat.GetFocusedRowCellValue("MAPX")}'";
        }

        private void updateSoLuongVatTu(string maVT, int soLuong)
        {
            Program.ExecSqlNonQuery($"EXEC SP_UPDATE_INVENTORY '{maVT}', {soLuong}");
            VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            VATTUTableAdapter.Fill(DS.Vattu);
        }
    }
}
