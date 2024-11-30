using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace GUI.Report
{
    public partial class ReportDSNV : DevExpress.XtraReports.UI.XtraReport
    {
        private Random random = new Random();

        public ReportDSNV()
        {
            InitializeComponent();
        }

        private void xrTableCell3_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            if (cell != null)
            {
                int randomShift = random.Next(1, 4); // Random từ 1 đến 3
                cell.Text = "Ca " + randomShift;
            }
        }
    }
}
