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
    public partial class FormAraclar : Form
    {
        public FormAraclar()
        {
            InitializeComponent();
        }

        KargoEntities1 con = new KargoEntities1();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAnasayfa fa = new FormAnasayfa();
            fa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        public void Listele()
        {
            dataGridView1.DataSource = con.AListele();
        }

        public void Temizle()
        {
            txt2.Clear();
            txt3.Value=0;
            txt4.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araclar save = new Araclar();
            save.AracTur = txt2.Text;
            save.AracKapasite = Convert.ToInt32(txt3.Text);
            save.AracSofor = txt4.Text;
            con.AEkle(save.AracTur, save.AracKapasite, save.AracSofor);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt2.Tag = satir.Cells["AracNo"].Value.ToString();
            txt2.Text = satir.Cells["AracTur"].Value.ToString();
            txt3.Text = satir.Cells["AracKapasite"].Value.ToString();
            txt4.Text = satir.Cells["AracSofor"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Araclar sil = new Araclar();
            sil.AracNo = Convert.ToInt32(txt2.Tag);
            con.ASil(sil.AracNo);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Araclar yenile = new Araclar();
            yenile.AracNo = Convert.ToInt32(txt2.Tag);
            yenile.AracTur = txt2.Text;
            yenile.AracKapasite = Convert.ToInt32(txt3.Text);
            yenile.AracSofor = txt4.Text;
            con.AYenile(yenile.AracNo, yenile.AracTur, yenile.AracKapasite, yenile.AracSofor);
            con.SaveChanges();
            Listele();
            Temizle();
        }
    }
}
