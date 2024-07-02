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
    public partial class ticket : Form
    {
        string ID, user, eid2, getid;
        int eid, playerid, no;
        public ticket(string ID, string user, int eid, int no)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;
            this.eid = eid;
            this.no = no;
        }

        private void ticket_Load(object sender, EventArgs e)
        {
            int.TryParse(ID, out playerid);
            eid2 = eid.ToString();

            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from events natural join tickets";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getid = reader["eventID"].ToString();
                    if (getid == eid2)
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");

                        label1.Text = reader["eventName"].ToString();
                        textBox1.Text = reader["price"].ToString();
                        label5.Text = reader["number"].ToString() + " TICKETS REMAINING!";

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
            string connstring = "server=localhost;uid=root;pwd=student342;database=sportsmanagementsys";
            MySqlConnection con = new MySqlConnection(connstring);
            //con.ConnectionString = connstring;
            con.Open();
            string query = "insert into ticketbuyer(eventID, PlayerID)  values(" + eid + "," + playerid + ")";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            if (i > -1)
            {
                MessageBox.Show("Purchase Successful");
                no = no - 1;
                con.Close();
                con.Open();
                string query1 = "update tickets set number = " +no+ " where eventid= "+eid;
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                int j = cmd1.ExecuteNonQuery();

            }
        }
    }
}
