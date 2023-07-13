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
    public partial class Form8 : Form
    {
        
        public Form8()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 gosteranamenu = new Form2();
            gosteranamenu.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label6.Text = "Onur Muhasebe A.Ş";
            label7.Text = "10001203";
            label8.Text = "A0001991";
            label9.Text = "Türkiye İş Bankası";
            label14.Text = "Onur Başcan";
            label15.Text = "www.onurmuhasebeas.com";
            label16.Text = "Marmara Üniversitesi";
            label17.Text = "Muhasebe/Accounting";
        }
    }
}
