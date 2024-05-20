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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('" + txtAdSoyad.Text + "','" + richTextBox1.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close() ;
            Mesajlar mesajlar = new Mesajlar();
            mesajlar.verileriGoster(listView1);
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            Mesajlar mesajlar = new Mesajlar();
            mesajlar.verileriGoster(listView1);
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdSoyad .Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
