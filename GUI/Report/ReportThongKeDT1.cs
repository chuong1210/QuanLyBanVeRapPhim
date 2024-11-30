using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BLL;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using DTO;

namespace GUI.Report
{
    public partial class ReportThongKeDT1 : DevExpress.XtraReports.UI.XtraReport
    {
        private DoanhThuBLL doanhThuBLL = new DoanhThuBLL();

        public ReportThongKeDT1()
        {
            InitializeComponent();
            PidPhim.Visible = false;

        }
        public void initData(string idPhim, DateTime nbd, DateTime nkt)
        {
            //PidPhim.Value = idPhim;
            //PtgBd.Value = nbd;
            //PtgKT.Value = nkt;

            // Lấy dữ liệu doanh thu
            List<DoanhThuDTO> data = doanhThuBLL.LayDoanhThuTheoKhoangThoiGian(nbd, nkt);

            // Kiểm tra nếu data rỗng hoặc null, thông báo lỗi và không thực hiện tiếp
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu trong khoảng thời gian này.");
                return;
            }

            // Cấu hình nguồn dữ liệu cho biểu đồ
            xrChart1.DataSource = data;

            // Kiểm tra xem Series[0] đã tồn tại chưa, nếu chưa thì tạo mới
            if (xrChart1.Series.Count == 0)
            {
                xrChart1.Series.Add(new DevExpress.XtraCharts.Series("Doanh thu", DevExpress.XtraCharts.ViewType.Line));
            }

            // Thiết lập trục X và Y
            xrChart1.Series[0].ArgumentDataMember = "Ngay"; // Trục X là ngày
            xrChart1.Series[0].ValueDataMembers[0] = "TongDoanhThu"; // Trục Y là doanh thu

            // Tùy chỉnh lại Series
            xrChart1.Series[0].Name = "Doanh thu";
            xrChart1.Series[0].View = new DevExpress.XtraCharts.LineSeriesView();
        }

        private void ReportThongKeDT1_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

        }
    }
}
