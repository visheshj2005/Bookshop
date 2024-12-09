using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TIKOGBR\SQLEXPRESS;Initial Catalog=BookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");

        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(Qty.Text);
            try
            {
                Con.Open();
                string query = "UPDATE BookTbl SET BQty=" + newQty + "where BId=" + key + ";";

                SqlCommand cmd = new SqlCommand(query, Con);


                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int n = 0, Grdtotal;
        private void Save_Click(object sender, EventArgs e)
        {

            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(BillDGV);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = BTitleTb.Text;
                newrow.Cells[2].Value = Qty.Text;
                newrow.Cells[3].Value = PriceTb.Text;
                newrow.Cells[4].Value = total;
                BillDGV.Rows.Add(newrow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "Rs " + Grdtotal.ToString();
            }
        } // Closing bracket for Save_Click added here

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delegate the logic to the CellClick handler
            BookDGV_CellClick(sender, e);
        }

        int key = 0, stock = 0;

        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the clicked row is valid (exclude header rows and out-of-range clicks)
                if (e.RowIndex >= 0 && e.RowIndex < BookDGV.Rows.Count)
                {
                    // Access the clicked row
                    DataGridViewRow row = BookDGV.Rows[e.RowIndex];

                    // Check if the row has sufficient cells
                    if (row.Cells.Count >= 5)
                    {
                        // Populate the text boxes with row's cell values
                        BTitleTb.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                        //Qty.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                        PriceTb.Text = row.Cells[5].Value?.ToString() ?? string.Empty;

                        if (BTitleTb.Text == "")
                        {
                            key = 0;
                            stock = 0;
                        }
                        // Parse the key from the first cell, if possible
                        else
                        {
                            key = int.TryParse(row.Cells[0].Value?.ToString(), out int parsedKey) ? parsedKey : 0;
                            stock = int.TryParse(row.Cells[4].Value?.ToString(), out int parsedStock) ? parsedStock : 0;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display any unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            Qty.Text = "";
            PriceTb.Text = "";
            Client.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            if (Client.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTb; values ('" + UserNameLbl.Text + "','" + Client.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();
                    //populate();
                    //Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }



            }

        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("Id product price quantity total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Grand Total : " + Grdtotal + " Đồng", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(26, pos + 50));
            e.Graphics.DrawString("***********Book Store***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = login.UserName;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
