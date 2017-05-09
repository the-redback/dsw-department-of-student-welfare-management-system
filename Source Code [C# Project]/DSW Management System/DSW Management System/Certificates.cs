using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSW_Management_System
{
    public partial class Certificates : UserControl
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idText.Text.Length != 0 )
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO certificates (student_id, issue_status) VALUES ( @id, 'issued');";
                cmd.Parameters.AddWithValue("@id", idText.Text);

                cmd.Connection = connect;
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Certificate Issue Entry Successful.");
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Incorrect Information Format!");
                }
            }
            else
            {
                MessageBox.Show("Feild is Empty");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE certificates SET issue_status='Delivered' WHERE student_id=@id";
                cmd.Parameters.AddWithValue("@id", idText.Text);

                cmd.Connection = connect;
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Certificate Deliver Entry Successful.");
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Incorrect Information Format!");
                }
            }
            else
            {
                MessageBox.Show("Feild is Empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            textBox1.Text = "";
        }
    }
}
