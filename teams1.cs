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

namespace sportsmanagementsystem
{
    public partial class teams1 : Form
    {
        string ID, getid, teamnam, captai, coachhid, user, user1 = "teams", tid;
        public teams1(string ID, string user)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tid = textBox1.Text;
            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = "Select * from Teams ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                
                while (reader.Read())
                {
                    teamnam = reader["TeamName"].ToString();
                    captai = reader["captain"].ToString();
                    coachhid = reader["coach_ID"].ToString();
                    getid = reader["TeamID"].ToString();
                    if (tid == getid)
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");
                        MessageBox.Show("team ID:" + tid + "\nTeam name:" + teamnam + "\nCaptain:" + captai + "\n Coach ID:" + coachhid);

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
            tid = textBox1.Text;
            editteams fr = new editteams(ID, user, user1,tid);
            fr.Show();
        }
    }
}
