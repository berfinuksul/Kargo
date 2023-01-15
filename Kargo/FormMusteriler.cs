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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
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
            dataGridView1.DataSource = con.MListele();
        }

        public void Temizle()
        {
            txt2.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt6.Clear();
            txt7.Clear();
            comboBox1.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler save = new Musteriler();
            save.SevkiyatNo = Convert.ToInt32(comboBox1.Text);
            save.MusteriAdSoyad = txt2.Text;
            save.MusteriAdres = txt4.Text;
            save.MusteriTelefon = txt5.Text;
            save.Mail = txt6.Text;
            save.OdemeDurumu = txt7.Text;
            con.MEkle(save.SevkiyatNo,save.MusteriAdSoyad, save.MusteriAdres, save.MusteriTelefon, save.Mail, save.OdemeDurumu);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteriler yenile = new Musteriler();
            yenile.MusteriNo = Convert.ToInt32(comboBox1.Tag);
            yenile.SevkiyatNo = Convert.ToInt32(comboBox1.Text);
            yenile.MusteriAdSoyad = txt2.Text;
            yenile.MusteriAdres = txt4.Text;
            yenile.MusteriTelefon = txt5.Text;
            yenile.Mail = txt6.Text;
            yenile.OdemeDurumu = txt7.Text;
            con.MYenile(yenile.MusteriNo, yenile.SevkiyatNo, yenile.MusteriAdSoyad, yenile.MusteriAdres, yenile.MusteriTelefon, yenile.Mail, yenile.OdemeDurumu);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteriler sil = new Musteriler();
            sil.MusteriNo = Convert.ToInt32(comboBox1.Tag);
            con.MSil(sil.MusteriNo);
            con.SaveChanges();
            Listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            comboBox1.Tag = satir.Cells["MusteriNo"].Value.ToString();
            comboBox1.Text = satir.Cells["SevkiyatNo"].Value.ToString();
            txt2.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            txt4.Text = satir.Cells["MusteriAdres"].Value.ToString();
            txt5.Text = satir.Cells["MusteriTelefon"].Value.ToString();
            txt6.Text = satir.Cells["Mail"].Value.ToString();
            txt7.Text = satir.Cells["OdemeDurumu"].Value.ToString();
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = con.Sevkiyatlars.ToList();
            comboBox1.ValueMember = "SevkiyatNo";
        }
    }
}
