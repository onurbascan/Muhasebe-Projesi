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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7IK5QL\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        
        public Form4()
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
                SqlDataAdapter adptr = new SqlDataAdapter("Select id,tckimlik,adi,soyadi,adres,il,ilce,ulke,telefon1,telefon2,faks,vergidairesi,vergino,carikod,tarih from carihesap", conn);
                adptr.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }
       

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            tckimlik.Text = null;
            ad.Text = null;
            soyad.Text = null;
            adres.Text = null;
            il.Text = null;
            ilce.Text = null;
            ulke.Text = null;
            telefon1.Text = null;
            telefon2.Text = null;
            faks.Text = null;
            vergidairesi.Text = null;
            vergino.Text = null;
            carikod.Text = null;
            tarihtext.Text = null;
            tarih.Text = null;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            int kontrol2 = 0;
            if (tckimlik.Text == "" || ad.Text == "" || soyad.Text == "" || adres.Text == "" || il.Text == "" || ilce.Text == "" || ulke.Text == "" || telefon1.Text == "" || telefon2.Text == "" || faks.Text == "" || vergidairesi.Text == "" || vergino.Text == "" || carikod.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
                kontrol2 = 1;

            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (tckimlik.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("Aynı Tc ye ait Kayıt Zaten Var");
                    kontrol = 1;
                }
            }
          
            if(kontrol==0&&kontrol2==0)
            {
                
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        string ay = tarih.Value.Month.ToString();
                        string gun = tarih.Value.Day.ToString();
                        string yil = tarih.Value.Year.ToString();
                        tarihtext.Text = yil + "-" + ay + "-" + gun;
                        conn.Open();
                        SqlCommand kmt = new SqlCommand("Insert into  carihesap VALUES  ('" + tckimlik.Text + "','" + ad.Text + "','" + soyad.Text + "','" + adres.Text + "','" + il.Text + "','" + ilce.Text + "','" + ulke.Text + "','" + telefon1.Text + "','" + telefon2.Text + "','" + faks.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "','" + carikod.Text + "','" + tarihtext.Text.ToString() + "')", conn);
                        kmt.ExecuteNonQuery();
                        conn.Close();
                        DatagridYenile();
                        MessageBox.Show("Cari Hesap Eklenmiştir");
                        tckimlik.Text = null;
                        ad.Text = null;
                        soyad.Text = null;
                        adres.Text = null;
                        il.Text = null;
                        ilce.Text = null;
                        ulke.Text = null;
                        telefon1.Text = null;
                        telefon2.Text = null;
                        faks.Text = null;
                        vergidairesi.Text = null;
                        vergino.Text = null;
                        carikod.Text = null;
                        tarihtext.Text = null;
                        tarih.Text = null;
                   
                    }
                }
                catch
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  carihesap where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Cari Hesap Silinmiştir");
                tckimlik.Text = null;
                ad.Text = null;
                soyad.Text = null;
                adres.Text = null;
                il.Text = null;
                ilce.Text = null;
                ulke.Text = null;
                telefon1.Text = null;
                telefon2.Text = null;
                faks.Text = null;
                vergidairesi.Text = null;
                vergino.Text = null;
                carikod.Text = null;
                tarih.Text = null;
                tarihtext.Text = null;
            }
            else
            {
                MessageBox.Show("Silinecek Veri Bulunamadı");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tckimlik.Text == "" || ad.Text == "" || soyad.Text == "" || adres.Text == "" || il.Text == "" || ilce.Text == "" || ulke.Text == "" || telefon1.Text == "" || telefon2.Text == "" || faks.Text == "" || vergidairesi.Text == "" || vergino.Text == "" || carikod.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {
                string ay = tarih.Value.Month.ToString();
                string gun = tarih.Value.Day.ToString();
                string yil = tarih.Value.Year.ToString();
                tarihtext.Text = yil + "-" + ay + "-" + gun;
                conn.Open();
                SqlCommand kmt = new SqlCommand("update  carihesap set tckimlik='" + tckimlik.Text + "',adi='" + ad.Text + "',soyadi='" + soyad.Text + "',adres='" + adres.Text + "' ,il='" + il.Text + "',ilce='" + ilce.Text + "',ulke='" + ulke.Text + "',telefon1='" + telefon1.Text + "',telefon2='" + telefon2.Text + "',faks='" + faks.Text + "',vergidairesi='" + vergidairesi.Text + "',vergino='" + vergino.Text + "',carikod='" + carikod.Text + "',tarih='" + tarihtext.Text.ToString() + "' where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Güncelleme İşleminiz Başarılı");
                tckimlik.Text = null;
                ad.Text = null;
                soyad.Text = null;
                adres.Text = null;
                il.Text = null;
                ilce.Text = null;
                ulke.Text = null;
                telefon1.Text = null;
                telefon2.Text = null;
                faks.Text = null;
                vergidairesi.Text = null;
                vergino.Text = null;
                carikod.Text = null;
                tarihtext.Text = null;
                tarih.Text = null;
            }
            
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                tckimlik.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["tckimlik"].Value.ToString();
                ad.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["adi"].Value.ToString();
                soyad.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["soyadi"].Value.ToString();
                adres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["adres"].Value.ToString();
                il.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["il"].Value.ToString();
                ilce.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ilce"].Value.ToString();
                ulke.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ulke"].Value.ToString();
                telefon1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["telefon1"].Value.ToString();
                telefon2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["telefon2"].Value.ToString();
                faks.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["faks"].Value.ToString();
                vergidairesi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["vergidairesi"].Value.ToString();
                vergino.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["vergino"].Value.ToString();
                carikod.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["carikod"].Value.ToString();
                tarih.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["tarih"].Value.ToString();
            }
            catch
            {
            }
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {
            string ay = tarih.Value.Month.ToString();
            string gun = tarih.Value.Day.ToString();
            string yil = tarih.Value.Year.ToString();
            tarihtext.Text = gun + "-" + ay + "-" + yil;
            
        }

        private void tckimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void il_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void ilce_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void ulke_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void telefon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void telefon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void faks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void vergidairesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void vergino_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void carikod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void tckimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
