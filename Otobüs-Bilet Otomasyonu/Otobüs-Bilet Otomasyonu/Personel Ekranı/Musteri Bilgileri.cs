using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Musteri_Bilgileri : Form
    {
        public Musteri_Bilgileri()
        {
            InitializeComponent();
        }
        string vericek;
        private void tablo()
        {
            BackColor = Color.FromArgb(43, 161, 147);
            dataGridView2.BackgroundColor = Color.FromArgb(43, 161, 147);
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();

            if (Properties.Settings.Default.dil == "tr")
            {
                vericek = "select Ad, Soyad, TC, Email, Cinsiyet, HESkodu as [HES Kodu], Adres, SeferID as [Sefer Numarası], KoltukNo as [Koltuk Numarası], m.MusteriID as [Müşteri Numarası] from Musteriler m inner join Biletler b on m.MusteriID = b.MusteriID";
            }
            else if (Properties.Settings.Default.dil == "en")
            {
                vericek = "select Ad as Name, Soyad as Surname, TC as Citizenship, Email as Email, Cinsiyet as Gender, HESkodu as [HES Code], Adres as Adress, SeferID as [Flight Number], KoltukNo as [Seat Number], m.MusteriID as [Customer Number] from Musteriler m inner join Biletler b on m.MusteriID = b.MusteriID";
            }

            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void Musteri_Bilgileri_Load(object sender, EventArgs e)
        {
            tablo();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            Personel_Ekranı personel_Ekranı = new Personel_Ekranı();
            int sılınecekMusterıID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[9].Value);
            string sılınecekMusterıAdı = $"{dataGridView2.CurrentRow.Cells[0].Value}";

            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"{sılınecekMusterıAdı} adlı müşteriyi silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
            else if (Properties.Settings.Default.dil == "en")
            {
                dialogResult = MessageBox.Show($"Are you sure you want to delete the customer named {sılınecekMusterıAdı}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (dialogResult == DialogResult.Yes)
            {
                komut.CommandText = $"DELETE FROM Musteriler where MusteriID = {sılınecekMusterıID}";
                baglan.Open();
                komut.Connection = baglan;
                int i = komut.ExecuteNonQuery();
                baglan.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Müşteri başarıyla silindi.");
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("Customers successfully deleted.");
                }
                if (i == 1)
                {
                    tablo();
                }
            }
            else
            {
                //do nothing...
            }
        }

        private void müşteriyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is Label || control is Button)
                {
                    control.Visible = true;
                }
            }

            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString().Trim();
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString().Trim();
            textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString().Trim();
            textBox6.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString().Trim();
            textBox7.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString().Trim();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"{dataGridView2.CurrentRow.Cells[0].Value} adlı müşterinin bilgilerini güncellemek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (Properties.Settings.Default.dil == "en")
            {
                dialogResult = MessageBox.Show($"Are you sure you want to update customer name of {dataGridView2.CurrentRow.Cells[0].Value}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (dialogResult == DialogResult.Yes)
            {
                komut.CommandText = $"UPDATE Musteriler SET Ad = @Ad, Soyad = @Soyad, TC = @TC, Email = @Email, Cinsiyet = @Cinsiyet, HESkodu = @HESkodu, Adres = @Adres where TC={dataGridView2.CurrentRow.Cells[2].Value}";
                komut.Parameters.AddWithValue("@Ad", textBox1.Text);
                komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@TC", textBox3.Text);
                komut.Parameters.AddWithValue("@Email", textBox4.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", textBox5.Text);
                komut.Parameters.AddWithValue("@HESkodu", textBox6.Text);
                komut.Parameters.AddWithValue("@Adres", textBox7.Text);

                baglan.Open();
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Müşteri başarıyla güncellendi.");
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("Customers successfully updated.");
                }

                foreach (Control control in Controls)
                {
                    if (control is TextBox || control is Label || control is Button)
                    {
                        control.Visible = false;
                    }
                }
                tablo();
            }
            else
            {
                //do nothing...
            }
        }
    }
}
