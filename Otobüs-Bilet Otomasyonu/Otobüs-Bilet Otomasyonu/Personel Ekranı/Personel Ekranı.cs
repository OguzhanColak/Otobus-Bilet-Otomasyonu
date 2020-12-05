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
    public partial class Personel_Ekranı : Form
    {
        public Personel_Ekranı()
        {
            InitializeComponent();
        }
        

        private void Personel_Ekranı_Load(object sender, EventArgs e)
        {
            //Panel içinde form açma
            //https://youtu.be/l_K-CgkovJI
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sefer_ve_Koltuk_Seçimi f1 = new Sefer_ve_Koltuk_Seçimi();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otobüs_Seferleri f2 = new Otobüs_Seferleri();
            f2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri_Bilgileri f3 = new Musteri_Bilgileri();
            f3.Show();
        }
    }
}
