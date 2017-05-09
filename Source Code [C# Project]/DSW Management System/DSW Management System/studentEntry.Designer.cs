using System.Windows.Forms;
namespace DSW_Management_System
{
    partial class studentEntry
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.deptText = new System.Windows.Forms.TextBox();
            this.fatherText = new System.Windows.Forms.TextBox();
            this.motherText = new System.Windows.Forms.TextBox();
            this.contactText = new System.Windows.Forms.TextBox();
            this.permText = new System.Windows.Forms.TextBox();
            this.presentText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.parentContactText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(260, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Father\'s Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mother\'s Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Permanent Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Present Address:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(221, 64);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameText.Multiline = true;
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(151, 21);
            this.firstNameText.TabIndex = 10;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(221, 16);
            this.idText.Margin = new System.Windows.Forms.Padding(2);
            this.idText.Multiline = true;
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(151, 21);
            this.idText.TabIndex = 11;
            // 
            // deptText
            // 
            this.deptText.Location = new System.Drawing.Point(564, 16);
            this.deptText.Margin = new System.Windows.Forms.Padding(2);
            this.deptText.Multiline = true;
            this.deptText.Name = "deptText";
            this.deptText.Size = new System.Drawing.Size(151, 21);
            this.deptText.TabIndex = 12;
            // 
            // fatherText
            // 
            this.fatherText.Location = new System.Drawing.Point(221, 148);
            this.fatherText.Margin = new System.Windows.Forms.Padding(2);
            this.fatherText.Multiline = true;
            this.fatherText.Name = "fatherText";
            this.fatherText.Size = new System.Drawing.Size(151, 21);
            this.fatherText.TabIndex = 14;
            // 
            // motherText
            // 
            this.motherText.Location = new System.Drawing.Point(221, 197);
            this.motherText.Margin = new System.Windows.Forms.Padding(2);
            this.motherText.Multiline = true;
            this.motherText.Name = "motherText";
            this.motherText.Size = new System.Drawing.Size(151, 21);
            this.motherText.TabIndex = 15;
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(564, 148);
            this.contactText.Margin = new System.Windows.Forms.Padding(2);
            this.contactText.Multiline = true;
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(151, 21);
            this.contactText.TabIndex = 16;
            // 
            // permText
            // 
            this.permText.Location = new System.Drawing.Point(221, 245);
            this.permText.Margin = new System.Windows.Forms.Padding(2);
            this.permText.Multiline = true;
            this.permText.Name = "permText";
            this.permText.Size = new System.Drawing.Size(151, 85);
            this.permText.TabIndex = 17;
            // 
            // presentText
            // 
            this.presentText.Location = new System.Drawing.Point(564, 245);
            this.presentText.Margin = new System.Windows.Forms.Padding(2);
            this.presentText.Multiline = true;
            this.presentText.Name = "presentText";
            this.presentText.Size = new System.Drawing.Size(151, 85);
            this.presentText.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(501, 381);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // parentContactText
            // 
            this.parentContactText.Location = new System.Drawing.Point(564, 192);
            this.parentContactText.Margin = new System.Windows.Forms.Padding(2);
            this.parentContactText.Multiline = true;
            this.parentContactText.Name = "parentContactText";
            this.parentContactText.Size = new System.Drawing.Size(151, 21);
            this.parentContactText.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(399, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Parent\'s Contact no:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 21, 23, 49, 7, 0);
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(564, 64);
            this.middleNameText.Margin = new System.Windows.Forms.Padding(2);
            this.middleNameText.Multiline = true;
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(151, 21);
            this.middleNameText.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Middle Name:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(221, 105);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameText.Multiline = true;
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(151, 21);
            this.lastNameText.TabIndex = 26;
            this.lastNameText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(118, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Last Name:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // studentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.parentContactText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.presentText);
            this.Controls.Add(this.permText);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.motherText);
            this.Controls.Add(this.fatherText);
            this.Controls.Add(this.deptText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentEntry";
            this.Size = new System.Drawing.Size(775, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox deptText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox fatherText;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.TextBox motherText;
        private System.Windows.Forms.TextBox parentContactText;
        private System.Windows.Forms.TextBox permText;
        private System.Windows.Forms.TextBox presentText;
        private System.Windows.Forms.Button button2;
        
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label12;
    }
}
