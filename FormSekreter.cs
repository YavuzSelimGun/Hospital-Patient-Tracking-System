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
using System.Reflection.Emit;

namespace Hastane_Otomasyon_Projesi
{
    public partial class FormSekreter : Form
    {
        public FormSekreter()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();  

        private void FormSekreter_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select SekreterAd,SekreterSoyad from Table_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Kopru.tcNum);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = "Merhaba, " + dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void BtnRandevuOl_Click(object sender, EventArgs e)
        {
            FormRandevu fr = new FormRandevu();
            fr.ShowDialog();
        }

        private void BtnDrKaydet_Click(object sender, EventArgs e)
        {
            FormDoktorKayit fr = new FormDoktorKayit();  
            fr.ShowDialog();
        }

        private void BtnDoktorList_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select (DoktorAd + DoktorSoyad) as 'Doktorlar', DoktorBrans as 'Branşlar' From Table_Doktor",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnRandevuList_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            FormPoliklinik fr = new FormPoliklinik();
            fr.ShowDialog();
        }

        private void BtnMesajOl_Click(object sender, EventArgs e)
        {
            FormMesaj fr = new FormMesaj();
            fr.ShowDialog();
        }
    }
}
