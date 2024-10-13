namespace GUI
{
    partial class frmChangePW
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtOldPW = new TextBox();
            txtNewPW = new TextBox();
            txtConfirmPW = new TextBox();
            btnConfirm = new Button();
            txtError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_huit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(81, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 141);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(81, 182);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 1;
            label1.Text = "Màn hình đổi mật khẩu";
            // 
            // txtOldPW
            // 
            txtOldPW.Location = new Point(81, 223);
            txtOldPW.Name = "txtOldPW";
            txtOldPW.PasswordChar = '*';
            txtOldPW.PlaceholderText = "Nhập mật khẩu cũ";
            txtOldPW.Size = new Size(185, 27);
            txtOldPW.TabIndex = 2;
            // 
            // txtNewPW
            // 
            txtNewPW.Location = new Point(81, 278);
            txtNewPW.Name = "txtNewPW";
            txtNewPW.PasswordChar = '*';
            txtNewPW.PlaceholderText = "Nhập mật khẩu mới";
            txtNewPW.Size = new Size(185, 27);
            txtNewPW.TabIndex = 3;
            // 
            // txtConfirmPW
            // 
            txtConfirmPW.Location = new Point(81, 333);
            txtConfirmPW.Name = "txtConfirmPW";
            txtConfirmPW.PasswordChar = '*';
            txtConfirmPW.PlaceholderText = "Xác nhận mật khẩu";
            txtConfirmPW.Size = new Size(185, 27);
            txtConfirmPW.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.BackgroundImage = Properties.Resources.th__1_;
            btnConfirm.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirm.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnConfirm.ForeColor = SystemColors.ButtonFace;
            btnConfirm.Location = new Point(81, 387);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(185, 50);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtError.ForeColor = Color.Cyan;
            txtError.Location = new Point(42, 362);
            txtError.Name = "txtError";
            txtError.Size = new Size(0, 18);
            txtError.TabIndex = 6;
            // 
            // frmChangePW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 50, 60);
            ClientSize = new Size(349, 450);
            Controls.Add(txtError);
            Controls.Add(btnConfirm);
            Controls.Add(txtConfirmPW);
            Controls.Add(txtNewPW);
            Controls.Add(txtOldPW);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            HelpButton = true;
            Name = "frmChangePW";
            Text = "frmChangePW";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtOldPW;
        private TextBox txtNewPW;
        private TextBox txtConfirmPW;
        private Button btnConfirm;
        private Label txtError;
    }
}