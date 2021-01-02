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
        public bool IsDeleted { get; set; } //kullanılmadı
        public bool IsManager { get; set; }
        public bool IsLogin { get; set; }
        public DateTime OperationTime { get; set; }
        public string PersonalOperation { get; set; }

        Yönetici_Ekranı managerScreen = new Yönetici_Ekranı();
        Personel_Ekranı personalScreen = new Personel_Ekranı();


        public void login()
        {
            SqlConnection conn;
            string connectionString;
            SqlCommand cmd;
            SqlDataReader rdr;
            connectionString = "Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn.Open();
            cmd = new SqlCommand($"select KullanıcıAdı, Sifre, Ad, YoneticiID, PersonelID from Personeller WHERE KullanıcıAdı='{Username}' AND Sifre='{Password}'", conn);
            rdr = cmd.ExecuteReader();

            //birden fazla yanlış girişte yapılacak eylem
            //şifremi unuttum
            //şifremi hatırla
            //kayıt ol --> karakter kısıtlaması - farklı karakter türlerinden en az bir tane

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    string Name = rdr.GetString(2);
                    IsManager = rdr.GetBoolean(3);
                    Id = rdr.GetInt32(4);

                    if (IsManager)
                    {
                        managerScreen.label1.Text = $"{Name} kullanıcısı oturum açtı.";
                        OperationTime = DateTime.Now;
                        PersonalOperation = "Oturum açtı";
                        Ödeme_Bilgileri.personelID = Id;
                        IsLogin = true;
                        managerScreen.Show();
                    }
                    else
                    {
                        personalScreen.label1.Text = $"{Name} kullanıcısı oturum açtı.";
                        OperationTime = DateTime.Now;
                        PersonalOperation = "Oturum açtı";
                        Ödeme_Bilgileri.personelID = Id;
                        IsLogin = true;
                        personalScreen.Show();
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre girişi boş bırakılamaz!");
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre girişi!");
                }
                IsLogin = false;
            }
            conn.Close();
        }
    }
}
