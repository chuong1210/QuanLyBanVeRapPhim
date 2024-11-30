using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace GUI.Report
{
    public partial class ReportThongKeDT1 : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportThongKeDT1()
        {
            InitializeComponent();
        }
        public void initData(string idPhim, DateTime nbd,DateTime nkt)
        {
            PidPhim.Value = idPhim;
            PtgBd.Value = nbd;
            PtgKT.Value = nkt;

        }
    }
}
