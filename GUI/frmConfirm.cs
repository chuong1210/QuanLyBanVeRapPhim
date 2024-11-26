using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace GUI
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            groupControl1.Height = 300;
            // Định nghĩa font chữ lớn hơn
            Font labelFont = new Font("Tahoma", 12, FontStyle.Regular);
            Font textEditFont = new Font("Tahoma", 12, FontStyle.Regular);

            // Tạo Label và TextEdit cho Mã thành viên
            LabelControl lblMemberID = new LabelControl
            {
                Text = "Mã thành viên:",
                Font = labelFont,
                Location = new System.Drawing.Point(20, 40)
            };
            TextEdit txtMemberID = new TextEdit
            {
                Font = textEditFont,
                Location = new System.Drawing.Point(240, 37),
                Width = 300 // Tăng chiều rộng cho phép hiển thị nội dung dài hơn
            };

            // Tạo Label và TextEdit cho Tên khách hàng
            LabelControl lblCustomerName = new LabelControl
            {
                Text = "Tên khách hàng:",
                Font = labelFont,
                Location = new System.Drawing.Point(20, 90)
            };
            TextEdit txtCustomerName = new TextEdit
            {
                Font = textEditFont,
                Location = new System.Drawing.Point(240, 87),
                Width = 300
            };

            // Tạo Label và TextEdit cho Hạng thẻ
            LabelControl lblCardType = new LabelControl
            {
                Text = "Hạng thẻ khách hàng:",
                Font = labelFont,
                Location = new System.Drawing.Point(20, 140)
            };
            TextEdit txtCardType = new TextEdit
            {
                Font = textEditFont,
                Location = new System.Drawing.Point(240, 137),
                Width = 300
            };

            // Tạo Label và TextEdit cho Điểm khả dụng
            LabelControl lblAvailablePoints = new LabelControl
            {
                Text = "Điểm tích lũy khả dụng:",
                Font = labelFont,
                Location = new System.Drawing.Point(20, 190)
            };
            TextEdit txtAvailablePoints = new TextEdit
            {
                Font = textEditFont,
                Location = new System.Drawing.Point(240, 187),
                Width = 300
            };

            // Thêm các LabelControl và TextEdit vào GroupControl
            groupControl1.Controls.Add(lblMemberID);
            groupControl1.Controls.Add(txtMemberID);

            groupControl1.Controls.Add(lblCustomerName);
            groupControl1.Controls.Add(txtCustomerName);

            groupControl1.Controls.Add(lblCardType);
            groupControl1.Controls.Add(txtCardType);

            groupControl1.Controls.Add(lblAvailablePoints);
            groupControl1.Controls.Add(txtAvailablePoints);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
