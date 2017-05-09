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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0 && textBox2.Text.Length!=0 && textBox3.Text.Length!=0 && textBox3.Text==textBox2.Text)
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO login (Username, Password) VALUES (@user, @pass);";
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                cmd.Connection = connect;
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Offenses Data Entry Successful.");
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Incorrect Information Format!");
                }
            }
            else if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Password Doesn't Match!!");
            }
            else
            {
                MessageBox.Show("Empty Field!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
