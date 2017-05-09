using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSW_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private studentEntry frm;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        

        private void leftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            search myForm = new search();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();


            b5.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "Search";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            container.Controls.Clear();
            studentEntry myForm = new studentEntry();
            myForm.AutoScroll = true;
            container.Controls.Add(myForm);
            myForm.Show();

            b0.BackColor = Color.FromArgb(41, 53, 65);
            b1.BackColor = Color.FromArgb(21, 33, 45);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "Student's Information Entry";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            container.Visible = false;
            /*
            DashboardMini myForm = new DashboardMini();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();
             * */
            
            b0.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "Dashboard";

        }

        private void b2_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            offenses myForm = new offenses();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();


            b2.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);
            headLabel.Text = "Violations : Offenses";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            verdict myForm = new verdict();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();

            b3.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);
            headLabel.Text = "Violations : Verdicts";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            Certificates myForm = new Certificates();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();

            b4.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "Character Certificate";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            Settings myForm = new Settings();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();

            b6.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);
            b7.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "Settings";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            container.Visible = true;
            about myForm = new about();
            myForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(myForm);
            myForm.Show();


            b7.BackColor = Color.FromArgb(21, 33, 45);

            b1.BackColor = Color.FromArgb(41, 53, 65);
            b2.BackColor = Color.FromArgb(41, 53, 65);
            b3.BackColor = Color.FromArgb(41, 53, 65);
            b4.BackColor = Color.FromArgb(41, 53, 65);
            b5.BackColor = Color.FromArgb(41, 53, 65);
            b6.BackColor = Color.FromArgb(41, 53, 65);
            b0.BackColor = Color.FromArgb(41, 53, 65);

            headLabel.Text = "About";
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
