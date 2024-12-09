using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            populate();
            

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TIKOGBR\SQLEXPRESS;Initial Catalog=BookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values ('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where UId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserDGV_CellClick(sender, e);
        }
        int key = 0;
        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the clicked row is valid (exclude header rows and out-of-range clicks)
                if (e.RowIndex >= 0 && e.RowIndex < UserDGV.Rows.Count)
                {
                    // Access the clicked row
                    DataGridViewRow row = UserDGV.Rows[e.RowIndex];

                    // Check if the row has sufficient cells
                    if (row.Cells.Count >= 5)
                    {
                        // Populate the text boxes with row's cell values
                        UnameTb.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                        PhoneTb.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                        AddTb.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                        PassTb.Text = row.Cells[4].Value?.ToString() ?? string.Empty;

                        // Parse the key from the first cell, if possible
                        key = int.TryParse(row.Cells[0].Value?.ToString(), out int parsedKey) ? parsedKey : 0;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE UserTbl SET UName=@UnameTb, UPhone=@PhoneTb, UAdd=@AddTb, UPass=@PassTb WHERE UId=@UId";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    // Adding parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@UnameTb", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@PhoneTb", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AddTb", AddTb.Text);
                    cmd.Parameters.AddWithValue("@PassTb", PassTb.Text);

                    cmd.Parameters.AddWithValue("@UId", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Books Obj = new Books();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void users_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UserDGV.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

        }
    }
}
