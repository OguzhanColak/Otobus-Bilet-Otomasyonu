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
            systemUser.Username = txtUserName.Text;
            systemUser.Password = txtPassword.Text;
            systemUser.login();
        }

        private void ıslemZamanı_turu()
        {
            /* 
             * $"INSERT INTO PersonelIslem(PersonelIslem, PersonelID, IslemZamanı) VALUES ({txt_personelIslem}, {personel_id}, {islem_zamani})"; 
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
                Hide();
                ıslemZamanı_turu();
            }
            else
            {
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void Giriş_Ekranı_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dil == "tr")
            {
                Properties.Settings.Default.dil = "en";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.dil = "tr";
                Properties.Settings.Default.Save();
            }
            Application.Restart();
        }
    }
}
