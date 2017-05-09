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
    public partial class studentEntry : UserControl
    {
        public studentEntry()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idText.Text.Length != 0 && firstNameText.Text.Length != 0 && middleNameText.Text.Length != 0 && lastNameText.Text.Length != 0 && dateTimePicker1.Text.Length != 0 && deptText.Text.Length != 0 && contactText.Text.Length != 0 && fatherText.Text.Length != 0 && motherText.Text.Length != 0 && parentContactText.Text.Length != 0 && permText.Text.Length != 0 && presentText.Text.Length != 0)
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO student_info (student_id, student_firstname, student_middlename, student_lastname, dateOfBirth, dept, contact_info, fatherName, motherName, parentContact, permanentAddress, presentAddress) VALUES (@id, @firstName, @middleName, @lastName, @birth, @dept, @contact_info, @fatherName, @motherName, @parentContact, @permanentAddress, @presentAddress)";
                cmd.Parameters.AddWithValue("@id", idText.Text);
                cmd.Parameters.AddWithValue("@firstName", firstNameText.Text);
                cmd.Parameters.AddWithValue("@middleName", middleNameText.Text);
                cmd.Parameters.AddWithValue("@lastName", lastNameText.Text);
                cmd.Parameters.AddWithValue("@birth", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@dept", deptText.Text);
                cmd.Parameters.AddWithValue("@contact_info", contactText.Text);
                cmd.Parameters.AddWithValue("@fatherName", fatherText.Text);
                cmd.Parameters.AddWithValue("@motherName", motherText.Text);
                cmd.Parameters.AddWithValue("@parentContact", parentContactText.Text);
                cmd.Parameters.AddWithValue("@permanentAddress", permText.Text);
                cmd.Parameters.AddWithValue("@presentAddress", presentText.Text);

                cmd.Connection = connect;
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Student Data Entry Successful.");
                }
                catch
                {
                    connect.Close();
                    MessageBox.Show("Incorrect Information Format!");
                }
            }
            else
            {
                MessageBox.Show("Textbox can't be empty!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            firstNameText.Text = "";
            middleNameText.Text = "";
            lastNameText.Text = "";
            dateTimePicker1.Text = "";
            deptText.Text = "";
            contactText.Text = "";
            fatherText.Text = "";
            motherText.Text = "";
            parentContactText.Text = "";
            permText.Text = "";
            presentText.Text = "";

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
