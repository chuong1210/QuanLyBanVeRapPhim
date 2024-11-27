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
using DTO;
using BLL;
using System.Drawing.Printing;
namespace GUI
{
    public partial class frmConfirm : Form
    {
        public DatVeDTO dt { get; set; }
        public List<string> seats { get; set; }
        PhimBLL phimBll = new PhimBLL();
        TaiKhoanBLL khBLL = new TaiKhoanBLL();
        KhachHangDTO newCustomer;
        private Font labelFont;
        private Font textEditFont;
        private int labelX;
        private int textX;
        private int currentY;
        private int lineSpacing;

        private LabelControl lblMemberID;
        private TextEdit txtMemberID;
        private LabelControl lblCustomerName;
        private TextEdit txtCustomerName;
        private LabelControl lblCardType;
        private TextEdit txtCardType;
        private LabelControl lblAvailablePoints;
        private TextEdit txtAvailablePoints;
        private LabelControl lblBirthDate;
        private DateEdit dateBirthDate;
        private LabelControl lblAddress;
        private MemoEdit txtAddress;
        private LabelControl lblPhone;
        private TextEdit txtPhone;
        private LabelControl lblEmail;
        private TextEdit txtEmail;
        private LabelControl lblGender;
        private ComboBoxEdit cmbGender;
        private SimpleButton btnCreateUser;
        private SimpleButton btnCreateInvoice;

        public frmConfirm()
        {
            InitializeComponent();

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            groupControl1.Height = 600;
            groupControl2.Height = 600;

            // Định nghĩa font chữ lớn hơn

            // Định nghĩa font chữ
            Font labelFont = new Font("Tahoma", 12, FontStyle.Regular);
            Font textEditFont = new Font("Tahoma", 12, FontStyle.Regular);

            int labelX = 20; // Vị trí X của Label
            int textX = 240; // Vị trí X của TextEdit
            int currentY = 40; // Vị trí Y bắt đầu
            int lineSpacing = 50; // Khoảng cách giữa các dòng

            // Tạo các Label và TextEdit
             lblMemberID = new LabelControl
            {
                Text = "Mã thành viên:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtMemberID = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            currentY += lineSpacing; // Cập nhật vị trí Y
             lblCustomerName = new LabelControl
            {
                Text = "Tên khách hàng:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtCustomerName = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            currentY += lineSpacing;
             lblCardType = new LabelControl
            {
                Text = "Hạng thẻ khách hàng:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtCardType = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            currentY += lineSpacing;
             lblAvailablePoints = new LabelControl
            {
                Text = "Điểm tích lũy khả dụng:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtAvailablePoints = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };
            txtAvailablePoints.Properties.Mask.EditMask = @"\d+";
            txtAvailablePoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtAvailablePoints.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Thêm các trường mới
            currentY += lineSpacing;
             lblBirthDate = new LabelControl
            {
                Text = "Ngày sinh:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             dateBirthDate = new DateEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            // Cấu hình định dạng ngày tháng
            dateBirthDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateBirthDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateBirthDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateBirthDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            // Cấu hình mask để đảm bảo nhập đúng định dạng
            dateBirthDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateBirthDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            currentY += lineSpacing;
             lblAddress = new LabelControl
            {
                Text = "Địa chỉ:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtAddress = new MemoEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300,
                Height = 50 // Tăng chiều cao cho nhiều dòng
            };

            currentY += lineSpacing + 20; // Dòng sau MemoEdit cần khoảng cách lớn hơn
             lblPhone = new LabelControl
            {
                Text = "Số điện thoại:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtPhone = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            currentY += lineSpacing;
             lblEmail = new LabelControl
            {
                Text = "Email:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             txtEmail = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };

            currentY += lineSpacing;
             lblGender = new LabelControl
            {
                Text = "Giới tính:",
                Font = labelFont,
                Location = new Point(labelX, currentY)
            };
             cmbGender = new ComboBoxEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY - 3),
                Width = 300
            };
            cmbGender.Properties.Items.AddRange(new[] { "Nam", "Nữ", "Khác" });

           
            // Tạo nút "Tạo người dùng"
             btnCreateUser = new SimpleButton
            {
                Text = "Tạo người dùng",
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Location = new Point(labelX+150, currentY+70),
                Size = new Size(200, 40), // Kích thước nút
                //ImageOptions =
                //{
                //Image = Properties.Resources.user_icon_png_3,
                //  SvgImageSize = new Size(20, 20),
                //    // Cấu hình zoom
                //    ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter,
                //}
            };

             btnCreateInvoice = new SimpleButton
            {
                Text = "Thanh toán",
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Location = new Point(labelX + 90, currentY + 70),
                Size = new Size(200, 40), // Kích thước nút
            
            };
            // Gán sự kiện khi bấm nút
            btnCreateUser.Click += BtnCreateUser_Click;
            btnCreateInvoice.Click += btnCreateInvoice_Click;


            // Thêm nút vào GroupControl
            groupControl1.Controls.Add(btnCreateUser);
            groupControl2.Controls.Add(btnCreateInvoice);


            // Thêm các Label và Control vào GroupControl
            groupControl1.Controls.Add(lblMemberID);
            groupControl1.Controls.Add(txtMemberID);

            groupControl1.Controls.Add(lblCustomerName);
            groupControl1.Controls.Add(txtCustomerName);

            groupControl1.Controls.Add(lblCardType);
            groupControl1.Controls.Add(txtCardType);

            groupControl1.Controls.Add(lblAvailablePoints);
            groupControl1.Controls.Add(txtAvailablePoints);

            groupControl1.Controls.Add(lblBirthDate);
            groupControl1.Controls.Add(dateBirthDate);

            groupControl1.Controls.Add(lblAddress);
            groupControl1.Controls.Add(txtAddress);

            groupControl1.Controls.Add(lblPhone);
            groupControl1.Controls.Add(txtPhone);

            groupControl1.Controls.Add(lblEmail);
            groupControl1.Controls.Add(txtEmail);

            groupControl1.Controls.Add(lblGender);
            groupControl1.Controls.Add(cmbGender);




        }
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng KhachHangDTO và gán giá trị từ các trường nhập liệu

            // Gọi phương thức InsertKhachHang để thêm khách hàng vào cơ sở dữ liệu
            newCustomer = new KhachHangDTO
            {
                HoTen = txtCustomerName.Text,  // Tên khách hàng
                NgaySinh = dateBirthDate.DateTime.ToString("dd/MM/yyyy"),  // Ngày sinh
                DiemTichLuy =int.Parse( txtAvailablePoints.Text),  // Diem tích lũy mặc định có thể cập nhật sau
                DiaChi = txtAddress.Text,  // Địa chỉ
                SDT = txtPhone.Text,  // Số điện thoại
                Email = txtEmail.Text,  // Email
                GioiTinh = cmbGender.SelectedItem?.ToString() // Giới tính
            };

            bool isSuccess = khBLL.AddKH(newCustomer);

            if (isSuccess)
            {
                // Hiển thị thông báo thành công
                MessageBox.Show("Tạo người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị thông báo lỗi nếu không thể tạo người dùng
                MessageBox.Show("Lỗi khi tạo người dùng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {

            HoaDonDTO result = phimBll.DatVeXemPhim(dt, seats, ""); // Pass the list of IDs

            if (result != null)
            {
                // Đặt màu xanh cho các ghế đã chọn
               

                  MessageBox.Show("Đặt vé thành công", "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt vé không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        
        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
            
        //    string tenPhim = dt.TenPhim;
        //    string ngayChieu = dt.IdLichChieuPhim;
        //    string phongChieu = dt.TenPhim;
        //    string gheDaChon = string.Join(", ", seats);
        //    //decimal tongTien = selectedSeats.Count * lc.GiaVePhim;

        //    // Định dạng font và khoảng cách
        //    Font font = new Font("Arial", 28);
        //    int lineHeight = font.Height + 10;
        //    int x = 100; // Vị trí X để bắt đầu in
        //    int y = 100; // Vị trí Y để bắt đầu in

        //    // In thông tin hóa đơn
        //    e.Graphics.DrawString("HÓA ĐƠN ĐẶT VÉ", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
        //    y += lineHeight;
        //    e.Graphics.DrawString($"Tên phim: {tenPhim}", font, Brushes.Black, x, y);
        //    y += lineHeight;

         
        //    e.Graphics.DrawString($"Ngày chiếu: {ngayChieu}", font, Brushes.Black, x, y);
        //    y += lineHeight;
        //    e.Graphics.DrawString($"Phòng chiếu: {phongChieu}", font, Brushes.Black, x, y);
        //    y += lineHeight;
        //    e.Graphics.DrawString($"Ghế đã chọn: {gheDaChon}", font, Brushes.Black, x, y);
        //    y += lineHeight;
        //    var cultureInfo = new System.Globalization.CultureInfo("vi-VN");
        //    e.Graphics.DrawString($"Tổng tiền: {dt.TongTien.ToString("C", cultureInfo)}", font, Brushes.Black, x, y);

        //}

        //private void printPreviewDialog1_Load(object sender, EventArgs e)
        //{
        //    printPreviewDialog1.WindowState = FormWindowState.Maximized;
        //}
    }
}
