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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TIKOGBR\SQLEXPRESS;Initial Catalog=BookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");
        public static string UserName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName='" + UNameTb.Text + "'and UPass='" + UPassTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserName = UNameTb.Text;
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            Obj.Show();
            this.Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Your click event logic here
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Your click event logic here
        }
        private void label5_Click(object sender, EventArgs e)
        {
            // Your click event logic here
        }
        private void label6_Click(object sender, EventArgs e)
        {
            // Your click event logic here
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Your picture box click event logic here
        }
        private void UNameTb_TextChanged(object sender, EventArgs e)
        {
            // Your text box text changed event logic here
        }

        private void UPassTb_TextChanged(object sender, EventArgs e)
        {
            // Your password text box text changed event logic here
        }

    }
}
