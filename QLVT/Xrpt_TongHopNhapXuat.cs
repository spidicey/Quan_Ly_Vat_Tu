using System;

namespace QLVT
{
    public partial class Xrpt_TongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_TongHopNhapXuat(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            sqlDataSource.Connection.ConnectionString = Program.connstr;
            sqlDataSource.Queries[0].Parameters[0].Value = dateFrom;
            sqlDataSource.Queries[0].Parameters[1].Value = dateTo;
            sqlDataSource.Fill();
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH.
            lblNgayBatDau.Text = dateFrom.ToString("dd/MM/yyyy"); lblNgayKetThuc.Text = dateTo.ToString("dd/MM/yyyy");
        }
    }
}
