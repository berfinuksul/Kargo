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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KargoEntities1 con = new KargoEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
        public bool Giris(string kullaniciadi, string sifre)
        {
            var query = from lg in con.KullaniciGiris where lg.KullaniciAdi == kullaniciadi && lg.Sifre == sifre select lg;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true)
            {
                groupBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris(txt1.Text, txt2.Text))
            {
                MessageBox.Show("Hoşgeldiniz.");
                FormAnasayfa fa = new FormAnasayfa();
                fa.Show();
                this.Hide();
                txt1.Clear();
                txt2.Clear();
            }
            else
            {
                MessageBox.Show("Eksik ya da yanlış bilgi girdiniz.");
                txt1.Clear();
                txt2.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KullaniciGiri save = new KullaniciGiri();
            save.AdSoyad = txt5.Text;
            save.KullaniciAdi = txt6.Text;
            save.Sifre = txt7.Text;
            con.KullaniciGiris.Add(save);
            con.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
        }
    }
}
