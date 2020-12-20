using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Otobüs_Bilet_Otomasyonu
{
    class SystemUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsManager { get; set; } 
        public bool IsLogın { get; set; }
        public DateTime OperationTime { get; set; }
        public string PersonalOperation { get; set; }

        Yönetici_Ekranı ManagerScreen = new Yönetici_Ekranı();
        Personel_Ekranı PersonalScreen = new Personel_Ekranı();

        public void login()
        {
            SqlConnection conn;
            string connectionString;
            SqlCommand cmd;
            SqlDataReader rdr = null;
            connectionString = "Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn.Open();
            cmd = new SqlCommand($"select KullanıcıAdı, Sifre, Ad, YoneticiID, PersonelID from Personeller WHERE KullanıcıAdı='{Username}' AND Sifre='{Password}'", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string Name = rdr.GetString(2);
                IsManager = rdr.GetBoolean(3);
                Id = rdr.GetInt32(4);

                if (IsManager)
                {
                    ManagerScreen.label1.Text = $"{Name} kullanıcısı oturum açtı.";
                    OperationTime = DateTime.Now;
                    PersonalOperation = "Oturum açtı"; 
                    Ödeme_Bilgileri.personelID = Id;
                    IsLogın = true;
                    ManagerScreen.Show();
                }
                else if (!IsManager)
                {
                    PersonalScreen.label1.Text = $"{Name} kullanıcısı oturum açtı.";
                    OperationTime = DateTime.Now;
                    PersonalOperation = "Oturum açtı";
                    Ödeme_Bilgileri.personelID = Id;
                    IsLogın = true;
                    PersonalScreen.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girişi!!!");
                    IsLogın = false;
                }
            }
            conn.Close();
        }
    }
}
