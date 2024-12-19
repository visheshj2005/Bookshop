namespace Bookshop
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            label4 = new Label();
            ResetBtn = new Button();
            PrintBtn = new Button();
            label8 = new Label();
            Save = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            panel6 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            UserNameLbl = new Label();
            pictureBox2 = new PictureBox();
            TotalLbl = new Label();
            Qty = new TextBox();
            Client = new TextBox();
            BookDGV = new DataGridView();
            label9 = new Label();
            BillDGV = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            PriceTb = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(138, 315);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 20;
            label4.Text = "Books List";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.White;
            ResetBtn.Location = new Point(119, 220);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 32);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.White;
            PrintBtn.Location = new Point(484, 420);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(75, 32);
            PrintBtn.TabIndex = 16;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += Edit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(684, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 33);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.White;
            Save.Location = new Point(13, 220);
            Save.Name = "Save";
            Save.Size = new Size(75, 32);
            Save.TabIndex = 7;
            Save.Text = "Add to Bill";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(119, 94);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 5;
            label2.Text = "Book Name";
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
            // panel6
            // 
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(3, 497);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 41);
            panel6.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 541);
            panel1.TabIndex = 4;
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
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTitleTb.Location = new Point(3, 118);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(85, 27);
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(UserNameLbl);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(TotalLbl);
            panel2.Controls.Add(Qty);
            panel2.Controls.Add(Client);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(BillDGV);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(PrintBtn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Save);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(241, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 541);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = Color.Transparent;
            UserNameLbl.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLbl.ForeColor = Color.DimGray;
            UserNameLbl.Location = new Point(48, 5);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(146, 33);
            UserNameLbl.TabIndex = 34;
            UserNameLbl.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.BackColor = Color.Transparent;
            TotalLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLbl.ForeColor = Color.DimGray;
            TotalLbl.Location = new Point(495, 395);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(53, 22);
            TotalLbl.TabIndex = 32;
            TotalLbl.Text = "Total";
            // 
            // Qty
            // 
            Qty.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Qty.Location = new Point(119, 118);
            Qty.Name = "Qty";
            Qty.Size = new Size(85, 27);
            Qty.TabIndex = 31;
            // 
            // Client
            // 
            Client.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Client.Location = new Point(8, 172);
            Client.Name = "Client";
            Client.Size = new Size(94, 27);
            Client.TabIndex = 30;
            // 
            // BookDGV
            // 
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.BackgroundColor = Color.White;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Location = new Point(13, 340);
            BookDGV.Name = "BookDGV";
            BookDGV.Size = new Size(342, 194);
            BookDGV.TabIndex = 29;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(473, 69);
            label9.Name = "label9";
            label9.Size = new Size(87, 22);
            label9.TabIndex = 28;
            label9.Text = "Books Bill";
            // 
            // BillDGV
            // 
            BillDGV.BackgroundColor = Color.White;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column5 });
            BillDGV.Location = new Point(316, 94);
            BillDGV.Name = "BillDGV";
            BillDGV.Size = new Size(390, 205);
            BillDGV.TabIndex = 27;
            BillDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 148);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 26;
            label6.Text = "Client Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(119, 148);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 25;
            label7.Text = "Price";
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTb.Location = new Point(119, 172);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(85, 27);
            PriceTb.TabIndex = 23;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Qty";
            Column4.Name = "Column4";
            Column4.Width = 40;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            Column3.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            Column5.Width = 90;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(968, 565);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button ResetBtn;
        private Button PrintBtn;
        private Label label13;
        private TextBox Price;
        private Label label12;
   
        private ComboBox BCatTb;
        private Label TotalLbl;
        private Label label8;
        private Button Save;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
       
        private Label label10;
        private PictureBox pictureBox6;
        private Panel panel6;
        private Panel panel1;
        private Label label5;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox PriceTb;
        private DataGridView BillDGV;
        private Label label9;
        private DataGridView BookDGV;
        private TextBox Client;
        private TextBox Qty;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label UserNameLbl;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
    }
}