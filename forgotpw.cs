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

    public partial class forgotpw : Form
    {
        string pw, pw2;
        string user, user1, getid;
        public forgotpw(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void forgotpw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user1 = user;
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
                if (textBox1.Text == getid)
                {

                    break;
                }


            }
            if (textBox1.Text == getid)
            {
                pw = textBox2.Text;
                pw2 = textBox3.Text;
                if (textBox2.TextLength > 7)
                {
                    if (pw == pw2)
                    {

                        MySqlConnection con1 = new MySqlConnection(connstring);
                        //con.ConnectionString = connstring;
                        con1.Open();
                        string query = "update " + user + " set password='" + textBox2.Text + "' where " + user1 + "id= " + textBox1.Text;
                        MySqlCommand cmd1 = new MySqlCommand(query, con1);
                        int i = cmd1.ExecuteNonQuery();
                        if (i > -1)
                        {
                            MessageBox.Show("Password Updated");
                        }
                        Form2 fr = new Form2(user, pw);
                        this.Hide();
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Enter an 8 characters or more password");
                }
            }
            else
            {
                MessageBox.Show(user1 + "ID does not exist");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
