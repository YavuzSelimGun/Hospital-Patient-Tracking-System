namespace Hastane_Otomasyon_Projesi
{
    partial class FormMesaj
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.CmbAlıcı = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mesajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajGrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajAlıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajIcerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMesajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet3 = new Hastane_Otomasyon_Projesi.HastaneProjeDataSet3();
            this.lblid = new System.Windows.Forms.Label();
            this.table_MesajTableAdapter = new Hastane_Otomasyon_Projesi.HastaneProjeDataSet3TableAdapters.Table_MesajTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMesajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSil.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(153, 484);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 36);
            this.BtnSil.TabIndex = 67;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 35);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mesaj Kutusu";
            // 
            // CmbKategori
            // 
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Items.AddRange(new object[] {
            "Doktor",
            "Hasta"});
            this.CmbKategori.Location = new System.Drawing.Point(159, 165);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(195, 36);
            this.CmbKategori.TabIndex = 60;
            this.CmbKategori.SelectedIndexChanged += new System.EventHandler(this.CmbKategori_SelectedIndexChanged);
            // 
            // CmbAlıcı
            // 
            this.CmbAlıcı.FormattingEnabled = true;
            this.CmbAlıcı.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbAlıcı.Location = new System.Drawing.Point(159, 213);
            this.CmbAlıcı.Name = "CmbAlıcı";
            this.CmbAlıcı.Size = new System.Drawing.Size(195, 36);
            this.CmbAlıcı.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(77, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Alıcı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Kategori:";
            // 
            // BtnGonder
            // 
            this.BtnGonder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGonder.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGonder.ForeColor = System.Drawing.Color.White;
            this.BtnGonder.Location = new System.Drawing.Point(41, 484);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(105, 36);
            this.BtnGonder.TabIndex = 62;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = false;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 64);
            this.panel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(41, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 173);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj Metni";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(395, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 422);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderilen Mesajlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesajidDataGridViewTextBoxColumn,
            this.mesajGrupDataGridViewTextBoxColumn,
            this.mesajAlıcıDataGridViewTextBoxColumn,
            this.mesajIcerikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableMesajBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mesajidDataGridViewTextBoxColumn
            // 
            this.mesajidDataGridViewTextBoxColumn.DataPropertyName = "Mesajid";
            this.mesajidDataGridViewTextBoxColumn.HeaderText = "Mesajid";
            this.mesajidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajidDataGridViewTextBoxColumn.Name = "mesajidDataGridViewTextBoxColumn";
            this.mesajidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesajidDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajGrupDataGridViewTextBoxColumn
            // 
            this.mesajGrupDataGridViewTextBoxColumn.DataPropertyName = "MesajGrup";
            this.mesajGrupDataGridViewTextBoxColumn.HeaderText = "MesajGrup";
            this.mesajGrupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajGrupDataGridViewTextBoxColumn.Name = "mesajGrupDataGridViewTextBoxColumn";
            this.mesajGrupDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajAlıcıDataGridViewTextBoxColumn
            // 
            this.mesajAlıcıDataGridViewTextBoxColumn.DataPropertyName = "MesajAlıcı";
            this.mesajAlıcıDataGridViewTextBoxColumn.HeaderText = "MesajAlıcı";
            this.mesajAlıcıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajAlıcıDataGridViewTextBoxColumn.Name = "mesajAlıcıDataGridViewTextBoxColumn";
            this.mesajAlıcıDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajIcerikDataGridViewTextBoxColumn
            // 
            this.mesajIcerikDataGridViewTextBoxColumn.DataPropertyName = "MesajIcerik";
            this.mesajIcerikDataGridViewTextBoxColumn.HeaderText = "MesajIcerik";
            this.mesajIcerikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajIcerikDataGridViewTextBoxColumn.Name = "mesajIcerikDataGridViewTextBoxColumn";
            this.mesajIcerikDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableMesajBindingSource
            // 
            this.tableMesajBindingSource.DataMember = "Table_Mesaj";
            this.tableMesajBindingSource.DataSource = this.hastaneProjeDataSet3;
            // 
            // hastaneProjeDataSet3
            // 
            this.hastaneProjeDataSet3.DataSetName = "HastaneProjeDataSet3";
            this.hastaneProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(106, 122);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 28);
            this.lblid.TabIndex = 70;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // table_MesajTableAdapter
            // 
            this.table_MesajTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(265, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 71;
            this.button1.Text = "Liste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.CmbAlıcı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormMesaj";
            this.Text = "FormMesaj";
            this.Load += new System.EventHandler(this.FormMesaj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMesajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.ComboBox CmbAlıcı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblid;
        private HastaneProjeDataSet3 hastaneProjeDataSet3;
        private System.Windows.Forms.BindingSource tableMesajBindingSource;
        private HastaneProjeDataSet3TableAdapters.Table_MesajTableAdapter table_MesajTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajGrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajAlıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajIcerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}