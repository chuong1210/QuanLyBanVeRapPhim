namespace GUI
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pt2 = new PictureBox();
            pt1 = new PictureBox();
            lblEmailError = new Label();
            lblPasswordError = new Label();
            label11 = new Label();
            txtFullName = new TextBox();
            dtKH = new DateTimePicker();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtSDT = new TextBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtConfirmPW = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pt1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.ScrollBar;
            pictureBox1.BackgroundImage = Properties.Resources.wallpapersden_com_gradient_landscape_4k_illustration_3840x2160;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.wallpapersden_com_gradient_landscape_4k_illustration_3840x2160;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1406, 702);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(pt2);
            panel2.Controls.Add(pt1);
            panel2.Controls.Add(lblEmailError);
            panel2.Controls.Add(lblPasswordError);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(dtKH);
            panel2.Controls.Add(rdoNu);
            panel2.Controls.Add(rdoNam);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtConfirmPW);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(58, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1218, 565);
            panel2.TabIndex = 4;
            // 
            // pt2
            // 
            pt2.BackColor = Color.White;
            pt2.BackgroundImage = Properties.Resources.show;
            pt2.BackgroundImageLayout = ImageLayout.Center;
            pt2.Location = new Point(527, 194);
            pt2.Name = "pt2";
            pt2.Size = new Size(43, 30);
            pt2.TabIndex = 27;
            pt2.TabStop = false;
            pt2.Click += pt2_Click;
            // 
            // pt1
            // 
            pt1.BackColor = Color.White;
            pt1.BackgroundImage = Properties.Resources.show;
            pt1.BackgroundImageLayout = ImageLayout.Center;
            pt1.Location = new Point(527, 130);
            pt1.Name = "pt1";
            pt1.Size = new Size(43, 30);
            pt1.TabIndex = 26;
            pt1.TabStop = false;
            pt1.Click += pt1_Click;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(826, 231);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(226, 20);
            lblEmailError.TabIndex = 25;
            lblEmailError.Text = "(*) Không đúng định dạng email!";
            lblEmailError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(266, 231);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(180, 20);
            lblPasswordError.TabIndex = 24;
            lblPasswordError.Text = "(*) Không trủng mật khẩu!";
            lblPasswordError.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(53, 316);
            label11.Name = "label11";
            label11.Size = new Size(123, 32);
            label11.TabIndex = 23;
            label11.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(265, 322);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Fullname";
            txtFullName.Size = new Size(305, 32);
            txtFullName.TabIndex = 22;
            // 
            // dtKH
            // 
            dtKH.Location = new Point(824, 135);
            dtKH.Name = "dtKH";
            dtKH.Size = new Size(305, 27);
            dtKH.TabIndex = 21;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(901, 266);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 20;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(824, 266);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 19;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(610, 260);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 18;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(614, 188);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 16;
            label8.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(826, 194);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(305, 32);
            txtEmail.TabIndex = 15;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(612, 130);
            label9.Name = "label9";
            label9.Size = new Size(150, 32);
            label9.TabIndex = 14;
            label9.Text = "Date of birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(612, 69);
            label10.Name = "label10";
            label10.Size = new Size(93, 30);
            label10.TabIndex = 13;
            label10.Text = "Number";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(824, 69);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Number";
            txtSDT.Size = new Size(305, 32);
            txtSDT.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(53, 252);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(265, 258);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Adress";
            txtDiaChi.Size = new Size(305, 32);
            txtDiaChi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(53, 188);
            label5.Name = "label5";
            label5.Size = new Size(206, 32);
            label5.TabIndex = 8;
            label5.Text = "Confirm password";
            // 
            // txtConfirmPW
            // 
            txtConfirmPW.Location = new Point(265, 194);
            txtConfirmPW.Multiline = true;
            txtConfirmPW.Name = "txtConfirmPW";
            txtConfirmPW.PasswordChar = '*';
            txtConfirmPW.PlaceholderText = "Confirm password";
            txtConfirmPW.Size = new Size(305, 32);
            txtConfirmPW.TabIndex = 7;
            txtConfirmPW.TextChanged += txtConfirmPW_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(624, 493);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 6;
            label4.Text = "Đăng nhập";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseCompatibleTextRendering = true;
            label4.DoubleClick += label4_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(453, 497);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 5;
            label3.Text = "Đã có tài khoản?";
            // 
            // btnRegister
            // 
            btnRegister.BackgroundImage = (Image)resources.GetObject("btnRegister.BackgroundImage");
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Violet;
            btnRegister.Location = new Point(203, 415);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(772, 65);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(53, 124);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(53, 62);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 130);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(305, 32);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(265, 66);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Username";
            txtUsername.Size = new Size(305, 32);
            txtUsername.TabIndex = 0;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 702);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "frmRegister";
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pt1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Button btnRegister;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtConfirmPW;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private TextBox txtSDT;
        private Label label6;
        private TextBox txtDiaChi;
        private RadioButton rdoNam;
        private DateTimePicker dtKH;
        private RadioButton rdoNu;
        private Label label11;
        private TextBox txtFullName;
        private Label lblPasswordError;
        private Label lblEmailError;
        private PictureBox pt1;
        private PictureBox pt2;
    }
}