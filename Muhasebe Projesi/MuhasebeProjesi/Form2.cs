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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void tarihsaat()
        {
            label9.Text = DateTime.Now.ToLongDateString();
            
            label8.Text = DateTime.Now.ToLongTimeString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 gosterhesapmakinesi = new Form3();
            gosterhesapmakinesi.Show();
            
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 gostercarihesap = new Form4();
            gostercarihesap.Show();
            this.Hide();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 gostercekislemi = new Form5();
            gostercekislemi.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 gostersatinal = new Form6();
            gostersatinal.Show();
            this.Hide();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tarihsaat();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 gosterstok = new Form7();
            gosterstok.Show();
            this.Hide();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ppddialog.Document = pdyazici;
            ppddialog.ShowDialog();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 gosterkasa = new Form8();
            gosterkasa.Show();
            this.Hide();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 gosterbankamenu = new Form9();
            gosterbankamenu.Show();
            this.Hide();
           
        }
        Font baslik = new Font("Verdana", 8, FontStyle.Bold);
        Font icerik = new Font("Verdana", 8);
        

        SolidBrush sb = new SolidBrush(Color.Black);
       
        Form4 yaz = new Form4();
        
        private void pdyazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sformat = new StringFormat();
            
            sformat.Alignment = StringAlignment.Near;
            

            e.Graphics.DrawString("TC                   Adı                        Soyadı                        VergiDairesi                       VergiNo                       CariKod     ", baslik, sb, 40, 150);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------", baslik, sb, 30, 170);
            
            for (int i = 0; i < yaz.dataGridView1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[1].Value.ToString(), icerik, sb, 10 + 20, 190 + (i * 30));
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[2].Value.ToString(), icerik, sb, 90 + 40, 190 + (i * 30));
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[3].Value.ToString(), icerik, sb, 180 + 60, 190 + (i * 30));
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[11].Value.ToString(), icerik, sb, 270 + 100, 190 + (i * 30));
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[12].Value.ToString(), icerik, sb, 340 + 200, 190 + (i * 30));
                e.Graphics.DrawString(yaz.dataGridView1.Rows[i].Cells[13].Value.ToString(), icerik, sb, 420 + 260, 190 + (i * 30));
               

            }

        }
    }
}
