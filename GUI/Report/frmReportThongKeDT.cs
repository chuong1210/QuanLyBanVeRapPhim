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
using DevExpress.Mvvm.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using DTO;

namespace GUI.Report
{
    public partial class frmReportThongKeDT : Form
    {
        public frmReportThongKeDT()
        {

            InitializeComponent();


        }

        private void LoadDoanhThuLenBieuDo(DateTime startDate, DateTime endDate)
        {
        }

        public void printStatistical(string idPhim, DateTime nbd, DateTime nkt)
        {

            ReportThongKeDT1 rp = new ReportThongKeDT1();
            foreach (var p in rp.Parameters)
            {
                p.Visible = true;
            }
            this.Show();

            // Thiết lập các tham số cho báo cáo
            rp.Parameters["PidPhim"].Value = idPhim;
            rp.Parameters["PtgBd"].Value = nbd;
            rp.Parameters["PtgKT"].Value = nkt;
        
            rp.initData(idPhim, nbd, nkt);
       

            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }
    }
}
