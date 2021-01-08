using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Yönetici_Ekranı : Form
    {
        public Yönetici_Ekranı()
        {
            InitializeComponent();
        }


        private void Yönetici_Ekranı_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);
            pnlMenu.BackColor = Color.FromArgb(39, 145, 133);
            btnAnasayfa.BackColor = Color.FromArgb(51, 193, 177);
            btnKullanıcıEkle.BackColor = Color.FromArgb(51, 193, 177);
            btnOturumBilgileri.BackColor = Color.FromArgb(51, 193, 177);
            btnPersonelBilgileri.BackColor = Color.FromArgb(51, 193, 177);
            btnSeferEkle.BackColor = Color.FromArgb(51, 193, 177);
            btnİstatistikler.BackColor = Color.FromArgb(51, 193, 177);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oturum_Bilgileri oturum_Bilgileri = new Oturum_Bilgileri();
            pnlYönetici.Controls.Clear();
            oturum_Bilgileri.Dock = DockStyle.Fill;
            oturum_Bilgileri.TopLevel = false;
            oturum_Bilgileri.TopMost = true;
            oturum_Bilgileri.FormBorderStyle = FormBorderStyle.None;

            pnlYönetici.Controls.Add(oturum_Bilgileri);
            oturum_Bilgileri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_Bilgileri personel_Bilgileri = new Personel_Bilgileri();
            pnlYönetici.Controls.Clear();
            personel_Bilgileri.Dock = DockStyle.Fill;
            personel_Bilgileri.TopLevel = false;
            personel_Bilgileri.TopMost = true;
            personel_Bilgileri.FormBorderStyle = FormBorderStyle.None;

            pnlYönetici.Controls.Add(personel_Bilgileri);
            personel_Bilgileri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle kullanıcı_Ekle = new Kullanıcı_Ekle();
            pnlYönetici.Controls.Clear();
            kullanıcı_Ekle.Dock = DockStyle.Fill;
            kullanıcı_Ekle.TopLevel = false;
            kullanıcı_Ekle.TopMost = true;
            kullanıcı_Ekle.FormBorderStyle = FormBorderStyle.None;

            pnlYönetici.Controls.Add(kullanıcı_Ekle);
            kullanıcı_Ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sefer_Ekle sefer_Ekle = new Sefer_Ekle();
            pnlYönetici.Controls.Clear();
            sefer_Ekle.Dock = DockStyle.Fill;
            sefer_Ekle.TopLevel = false;
            sefer_Ekle.TopMost = true;
            sefer_Ekle.FormBorderStyle = FormBorderStyle.None;

            pnlYönetici.Controls.Add(sefer_Ekle);
            sefer_Ekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İstatistikler istatistikler = new İstatistikler();
            pnlYönetici.Controls.Clear();
            istatistikler.Dock = DockStyle.Fill;
            istatistikler.TopLevel = false;
            istatistikler.TopMost = true;
            istatistikler.FormBorderStyle = FormBorderStyle.None;

            pnlYönetici.Controls.Add(istatistikler);
            istatistikler.Show();
        }
    }
}
