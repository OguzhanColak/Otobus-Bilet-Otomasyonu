﻿using System;
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
    public partial class Oturum_Bilgileri : Form
    {
        public Oturum_Bilgileri()
        {
            InitializeComponent();
        }
        string vericek;
        private void Oturum_Bilgileri_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 161, 147);
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();

            if (Properties.Settings.Default.dil == "tr")
            {
                vericek = "select p.Ad, p.Soyad, PersonelIslem as [Yapılan Eylem], IslemZamanı as [İşlem Zamanı] from Personeller p inner join PersonelIslem pı on p.PersonelID = pı.PersonelID order by IslemZamanı desc";

            }
            else if (Properties.Settings.Default.dil == "en")
            {
                vericek = "select p.Ad as Name, p.Soyad as Surname, PersonelIslem as [Operation Type], IslemZamanı as [Operation Time] from Personeller p inner join PersonelIslem pı on p.PersonelID = pı.PersonelID order by IslemZamanı desc";
            }

            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 110;

        }
    }
}
