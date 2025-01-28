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
    public partial class FormMesajKutusu : Form
    {
        public FormMesajKutusu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string alici;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Mesaj Where MesajAlıcı=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.Add("@p1", alici);
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsil = new SqlCommand("Delete From Table_Mesaj Where Mesajid=@p1", bgl.baglanti());
            cmdsil.Parameters.AddWithValue("@p1", lblid.Text);
            cmdsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesaj Silindi!!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
