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

namespace PersonelUygulaması
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PLR25FM;Initial Catalog=PersonelDB;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from Tbl_Personel",conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) 
            {
                lblSumPerSonuc.Text = dr1[0].ToString();
            }
            conn.Close();

            //Evli PErsonel
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Tbl_Personel where perDurum = 1", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPerSonuc.Text = dr2[0].ToString();
            }
            conn.Close();

            //Bekar PErsonel
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("select count(*) from Tbl_Personel where perDurum = 0", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPerSonuc.Text = dr3[0].ToString();
            }
            conn.Close();

            //Şehir Sayısı
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("select count(distinct(perSehir)) from Tbl_Personel", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayisiSonuc.Text = dr4[0].ToString();
            }
            conn.Close();

            //Toplam Maaş
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("select sum(perMaas) from Tbl_Personel ", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblSumMaasSonuc.Text = dr5[0].ToString();
            }
            conn.Close();

            //Ortalama Maaş
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("select Avg(perMaas) from Tbl_Personel", conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtMaasSonuc.Text = dr6[0].ToString();
            }
            conn.Close();
        }
    }
}
