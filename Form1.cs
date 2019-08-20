using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int t, t2, t3, t4, t5, t6;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }

        //Start
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t++;
            
            if (t == 10)
            {
                t2 = t2 + 1;
                t = 0;
                if (t2 == 6)
                {
                    t2 = 0;
                    t3 = t3 + 1;
                    if (t3 == 10)
                    {
                        t3 = 0;
                        t4 = t4 + 1;
                        if (t4 == 6)
                        {
                            t4 = 0;
                            t5 = t5 + 1;
                            if(t5 == 10)
                            {
                                t5 = 0;
                                t6 = t6 + 1;
                            }
                        }
                    }
                }

            }
            label4.Text = t.ToString();
            label5.Text = t2.ToString();
            label6.Text = t3.ToString();
            label7.Text = t4.ToString();
            label8.Text = t5.ToString();
            label9.Text = t6.ToString();
        }

        //Timecount
        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + label9.Text 
                    + label8.Text + ":" + label7.Text + label6.Text + ":" + label5.Text 
                    + label4.Text;
            }
            else
            {
                textBox1.Text = label2.Text;
            }
        }

        //Stop
        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        
        //Reset
        private void Button4_Click(object sender, EventArgs e)
        {
            t = 0;
            t2 = 0;
            t3 = 0;
            t4 = 0;
            t5 = 0;
            t6 = 0;
            label4.Text = t.ToString();
            label5.Text = t2.ToString();
            label6.Text = t3.ToString();
            label7.Text = t4.ToString();
            label8.Text = t5.ToString();
            label9.Text = t6.ToString();
        }
    }
}
