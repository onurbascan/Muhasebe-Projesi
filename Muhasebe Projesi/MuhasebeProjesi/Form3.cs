using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProjesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double x,y;
        string z;
        int kontrol = 0;
       

        private void Form3_Load(object sender, EventArgs e)
        {
            z = " ";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                kontrol++;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                kontrol++;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                kontrol++;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                kontrol++;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                kontrol++;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                kontrol++;
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                kontrol++;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                kontrol++;
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                kontrol++;
            }
            
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (z == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
            }
            if (z == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
            }
            if (z == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
            }
            if (z == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            z = "";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(kontrol!=0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "+";
                textBox1.Text = " ";
                kontrol = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (kontrol != 0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "-";
                textBox1.Text = " ";
                kontrol = 0;
            }
                

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (kontrol != 0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "*";
                textBox1.Text = " ";
                kontrol = 0;
            }
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (kontrol != 0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "/";
                textBox1.Text = " ";
                kontrol = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (kontrol != 0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "x.x";
                textBox1.Text = Convert.ToString(x * x);
                kontrol = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (kontrol != 0)
            {
                x = Convert.ToDouble(textBox1.Text);
                z = "x.x";
                x = Math.Sqrt(x);
                textBox1.Text = Convert.ToString(x);
                kontrol = 0;
            }
           

        }

        private void button19_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="0")
            {
                textBox1.Text = "1";
                kontrol++;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                kontrol++;
            }
            

        }
    }
}
