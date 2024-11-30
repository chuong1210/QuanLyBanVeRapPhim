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
    public partial class frmThongKeDT : Form
    {
        public frmThongKeDT()
        {
            InitializeComponent();
        }
        public void printStatistical(string idPhim, DateTime nbd, DateTime nkt)
        {
            ReportThongKeDT1 rp = new ReportThongKeDT1();
            foreach (var p in rp.Parameters)
            {
                p.Visible = true;
            }
            rp.initData(idPhim, nbd, nkt);
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }
    }
}
