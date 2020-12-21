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
            dataGridView1.BackgroundColor = Color.FromArgb(43, 161, 147);
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlCommand komut;
        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
            string sorgu = "INSERT INTO Personeller(PersonelID, SubeID, YoneticiID, Ad, Soyad, Email, Telefon, KullanıcıAdı, Sifre) VALUES (@PersonelID, @SubeID, @YoneticiID, @Ad, @Soyad, @Email, @Telefon, @KullanıcıAdı, @Sifre)";
            komut = new SqlCommand(sorgu, baglan);

            komut.Parameters.AddWithValue("@PersonelID", dataGridView1.Rows[0].Cells[0].Value);
            komut.Parameters.AddWithValue("@SubeID", dataGridView1.Rows[0].Cells[1].Value);
            komut.Parameters.AddWithValue("@YoneticiID", dataGridView1.Rows[0].Cells[2].Value);
            komut.Parameters.AddWithValue("@Ad", dataGridView1.Rows[0].Cells[3].Value);
            komut.Parameters.AddWithValue("@Soyad", dataGridView1.Rows[0].Cells[4].Value);
            komut.Parameters.AddWithValue("@Email", dataGridView1.Rows[0].Cells[5].Value);
            komut.Parameters.AddWithValue("@Telefon", dataGridView1.Rows[0].Cells[6].Value);
            komut.Parameters.AddWithValue("@KullanıcıAdı", dataGridView1.Rows[0].Cells[7].Value);
            komut.Parameters.AddWithValue("@Sifre", dataGridView1.Rows[0].Cells[8].Value);


            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = "";
                }
            }

        }
    }
}
