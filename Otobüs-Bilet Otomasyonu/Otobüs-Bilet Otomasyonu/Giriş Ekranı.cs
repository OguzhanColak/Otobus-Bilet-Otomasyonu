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

       
        Personel_Ekranı f1 = new Personel_Ekranı();
        Yönetici_Ekranı f2 = new Yönetici_Ekranı();
        //Ödeme_Bilgileri f3 = new Ödeme_Bilgileri(null);
        SystemUser systemUser = new SystemUser();
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");

        private void verilerigoster()
        {
            //baglan.Open();
            //string KullanıcıAd = txtUserName.Text;
            //string Sıfre = txtPassword.Text;
            //SqlCommand komut = new SqlCommand($"select KullanıcıAdı, Sifre, Ad, YoneticiID, PersonelID from Personeller WHERE KullanıcıAdı='{KullanıcıAd}' AND Sifre='{Sıfre}'", baglan);
            //SqlDataReader oku = null;
            //oku = komut.ExecuteReader();
            ////PictureBox pct = new PictureBox()
            ////{
            ////    Image = Properties.Resources.dosyadi
            ////};
            //while (oku.Read())
            //{
            //    string Ad = oku.GetString(2);
            //    int YöneticiID = oku.GetInt32(3);
            //    personelID = oku.GetInt32(4);
            //        if (YöneticiID == 1)
            //        {
            //            f2.label1.Text = $"{Ad} kullanıcısı oturum açtı.";
            //            IslemZamanı = DateTime.Now;
            //            PersonelIslem = "Oturum açtı";
            //            MessageBox.Show(personelID.ToString());
            //            Ödeme_Bilgileri.personelID = personelID;

            //            f2.Show();
            //        }
            //        else
            //        {
            //            f1.label1.Text = $"{Ad} kullanıcısı oturum açtı.";
            //            IslemZamanı = DateTime.Now;
            //            PersonelIslem = "Oturum açtı";
            //            Ödeme_Bilgileri.personelID = personelID;
            //            f1.Show();
            //        }
            //        kullanıcı_giris = true; 
            //}
            //if (!kullanıcı_giris)
            //{
            //    MessageBox.Show("Hatalı kullanıcı adı veya şifre girişi!!!");
            //    kullanıcı_giris = false;
            //}
            //baglan.Close();
            systemUser.Username = txtUserName.Text;
            systemUser.Password = txtPassword.Text;
            systemUser.login();

        }

        private void ıslemZamanı_turu()
        {
            /*
             * 
             * 
             * $"INSERT INTO PersonelIslem(PersonelIslem, PersonelID, IslemZamanı) VALUES ({txt_personelIslem}, {personel_id}, {islem_zamani})";
             * 
             */
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut;
            string sorgu = "INSERT INTO PersonelIslem(PersonelIslem, PersonelID, IslemZamanı) VALUES (@PersonelIslem, @PersonelID, @IslemZamanı)";
            komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@PersonelIslem", systemUser.PersonalOperation);
            komut.Parameters.AddWithValue("@PersonelID", systemUser.Id);
            komut.Parameters.AddWithValue("@IslemZamanı", systemUser.OperationTime);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            verilerigoster();
            if (systemUser.IsLogin)
            {
                ıslemZamanı_turu();
            }
            Hide();
            
            


        }

        private void Giriş_Ekranı_Load(object sender, EventArgs e)
        {
            
        }
    }
}
