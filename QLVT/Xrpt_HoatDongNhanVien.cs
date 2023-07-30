using System;

namespace QLVT
{
    public partial class Xrpt_HoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_HoatDongNhanVien(int maNV, string hoTen, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            // THIẾT LẬP KẾT NỐI VÀ TẢI DỮ LIỆU.
            sqlDataSource.Connection.ConnectionString = Program.connstr;
            sqlDataSource.Queries[0].Parameters[0].Value = maNV;
            sqlDataSource.Queries[0].Parameters[1].Value = dateFrom;
            sqlDataSource.Queries[0].Parameters[2].Value = dateTo;
            sqlDataSource.Fill();
            // THIẾT LẬP THÔNG TIN MẶC ĐỊNH.
            lblHOTENNV.Text = hoTen;
            lblNgayBatDau.Text = dateFrom.ToString("dd/MM/yyyy"); lblNgayKetThuc.Text = dateTo.ToString("dd/MM/yyyy");
        }

        private void lblTongThe_SummaryCalculated(object sender, DevExpress.XtraReports.UI.TextFormatEventArgs e)
        {
            decimal totalValue = Convert.ToDecimal(e.Value);
            e.Text = $"{totalValue:N0} đồng ({NumberToText(totalValue)} đồng)";
        }

        private string NumberToText(decimal input)
        {
            //  KHỞI TẠO DỮ LIỆU CẦN THIẾT.
            string sNumber = input.ToString("#");
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };

            int ones, tens, hundreds;
            int digitPosition = sNumber.Length; // DUYỆT TỪ CUỐI => ĐẦU.

            // CHUYỂN ĐỔI THÀNH CHUỖI.
            string output = " ";
            if (digitPosition == 0) output = unitNumbers[0] + output;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;
                while (digitPosition > 0)
                {
                    // KIỂM TRA 3 SỐ CUỐI CÒN LẠI. ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(digitPosition - 1, 1));
                    digitPosition--;
                    if (digitPosition > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(digitPosition - 1, 1));
                        digitPosition--;
                        if (digitPosition > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(digitPosition - 1, 1));
                            digitPosition--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        output = placeValues[placeValue] + output;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1)) output = "một " + output;
                    else
                    {
                        if ((ones == 5) && (tens > 0)) output = "lăm " + output;
                        else if (ones > 0) output = unitNumbers[ones] + " " + output;
                    }

                    if (tens < 0) break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) output = "lẻ " + output;
                        if (tens == 1) output = "mười " + output;
                        if (tens > 1) output = unitNumbers[tens] + " mươi " + output;
                    }

                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            output = unitNumbers[hundreds] + " trăm " + output;
                    }

                    output = " " + output;
                }
            }

            return output.Trim();
        }
    }
}
