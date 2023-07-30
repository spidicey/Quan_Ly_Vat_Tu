using System;

namespace QLVT
{
    public partial class Xrpt_BangKeChiTietVatTu : DevExpress.XtraReports.UI.XtraReport
    {

        public Xrpt_BangKeChiTietVatTu(char type, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            sqlDataSourceCTVT.Connection.ConnectionString = Program.connstr;
            sqlDataSourceCTVT.Queries[0].Parameters[0].Value = Program.mNhom;
            sqlDataSourceCTVT.Queries[0].Parameters[1].Value = type;
            sqlDataSourceCTVT.Queries[0].Parameters[2].Value = dateFrom;
            sqlDataSourceCTVT.Queries[0].Parameters[3].Value = dateTo;
            sqlDataSourceCTVT.Fill();
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH.
            lblTieuDeBaoCao.Text = $"CHI TIẾT {((type == 'N') ? "NHẬP" : "XUẤT")} VẬT TƯ";
            lblNgayBatDau.Text = dateFrom.ToString("dd/MM/yyyy"); lblNgayKetThuc.Text = dateTo.ToString("dd/MM/yyyy");
        }
    }
}
