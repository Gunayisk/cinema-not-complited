using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1Mebleg = 0;
        int seans2 = 0;
        int seans2Mebleg = 0;
        int seans3 = 0;
        int seans3Mebleg = 0;
        int popcorn = 0;
        int popcornMebleg = 0;
        int cola = 0;
        int colaMebleg = 0;
        int water = 0;
        int waterMebleg = 0;

        private void button1_Click(object sender, EventArgs e)
        
        {
            seans1++;
            seans1Mebleg=seans1Mebleg+8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1Mebleg.ToString();
            if (seans1==40)
            {
                button1.Enabled = false;
            }
            if (seans1>=0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1Mebleg = seans1Mebleg - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1Mebleg.ToString();
            if (seans1==0)
            {
                button2.Enabled = false;
            }
            if (seans1<=40)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2Mebleg = seans2Mebleg + 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2Mebleg.ToString();
            if (seans2 == 40)
            {
                button3.Enabled = false;
            }
            if (seans2 >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2Mebleg = seans2Mebleg - 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2Mebleg.ToString();
            if (seans2 == 0)
            {
                button4.Enabled = false;
            }
            if (seans2 <= 40)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3Mebleg = seans3Mebleg + 12;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3Mebleg.ToString();
            if (seans3 == 40)
            {
                button5.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3Mebleg = seans3Mebleg - 12;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3Mebleg.ToString();
            if (seans3 == 0)
            {
                button6.Enabled = false;
            }
            if (seans3 <= 40)
            {
                button5.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            popcorn++;
            popcornMebleg = popcornMebleg + 4;
            textBox7.Text = popcorn.ToString();
            textBox8.Text =  popcornMebleg.ToString();
            if (popcorn==20)
            {
                button7.Enabled = false;
            }
            if (popcorn>=0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            popcorn--;
            popcornMebleg = popcornMebleg - 4;
            textBox7.Text = popcorn.ToString();
            textBox8.Text = popcornMebleg.ToString();
            if (popcorn == 0)
            {
                button8.Enabled = false;
            }
            if (popcorn >= 20)
            {
                button7.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cola++;
            colaMebleg = colaMebleg + 2;
            textBox9.Text = cola.ToString();
            textBox10.Text = colaMebleg.ToString();
            if (cola == 20)
            {
                button10.Enabled = false;
            }
            if (cola >= 0)
            {
                button9.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cola--;
            colaMebleg = colaMebleg - 2;
            textBox9.Text = cola.ToString();
            textBox10.Text = colaMebleg.ToString();
            if (cola == 0)
            {
                button9.Enabled = false;
            }
            if (cola >= 20)
            {
                button10.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            water++;
            waterMebleg = waterMebleg + 2;
            textBox11.Text = water.ToString();
            textBox12.Text = waterMebleg.ToString();
            if (water == 20)
            {
                button12.Enabled = false;
            }
            if (water >= 0)
            {
                button11.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            water--;
            waterMebleg = waterMebleg - 2;
            textBox11.Text = water.ToString();
            textBox12.Text = waterMebleg.ToString();
            if (water == 0)
            {
                button11.Enabled = false;
            }
            if (water >= 20)
            {
                button12.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            newForm myCinema = new newForm();
            myCinema.Show();
            this.Hide();
        }
    }
}
