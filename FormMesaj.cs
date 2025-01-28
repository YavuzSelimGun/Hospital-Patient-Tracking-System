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
    public partial class FormMesaj : Form
    {
        public FormMesaj()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void CmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbAlıcı.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Table_Doktor", bgl.baglanti());
            SqlDataReader rdr = cmd.ExecuteReader();    
            while (rdr.Read())    
            {    
                CmbAlıcı.Items.Add(rdr[0] + " " + rdr[1]);    
            }    
            bgl.baglanti().Close();        
        
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Mesaj (MesajGrup,MesajAlıcı,MesajIcerik) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbKategori.Text);
            komut.Parameters.AddWithValue("@p2", CmbAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesaj iletildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FormMesaj_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneProjeDataSet3.Table_Mesaj' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_MesajTableAdapter.Fill(this.hastaneProjeDataSet3.Table_Mesaj);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbAlıcı.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsil = new SqlCommand("Delete From Table_Mesaj Where Mesajid=@p1", bgl.baglanti());
            cmdsil.Parameters.AddWithValue("@p1", lblid.Text);
            cmdsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesaj Silindi!!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_MesajTableAdapter.Fill(this.hastaneProjeDataSet3.Table_Mesaj);
        }
    }
}
