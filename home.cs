using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace sportsmanagementsystem
{
    public partial class home : Form
    {
        string ID, user;
        public home(string ID, string user)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;

        }
        public void connectDB()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=student342;database=sportsmanagementsys";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from Coach";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Name: " + reader["Coach_ID"] + ".");
                    MessageBox.Show("Connected");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;

            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;

            if (user == "Organizer")
            {
                fINANCIALSToolStripMenuItem.Enabled = false;
            }
        }

        private void pROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Profile fr = new Profile(ID, user);
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectDB();

        }

        private void eVENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {
                events fr = new events(user, ID);
                fr.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tEAMSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            teams1 fr = new teams1(ID, user);
            fr.Show();

        }

        private void aPPLICATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            games fr = new games(ID, user);
            fr.Show();
        }

        private void fINANCIALSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user == "Players")
            {
                financial fr = new financial(ID, user);
                fr.Show();
            }
            else if (user == "Coach")
            {

                Financials2 fr = new Financials2(ID, user);
                fr.Show();
            }
        }

        private void fEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {

            feedback fr = new feedback(user, ID);
            fr.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
            this.Hide();
        }
    }
}

