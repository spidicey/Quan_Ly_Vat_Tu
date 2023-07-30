using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public interface IFormThongTinVatTu
    {
        void Confirm(object[] data);
        void Destroy();
        void Change(object[] data);
    }

    internal static class Program
    {
        // DATABASE CONNECTION.
        public static SqlConnection conn = new SqlConnection();
        // CONNECTION-STRING - SQL SERVER AUTHENTCATION MODE.
        public static string connstr;
        // CONNECTION-STRING - WINDOWS AUTHENTICATION MODE.
        public static string connstr_publisher = "Data Source=DESKTOP-OSBTFHG; Initial Catalog=QLVT_DATHANG; Integrated Security=True";
        // DATA STORAGE. (DATAREADER FORMAT)
        public static SqlDataReader myReader;

        // STORE THE INFORMATION OF CONNECTION-STRING.
        public static string servername = ""; // STORE THE SERVER NAME.
        public static string database = "QLVT_DATHANG"; // STORE THE DATABASE NAME.

        // ACCOUNT USED TO LOGIN DATABASE.
        public static string mlogin = "";
        public static string password = "";
        // STORE THE INFORMATION OF REMOTE ACCOUNT.
        public static string remoteLogin = "HTKN";
        public static string remotePassword = "thinh123";
        // STORE THE INFORMATION OF MEMBER ACCOUNT.
        public static string mloginDN = "";
        public static string passwordDN = "";
        // STORE THE INFORMATION OF STAFF FOR DISPLAYING IN STATUS STRIP.
        public static string username = "";
        public static string mHoTen = "";
        public static string mNhom = "";

        // STORE THE INFORMATION OF BRANCHES.
        public static BindingSource bds_dspm = new BindingSource();
        public static int mChiNhanh = 0;
        // STORE THE MAIN ELEMENT FOR REUSING.
        public static frmMain frmChinh;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }

        public static bool KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            try
            {
                connstr = $"Data Source={servername}; Initial Catalog={database}; User ID={mlogin}; password={password}";
                conn.ConnectionString = connstr;
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage("Lỗi kết nối cơ sở dữ liệu.\n" +
                    "Vui lòng kiểm tra thông tin đăng nhập! (Tài khoản & Mật khẩu)\n" + ex.Message);
                return false;
            }
        }

        public static SqlDataReader ExecSqlDataReader(string strCmd)
        {
            SqlDataReader reader;
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);
            sqlCmd.CommandType = CommandType.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                reader = sqlCmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                conn.Close();
                ErrorMessage(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                ErrorMessage(ex.Message);
                return null;
            }
        }

        public static int ExecSqlNonQuery(string strCmd)
        {
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                return 0;
            }
            catch (SqlException ex)
            {
                ErrorMessage(ex.Message);
                return ex.State;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void HienThiMenu()
        {
            // MAXIMIZE THE WINDOW.
            frmChinh.WindowState = FormWindowState.Maximized;
            // THAY ĐỔI THANH TRẠNG THÁI.
            frmChinh.MANV.Text = $"Mã NV: {username}";
            frmChinh.HOTEN.Text = $"Họ tên: {mHoTen}";
            frmChinh.NHOM.Text = $"Nhóm: {mNhom}";
            frmChinh.btnDangNhap.Enabled = false; frmChinh.btnDangXuat.Enabled = true;
            // PHÂN QUYỀN THANH MENU THEO NHÓM QUYỀN.
            frmChinh.ribDanhMuc.Visible = frmChinh.ribNghiepVu.Visible = true;
            if (mNhom != "USER") frmChinh.rpgTaiKhoan.Visible = frmChinh.ribBaoCao.Visible = true;
        }

        public static bool EqualString(string a, string b)
        {
            return a.Trim() == b.Trim();
        }

        public static void SuccessMessage()
        {
            MessageBox.Show("Thực thi thành công!", "Thông báo thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show("Thực thi thất bại!\n" + message, "Thông báo lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMessage(string message)
        {
            MessageBox.Show(message, "Thông báo thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ConfirmMessage()
        {
            return MessageBox.Show("Bạn có thực sự muốn thực hiện thao tác này?", "Thông báo xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
