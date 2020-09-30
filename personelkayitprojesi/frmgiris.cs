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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M7VSLVP\\SQLEXPRESS;Initial Catalog=personelvt;Integrated Security=True");
        
        private void frmgiris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblyonetici where kullaniciad=@1 and sifre=@2", baglanti);
            komut.Parameters.AddWithValue("@1", txtk.Text);
            komut.Parameters.AddWithValue("@2", txtsfre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi!");
            }
            baglanti.Close();
        }
    }
}
