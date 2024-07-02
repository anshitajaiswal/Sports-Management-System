using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sportsmanagementsystem

{
    public partial class feedback : Form
    {
        string user, ID, getid, user1;
        public feedback(string user, string ID)
        {
            InitializeComponent();
            this.user = user;
            this.ID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection(connstring);
                //con.ConnectionString = connstring;
                con.Open();
                string query = "insert into feedback(username, feedback)  values('" + textBox5.Text + "','" + textBox2.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i > -1)
                {
                    MessageBox.Show("Inserted");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
