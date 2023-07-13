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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeDataSet1.senetvecek' table. You can move, or remove it, as needed.
            this.senetvecekTableAdapter.Fill(this.muhasebeDataSet1.senetvecek);

            this.reportViewer1.RefreshReport();
        }
    }
}
