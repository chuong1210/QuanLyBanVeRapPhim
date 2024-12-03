using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.DataControl.DataUser
{
    public partial class ShowTimeUC : UserControl
    {
        public ShowTimeUC()
        {
            InitializeComponent();
        }

        private void dtgvShowTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadShowTime()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            LichChieuPhimBLL lcpBLL = new LichChieuPhimBLL();

            DataTable pDT = lcpBLL.GetListShowTime();
            dtgvShowTime.DataSource = pDT;

        }

        private void ShowTimeUC_Load(object sender, EventArgs e)
        {
            LoadShowTime();
        }
    }
}
