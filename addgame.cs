using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sportsmanagementsystem
{
    public partial class addgame : Form
    {
        string stime, etime, newdate, gid2, user, ID;
        public addgame(string ID, string user)
        {
            InitializeComponent();
            this.user = user;
            this.ID = ID;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            newdate = selectedDate.ToString("dd-mm-yyyy");
            TimeSpan timeSpan = TimeSpan.Parse(textBox2.Text);
            TimeSpan timeSpan2 = TimeSpan.Parse(textBox3.Text);



            if (user == "Organizer")
            {
                //int.TryParse(textBox1.Text, out eventid);
                //int.TryParse(textBox5.Text, out orgid);
                //int.TryParse(textBox6.Text, out price);
                // int.TryParse(textBox7.Text, out no);
                //try
                //{
                string connstring = "server=localhost;uid=root;pwd=student342;database=sportsmanagementsys";
                //MySqlConnection con = new MySqlConnection(connstring);
                //con.Open();
                //string query = "call insertevents(" + eventid + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + orgid + ")";
                //MySqlCommand cmd = new MySqlCommand(query, con);
                //int i = cmd.ExecuteNonQuery();

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql1 = "Select * from games";

                MySqlCommand cmd2 = new MySqlCommand(sql1, con);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    {

                        gid2 = reader["GameID"].ToString();
                        if (gid2 == textBox1.Text)
                        {
                            MessageBox.Show("Game ID already exists");
                            break;
                        }
                    }


                }
                con.Close();

                if (gid2 != textBox1.Text)
                {


                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("AddGame", connection))
                        {
                            // Set the command type to stored procedure
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            cmd.Parameters.AddWithValue("@p_GameID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@p_GameDate", DateTime.Now.Date);
                            cmd.Parameters.AddWithValue("@p_StartTime", timeSpan); // Replace with your actual start time
                            cmd.Parameters.AddWithValue("@p_EndTime", timeSpan2);   // Replace with your actual end time
                            cmd.Parameters.AddWithValue("@p_Location", textBox4.Text);
                            cmd.Parameters.AddWithValue("@p_HomeTeamID", textBox5.Text);  // Replace with your actual home team ID
                            cmd.Parameters.AddWithValue("@p_AwayTeamID", textBox6.Text);  // Replace with your actual away team ID
                            cmd.Parameters.AddWithValue("@p_TeamID", textBox7.Text);      // Replace with your actual team ID


                            connection.Open();
                            int i = cmd.ExecuteNonQuery();
                            connection.Close();
                            if (i > -1)
                            {
                                MessageBox.Show("Added a new Game!");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an organizer can add a game.");
            }

        }

        private void addgame_Load(object sender, EventArgs e)
        {
           // dateTimePicker1.Format = DateTimePickerFormat.Time;
          //  dateTimePicker1.ShowUpDown = true;
           // dateTimePicker2.Format = DateTimePickerFormat.Time;
           // dateTimePicker2.ShowUpDown = true;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
