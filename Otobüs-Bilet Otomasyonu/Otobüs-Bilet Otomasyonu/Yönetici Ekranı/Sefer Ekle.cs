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
    public partial class Sefer_Ekle : Form
    {
        public Sefer_Ekle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        int comboBox1SuankıIndex;
        int comboBox2SuankıIndex;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"Sisteme yeni bir sefer eklemek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (Properties.Settings.Default.dil == "en")
            {
                dialogResult = MessageBox.Show($"Are you sure you want to add a new voyage to the system?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand();

                string sorgu = "INSERT INTO Seferler(KalkısSehirID, VarisSehirID, OtobusID, KalkısVakti, VarisVakti, SeferSure) VALUES (@KalkısSehirID, @VarisSehirID, @OtobusID, @KalkısVakti, @VarisVakti, @SeferSure)";
                komut = new SqlCommand(sorgu, baglan);

                komut.Parameters.AddWithValue("@KalkısSehirID", comboBox1SuankıIndex + 1);
                komut.Parameters.AddWithValue("@VarisSehirID", comboBox2SuankıIndex + 1);
                komut.Parameters.AddWithValue("@OtobusID", comboBox3.SelectedItem);
                komut.Parameters.AddWithValue("@KalkısVakti", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@VarisVakti", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@SeferSure", textBox2.Text);

                baglan.Open();
                komut.ExecuteNonQuery();
                baglan.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Sefer Başarıyla Eklendi.");
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("Voyage added successfully.");
                }


                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                    else if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = DateTime.Now;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).Items.Clear();
                    }
                
                }
            }
        }

        private void Sefer_Ekle_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand komut = new SqlCommand($"Select SehirAdı from Sehirler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku.GetString(0).Trim());
                comboBox2.Items.Add(oku.GetString(0).Trim());
            }
            baglan.Close();

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand komut2 = new SqlCommand($"select OtobusID from Otobüsler", baglan);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox3.Items.Add(oku2.GetInt32(0));
            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1SuankıIndex = comboBox1.SelectedIndex;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2SuankıIndex = comboBox2.SelectedIndex;
        }
    }
}
