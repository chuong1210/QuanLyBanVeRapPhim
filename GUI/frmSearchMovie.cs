using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmSearchMovie : Form
    {
        private PhimBLL phimBLL;
        public frmSearchMovie()
        {
            InitializeComponent();
            phimBLL = new PhimBLL();
        }

        private void searchPN_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Adjust the color and offsets as needed
            Color shadowColor = Color.FromArgb(100, 0, 0, 0); // Adjust opacity and color as needed
            int shadowOffset = 5;

            // Create a rectangle to draw the raised effect on.  
            Rectangle rect = new Rectangle(0, 0, panelFilter.ClientSize.Width, panelFilter.ClientSize.Height);

            // Create a path for the panel border
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);


            // Draw the shadow
            using (Pen shadowPen = new Pen(shadowColor, 2))
            {
                g.DrawPath(shadowPen, path);
            }

            // Adjust the color for the panel itself
            Brush panelBrush = new SolidBrush(Color.White);
            g.FillPath(panelBrush, path);

            panelFilter.Region = new Region(path);// Hiển thị bóng đổ lên panelFilter
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
        }

        private void frmSearchMovie_Load(object sender, EventArgs e)
        {
            cbGenre.DataSource = phimBLL.DanhSachTheLoai();
            cbGenre.DisplayMember = "TenTheLoai";
            cbGenre.ValueMember= "TenTheLoai";
        }
    }
}
