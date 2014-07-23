namespace Appoteka_v2._0
{
    partial class FormNarudzbe
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
            this.idNarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.narudzbeTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.narudzbeTableAdapter();
            this.btnNarudzbeNatrag = new System.Windows.Forms.Button();
            this.btnNarudzbeNovi = new System.Windows.Forms.Button();
            this.btnNarudzbeIzmijeni = new System.Windows.Forms.Button();
            this.btnNarudzbeIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).BeginInit();
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
            this.idNarudzbeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.idDobavljacDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // idNarudzbeDataGridViewTextBoxColumn
            // 
            this.idNarudzbeDataGridViewTextBoxColumn.DataPropertyName = "IdNarudzbe";
            this.idNarudzbeDataGridViewTextBoxColumn.HeaderText = "ID narudžbe";
            this.idNarudzbeDataGridViewTextBoxColumn.Name = "idNarudzbeDataGridViewTextBoxColumn";
            this.idNarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDobavljacDataGridViewTextBoxColumn
            // 
            this.idDobavljacDataGridViewTextBoxColumn.DataPropertyName = "IdDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.HeaderText = "ID dobavljač";
            this.idDobavljacDataGridViewTextBoxColumn.Name = "idDobavljacDataGridViewTextBoxColumn";
            this.idDobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbeBindingSource
            // 
            this.narudzbeBindingSource.DataMember = "narudzbe";
            this.narudzbeBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeTableAdapter
            // 
            this.narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // btnNarudzbeNatrag
            // 
            this.btnNarudzbeNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeNatrag.Location = new System.Drawing.Point(21, 218);
            this.btnNarudzbeNatrag.Name = "btnNarudzbeNatrag";
            this.btnNarudzbeNatrag.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeNatrag.TabIndex = 1;
            this.btnNarudzbeNatrag.Text = "Natrag";
            this.btnNarudzbeNatrag.UseVisualStyleBackColor = true;
            this.btnNarudzbeNatrag.Click += new System.EventHandler(this.btnNarudzbeNatrag_Click);
            // 
            // btnNarudzbeNovi
            // 
            this.btnNarudzbeNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeNovi.Location = new System.Drawing.Point(275, 218);
            this.btnNarudzbeNovi.Name = "btnNarudzbeNovi";
            this.btnNarudzbeNovi.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeNovi.TabIndex = 2;
            this.btnNarudzbeNovi.Text = "Nova";
            this.btnNarudzbeNovi.UseVisualStyleBackColor = true;
            this.btnNarudzbeNovi.Click += new System.EventHandler(this.btnNarudzbeNovi_Click);
            // 
            // btnNarudzbeIzmijeni
            // 
            this.btnNarudzbeIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeIzmijeni.Location = new System.Drawing.Point(385, 218);
            this.btnNarudzbeIzmijeni.Name = "btnNarudzbeIzmijeni";
            this.btnNarudzbeIzmijeni.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeIzmijeni.TabIndex = 3;
            this.btnNarudzbeIzmijeni.Text = "Izmijeni";
            this.btnNarudzbeIzmijeni.UseVisualStyleBackColor = true;
            this.btnNarudzbeIzmijeni.Click += new System.EventHandler(this.btnNarudzbeIzmijeni_Click);
            // 
            // btnNarudzbeIzbrisi
            // 
            this.btnNarudzbeIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeIzbrisi.Location = new System.Drawing.Point(491, 218);
            this.btnNarudzbeIzbrisi.Name = "btnNarudzbeIzbrisi";
            this.btnNarudzbeIzbrisi.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeIzbrisi.TabIndex = 4;
            this.btnNarudzbeIzbrisi.Text = "Izbriši";
            this.btnNarudzbeIzbrisi.UseVisualStyleBackColor = true;
            this.btnNarudzbeIzbrisi.Click += new System.EventHandler(this.btnNarudzbeIzbrisi_Click);
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 275);
            this.Controls.Add(this.btnNarudzbeIzbrisi);
            this.Controls.Add(this.btnNarudzbeIzmijeni);
            this.Controls.Add(this.btnNarudzbeNovi);
            this.Controls.Add(this.btnNarudzbeNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNarudzbe";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.FormNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource narudzbeBindingSource;
        private appotekaDBDataSet2TableAdapters.narudzbeTableAdapter narudzbeTableAdapter;
        private System.Windows.Forms.Button btnNarudzbeNatrag;
        private System.Windows.Forms.Button btnNarudzbeNovi;
        private System.Windows.Forms.Button btnNarudzbeIzmijeni;
        private System.Windows.Forms.Button btnNarudzbeIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
    }
}