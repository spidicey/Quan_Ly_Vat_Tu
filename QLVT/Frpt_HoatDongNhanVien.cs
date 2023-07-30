using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Frpt_HoatDongNhanVien : Form
    {
        public Frpt_HoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void Frpt_TinhHinhHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            // TẢI DỮ LIỆU VÀO COMBOBOX.
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "BRANCH_NAME";
            cmbChiNhanh.ValueMember = "SERVER_NAME";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            // THIẾT LẬP KẾT NỐI VÀI TẢI DỮ LIỆU.
            HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            HOTENNVTableAdapter.Fill(DS.HOTENNV);
            // THIẾT LẬP CHẾ ĐỘ THEO NHÓM QUYỀN.
            if (Program.mNhom != "CONGTY") cmbChiNhanh.Enabled = false;
            if (bdsHOTENNV.Count > 0)
            {
                cmbHOTENNV.SelectedIndex = -1; cmbHOTENNV.SelectedIndex = 0;
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
                HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                HOTENNVTableAdapter.Fill(DS.HOTENNV);
                if (bdsHOTENNV.Count > 0)
                {
                    cmbHOTENNV.SelectedIndex = -1; cmbHOTENNV.SelectedIndex = 0;
                }
            }
        }

        private void cmbHOTENNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHOTENNV.SelectedIndex != -1 && cmbHOTENNV.SelectedValue.ToString() != "System.Data.DataRowView")
                txtMANV.Text = cmbHOTENNV.SelectedValue.ToString();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (detNgayBatDau.DateTime.CompareTo(detNgayKetThuc.DateTime) > 0)
            {
                Program.WarningMessage("Ngày bắt đầu không thể sau ngày kết thúc!");
                return;
            }
            // THỰC HIỆN PREVIEW.
            new ReportPrintTool(new Xrpt_HoatDongNhanVien(Convert.ToInt32(cmbHOTENNV.SelectedValue), cmbHOTENNV.Text,
                detNgayBatDau.DateTime, detNgayKetThuc.DateTime)).ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
