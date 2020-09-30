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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-M7VSLVP\\SQLEXPRESS;Initial Catalog=personelvt;Integrated Security=True");
        void temizle()
        {
            txtperid.Text = "";
            txtperad.Text = "";
            txtpersoyad.Text = "";
            combosehir.Text = "";
            mtxtmaas.Text = "";
            permeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtperad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personelvtDataSet.personel);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personelvtDataSet.personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personel(perad,persoyad,persehir,permaas,permeslek,perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtperad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersoyad.Text);
            komut.Parameters.AddWithValue("@p3", combosehir.Text);
            komut.Parameters.AddWithValue("@p4", mtxtmaas.Text);
            komut.Parameters.AddWithValue("@p5", permeslek.Text);
            komut.Parameters.AddWithValue("@p6", label9.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label9.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label9.Text = "False";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtperid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtperad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtpersoyad.Text =dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combosehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            permeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label9.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from personel where perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtperid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update personel set perad=@a1,persoyad=@a2,persehir=@a3,permaas=@a4,perdurum=@a5,permeslek=@a6 where perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtperad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtpersoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", combosehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mtxtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label9.Text);
            komutguncelle.Parameters.AddWithValue("@a6", permeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtperid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgi güncellendi.");
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        { 
            Frmgrafik frg = new Frmgrafik();
            frg.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmrapor frmr = new frmrapor();
            frmr.Show();
        }

        
    }
}
