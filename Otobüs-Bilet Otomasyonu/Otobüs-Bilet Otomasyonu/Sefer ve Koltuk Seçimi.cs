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

                string DBKalkısVaktı = oku.GetValue(4).ToString().Split()[0];

                if (KalkısSehir == (Int32)oku["KalkısSehirID"] && VarisSehir == (Int32)oku["VarisSehirID"] && KalkısVakti == DBKalkısVaktı)
                {
                    MessageBox.Show("Sorgu Çalışıyor!", "Bilgilendirme Penceresi");
                    button2.Text = $"{KalkısVakti}     {comboBox1.SelectedItem}     {comboBox2.SelectedItem}";
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
    }
}
