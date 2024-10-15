namespace GUI
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAccount = new Button();
            btnCustomer = new Button();
            btnStaff = new Button();
            btnData = new Button();
            btnRevenue = new Button();
            pnBodyAdmin = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnData);
            panel1.Controls.Add(btnRevenue);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1810, 157);
            panel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(192, 192, 255);
            btnAccount.Font = new Font("Consolas", 12F);
            btnAccount.Image = Properties.Resources.login_user_profile_account_logout_people_man_human_512;
            btnAccount.ImageAlign = ContentAlignment.TopLeft;
            btnAccount.Location = new Point(938, 23);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(135, 69);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Tài khoản";
            btnAccount.TextAlign = ContentAlignment.BottomLeft;
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.RosyBrown;
            btnCustomer.Font = new Font("Consolas", 12F);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = Properties.Resources.people_2_512;
            btnCustomer.ImageAlign = ContentAlignment.TopLeft;
            btnCustomer.Location = new Point(737, 23);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(135, 69);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.TextAlign = ContentAlignment.BottomLeft;
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.SkyBlue;
            btnStaff.Font = new Font("Consolas", 12F);
            btnStaff.Image = Properties.Resources.employee_office_staff_3d735bc691173bb5_256x256;
            btnStaff.ImageAlign = ContentAlignment.TopLeft;
            btnStaff.Location = new Point(536, 23);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(135, 69);
            btnStaff.TabIndex = 2;
            btnStaff.Text = "Nhân viên";
            btnStaff.TextAlign = ContentAlignment.BottomLeft;
            btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnData
            // 
            btnData.BackColor = Color.FromArgb(192, 192, 0);
            btnData.Font = new Font("Consolas", 12F);
            btnData.ForeColor = Color.White;
            btnData.Image = Properties.Resources.openfolder_4896;
            btnData.ImageAlign = ContentAlignment.TopLeft;
            btnData.Location = new Point(335, 23);
            btnData.Name = "btnData";
            btnData.Size = new Size(135, 69);
            btnData.TabIndex = 1;
            btnData.Text = "Dữ liệu";
            btnData.TextAlign = ContentAlignment.BottomLeft;
            btnData.UseVisualStyleBackColor = false;
            btnData.Click += btnData_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = Color.Green;
            btnRevenue.Font = new Font("Consolas", 12F);
            btnRevenue.ForeColor = Color.White;
            btnRevenue.Image = Properties.Resources.pie_chart___Copy;
            btnRevenue.ImageAlign = ContentAlignment.TopLeft;
            btnRevenue.Location = new Point(111, 24);
            btnRevenue.Margin = new Padding(0);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(136, 68);
            btnRevenue.TabIndex = 0;
            btnRevenue.Text = "Doanh thu";
            btnRevenue.TextAlign = ContentAlignment.BottomLeft;
            btnRevenue.UseVisualStyleBackColor = false;
            // 
            // pnBodyAdmin
            // 
            pnBodyAdmin.Location = new Point(1, 159);
            pnBodyAdmin.Name = "pnBodyAdmin";
            pnBodyAdmin.Size = new Size(1807, 665);
            pnBodyAdmin.TabIndex = 1;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 821);
            Controls.Add(pnBodyAdmin);
            Controls.Add(panel1);
            Name = "frmAdmin";
            Text = "frmAdmin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnStaff;
        private Button btnData;
        private Button btnRevenue;
        private Button btnAccount;
        private Button btnCustomer;
        private Panel pnBodyAdmin;
    }
}