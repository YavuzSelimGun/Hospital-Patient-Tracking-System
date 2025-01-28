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
    public partial class FormHastaProfili : Form
    {
        public FormHastaProfili()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void BtnGuncelleme_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Table_Hasta Set HastaSifre=@p1,HastaAd=@p2,HastaSoyad=@p3,HastaCinsiyet=@p4,HastaDogumTarihi=@p5,HastaTelefon=@p6,HastaEmail=@p7 where HastaTC=@p8", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", TxtSifre.Text);
            cmd2.Parameters.AddWithValue("@p2", TxtAd.Text);
            cmd2.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            cmd2.Parameters.AddWithValue("@p4", CmbCinsiyet.Text);
            cmd2.Parameters.AddWithValue("@p5", MskDogum.Text);
            cmd2.Parameters.AddWithValue("@p6", MskTelefon.Text);
            cmd2.Parameters.AddWithValue("@p7", TxtEmail.Text);
            cmd2.Parameters.AddWithValue("@p8", MskTCno.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FormHastaProfili_Load(object sender, EventArgs e)
        {
            MskTCno.Text = Kopru.tcNum;
            SqlCommand cmd = new SqlCommand("Select * From Table_Hasta Where HastaTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",MskTCno.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtSifre.Text = reader[2].ToString();
                TxtAd.Text = reader[3].ToString();
                TxtSoyad.Text = reader[4].ToString();
                CmbCinsiyet.Text = reader[5].ToString();
                MskDogum.Text = reader[6].ToString();
                MskTelefon.Text = reader[7].ToString(); 
                TxtEmail.Text = reader[8].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
