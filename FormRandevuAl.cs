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
    public partial class FormRandevuAl : Form
    {
        public FormRandevuAl()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormRandevuAl_Load(object sender, EventArgs e)
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
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Randevular where Brans=@p1 and Doktor=@p2", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", CmbPoliklinik.Text);
            da.SelectCommand.Parameters.AddWithValue("@p2", CmbDoktor.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            label6.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbPoliklinik.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
        }

        private void BtnRandevuSec_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Table_Randevular Set Durum=@p1,HastaTC=@p2 where Durum=0 and Randevuid=@p3", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", 1);
            cmd.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p3", label6.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Bilgilendirme", MessageBoxButtons.OK);
        }
    }
}
