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
using System.Text.RegularExpressions;
using GUI.Utils;
using System.ComponentModel.DataAnnotations;
using GUI.Report;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts.Native;
namespace GUI
{
    public partial class frmConfirm : Form
    {
        public DatVeDTO dt { get; set; }
        public string idKh { get; set; } = string.Empty;
        public List<string> seats { get; set; }
        PhimBLL phimBll = new PhimBLL();
        TaiKhoanBLL khBLL = new TaiKhoanBLL();
        KhachHangBLL kh = new KhachHangBLL();
        KhachHangDTO newCustomer;
        private Font labelFont;
        private Font textEditFont;
        private int labelX;
        private int textX;
        private int currentY;
        private int lineSpacing;
        private List<MuaHangDTO> _vps;
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
        private TextEdit txtSTK;
        private TextEdit txtTenTaiKhoan;
        private TextEdit txtSoTien;
        private ComboBoxEdit cb_template;

        public frmConfirm(List<MuaHangDTO> vps)
        {
            InitializeComponent();

            _vps = vps;
            lkBank = new LookUpEdit
            {
                Font = textEditFont,
                Width = 300
            };

            groupControl2.Controls.Add(lkBank);

            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                lkBank.Properties.DataSource = listBankData.data;
                // list banks
                lkBank.Properties.DisplayMember = "name";
                lkBank.Properties.ValueMember = "bin";
                lkBank.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Tên ngân hàng"));
                lkBank.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin", "Code Bank", 20));
                // Ẩn cột CMND khi hiển thị
                //lkBank.Properties.Columns["id"].Visible = false;
                //lkBank.Properties.Columns["code"].Visible = false;
                //lkBank.Properties.Columns["shortName"].Visible = false;
                //lkBank.Properties.Columns["logo"].Visible = false;
                //lkBank.Properties.Columns["transferSupported"].Visible = false;
                //lkBank.Properties.Columns["short_name"].Visible = false;
                //lkBank.Properties.Columns["lookupSupported"].Visible = false;
                //lkBank.Properties.Columns["support"].Visible = false;
                //lkBank.Properties.Columns["isTransfer"].Visible = false;
                //lkBank.Properties.Columns["swift_code"].Visible = false;

                lkBank.EditValue = listBankData.data.FirstOrDefault().bin;
                lkBank.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
                lkBank.Properties.AutoSearchColumnIndex = 0;  // Chọn cột nào để tìm kiếm
            }

        }
        private void CreateTextBoxesBelowLookUpEdit()
        {
            int startY = lkBank.Bottom + 100; // Vị trí dưới lkBank
            int textBoxWidth = 300;


            //// Tạo TextEdit cho STK (Số tài khoản)
            //txtSTK = new TextEdit
            //{
            //    Font = textEditFont,
            //    Location = new Point(textX, currentY + 50),  // Đặt vị trí sau lbtongtien và txtTT
            //    Width = textBoxWidth,
            //    Name = "txtSTK",
            //    Properties = { NullText = "Nhập số tài khoản" } // Thêm placeholder
            //};
            //groupControl2.Controls.Add(txtSTK);
            //currentY += txtSTK.Height + 10; // Cập nhật vị trí currentY

            // Tạo TextEdit cho Tên tài khoản
            txtTenTaiKhoan = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY),
                Width = textBoxWidth,
                Name = "txtTenTaiKhoan",
                Properties = { NullText = "Nhập tên tài khoản" } // Thêm placeholder
            };
            groupControl2.Controls.Add(txtTenTaiKhoan);
            currentY += txtTenTaiKhoan.Height + 10;
            txtTenTaiKhoan.Visible = false;

            // Tạo TextEdit cho Số tiền
            txtSoTien = new TextEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY),
                Width = textBoxWidth,
                Name = "txtSoTien",
                Properties = { NullText = "Nhập số tiền" } // Thêm placeholder
            };
            groupControl2.Controls.Add(txtSoTien);
            currentY += txtSoTien.Height + 10;
            txtSoTien.Visible = false;
            txtSoTien.Text = txtTT.Text;


            // Tạo ComboBoxEdit cho template
            cb_template = new ComboBoxEdit
            {
                Font = textEditFont,
                Location = new Point(textX, currentY),
                Width = textBoxWidth,
                Name = "cb_template"
            };
            cb_template.Visible = false;
            // Cần thêm các template vào ComboBox
            //
            //
            // Edit (ví dụ: Text, QR Code...)
            cb_template.Properties.Items.AddRange(new string[] { "template 1", "template 2", "template 3" });
            groupControl2.Controls.Add(cb_template);
            currentY += cb_template.Height + 20; // Cập nhật lại vị trí currentY sau khi thêm cb_template
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        public void ThanhToanQR()
        {
            var apiRequest = new ApiRequest();
            apiRequest.acqId = Convert.ToInt32(lkBank.EditValue.ToString());
            //apiRequest.accountNo = long.Parse(txtSTK.Text);
            apiRequest.accountNo = long.MinValue;
            apiRequest.accountName = txtTenTaiKhoan.Text;
            string input = txtSoTien.Text;

            // Lấy phần trước "VNĐ"
            //   string numberString = input.Substring(0, input.Length - 3).Trim(); // Cắt 3 ký tự "VNĐ"
            string numberString = input.Replace("VNĐ", "").Trim();
            // Chuyển đổi thành kiểu số (int, decimal...)
            int result;
            if (int.TryParse(numberString, out result))
            {
                Console.WriteLine("Số tiền là: " + result);
            }
            else
            {
                Console.WriteLine("Lỗi định dạng số!");
            }

            apiRequest.amount = Convert.ToInt32(_vps.Count);
            apiRequest.format = "text";
            apiRequest.template = cb_template.Text;
            apiRequest = new ApiRequest
            {
                acqId = Convert.ToInt32(lkBank.EditValue.ToString()),
                accountNo = long.Parse("204242"),  // Đảm bảo txtSTK có giá trị hợp lệ
                accountName = txtTenTaiKhoan.Text,
                amount = result,  // Gán giá trị số tiền
                format = "text",
                template = "compact"
            };

            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            // Gửi yêu cầu
            var response = client.Execute(request);
            var content = response.Content;

            if (response.IsSuccessful)
            {
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);
                var image = Base64ToImage(dataResult.Data.qrDataURL.Replace("data:image/png;base64,", ""));
                pc1.Image = image;
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo QR code: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            groupControl1.Height = 900;
            groupControl2.Height = 900;

            // Định nghĩa font chữ lớn hơn

            // Định nghĩa font chữ
            Font labelFont = new Font("Tahoma", 12, FontStyle.Regular);
            Font textEditFont = new Font("Tahoma", 12, FontStyle.Regular);

            int labelX = 20; // Vị trí X của Label
            int textX = 240; // Vị trí X của TextEdit
            int currentY = 40; // Vị trí Y bắt đầu
            int lineSpacing = 50; // Khoảng cách giữa các dòng

            // Tạo các Label và TextEdit


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
            CreateTextBoxesBelowLookUpEdit();

            if (!string.IsNullOrEmpty(idKh))
            {
                KhachHangDTO customer = kh.GetChiTietKhachHang(idKh);

                if (customer != null)
                {
                    txtTenTaiKhoan.Text = customer.HoTen;

                    // Gán giá trị cho các trường
                    txtCustomerName.Text = customer.HoTen;
                    txtCardType.Text = customer.DiemTichLuy >= 1000 ? "VIP" : "Thường"; // Ví dụ logic hạng thẻ
                    txtAvailablePoints.Text = customer.DiemTichLuy.ToString();
                    dateBirthDate.DateTime = DateTime.TryParse(customer.NgaySinh, out var birthDate) ? birthDate : DateTime.MinValue;
                    txtAddress.Text = customer.DiaChi;
                    txtPhone.Text = customer.SDT;
                    txtEmail.Text = customer.Email;
                    cmbGender.SelectedItem = customer.GioiTinh;

                    // Đặt các trường thành readonly
                    txtCustomerName.Properties.ReadOnly = true;
                    txtCardType.Properties.ReadOnly = true;
                    txtAvailablePoints.Properties.ReadOnly = true;
                    dateBirthDate.Properties.ReadOnly = true;
                    txtAddress.Properties.ReadOnly = true;
                    txtPhone.Properties.ReadOnly = true;
                    txtEmail.Properties.ReadOnly = true;
                    cmbGender.Properties.ReadOnly = true;

                    // Đổi màu nền để dễ nhận biết
                    txtCustomerName.BackColor = Color.LightGray;
                    txtCardType.BackColor = Color.LightGray;
                    txtAvailablePoints.BackColor = Color.LightGray;
                    dateBirthDate.BackColor = Color.LightGray;
                    txtAddress.BackColor = Color.LightGray;
                    txtPhone.BackColor = Color.LightGray;
                    txtEmail.BackColor = Color.LightGray;
                    cmbGender.BackColor = Color.LightGray;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Tạo nút "Tạo người dùng"
            btnCreateUser = new SimpleButton
            {
                Text = "Tạo người dùng",
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Location = new Point(labelX + 150, currentY + 70),
                Size = new Size(200, 40), // Kích thước nút
                //ImageOptions =
                //{
                //Image = Properties.Resources.user_icon_png_3,
                //  SvgImageSize = new Size(20, 20),
                //    // Cấu hình zoom
                //    ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter,
                //}
            };

            int startY = pc1.Bottom + 50; // Vị trí dưới lkBank
            int textBoxWidth = 300;
            guna2Button1.Location = new Point(labelX + 140, currentY + 125);


            btnCreateInvoice = new SimpleButton
            {
                Text = "Thanh toán",
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Location = new Point(labelX + 90, startY),
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





            dtGVDH.DataSource = _vps;
            foreach (DataGridViewColumn column in dtGVDH.Columns)
            {
                // Lấy thuộc tính PropertyInfo của đối tượng DTO
                var propertyInfo = typeof(MuaHangDTO).GetProperty(column.DataPropertyName);

                // Kiểm tra xem có Display attribute hay không
                var displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(DisplayAttribute));

                if (displayAttribute != null)
                {
                    // Gán tên hiển thị từ Display.Name vào tiêu đề cột
                    column.HeaderText = displayAttribute.Name;
                }
            }
            // Cập nhật giá trị vào ô cụ thể
            txtTT.Text = dt.TongTien.ToString() + "VNĐ";

            ThanhToanQR();

        }
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;  // Email

            // Tạo đối tượng KhachHangDTO và gán giá trị từ các trường nhập liệu
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            // Gọi phương thức InsertKhachHang để thêm khách hàng vào cơ sở dữ liệu
            newCustomer = new KhachHangDTO
            {
                HoTen = txtCustomerName.Text,  // Tên khách hàng
                NgaySinh = dateBirthDate.DateTime.ToString("dd/MM/yyyy"),  // Ngày sinh
                DiemTichLuy = int.Parse(txtAvailablePoints.Text),  // Diem tích lũy mặc định có thể cập nhật sau
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

        private string _idlc;
        private string _tenPhim;
        private string _posterPath;
        private string _ngayChieu;
        private string _userName;
        public void LoadMovieCF(string idLichChieu, string tenPhim, string posterPath, string ngayChieu, string userName)
        {
            _idlc = idLichChieu;
            _tenPhim = tenPhim;
            _posterPath = posterPath;
            _ngayChieu = ngayChieu;
            _userName = userName;




        }

        private void BtnBackSeat(object sender, EventArgs e)
        {
            frmSeatMovie seatMovieForm = new frmSeatMovie();

            seatMovieForm.LoadMovie(_idlc, _tenPhim, _posterPath, _ngayChieu, _userName);
        }
        private bool IsValidEmail(string email)
        {
            // Kiểm tra email với biểu thức chính quy
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }


        private async void btnCreateInvoice_Click(object sender, EventArgs e)
        {

            HoaDonDTO result = phimBll.DatVeXemPhim(dt, seats, ""); // Pass the list of IDs

            if (result != null)
            {
                // Đặt màu xanh cho các ghế đã chọn


                MessageBox.Show("Đặt vé thành công", "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmReportHD report = new frmReportHD(_vps);

                // Truyền danh sách vào DataSource

                // Hiển thị báo cáo
                //frmSearchMovie search = new frmSearchMovie(UserSession.Username);

                //search.Show();
                await Task.Delay(1000);
                report.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đặt vé không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmSeatMovie seatMovieForm = new frmSeatMovie();

            //seatMovieForm.LoadMovie(_idlc, _tenPhim, _posterPath, _ngayChieu, _userName);
            //seatMovieForm.Show();
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
