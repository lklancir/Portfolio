namespace Appoteka_v2._0
{
    partial class FormZaposlenici
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
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.zaposleniciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter();
            this.btnZaposleniciNatrag = new System.Windows.Forms.Button();
            this.btnZaposleniciNovi = new System.Windows.Forms.Button();
            this.btnZaposleniciIzmijeni = new System.Windows.Forms.Button();
            this.btnZaposleniciIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.korImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaposleniciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korImeDataGridViewTextBoxColumn
            // 
            this.korImeDataGridViewTextBoxColumn.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korImeDataGridViewTextBoxColumn.Name = "korImeDataGridViewTextBoxColumn";
            this.korImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // btnZaposleniciNatrag
            // 
            this.btnZaposleniciNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciNatrag.Location = new System.Drawing.Point(22, 239);
            this.btnZaposleniciNatrag.Name = "btnZaposleniciNatrag";
            this.btnZaposleniciNatrag.Size = new System.Drawing.Size(102, 35);
            this.btnZaposleniciNatrag.TabIndex = 1;
            this.btnZaposleniciNatrag.Text = "Natrag";
            this.btnZaposleniciNatrag.UseVisualStyleBackColor = true;
            this.btnZaposleniciNatrag.Click += new System.EventHandler(this.btnZaposleniciNatrag_Click);
            // 
            // btnZaposleniciNovi
            // 
            this.btnZaposleniciNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciNovi.Location = new System.Drawing.Point(320, 224);
            this.btnZaposleniciNovi.Name = "btnZaposleniciNovi";
            this.btnZaposleniciNovi.Size = new System.Drawing.Size(102, 35);
            this.btnZaposleniciNovi.TabIndex = 2;
            this.btnZaposleniciNovi.Text = "Novi";
            this.btnZaposleniciNovi.UseVisualStyleBackColor = true;
            this.btnZaposleniciNovi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnZaposleniciIzmijeni
            // 
            this.btnZaposleniciIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciIzmijeni.Location = new System.Drawing.Point(462, 224);
            this.btnZaposleniciIzmijeni.Name = "btnZaposleniciIzmijeni";
            this.btnZaposleniciIzmijeni.Size = new System.Drawing.Size(102, 35);
            this.btnZaposleniciIzmijeni.TabIndex = 3;
            this.btnZaposleniciIzmijeni.Text = "Izmijeni";
            this.btnZaposleniciIzmijeni.UseVisualStyleBackColor = true;
            this.btnZaposleniciIzmijeni.Click += new System.EventHandler(this.btnZaposleniciIzmijeni_Click);
            // 
            // btnZaposleniciIzbrisi
            // 
            this.btnZaposleniciIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposleniciIzbrisi.Location = new System.Drawing.Point(604, 224);
            this.btnZaposleniciIzbrisi.Name = "btnZaposleniciIzbrisi";
            this.btnZaposleniciIzbrisi.Size = new System.Drawing.Size(102, 35);
            this.btnZaposleniciIzbrisi.TabIndex = 4;
            this.btnZaposleniciIzbrisi.Text = "Izbriši";
            this.btnZaposleniciIzbrisi.UseVisualStyleBackColor = true;
            this.btnZaposleniciIzbrisi.Click += new System.EventHandler(this.btnZaposleniciIzbrisi_Click);
            // 
            // FormZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 294);
            this.Controls.Add(this.btnZaposleniciIzbrisi);
            this.Controls.Add(this.btnZaposleniciIzmijeni);
            this.Controls.Add(this.btnZaposleniciNovi);
            this.Controls.Add(this.btnZaposleniciNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormZaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.FormZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.Button btnZaposleniciNatrag;
        private System.Windows.Forms.Button btnZaposleniciNovi;
        private System.Windows.Forms.Button btnZaposleniciIzmijeni;
        private System.Windows.Forms.Button btnZaposleniciIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
    }
}