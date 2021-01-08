using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();
            // SqlCommand komut = new SqlCommand($"Select KoltukNo from Biletler where SeferID = {Convert.ToInt32(seferID)}", baglan1);
            SqlCommand komut = new SqlCommand($"select o.KoltukDuzeni, sf.KalkısSehirID, sf.SeferID from Seferler sf inner join Otobüsler o on sf.OtobusID=o.OtobusID  where sf.SeferID = {seferID}", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                string koltukDuzenı = oku.GetString(0);
                
                MessageBox.Show($"koltukduzenıı { koltukDuzenı}");
                pnlOtobusKoltuk.Controls.Clear();
                if (koltukDuzenı == "2+1")
                {
                    pnlOtobusKoltuk.Controls.Add(sefer_Ve_Koltuk_Seçimi.panel2_1);
                }
                else
                {
                    pnlOtobusKoltuk.Controls.Add(sefer_Ve_Koltuk_Seçimi.panel2_2);
                    sefer_Ve_Koltuk_Seçimi.panel2_2.Location= new Point(0, 0);
                    sefer_Ve_Koltuk_Seçimi.panel2_2.Visible = true;
                }
                Sefer_ve_Koltuk_Seçimi.kalkıssehirıd = oku.GetInt32(1);
                Sefer_ve_Koltuk_Seçimi.seferID= oku.GetInt32(2);
            }
            baglan.Close();
            sefer_Ve_Koltuk_Seçimi.koltuk_alınmıs_mı(seferID);
        }

    }
}


