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
    public partial class FormDoktorKayit : Form
    {
        public FormDoktorKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Doktor (DoktorTC,DoktorSifre,DoktorAd,DoktorSoyad,DoktorBrans,DoktorCinsiyet,DoktorDogumTarihi,DoktorTelefon,DoktorEmail) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            cmd.Parameters.AddWithValue("@p3", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p4", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p5", CmbBrans.Text);
            cmd.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p7", MskDogum.Text);
            cmd.Parameters.AddWithValue("@p8", MskTelefon.Text);
            cmd.Parameters.AddWithValue("@p9", TxtEmail.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Doktor sisteme kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsil = new SqlCommand("Delete From Table_Doktor Where DoktorTC=@p1", bgl.baglanti());
            cmdsil.Parameters.AddWithValue("@p1", MskTC.Text);
            cmdsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Sistemden Silindi!!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormDoktorKayit_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select PoliklinikAd From Table_Poliklinik", bgl.baglanti());
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            MskDogum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_DoktorTableAdapter.Fill(this.hastaneProjeDataSet2.Table_Doktor);
        }
    }
}
