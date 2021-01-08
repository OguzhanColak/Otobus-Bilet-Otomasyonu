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
    public partial class Otobüs_Seferleri : Form
    {
        public Otobüs_Seferleri()
        {
            InitializeComponent();
        }
        string vericek;
        private void Otobüs_Seferleri_Load(object sender, EventArgs e)
        {
            Otobüs_Seferleri otobüs_Seferleri = new Otobüs_Seferleri();
            Personel_Ekranı personel_Ekranı = new Personel_Ekranı();
            BackColor = Color.FromArgb(43, 161, 147);
            dataGridView1.BackgroundColor = Color.FromArgb(43, 161, 147);

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();

            if (Properties.Settings.Default.dil == "tr")
            {
                vericek = "select OtobusID as [Otobüs No], SeferID as [Sefer No], s1.SehirAdı as [Kalkış Şehir] , s2.SehirAdı as [Varış Şehir], KalkısVakti, VarisVakti from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID";

            }
            else if (Properties.Settings.Default.dil == "en")
            {
                vericek = "select OtobusID as [Bus Number], SeferID as [Flight Number], s1.SehirAdı as [Departure City] , s2.SehirAdı as [Destination City], KalkısVakti as [Departure Time], VarisVakti as [Arrive Time] from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID";
            }

            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Otobüs_Koltuk otobüs_Koltuk = new Otobüs_Koltuk();
            Personel_Ekranı personel_Ekranı = new Personel_Ekranı();
            otobüs_Koltuk.seferID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

            otobüs_Koltuk.Show();
        }
    }
}
