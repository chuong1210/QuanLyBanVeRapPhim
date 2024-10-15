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
using DTO;
using DAL;
using Microsoft.VisualBasic.Devices;

namespace GUI.DataControl.DataUser
{
    public partial class MovieUC : UserControl
    {
        public MovieUC()
        {
            InitializeComponent();
            LoadMovie();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadMovie()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            PhimBLL phimBLL = new PhimBLL();
            DataTable pDT = phimBLL.getListMovie();
            dtgvMovie.DataSource = pDT;

            // Thiết lập ràng buộc dữ liệu
            DataBindings(pDT);
        }
      
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ

            txtMovieID.DataBindings.Clear();
            txtMovieName.DataBindings.Clear();
            txtMovieDescription.DataBindings.Clear();
            txtMovieLength.DataBindings.Clear();
            dtmMovieStart.DataBindings.Clear();
            dtmMovieEnd.DataBindings.Clear();
            txtMovieProductor.DataBindings.Clear();
            txtMovieDirector.DataBindings.Clear();
            txtMovieYear.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ BindingSource
            txtMovieID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged); // 
            txtMovieName.DataBindings.Add("Text", pDT, "TenPhim", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieDescription.DataBindings.Add("Text", pDT, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieLength.DataBindings.Add("Text", pDT, "NgayKhoiChieu", true, DataSourceUpdateMode.OnPropertyChanged);
            dtmMovieStart.DataBindings.Add("Value", pDT, "NgayKetThuc", true, DataSourceUpdateMode.OnPropertyChanged);
            dtmMovieEnd.DataBindings.Add("Value", pDT, "SanXuat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieProductor.DataBindings.Add("Text", pDT, "DaoDien", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieDirector.DataBindings.Add("Text", pDT, "DienVien", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieYear.DataBindings.Add("Text", pDT, "NamSX", true, DataSourceUpdateMode.OnPropertyChanged);


        }

    }
}
