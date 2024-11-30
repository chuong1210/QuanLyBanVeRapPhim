using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraGrid.Columns;

namespace GUI
{
    public partial class frmDanhSachPhim : frmNavBar
    {
        PhimBLL phimBLL = new PhimBLL();
        public frmDanhSachPhim()
        {
            InitializeComponent();
            gridControl1.DataSource = phimBLL.DanhSachPhim();

            LoadData();


            //gridControl1.DataSource = phimBLL.TimPhimTheoKhoangThoiGian(datestart.DateTime, dateend.DateTime);
        }

        private void LoadData()
        {
            btnloadData.Height = 200;
            btnPrint.Height = 200;
            gridView1.PopulateColumns();
            gridView1.Columns["TenPhim"].Caption = "Tên Phim";
            gridView1.Columns["NgayKhoiChieu"].Caption = "Ngày Khởi Chiếu";
            gridView1.Columns["NgayKetThuc"].Caption = "Ngày Kết Thúc";
            gridView1.Columns["SanXuat"].Visible = false;
            gridView1.Columns["Poster"].Visible = false;



            // Định dạng ngày tháng
            gridView1.Columns["NgayKhoiChieu"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["NgayKhoiChieu"].DisplayFormat.FormatString = "dd/MM/yyyy";
            foreach (GridColumn column in gridView1.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa giá trị
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa tiêu đề
            }
            GridColumn checkBoxColumn = gridView1.Columns.AddVisible("IsSelected", "Chọn");
            checkBoxColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            checkBoxColumn.VisibleIndex = gridView1.Columns.Count; // Đưa cột này xuống cuối
            checkBoxColumn.Width = 50; // Điều chỉnh kích thước
            checkBoxColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa tiêu đề
            gridView1.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "IsSelected" && e.IsGetData)
                {
                    e.Value = false; // Giá trị mặc định là không chọn
                }
            };
            gridView1.CellValueChanged += (sender, e) =>
            {
                if (e.Column.FieldName == "IsSelected")
                {
                    bool isChecked = (bool)e.Value;
                    int rowHandle = e.RowHandle;

                    if (isChecked)
                    {
                        Console.WriteLine($"Dòng {rowHandle} được chọn.");
                    }
                }
            };

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnloadData_Click(object sender, EventArgs e)
        {
            DateTime startDate = datestart.DateTime; // Lấy ngày bắt đầu
            DateTime endDate = dateend.DateTime;    // Lấy ngày kết thúc

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!");
                return;
            }
            gridControl1.DataSource = phimBLL.TimPhimTheoKhoangThoiGian(startDate, endDate);

        }
    }
}
