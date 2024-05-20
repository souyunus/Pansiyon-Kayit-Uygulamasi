using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm1 = new FrmAdminGiris();
            frm1.Show();
            this.Hide();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frm1 = new FrmYeniMusteri();
            frm1.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frm1 = new FrmOdalar();
            frm1.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm1 = new FrmMusteriler();
            frm1.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NYP Proje");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerMaas_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            frm.Show();
        }

        private void btnMusMesaj_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }
    }
}
