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


namespace Hastane_Otomasyon_Projesi
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tam;

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Table_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Kopru.tcNum);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = "Merhaba, " + dr[0] + " " + dr[1];
                Kopru.ad = (string)dr[0];
                Kopru.soyad = (string)dr[1];
                tam = Kopru.ad + " " + Kopru.soyad;
            }
            bgl.baglanti().Close();
        }

        private void BtnProfil_Click(object sender, EventArgs e)
        {
            FormDoktorProfil fr = new FormDoktorProfil();
            fr.ShowDialog();
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular Where Doktor=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.Add("@p1", tam);
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FormMesajKutusu fr = new FormMesajKutusu();
            fr.alici = tam;
            fr.ShowDialog();
        }
    }
}
