using DevExpress.Utils.Extensions;
using QLVT.DSTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmDatHang : Form, IFormThongTinVatTu
    {
        private int viTri;

        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            HOTENNVTableAdapter.Fill(DS.HOTENNV);

            KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            KHOTableAdapter.Fill(DS.Kho);

            DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            DATHANGTableAdapter.Fill(DS.DatHang);

            VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            VATTUTableAdapter.Fill(DS.Vattu);

            CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            CTDDHTableAdapter.Fill(DS.CTDDH);
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsDH.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
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
            viTri = bdsDH.Position;
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH KHI THÊM.
            bdsDH.AddNew();
            detNGAY.DateTime = DateTime.Today;
            cmbHOTENNV.SelectedValue = Program.username;
            cmbTENKHO.SelectedIndex = -1; cmbTENKHO.SelectedIndex = 0;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcDatHang.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrWhiteSpace(txtMASODDH.Text))
            {
                Program.WarningMessage("Số phiếu không thể trống!");
                txtMASODDH.Focus();
                return;
            }

            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_CARD_CODE '{txtMASODDH.Text}', 'D'");
            try
            {
                if (Program.myReader.Read())
                {
                    Program.WarningMessage("Số phiếu đã tồn tại!");
                    txtMASODDH.Focus();
                    return;
                }
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }

            if (string.IsNullOrEmpty(txtNHACC.Text))
            {
                Program.WarningMessage("Nhà cung cấp không thể trống!");
                txtNHACC.Focus();
                return;
            }
            // THỰC HIỆN GHI.
            try
            {
                bdsDH.EndEdit();
                bdsDH.ResetCurrentItem();
                DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                DATHANGTableAdapter.Update(DS.DatHang);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcDatHang.Enabled = true; pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            bdsCTDDH.Filter = $"MASODDH = '{gvDatHang.GetFocusedRowCellValue("MASODDH")}'";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Đơn đặt hàng này đã được lập vật tư!");
                return;
            }
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maSoDDH = "";
            try
            {
                maSoDDH = (bdsDH.Current as DataRowView)["MASODDH"].ToString();
                bdsDH.RemoveCurrent();
                DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                DATHANGTableAdapter.Update(DS.DatHang);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                DATHANGTableAdapter.Fill(DS.DatHang);
                bdsDH.Position = bdsDH.Find("MASODDH", maSoDDH);
                return;
            }
            if (bdsDH.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDH.EndEdit();
            btnReload_ItemClick(sender, e);
            bdsDH.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            gcDatHang.Enabled = true; pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsDH.Count > 0) btnXoa.Enabled = btnChiTiet.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                HOTENNVTableAdapter.Fill(DS.HOTENNV);
                KHOTableAdapter.Fill(DS.Kho);
                DATHANGTableAdapter.Fill(DS.DatHang);

                VATTUTableAdapter.Fill(DS.Vattu);
                CTDDHTableAdapter.Fill(DS.CTDDH);
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
            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_HAS_IMPORT_CARD '{txtMASODDH.Text}'");
            try
            {
                if (Program.myReader.Read())
                {
                    Program.WarningMessage("Không thể hiệu chỉnh! Đơn đặt hàng này đã được lập phiếu nhập.");
                    return;
                }
                gcDatHang.Enabled = btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = gcCTDDH.Enabled;
                gcCTDDH.Enabled = cmsChucNangVT.Enabled = !gcCTDDH.Enabled;
                if (cmsChucNangVT.Enabled)
                {
                    btnThemVT.Enabled = true;
                    if (bdsCTDDH.Count > 0) btnXoaVT.Enabled = btnSuaVT.Enabled = true;
                }
            }
            finally
            {
                Program.myReader.Close();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMASODDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtNHACC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || char.IsWhiteSpace(e.KeyChar) && (txtNHACC.SelectionStart == 0 || txtNHACC.Text[txtNHACC.SelectionStart - 1] == ' '
                || (txtNHACC.SelectionStart != txtNHACC.Text.Length && txtNHACC.Text[txtNHACC.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (bdsCTDDH.Count == bdsVT.Count)
            {
                Program.WarningMessage("Toàn bộ vật tư đã được đặt hàng!");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("MAVT"); dt.Columns.Add("TENVT"); dt.Columns.Add("SOLUONG");
            dt.DefaultView.Sort = "TENVT ASC";
            foreach (DataRowView dr in bdsVT)
            {
                if (bdsCTDDH.Find("MAVT", dr["MAVT"].ToString()) == -1) dt.Rows.Add(dr["MAVT"], dr["TENVT"], dr["SOLUONGTON"]);
            }

            bdsCTDDH.AddNew();
            new frmNhapXuatVatTu((bdsDH.Current as DataRowView).Row["MASODDH"].ToString(), dt, this).Show();
            btnThemVT.Enabled = btnSuaVT.Enabled = true;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            try
            {
                bdsCTDDH.RemoveCurrent();
                CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                CTDDHTableAdapter.Update(DS.CTDDH);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                CTDDHTableAdapter.Fill(DS.CTDDH);
                return;
            }
            if (bdsCTDDH.Count == 0) btnXoaVT.Enabled = btnSuaVT.Enabled = false;
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            object[] oldData = (bdsCTDDH.Current as DataRowView).Row.ItemArray;
            new frmHieuChinhVatTu(oldData, Convert.ToInt32((bdsVT[bdsVT.Find("MAVT", oldData[1])] as DataRowView)["SOLUONGTON"]), this).Show();
        }

        public void Confirm(object[] data)
        {
            (bdsCTDDH.Current as DataRowView).Row.ItemArray = data;
            // THỰC HIỆN GHI.
            try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();
                CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                CTDDHTableAdapter.Update(DS.CTDDH);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            btnXoaVT.Enabled = true;
        }

        public void Destroy()
        {
            bdsCTDDH.CancelEdit();
        }

        public void Change(object[] data)
        {
            object[] oldData = (bdsCTDDH.Current as DataRowView).Row.ItemArray;
            // KIỂM TRA SỰ THAY ĐỔI
            if (Convert.ToInt32(oldData[2]) != Convert.ToInt32(data[2]) || Convert.ToDecimal(oldData[3]) != Convert.ToDecimal(data[3]))
            {
                (bdsCTDDH.Current as DataRowView).Row.ItemArray = data;
                // THỰC HIỆN GHI.
                try
                {
                    bdsCTDDH.EndEdit();
                    bdsCTDDH.ResetCurrentItem();
                    CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    CTDDHTableAdapter.Update(DS.CTDDH);
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
                HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                HOTENNVTableAdapter.Fill(DS.HOTENNV);

                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Fill(DS.Kho);

                DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                DATHANGTableAdapter.Fill(DS.DatHang);

                VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                VATTUTableAdapter.Fill(DS.Vattu);

                CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                CTDDHTableAdapter.Fill(this.DS.CTDDH);
            }
        }

        private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bdsCTDDH.Filter = $"MASODDH = '{gvDatHang.GetFocusedRowCellValue("MASODDH")}'";
        }
    }
}
