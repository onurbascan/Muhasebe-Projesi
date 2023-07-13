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
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7IK5QL\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        public Form6()
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
                SqlDataAdapter adptr = new SqlDataAdapter("Select id,sektor,kdv,kategori,adet,tarih,acikadres,hamfiyat,kdvfiyat,toplamfiyat,durum from satinalma", conn);
                adptr.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
            sektor.Items.Add("Kırtasiye");
            sektor.Items.Add("Gıda");
            sektor.Items.Add("İlaç");
            sektor.Items.Add("Giyim");
            sektor.Items.Add("Otomobil");
            sektor.Items.Add("İnşaat");
            sektor.Items.Add("Elektrik");
            label11.Text = "-";
            label9.Text = "-";
            label13.Text = "-";
            sektor.Text = null;
            kdvtext.Text = null;
            kategori.Text = null;
            adet.Text = null;
            tarih.Text = null;
            acikadres.Text = null;
            
        }
        int[] gidafiyat = { 2, 20, 4, 3, 5 };
        int[] kirtasiyefiyat = { 1, 2, 50, 10, 7,3,5 };
        int[] elektronikfiyat = { 3, 10, 12, 10, 4, 5, 25 };
        int[] ilacfiyat = { 10, 15, 100, 20, 30, 10 , 8,13 };
        int[] otofiyat = { 200000, 50000, 100000, 75000,40000 };
        int[] giyimfiyat = { 10, 15, 20, 25, 30,35,100,150 };
        int[] secilensektor = { 7, 5, 8, 8, 5, 5, 6 };
        int[] insaatfiyat = { 100, 10, 20, 30, 40};

        private void button3_Click(object sender, EventArgs e)
        {
            if (sektor.Text == "" || kdvtext.Text == "" || kategori.Text == "" || adet.Text == "" || acikadres.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {
                int fiyat = 0;
                int adet1 = 0;
                int son = 0;
                int son2 = 0;
                int kdv = 0;
                int toplamfiyat = 0;
                son = sektor.SelectedIndex;
                son2 = secilensektor[son];
                for (int i = 0; i < son2; i++)
                {
                    if (i == kategori.SelectedIndex)
                    {
                        adet1 = Convert.ToInt32(this.adet.Text);
                        if (son == 0)
                        {
                            fiyat = adet1 * kirtasiyefiyat[i];
                        }
                        else if (son == 1)
                        {
                            fiyat = adet1 * gidafiyat[i];
                        }
                        else if (son == 2)
                        {
                            fiyat = adet1 * ilacfiyat[i];
                        }
                        else if (son == 3)
                        {
                            fiyat = adet1 * giyimfiyat[i];
                        }
                        else if (son == 4)
                        {
                            fiyat = adet1 * otofiyat[i];
                        }
                        else if (son == 5)
                        {
                            fiyat = adet1 * insaatfiyat[i];
                        }
                        else if (son == 6)
                        {
                            fiyat = adet1 * elektronikfiyat[i];
                        }
                        kdv = (fiyat * 18) / 100;
                        toplamfiyat = fiyat + kdv;
                        label11.Text = fiyat.ToString();
                        label9.Text = kdv.ToString();
                        label13.Text = toplamfiyat.ToString();
                        i = son2;

                    }
                }
            }

            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sektor.SelectedItem == "Kırtasiye")
            {
                kategori.Items.Clear();
                kategori.Items.Add("Kalem");
                kategori.Items.Add("Silgi");
                kategori.Items.Add("Çanta");
                kategori.Items.Add("Suluk");
                kategori.Items.Add("Beslenme Çantası");
                kategori.Items.Add("Defter");
                kategori.Items.Add("Kitap");
                kdvtext.Text = "18";
                
            }
            else if (sektor.SelectedItem == "Gıda")
            {
                kategori.Items.Clear();
                kategori.Items.Add("Makarna");
                kategori.Items.Add("Et");
                kategori.Items.Add("Baharat");
                kategori.Items.Add("Sebze");
                kategori.Items.Add("Meyve");
                kdvtext.Text = "18";


            }
            else if (sektor.SelectedItem == "İlaç")
            {
                kategori.Items.Clear();
                kategori.Items.Add("Ağrı Kesici");
                kategori.Items.Add("Antibiyotik");
                kategori.Items.Add("Kanser İlacı");
                kategori.Items.Add("Mide İlacı");
                kategori.Items.Add("Tansiyon İlacı");
                kategori.Items.Add("Yanık Kremi");
                kategori.Items.Add("Burun Spreyi");
                kategori.Items.Add("Vitamin");
                kdvtext.Text = "18";
            }
            else if (sektor.SelectedItem == "Giyim")
            {
                kategori.Items.Clear();
                kategori.Items.Add("T-Shirt");
                kategori.Items.Add("Etek");
                kategori.Items.Add("Elbise");
                kategori.Items.Add("Pantolon");
                kategori.Items.Add("Gömlek");
                kategori.Items.Add("Ceket");
                kategori.Items.Add("Mont");
                kategori.Items.Add("Kaban");
                kdvtext.Text = "18";
            }
            else if (sektor.SelectedItem == "Otomobil")
            {
                kategori.Items.Clear(); 
                kategori.Items.Add("Spor Otomobil");
                kategori.Items.Add("Ticari Araç");
                kategori.Items.Add("İş Makinesi");
                kategori.Items.Add("Resmi Araç");
                kategori.Items.Add("SUV");
                kdvtext.Text = "18";

            }
            else if (sektor.SelectedItem == "İnşaat")
            {
                kategori.Items.Clear();
                kategori.Items.Add("Çimento");
                kategori.Items.Add("Tuğla");
                kategori.Items.Add("Kireç");
                kategori.Items.Add("Boya");
                kategori.Items.Add("Sıva");
                kdvtext.Text = "18";

            }
            else if (sektor.SelectedItem == "Elektrik")
            {
                kategori.Items.Clear();
                kategori.Items.Add("Direnç");
                kategori.Items.Add("Ampermetre");
                kategori.Items.Add("Voltmetre");
                kategori.Items.Add("Diyot");
                kategori.Items.Add("Ampul");
                kategori.Items.Add("Jeneratör");
                kdvtext.Text = "18";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                label9.Text = "";
                label11.Text = "";
                label13.Text = "";
                sektor.Text = "";
                kdvtext.Text = "";
                kategori.Text = "";
                adet.Text = "";
                tarih.Text = "";
                acikadres.Text = "";
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  satinalma where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Siparişiniz İptal Edildi");
            }
            else
            {
                MessageBox.Show("Sipariş Yok");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            kategori.SelectedItem = null;
            label11.Text = null;
            label9.Text = null;
            label13.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(sektor.Text=="" ||kdvtext.Text=="" ||kategori.Text=="" ||adet.Text=="" ||acikadres.Text=="" ||label9.Text=="" ||label11.Text=="" ||label13.Text=="")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    string ay = tarih.Value.Month.ToString();
                    string gun = tarih.Value.Day.ToString();
                    string yil = tarih.Value.Year.ToString();
                    tarihtext.Text = yil + "-" + ay + "-" + gun;
                    conn.Open();
                    string durum = "Beklemede";
                    SqlCommand kmt = new SqlCommand("Insert into  satinalma VALUES  ('" + sektor.Text + "','" + kdvtext.Text + "','" + kategori.Text + "','" + adet.Text + "','" + tarihtext.Text + "','" + acikadres.Text + "','" + label11.Text + "','" + label9.Text + "','" + label13.Text + "','" + durum + "')", conn);
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    DatagridYenile();
                    MessageBox.Show("Siparişiniz Alındı");
                    sektor.Text = null;
                    kdvtext.Text = null;
                    kategori.Text = null;
                    adet.Text = null;
                    tarih.Text = null;
                    acikadres.Text = null;
                    label11.Text = null;
                    label9.Text = null;
                    label13.Text = null;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                sektor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["sektor"].Value.ToString();
                kdvtext.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["kdv"].Value.ToString();
                kategori.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["kategori"].Value.ToString();
                adet.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["adet"].Value.ToString();
                tarih.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["tarih"].Value.ToString();
                acikadres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["acikadres"].Value.ToString();
                label11.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["hamfiyat"].Value.ToString();
                label9.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["kdvfiyat"].Value.ToString();
                label13.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["toplamfiyat"].Value.ToString();
            }
            catch
            {

            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string durum = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                if (dataGridView1.CurrentRow.Selected == true)
                {
                    if (durum !="tamamlandı")
                    {
                        dataGridView1.CurrentRow.Cells[10].Value = "tamamlandı";
                        durum = "tamamlandı";
                        conn.Open();
                        SqlCommand kmt = new SqlCommand("update  satinalma  set durum='" + durum + "' where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", conn);
                        kmt.ExecuteNonQuery();
                        conn.Close();
                        DatagridYenile();
                        MessageBox.Show("Siparişiniz Tamamlandı");
                        sektor.SelectedItem = null;
                        kategori.SelectedItem = null;
                        adet.Clear();
                        acikadres.Clear();
                        kdvtext.Clear();
                        label9.Text = "-";
                        label11.Text = "-";
                        label13.Text = "-";
                        sektor.Text = null;
                        kdvtext.Text = null;
                        kategori.Text = null;
                        adet.Text = null;
                        tarih.Text = null;
                        acikadres.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Siparişiniz Zaten Tamamlanmıştı");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sipariş Yok");
            }
            
            /*if (dataGridView1.CurrentCell.ColumnIndex == 10)
            {
                dataGridView1.CurrentCell.Value = "tamamlandı";
                durum = "tamamlandı";
                conn.Open();
                SqlCommand kmt = new SqlCommand("update  satinalma  set durum='" + durum + "' where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Siparişiniz Tamamlandı");
                sektor.SelectedItem = null;
                kategori.SelectedItem = null;
                adet.Clear();
                acikadres.Clear();
                kdvtext.Clear();
                label9.Text = "-";
                label11.Text = "-";
                label13.Text = "-";
                sektor.Text = null;
                kdvtext.Text = null;
                kategori.Text = null;
                adet.Text = null;
                tarih.Text = null;
                acikadres.Text = null;
            }*/

        }

        private void acikadres_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label11.Text = null;
            label9.Text = null;
            label13.Text = null;
            
            
        }

        private void kategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
            char ch1 = e.KeyChar;
            if (!Char.IsLetter(ch1) && ch1 != 8 && ch1 != 46 && ch1 != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void sektor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
            char ch1 = e.KeyChar;
            if (!Char.IsLetter(ch1) && ch1 != 8 && ch1 != 46 && ch1 != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
