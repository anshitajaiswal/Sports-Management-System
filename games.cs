using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsmanagementsystem
{
    public partial class games : Form
    {
        string ID, user, gid, gdate, st, et, loc, HTID, ATID, getid;

        public games(string ID, string user)
        {
            InitializeComponent();
            this.user = user;
            this.ID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gid = textBox1.Text;
            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = "Select * from Games ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    gdate = reader["GameDate"].ToString();
                    st = reader["StartTime"].ToString();
                    et = reader["EndTime"].ToString();
                    loc = reader["Location"].ToString();
                    HTID = reader["HomeTeamID"].ToString();
                    ATID = reader["AwayTeamID"].ToString();
                    getid = reader["GameID"].ToString();

                    if (gid == getid)
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");
                        MessageBox.Show("Game ID:" + gid + "\nGame date:" + gdate + "\nStart Time:" + st + "\n End Time:" + et + "\n Location:" + loc + "\n Home Team ID:" + HTID + "\nAway Team ID:" + ATID);

                    }


                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gid = textBox1.Text;
            addgame fr = new addgame(ID, user);
            fr.Show();
        }

        private void games_Load(object sender, EventArgs e)
        {

        }
    }
}
