using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HotelManagement
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surov\OneDrive\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Staff_table where Staffname='" + usernametb.Text+"' and Staffpassword='"+passwordtb.Text+"' ",Con);
           
                DataTable dt=new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
        MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Wrong Username or Password");
            }
                Con.Close();
        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
