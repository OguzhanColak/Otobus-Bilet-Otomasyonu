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


namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Sefer_ve_Koltuk_Seçimi : Form
    {
        public Sefer_ve_Koltuk_Seçimi()
        {
            InitializeComponent();
        }


        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");

        private void seferlerigoster()
        {
            int KalkısSehir = comboBox1.SelectedIndex + 1;
            int VarisSehir = comboBox2.SelectedIndex + 1;
            string KalkısVakti = dateTimePicker1.Value.ToShortDateString(); //gün-ay-yıl
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Seferler", baglan);
           // SqlCommand komut2 = new SqlCommand("SELECT system.CONVERT(VARCHAR(10), KalkısVakti, 103) from Seferler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            // SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku.Read())
            {
                //var a = Convert.ToString(oku["KalkısVakti"]);
                //MessageBox.Show(a,"Veritabanındaki tarih");

                //var b = Convert.ToString(KalkısVakti);
                //MessageBox.Show(b, "DatetimePicker'dan seçilen tarih");

                string x = oku.GetValue(4).ToString().Split()[0];
                if (KalkısVakti == x) { MessageBox.Show("Sefer bulunuyor"); }
                else { MessageBox.Show("Sefer bulunamadı"); }
                // var d = Convert.ToString(oku2);
                // MessageBox.Show(d, "Veritabanından gelen tarihin kısa yazılımı");

                //List<string> myList = new List<string>();

                //myList.Add(oku.GetString(4));
                //2020-11-13 08:45:00.000
                //DateTime dt = new DateTime(myList(0));



                /*
                string format = "dd.MM.yyyy";
                dt.toString(format);
                */











                if (KalkısSehir == (Int32)oku["KalkısSehirID"] && VarisSehir == (Int32)oku["VarisSehirID"] && KalkısVakti == Convert.ToString(oku["KalkısVakti"]))
                {
                    MessageBox.Show("Sorgu Çalışıyor!", "Bilgilendirme Penceresi");

                }
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seferlerigoster(); 

        }
    }
}
