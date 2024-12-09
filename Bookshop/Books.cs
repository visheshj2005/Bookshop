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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Bookshop
{
    public partial class Books : Form
    {
        public Books()
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
        private void filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat = '" + CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || Bauthtb.Text == "" || QtyTb.Text == "" || Price.Text == "" || BCatTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values ('" + BTitleTb.Text + "','" + Bauthtb.Text + "','" + BCatTb.SelectedItem.ToString() + "','" + QtyTb.Text + "'," + Price.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
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

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            Bauthtb.Text = "";
            BCatTb.SelectedIndex = -1;
            Price.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delegate the logic to the CellClick handler
            BookDGV_CellClick(sender, e);
        }

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
                        Bauthtb.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                        BCatTb.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                        QtyTb.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                        Price.Text = row.Cells[5].Value?.ToString() ?? string.Empty;

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
                    string query = "delete from BookTbl where BId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || Bauthtb.Text == "" || QtyTb.Text == "" || Price.Text == "" || BCatTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE BookTbl SET BTitle=@BTitle, BAuthor=@BAuthor, BCat=@BCat, BQty=@BQty, BPrice=@BPrice WHERE BId=@BId";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    // Adding parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@BTitle", BTitleTb.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", Bauthtb.Text);
                    cmd.Parameters.AddWithValue("@BCat", BCatTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BQty", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@BPrice", Price.Text);
                    cmd.Parameters.AddWithValue("@BId", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated Successfully");
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

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            users Obj = new users();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            // Path to your Python executable and script
            string pythonPath = @"C:\Users\vishe\AppData\Local\Programs\Python\Python312\python.exe";
            string scriptPath = @"G:\My Drive\Programming Backup\Python tutorials course\Python Projects\Scan QR Code\scan1.py";
            string outputFilePath = @"G:\My Drive\Programming Backup\Python tutorials course\Python Projects\Scan QR Code\output.txt";

            try
            {
                // Step 1: Configure process to run the Python script
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    Arguments = "\"" + scriptPath + "\"", // Add quotes around the script path
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false // Allow scanner window
                };

                // Start the Python process
                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();

                    // Optional: Log Python script output or errors
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    if (!string.IsNullOrEmpty(output))
                    {
                        System.Diagnostics.Debug.WriteLine("Python Output: " + output);
                    }
                    if (!string.IsNullOrEmpty(error))
                    {
                        System.Diagnostics.Debug.WriteLine("Python Error: " + error);
                    }
                }

                // Step 2: Introduce a small delay before reading the file to ensure it has been written
                System.Threading.Thread.Sleep(500); // Wait for 500ms

                // Step 3: Check if output.txt was updated
                if (File.Exists(outputFilePath))
                {
                    string[] lines = File.ReadAllLines(outputFilePath);
                    System.Diagnostics.Debug.WriteLine("Output file content: " + string.Join(", ", lines)); // Debug output

                    // Check if file contains two lines with valid data
                    if (lines.Length == 5 && !string.IsNullOrWhiteSpace(lines[0]) && !string.IsNullOrWhiteSpace(lines[1]) && !string.IsNullOrWhiteSpace(lines[2]) && !string.IsNullOrWhiteSpace(lines[3]) && !string.IsNullOrWhiteSpace(lines[4]))
                    {
                        BTitleTb.Text = lines[0]; // Name
                        Bauthtb.Text = lines[1];
                        QtyTb.Text = lines[2];
                        Price.Text = lines[3];// Age
                        BCatTb.SelectedIndex = Convert.ToInt32(lines[4])-1;
                    }
                    else
                    {
                        BTitleTb.Text = "Invalid QR code!";
                        Bauthtb.Text = "";
                    }
                }
                else
                {
                    BTitleTb.Text = "Output file not found!";
                    Bauthtb.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception
                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message);
                BTitleTb.Text = "Error occurred!";
                Bauthtb.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
