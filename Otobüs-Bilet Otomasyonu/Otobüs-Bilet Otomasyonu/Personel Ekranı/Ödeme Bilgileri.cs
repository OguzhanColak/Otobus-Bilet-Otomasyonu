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
        List<string> koltuk = new List<string>();
        public Ödeme_Bilgileri(List<string> x)
        {
            InitializeComponent();

          
          
            koltuk = x;
           //koltuk.RemoveAll(item => item == null);

            //if (!koltuk.Any()) { }
            //foreach (var item in x)
            //{
            //    MessageBox.Show(item);
            //}
            //MessageBox.Show(x[0]);
        }

        SqlConnection baglan2 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlCommand komut;
        public int aıleID;
        public static int personelID;
        public int enBuyukMusterıID;
        private void musteriekle()
        {
            
            string sorguSoyadlarAynıMı = "SELECT Soyad, AıleID FROM Musteriler order by AıleID desc";
            komut = new SqlCommand(sorguSoyadlarAynıMı, baglan);
            baglan.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (aıleID < oku.GetInt32(1)) { aıleID = oku.GetInt32(1); }

                if (txtSoyad.Text == oku.GetString(0)) { aıleID = oku.GetInt32(1); }
            }
            aıleID++;
            baglan.Close();


            string sorgu2 = "INSERT INTO Musteriler(AıleID, SehırID, Ad, Soyad, TC, Email, Cinsiyet, Adres, HESkodu) VALUES (@AıleID, @SehırID, @Ad, @Soyad, @TC, @Email, @Cinsiyet, @Adres, @HESkodu)";
            komut = new SqlCommand(sorgu2, baglan);
            komut.Parameters.AddWithValue("@AıleID", aıleID);
            komut.Parameters.AddWithValue("@SehırID", Sefer_ve_Koltuk_Seçimi.kalkıssehirıd);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@Email", txtEposta.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", txtAd.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@HESkodu", txtHES.Text);

            string sonEklenenMusterininIDsı = "SELECT top 1 MusteriID FROM Musteriler order by MusteriID desc";
            komut = new SqlCommand(sonEklenenMusterininIDsı, baglan2);
            baglan2.Open();
            SqlDataReader oku2 = komut.ExecuteReader();
            while (oku2.Read())
            {
                enBuyukMusterıID = oku2.GetInt32(0);                
            }
            baglan2.Close();



            MessageBox.Show(personelID.ToString());
            string sorgu3 = "INSERT INTO Biletler(PersonelID, MusteriID, SeferID, RezervasyonluMu, KoltukNo, Ucret) VALUES(@PersonelID, @MusteriID, @SeferID, @RezervasyonluMu, @KoltukNo, @Ucret)";
            komut = new SqlCommand(sorgu3, baglan);
            komut.Parameters.AddWithValue("@PersonelID", personelID);
            komut.Parameters.AddWithValue("@MusteriID", enBuyukMusterıID);
            komut.Parameters.AddWithValue("@SeferID", Sefer_ve_Koltuk_Seçimi.seferID);
            komut.Parameters.AddWithValue("@RezervasyonluMu", false);
            komut.Parameters.AddWithValue("@KoltukNo", koltuk[0]);
            komut.Parameters.AddWithValue("@Ucret", 100);


            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Bilet satışı başarıyla gerçekleştirildi!");

        }

        public void Ödeme_Bilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                
                txtAd.Text = Sefer_ve_Koltuk_Seçimi.seferID.ToString();
                
                lblKoltukNo.Text = $"{koltuk[koltuk.Count-1]} numaralı koltuğu alan müşterinin bilgilerini giriniz";
                MessageBox.Show(personelID.ToString());
                txtSoyad.Text = personelID.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle();
        }
    }
}
