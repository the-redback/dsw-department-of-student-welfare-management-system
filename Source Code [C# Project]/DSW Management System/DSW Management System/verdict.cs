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
    public partial class verdict : UserControl
    {
        public verdict()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idText.Text.Length != 0 && offenseId.Text.Length != 0 && dateOfVerdict.Text.Length != 0 && verdictDetails.Text.Length != 0)
            {
                string conString;
                MySqlConnection connect;
                conString = "server=localhost;port=3306;database=dsw_management_system;userid=root;password=;";
                connect = new MySqlConnection(conString);
                connect.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE offenses SET verdict_Details = @verdict, date_Of_Verdict = @dateOfVerdict WHERE offense_id = @offense_id and Student_id=@id;";
                cmd.Parameters.AddWithValue("@id", idText.Text);
                cmd.Parameters.AddWithValue("@offense_id", offenseId.Text);
                cmd.Parameters.AddWithValue("@dateOfVerdict", dateOfVerdict.Text);
                cmd.Parameters.AddWithValue("@verdict", verdictDetails.Text);

                cmd.Connection = connect;
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Verdict Data Entry Successful.");
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Incorrect Information Format!"+ex);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Information Format!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            nameText.Text = "";
            offenseId.Text = "";
            verdictDetails.Text = "";
        }
    }
}
