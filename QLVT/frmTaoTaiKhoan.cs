using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }


        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // CHUYỂN KẾT NỐI VỀ CHI NHÁNH HIỆN TẠI ĐỐI VỚI NHÓM QUYỀN CÔNG TY.
            if (Program.mNhom == "CONGTY" && Program.mlogin != Program.mloginDN)
            {
                Program.servername = (Program.bds_dspm.List[Program.mChiNhanh] as DataRowView)["SERVER_NAME"].ToString();
                Program.mlogin = Program.mloginDN; Program.password = Program.passwordDN;
                Program.KetNoi();
            }
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            NO_ACCOUNT_STAFFTableAdapter.Connection.ConnectionString = Program.connstr;
            NO_ACCOUNT_STAFFTableAdapter.Fill(DS.NO_ACCOUNT_STAFF);
            // PHÂN QUYỀN VAI TRÒ ĐƯỢC PHÉP CHỌN.
            if (Program.mNhom == "CONGTY")
            {
                rdbCongTy.Checked = true;
                rdbUser.Enabled = rdbChiNhanh.Enabled = false;
            }
            else
            {
                rdbUser.Checked = true;
                rdbCongTy.Enabled = false;
            }
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ TẠO TÀI KHOẢN.
            if (bdsNAS.Count > 0)
            {
                cmbMaNV.SelectedIndex = -1; cmbMaNV.SelectedIndex = 0;
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                Program.WarningMessage("Tên đăng nhập không thể trống!");
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                Program.WarningMessage("Mật khẩu không thể trống!");
                txtMatKhau.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhauXacNhan.Text))
            {
                Program.WarningMessage("Mật khẩu xác nhận không thể trống!");
                txtMatKhauXacNhan.Focus();
                return;
            }

            if (txtMatKhauXacNhan.Text != txtMatKhau.Text)
            {
                Program.WarningMessage("Mật khẩu xác nhận không chính xác!");
                txtMatKhauXacNhan.Focus();
                return;
            }
            // THỰC HIỆN TẠO TÀI KHOẢN.
            string strCmd = $"EXEC SP_CREATE_ACCOUNT '{txtTenDangNhap.Text}', '{txtMatKhau.Text}', '{cmbMaNV.SelectedValue}', " +
                $"'{(rdbCongTy.Checked ? "CONGTY" : (rdbChiNhanh.Checked ? "CHINHANH" : "USER"))}'";
            if (Program.ExecSqlNonQuery(strCmd) != 0) return;
            Program.SuccessMessage();
            // LÀM MỚI VÙNG NHẬP LIỆU.
            NO_ACCOUNT_STAFFTableAdapter.Fill(DS.NO_ACCOUNT_STAFF);
            txtTenDangNhap.Text = txtMatKhau.Text = txtMatKhauXacNhan.Text = string.Empty;
            if (Program.mNhom != "CONGTY") rdbUser.Checked = true;
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ TẠO TÀI KHOẢN.
            if (bdsNAS.Count > 0)
            {
                cmbMaNV.SelectedIndex = -1; cmbMaNV.SelectedIndex = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtMatKhauXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void frmTaoTaiKhoan_Activated(object sender, EventArgs e)
        {
            try
            {
                NO_ACCOUNT_STAFFTableAdapter.Fill(DS.NO_ACCOUNT_STAFF);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }
    }
}
