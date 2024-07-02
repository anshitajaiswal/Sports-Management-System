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
    public partial class playregister : Form
    {
        int playerid, teamid;
        public playregister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 10)
            {
                int.TryParse(textBox1.Text, out playerid);
                int.TryParse(textBox8.Text, out teamid);
                //try
                //{
                string connstring = "server=localhost;uid=root;pwd=student342;database=sportsmanagementsys";
                MySqlConnection con = new MySqlConnection(connstring);
                //con.ConnectionString = connstring;
                con.Open();
                string query = "insert into Players(PlayerID, PlayerName, PlayerPhone,username,password, sem, department, TeamID)  values(" + playerid + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'," + teamid + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i > -1)
                {
                    MessageBox.Show("Inserted");
                }
           

            Form1 fr = new Form1();
            fr.Show();
            }
            else
            {
                MessageBox.Show("Enter 10 digit phone no.");
            }
        }
    }
}
