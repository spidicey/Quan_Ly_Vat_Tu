using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmHieuChinhVatTu : Form
    {
        private readonly IFormThongTinVatTu parent;

        public frmHieuChinhVatTu(object[] data, int soLuongToiDa, Form parent)
        {
            Program.frmChinh.Enabled = false;
            this.parent = parent as IFormThongTinVatTu;
            InitializeComponent();
            // THIẾT LẬP DỮ LIỆU NHẬN ĐƯỢC.
            txtSOPHIEU.Text = data[0].ToString();
            txtMAVT.Text = data[1].ToString();
            nudSOLUONG.Value = Convert.ToInt32(data[2]);
            nudDONGIA.Value = Convert.ToDecimal(data[3]);
            if (parent.GetType() != typeof(frmDatHang)) nudSOLUONG.Maximum = soLuongToiDa;
            toolTipSOLUONG.SetToolTip(nudSOLUONG, $"Số lượng tối đa hiện tại: {soLuongToiDa}");
        }

        private void btnXacNhan_Click(object sender, System.EventArgs e)
        {
            parent.Change(new object[] { txtSOPHIEU.Text, txtMAVT.Text, nudSOLUONG.Value, nudDONGIA.Value });
            Program.frmChinh.Enabled = true;
            Close();
        }

        private void btnHuyBo_Click(object sender, System.EventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Close();
        }
    }
}
