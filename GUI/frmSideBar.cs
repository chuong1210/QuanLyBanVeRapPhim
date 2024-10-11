using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSideBar : Form
    {
        private List<Button> buttons = new List<Button>();
        private Form activeForm = null; // Lưu form đang hoạt động

        private Panel panelContent;

        public frmSideBar()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            this.TopMost = false; // Đưa form lên trên cùng nếu cần
            this.Controls.Add(sidebarPanel);

            string[] buttonLabels = {  "Thể loại", "Quản lý phim", "Quản lý thành viên" };

            foreach (string label in buttonLabels)
            {
              
                Button button = new Button();
                button.Text = label;
                button.BackColor = Color.LightBlue;
                button.Dock = DockStyle.Top;
                button.Click += Button_Click;
                sidebarPanel.Controls.Add(button);
                buttons.Add(button);
            }

            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            this.Controls.Add(panelContent);

            ShowForm(new frmSeatMovie());




        }

        private void ShowForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Dispose(); // Dispose() là quan trọng, giải phóng tài nguyên
                activeForm = null;
            }

            if (form != null)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelContent.Controls.Clear(); // Xóa hết controls cũ, quan trọng!
                panelContent.Controls.Add(form);
                form.Show();
                activeForm = form;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Highlight selected button
            foreach (Button button in buttons)
            {
                button.BackColor = Color.LightBlue;
            }

            clickedButton.BackColor = Color.SkyBlue;

            // Ẩn form đang hoạt động nếu có
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            Form newForm = null;

            // Tạo form quản lý dựa trên nút được chọn
            if (clickedButton.Text == "Quản lý phim")
            {
                newForm = new frmRegister(); // Thay MovieManagementForm bằng form của bạn
            }
            else if (clickedButton.Text == "Quản lý thành viên")
            {
                newForm = new frmSeatMovie(); // Thay MemberManagementForm bằng form của bạn
            }
            // ... các điều kiện khác

            if (newForm != null)
            {
                newForm.TopLevel = false; // Quan trọng: đặt TopLevel = false
                newForm.FormBorderStyle = FormBorderStyle.None; // Remove border
                newForm.Dock = DockStyle.Fill; // Nạp form đầy Panel
                panelContent.Controls.Clear();
                panelContent.Controls.Add(newForm);
                newForm.BringToFront();
                newForm.Show();
                activeForm = newForm;

                newForm.Activated += (s, args) => {

                    newForm.Focus(); // Cho phép form hoạt động
                    this.ActiveControl = newForm; // Điều này giúp form hoạt động đúng.
                };
            }


        }

        private void frmClient_Load(object sender, EventArgs e)
        {

            // Thêm panel vào

        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
