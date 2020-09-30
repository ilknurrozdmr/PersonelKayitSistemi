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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M7VSLVP\\SQLEXPRESS;Initial Catalog=personelvt;Integrated Security=True");
        
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbltplmprsnl.Text = dr1[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from personel where perdurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                evlips.Text= dr2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from personel where perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                bekarps.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(persehir)) from personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                sehirsayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                tplmmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
