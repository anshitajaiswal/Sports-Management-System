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
    public partial class editteams : Form
    {
        string ID, user, user1, getid, tid;
        int cid, tid2;
        public editteams(string ID, string user, string user1, string tid)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;
            this.user1 = user1;
            this.tid = tid;
        }

        private void editteams_Load(object sender, EventArgs e)
        {
            try
            {
                if (user == "Coach")
                {
                    string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    user1 = "teams";
                    string sql = "Select * from Teams";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        getid = reader["TeamID"].ToString();
                        if (tid == getid)
                        {
                            // MessageBox.Show("Name: " + reader["PlayerName"] + ".");

                            label4.Text = tid;
                            textBox1.Text = reader["TeamName"].ToString();
                            textBox2.Text = reader["Captain"].ToString();
                            textBox3.Text = reader["Coach_ID"].ToString();
                        }
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
            try
            {

                if (user == "Coach")
                {
                    string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    int.TryParse(textBox3.Text, out cid);
                    int.TryParse(textBox3.Text, out tid2);
                    string query = " update teams set TeamName = ' " + textBox1.Text + " ' ,Captain = ' " + textBox2.Text + " ' ,Coach_ID = " + cid + " where teamID= " + tid2;

                    MySqlCommand cmd0 = new MySqlCommand(query, con);


                    int i = cmd0.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Updated");
                    }
                }
                else
                {
                    MessageBox.Show("only coaches can edit teams. you can only view teams");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
