using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Restaurant_Management_WEB_APP
{
   
    public partial class Form2 : Form
    {   
        user X;
        Form3 F3;
        
        user[] U = new user[4];
        public string s = "";
        Timer timer = new Timer();
        
        Form4 F4 = new Form4();
        
        public Form2(user a)
        {
            InitializeComponent();
            X = a;
            
            s = a.getName() + " " + a.getFamilyName();
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 800;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            label9.Text = s;
            label3.BackColor = System.Drawing.Color.Empty;
            PersianCalendar p = new PersianCalendar();
            DateTime dt = DateTime.Now;
            int y, m, d;
            y = p.GetYear(dt);
            m = p.GetMonth(dt);
            d = p.GetDayOfMonth(dt);
            lblDate.Text = y.ToString() + "/"
            + m.ToString() + "/"
            + d.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(X);
            F4.Hide();
            F3.Hide();
            F4.pictureBox16.Hide();
            F4.T6.Hide();
            F4.T5.Hide();
            F4.T4.Hide();
            F4.T3.Hide();
            F4.T2.Hide();
            F4.T1.Hide();
            F4.label21.Hide();
            F4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(X);
            F4.Hide();
            F3.Hide();
            F4.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(X);
            F3.Hide();
            F4.Hide();
            F3.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(X);
            F4.Hide();
            F3.Hide();
            F4.Show();
            F4.T6.Show();
            F4.T5.Show();
            F4.T4.Show();
            F4.T3.Show();
            F4.T2.Show();
            F4.T1.Show();
            F4.label21.Show();
            F4.pictureBox16.Show();
            
            
        }
    }
}
