using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmDangNhap : Form
    {
        private readonly SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private bool KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return true;
            }
            catch (Exception ex)
            {
                Program.ErrorMessage("Lỗi kết nối về cơ sở dữ liệu gốc.\n" +
                    "Vui lòng kiểm tra thông tin kết nối. (Tên Server Publisher & Tên Database)\n" + ex.Message);
                return false;
            }
        }

        private void Lay_DSPM()
        {
            // KẾT NỐI VÀ TẢI DỮ LIỆU.
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM V_GET_SUBSCRIBERS", conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            // TẢI DỮ LIỆU VÀO BINDING SOURCE LƯU TRỮ DANH SÁCH PHÂN MẢNH.
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc())
            {
                Lay_DSPM();
                cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // KIỂM TRA THÔNG TIN ĐĂNG NHẬP.
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                Program.WarningMessage("Tài khoản & Mật khẩu không thể trống!");
                return;
            }
            // KẾT NỐI CƠ SỞ DỮ LIỆU & LƯU TRỮ THÔNG TIN ĐĂNG NHẬP.
            Program.mlogin = txtTaiKhoan.Text; Program.password = txtMatKhau.Text;
            if (!Program.KetNoi()) return;
            Program.mloginDN = Program.mlogin; Program.passwordDN = Program.password;
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
            // KIỂM TRA & LẤY THÔNG TIN NHÂN VIÊN ĐĂNG NHẬP.
            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_GET_INFORMATION_STAFF '{Program.mlogin}'");
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoTen = Program.myReader.GetString(1);
                Program.mNhom = Program.myReader.GetString(2);
            }
            catch
            {
                Program.ErrorMessage("Tài khoản của bạn hiện không còn hoạt động hoặc không được cấp quyền truy cập vào cơ sở dữ liệu.\n" +
                        "Vui lòng liên hệ với quản lý chi nhánh hoặc kiểm tra thông tin đăng nhập (Tài khoản & Mật khẩu).");
                return;
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }
            // ĐĂNG NHẬP THÀNH CÔNG.
            Program.HienThiMenu();
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
