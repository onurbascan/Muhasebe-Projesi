using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MuhasebeProjesi
{

    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7IK5QL\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
            DatagridYenile();
        }
        protected void DatagridYenile()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select id,sektor,kdv,kategori,adet,tarih,acikadres,hamfiyat,kdvfiyat,toplamfiyat,durum from satinalma where durum='tamamlandı'", conn);
                adptr.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  satinalma where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Eşya Stoğunuzdan Tamamen Kaldırıldı");
            }
            else
            {
                MessageBox.Show("Eşya Bulunamadı");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ppddialog.Document = pdyazici;
            ppddialog.ShowDialog();
        }
        Font baslik = new Font("Verdana", 8, FontStyle.Bold);
        Font icerik = new Font("Verdana", 8);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void pdyazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sformat = new StringFormat();
            sformat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Sipariş Id        Sektör             Kategori              Adet                    Tarih                          Kdv                          Fiyat     ", baslik, sb, 49, 150);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------", baslik, sb, 30, 170);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), icerik, sb, 40 + 20, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), icerik, sb, 100 + 40, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), icerik, sb, 170 + 60, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), icerik, sb, 240 + 100, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), icerik, sb, 310 + 100, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), icerik, sb, 380 + 200, 190 + (i * 30));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[9].Value.ToString(), icerik, sb, 450 + 260, 190 + (i * 30));

            }
        }
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count>1)
            {
            sayi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            sayi--;
            if (sayi>0)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("update  satinalma set adet='" + sayi.ToString() + "' where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
            }
            if (sayi<=0)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  satinalma where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Eşya Stoğunuzda Kalmadı Ve Silindi");
            }

        }
            else
            {
                MessageBox.Show("Eşya Bulunamadı");
            }
        }
    }
}
