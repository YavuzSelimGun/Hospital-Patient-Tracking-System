namespace Hastane_Otomasyon_Projesi
{
    partial class FormPoliklinik
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.hastaneProjeDataSet1 = new Hastane_Otomasyon_Projesi.HastaneProjeDataSet1();
            this.tablePoliklinikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_PoliklinikTableAdapter = new Hastane_Otomasyon_Projesi.HastaneProjeDataSet1TableAdapters.Table_PoliklinikTableAdapter();
            this.poliklinikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinikAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoliklinikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poliklinikidDataGridViewTextBoxColumn,
            this.poliklinikAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePoliklinikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(423, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 218);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(291, 217);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(94, 49);
            this.BtnSil.TabIndex = 73;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnEkle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Location = new System.Drawing.Point(190, 217);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(94, 49);
            this.BtnEkle.TabIndex = 69;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // Txtid
            // 
            this.Txtid.BackColor = System.Drawing.SystemColors.Window;
            this.Txtid.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Location = new System.Drawing.Point(190, 111);
            this.Txtid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(195, 36);
            this.Txtid.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 62;
            this.label7.Text = "id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 61;
            this.label6.Text = "Poliklinik Adı:";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(190, 159);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(195, 36);
            this.TxtAd.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 56);
            this.panel1.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(157, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 35);
            this.label9.TabIndex = 25;
            this.label9.Text = "Poliklinik İşlemleri";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(190, 281);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(194, 48);
            this.BtnGuncelle.TabIndex = 75;
            this.BtnGuncelle.Text = "Listele";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // hastaneProjeDataSet1
            // 
            this.hastaneProjeDataSet1.DataSetName = "HastaneProjeDataSet1";
            this.hastaneProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePoliklinikBindingSource
            // 
            this.tablePoliklinikBindingSource.DataMember = "Table_Poliklinik";
            this.tablePoliklinikBindingSource.DataSource = this.hastaneProjeDataSet1;
            // 
            // table_PoliklinikTableAdapter
            // 
            this.table_PoliklinikTableAdapter.ClearBeforeFill = true;
            // 
            // poliklinikidDataGridViewTextBoxColumn
            // 
            this.poliklinikidDataGridViewTextBoxColumn.DataPropertyName = "Poliklinikid";
            this.poliklinikidDataGridViewTextBoxColumn.HeaderText = "Poliklinikid";
            this.poliklinikidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poliklinikidDataGridViewTextBoxColumn.Name = "poliklinikidDataGridViewTextBoxColumn";
            this.poliklinikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.poliklinikidDataGridViewTextBoxColumn.Width = 125;
            // 
            // poliklinikAdDataGridViewTextBoxColumn
            // 
            this.poliklinikAdDataGridViewTextBoxColumn.DataPropertyName = "PoliklinikAd";
            this.poliklinikAdDataGridViewTextBoxColumn.HeaderText = "PoliklinikAd";
            this.poliklinikAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poliklinikAdDataGridViewTextBoxColumn.Name = "poliklinikAdDataGridViewTextBoxColumn";
            this.poliklinikAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 357);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPoliklinik";
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.FormPoliklinik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoliklinikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGuncelle;
        private HastaneProjeDataSet1 hastaneProjeDataSet1;
        private System.Windows.Forms.BindingSource tablePoliklinikBindingSource;
        private HastaneProjeDataSet1TableAdapters.Table_PoliklinikTableAdapter table_PoliklinikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinikAdDataGridViewTextBoxColumn;
    }
}