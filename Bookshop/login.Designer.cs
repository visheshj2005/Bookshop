namespace Bookshop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label4 = new Label();
            LoginBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            UPassTb = new TextBox();
            UNameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(22, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 416);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(46, 286);
            label7.Name = "label7";
            label7.Size = new Size(180, 33);
            label7.TabIndex = 8;
            label7.Text = "Nice Service";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(8, 197);
            label6.Name = "label6";
            label6.Size = new Size(233, 33);
            label6.TabIndex = 7;
            label6.Text = "Large Collection";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(46, 108);
            label5.Name = "label5";
            label5.Size = new Size(140, 33);
            label5.TabIndex = 6;
            label5.Text = "Nice Staff";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UPassTb);
            panel2.Controls.Add(UNameTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(278, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 416);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(479, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 33);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(216, 375);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 8;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(211, 335);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(14, 259);
            label3.Name = "label3";
            label3.Size = new Size(138, 33);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(14, 186);
            label2.Name = "label2";
            label2.Size = new Size(146, 33);
            label2.TabIndex = 5;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // UPassTb
            // 
            UPassTb.Font = new Font("Century Gothic", 20.25F);
            UPassTb.Location = new Point(200, 246);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(261, 41);
            UPassTb.TabIndex = 4;
            UPassTb.TextChanged += UPassTb_TextChanged;
            // 
            // UNameTb
            // 
            UNameTb.Font = new Font("Century Gothic", 20.25F);
            UNameTb.Location = new Point(200, 173);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(261, 41);
            UNameTb.TabIndex = 3;
            UNameTb.TextChanged += UNameTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(178, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            label1.Click += label1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox UPassTb;
        private TextBox UNameTb;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Button LoginBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label1;
    }
}