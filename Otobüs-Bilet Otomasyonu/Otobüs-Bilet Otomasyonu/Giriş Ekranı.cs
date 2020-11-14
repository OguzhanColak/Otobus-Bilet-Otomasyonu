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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Yönetici_Ekranı f2 = new Yönetici_Ekranı();
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");

        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Personel", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                if ((oku["KullanıcıAdı"].ToString() == "fevzi22") && (oku["Sifre"].ToString() == "gjeo5dk"))
                {
                    f2.label1.Text = "Fevzi kardeşim hoşgeldin";
                }
                else if ((oku["KullanıcıAdı"].ToString() == "salihkk") && (oku["Sifre"].ToString() == "5d8cm2h"))
                {
                    f2.label1.Text = "Salih kardeş hoşgeldin";
                }
            }
            baglan.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoster();

            this.Hide();

            f2.Show();

            //Sayısal değer çekseydik: double s1 = Convert.ToDouble(textBox1.Text);
            //                            int s1 = int.Parse(textBox1.Text);
            //https://youtu.be/Z-9cV6-m0Mc

        }


    }
}
