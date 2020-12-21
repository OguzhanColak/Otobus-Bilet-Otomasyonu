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
    public partial class Musteri_Bilgileri : Form
    {
        public Musteri_Bilgileri()
        {
            InitializeComponent();
        }
        
        private void Musteri_Bilgileri_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);
            dataGridView2.BackgroundColor = Color.FromArgb(43, 161, 147);

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();

            string vericek = "select Ad, Soyad, TC, Email, Cinsiyet, Adres, HESkodu from Musteriler";
            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglan.Close();
        }

    }
}
