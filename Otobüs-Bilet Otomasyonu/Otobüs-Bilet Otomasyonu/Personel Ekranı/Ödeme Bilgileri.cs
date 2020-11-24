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
    public partial class Ödeme_Bilgileri : Form
    {
        public Ödeme_Bilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlCommand komut;
        public int aıleID;

        

        private void musteriekle()
        {
            /*
            string sorguSoyadlarAynıMı = "SELECT Soyad, AıleID FROM Musteriler";
            komut = new SqlCommand(sorguSoyadlarAynıMı, baglan);
            baglan.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (txtSoyad.Text == oku.GetString(0)) { aıleID = oku.GetInt32(1); }
                else { aıleıdArttır();  }

            }
            baglan.Close();
            */

          /*  void aıleıdArttır()
            {
                string sorgu_en_buyuk_aıleID = "select top 1 AıleID from Musteriler order by AıleID desc";
                komut = new SqlCommand(sorgu_en_buyuk_aıleID, baglan);
                baglan.Open();
                SqlDataReader oku1 = komut.ExecuteReader();

                while (oku1.Read())
                {
                    aıleID = oku1.GetInt32(0);
                }
                baglan.Close();
            } 
          */
           


            string sorgu2 = "INSERT INTO Musteriler(AıleID, SehırID, Ad, Soyad, TC, Email, Cinsiyet, Adres, HESkodu) VALUES (@AıleID, @SehırID, @Ad, @Soyad, @TC, @Email, @Cinsiyet, @Adres, @HESkodu)";
            komut = new SqlCommand(sorgu2, baglan);
            komut.Parameters.AddWithValue("@AıleID", 3);
            komut.Parameters.AddWithValue("@SehırID", Sefer_ve_Koltuk_Seçimi.kalkıssehirıd);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@Email", txtEposta.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", txtAd.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@HESkodu", txtHES.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Bilet satışı başarıyla gerçekleştirildi!");

        }

        public void Ödeme_Bilgileri_Load(object sender, EventArgs e)
        {
            txtAd.Text = Sefer_ve_Koltuk_Seçimi.seferID.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle();

        }
    }
}
