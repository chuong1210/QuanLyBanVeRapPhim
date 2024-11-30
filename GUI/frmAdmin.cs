using GUI.DataControl.DataAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            this.Text = "Dữ Liệu";
            pnBodyAdmin.Controls.Clear();
            DataUC dataUc = new DataUC();
            dataUc.Dock = DockStyle.Fill;
            pnBodyAdmin.Controls.Add(dataUc);
        }
    }
}
