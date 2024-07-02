using Microsoft.VisualBasic.ApplicationServices;

namespace sportsmanagementsystem
{
    public partial class Form1 : Form
    {
        string user, pw = "qwerty";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = comboBox1.Text;
            if (user != "")
            {
                Form2 fr = new Form2(user, pw);
                this.Hide();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Enter login detail.");


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user = comboBox2.Text;
            if (user == "Players")
            {
                playregister fr = new playregister();
                this.Hide();
                fr.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}