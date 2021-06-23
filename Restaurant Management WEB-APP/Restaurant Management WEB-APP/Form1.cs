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
    
    public partial class Form1 : Form
    {
        user[] U = new user[5];
        user X;
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
        public Form1()
        {
            
            U[0] = new user("سید علی", "فاطمی", "09300000000", "اصفهان", "971490003", "Ali.fatemi.30@gmail.com", "127312");
            U[1] = new user("فاطمه", "هاشمی", "09300000001", "اصفهان", "971490001", "Fateme.hashemi@gmail.com", "1");
            U[2] = new user("امیر", "برجیسیان", "09300000002", "اصفهان", "971490002", "Amirhosein.berjisian@gmail.com", "2");
            U[3] = new user("زهرا", "جعفری", "09300000003", "اصفهان", "971490014", "Zahra.Jafari@gmail.com", "3");
            U[4] = new user("","","","","","","");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void PictureBox1()
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                pictureBox8.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                T1.Hide();
                T2.Hide();
                T3.Hide();
                T4.Hide();
                T5.Hide();
                T6.Hide();
                T7.Hide();
                T8.Hide();
                button3.Hide();
                button4.Hide();
            }
            {
                T2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T3.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T4.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T5.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T7.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T6.BorderStyle = System.Windows.Forms.BorderStyle.None;
                T8.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
                var label9 = new Label()
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
                T8.Controls.Add(label9);
            }
            label4.Hide();
            label16.Hide();
            pictureBox4.BackColor = Color.FromArgb(127, pictureBox4.BackColor);
            label1.BackColor = Color.FromArgb(127, label1.BackColor);
            label2.BackColor = Color.FromArgb(127, label2.BackColor);
            label3.BackColor = Color.FromArgb(127, label3.BackColor);
            label4.BackColor = Color.FromArgb(127, label3.BackColor);
            label5.BackColor = Color.FromArgb(127, label3.BackColor);
            label6.BackColor = Color.FromArgb(127, label3.BackColor);
            {
                textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                var lbl1 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                var lbl2 = new Label()
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black
                };
                textBox1.Controls.Add(lbl1);
                textBox2.Controls.Add(lbl2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] userInfo = new string[5, 2]{
                                   { U[0].getUserName(),U[0].getPassword() },
                                   { U[1].getUserName(),U[1].getPassword() },
                                   { U[2].getUserName(),U[2].getPassword() },
                                   { U[3].getUserName(),U[3].getPassword() },
                                   { U[4].getUserName(),U[4].getPassword() }
              };
            for (int i = 0; i < 5; i++)
            {
                if (textBox1.Text == userInfo[i, 0] && textBox2.Text == userInfo[i, 1])
                {
                    X = U[i];
                    this.Hide();
                    Form2 F = new Form2(X);
                    F.Show();
                }
            }
            label5.Hide();
            label6.Hide();
            label4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            {
                pictureBox8.Show();
                label7.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label15.Show();
                T1.Show();
                T2.Show();
                T3.Show();
                T4.Show();
                T5.Show();
                T6.Show();
                T7.Show();
                T8.Show();
                button3.Show();
                button4.Show();
            }
            pictureBox3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Hide();
            label16.Hide();
            {
                pictureBox8.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                T1.Hide();
                T2.Hide();
                T3.Hide();
                T4.Hide();
                T5.Hide();
                T6.Hide();
                T7.Hide();
                T8.Hide();
                T1.Text = "";
                T2.Text = "";
                T3.Text = "";
                T4.Text = "";
                T5.Text = "";
                T6.Text = "";
                T7.Text = "";
                T8.Text = "";
                button3.Hide();
                button4.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (T4.Text != T8.Text)
            {
                label16.Show();
                label8.Hide();
            }
            else
            {
                label16.Hide();
                label8.Show();
                if (T1.Text != "" && T2.Text != "" && T3.Text != "" && T4.Text != "" && T5.Text != "" && T6.Text != "" && T7.Text != "")
                {
                    U[4] = new user(T2.Text, T3.Text, T5.Text, T7.Text, T1.Text, T6.Text, T4.Text);
                    label8.Hide();
                }
                else
                    label8.Show();
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    
}
