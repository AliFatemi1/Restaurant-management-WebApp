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

namespace Restaurant_Management_WEB_APP
{
    
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );
        user[] U = new user[4];
        user Y;
        public Form3(user X)
        {
            InitializeComponent();
            Y = X;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Hide();
            
            T2.Text = Y.getName();
            T3.Text = Y.getFamilyName();
            T1.Text = Y.getUserName();
            T5.Text = Y.getPhoneNumber();
            T7.Text = Y.getAddress();
            T6.Text = Y.getEmail();
            T4.Text = Y.getPassword();

            T4.PasswordChar = '*';
            {
                T2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T3.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T4.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T5.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T7.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T6.BorderStyle = System.Windows.Forms.BorderStyle.None;
                var label = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label7 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label6 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label5 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label4 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label3 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var label8 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                T2.Controls.Add(label);
                T3.Controls.Add(label7);
                T1.Controls.Add(label6);
                T4.Controls.Add(label8);
                T5.Controls.Add(label5);
                T7.Controls.Add(label4);
                T6.Controls.Add(label3);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            T2.Text = Y.getName();
            T3.Text = Y.getFamilyName();
            T1.Text = Y.getUserName();
            T5.Text = Y.getPhoneNumber();
            T7.Text = Y.getAddress();
            T6.Text = Y.getEmail();
            T4.Text = Y.getPassword();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (T1.Text != "" && T2.Text != "" && T3.Text != "" && T4.Text != "" && T5.Text != "" && T6.Text != "" && T7.Text != "")
            {
                Y.changeInformation(T2.Text, T3.Text, T5.Text, T7.Text, T1.Text, T6.Text, T4.Text);
                label8.Hide();
            }
            else
                label8.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                T4.UseSystemPasswordChar = true;
            else
                T4.UseSystemPasswordChar = false;


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                T4.TabStop = true;
                T4.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                T4.TabStop = false;
                T4.Enabled = false;
            }

        }
    }
    
}
