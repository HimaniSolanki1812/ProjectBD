using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Registrations
{
    public partial class Form1 : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HardwareDb.mdf;Integrated Security=True";
        string gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();
            string query = "INSERT INTO register(Name, password, city, branch, gender) VALUES ('"
                           + nametextbox.Text + "', '"
                           + passtextbox.Text + "', '"
                           + citytextbox.SelectedItem.ToString() + "', '"
                           + branchtextbox.SelectedItem.ToString() + "', '"
                           + gender + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("register successfully");

            

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
