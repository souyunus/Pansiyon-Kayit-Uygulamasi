using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");

        private void verileriGoster()
        {
            Musteriler musteriler = new Musteriler();
            musteriler.verilerigoster(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update musteriEkle set Adi='" + txtAd.Text + "',Soyadi='" + txtSoyad.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + txtTelefon.Text + "',Mail='" + txtMail.Text + "',TC='" + txtTC.Text + "',OdaNo='" + txtOda.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" + dtpGiris.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpCikis.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOda.Text=="101")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda101", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "102")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda102", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "103")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda103", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "104")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda104", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "105")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda105", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "106")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda106", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "107")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda107", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "108")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda108", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "109")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda109", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "201")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda201", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "202")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda202", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "203")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda203", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "204")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda204", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "205")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda205", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOda.Text == "206")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda206", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            comboBox1.Text = "";
            txtTelefon.Clear();
            txtMail.Text = "";
            txtTC.Clear();
            txtOda.Clear();
            txtUcret.Clear();
            dtpGiris.Text = "";
            dtpCikis.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from musteriEkle where TC like '%" + txtAra.Text + "%'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}