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
    public partial class Reservationinfo : Form
    {

        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\surov\OneDrive\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservationgridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Reservationinfo()
        {
            InitializeComponent();
        }
        DateTime today;
        private void reservationgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationid.Text = reservationgridview.SelectedRows[0].Cells[0].Value.ToString();
        }
        public void fillroomcobo()
        {
            Con.Open();
            string roomstate = "free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room_table where RoomFree = '"+roomstate+"'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            reroom.ValueMember = "RoomId";
            reroom.DataSource = dt;
            Con.Close() ;
        }
        public void fillclientcobo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_table", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            reclient.ValueMember = "ClientName";
            reclient.DataSource = dt;
            Con.Close();
        }
        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            reDatelbl.Text = DateTime.Now.ToLongTimeString();
            today = datein.Value;
            fillroomcobo();
            fillclientcobo();
            populate();
        } 

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(datein.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Wrong Date for Reservation");
            }

        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateout.Value, datein.Value);
            if (res < 0)
            {
                MessageBox.Show("Wrong Dateout. Check once more");
            }
        }
        public void updateroomstate()

        {
            
                Con.Open();
                string newstate = "busy";
                string myquery = "UPDATE Room_table set RoomFree = '" + newstate + "'where RoomId= " + Convert.ToInt32(reroom.SelectedValue.ToString())+ ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Reservation Successfully Edited");
                Con.Close();
               
               fillroomcobo();
            }
        public void updateroomondelete()

        {

            Con.Open();
            string newstate = "free";
            int roomid = Convert.ToInt32(reservationgridview.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "UPDATE Room_table set RoomFree = '" + newstate + "'where RoomId= " + roomid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Reservation Successfully Edited");
            Con.Close();

            fillroomcobo();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_table values('" + reservationid.Text + "','" + reclient.SelectedValue.ToString() + "','" + reroom.SelectedValue.ToString() + "','" + datein.Value + "','" + dateout.Value + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            populate();
            updateroomstate();
        }

        private void reclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (reservationid.Text == "")
            {
                MessageBox.Show("Enter the reservation to be deleted");
            }
            else
            {
                Con.Open();
                string Query = "delete from Reservation_table where ResId = " + reservationid.Text + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();
                updateroomondelete();
                populate();
            }
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (reservationid.Text == "")
            {
                MessageBox.Show("Please Enter the Reservation Id");
            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Reservation_table set Client = '" + reclient.SelectedValue.ToString() + "', Room = '" + reroom.SelectedValue.ToString() + "',DataIn = '" + datein.Value.ToString() + "',DataOut = '" + datein.Value.ToString() + "'where ResId= " + reservationid.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Edited");
                Con.Close();
                populate();
            }
        }

        private void research_Click(object sender, EventArgs e)
        {

            Con.Open();
            string Myquery = "select * from Reservation_table where ResId = '" + reservationsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservationgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void rerefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }

        private void reroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
