using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.Report
{
    public partial class frmReportHD : Form
    {
        public frmReportHD(List<MuaHangDTO> vps)
        {
          
            InitializeComponent();
            ReportHoaDon report = new ReportHoaDon();
            report.DataSource = vps;

            // Gắn Report vào DocumentViewer
            documentViewer1.DocumentSource = report;

            // Tải dữ liệu vào Report
            report.CreateDocument();
        }
    }
}
