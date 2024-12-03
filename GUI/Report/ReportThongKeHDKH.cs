using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using DTO;
namespace GUI.Report
{
    public partial class ReportThongKeHDKH : DevExpress.XtraReports.UI.XtraReport
    {
        public List<DoanhThuMuaVeDTO> _muaVeThongKe;
        public ReportThongKeHDKH(List<DoanhThuMuaVeDTO> muaVeThongKe)

        {
            InitializeComponent();
            _muaVeThongKe = muaVeThongKe;

            // Tạo biểu đồ Combo với Bar và Line
            xrChart1.Series.Clear();

            // Tạo Series cho Bar Chart (Tên phim và số lượng vé)
            Series barSeries = new Series("Số lượng vé theo phim", ViewType.Bar);
            foreach (var data in muaVeThongKe)
            {
                barSeries.Points.Add(new SeriesPoint(data.TenPhim, data.SoLuong));  // Tên phim làm trục X, Số lượng vé làm trục Y
            }

            // Tạo Series cho Line Chart (Ngày mua và số lượng vé)
            Series lineSeries = new Series("Số lượng vé theo ngày", ViewType.Line);
            foreach (var data in muaVeThongKe)
            {
                lineSeries.Points.Add(new SeriesPoint(data.NgayMua, data.SoLuong));  // Ngày mua làm trục X, Số lượng vé làm trục Y
            }

            // Thêm các series vào biểu đồ
            xrChart1.Series.Add(barSeries);
            xrChart1.Series.Add(lineSeries);

            // Cấu hình trục X và Y sử dụng Diagram
            XYDiagram diagram = (XYDiagram)xrChart1.Diagram;

            // Cấu hình trục X
            diagram.AxisX.Title.Text = "Tên Phim / Ngày Mua";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;  // Hiển thị tiêu đề trục X
            diagram.AxisX.Label.Angle = -45;  // Đưa các nhãn trên trục X vào góc 45 độ nếu cần để tránh bị chồng lấp

            // Cấu hình trục Y
            diagram.AxisY.Title.Text = "Số Lượng Vé";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;  // Hiển thị tiêu đề trục Y

            // Liên kết dữ liệu vào biểu đồ
            xrChart1.DataSource = muaVeThongKe;

        }
    }
}
