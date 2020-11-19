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
        public static string seferID;

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
            int KalkısSehir = comboBox1.SelectedIndex + 1;
            int VarisSehir = comboBox2.SelectedIndex + 1;
            string KalkısVakti = dateTimePicker1.Value.ToShortDateString(); //gün-ay-yıl

            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Seferler", baglan);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {

                string DBKalkısVaktı = oku.GetValue(4).ToString().Split()[0];

                if (KalkısSehir == (Int32)oku["KalkısSehirID"] && VarisSehir == (Int32)oku["VarisSehirID"] && KalkısVakti == DBKalkısVaktı)
                {
                   
                    seferID = oku["SeferID"].ToString();

                    MessageBox.Show("Sorgu Çalışıyor! ", "Bilgilendirme Penceresi");
                    MessageBox.Show(seferID, "Bilgilendirme Penceresi");
                    button2.Text = $"{KalkısVakti}     {comboBox1.SelectedItem}     {comboBox2.SelectedItem}";
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

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Ödeme_Bilgileri f1 = new Ödeme_Bilgileri();
            f1.Show();
        }
    }
}
