namespace QLVT
{
    public partial class Xrpt_DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachNhanVien()
        {
            InitializeComponent();
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            sqlDataSourceNV.Connection.ConnectionString = Program.connstr;
            sqlDataSourceNV.Fill();
        }
    }
}
