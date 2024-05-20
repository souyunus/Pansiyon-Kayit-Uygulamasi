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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOda.Text = "101";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOda.Text = "102";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOda.Text = "103";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOda.Text = "104";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOda.Text = "105";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOda.Text = "106";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOda.Text = "107";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOda.Text = "108";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOda.Text = "109";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            txtOda.Text = "201"; baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda201 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            txtOda.Text = "202";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda202 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            txtOda.Text = "203";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda203 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            txtOda.Text = "204";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda204 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            txtOda.Text = "205";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda205 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn206_Click(object sender, EventArgs e)
        {
            txtOda.Text = "206";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda206 (Adi,Soyadi) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime ktarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime btarih = Convert.ToDateTime(dtpCikis.Text);

            TimeSpan sonuc = btarih - ktarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into musteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboBox1.Text + "','" + txtTelefon.Text + "','" + txtMail.Text + "','" + txtTC.Text + "','" + txtOda.Text + "','" + txtUcret.Text + "','" + dtpGiris.Value.ToString("yyyy-MM-dd") + "','" + dtpCikis.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı.");

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            YeniMusteri odalar100 = new YeniMusteri();
            odalar100.YeniMusteri100(btn101, btn102, btn103,
                                     btn104, btn105, btn106,
                                    btn107, btn108, btn109);


            YeniMusteri odalar200 = new YeniMusteri();
            odalar200.YeniMusteri200(btn201, btn202, btn203,
                                    btn204, btn205, btn206);
        }
    }
}