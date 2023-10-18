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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PLR25FM;Initial Catalog=PersonelDB;Integrated Security=True");

        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mtxtMaas.Text = "";
            txtMeslek.Text = "";
            rdbtnBekar.Checked = false;
            rdbtnEvli.Checked = false;

            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDBDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("insert into Tbl_Personel (perAd, perSoyad, perSehir, perMaas, perMeslek, perDurum) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbSehir.Text);
            cmd.Parameters.AddWithValue("@p4", mtxtMaas.Text);
            cmd.Parameters.AddWithValue("@p5", txtMeslek.Text);
            cmd.Parameters.AddWithValue("@p6", lblMedeniDurum.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi!!");
        }

        private void rdbtnBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnBekar.Checked == true)
            {
                lblMedeniDurum.Text = "False";
            }
        }

        private void rdbtnEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEvli.Checked == true)
            {
                lblMedeniDurum.Text = "True";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdDelete = new SqlCommand("delete from Tbl_Personel where perID = @s1",baglanti);
            cmdDelete.Parameters.AddWithValue("@s1",txtID.Text);
            cmdDelete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!!");
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblMedeniDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void lblMedeniDurum_TextChanged(object sender, EventArgs e)
        {
            if (lblMedeniDurum.Text == "True")
            {
                rdbtnEvli.Checked = true;
                rdbtnBekar.Checked = false;
            }
            if (lblMedeniDurum.Text == "False")
            {
                rdbtnBekar.Checked = true;
                rdbtnEvli.Checked = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdUpdate = new SqlCommand("update Tbl_Personel set perAd = @u1, perSoyad = @u2, perSehir = @u3, perMaas = @u4, perDurum = @u5, perMeslek = @u6 where perId = @u7", baglanti);
            cmdUpdate.Parameters.AddWithValue("@u1", txtAd.Text);
            cmdUpdate.Parameters.AddWithValue("@u2", txtSoyad.Text);
            cmdUpdate.Parameters.AddWithValue("@u3", cmbSehir.Text);
            cmdUpdate.Parameters.AddWithValue("@u4", mtxtMaas.Text);
            cmdUpdate.Parameters.AddWithValue("@u5", lblMedeniDurum.Text);
            cmdUpdate.Parameters.AddWithValue("@u6", txtMeslek.Text);
            cmdUpdate.Parameters.AddWithValue("@u7", txtID.Text);
            cmdUpdate.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi!!");
            Temizle();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistik = new FrmIstatistik();
            istatistik.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafik gr = new FrmGrafik();
            gr.Show();
        }
    }
}
