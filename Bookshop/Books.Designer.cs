namespace Bookshop
{
    partial class Books
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            panel2 = new Panel();
            RefreshBtn = new Button();
            CatCbSearchCb = new ComboBox();
            label4 = new Label();
            BookDGV = new DataGridView();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            Edit = new Button();
            label13 = new Label();
            Price = new TextBox();
            label12 = new Label();
            QtyTb = new TextBox();
            BCatTb = new ComboBox();
            label11 = new Label();
            label8 = new Label();
            Save = new Button();
            label3 = new Label();
            label2 = new Label();
            Bauthtb = new TextBox();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(CatCbSearchCb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(Edit);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(Price);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(BCatTb);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Save);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Bauthtb);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(268, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 541);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.White;
            RefreshBtn.Location = new Point(454, 242);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 32);
            RefreshBtn.TabIndex = 22;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // CatCbSearchCb
            // 
            CatCbSearchCb.FormattingEnabled = true;
            CatCbSearchCb.Items.AddRange(new object[] { "Programming", "Networking ", "Math", "Physics", "Science" });
            CatCbSearchCb.Location = new Point(221, 245);
            CatCbSearchCb.Name = "CatCbSearchCb";
            CatCbSearchCb.Size = new Size(186, 29);
            CatCbSearchCb.TabIndex = 21;
            CatCbSearchCb.Text = "Filter By Catagory";
            CatCbSearchCb.SelectionChangeCommitted += CatCbSearchCb_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(285, 220);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 20;
            label4.Text = "Books List";
            // 
            // BookDGV
            // 
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.BackgroundColor = Color.White;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle1;
            BookDGV.Location = new Point(3, 296);
            BookDGV.Name = "BookDGV";
            BookDGV.Size = new Size(682, 194);
            BookDGV.TabIndex = 19;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.White;
            ResetBtn.Location = new Point(509, 173);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 32);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.White;
            DeleteBtn.Location = new Point(381, 173);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 32);
            DeleteBtn.TabIndex = 17;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.White;
            Edit.Location = new Point(264, 173);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 32);
            Edit.TabIndex = 16;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(567, 92);
            label13.Name = "label13";
            label13.Size = new Size(47, 21);
            label13.TabIndex = 15;
            label13.Text = "Price";
            // 
            // Price
            // 
            Price.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.Location = new Point(567, 117);
            Price.Name = "Price";
            Price.Size = new Size(80, 27);
            Price.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(454, 92);
            label12.Name = "label12";
            label12.Size = new Size(80, 21);
            label12.TabIndex = 13;
            label12.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QtyTb.Location = new Point(454, 117);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(80, 27);
            QtyTb.TabIndex = 12;
            // 
            // BCatTb
            // 
            BCatTb.FormattingEnabled = true;
            BCatTb.Items.AddRange(new object[] { "Programming", "Networking ", "Math", "Physics", "Science" });
            BCatTb.Location = new Point(285, 116);
            BCatTb.Name = "BCatTb";
            BCatTb.Size = new Size(154, 29);
            BCatTb.TabIndex = 11;
            BCatTb.Text = "Select Catagory";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(285, 92);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 10;
            label11.Text = "Catagories";
            label11.Click += label11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(657, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 33);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.White;
            Save.Location = new Point(141, 173);
            Save.Name = "Save";
            Save.Size = new Size(75, 32);
            Save.TabIndex = 7;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(151, 93);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // Bauthtb
            // 
            Bauthtb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bauthtb.Location = new Point(151, 118);
            Bauthtb.Name = "Bauthtb";
            Bauthtb.Size = new Size(118, 27);
            Bauthtb.TabIndex = 4;
            // 
            // BTitleTb
            // 
            BTitleTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTitleTb.Location = new Point(3, 118);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(118, 27);
            BTitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(254, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 541);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(3, 317);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 41);
            panel6.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(67, 3);
            label10.Name = "label10";
            label10.Size = new Size(107, 33);
            label10.TabIndex = 6;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(6, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 41);
            panel5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(64, 3);
            label7.Name = "label7";
            label7.Size = new Size(78, 33);
            label7.TabIndex = 6;
            label7.Text = "Users";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(3, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 41);
            panel4.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(67, 3);
            label9.Name = "label9";
            label9.Size = new Size(160, 33);
            label9.TabIndex = 6;
            label9.Text = "Dashboard";
            label9.Click += label9_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(3, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 41);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(67, 3);
            label6.Name = "label6";
            label6.Size = new Size(91, 33);
            label6.TabIndex = 10;
            label6.Text = "Books";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(70, 19);
            label5.Name = "label5";
            label5.Size = new Size(153, 33);
            label5.TabIndex = 5;
            label5.Text = "Book Shop";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(968, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Books_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Button Save;
        private Label label3;
        private Label label2;
        private TextBox Bauthtb;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label label10;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Label label7;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label6;
        private ComboBox BCatTb;
        private Label label11;
        private Label label12;
        private TextBox QtyTb;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button Edit;
        private Label label13;
        private TextBox Price;
        private Button RefreshBtn;
        private ComboBox CatCbSearchCb;
        private Label label4;
        private DataGridView BookDGV;
    }
}