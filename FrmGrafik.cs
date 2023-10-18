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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PLR25FM;Initial Catalog=PersonelDB;Integrated Security=True");

        private void GrfSehir_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select perSehir,count(*) from Tbl_Personel group by perSehir", conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                GrfSehir.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            conn.Close();

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select perMeslek,sum(perMaas) from Tbl_Personel group by perMeslek", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                grfMeslekMaas.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            conn.Close();
        }
    }
}
