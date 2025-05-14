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
    public partial class Staffinfo : Form
    {
       
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surov\OneDrive\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
            public void populate()
            {
                Con.Open();
                string Myquery = "select * from Staff_table";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Staffgridview.DataSource = ds.Tables[0];
                Con.Close();
            }
        
        public Staffinfo()
        {
            InitializeComponent();
        }

        private void Staffinfo_Load(object sender, EventArgs e)
        {
            stDatelbl.Text = DateTime.Now.ToLongTimeString();
           // timer1.Start();
            
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_table values('" + staffidtbl.Text + "','" + staffnametbl.Text + "','" + stphonenumbertbl.Text + "','" + gendertbl.SelectedItem.ToString() + "','" + staffpasstb.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void Staffgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            staffidtbl.Text = Staffgridview.SelectedRows[0].Cells[0].Value.ToString();
            staffnametbl.Text = Staffgridview.SelectedRows[0].Cells[1].Value.ToString();
            stphonenumbertbl.Text = Staffgridview.SelectedRows[0].Cells[2].Value.ToString();
            staffpasstb.Text = Staffgridview.SelectedRows[0].Cells[4].Value.ToString();
            populate();
        }

        private void staffidtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientsearchtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffsearch_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_table where Staffname = '" + staffsearchtbl.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Staffgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void staffrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            string myquery = "UPDATE Staff_table set Staffname = '" + staffnametbl.Text + "', Staffphone = '" + stphonenumbertbl.Text + "',gender = '" + gendertbl.SelectedItem.ToString() + "', Staffpassword = '" + staffpasstb.Text +"' where StaffId= " + staffidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            string Query = "delete from Staff_table where StaffId = " + staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted");
            Con.Close();
            populate();
        }

        private void stDatelbl_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }

        private void gendertbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stphonenumbertbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
