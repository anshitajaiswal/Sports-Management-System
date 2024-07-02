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
    public partial class Form2 : Form
    {
        string user, ID, pw = "qwerty", pw2, user1, getid, user2;

        public Form2(string user, string pw)
        {
            InitializeComponent();
            this.user = user;
            this.pw = pw;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = user + " LOGIN";
            label2.Text = user + " ID";
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
                user2 = reader["username"].ToString();
                pw2 = reader["password"].ToString();
                if (textBox1.Text == getid)
                {
                    if(textBox3.Text== user2)
                            {
                        if(textBox2.Text== pw2)
                        {
                            ID = textBox1.Text;
                            home fr2 = new home(ID, user);
                            this.Hide();
                            fr2.Show();

                        }
                        else
                        {
                            MessageBox.Show("wrong password");
                        }
                    }
                    break;
                    
                }


            }

            if(textBox1.Text != getid)
            {
                MessageBox.Show("wrong ID");

            }
            if (textBox3.Text != user2)
            {
                MessageBox.Show("wrong username");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgotpw fr = new forgotpw(user);
            this.Hide();
            fr.Show();

        }
    }
}
