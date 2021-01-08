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
    public partial class Personel_Bilgileri : Form
    {
        public Personel_Bilgileri()
        {
            InitializeComponent();
        }

        private void tablo()
        {
            BackColor = Color.FromArgb(43, 161, 147);
            dataGridView1.BackgroundColor = Color.FromArgb(43, 161, 147);
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();

            string vericek = "select Ad, Soyad, Email, Telefon from Personeller";
            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
            //dataGridView1.Size = ds.Tables.siz
            dataGridView1.Columns[0].Width = 115;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 115;
            dataGridView1.Columns[3].Width = 115;
        }

        private void Personel_Bilgileri_Load(object sender, EventArgs e)
        {
            tablo();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            string sılınecekPersonelAd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sılınecekPersonelSoyad = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"{sılınecekPersonelAd} adlı kullanıcıyı silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (Properties.Settings.Default.dil == "en")
            {
                dialogResult = MessageBox.Show($"Are you sure you want to delete the personnel named {sılınecekPersonelAd}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            }

            if (dialogResult == DialogResult.Yes)
            {
                komut.CommandText = $"DELETE FROM Personeller where Ad = {sılınecekPersonelAd} And Soyad = {sılınecekPersonelSoyad}";
                baglan.Open();
                komut.Connection = baglan;
                int i = komut.ExecuteNonQuery();
                baglan.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Personel başarıyla silindi.");

                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("Personnel successfully deleted.");
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
        int guncellencekPersonelID;
        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is Label || control is Button || control is CheckBox)
                {
                    control.Visible = true;
                }
            }

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select Ad, Soyad, Email, Telefon, KullanıcıAdı, Sifre, YoneticiID, PersonelID from Personeller", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            int j = 0;

            while (oku.Read())
            {

                if (j == dataGridView1.CurrentRow.Index)
                {
                    textBox1.Text = oku.GetString(0);
                    textBox2.Text = oku.GetString(1);
                    textBox3.Text = oku.GetString(2);
                    textBox4.Text = oku.GetString(3);

                    textBox5.Text = oku.GetString(4);
                    textBox6.Text = oku.GetString(5);
                    checkBox1.Checked = oku.GetBoolean(6);
                    guncellencekPersonelID = oku.GetInt32(7);
                    break;
                }
                j++;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            DialogResult dialogResult = new DialogResult();

            if (Properties.Settings.Default.dil == "tr")
            {
                dialogResult = MessageBox.Show($"{dataGridView1.CurrentRow.Cells[0].Value} adlı kullanıcının bilgilerini güncellemek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (Properties.Settings.Default.dil == "en")
            {
                dialogResult = MessageBox.Show($"Are you sure you want to update customer name of {dataGridView1.CurrentRow.Cells[0].Value}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (dialogResult == DialogResult.Yes)
            {
                komut.CommandText = $"UPDATE Personeller SET YoneticiID= @YoneticiID, Ad = @Ad, Soyad = @Soyad, Email = @Email, Telefon = @Telefon, KullanıcıAdı = @KullanıcıAdı, Sifre = @Sifre where PersonelID = {guncellencekPersonelID} ";
                komut.Parameters.AddWithValue("@YoneticiID", checkBox1.Checked);
                komut.Parameters.AddWithValue("@Ad", textBox1.Text);
                komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@Email", textBox3.Text);
                komut.Parameters.AddWithValue("@Telefon", textBox4.Text);
                komut.Parameters.AddWithValue("@KullanıcıAdı", textBox5.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox6.Text);

                baglan.Open();
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("User successfully updated.");
                }

                foreach (Control control in Controls)
                {
                    if (control is TextBox || control is Label || control is Button || control is CheckBox)
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
