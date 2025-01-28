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
    public partial class FormRandevu : Form
    {
        public FormRandevu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();  

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Randevular (Tarih,Saat,Brans,Doktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTarih.Text);
            cmd.Parameters.AddWithValue("@p2", MskSaat.Text);
            cmd.Parameters.AddWithValue("@p3", CmbPoliklinik.Text);
            cmd.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Randevu oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK);
        }

        private void FormRandevu_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select PoliklinikAd From Table_Poliklinik", bgl.baglanti());
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                CmbPoliklinik.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Table_Doktor Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbPoliklinik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.table_RandevularTableAdapter.Fill(this.hastaneProjeDataSet.Table_Randevular);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbPoliklinik.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsil = new SqlCommand("Delete From Table_Randevular Where Randevuid=@p1", bgl.baglanti());
            cmdsil.Parameters.AddWithValue("@p1", Txtid.Text);
            cmdsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Silindi!!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Table_Randevular Set Tarih=@p1,Saat=@p2,Brans=@p3,Doktor=@p4 where Randevuid=@p5", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", MskTarih.Text);
            cmd3.Parameters.AddWithValue("@p2", MskSaat.Text);
            cmd3.Parameters.AddWithValue("@p3", CmbPoliklinik.Text);
            cmd3.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            cmd3.Parameters.AddWithValue("@p5", Txtid.Text);
            cmd3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Bilgilendirme", MessageBoxButtons.OK);
        }
    }
}
