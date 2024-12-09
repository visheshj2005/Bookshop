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
using System.Xml;

namespace Bookshop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        private void label7_Click(object sender, EventArgs e)
        {
            users Obj = new users();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TIKOGBR\SQLEXPRESS;Initial Catalog=BookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(BQty) from BookTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStockLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from UserTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            UserTotalLbl.Text = dt1.Rows[0][0].ToString();
            Con.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
