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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(txtPersonelSayisi.Text);
            lblPerMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaTutar.Text) - (Convert.ToInt32(lblPerMaas.Text) + Convert.ToInt32(lblUrunTutar1.Text) + Convert.ToInt32(lblUrunTutar2.Text) + Convert.ToInt32(lblUrunTutar3.Text) + Convert.ToInt32(lblFatura1.Text) + Convert.ToInt32(lblFatura2.Text) + Convert.ToInt32(lblFatura3.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.gelirgider(lblKasaTutar,lblUrunTutar1,lblUrunTutar2,lblUrunTutar3,lblFatura1,lblFatura2,lblFatura3);
        }
    }
}
