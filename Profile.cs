using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsmanagementsystem
{
    public partial class Profile : Form
    {
        string ID, user1, user, getid;
        public Profile(string ID, string user)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            user1 = user;

            label1.Text = user + " ID";
            label2.Text = user + " NAME";
            label3.Text = user + " PHONE NO.";
            label4.Text = ID;
            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from " + user;
                if (user == "Players")
                {
                    user1 = "Player";
                }
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getid = reader[user1 + "ID"].ToString();
                    if (ID == getid)
                    {
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");
                        MessageBox.Show("Connected");
                        label5.Text = reader[user1 + "Name"].ToString();
                        label6.Text = reader[user1 + "Phone"].ToString();
                    }


                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
