using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class frmReportDSKH : Form
    {
        public frmReportDSKH()
        {
            InitializeComponent();
            ReportThongKeDT report = new ReportThongKeDT();

            // Gắn Report vào DocumentViewer
            documentViewer1.DocumentSource = report;

            // Tải dữ liệu vào Report
            report.CreateDocument();
        }
    }
}
