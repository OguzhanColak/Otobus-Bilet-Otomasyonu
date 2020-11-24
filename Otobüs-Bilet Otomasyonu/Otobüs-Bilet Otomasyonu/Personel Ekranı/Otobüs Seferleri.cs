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
    public partial class Otobüs_Seferleri : Form
    {
        public Otobüs_Seferleri()
        {
            InitializeComponent();
        }

        private void Otobüs_Seferleri_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BMGTNCU;Initial Catalog=Otobus_Bılet_Otomasyonu;Integrated Security=True");
            baglan.Open();
            
            string vericek = "select OtobusID as [Otobüs No], SeferID as [Sefer No], s1.SehirAdı , s2.SehirAdı, KalkısVakti, VarisVakti from Sehirler s1 inner join Seferler sf on s1.SehirID = sf.KalkısSehirID inner join Sehirler s2 on s2.SehirID = sf.VarisSehirID";
            SqlDataAdapter adp = new SqlDataAdapter(vericek, baglan);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
    }
}
