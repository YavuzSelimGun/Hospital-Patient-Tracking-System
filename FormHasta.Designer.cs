namespace Hastane_Otomasyon_Projesi
{
    partial class FormHasta
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
            this.BtnProfil = new System.Windows.Forms.Button();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.BtnRandevuGecmis = new System.Windows.Forms.Button();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProfil
            // 
            this.BtnProfil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnProfil.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnProfil.ForeColor = System.Drawing.Color.White;
            this.BtnProfil.Location = new System.Drawing.Point(48, 153);
            this.BtnProfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProfil.Name = "BtnProfil";
            this.BtnProfil.Size = new System.Drawing.Size(264, 95);
            this.BtnProfil.TabIndex = 0;
            this.BtnProfil.Text = "Profil";
            this.BtnProfil.UseVisualStyleBackColor = false;
            this.BtnProfil.Click += new System.EventHandler(this.BtnProfil_Click);
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRandevuAl.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevuAl.ForeColor = System.Drawing.Color.White;
            this.BtnRandevuAl.Location = new System.Drawing.Point(48, 260);
            this.BtnRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(264, 95);
            this.BtnRandevuAl.TabIndex = 1;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = false;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // BtnRandevuGecmis
            // 
            this.BtnRandevuGecmis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRandevuGecmis.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevuGecmis.ForeColor = System.Drawing.Color.White;
            this.BtnRandevuGecmis.Location = new System.Drawing.Point(48, 367);
            this.BtnRandevuGecmis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRandevuGecmis.Name = "BtnRandevuGecmis";
            this.BtnRandevuGecmis.Size = new System.Drawing.Size(264, 95);
            this.BtnRandevuGecmis.TabIndex = 2;
            this.BtnRandevuGecmis.Text = "Randevu Geçmişi";
            this.BtnRandevuGecmis.UseVisualStyleBackColor = false;
            this.BtnRandevuGecmis.Click += new System.EventHandler(this.BtnRandevuGecmis_Click);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LblAdSoyad.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.LblAdSoyad.Location = new System.Drawing.Point(62, 11);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(130, 35);
            this.LblAdSoyad.TabIndex = 5;
            this.LblAdSoyad.Text = "Ad Soyad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(353, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 337);
            this.groupBox1.TabIndex = 6;
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
            this.dataGridView1.Size = new System.Drawing.Size(498, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.LblAdSoyad);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 61);
            this.panel1.TabIndex = 7;
            // 
            // FormHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(887, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRandevuGecmis);
            this.Controls.Add(this.BtnRandevuAl);
            this.Controls.Add(this.BtnProfil);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormHasta";
            this.Text = "FormHasta";
            this.Load += new System.EventHandler(this.FormHasta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProfil;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.Button BtnRandevuGecmis;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}