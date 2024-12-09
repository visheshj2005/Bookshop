namespace Bookshop
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UPassTb = new TextBox();
            label3 = new Label();
            LoginBtn = new Button();
            label8 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(296, 10);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 1;
            label1.Text = "Admin Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UPassTb
            // 
            UPassTb.Font = new Font("Century Gothic", 20.25F);
            UPassTb.Location = new Point(335, 166);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(261, 41);
            UPassTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(148, 169);
            label3.Name = "label3";
            label3.Size = new Size(138, 33);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(341, 260);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(740, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 33);
            label8.TabIndex = 9;
            label8.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(UPassTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 416);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(335, 314);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 10;
            label2.Text = "Cancel";
            label2.Click += label2_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UPassTb;
        private Label label3;
        private Button LoginBtn;
        private Label label8;
        private Panel panel2;
        private Label label2;
    }
}