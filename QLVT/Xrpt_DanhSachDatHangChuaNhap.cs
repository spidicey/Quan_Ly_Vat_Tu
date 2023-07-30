namespace QLVT
{
    public partial class Xrpt_DanhSachDatHangChuaNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachDatHangChuaNhap()
        {
            // THỰC HIỆN KẾT NỐI VÀ TẢI DỮ LIỆU.
            InitializeComponent();
            sqlDataSource.Connection.ConnectionString = Program.connstr;
            sqlDataSource.Queries[0].Parameters[0].Value = Program.mNhom;
            sqlDataSource.Fill();
        }
    }
}
