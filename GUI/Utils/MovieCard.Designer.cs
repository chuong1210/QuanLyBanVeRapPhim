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
            poster = new PictureBox();
            lbName = new Label();
            lbDuration = new Label();
            lbDirector = new Label();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)poster).BeginInit();
            SuspendLayout();
            // 
            // poster
            // 
            poster.BackColor = Color.FromArgb(192, 192, 255);
            poster.BackgroundImage = Properties.Resources.oip1;
            poster.BackgroundImageLayout = ImageLayout.Zoom;
            poster.Location = new Point(0, 3);
            poster.Name = "poster";
            poster.Size = new Size(194, 187);
            poster.TabIndex = 0;
            poster.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(57, 197);
            lbName.Name = "lbName";
            lbName.Size = new Size(91, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Kí sinh trùng";
            // 
            // lbDuration
            // 
            lbDuration.AutoSize = true;
            lbDuration.Location = new Point(143, 227);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new Size(28, 20);
            lbDuration.TabIndex = 2;
            lbDuration.Text = "90'";
            // 
            // lbDirector
            // 
            lbDirector.AutoSize = true;
            lbDirector.Location = new Point(18, 227);
            lbDirector.Name = "lbDirector";
            lbDirector.Size = new Size(74, 20);
            lbDirector.TabIndex = 3;
            lbDirector.Text = "John cena";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(37, 250);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(134, 29);
            btnPay.TabIndex = 4;
            btnPay.Text = "button1";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(btnPay);
            Controls.Add(lbDirector);
            Controls.Add(lbDuration);
            Controls.Add(lbName);
            Controls.Add(poster);
            Name = "MovieCard";
            Size = new Size(194, 285);
            ((System.ComponentModel.ISupportInitialize)poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox poster;
        private Label lbName;
        private Label lbDuration;
        private Label lbDirector;
        private Button btnPay;
    }
}
