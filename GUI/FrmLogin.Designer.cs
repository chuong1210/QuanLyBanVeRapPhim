namespace GUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel2 = new Panel();
            pt1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pt1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(pt1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(167, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 313);
            panel2.TabIndex = 1;
            // 
            // pt1
            // 
            pt1.BackColor = Color.White;
            pt1.BackgroundImage = Properties.Resources.show;
            pt1.BackgroundImageLayout = ImageLayout.Center;
            pt1.Cursor = Cursors.Hand;
            pt1.Location = new Point(442, 147);
            pt1.Name = "pt1";
            pt1.Size = new Size(43, 28);
            pt1.TabIndex = 28;
            pt1.TabStop = false;
            pt1.Click += pt1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(332, 268);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 6;
            label4.Text = "Đăng ký";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseCompatibleTextRendering = true;
            label4.DoubleClick += label4_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(191, 274);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Chưa có tài khoản?";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.Violet;
            btnLogin.Location = new Point(210, 207);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(66, 147);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(66, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 147);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(305, 32);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 71);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Username";
            txtUsername.Size = new Size(305, 32);
            txtUsername.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ImeMode = ImeMode.AlphaFull;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 519);
            panel1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 519);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pt1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private PictureBox pt1;
    }
}