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
        List<string> koltuk = new List<string>();
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
            SqlCommand komut = new SqlCommand($"Select KoltukNo from Biletler where SeferID = {Convert.ToInt32(seferID)}", baglan1);

            SqlDataReader oku = komut.ExecuteReader();

            MessageBox.Show($"{seferID}");

            foreach (Control contr in panel1.Controls)
            {
                if (contr is Button)
                {
                    contr.BackColor = SystemColors.ControlLight;
                    contr.Enabled = true;
                }
            }

            //foreach (var button in this.Controls.OfType<Button>())
            //{

            //    button.BackColor = SystemColors.ControlLight;
            //    button.Enabled = true;
            //}

            if (oku.HasRows)
            {
                while (oku.Read())
                {
                    string a = oku.GetInt32(0).ToString();

                    foreach (Control contr in panel1.Controls)
                    {
                        if (contr is Button)
                        {
                            if (contr.Text == a)
                            {
                                contr.BackColor = Color.Red;
                                contr.Enabled = false;
                            }
                        }
                    }
                    //foreach (var button in this.Controls.OfType<Button>())
                    //{

                    //    if (button.Text == a) { button.BackColor = Color.Red; button.Enabled = false; }
                    //}
                }
            }
            baglan1.Close();
        }

        public void seferlerigoster()
        {
            string KalkısSehir = comboBox1.Text.ToString().Trim();
            string VarisSehir = comboBox2.Text.ToString().Trim();
            string KalkısVakti = dateTimePicker1.Value.ToShortDateString(); // Gün-Ay-Yıl
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("select KalkısVakti, s1.SehirAdı,s2.SehirAdı, BosKoltuk, KoltukDuzeni, SeferID, KalkısSehirID from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID  inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID inner join Otobüsler o on o.OtobusID = sf.OtobusID", baglan);
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
                    MessageBox.Show($"İçeri giren seferID: {seferID.ToString()}", "SeferID");
                    btnSeferıSec.Text = $"{KalkısVakti}     {comboBox1.SelectedItem}     {comboBox2.SelectedItem}     {DBKalkısVaktıSaat}      {kalankoltuksayısı}";
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
            else
            {
                b.BackColor = Color.Green;
            }
        }

        private void SeferAra_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            seferlerigoster();
            panel2.Visible = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            koltuk.Clear();
            //foreach (var button in Controls.OfType<Button>())
            //{
            //    if (button.BackColor == Color.Green) { koltuk.Add(button.Text); }
            //}
            foreach (Control contr in panel1.Controls)
            {
                if (contr is Button)
                {
                    if (contr.BackColor == Color.Green) { koltuk.Add(contr.Text); }
                }
            }
            Ödeme_Bilgileri f1 = new Ödeme_Bilgileri(koltuk);
            f1.Show();
        }

        private void Sefer_ve_Koltuk_Seçimi_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Height = btnSeferıSec.Height;

            baglan.Open();
            SqlCommand komut = new SqlCommand($"Select SehirAdı from Sehirler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku.GetString(0).Trim());
                comboBox2.Items.Add(oku.GetString(0).Trim());
            }
            baglan.Close();

        }

        private void btnSeferıSec_Click(object sender, EventArgs e)
        {
            if (panel2.Height == btnSeferıSec.Height)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Height += 5; 
            if (panel2.Height == 340)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Height -= 5;
            if (panel2.Height == btnSeferıSec.Height)
            {
                timer2.Stop();
            }
        }
    }
}
