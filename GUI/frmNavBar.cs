using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using GUI.Utils;
using GUI.Report;
namespace GUI
{
    public partial class frmNavBar : Form
    {
        public frmNavBar()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful"); // Hoặc theme khác
            this.FormBorderStyle = FormBorderStyle.None;
            // Tạo các Button cho Minimize, Maximize, Close

            minimizeButton.ItemClick += (s, e) => this.WindowState = FormWindowState.Minimized;

            maximizeButton.ItemClick += (s, e) => this.WindowState = FormWindowState.Maximized;




            closeButton.ItemClick += (s, e) => this.Close();



        }



        private void bar_button_listphim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();

            frmSearchMovie lg = new frmSearchMovie("");
            lg.ShowDialog();
        }

        private void barButtonItem_out_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();

            FrmLogin lg = new FrmLogin();
            lg.ShowDialog();
        }

        private void tkHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhSachPhim frm = new frmDanhSachPhim();
            frm.Show();
        }

        private void frmNavBar_Load(object sender, EventArgs e)
        {



        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmChangePW lg = new frmChangePW(UserSession.Username);
            lg.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportDSKH lg = new frmReportDSKH();
            lg.ShowDialog();
        }

        private void btnTimphim_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportDSNV lg = new frmReportDSNV();
            lg.ShowDialog();
        }
    }
}
