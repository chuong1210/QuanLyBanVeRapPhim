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
    public partial class RoomUC : UserControl
    {
        public RoomUC()
        {
            InitializeComponent();
            LoadCinema();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadCinema()
        {
            LoadGrid();
            LoadScreens();
        }
        public void LoadGrid()
        {
            PhongChieuBLL pcBLL = new PhongChieuBLL();

            DataTable pDT = pcBLL.GetListCinema();
            dtgvRoom.DataSource = pDT;
            DataBindings(pDT);
        }
        public void LoadScreens()
        {
            PhongChieuBLL pcBLL = new PhongChieuBLL();
            DataTable screenDT = pcBLL.GetListManHinh(); // Lấy danh sách màn hình

            cboScreen.DataSource = screenDT; // Thiết lập DataSource cho ComboBox
            cboScreen.DisplayMember = "TenMH"; // Tên trường hiển thị
            cboScreen.ValueMember = "id"; // Tên trường giá trị
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ
            txtRoomID.DataBindings.Clear();
            txtRoomName.DataBindings.Clear();
            cboScreen.DataBindings.Clear();
            txtRoomSeats.DataBindings.Clear();
            txtState.DataBindings.Clear();
            txtNumberOfRows.DataBindings.Clear();
            txtSeatsPerRow.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ BindingSource
            txtRoomID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRoomName.DataBindings.Add("Text", pDT, "TenPhong", true, DataSourceUpdateMode.OnPropertyChanged);
            cboScreen.DataBindings.Add("SelectedValue", pDT, "idManHinh", true, DataSourceUpdateMode.OnPropertyChanged); // Sửa thành SelectedValue
            txtRoomSeats.DataBindings.Add("Text", pDT, "SoGheNgoi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtState.DataBindings.Add("Text", pDT, "TrangThaiChoNgoi", true, DataSourceUpdateMode.OnPropertyChanged); // 
            txtNumberOfRows.DataBindings.Add("Text", pDT, "SoHangGhe", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSeatsPerRow.DataBindings.Add("Text", pDT, "SoCotGhe", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void dtgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
