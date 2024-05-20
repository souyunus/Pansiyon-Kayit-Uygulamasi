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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            Odalar odalar100 = new Odalar();
            odalar100.odalar100(btn101, btn102, btn103,
                                btn104, btn105, btn106,
                               btn107, btn108, btn109);

            Odalar odalar200 = new Odalar();
            odalar200.odalar200(btn201, btn202, btn203,
                               btn204, btn205, btn206);
        }
    }
}
