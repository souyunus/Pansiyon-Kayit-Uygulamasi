using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Uygulamasi
{
    public class GelirGider
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");

        public void gelirgider(Label lblKasaTutar,Label lblUrunTutar1,Label lblUrunTutar2,Label lblUrunTutar3,Label lblFatura1, Label lblFatura2, Label lblFatura3) 
        {
            // KASADAKİ TOPLAM TUTAR
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select sum(Ucret) as toplam from musteriEkle", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                lblKasaTutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // GIDA GİDERLERİ
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                lblUrunTutar1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            // İÇECEK GİDERLERİ
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                lblUrunTutar2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            // CEREZ GİDERLERİ
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                lblUrunTutar3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            // ELEKTRİK GİDERİ
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();
            while (oku5.Read())
            {
                lblFatura1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            // SU GİDERİ
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();
            while (oku6.Read())
            {
                lblFatura2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            // İNTERNET GİDERİ
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();
            while (oku7.Read())
            {
                lblFatura3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
}

