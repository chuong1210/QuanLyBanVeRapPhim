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
            BarButtonItem minimizeButton = new BarButtonItem();
            minimizeButton.Caption = "Minimize";
            minimizeButton.ItemClick += (s, e) => this.WindowState = FormWindowState.Minimized;

            BarButtonItem maximizeButton = new BarButtonItem();
            maximizeButton.Caption = "Maximize";
            maximizeButton.ItemClick += (s, e) => this.WindowState = FormWindowState.Maximized;

            BarButtonItem closeButton = new BarButtonItem();
            closeButton.Caption = "Close";
            closeButton.ItemClick += (s, e) => this.Close();

            // Thêm các Button vào RibbonPageGroup
            RibbonPage page = new RibbonPage("Window");
            RibbonPageGroup group = new RibbonPageGroup("Actions");
            group.ItemLinks.Add(minimizeButton);
            group.ItemLinks.Add(maximizeButton);
            group.ItemLinks.Add(closeButton);

            page.Groups.Add(group);
            ribbonControl1.Pages.Add(page);  // ribbonCont

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

        }
    
        private void frmNavBar_Load(object sender, EventArgs e)
        {
          
           

        }
    }
}
