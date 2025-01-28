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
    public partial class FormDoktorProfil : Form
    {
        public FormDoktorProfil()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void FormDoktorProfil_Load(object sender, EventArgs e)
        {
            MskTC.Text = Kopru.tcNum;

            SqlCommand cmd2 = new SqlCommand("Select PoliklinikAd From Table_Poliklinik", bgl.baglanti());
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            SqlCommand cmd = new SqlCommand("Select * From Table_Doktor Where DoktorTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtSifre.Text = reader[2].ToString();
                TxtAd.Text = reader[3].ToString();
                TxtSoyad.Text = reader[4].ToString();
                CmbBrans.Text = reader[5].ToString();
                CmbCinsiyet.Text = reader[6].ToString();
                MskDogum.Text = reader[7].ToString();
                MskTelefon.Text = reader[8].ToString();
                TxtEmail.Text = reader[9].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelleme_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Table_Doktor Set DoktorSifre=@p1,DoktorAd=@p2,DoktorSoyad=@p3,DoktorBrans=@p4,DoktorCinsiyet=@p5,DoktorDogumTarihi=@p6,DoktorTelefon=@p7,DoktorEmail=@p8 where DoktorTC=@p9", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", TxtSifre.Text);
            cmd3.Parameters.AddWithValue("@p2", TxtAd.Text);
            cmd3.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            cmd3.Parameters.AddWithValue("@p4", CmbBrans.Text);
            cmd3.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            cmd3.Parameters.AddWithValue("@p6", MskDogum.Text);
            cmd3.Parameters.AddWithValue("@p7", MskTelefon.Text);
            cmd3.Parameters.AddWithValue("@p8", TxtEmail.Text);
            cmd3.Parameters.AddWithValue("@p9", MskTC.Text);
            cmd3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
