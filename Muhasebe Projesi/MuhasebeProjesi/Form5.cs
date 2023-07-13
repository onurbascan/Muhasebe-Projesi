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
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7IK5QL\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");

        public Form5()
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
                SqlDataAdapter adptr = new SqlDataAdapter("Select id,islemtarih,vadetarih,tutar,ceksenetno,ceksenetturu,bankaadi,bankasubesi,hesapno,aciklama from senetvecek", conn);
                adptr.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            islemtarih.Text = null;
            vadetarih.Text = null;
            tutar.Text = null;
            ceksenetno.Text = null;
            ceksenettur.Text = null;
            bankaadi.Text = null;
            bankasubesi.Text = null;
            hesapno.Text = null;
            aciklama.Text = null;   
            ceksenettur.Items.Add("Kendi Evrağımız");
            ceksenettur.Items.Add("Müşteri Evrağı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(islemtext.Text=="" ||vadetext.Text=="" ||tutar.Text=="" ||ceksenetno.Text=="" ||ceksenettur.Text=="" ||bankaadi.Text=="" ||bankasubesi.Text=="" ||hesapno.Text=="" ||aciklama.Text=="")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");

            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        string ay = islemtarih.Value.Month.ToString();
                        string gun = islemtarih.Value.Day.ToString();
                        string yil = islemtarih.Value.Year.ToString();
                        islemtext.Text = yil + "-" + ay + "-" + gun;

                        string vadeay = vadetarih.Value.Month.ToString();
                        string vadegun = vadetarih.Value.Day.ToString();
                        string vadeyil = vadetarih.Value.Year.ToString();
                        vadetext.Text = vadeyil + "-" + vadeay + "-" + vadegun;
                        conn.Open();
                        SqlCommand kmt = new SqlCommand("Insert into  senetvecek VALUES  ('" + islemtext.Text + "','" + vadetext.Text + "','" + tutar.Text + "','" + ceksenetno.Text + "','" + ceksenettur.Text + "','" + bankaadi.Text + "','" + bankasubesi.Text + "','" + hesapno.Text + "','" + aciklama.Text + "')", conn);
                        kmt.ExecuteNonQuery();
                        conn.Close();
                        DatagridYenile();
                        MessageBox.Show("Çek İşleminiz Gerçekleşti");
                        islemtarih.Text = null;
                        vadetarih.Text = null;
                        tutar.Text = null;
                        ceksenetno.Text = null;
                        ceksenettur.Text = null;
                        bankaadi.Text = null;
                        bankasubesi.Text = null;
                        hesapno.Text = null;
                        aciklama.Text = null;
                    }
                }
                catch
                {

                }
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (islemtext.Text == "" || vadetext.Text == "" || tutar.Text == "" || ceksenetno.Text == "" || ceksenettur.Text == "" || bankaadi.Text == "" || bankasubesi.Text == "" || hesapno.Text == "" || aciklama.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  senetvecek where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Çek Bilgisini Sildiniz");
                islemtarih.Text = null;
                vadetarih.Text = null;
                tutar.Text = null;
                ceksenetno.Text = null;
                ceksenettur.Text = null;
                bankaadi.Text = null;
                bankasubesi.Text = null;
                hesapno.Text = null;
                aciklama.Text = null;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (islemtext.Text == "" || vadetext.Text == "" || tutar.Text == "" || ceksenetno.Text == "" || ceksenettur.Text == "" || bankaadi.Text == "" || bankasubesi.Text == "" || hesapno.Text == "" || aciklama.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {

                string ay = islemtarih.Value.Month.ToString();
                string gun = islemtarih.Value.Day.ToString();
                string yil = islemtarih.Value.Year.ToString();
                islemtext.Text = yil + "-" + ay + "-" + gun;

                string vadeay = vadetarih.Value.Month.ToString();
                string vadegun = vadetarih.Value.Day.ToString();
                string vadeyil = vadetarih.Value.Year.ToString();
                vadetext.Text = vadeyil + "-" + vadeay + "-" + vadegun;
                conn.Open();
                SqlCommand kmt = new SqlCommand("update  senetvecek set islemtarih='" + islemtext.Text + "',vadetarih='" + vadetext.Text + "',tutar='" + tutar.Text + "',ceksenetno='" + ceksenetno.Text + "' ,ceksenetturu='" + ceksenettur.Text + "',bankaadi='" + bankaadi.Text + "',bankasubesi='" + bankasubesi.Text + "',hesapno='" + hesapno.Text + "',aciklama='" + aciklama.Text + "' where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("Çek Bilgileriniz Güncellendi");
                islemtarih.Text = null;
                vadetarih.Text = null;
                tutar.Text = null;
                ceksenetno.Text = null;
                ceksenettur.Text = null;
                bankaadi.Text = null;
                bankasubesi.Text = null;
                hesapno.Text = null;
                aciklama.Text = null;
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                islemtarih.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["islemtarih"].Value.ToString();
                vadetarih.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["vadetarih"].Value.ToString();
                tutar.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["tutar"].Value.ToString();
                ceksenetno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ceksenetno"].Value.ToString();
                ceksenettur.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ceksenetturu"].Value.ToString();
                bankaadi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["bankaadi"].Value.ToString();
                bankasubesi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["bankasubesi"].Value.ToString();
                hesapno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["hesapno"].Value.ToString();
                aciklama.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["aciklama"].Value.ToString();
            }
            catch
            {

            }
        }

        private void islemtarih_ValueChanged(object sender, EventArgs e)
        {
            string ay = islemtarih.Value.Month.ToString();
            string gun = islemtarih.Value.Day.ToString();
            string yil = islemtarih.Value.Year.ToString();
            islemtext.Text = yil + "-" + ay + "-" + gun;
        }

        private void vadetarih_ValueChanged(object sender, EventArgs e)
        {
            string vadeay = vadetarih.Value.Month.ToString();
            string vadegun = vadetarih.Value.Day.ToString();
            string vadeyil = vadetarih.Value.Year.ToString();
            vadetext.Text = vadeyil + "-" + vadeay + "-" + vadegun;
        }

        private void tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void ceksenetno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void bankaadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void bankasubesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void hesapno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 goster1 = new Form10();
            goster1.Show();
        }
    }
}
