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

namespace HotelManagement
{
    public partial class Roominfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surov\OneDrive\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            roomgridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Roominfo()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)
            
                isfree = "free";
            
            else
            
                isfree = "busy";
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_table values('" + roomidtbl.Text + "','" + roomphonetbl.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();
        }

        private void Roominfo_Load(object sender, EventArgs e)
        {
            stDatelbl.Text = DateTime.Now.ToLongTimeString();

            populate();
        }

        private void roomgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomidtbl.Text = roomgridview.SelectedRows[0].Cells[0].Value.ToString();
            roomphonetbl.Text = roomgridview.SelectedRows[0].Cells[1].Value.ToString();
           
            populate();
        }

        private void DeleteroomBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "delete from Room_table where RoomId = " + roomidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted");
            Con.Close();
            populate();
        }

        private void EditroomBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)

                isfree = "free";

            else

                isfree = "busy";
            Con.Open();
            string myquery = "UPDATE Room_table set RoomId = '" + roomidtbl.Text + "', RoomPhone = '" + roomphonetbl.Text + "',RoomFree = '" + isfree + "' where RoomId= " + roomidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate();
        }

        private void roomsearch_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_table where RoomId = '" + roomsearchtbl.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            roomgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void roomrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roomidtbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
