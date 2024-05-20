using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Uygulamasi
{
    public class Odalar
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G73E5139\\MSSQLSERVER01;Initial Catalog=PansiyonDb;Integrated Security=True");

        public void odalar100(Button btn101, Button btn102, Button btn103, 
                              Button btn104, Button btn105, Button btn106, 
                              Button btn107, Button btn108, Button btn109)

        {
            // ODA 101
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = cmd1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
            }

            // ODA 103
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }

            // ODA 102
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
            }

            // ODA 104
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }

            // ODA 105
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
            }

            // ODA 106
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
            }

            // ODA 107
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
            }

            // ODA 108
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = cmd8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
            }

            // ODA 109
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = cmd9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
            }
        }

        public void odalar200(Button btn201, Button btn202,Button btn203, 
                             Button btn204, Button btn205, Button btn206)

        {
            // ODA 201
            baglanti.Open();
            SqlCommand cmd01 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku01 = cmd01.ExecuteReader();

            while (oku01.Read())
            {
                btn201.Text = oku01["Adi"].ToString() + " " + oku01["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn201.Text != "201")
            {
                btn201.BackColor = Color.Red;
            }

            // ODA 202
            baglanti.Open();
            SqlCommand cmd02 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku02 = cmd02.ExecuteReader();

            while (oku02.Read())
            {
                btn202.Text = oku02["Adi"].ToString() + " " + oku02["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn202.Text != "202")
            {
                btn202.BackColor = Color.Red;
            }

            // ODA 203
            baglanti.Open();
            SqlCommand cmd03 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku03 = cmd03.ExecuteReader();

            while (oku03.Read())
            {
                btn203.Text = oku03["Adi"].ToString() + " " + oku03["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn203.Text != "203")
            {
                btn203.BackColor = Color.Red;
            }

            // ODA 204
            baglanti.Open();
            SqlCommand cmd04 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku04 = cmd04.ExecuteReader();

            while (oku04.Read())
            {
                btn204.Text = oku04["Adi"].ToString() + " " + oku04["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn204.Text != "204")
            {
                btn204.BackColor = Color.Red;
            }

            // ODA 205
            baglanti.Open();
            SqlCommand cmd05 = new SqlCommand("select * from Oda205", baglanti);
            SqlDataReader oku05 = cmd05.ExecuteReader();

            while (oku05.Read())
            {
                btn205.Text = oku05["Adi"].ToString() + " " + oku05["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn205.Text != "205")
            {
                btn205.BackColor = Color.Red;
            }

            // ODA 206
            baglanti.Open();
            SqlCommand cmd06 = new SqlCommand("select * from Oda206", baglanti);
            SqlDataReader oku06 = cmd06.ExecuteReader();

            while (oku06.Read())
            {
                btn206.Text = oku06["Adi"].ToString() + " " + oku06["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn206.Text != "206")
            {
                btn206.BackColor = Color.Red;
            }
        }
    }
}
