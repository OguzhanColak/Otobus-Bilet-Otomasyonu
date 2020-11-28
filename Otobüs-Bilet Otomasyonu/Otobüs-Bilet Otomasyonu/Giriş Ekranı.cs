using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Giriş_Ekranı : Form
    {
        public Giriş_Ekranı()
        {
            InitializeComponent();
        }
        string PersonelIslem;
        DateTime IslemZamanı;
        int personelID;
        bool kullanıcı_giris;


        Personel_Ekranı f1 = new Personel_Ekranı();
        Yönetici_Ekranı f2 = new Yönetici_Ekranı();
        Ödeme_Bilgileri f3 = new Ödeme_Bilgileri(null);
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");

        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select KullanıcıAdı, Sifre, Ad, YoneticiID, PersonelID from Personeller", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            string KullanıcıAd = txtKullanıcıAd.Text;
            string Sıfre = txtSıfre.Text;

            while (oku.Read())
            {
                string Ad = oku.GetString(2);
                int YöneticiID = oku.GetInt32(3);
                string DBKullanıcıAd = oku.GetString(0);
                string DBSıfre = oku.GetString(1);
                personelID = oku.GetInt32(4);

                if (DBKullanıcıAd == KullanıcıAd && DBSıfre == Sıfre)
                {
                    MessageBox.Show("Buraya giriyorr");
                    MessageBox.Show(personelID.ToString());
                    if (YöneticiID == 1)
                    {
                        f2.label1.Text = $"{Ad} kullanıcısı oturum açtı.";
                        IslemZamanı = DateTime.Now;
                        PersonelIslem = "Oturum açtı";
                        Ödeme_Bilgileri.personelID = personelID;
                        f2.Show();
                    }
                    else
                    {
                        f1.label1.Text = $"{Ad} kullanıcısı oturum açtı.";
                        IslemZamanı = DateTime.Now;
                        PersonelIslem = "Oturum açtı";
                        Ödeme_Bilgileri.personelID = personelID;
                        f1.Show();
                    }
                    kullanıcı_giris = true;
                }
                else
                {
                   
                }
            }
            if (!kullanıcı_giris)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girişi!!!");
                kullanıcı_giris = false;
            }
            baglan.Close();
        }

        private void ıslemZamanı_turu()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut;
            string sorgu = "INSERT INTO PersonelIslem(PersonelIslem, PersonelID, IslemZamanı) VALUES (@PersonelIslem, @PersonelID, @IslemZamanı)";
            komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@PersonelIslem", PersonelIslem);
            komut.Parameters.AddWithValue("@PersonelID", personelID);
            komut.Parameters.AddWithValue("@IslemZamanı", IslemZamanı);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoster();
            if (kullanıcı_giris)
            {
                ıslemZamanı_turu();
            }
            this.Hide();

            

            //Sayısal değer çekseydik: double s1 = Convert.ToDouble(textBox1.Text);
            //                            int s1 = int.Parse(textBox1.Text);
            //https://youtu.be/Z-9cV6-m0Mc

        }


    }
}
