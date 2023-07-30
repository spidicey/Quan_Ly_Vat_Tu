using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmXoaTaiKhoan : Form
    {
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            ACCOUNT_STAFFTableAdapter.Connection.ConnectionString = Program.connstr;
            ACCOUNT_STAFFTableAdapter.Fill(DS.ACCOUNT_STAFF);
            // THIẾT LẬP DỮ LIỆU MẶC ĐỊNH.
            if (bdsAS.Count > 0)
            {
                cmbTaiKhoan.SelectedIndex = -1;
                cmbTaiKhoan.SelectedIndex = 0;
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            String username = cmbTaiKhoan.Text.Split(new string[] { " - " }, StringSplitOptions.None)[0];
            if (Program.EqualString(username, Program.username))
            {
                Program.WarningMessage("Bạn không thể tự xóa tài khoản của bản thân!");
                cmbTaiKhoan.Focus();
                return;
            }
            // THỰC HIỆN XÓA TÀI KHOẢN.
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            if (Program.ExecSqlNonQuery($"EXEC SP_REMOVE_ACCOUNT '{cmbTaiKhoan.SelectedValue}', '{username}'") != 0) return;
            Program.SuccessMessage();
            // LÀM MỚI VÙNG NHẬP LIỆU.
            ACCOUNT_STAFFTableAdapter.Connection.ConnectionString = Program.connstr;
            ACCOUNT_STAFFTableAdapter.Fill(DS.ACCOUNT_STAFF);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
