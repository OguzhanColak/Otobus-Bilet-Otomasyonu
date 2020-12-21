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

        private void Personel_Bilgileri_Load(object sender, EventArgs e)
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
    }
}
