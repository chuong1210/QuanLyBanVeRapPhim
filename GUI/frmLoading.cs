using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            guna2ProgressIndicator1.Start(); // Bắt đầu spinner
            guna2ProgressIndicator1.ProgressColor = Color.MediumSlateBlue;
            guna2ProgressIndicator1.Location = new Point((this.Width - 80) / 2, (this.Height - 80) / 2);

            guna2ProgressIndicator1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
