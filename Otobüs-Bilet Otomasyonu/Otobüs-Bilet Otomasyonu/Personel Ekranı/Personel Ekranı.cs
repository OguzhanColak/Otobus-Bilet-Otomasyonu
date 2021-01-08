using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Personel_Ekranı : Form
    {
        public Personel_Ekranı()
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
            InitializeComponent();
            this.FormClosed += Personel_Ekranı_FormClosed;
        }


        private void Personel_Ekranı_Load(object sender, EventArgs e)
        {
            //Panel içinde form açma
            //https://youtu.be/l_K-CgkovJI
            BackColor = Color.FromArgb(43, 161, 147);
            //FormBorderStyle = None; olacak
            pnlMenu.BackColor = Color.FromArgb(39, 145, 133);
            btnBiletSatıs.BackColor = Color.FromArgb(51, 193, 177);
            btnOtobusSeferlerı.BackColor = Color.FromArgb(51, 193, 177);
            btnMusterıBılgılerı.BackColor = Color.FromArgb(51, 193, 177);
            btnAnasayfa.BackColor = Color.FromArgb(51, 193, 177);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sefer_ve_Koltuk_Seçimi SeferveKoltukSeçimi = new Sefer_ve_Koltuk_Seçimi();

            pnlPersonel.Controls.Clear();
            SeferveKoltukSeçimi.Dock = DockStyle.Fill;
            SeferveKoltukSeçimi.TopLevel = false;
            SeferveKoltukSeçimi.TopMost = true;
            SeferveKoltukSeçimi.FormBorderStyle = FormBorderStyle.None;

            pnlPersonel.Controls.Add(SeferveKoltukSeçimi);
            SeferveKoltukSeçimi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otobüs_Seferleri OtobüsSeferleri = new Otobüs_Seferleri();

            pnlPersonel.Controls.Clear();
            OtobüsSeferleri.Dock = DockStyle.Fill;
            OtobüsSeferleri.TopLevel = false;
            OtobüsSeferleri.TopMost = true;
            OtobüsSeferleri.FormBorderStyle = FormBorderStyle.None;

            pnlPersonel.Controls.Add(OtobüsSeferleri);
            OtobüsSeferleri.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Musteri_Bilgileri MusteriBilgileri = new Musteri_Bilgileri();
            pnlPersonel.Controls.Clear();
            MusteriBilgileri.Dock = DockStyle.Fill;
            MusteriBilgileri.TopLevel = false;
            MusteriBilgileri.TopMost = true;
            MusteriBilgileri.FormBorderStyle = FormBorderStyle.None;

            pnlPersonel.Controls.Add(MusteriBilgileri);
            MusteriBilgileri.Show();
        }


        private void Personel_Ekranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
