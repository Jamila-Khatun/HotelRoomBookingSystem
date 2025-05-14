using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 login=new Form1();
            login.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Clientinfo clinfo = new Clientinfo();
            clinfo.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Staffinfo staffinfo = new Staffinfo();
            staffinfo.Show();
            this.Hide();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Roominfo roominfo = new Roominfo();
            roominfo.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reservationinfo reservationinfo = new Reservationinfo();
            reservationinfo.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
