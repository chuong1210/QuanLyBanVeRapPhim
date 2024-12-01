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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using GUI.Report;

namespace GUI
{
    public partial class frmDanhSachPhim : Form
    {
        PhimBLL phimBLL = new PhimBLL();
        private bool isValueChanging = false;
        private int idValue = -1;

        public frmDanhSachPhim()
        {
            InitializeComponent();

            LoadData();

            gridView1.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "IsSelected" && e.IsGetData)
                {
                    e.Value = false; // Giá trị mặc định là không chọn
                }
            };

            //gridControl1.DataSource = phimBLL.TimPhimTheoKhoangThoiGian(datestart.DateTime, dateend.DateTime);
        }

        private void LoadData()
        {
            btnloadData.Height = 200;
            btnPrint.Height = 200;
            gridControl1.DataSource = phimBLL.DanhSachPhim();

            gridView1.PopulateColumns();

            gridView1.Columns["TenPhim"].Caption = "Tên Phim";
            gridView1.Columns["NgayKhoiChieu"].Caption = "Ngày Khởi Chiếu";
            gridView1.Columns["NgayKetThuc"].Caption = "Ngày Kết Thúc";
            gridView1.Columns["SanXuat"].Visible = false;
            gridView1.Columns["Poster"].Visible = false;
            // Thêm cột idPhim (đảm bảo idPhim hiển thị trong Grid)
            gridView1.Columns["Id"].Visible = true; // Giả sử cột IdPhim có tên là "IdPhim"
            gridView1.Columns["Id"].Caption = "ID Phim";


            // Định dạng ngày tháng
            gridView1.Columns["NgayKhoiChieu"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["NgayKhoiChieu"].DisplayFormat.FormatString = "dd/MM/yyyy";
            foreach (GridColumn column in gridView1.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa giá trị
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa tiêu đề
            }

            //GridColumn checkBoxColumn = gridView1.Columns.AddVisible("IsSelected", "Chọn");
            //checkBoxColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            //checkBoxColumn.VisibleIndex = gridView1.Columns.Count; // Đưa cột này xuống cuối
            //checkBoxColumn.Width = 50; // Điều chỉnh kích thước
            //checkBoxColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa tiêu đề

            // Tạo RepositoryItemCheckEdit cho cột IsSelected
            RepositoryItemCheckEdit checkEdit = new RepositoryItemCheckEdit();
            gridControl1.RepositoryItems.Add(checkEdit);

            // Đặt RepositoryItemCheckEdit cho cột IsSelected
            gridView1.Columns["IsSelected"].ColumnEdit = checkEdit;

        }
        private List<string> GetSelectedPhimIds()
        {
            List<string> selectedIds = new List<string>();

            // Duyệt qua tất cả các dòng trong gridView
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                // Kiểm tra giá trị checkbox (IsSelected)
                bool isSelected = (bool)gridView1.GetRowCellValue(i, "IsSelected");

                if (isSelected)
                {

                    // Lấy idPhim từ cột "IdPhim" của dòng hiện tại
                    string phimId = gridView1.GetRowCellValue(i, "Id").ToString();
                    selectedIds.Add(phimId);
                }
            }


            return selectedIds;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime startDate = datestart.DateTime; // Lấy ngày bắt đầu
            DateTime endDate = dateend.DateTime;    // Lấy ngày kết thúc

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!");
                return;
            }
            List<string> selectedPhimIds = GetSelectedPhimIds();

            // Kiểm tra xem có phim nào được chọn không
            if (selectedPhimIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một bộ phim!");
                return;
            }

            // Truyền selectedPhimIds vào frmThongKeDT
            frmReportThongKeDT frm = new frmReportThongKeDT();
            frm.printStatistical(selectedPhimIds[0], startDate, endDate);
            //  gridControl1.DataSource = phimBLL.TimPhimTheoKhoangThoiGian(startDate, endDate);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridView1.GetFocusedRow();
     
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            //if (e.Column.FieldName == "IsSelected")
            //{
            //    e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
          
            //}

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IsSelected")
            {
                bool isChecked = (bool)e.Value;  // Lấy giá trị của checkbox
                //MessageBox.Show("Checkbox is " + (isChecked ? "Checked (True)" : "Unchecked (False)"));
            }
        }
    }
}

