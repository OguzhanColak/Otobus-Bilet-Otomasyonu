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
using System.Linq;
using System.Text.RegularExpressions;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Sefer_ve_Koltuk_Seçimi : Form
    {
        public Sefer_ve_Koltuk_Seçimi()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        public static int seferID;
        public static int kalkıssehirıd;
        public static int kalankoltuksayısı;
        public void koltuk_alınmıs_mı()
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan1.Open();
            SqlCommand komut = new SqlCommand($"select KoltukNo from Biletler where SeferID = {Convert.ToInt32(seferID)}", baglan1);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                string a = oku.GetInt32(0).ToString();
                

                foreach (var button in this.Controls.OfType<Button>())
                {
                    if(button.Text==a){ button.BackColor = Color.Red; }
                }
            }
            baglan1.Close();

        }

        public void seferlerigoster()
        {
            string KalkısSehir = comboBox1.Text.ToString();
            string VarisSehir = comboBox2.Text.ToString().Trim();
            string KalkısVakti = dateTimePicker1.Value.ToShortDateString(); // Gün-Ay-Yıl

            baglan.Open();
            SqlCommand komut = new SqlCommand("select KalkısVakti, s1.SehirAdı, s2.SehirAdı, BosKoltuk, KoltukDuzeni, SeferID, KalkısSehirID from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID  inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID inner join Otobüsler o on o.OtobusID = sf.OtobusID where SeferID = 1", baglan);
            SqlDataReader oku = komut.ExecuteReader();

          

            while (oku.Read())
            {

                string DBKalkısVaktıGun = oku.GetValue(0).ToString().Split()[0]; // Gün-Ay-Yıl
                string DBKalkısVaktıSaat = oku.GetValue(0).ToString().Split()[1];// Saat-Dakika
                string DBKalkısSehir = oku.GetValue(1).ToString().Trim();
                string DBVarisSehir = oku.GetValue(2).ToString().Trim();
                kalkıssehirıd = oku.GetInt32(6);


                if (KalkısSehir == DBKalkısSehir && VarisSehir == DBVarisSehir && KalkısVakti == DBKalkısVaktıGun)
                {

                    seferID = oku.GetInt32(5);
                    kalankoltuksayısı = Convert.ToInt32(oku.GetValue(3));

                    MessageBox.Show("Sorgu Çalışıyor! ", "Bilgilendirme Penceresi");
                    MessageBox.Show(seferID.ToString(), "Bilgilendirme Penceresi");
                    button2.Text = $"{KalkısVakti}     {comboBox1.SelectedItem}     {comboBox2.SelectedItem}     {DBKalkısVaktıSaat}      {kalankoltuksayısı}";
                    //eğer içeri girerse paneller oluşturulacak.

                    koltuk_alınmıs_mı();

                }
            }

            baglan.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.BackColor == Color.Green) { b.BackColor = SystemColors.ControlLight; }
            else { b.BackColor = Color.Green; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seferlerigoster();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Ödeme_Bilgileri f1 = new Ödeme_Bilgileri();
            f1.Show();
        }
    }
}
