namespace GUI.Utils
{
    partial class MovieCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCard));
            pbPoster = new PictureBox();
            lbName = new Label();
            lbDuration = new Label();
            lbDirector = new Label();
            btnBookTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // pbPoster
            // 
            pbPoster.BackColor = Color.FromArgb(192, 192, 255);
            pbPoster.BackgroundImage = (Image)resources.GetObject("pbPoster.BackgroundImage");
            pbPoster.BackgroundImageLayout = ImageLayout.Zoom;
            pbPoster.BorderStyle = BorderStyle.Fixed3D;
            pbPoster.Location = new Point(0, 0);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(194, 190);
            pbPoster.TabIndex = 0;
            pbPoster.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BorderStyle = BorderStyle.Fixed3D;
            lbName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbName.ForeColor = Color.Red;
            lbName.Location = new Point(68, 193);
            lbName.Name = "lbName";
            lbName.Size = new Size(126, 26);
            lbName.TabIndex = 1;
            lbName.Text = "Kí sinh trùng";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDuration
            // 
            lbDuration.AutoSize = true;
            lbDuration.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbDuration.Location = new Point(157, 222);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new Size(27, 18);
            lbDuration.TabIndex = 2;
            lbDuration.Text = "90'";
            // 
            // lbDirector
            // 
            lbDirector.AutoSize = true;
            lbDirector.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbDirector.Location = new Point(15, 222);
            lbDirector.Name = "lbDirector";
            lbDirector.Size = new Size(96, 18);
            lbDirector.TabIndex = 3;
            lbDirector.Text = "dnaiodhiladia";
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackgroundImage = Properties.Resources.th;
            btnBookTicket.BackgroundImageLayout = ImageLayout.Stretch;
            btnBookTicket.Cursor = Cursors.Hand;
            btnBookTicket.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBookTicket.ForeColor = Color.MediumSlateBlue;
            btnBookTicket.Location = new Point(37, 250);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(126, 42);
            btnBookTicket.TabIndex = 4;
            btnBookTicket.Text = "Đặt vé";
            btnBookTicket.UseVisualStyleBackColor = true;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(btnBookTicket);
            Controls.Add(lbDirector);
            Controls.Add(lbDuration);
            Controls.Add(lbName);
            Controls.Add(pbPoster);
            Name = "MovieCard";
            Size = new Size(195, 308);
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPoster;
        private Label lbName;
        private Label lbDuration;
        private Label lbDirector;
        private Button btnBookTicket;
    }
}
