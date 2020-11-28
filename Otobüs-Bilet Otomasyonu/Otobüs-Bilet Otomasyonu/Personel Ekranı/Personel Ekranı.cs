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
        Sefer_ve_Koltuk_Seçimi f3 = new Sefer_ve_Koltuk_Seçimi();

        private void Personel_Ekranı_Load(object sender, EventArgs e)
        {
            //Panel içinde form açma
            //https://youtu.be/l_K-CgkovJI
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3.Show();
        }
    }
}
