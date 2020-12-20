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
    public partial class Otobüs_Koltuk : Form
    {
        public Otobüs_Koltuk()
        {
            InitializeComponent();
        }
        public int seferID;
        Sefer_ve_Koltuk_Seçimi sefer_Ve_Koltuk_Seçimi = new Sefer_ve_Koltuk_Seçimi();
        private void Otobüs_Koltuk_Load(object sender, EventArgs e)
        {
            pnlOtobusKoltuk.Controls.Add(sefer_Ve_Koltuk_Seçimi.panel1);
            sefer_Ve_Koltuk_Seçimi.koltuk_alınmıs_mı(seferID);

        }
    }
}


