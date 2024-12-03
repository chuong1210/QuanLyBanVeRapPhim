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

            xrChart1.Series.Clear();

            // Tạo Series 1 - Line Chart
            var lineSeries = new DevExpress.XtraCharts.Series("Doanh thu (Line)", DevExpress.XtraCharts.ViewType.Line);
            lineSeries.ArgumentDataMember = "Ngay"; // Trục X là ngày
            lineSeries.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" }); // Trục Y là tổng doanh thu
            lineSeries.View = new DevExpress.XtraCharts.LineSeriesView(); // Giao diện là Line Chart
            xrChart1.Series.Add(lineSeries);

            // Tạo Series 2 - Bar Chart
            var barSeries = new DevExpress.XtraCharts.Series("Doanh thu (Bar)", DevExpress.XtraCharts.ViewType.Bar);
            barSeries.ArgumentDataMember = "Ngay"; // Trục X là ngày
            barSeries.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" }); // Trục Y là tổng doanh thu
            xrChart1.Series.Add(barSeries);

            // Tùy chỉnh View cho Bar Series (có thể không cần vì ViewType đã là Bar)
            DevExpress.XtraCharts.BarSeriesView barView = (DevExpress.XtraCharts.BarSeriesView)barSeries.View;
            barView.Color = Color.LightBlue; // Đổi màu cột nếu cần

            // Hiển thị nhãn trên cả hai Series
            lineSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            barSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;



        }

        private void ReportThongKeDT1_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            string idPhim = PidPhim.Value.ToString(); // Ví dụ: lấy id phim
            DateTime nbd = Convert.ToDateTime(PtgBd.Value); // Ví dụ: lấy ngày bắt đầu
            DateTime nkt = Convert.ToDateTime(PtgKT.Value); // Ví dụ: lấy ngày kết thúc

            // Gọi lại phương thức initData để cập nhật lại biểu đồ và dữ liệu
            initData(idPhim, nbd, nkt);
        }
    }
}
