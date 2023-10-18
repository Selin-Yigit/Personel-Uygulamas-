using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelUygulaması
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PLR25FM;Initial Catalog=PersonelDB;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Tbl_Giris where KullaniciAdi = @p1 and Sifre = @p2", baglanti);
            cmd1.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            cmd1.Parameters.AddWithValue("@p2", txtSifre.Text);


            SqlDataReader dr1 = cmd1.ExecuteReader();
            if(dr1.Read())
            {
                FrmAnaForm anaForm = new FrmAnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı ya da şifre hatalıdır.");
            }
            baglanti.Close();
        }
    }
}
