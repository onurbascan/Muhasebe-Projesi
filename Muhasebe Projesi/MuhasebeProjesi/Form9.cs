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
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7IK5QL\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");

        public Form9()
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
                SqlDataAdapter adptr = new SqlDataAdapter("Select id,ad,soyad,iban,bankaadi,aktarilanyer,firmaismi,miktar,yapilanislem from bankaislemm", conn);
                adptr.Fill(tbl);
                conn.Close();
                dataGridView1.DataSource = tbl;
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            aktarilan.Items.Add("Kendi Firmamız");
            aktarilan.Items.Add("Özel");
            firmaisim.Visible = false;
            label7.Visible = false;
            adi.Text = null;
            soyadi.Text = null;
            miktar.Text = null;
            aktarilan.Text = null;
            bankaadi.Text = null;
            ibanno.Text = null;
            firmaisim.Text = null;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(aktarilan.SelectedItem=="Özel")
            {
                firmaisim.Visible = true;
                label7.Visible = true;
            }
            else if(aktarilan.SelectedItem=="Kendi Firmamız")
            {
                firmaisim.Visible = false;
                label7.Visible = false;
                firmaisim.Text = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(adi.Text=="" ||soyadi.Text=="" ||ibanno.Text=="" ||bankaadi.Text=="" ||aktarilan.Text=="" ||miktar.Text=="")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");

            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand kmt = new SqlCommand("Insert into  bankaislemm VALUES  ('" + adi.Text + "','" + soyadi.Text + "','" + ibanno.Text + "','" + bankaadi.Text + "','" + aktarilan.Text + "','" + firmaisim.Text + "','" + miktar.Text + "','" + "Yatırma" + "')", conn);
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    DatagridYenile();
                    MessageBox.Show("Para Yatırma İşleminiz Gerçekleşti");
                    adi.Text = null;
                    soyadi.Text = null;
                    miktar.Text = null;
                    aktarilan.Text = null;
                    bankaadi.Text = null;
                    ibanno.Text = null;
                    firmaisim.Text = null;
                   
                }
            }
            
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            if (adi.Text == "" || soyadi.Text == "" || ibanno.Text == "" || bankaadi.Text == "" || aktarilan.Text == "" ||  miktar.Text == "")
            {
                MessageBox.Show("Eksik Yada Hatalı Giriş Yaptınız Bilgileri Tekrar Giriniz");
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand kmt = new SqlCommand("Insert into  bankaislemm VALUES  ('" + adi.Text + "','" + soyadi.Text + "','" + ibanno.Text + "','" + bankaadi.Text + "','" + aktarilan.Text + "','" + firmaisim.Text + "','" + miktar.Text + "','" + "Çekme" + "')", conn);
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    DatagridYenile();
                    MessageBox.Show("Para Çekme İşleminiz Gerçekleşti");
                    adi.Text = null;
                    soyadi.Text = null;
                    miktar.Text = null;
                    aktarilan.Text = null;
                    bankaadi.Text = null;
                    ibanno.Text = null;
                    firmaisim.Text = null;
                }
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                adi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ad"].Value.ToString();
                soyadi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["soyad"].Value.ToString();
                ibanno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["iban"].Value.ToString();
                bankaadi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["bankaadi"].Value.ToString();
                aktarilan.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["aktarilanyer"].Value.ToString();
                firmaisim.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["firmaismi"].Value.ToString();
                miktar.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["miktar"].Value.ToString();
                
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("DELETE  bankaislemm where id=" + dataGridView1.CurrentRow.Cells["id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DatagridYenile();
                MessageBox.Show("İşlem Bilgisini Sildiniz");
                bankaadi.Text = null;
                adi.Text = null;
                soyadi.Text = null;
                ibanno.Text = null;
                aktarilan.Text = null;
                firmaisim.Text = null;
                miktar.Text = null;
            }
            else
            {
                MessageBox.Show("Silinecek Veri Bulunamadı");
            }
        }

        private void adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void ibanno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void miktar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void firmaisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void aktarilan_KeyPress(object sender, KeyPressEventArgs e)
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
