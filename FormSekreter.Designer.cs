namespace Hastane_Otomasyon_Projesi
{
    partial class FormSekreter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBransEkle = new System.Windows.Forms.Button();
            this.BtnMesajOl = new System.Windows.Forms.Button();
            this.BtnRandevuOl = new System.Windows.Forms.Button();
            this.BtnDrKaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDoktorList = new System.Windows.Forms.Button();
            this.BtnRandevuList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(352, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 338);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnBransEkle
            // 
            this.BtnBransEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBransEkle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBransEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBransEkle.Location = new System.Drawing.Point(190, 222);
            this.BtnBransEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBransEkle.Name = "BtnBransEkle";
            this.BtnBransEkle.Size = new System.Drawing.Size(122, 95);
            this.BtnBransEkle.TabIndex = 11;
            this.BtnBransEkle.Text = "Poliklinik İşlemleri";
            this.BtnBransEkle.UseVisualStyleBackColor = false;
            this.BtnBransEkle.Click += new System.EventHandler(this.BtnBransEkle_Click);
            // 
            // BtnMesajOl
            // 
            this.BtnMesajOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMesajOl.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesajOl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMesajOl.Location = new System.Drawing.Point(46, 222);
            this.BtnMesajOl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMesajOl.Name = "BtnMesajOl";
            this.BtnMesajOl.Size = new System.Drawing.Size(122, 95);
            this.BtnMesajOl.TabIndex = 10;
            this.BtnMesajOl.Text = "Mesaj Oluştur";
            this.BtnMesajOl.UseVisualStyleBackColor = false;
            this.BtnMesajOl.Click += new System.EventHandler(this.BtnMesajOl_Click);
            // 
            // BtnRandevuOl
            // 
            this.BtnRandevuOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRandevuOl.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevuOl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRandevuOl.Location = new System.Drawing.Point(190, 113);
            this.BtnRandevuOl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRandevuOl.Name = "BtnRandevuOl";
            this.BtnRandevuOl.Size = new System.Drawing.Size(122, 95);
            this.BtnRandevuOl.TabIndex = 9;
            this.BtnRandevuOl.Text = "Randevu İşlemleri";
            this.BtnRandevuOl.UseVisualStyleBackColor = false;
            this.BtnRandevuOl.Click += new System.EventHandler(this.BtnRandevuOl_Click);
            // 
            // BtnDrKaydet
            // 
            this.BtnDrKaydet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnDrKaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDrKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDrKaydet.Location = new System.Drawing.Point(47, 113);
            this.BtnDrKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDrKaydet.Name = "BtnDrKaydet";
            this.BtnDrKaydet.Size = new System.Drawing.Size(122, 95);
            this.BtnDrKaydet.TabIndex = 8;
            this.BtnDrKaydet.Text = "Doktor Kaydet";
            this.BtnDrKaydet.UseVisualStyleBackColor = false;
            this.BtnDrKaydet.Click += new System.EventHandler(this.BtnDrKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 50);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad Soyad";
            // 
            // BtnDoktorList
            // 
            this.BtnDoktorList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnDoktorList.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoktorList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDoktorList.Location = new System.Drawing.Point(190, 331);
            this.BtnDoktorList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDoktorList.Name = "BtnDoktorList";
            this.BtnDoktorList.Size = new System.Drawing.Size(122, 95);
            this.BtnDoktorList.TabIndex = 17;
            this.BtnDoktorList.Text = "Doktor Listele";
            this.BtnDoktorList.UseVisualStyleBackColor = false;
            this.BtnDoktorList.Click += new System.EventHandler(this.BtnDoktorList_Click);
            // 
            // BtnRandevuList
            // 
            this.BtnRandevuList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRandevuList.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevuList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRandevuList.Location = new System.Drawing.Point(46, 331);
            this.BtnRandevuList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRandevuList.Name = "BtnRandevuList";
            this.BtnRandevuList.Size = new System.Drawing.Size(122, 95);
            this.BtnRandevuList.TabIndex = 16;
            this.BtnRandevuList.Text = "Randevu Listele";
            this.BtnRandevuList.UseVisualStyleBackColor = false;
            this.BtnRandevuList.Click += new System.EventHandler(this.BtnRandevuList_Click);
            // 
            // FormSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(987, 467);
            this.Controls.Add(this.BtnDoktorList);
            this.Controls.Add(this.BtnRandevuList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBransEkle);
            this.Controls.Add(this.BtnMesajOl);
            this.Controls.Add(this.BtnRandevuOl);
            this.Controls.Add(this.BtnDrKaydet);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormSekreter";
            this.Text = "FormSekreter";
            this.Load += new System.EventHandler(this.FormSekreter_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBransEkle;
        private System.Windows.Forms.Button BtnMesajOl;
        private System.Windows.Forms.Button BtnRandevuOl;
        private System.Windows.Forms.Button BtnDrKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDoktorList;
        private System.Windows.Forms.Button BtnRandevuList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}