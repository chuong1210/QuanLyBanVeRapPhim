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
using DAL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using GUI.Report;

namespace GUI
{
    public partial class frmDanhSachKhachHang : Form
    {
        KhachHangBLL khBll = new KhachHangBLL();

        public frmDanhSachKhachHang()
        {
            InitializeComponent();
            gridView1.OptionsFind.AlwaysVisible = true; // Hiển thị thanh tìm kiếm
            gridView1.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm..."; // Văn bản gợi ý
            gridView1.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "IsSelected" && e.IsGetData)
                {
                    e.Value = false; // Giá trị mặc định là không chọn
                }
            };
            LoadData();
   
        }


        private void LoadData()
        {
            btnloadData.Height = 200;
            btnPrint.Height = 200;
            var dds = khBll.GetAllKhachHang();

            gridControl1.DataSource = khBll.GetAllKhachHang();

            gridView1.PopulateColumns();

            gridView1.Columns["Id"].Caption = "ID";
            gridView1.Columns["HoTen"].Caption = "Họ tên";
            gridView1.Columns["NgaySinh"].Caption = "Ngày sinh";
            gridView1.Columns["Email"].Caption = "Emal";
            gridView1.Columns["GioiTinh"].Caption = "Giới tính";
            gridView1.Columns["DiaChi"].Visible = false;
            gridView1.Columns["SDT"].Visible = false;
            // Thêm cột idPhim (đảm bảo idPhim hiển thị trong Grid)



            // Định dạng ngày tháng
            gridView1.Columns["NgaySinh"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["NgaySinh"].DisplayFormat.FormatString = "dd/MM/yyyy";
            foreach (GridColumn column in gridView1.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa giá trị
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Căn giữa tiêu đề
            }

            RepositoryItemCheckEdit checkEdit = new RepositoryItemCheckEdit();
            gridControl1.RepositoryItems.Add(checkEdit);

            // Đặt RepositoryItemCheckEdit cho cột IsSelected
            //gridView1.Columns["IsSelected"].ColumnEdit = checkEdit;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             frmReportDSKH lg = new frmReportDSKH();
            lg.ShowDialog();
        }
    }
}
