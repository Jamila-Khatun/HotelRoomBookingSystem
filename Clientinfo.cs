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
using System.Collections;
namespace HotelManagement
{
    public partial class Clientinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surov\OneDrive\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da); 
            var ds = new DataSet();
            da.Fill(ds);
            Clientgridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_table values('"+clientidtbl.Text+"','"+clientnametbl.Text + "','"+phonenumbertbl.Text + "','"+countrytbl.SelectedItem.ToString() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void Clientgridview_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = Clientgridview.SelectedRows[0].Cells[0].Value.ToString();
            clientnametbl.Text = Clientgridview.SelectedRows[0].Cells[1].Value.ToString();
            phonenumbertbl.Text = Clientgridview.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_table set ClientName = '" + clientnametbl.Text + "', ClientPhone = '" + phonenumbertbl.Text + "',ClientCountry = '"+countrytbl.SelectedItem.ToString()+"'where ClientId= "+clientidtbl.Text+";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "delete from Client_table where ClientId = " + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Con.Open();
            string Myquery = "select * from Client_table where ClientName = '"+clientsearchtbl.Text+ "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Clientgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void clientsearchtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
            

        }

        private void countrytbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

