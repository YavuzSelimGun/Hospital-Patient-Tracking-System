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
    public partial class FormPoliklinik : Form
    {
        public FormPoliklinik()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void FormPoliklinik_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Poliklinik (PoliklinikAd) values (@p1)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Poliklinik eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand plsil = new SqlCommand("Delete From Table_Poliklinik Where Poliklinikid=@p1", bgl.baglanti());
            plsil.Parameters.AddWithValue("@p1", Txtid.Text);
            plsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Poliklinik kaldırıldı!!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            this.table_PoliklinikTableAdapter.Fill(this.hastaneProjeDataSet1.Table_Poliklinik);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
