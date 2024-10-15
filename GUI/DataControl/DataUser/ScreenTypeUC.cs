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
    public partial class ScreenTypeUC : UserControl
    {
        public ScreenTypeUC()
        {
            InitializeComponent();
            LoadScreenType();
        }
        public void LoadScreenType()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            LoaiManHinhBLL lmhBLL = new LoaiManHinhBLL();

            DataTable pDT = lmhBLL.GetListScreen();
            dtgvScreenType.DataSource = pDT;
            DataBindings(pDT);
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ
            txtScreenTypeID.DataBindings.Clear();
            txtScreenTypeName.DataBindings.Clear();
           

            // Thiết lập binding cho các TextBox từ BindingSource
            txtScreenTypeID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtScreenTypeName.DataBindings.Add("Text", pDT, "TenMH", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }
    }
}
