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
        private string _username ;
        private Panel panelContent;

        public frmSideBar(string username)
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            this.TopMost = false; // Đưa form lên trên cùng nếu cần

            this.Controls.Add(sidebarPanel);
            sidebarPanel.Padding = new Padding(0, 170, 0, 0); // Khoảng cách trên cùng là 50px
            _username=username;
            string[] buttonLabels = {  "Lịch chiếu phim",  "Đổi mật khẩu", "Biểu mẫu hóa đơn" };
            buttonLabels = buttonLabels.Reverse().ToArray();
            foreach (string label in buttonLabels)
            {
              
                Button button = new Button();
                button.Text = label;
                button.BackColor = Color.LightBlue;
                button.Dock = DockStyle.Top;
                button.Width= 100;
                button.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                button.Height = 80;
                button.Margin = new Padding(0, 120, 0, 0);
                button.Click += Button_Click;
                sidebarPanel.Controls.Add(button);
                buttons.Add(button);
            }

            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            this.Controls.Add(panelContent);

            ShowForm(new frmSearchMovie(_username));




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


         
            if (clickedButton.Text != "Đổi mật khẩu")
            {
                Form newForm = null;
            

                if (clickedButton.Text == "Lịch chiếu phim")
                {
                    newForm = new frmSearchMovie(_username); // Thay MovieManagementForm bằng form của bạn
                }

                if (newForm != null)
                {
                    //Crucially, use ShowDialog() for modal forms
                  
                        //ShowForm(newForm); //Use ShowForm for non-modal forms
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

             

            // ... các điều kiện khác

         
           
            }
            else
            {
                frmChangePW pw = new frmChangePW(_username);

                pw.Show();
                frmSearchMovie frmSearch=new frmSearchMovie(_username);
                ShowForm(frmSearch);
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
