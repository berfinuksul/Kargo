using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo
{
    public partial class FormRaporlar : Form
    {
        KargoEntities1 con = new KargoEntities1();
        public FormRaporlar()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ToplamSevkiyat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ToplamMüşteri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ToplamArac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.SevkiyatMusteri();
        }
    }
}
