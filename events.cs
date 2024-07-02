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

    public partial class events : Form
    {
        string user, ID, user1, getid, eid, desc, ven, org, eid2;
        int eventid, orgid, price, no;
        public events(string user, string ID)
        {
            InitializeComponent();
            this.user = user;
            this.ID = ID;
        }

        private void events_Load(object sender, EventArgs e)
        {

            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from events";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");


                        eid = reader["EventID"].ToString();
                        user1 = reader["EventName"].ToString();
                        listBox1.Items.Add(">Event ID: " + eid + "   Event Name: " + user1);
                        comboBox1.Items.Add(eid);
                    }


                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == "Organizer")
            {
                int.TryParse(textBox1.Text, out eventid);
                int.TryParse(textBox5.Text, out orgid);
                int.TryParse(textBox6.Text, out price);
                int.TryParse(textBox7.Text, out no);
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
                string sql1 = "Select * from events";

                MySqlCommand cmd2 = new MySqlCommand(sql1, con);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    {

                        eid2 = reader["EventID"].ToString();
                        if (eid2 == textBox1.Text)
                        {
                            MessageBox.Show("Event ID already exists");
                            break;
                        }
                    }


                }
                con.Close();

                if (eid2 != textBox1.Text)
                {


                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("insertevents", connection))
                        {
                            // Set the command type to stored procedure
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            cmd.Parameters.AddWithValue("@p_id", eventid);
                            cmd.Parameters.AddWithValue("@p_name", textBox2.Text);
                            cmd.Parameters.AddWithValue("@p_desc", textBox3.Text);
                            cmd.Parameters.AddWithValue("@p_venue", textBox4.Text);
                            cmd.Parameters.AddWithValue("@p_oid", orgid);

                            connection.Open();
                            int i = cmd.ExecuteNonQuery();
                            connection.Close();
                            if (i > -1)
                            {
                                MessageBox.Show("Inserted into Events");
                            }

                        }
                    }


                    // MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string query1 = "insert into tickets(EventID, price, number)  values(" + eventid + "," + price + "," + no + ")";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    int j = cmd1.ExecuteNonQuery();
                    if (j > -1)
                    {
                        MessageBox.Show("Insertion complete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an organizer can add an event.");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from events";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");
                        eid = reader["EventID"].ToString();
                        user1 = reader["EventName"].ToString();
                        desc = reader["Description"].ToString();
                        ven = reader["Venue"].ToString();
                        org = reader["OrganizerID"].ToString();
                        if (comboBox1.Text == eid)
                        {
                            MessageBox.Show("Event ID: " + eid + "\nEvent Name: " + user1 + "\nDescription: " + desc + "\nVenue: " + ven + "\norganizerID: " + org);
                        }
                    }


                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
