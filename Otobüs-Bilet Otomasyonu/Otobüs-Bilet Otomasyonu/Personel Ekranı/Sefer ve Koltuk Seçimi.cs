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
        public void koltuk_alınmıs_mı(int seferID) //Panel tipinde bir parametre alacak
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan1.Open();
            // SqlCommand komut = new SqlCommand($"Select KoltukNo from Biletler where SeferID = {Convert.ToInt32(seferID)}", baglan1);
            SqlCommand komut = new SqlCommand($"select b.KoltukNo, o.KoltukDuzeni from Seferler s Full Outer Join Otobüsler o on s.OtobusID=o.OtobusID Full Outer Join Biletler b on s.SeferID = b.SeferID where s.SeferID ={seferID}", baglan1);

            SqlDataReader oku = komut.ExecuteReader();
            MessageBox.Show($"Gönderilen seferıd {seferID}");
            // aşağı ulaşıyor musun ki null olduğu için veriyor hatayı
            
            if (acılacakPanelTıpı == null)
            {
                MessageBox.Show("nullu kısma girdii");
                while (oku.Read())
                {
                    MessageBox.Show("WHİLE içinede girdi");
                    string koltukDuzenı = oku.GetString(1);
                    if (koltukDuzenı == "2+1")
                    {
                        MessageBox.Show("koltukDuzenı == 2 + 1 kısmına girdi");
                        acılacakPanelTıpı = panel2_1;
                        break;
                    }
                    else
                    {
                        acılacakPanelTıpı = panel2_2;
                        break;
                    }
                }
            }
            MessageBox.Show(acılacakPanelTıpı.Name);
            foreach (Control contr in acılacakPanelTıpı.Controls)//
            {
                
                if (contr is Button)
                {
                    contr.BackColor = SystemColors.ControlLight;
                    contr.Enabled = true;
                    if (contr.Text == "Ara Çıkış") { contr.Enabled = false; }
                }
            }

            if (oku.HasRows || oku.GetInt32(0).ToString() != "NULL")
            {
                //MessageBox.Show("hasrowslu satıra girebildi");
                //MessageBox.Show(acılacakPanelTıpı.Name.ToString());
                
                while (oku.Read()) // BURASI CHECK EDİLECEK........................................
                {
                    string a = oku.GetInt32(0).ToString();
                    //MessageBox.Show($"{a}");
                    foreach (Control contr in acılacakPanelTıpı.Controls)
                    {
                        //MessageBox.Show(contr.Text);
                        if (contr is Button)
                        {
                            //MessageBox.Show($"if'in içine gelen koltuk no: {a}");
                            //MessageBox.Show($"{a}=={contr.Text}: {a == contr.Text}");
                            if (contr.Text == a)
                            {
                                //MessageBox.Show("butonların kırmızı yapıldığı kısma girildi.");
                                contr.BackColor = Color.Red;
                                contr.Enabled = false;
                            }
                        }
                    }
                }
            }
            baglan1.Close();
        }

        public void seferlerigoster()
        {
            try
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

                        //koltuk_alınmıs_mı();
                    }
                }
                baglan.Close();
            }
            finally
            {
                baglan.Close();
            }
        }
        //panel2'nin butonlarınada btn click eventi eklenecek
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
            //panel1.Visible = true;
            //seferlerigoster();
            panel2_1.Visible = false;
            panel2.Visible = true;
            SeferleriDinamikGoster();
        }

        //dinamik buton oluşturma
        List<string> SeferSayısı = new List<string>();
        List<int> SeferID = new List<int>();
        List<string> KoltukDuzenı = new List<string>();


        int count = 1;

        int y = 1;

        public void SeferleriDinamikGoster()
        {

            panelTemizle();
            string KalkısSehir = comboBox1.Text.ToString().Trim();
            string VarisSehir = comboBox2.Text.ToString().Trim();
            string KalkısVakti = dateTimePicker1.Value.ToShortDateString(); // Gün-Ay-Yıl


            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand komut = new SqlCommand("select KalkısVakti, s1.SehirAdı,s2.SehirAdı, BosKoltuk, KoltukDuzeni, SeferID, KalkısSehirID from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID  inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID inner join Otobüsler o on o.OtobusID = sf.OtobusID", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            int aramayaGoreCıkanSeferSayısı = 0;
            //önce listede bir eleman varsa onlar temizlenecek
            SeferID.Clear();
            SeferSayısı.Clear();
            KoltukDuzenı.Clear();
            int x = 0;
            while (oku.Read())
            {
                string DBKalkısVaktıGun = oku.GetValue(0).ToString().Split()[0]; // Gün-Ay-Yıl
                string DBKalkısVaktıSaat = oku.GetValue(0).ToString().Split()[1];// Saat-Dakika
                string DBKalkısSehir = oku.GetValue(1).ToString().Trim();
                string DBVarisSehir = oku.GetValue(2).ToString().Trim();

                kalkıssehirıd = oku.GetInt32(6);

                /*seferID'ler bir list'e toplanacak
                 * hatta SeferSayısı list'esinede konulabilir. 
                 * btn click eventine seferıd'ye göre koltuk düzeni gelir.
                 */
                if (KalkısSehir == DBKalkısSehir && VarisSehir == DBVarisSehir && KalkısVakti == DBKalkısVaktıGun)
                {
                    KoltukDuzenı.Add(oku.GetString(4));
                    seferID = oku.GetInt32(5);
                    SeferID.Add(seferID);
                    kalankoltuksayısı = Convert.ToInt32(oku.GetValue(3));

                    MessageBox.Show("dinamik Sorgu Çalışıyor! ", "Bilgilendirme Penceresi");
                    //MessageBox.Show($"İçeri giren seferID: {seferID.ToString()}", "SeferID");
                    btnSeferıSec.Text = $"{KalkısVakti}     {comboBox1.SelectedItem}     {comboBox2.SelectedItem}     {DBKalkısVaktıSaat}      {kalankoltuksayısı}";
                    //eğer içeri girerse paneller oluşturulacak.
                    aramayaGoreCıkanSeferSayısı++;


                    //Her sefer button'unda 5 eleman tutulacak
                    SeferSayısı.Add(KalkısVakti);
                    SeferSayısı.Add(comboBox1.SelectedItem.ToString());
                    SeferSayısı.Add(comboBox2.SelectedItem.ToString());
                    SeferSayısı.Add(DBKalkısVaktıSaat);
                    SeferSayısı.Add(kalankoltuksayısı.ToString());

                    //koltuk_alınmıs_mı();
                }
            }
            baglan.Close();
            foreach (var item in SeferSayısı)
            {
                listBox1.Items.Add(item);
            }

            int j = 0;
            for (int i = 0; i < aramayaGoreCıkanSeferSayısı; i++)
            {
                MessageBox.Show(aramayaGoreCıkanSeferSayısı.ToString());
                Button btn = new Button();
                btn.Text = $"{SeferSayısı[j]}  {SeferSayısı[j + 1]}  {SeferSayısı[j + 2]}  {SeferSayısı[j + 3]}  {SeferSayısı[j + 4]}";
                j = 5;
                btn.Name = $"{SeferID[i]}";
                btn.Size = new Size(100, 60);
                btn.Location = new Point(x, 0);
                btn.Click += Btn_Click;
                x = x + 110;
                count++;
                panel2.Controls.Add(btn);
            }
        }
        private void panelTemizle()
        {
            panel2.Controls.Clear();
        }

        int secılenSeferIDSırası;
        Control acılacakPanelTıpı;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            secılenSeferIDSırası = SeferID.IndexOf(Convert.ToInt32(btn.Name));

            if (KoltukDuzenı[secılenSeferIDSırası] == "2+1")
            {
                panel2_2.Visible = false;
                panel2_1.Visible = true;

                panel2_2.Location = new Point(65, 561);
                panel2_1.Location = new Point(65, 173);
                MessageBox.Show(KoltukDuzenı[secılenSeferIDSırası]);
                MessageBox.Show("if girdi");
            }
            else
            {
                panel2_1.Visible = false;
                panel2_2.Visible = true;

                panel2_2.Location = new Point(65, 173);
                panel2_1.Location = new Point(65, 561);
                MessageBox.Show("else girdi");
                MessageBox.Show(KoltukDuzenı[secılenSeferIDSırası]);
            }

            MessageBox.Show(secılenSeferIDSırası.ToString());
            if (KoltukDuzenı[secılenSeferIDSırası] == "2+1")
            {
                acılacakPanelTıpı = panel2_1;
            }
            else
            {
                MessageBox.Show(panel2_2.GetType().ToString());
                acılacakPanelTıpı = panel2_2;
            }

            koltuk_alınmıs_mı(Convert.ToInt32(btn.Name));
            MessageBox.Show(btn.Name);
        }

        //Tıklanan koltukların gönderildiği yer
        private void button40_Click(object sender, EventArgs e)

        {
            List<int> CıftA = new List<int>() { 3, 8, 13, 18, 22, 27, 32 };
            List<int> CıftB = new List<int>() { 2, 7, 12, 17, 21, 26, 31 };

            List<int> CıftC = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54 };
            List<int> CıftD = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, };

            koltuk.Clear();
            
            
            //MessageBox.Show($"Şuanda seçilen panel tipi: { acılacakPanelTıpı}");
            foreach (Control contr in acılacakPanelTıpı.Controls) 
            {
                //MessageBox.Show($"Şuanda seçilen panel tipi: {acılacakPanelTıpı.Name} 2 + 1 == acılacakPanelTıpı.Name: {"2 +1" == acılacakPanelTıpı.Name}");
                if (contr is Button)
                {
                    if (contr.BackColor == Color.Green) { koltuk.Add(contr.Text); }
                    //MessageBox.Show(koltuk.Count.ToString());



                    if ("panel2_1" == acılacakPanelTıpı.Name)
                    {
                        //MessageBox.Show("ıfffffffffffe");
                        if (contr.BackColor == Color.Green && (CıftA.Contains(int.Parse(contr.Text)) || CıftB.Contains(int.Parse(contr.Text))))
                        {
                            if (baglan.State == ConnectionState.Closed)
                            {
                                baglan.Open();
                            }
                            SqlCommand komut = new SqlCommand("Select KoltukNo from Biletler", baglan);
                            SqlDataReader oku = komut.ExecuteReader();
                            while (oku.Read())
                            {
                                //MessageBox.Show(contr.Text);
                                if (CıftA.Contains(int.Parse(contr.Text)))
                                {
                                    if (oku.GetInt32(0) == int.Parse(contr.Text) - 1)
                                    {
                                        //contr.Text numaralı koltuğu alan müşterinin soyadı 
                                        //oku.GetInt32(0) numaralı koltuğun sahibiyle uyuşuyorsa
                                        //koltuğu alabilecek.
                                        //uyuşmazsa uyarı çıkacak.
                                        CıftA.RemoveAll(r => r != int.Parse(contr.Text));
                                    }
                                }
                                else if (CıftB.Contains(int.Parse(contr.Text)))
                                {
                                    if (oku.GetInt32(0) == int.Parse(contr.Text) + 1)
                                    {
                                        //contr.Text numaralı koltuğu alan müşterinin soyadı 
                                        //oku.GetInt32(0) numaralı koltuğun sahibiyle uyuşuyorsa
                                        //koltuğu alabilecek.
                                        //uyuşmazsa uyarı çıkacak.
                                        CıftB.RemoveAll(r => r != int.Parse(contr.Text));
                                    }
                                }
                            }
                            oku.Close();
                        }
                    }
                    else
                    {
                        //MessageBox.Show("ELSEEEEEEEEEEEE");
                        /*
                         * 2+1 panel olmasına rağmen
                         */
                        
                        //2+2 paneli
                        if (contr.BackColor == Color.Green && (CıftC.Contains(int.Parse(contr.Text)) || CıftD.Contains(int.Parse(contr.Text))))
                        {
                            if (baglan.State == ConnectionState.Closed)
                            {
                                baglan.Open();
                            }
                            SqlCommand komut = new SqlCommand("Select KoltukNo from Biletler", baglan);
                            SqlDataReader oku = komut.ExecuteReader();

                            while (oku.Read())
                            {
                                //MessageBox.Show(contr.Text);
                                if (CıftC.Contains(int.Parse(contr.Text)))
                                {
                                    if (oku.GetInt32(0) == int.Parse(contr.Text) - 1)
                                    {
                                        CıftC.RemoveAll(r => r != int.Parse(contr.Text));
                                    }
                                }
                                else
                                {
                                    if (oku.GetInt32(0) == int.Parse(contr.Text) + 1)
                                    {
                                        CıftD.RemoveAll(r => r != int.Parse(contr.Text));
                                    }
                                }
                            }
                            oku.Close();
                        }

                    }
                }
            }

            if (koltuk.Count != 1)
            {
                
                if (koltuk.Count > 1)
                {
                    MessageBox.Show("Tek seferde sadece bir koltuğa bilet alabilirsiniz!");
                    foreach (Control c in acılacakPanelTıpı.Controls)//
                    {
                        if (c is Button && c.BackColor == Color.Green)
                        {
                            c.BackColor = SystemColors.ControlLight;
                        }
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Lütfen bir koltuk seçiniz!");
                    return;
                }
            }

            Ödeme_Bilgileri f1 = new Ödeme_Bilgileri(koltuk, CıftA, CıftB,CıftC,CıftD);
            f1.Show();
        }

        private void Sefer_ve_Koltuk_Seçimi_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);
            panel2.Visible = false;
            panel2_1.Visible = false;
            panel2_2.Visible = false;
            //panel2.Height = btnSeferıSec.Height;

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

    }
}
