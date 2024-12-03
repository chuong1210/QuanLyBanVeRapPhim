using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI.Report
{
    public partial class frmReportThongKeHoaDonKH : Form
    {
        public string _idKh="";
        DoanhThuBLL dtBll = new DoanhThuBLL();

        public frmReportThongKeHoaDonKH(string idKh)
        {
            InitializeComponent();
            _idKh = idKh;
            var muaVeThongKe = dtBll.GetMuaVeThongKe(_idKh);
            ReportThongKeHDKH report = new ReportThongKeHDKH(muaVeThongKe);


            // Hiển thị báo cáo
            // Gắn Report vào DocumentViewer
            documentViewer1.DocumentSource = report;

            // Tải dữ liệu vào Report
            report.CreateDocument();
        }
    }
}
