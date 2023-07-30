using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmChuyenChiNhanh : Form
    {
        private readonly frmNhanVien parent;
        private readonly int maNV;

        public frmChuyenChiNhanh(int maNV, string hoTen, frmNhanVien parent)
        {
            Program.frmChinh.Enabled = false;
            this.maNV = maNV;
            this.parent = parent;
            InitializeComponent();
            txtNhanVien.Text = $"{maNV} - {hoTen}";
        }

        private void frmChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            OTHER_BRANCHESTableAdapter.Connection.ConnectionString = Program.connstr;
            OTHER_BRANCHESTableAdapter.Fill(DS.OTHER_BRANCHES);
            cmbChiNhanh.SelectedIndex = -1; cmbChiNhanh.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // THỰC THI CHUYỂN CHI NHÁNH.
            if (Program.ExecSqlNonQuery($"EXEC SP_CHANGE_BRANCH {maNV}, '{cmbChiNhanh.SelectedValue}'") != 0) return;
            Program.SuccessMessage();
            Program.frmChinh.Enabled = true;
            // THỰC THI RELOAD Ở FORM-MAIN.
            parent.btnReload.PerformClick();
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Close();
        }
    }
}
