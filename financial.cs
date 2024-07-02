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
    public partial class financial : Form
    {
        string ID, user, getid, no, eid2;
        int eid, num;
        public financial(string ID, string user)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;
        }

        private void financial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out eid);

            string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "Select * from tickets";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getid = reader["eventID"].ToString();
                if (getid == textBox1.Text)
                {
                    // MessageBox.Show("Name: " + reader["PlayerName"] + ".");

                    no = reader["number"].ToString();

                }
            }

            int.TryParse(no, out num);
            if (num == 0)
            {
                MessageBox.Show("SOLD OUT");
            }

            ticket fr = new ticket(ID, user, eid, num);
            fr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
