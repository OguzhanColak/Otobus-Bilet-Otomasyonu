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
    public partial class Kullanıcı_Ekle : Form
    {
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }

        private void Kullanıcı_Ekle_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);

        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        
        int enBuyukPersonelID;
        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select Top 1 PersonelID from Personeller order by PersonelID desc", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                enBuyukPersonelID = oku.GetInt32(0);
            }
            baglan.Close();

            string sorgu = "INSERT INTO Personeller(PersonelID, YoneticiID, Ad, Soyad, Email, Telefon, KullanıcıAdı, Sifre) VALUES (@PersonelID, @YoneticiID, @Ad, @Soyad, @Email, @Telefon, @KullanıcıAdı, @Sifre)";
            komut = new SqlCommand(sorgu, baglan);

            komut.Parameters.AddWithValue("@PersonelID", enBuyukPersonelID + 1);
            komut.Parameters.AddWithValue("@YoneticiID", checkBox1.Checked);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@Email", textBox3.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@KullanıcıAdı", textBox5.Text);
            komut.Parameters.AddWithValue("@Sifre", textBox6.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"{textBox1.Text} adlı kullanıcıyı sisteme eklemek istediğinizden istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else 
            {
                dialogResult = MessageBox.Show($"Are you sure you want to add {textBox1.Text} user to the system?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dialogResult == DialogResult.Yes)
            {

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("User successfully added.");
                }
            }

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {       
                    ((CheckBox)control).Checked = false;
                }
            }
        }
    }
}
