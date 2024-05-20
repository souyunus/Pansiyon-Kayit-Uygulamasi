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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku= cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text =oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void faturalar()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('" + txtGida.Text + "','" + txtİcecek.Text + "','" + txtAtistirmalik.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            faturalar();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAtistirmalik.Clear();
            txtGida.Clear();
            txtİcecek.Clear();
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            txtElektrik.Clear();
            txtSu.Clear();
            txtİnternet.Clear();
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtİnternet.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            faturalar();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('" + txtGida.Text + "','" + txtİcecek.Text + "','" + txtAtistirmalik.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }
    }
}
