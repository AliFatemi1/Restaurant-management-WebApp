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
using System.Runtime.InteropServices;

namespace Restaurant_Management_WEB_APP
{
    public partial class Form4 : Form
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

        food[] F = new food[10];
        drink[] D = new drink[5];
        NumericUpDown[] N = new NumericUpDown[10];
        NumericUpDown[] S = new NumericUpDown[5];
        RichTextBox[] T = new RichTextBox[6];
        PersianCalendar p = new PersianCalendar();
        int orderNumber = 0;
        bool state = true;
        public Form4()
        {
            InitializeComponent();
            
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label20.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            label30.Hide();
            label18.Text = "0" + "تومان ";

            T[0] = T1;
            T[1] = T2;
            T[2] = T3;
            T[3] = T4;
            T[4] = T5;
            T[5] = T6;

            F[0] = new food("قرمه سبزی", 18000, "N1");
            F[1] = new food("قیمه بادمجان", 22000, "N2");
            F[2] = new food("ماکارانی", 19000, "N3");
            F[3] = new food("کتلت", 24000, "N4");
            F[4] = new food("قیمه", 17000, "N5");
            F[5] = new food("جوجه کباب", 35000, "N6");
            F[6] = new food("چلو ماهی", 32000, "N7");
            F[7] = new food("ته چین", 28000, "N8");
            F[8] = new food("زرشک پلو", 30000, "N9");
            F[9] = new food("کباب کوبیده", 35000, "N10");

            
            D[0] = new drink("نوشابه خانواده", 12500, "S1");
            D[1] = new drink("دلستر", 10000, "S2");
            D[2] = new drink("نوشابه قوطی", 5500, "S3");
            D[3] = new drink("نوشابه کوچک", 5000, "S4");
            D[4] = new drink("دوغ آبعلی", 7000, "S5");

            N[0] = N1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            label18.Text = "0" + "تومان ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Int64 price = 0;
            price = (Int32.Parse(N1.Value.ToString()) * Int32.Parse(F[0].getPrice().ToString()) +
                    (Int32.Parse(N2.Value.ToString()) * Int32.Parse(F[1].getPrice().ToString()) +
                    (Int32.Parse(N3.Value.ToString()) * Int32.Parse(F[2].getPrice().ToString()) +
                    (Int32.Parse(N4.Value.ToString()) * Int32.Parse(F[3].getPrice().ToString()) +
                    (Int32.Parse(N5.Value.ToString()) * Int32.Parse(F[4].getPrice().ToString()) +
                    (Int32.Parse(N6.Value.ToString()) * Int32.Parse(F[5].getPrice().ToString()) +
                    (Int32.Parse(N7.Value.ToString()) * Int32.Parse(F[6].getPrice().ToString()) +
                    (Int32.Parse(N8.Value.ToString()) * Int32.Parse(F[7].getPrice().ToString()) +
                    (Int32.Parse(N9.Value.ToString()) * Int32.Parse(F[8].getPrice().ToString()) +
                    (Int32.Parse(N10.Value.ToString()) * Int32.Parse(F[9].getPrice().ToString()) +
                    (Int32.Parse(S1.Value.ToString()) * Int32.Parse(D[0].getPrice().ToString()) +
                    (Int32.Parse(S2.Value.ToString()) * Int32.Parse(D[1].getPrice().ToString()) +
                    (Int32.Parse(S3.Value.ToString()) * Int32.Parse(D[2].getPrice().ToString()) +
                    (Int32.Parse(S4.Value.ToString()) * Int32.Parse(D[3].getPrice().ToString()) +
                    (Int32.Parse(S5.Value.ToString()) * Int32.Parse(D[4].getPrice().ToString())
                    )))))))))))))));
            label18.Text = price.ToString() + "تومان ";

            N[0] = N1;
            N[1] = N2;
            N[2] = N3;
            N[3] = N4;
            N[4] = N5;
            N[5] = N6;
            N[6] = N7;
            N[7] = N8;
            N[8] = N9;
            N[9] = N10;

            S[0] = S1;
            S[1] = S2;
            S[2] = S3;
            S[3] = S4;
            S[4] = S5;

            for (int i = 0; i < 15; i++)
            {
                if (i < 10)
                {
                    if (N[i].Value != 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + F[i].getName() + "   " + N[i].Value + "پرس\n";
                        richTextBox1.Text = richTextBox1.Text + F[i].getPrice() * N[i].Value + "\n * * * * * * * * * * * * * * * *\n";
                    }
                }
                else
                {
                    if (S[(i - 10)].Value != 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + D[(i - 10)].getName() + "   " + S[(i - 10)].Value + "عدد\n";
                        richTextBox1.Text = richTextBox1.Text + D[(i - 10)].getPrice() * S[(i - 10)].Value + "\n * * * * * * * * * * * * * * * *\n";
                    }
                    if (i == 14)
                        break;
                }
                if (i == 14)
                    label30.Show();
            }
            label30.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i < 10)
                {
                    N[i].Value = 0;
                }
                else
                {
                    S[(i-10)].Value = 0; ;
                }
            }
            DateTime dt = DateTime.Now;
            int y, m, d;
            y = p.GetYear(dt);
            m = p.GetMonth(dt);
            d = p.GetDayOfMonth(dt);
            for (int i = 0; i <= 5; i++)
            {
                if (richTextBox1.Text == "")
                {
                    label30.Show();
                }
                else if (T[i].Text == "" && richTextBox1.Text != "")
                {
                    T[i].BackColor = System.Drawing.Color.White;
                    T[i].Text = "سفارش " + (i + 1) + "\n\n" + y.ToString() + "/" + m.ToString() + "/" + d.ToString()  + "\n" + DateTime.Now.ToString("HH:mm:ss tt") +"\n\n" + richTextBox1.Text + "\n" + "مبلغ : " + label18.Text ;
                    if (i == 5)
                    {
                        state = false;
                    }
                    break;
                }
                
            }
            if (T[5].Text != "" && richTextBox1.Text != "" && state == true)
            {
                orderNumber++;
                for (int j = 0; j < 5; j++)
                {
                    T[j].Text = T[j + 1].Text;
                    
                }
                T[5].Text = "سفارش " + (orderNumber + 6) + "\n\n" + y.ToString() + "/" + m.ToString() + "/" + d.ToString() + "\n" + DateTime.Now.ToString("HH:mm:ss tt") + "\n\n" + richTextBox1.Text + "\n" + "مبلغ : " + label18.Text;
      
            }
            state = true;
            richTextBox1.Text = "";
            label18.Text = "0" + "تومان ";
        }
    }
}
