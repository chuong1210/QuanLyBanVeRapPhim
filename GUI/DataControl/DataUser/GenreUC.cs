using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DataControl.DataUser
{
    public partial class GenreUC : UserControl
    {
        public GenreUC()
        {
            InitializeComponent();
            LoadGenre();
        }

        public void LoadGenre()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            TheLoaiBLL tlBLL = new TheLoaiBLL();

            DataTable pDT = tlBLL.getListGenre();
            dgtvGenre.DataSource = pDT;
            DataBindings(pDT);
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ
            
            txtGenreID.DataBindings.Clear();
            txtGenreName.DataBindings.Clear();
            txtDescriptionGenre.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ BindingSource
            txtGenreID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged); // 
            txtGenreName.DataBindings.Add("Text", pDT, "TenTheLoai", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescriptionGenre.DataBindings.Add("Text", pDT, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
