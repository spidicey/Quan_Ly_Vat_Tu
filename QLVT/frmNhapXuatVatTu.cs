using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmNhapXuatVatTu : Form
    {
        private readonly IFormThongTinVatTu parent;
        private readonly DataTable data;

        public frmNhapXuatVatTu(string code, DataTable data, Form parent)
        {
            Program.frmChinh.Enabled = false;
            this.parent = parent as IFormThongTinVatTu;
            this.data = data;
            this.data.PrimaryKey = new DataColumn[] { this.data.Columns["MAVT"] };
            InitializeComponent();
            // THIẾT LẬP DỮ LIỆU NHẬN ĐƯỢC.
            txtSOPHIEU.Text = code;
            cmbMAVT.DataSource = data;
            cmbMAVT.DisplayMember = "TENVT";
            cmbMAVT.ValueMember = "MAVT";
            cmbMAVT.SelectedIndex = -1; cmbMAVT.SelectedIndex = 0;
        }

        private void cmbMAVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMAVT.SelectedIndex != -1 && cmbMAVT.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                nudSOLUONG.Value = 1;
                if (parent.GetType() != typeof(frmDatHang)) 
                    nudSOLUONG.Maximum = Convert.ToInt32(data.Rows.Find(cmbMAVT.SelectedValue.ToString())["SOLUONG"]);
                toolTipSOLUONG.SetToolTip(nudSOLUONG, $"Số lượng tối đa hiện tại: {nudSOLUONG.Maximum}");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            parent.Confirm(new object[] { txtSOPHIEU.Text, cmbMAVT.SelectedValue, nudSOLUONG.Value, nudDONGIA.Value });
            Program.frmChinh.Enabled = true;
            Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            parent.Destroy();
            Program.frmChinh.Enabled = true;
            Close();
        }
    }
}
