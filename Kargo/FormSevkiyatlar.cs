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
    public partial class FormSevkiyatlar : Form
    {
        public FormSevkiyatlar()
        {
            InitializeComponent();
        }
        KargoEntities1 con = new KargoEntities1();
        public void Listele()
        {
            dataGridView1.DataSource = con.SListele();
        }

        public void Temizle()
        {
            txt2.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt6.Clear();
            txt7.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAnasayfa fa = new FormAnasayfa();
            fa.Show();
            this.Hide();
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
            Sevkiyatlar save = new Sevkiyatlar();
            save.SevkiyatAdı = txt2.Text;
            save.SevkiyatAlimNoktasi = txt4.Text;
            save.SevkiyatUlasimNoktasi = txt5.Text;
            save.Mesafe = Convert.ToInt32(txt6.Text);
            save.MesafeTutar = Convert.ToInt32(txt7.Text);
            con.SEkle(save.SevkiyatAdı, save.SevkiyatAlimNoktasi, save.SevkiyatUlasimNoktasi, save.Mesafe, save.MesafeTutar);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sevkiyatlar sil = new Sevkiyatlar();
            sil.SevkiyatNo = Convert.ToInt32(txt2.Tag);
            con.SSil(sil.SevkiyatNo);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Sevkiyatlar yenile = new Sevkiyatlar();
            yenile.SevkiyatNo = Convert.ToInt32(txt2.Tag);
            yenile.SevkiyatAdı = txt2.Text;
            yenile.SevkiyatAlimNoktasi = txt4.Text;
            yenile.SevkiyatUlasimNoktasi = txt5.Text;
            yenile.Mesafe = Convert.ToInt32(txt6.Text);
            yenile.MesafeTutar = Convert.ToInt32(txt7.Text);
            con.SYenile(yenile.SevkiyatNo, yenile.SevkiyatAdı, yenile.SevkiyatAlimNoktasi, yenile.SevkiyatUlasimNoktasi, yenile.Mesafe, yenile.MesafeTutar);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt2.Tag = satir.Cells["SevkiyatNo"].Value.ToString();
            txt2.Text = satir.Cells["SevkiyatAdı"].Value.ToString();
            txt4.Text = satir.Cells["SevkiyatAlimNoktasi"].Value.ToString();
            txt5.Text = satir.Cells["SevkiyatUlasimNoktasi"].Value.ToString();
            txt6.Text = satir.Cells["Mesafe"].Value.ToString();
            txt7.Text = satir.Cells["MesafeTutar"].Value.ToString();
        }
    }
}
