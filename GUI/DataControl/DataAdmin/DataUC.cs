using GUI.DataControl.DataUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DataControl.DataAdmin
{
    public partial class DataUC : UserControl
    {

        public DataUC()
        {
            InitializeComponent();
        }
        private void btnScreen_Click(object sender, EventArgs e)
        {
            pnDataUC.Controls.Clear();
            ScreenTypeUC screenTypeUC = new ScreenTypeUC();
            screenTypeUC.Dock = DockStyle.Fill;
            pnDataUC.Controls.Add(screenTypeUC);


        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            pnDataUC.Controls.Clear();
            RoomUC roomUC = new RoomUC();
            roomUC.Dock = DockStyle.Fill;
            pnDataUC.Controls.Add(roomUC);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            pnDataUC.Controls.Clear();
            GenreUC genreUC = new GenreUC();
            genreUC.Dock = DockStyle.Fill;
            pnDataUC.Controls.Add(genreUC);
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            pnDataUC.Controls.Clear();
            MovieUC movieUC = new MovieUC();
            movieUC.Dock = DockStyle.Fill;
            pnDataUC.Controls.Add(movieUC);
        }
    }
}
