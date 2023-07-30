using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Frpt_BangKeChiTietVatTu : Form
    {
        public Frpt_BangKeChiTietVatTu()
        {
            InitializeComponent();
        }

        private void Frpt_BangKeChiTietVatTu_Load(object sender, System.EventArgs e)
        {
            cmbLoai.SelectedIndex = -1; cmbLoai.SelectedIndex = 0;
        }

        private void btnPreview_Click_1(object sender, System.EventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (detNgayBatDau.DateTime.CompareTo(detNgayKetThuc.DateTime) > 0)
            {
                Program.WarningMessage("Ngày bắt đầu không thể sau ngày kết thúc!");
                return;
            }
            // THỰC HIỆN PREVIEW.
            new ReportPrintTool(new Xrpt_BangKeChiTietVatTu(cmbLoai.Text[0], detNgayBatDau.DateTime, detNgayKetThuc.DateTime)).ShowPreviewDialog();
        }

        private void btnThoat_Click_1(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
