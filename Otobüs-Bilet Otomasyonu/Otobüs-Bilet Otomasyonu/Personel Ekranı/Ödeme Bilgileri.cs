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
    public partial class Ödeme_Bilgileri : Form
    {
        public Ödeme_Bilgileri()
        {
            InitializeComponent();
        }

        public void Ödeme_Bilgileri_Load(object sender, EventArgs e)
        {
            textBox1.Text = Sefer_ve_Koltuk_Seçimi.seferID;

        }
    }
}
