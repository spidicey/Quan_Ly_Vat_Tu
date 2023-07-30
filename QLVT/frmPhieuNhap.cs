using DevExpress.Utils.Extensions;
using DevExpress.XtraPrinting.Native;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmPhieuNhap : Form, IFormThongTinVatTu
    {
        private int viTri;
        private DataTable originalData;
        private DataTable filteredData;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void RefreshUnimportedOrders()
        {
            if (originalData.Rows.Count > 0) originalData.Clear();
            if (filteredData.Rows.Count > 0) filteredData.Clear();

            foreach (DataRowView dr in bdsDH)
            {
                originalData.Rows.Add(dr["MASODDH"], dr["NHACC"]);
                if (bdsPN.Find("MASODDH", dr["MASODDH"]) == -1) filteredData.Rows.Add(dr["MASODDH"], dr["NHACC"]);
            }
            if (bdsPN.Count > 0) cmbNHACC.SelectedValue = (bdsPN.Current as DataRowView)["MASODDH"];
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            DATHANGTableAdapter.Fill(DS.DatHang);

            KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            KHOTableAdapter.Fill(DS.Kho);

            HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            HOTENNVTableAdapter.Fill(DS.HOTENNV);

            PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

            VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            VATTUTableAdapter.Fill(DS.Vattu);

            CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            CTPNTableAdapter.Fill(DS.CTPN);
            // THIẾT LẬP CẤU TRÚC LƯU TRỮ ĐƠN ĐẶT HÀNG.
            originalData = new DataTable(); filteredData = new DataTable();
            originalData.Columns.Add("MASODDH"); originalData.Columns.Add("NHACC");
            originalData.PrimaryKey = new DataColumn[] { originalData.Columns["MASODDH"] };
            filteredData.Columns.Add("MASODDH"); filteredData.Columns.Add("NHACC");
            filteredData.PrimaryKey = new DataColumn[] { filteredData.Columns["MASODDH"] };
            filteredData.DefaultView.Sort = "NHACC ASC";
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsPN.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
            if (Program.mNhom == "CONGTY") btnThem.Enabled = btnXoa.Enabled = btnChiTiet.Enabled = false;
            else cmbChiNhanh.Enabled = false;
            // TẢI DỮ LIỆU VÀO REPOSITORY-ITEM.
            repositoryItemVT.DataSource = bdsVT;
            repositoryItemVT.DisplayMember = "TENVT";
            repositoryItemVT.ValueMember = "MAVT";
            // KẾT NỐI VÀO ORIGINAL-DATA.
            cmbNHACC.DataSource = originalData;
            cmbNHACC.DisplayMember = "NHACC";
            cmbNHACC.ValueMember = "MASODDH";
            // TẢI DỮ LIỆU VÀO DATATABLE.
            RefreshUnimportedOrders();
            // TẢI DỮ LIỆU VÀO COMBOBOX CHI NHÁNH.
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        private void cmbNHACC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNHACC.SelectedIndex != -1 && cmbNHACC.SelectedValue.ToString() != "System.Data.DataRowView")
                txtMASODDH.Text = cmbNHACC.SelectedValue.ToString();
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
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ LẬP PHIẾU NHẬP.
            if (filteredData.Rows.Count == 0)
            {
                Program.WarningMessage("Toàn bộ đơn đặt hàng đã được lập phiếu!");
                return;
            }
            // LƯU TRỮ VỊ TRÍ TRƯỚC KHI THAO TÁC.
            viTri = bdsPN.Position;
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH KHI THÊM.
            bdsPN.AddNew();
            detNGAY.DateTime = DateTime.Today;
            cmbHOTENNV.SelectedValue = Program.username;
            cmbTENKHO.SelectedIndex = -1; cmbTENKHO.SelectedIndex = 0;
            // KẾT NỐI FILTERED-DATA.
            cmbNHACC.DataSource = filteredData;
            cmbNHACC.SelectedIndex = -1; cmbNHACC.SelectedIndex = 0;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcPhieuNhap.Enabled = false; pncNhapLieu.Enabled = true;
            bmrChucNang.Items.ForEach(button => button.Enabled = false);
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrWhiteSpace(txtMAPN.Text))
            {
                Program.WarningMessage("Số phiếu nhập không thể trống!");
                txtMAPN.Focus();
                return;
            }

            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_EXIST_CARD_CODE '{txtMAPN.Text}', 'N'");
            try
            {
                if (Program.myReader.Read())
                {
                    Program.WarningMessage("Số phiếu đã tồn tại!");
                    txtMAPN.Focus();
                    return;
                }
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }
            // THỰC HIỆN GHI.
            try
            {
                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUNHAPTableAdapter.Update(DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcPhieuNhap.Enabled = true; pncNhapLieu.Enabled = false;
            bmrChucNang.Items.ForEach(button => button.Enabled = true);
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            bdsCTPN.Filter = $"MAPN = '{gvPhieuNhap.GetFocusedRowCellValue("MAPN")}'";
            // HIỆU CHỈNH DỮ LIỆU FILTERED-DATA & KẾT NỐI VÀO ORIGINAL-DATA.
            string maSoDDH = (bdsPN.Current as DataRowView)["MASODDH"].ToString();
            filteredData.Rows.Remove(filteredData.Rows.Find(maSoDDH));
            cmbNHACC.DataSource = originalData; cmbNHACC.SelectedValue = maSoDDH;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPN.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Phiếu nhập này đã được lập vật tư!");
                return;
            }
            // THỰC HIỆN XÓA.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maPN = string.Empty;
            object[] oldData = originalData.Rows.Find((bdsPN.Current as DataRowView)["MASODDH"].ToString()).ItemArray;
            try
            {
                maPN = (bdsPN.Current as DataRowView)["MAPN"].ToString();
                bdsPN.RemoveCurrent();
                PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUNHAPTableAdapter.Update(DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);
                bdsPN.Position = bdsPN.Find("MAPN", maPN);
                return;
            }
            filteredData.Rows.Add(oldData);
            if (bdsPN.Count == 0) btnXoa.Enabled = btnChiTiet.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPN.EndEdit();
            btnReload_ItemClick(sender, e);
            bdsPN.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            gcPhieuNhap.Enabled = true; pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (bdsPN.Count > 0) btnXoa.Enabled = btnChiTiet.Enabled = true;
            // KẾT NỐI VÀO ORIGINAL-DATA.
            cmbNHACC.DataSource = originalData;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DATHANGTableAdapter.Fill(DS.DatHang);

                HOTENNVTableAdapter.Fill(DS.HOTENNV);
                KHOTableAdapter.Fill(DS.Kho);
                PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

                VATTUTableAdapter.Fill(DS.Vattu);
                CTPNTableAdapter.Fill(DS.CTPN);

                RefreshUnimportedOrders();
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
            gcPhieuNhap.Enabled = btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = gcCTPN.Enabled;
            gcCTPN.Enabled = cmsChucNangVT.Enabled = !gcCTPN.Enabled;
            if (cmsChucNangVT.Enabled)
            {
                btnThemVT.Enabled = true;
                if (bdsCTPN.Count > 0) btnXoaVT.Enabled = btnSuaVT.Enabled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMAPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            string maPN = ((DataRowView)bdsPN.Current).Row["MAPN"].ToString();
            DataTable dt = Program.ExecSqlDataTable($"EXEC SP_GET_ORDERED_GOODS '{maPN}'");
            dt.DefaultView.Sort = "TENVT ASC";
            Program.conn.Close();

            if (dt.Rows.Count == 0)
            {
                Program.WarningMessage("Toàn bộ vật tư đã được nhập hàng!");
                return;
            }

            bdsCTPN.AddNew();
            new frmNhapXuatVatTu(maPN, dt, this).Show();
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            string maVT = (bdsCTPN.Current as DataRowView)["MAVT"].ToString(),
                soLuong = (bdsCTPN.Current as DataRowView)["SOLUONG"].ToString();
            if (Convert.ToInt32((bdsVT[bdsVT.Find("MAVT", maVT)] as DataRowView)["SOLUONGTON"]) < Convert.ToInt32(soLuong))
            {
                Program.ErrorMessage("Số lượng tồn không đáp ứng. Vật tư này đã được xuất hàng!");
                return;
            }
            try
            {
                bdsCTPN.RemoveCurrent();
                CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPNTableAdapter.Update(DS.CTPN);
                Program.ExecSqlNonQuery($"EXEC SP_UPDATE_INVENTORY '{maVT}', -{soLuong}");
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                CTPNTableAdapter.Fill(DS.CTPN);
                return;
            }
            if (bdsCTPN.Count == 0) btnXoaVT.Enabled = btnSuaVT.Enabled = false;
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            Program.myReader = Program.ExecSqlDataReader("SELECT SOLUONG FROM CTDDH " +
                $"WHERE MASODDH = '{((DataRowView)bdsPN.Current).Row["MASODDH"]}' AND MAVT = '{((DataRowView)bdsCTPN.Current).Row["MAVT"]}'");
            Program.myReader.Read();
            new frmHieuChinhVatTu((bdsCTPN.Current as DataRowView).Row.ItemArray, Program.myReader.GetInt32(0), this).Show();
            Program.myReader.Close();
        }

        public void Confirm(object[] data)
        {
            (bdsCTPN.Current as DataRowView).Row.ItemArray = data;
            // THỰC HIỆN GHI.
            try
            {
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();
                CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPNTableAdapter.Update(DS.CTPN);
                Program.ExecSqlNonQuery($"EXEC SP_UPDATE_INVENTORY '{data[1]}', {data[2]}");
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
            bdsCTPN.CancelEdit();
        }

        public void Change(object[] data)
        {
            object[] oldData = (bdsCTPN.Current as DataRowView).Row.ItemArray;
            // KIỂM TRA SỰ THAY ĐỔI
            if (Convert.ToInt32(oldData[2]) != Convert.ToInt32(data[2]) || Convert.ToDecimal(oldData[3]) != Convert.ToDecimal(data[3]))
            {
                (bdsCTPN.Current as DataRowView).Row.ItemArray = data;
                // THỰC HIỆN GHI.
                try
                {
                    bdsCTPN.EndEdit();
                    bdsCTPN.ResetCurrentItem();
                    CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    CTPNTableAdapter.Update(DS.CTPN);
                    // KIỂM TRA SỰ THAY ĐỔI SỐ LƯỢNG TỒN.
                    int luongChenhLech = Convert.ToInt32(data[2]) - Convert.ToInt32(oldData[2]);
                    if (luongChenhLech != 0) Program.ExecSqlNonQuery($"EXEC SP_UPDATE_INVENTORY '{data[1]}', {luongChenhLech}");
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
                DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                DATHANGTableAdapter.Fill(DS.DatHang);

                KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                KHOTableAdapter.Fill(DS.Kho);

                HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                HOTENNVTableAdapter.Fill(DS.HOTENNV);

                PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                PHIEUNHAPTableAdapter.Fill(DS.PhieuNhap);

                VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                VATTUTableAdapter.Fill(DS.Vattu);

                CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                CTPNTableAdapter.Fill(DS.CTPN);

                RefreshUnimportedOrders();
            }
        }

        private void gvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bdsCTPN.Filter = $"MAPN = '{gvPhieuNhap.GetFocusedRowCellValue("MAPN")}'";
        }


    }
}
