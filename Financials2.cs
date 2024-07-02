using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsmanagementsystem
{
    public partial class Financials2 : Form
    {
        string cid, user, ID;
        public Financials2(string ID, string user)
        {
            InitializeComponent();
            this.ID = ID;
            this.user = user;
        }

        private void Financials2_Load(object sender, EventArgs e)
        {

            try
            {
                string connstring = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from coach";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    {
                        cid= reader["CoachID"].ToString();
                        // MessageBox.Show("Name: " + reader["PlayerName"] + ".");
                        if (ID == cid)
                        {
                            textBox1.Text = reader["Salary"].ToString();
                        }

                    }


                }
                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }


            string connectionString = "server=localhost;database=sportsmanagementsys;uid=root;pwd=student342";

            // Create MySqlConnection and MySqlCommand
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("avgsalary", connection))
                {
                    // Set the command type to stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the stored procedure
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double averageSalary = Convert.ToDouble(reader["AverageSalary"]);
                                textBox2.Text = $"{averageSalary:C}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
