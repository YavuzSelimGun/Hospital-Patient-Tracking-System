﻿using System;
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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
         
        sqlbaglantisi bgl=new sqlbaglantisi(); 

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Table_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kopru.tcNum=MskTC.Text;
                FormSekreter fr = new FormSekreter();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
