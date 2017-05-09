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
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string conString;
            MySqlConnection connect;
            conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
            connect = new MySqlConnection(conString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM student_info Left JOIN offenses ON student_info.student_id=offenses.Student_id LEFT JOIN certificates on student_info.student_id=certificates.student_id where 1 ";
            if(idText.Text.Length!=0)
                sqlSelectAll += "and student_info.student_id=@id";
            if(deptText.Text.Length!=0)
                sqlSelectAll += "and student_info.dept=@dept";
            if (firstNameText.Text.Length!=0)
                sqlSelectAll += "and student_info.student_firstname=@firstName";
            if (middleNameText.Text.Length != 0)
                sqlSelectAll += "and student_info.student_student_middlename=@middleName";
            if (lastNameText.Text.Length != 0)
                sqlSelectAll += "and student_info.student_lastname=@lastName";
            if (contactText.Text.Length != 0)
                sqlSelectAll += "and student_info.contact_info=@contact";
            if (fatherText.Text.Length != 0)
                sqlSelectAll += "and student_info.fatherName=@fatherName";
            if (motherText.Text.Length != 0)
                sqlSelectAll += "and student_info.motherName=@motherName";
            if (parentContactText.Text.Length != 0)
                sqlSelectAll += "and student_info.parentContact=@parentContact";
            
            


            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, connect);
            MyDA.SelectCommand.Parameters.AddWithValue("@id", idText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@dept", deptText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@firstName", firstNameText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@middleName", middleNameText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@lastName", lastNameText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@contact", contactText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@fatherName", fatherText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@motherName", motherText.Text);
            MyDA.SelectCommand.Parameters.AddWithValue("@parentContact", parentContactText.Text);


            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            firstNameText.Text = "";
            middleNameText.Text = "";
            lastNameText.Text = "";
            deptText.Text = "";
            contactText.Text = "";
            fatherText.Text = "";
            motherText.Text = "";
            parentContactText.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            idText.Text = "";
            firstNameText.Text = "";
            middleNameText.Text = "";
            lastNameText.Text = "";
            deptText.Text = "";
            contactText.Text = "";
            fatherText.Text = "";
            motherText.Text = "";
            parentContactText.Text = "";
        }
    }
}
