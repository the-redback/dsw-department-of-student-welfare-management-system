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
    public partial class offenses : UserControl
    {
        public offenses()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idText.Text.Length != 0 && dateOfShowCause.Text.Length!=0 && actNo.Text.Length!=0 && dateOfShowCause.Text.Length!=0 && violationDetails.Text.Length!=0)
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO offenses (offense_id,Student_id, violation_of_act_no, date_Of_Violation, date_Of_ShowCause, violation_Details) VALUES (NULL,@student_id, @violation_of_act_no, @date_Of_Violation, @date_Of_ShowCause, @violation_Details);";
                cmd.Parameters.AddWithValue("@student_id", idText.Text);
                cmd.Parameters.AddWithValue("@violation_of_act_no", actNo.Text);
                cmd.Parameters.AddWithValue("@date_Of_Violation", dateOfViolation.Text);
                cmd.Parameters.AddWithValue("@date_Of_ShowCause", dateOfShowCause.Text);
                cmd.Parameters.AddWithValue("@violation_Details", violationDetails.Text);

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
            else
            {
                MessageBox.Show("Incorrect Information Format!");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            dateOfShowCause.Text = "";
            dateOfViolation.Text = "";
            violationDetails.Text = "";
            actNo.Text = "";

        }
    }
}
