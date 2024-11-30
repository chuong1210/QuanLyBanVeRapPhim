using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace GUI.Report
{
    public partial class ReportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoaDon()
        {
            InitializeComponent();
            xrLabel15.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}
