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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oturum_Bilgileri f1 = new Oturum_Bilgileri();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_Bilgileri f2 = new Personel_Bilgileri();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle f3 = new Kullanıcı_Ekle();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sefer_Ekle f4 = new Sefer_Ekle();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İstatistikler f5 = new İstatistikler();
            f5.Show();
        }
    }
}
