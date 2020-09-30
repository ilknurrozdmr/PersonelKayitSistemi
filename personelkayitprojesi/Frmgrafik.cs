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

namespace personelkayitprojesi
{
    public partial class Frmgrafik : Form
    {
        public Frmgrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M7VSLVP\\SQLEXPRESS;Initial Catalog=personelvt;Integrated Security=True");
        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Frmgrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select persehir,count(*) from personel group by persehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select permeslek,avg(permaas) from personel group by permeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
