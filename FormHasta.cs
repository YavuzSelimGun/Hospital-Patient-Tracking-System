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

namespace Hastane_Otomasyon_Projesi
{
    public partial class FormHasta : Form
    {
        public FormHasta()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormHasta_Load(object sender, EventArgs e)
        {
            //ad soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Table_Hasta where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Kopru.tcNum);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = "Merhaba," + dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close(); 

            //randevu al
            //randevu geçmiş
            
        }

        private void BtnRandevuGecmis_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Randevular where HastaTC=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Kopru.tcNum);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            FormRandevuAl fr = new FormRandevuAl();
            fr.ShowDialog();
        }

        private void BtnProfil_Click(object sender, EventArgs e)
        {
            FormHastaProfili fr = new FormHastaProfili();
            fr.ShowDialog();
        }
    }
}
