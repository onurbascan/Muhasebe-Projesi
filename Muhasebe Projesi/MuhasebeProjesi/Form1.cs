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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Interval = 1000;
        }
        int sure = 4;
        string kullanici_adi, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 gosteryuz = new Form11();
            gosteryuz.Show();
            this.Hide();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            button1.Visible = false;
            if (kullanici_adi=="admin"&& sifre=="12345")
          {
                progressBar1.Visible = true;
                label3.Visible = true;
                if (sure == 0 && progressBar1.Value == 100)
                {
                    timer1.Stop();
                    Form2 goster1 = new Form2();
                    goster1.Show();
                    this.Hide();
                }
               
            else
            {
                progressBar1.Visible = true;
                progressBar1.Value += 25;
                sure--; 
            }
                
         }
            if(kullanici_adi!="admin" || sifre !="12345")
            {
                button1.Visible = false;
                progressBar1.Visible = true;
                label3.Visible = true;
                if(sure==0 && progressBar1.Value==100)
                {
                    timer1.Stop();
                    MessageBox.Show("Girmiş Olduğunuz Bilgiler Hatalı Kontrol Edip Tekrar Deneyiniz");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    sure = 4;
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    label3.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    progressBar1.Value += 25;
                    sure--;
                    
                }
            }
            
        }
    }
}
