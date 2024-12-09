namespace Bookshop
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Myprogressbar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            PercentageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(157, 27);
            label1.Name = "label1";
            label1.Size = new Size(522, 39);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(29, 378);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 2;
            label2.Text = "Loading ...";
            // 
            // Myprogressbar
            // 
            Myprogressbar.Location = new Point(29, 415);
            Myprogressbar.Name = "Myprogressbar";
            Myprogressbar.Size = new Size(759, 23);
            Myprogressbar.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PercentageLabel
            // 
            PercentageLabel.AutoSize = true;
            PercentageLabel.BackColor = SystemColors.Control;
            PercentageLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PercentageLabel.ForeColor = Color.Gray;
            PercentageLabel.Location = new Point(157, 378);
            PercentageLabel.Name = "PercentageLabel";
            PercentageLabel.Size = new Size(25, 22);
            PercentageLabel.TabIndex = 4;
            PercentageLabel.Text = "%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(PercentageLabel);
            Controls.Add(Myprogressbar);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ProgressBar Myprogressbar;
        private System.Windows.Forms.Timer timer1;
        private Label PercentageLabel;
    }
}
