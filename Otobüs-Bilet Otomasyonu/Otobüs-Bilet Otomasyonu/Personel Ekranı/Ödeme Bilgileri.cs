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
    public partial class Ödeme_Bilgileri : Form
    {
        List<string> koltuk = new List<string>();

        //Bu listelere değer atanamadı
        List<int> CıftA = new List<int>();
        List<int> CıftB = new List<int>();
        List<int> CıftC = new List<int>();
        List<int> CıftD = new List<int>();

        //List<int> CıftA = new List<int>() { 3, 8, 13, 18, 23, 28, 33 };
        //List<int> CıftB = new List<int>() { 2, 7, 12, 17, 22, 27, 32 };

        public Ödeme_Bilgileri(List<string> x, List<int> cıftA, List<int> cıftB, List<int> cıftC, List<int> cıftD)
        {
            InitializeComponent();

            koltuk = x;
            CıftA = cıftA;
            CıftB = cıftB;
            CıftC = cıftC;
            CıftD = cıftD;
           
            //koltuk.RemoveAll(item => item == null);

            //if (!koltuk.Any()) { }
            //foreach (var item in x)
            //{
            //    MessageBox.Show(item);
            //}
            //MessageBox.Show(x[0]);
        }

        SqlConnection baglan2 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlConnection baglan3 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlConnection baglan4 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
        SqlCommand komut;

        public int aıleID;
        public static int personelID;
        public int enBuyukMusterıID;
        public int listIndex = 0;
        public int kalkısSehırID;

        private void musteriekle()
        {
            string sorguSoyadlarAynıMı = "SELECT Soyad, AıleID FROM Musteriler order by AıleID desc";
            komut = new SqlCommand(sorguSoyadlarAynıMı, baglan);
            baglan.Open();
            SqlDataReader oku = komut.ExecuteReader();
            MessageBox.Show(txtSoyad.Text);
            while (oku.Read())
            {
                if (aıleID < oku.GetInt32(1)) { aıleID = oku.GetInt32(1) + 1; }

                if (txtSoyad.Text == oku.GetString(0)) { aıleID = oku.GetInt32(1); break; }
            }
            baglan.Close();


            // AILE ID SIFIR OLMA DURUMUNDAN DOLAYI DİALOGRESULT DEVREYE GİRİYOR.
            MessageBox.Show($"aıleID: {aıleID}");
            bool aynıAıledenMı = true;
            bool y = false;
            string cıftlıKoltukdakilerAıleMı = $"Select KoltukNo, AıleID from Musteriler m inner join Biletler b on m.MusteriID = b.MusteriID where b.SeferID = {Sefer_ve_Koltuk_Seçimi.seferID}";
            komut = new SqlCommand(cıftlıKoltukdakilerAıleMı, baglan);
            baglan.Open();
            SqlDataReader oku3 = komut.ExecuteReader();
            while (oku3.Read())
            {
                int asd = 0;
                if ((CıftA.Contains(oku3.GetInt32(0) + 1) || CıftB.Contains(oku3.GetInt32(0) - 1)) && (CıftA.Count != 7 || CıftB.Count != 7))
                {
                    //foreach (var item in CıftA)
                    //{
                    //    MessageBox.Show(item.ToString());
                    //    listBox2.Items.Add(item);
                    //}
                    //foreach (var item in CıftB)
                    //{
                    //    MessageBox.Show(item.ToString());
                    //    listBox3.Items.Add(item);
                    //}


                    asd++;
                    if (aıleID == oku3.GetInt32(1))
                    {
                        y = true;
                        break;
                    }
                    else
                    {
                        y = false;
                    }
                    //MessageBox.Show("EĞERE GİRİYOR");
                    //if (aıleID != oku3.GetInt32(1))
                    //{
                    //    MessageBox.Show("İkili koltuklarda sadece aile üyeleri yan yana oturabilir. Lütfen tekli koltukları veya henüz alınmamış ikili koltukları tercih ediniz.");
                    //    //eğer bu uyarı verilirse kullanıcıya koltuk seçme ekranına dönme şansı tanınacak. Koltuğu değiştirme şansı verilecek.
                    //    //yada o koltuğu almaktan vazgeçme hakkı verilir. Birden fazla koltuk seçilip bu ekrana gelinmişse listenin sonraki elemanına geçilir.
                    //    //Birden fazla koltuk seçilmemişse Ödeme ekranı formu kapanıp koltuk seçme ekranına dönülecek.
                    //    aıleID = 0;
                    //    foreach (TextBox txtBox in Controls.OfType<TextBox>())
                    //    {
                    //        txtBox.Clear();
                    //    }
                    //    aynıAıledenMı = false;
                    //}
                }
                else if ((CıftC.Contains(oku3.GetInt32(0) + 1) || CıftD.Contains(oku3.GetInt32(0) - 1)) && (CıftC.Count != 27 || CıftD.Count != 27))
                {
                    if (aıleID == oku3.GetInt32(1))
                    {
                        y = true;
                        break;
                    }
                    else
                    {
                        y = false;
                    }

                    //if (aıleID != oku3.GetInt32(1))
                    //{
                    //    MessageBox.Show($"aıleID != oku3.GetInt32(1): {aıleID != oku3.GetInt32(1)} aıleID: {aıleID} oku3.GetInt32(1): {oku3.GetInt32(1)}");
                    //    MessageBox.Show($"aıleID: {aıleID}");
                    //    MessageBox.Show("İkili koltuklarda sadece aile üyeleri yan yana oturabilir. Lütfen tekli koltukları veya henüz alınmamış ikili koltukları tercih ediniz.");
                    //    bu mesajdan sonra üşteriye dialogresultla ne yapmak isatediği sorulacak
                    //    dialog resultla yap en iyisi

                    //    DialogResult dialogResult = new DialogResult();
                    //    MessageBox.Show($"aıleID: {aıleID}");
                    //    dialogResult = MessageBox.Show("İkili koltuklarda sadece aile üyeleri yan yana oturabilir. Koltuk seçim ekranına dönmek ister misiniz?", "Hatalı Koltuk Seçimi!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    //    aıleID = 0;
                    //    foreach (TextBox txtBox in Controls.OfType<TextBox>())
                    //    {
                    //        txtBox.Clear();
                    //    }
                    //    aynıAıledenMı = false;

                    //    if (dialogResult == DialogResult.Yes)
                    //    {
                    //        Close();
                    //        break;
                    //    }
                    //    else if (dialogResult == DialogResult.No)
                    //    {
                    //        break;
                    //    }
                    //}
                }
                else
                {
                    y = true;
                }
            }

            if (y == false)
            {
                DialogResult dialogResult = new DialogResult();
                MessageBox.Show($"aıleID: {aıleID}");

                if (Properties.Settings.Default.dil == "tr")
                {
                    dialogResult = MessageBox.Show("İkili koltuklarda sadece aile üyeleri yan yana oturabilir. Koltuk seçim ekranına dönmek ister misiniz?", "Hatalı Koltuk Seçimi!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    dialogResult = MessageBox.Show("In double seats, only family members can sit side by side. Would you like to return to the seat selection screen?", "Incorrect Seat Selection!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

                aıleID = 0;

                aynıAıledenMı = false;

                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    foreach (TextBox txtBox in Controls.OfType<TextBox>())
                    {
                        txtBox.Clear();
                    }
                }
            }

            if (aynıAıledenMı)
            {
                string sonEklenenMusterininIDsı = "SELECT top 1 MusteriID FROM Musteriler order by MusteriID desc";
                komut = new SqlCommand(sonEklenenMusterininIDsı, baglan2);
                baglan2.Open();
                SqlDataReader oku2 = komut.ExecuteReader();
                while (oku2.Read())
                {
                    enBuyukMusterıID = oku2.GetInt32(0);
                }
                baglan2.Close();
                enBuyukMusterıID++;

                kalkısSehırID = Sefer_ve_Koltuk_Seçimi.kalkıssehirıd;
                string sorgu2 = "INSERT INTO Musteriler(MusteriID, AıleID, SehırID, Ad, Soyad, TC, Email, Cinsiyet, Adres, HESkodu) VALUES (@MusteriID, @AıleID, @SehırID, @Ad, @Soyad, @TC, @Email, @Cinsiyet, @Adres, @HESkodu)";
                komut = new SqlCommand(sorgu2, baglan3);
                komut.Parameters.AddWithValue("@MusteriID", enBuyukMusterıID);
                komut.Parameters.AddWithValue("@AıleID", aıleID);
                komut.Parameters.AddWithValue("@SehırID", kalkısSehırID);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@TC", txtTC.Text);
                komut.Parameters.AddWithValue("@Email", txtEposta.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", txtAd.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@HESkodu", txtHES.Text);

                baglan3.Open();
                komut.ExecuteNonQuery();
                baglan3.Close();


                MessageBox.Show(enBuyukMusterıID.ToString());
                string sorgu3 = "INSERT INTO Biletler(PersonelID, MusteriID, SeferID, RezervasyonluMu, KoltukNo, Ucret) VALUES(@PersonelID, @MusteriID, @SeferID, @RezervasyonluMu, @KoltukNo, @Ucret)";
                komut = new SqlCommand(sorgu3, baglan4);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@MusteriID", enBuyukMusterıID);
                komut.Parameters.AddWithValue("@SeferID", Sefer_ve_Koltuk_Seçimi.seferID);
                komut.Parameters.AddWithValue("@RezervasyonluMu", false);
                komut.Parameters.AddWithValue("@KoltukNo", koltuk[listIndex]);
                komut.Parameters.AddWithValue("@Ucret", 100);


                baglan4.Open();
                komut.ExecuteNonQuery();
                baglan4.Close();

                if (Properties.Settings.Default.dil == "tr")
                {
                    MessageBox.Show("Bilet satışı başarıyla gerçekleştirildi!");
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    MessageBox.Show("The ticket sale has been successful!");
                }


                var intList = koltuk.Select(s => Convert.ToInt32(s)).ToList();
                var sortedValues = intList.OrderBy(v => v).ToList();

                if (sortedValues.Count - 1 > listIndex) //2-1 , 2-2 , 
                {
                    listIndex++;
                }
                else
                {
                    Hide();
                }

                if (Properties.Settings.Default.dil == "tr")
                {
                    lblKoltukNo.Text = $"{sortedValues[listIndex]} numaralı koltuğu alan müşterinin bilgilerini giriniz";
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    lblKoltukNo.Text = $"Enter the information of the customer who bought seat number {sortedValues[listIndex]}";
                }

                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.Clear();
                }
            }
        }

        public void Ödeme_Bilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                var intList = koltuk.Select(s => Convert.ToInt32(s)).ToList();
                var sortedValues = intList.OrderBy(v => v).ToList();

                if (Properties.Settings.Default.dil == "tr")
                {
                    lblKoltukNo.Text = $"{sortedValues[listIndex]} numaralı koltuğu alan müşterinin bilgilerini giriniz";
                }
                else if (Properties.Settings.Default.dil == "en")
                {
                    lblKoltukNo.Text = $"Enter the information of the customer who bought seat number {sortedValues[listIndex]}";
                }

                foreach (var item in sortedValues)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle();
        }
    }
}
