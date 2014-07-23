namespace Appoteka_v2._0
{
    partial class FormLijekovi
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
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet = new Appoteka_v2._0.appotekaDBDataSet();
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSetTableAdapters.lijekoviTableAdapter();
            this.btnLijekoviNovi = new System.Windows.Forms.Button();
            this.btnLijekoviNatrag = new System.Windows.Forms.Button();
            this.btnLijekoviIzmjeni = new System.Windows.Forms.Button();
            this.btnLijekIzbrisi = new System.Windows.Forms.Button();
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            this.dataGridLijekoviKategorije = new System.Windows.Forms.DataGridView();
            this.lijekovihaskategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.lijekovi_has_kategorijeTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter();
            this.kategorijeLijekovaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeLijekovaTableAdapter1 = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.kategorijeLijekovaTableAdapter();
            this.dgvKriticneZalihe = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kriticneZalihe = new Appoteka_v2._0.kriticneZalihe();
            this.lblKriticneZalihe = new System.Windows.Forms.Label();
            this.lijekoviTableAdapter1 = new Appoteka_v2._0.kriticneZaliheTableAdapters.lijekoviTableAdapter();
            this.grbTrazilica = new System.Windows.Forms.GroupBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLijekoviKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekovihaskategorijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKriticneZalihe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriticneZalihe)).BeginInit();
            this.grbTrazilica.SuspendLayout();
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
            this.nazivDataGridViewTextBoxColumn,
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.cijenaKupovnaDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dopunskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lijekoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            this.serijskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodacDataGridViewTextBoxColumn
            // 
            this.proizvodacDataGridViewTextBoxColumn.DataPropertyName = "proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.HeaderText = "Proizvođač";
            this.proizvodacDataGridViewTextBoxColumn.Name = "proizvodacDataGridViewTextBoxColumn";
            this.proizvodacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokTrajanjaDataGridViewTextBoxColumn
            // 
            this.rokTrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rokTrajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok trajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.Name = "rokTrajanjaDataGridViewTextBoxColumn";
            this.rokTrajanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaKupovnaDataGridViewTextBoxColumn
            // 
            this.cijenaKupovnaDataGridViewTextBoxColumn.DataPropertyName = "cijenaKupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn.HeaderText = "Kupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn.Name = "cijenaKupovnaDataGridViewTextBoxColumn";
            this.cijenaKupovnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaProdajnaDataGridViewTextBoxColumn
            // 
            this.cijenaProdajnaDataGridViewTextBoxColumn.DataPropertyName = "cijenaProdajna";
            this.cijenaProdajnaDataGridViewTextBoxColumn.HeaderText = "Prodajna";
            this.cijenaProdajnaDataGridViewTextBoxColumn.Name = "cijenaProdajnaDataGridViewTextBoxColumn";
            this.cijenaProdajnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dopunskoDataGridViewTextBoxColumn
            // 
            this.dopunskoDataGridViewTextBoxColumn.DataPropertyName = "dopunsko";
            this.dopunskoDataGridViewTextBoxColumn.HeaderText = "Dopunsko %";
            this.dopunskoDataGridViewTextBoxColumn.Name = "dopunskoDataGridViewTextBoxColumn";
            this.dopunskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet;
            // 
            // appotekaDBDataSet
            // 
            this.appotekaDBDataSet.DataSetName = "appotekaDBDataSet";
            this.appotekaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // btnLijekoviNovi
            // 
            this.btnLijekoviNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekoviNovi.Location = new System.Drawing.Point(22, 11);
            this.btnLijekoviNovi.Name = "btnLijekoviNovi";
            this.btnLijekoviNovi.Size = new System.Drawing.Size(75, 32);
            this.btnLijekoviNovi.TabIndex = 1;
            this.btnLijekoviNovi.Text = "Novi";
            this.btnLijekoviNovi.UseVisualStyleBackColor = true;
            this.btnLijekoviNovi.Click += new System.EventHandler(this.btnLijekoviNovi_Click);
            // 
            // btnLijekoviNatrag
            // 
            this.btnLijekoviNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekoviNatrag.Location = new System.Drawing.Point(22, 317);
            this.btnLijekoviNatrag.Name = "btnLijekoviNatrag";
            this.btnLijekoviNatrag.Size = new System.Drawing.Size(89, 44);
            this.btnLijekoviNatrag.TabIndex = 2;
            this.btnLijekoviNatrag.Text = "Natrag";
            this.btnLijekoviNatrag.UseVisualStyleBackColor = true;
            this.btnLijekoviNatrag.Click += new System.EventHandler(this.btnLijekoviNatrag_Click);
            // 
            // btnLijekoviIzmjeni
            // 
            this.btnLijekoviIzmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekoviIzmjeni.Location = new System.Drawing.Point(135, 11);
            this.btnLijekoviIzmjeni.Name = "btnLijekoviIzmjeni";
            this.btnLijekoviIzmjeni.Size = new System.Drawing.Size(75, 32);
            this.btnLijekoviIzmjeni.TabIndex = 3;
            this.btnLijekoviIzmjeni.Text = "Izmjeni";
            this.btnLijekoviIzmjeni.UseVisualStyleBackColor = true;
            this.btnLijekoviIzmjeni.Click += new System.EventHandler(this.btnLijekoviIzmjeni_Click);
            // 
            // btnLijekIzbrisi
            // 
            this.btnLijekIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekIzbrisi.Location = new System.Drawing.Point(247, 11);
            this.btnLijekIzbrisi.Name = "btnLijekIzbrisi";
            this.btnLijekIzbrisi.Size = new System.Drawing.Size(75, 32);
            this.btnLijekIzbrisi.TabIndex = 4;
            this.btnLijekIzbrisi.Text = "Izbriši";
            this.btnLijekIzbrisi.UseVisualStyleBackColor = true;
            this.btnLijekIzbrisi.Click += new System.EventHandler(this.btnLijekIzbrisi_Click);
            // 
            // appotekaDBDataSet1
            // 
            this.appotekaDBDataSet1.DataSetName = "appotekaDBDataSet1";
            this.appotekaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeLijekovaBindingSource
            // 
            this.kategorijeLijekovaBindingSource.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource.DataSource = this.appotekaDBDataSet1;
            // 
            // kategorijeLijekovaTableAdapter
            // 
            this.kategorijeLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridLijekoviKategorije
            // 
            this.dataGridLijekoviKategorije.AllowUserToAddRows = false;
            this.dataGridLijekoviKategorije.AllowUserToDeleteRows = false;
            this.dataGridLijekoviKategorije.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridLijekoviKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLijekoviKategorije.Location = new System.Drawing.Point(269, 243);
            this.dataGridLijekoviKategorije.Name = "dataGridLijekoviKategorije";
            this.dataGridLijekoviKategorije.ReadOnly = true;
            this.dataGridLijekoviKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLijekoviKategorije.Size = new System.Drawing.Size(236, 118);
            this.dataGridLijekoviKategorije.TabIndex = 5;
            this.dataGridLijekoviKategorije.SelectionChanged += new System.EventHandler(this.dataGridLijekoviKategorije_SelectionChanged);
            // 
            // lijekovihaskategorijeBindingSource
            // 
            this.lijekovihaskategorijeBindingSource.DataMember = "lijekovi_has_kategorije";
            this.lijekovihaskategorijeBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekovi_has_kategorijeTableAdapter
            // 
            this.lijekovi_has_kategorijeTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijeLijekovaBindingSource1
            // 
            this.kategorijeLijekovaBindingSource1.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource1.DataSource = this.appotekaDBDataSet2;
            // 
            // kategorijeLijekovaTableAdapter1
            // 
            this.kategorijeLijekovaTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvKriticneZalihe
            // 
            this.dgvKriticneZalihe.AllowUserToAddRows = false;
            this.dgvKriticneZalihe.AllowUserToDeleteRows = false;
            this.dgvKriticneZalihe.AutoGenerateColumns = false;
            this.dgvKriticneZalihe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKriticneZalihe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKriticneZalihe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1});
            this.dgvKriticneZalihe.DataSource = this.lijekoviBindingSource1;
            this.dgvKriticneZalihe.Location = new System.Drawing.Point(568, 243);
            this.dgvKriticneZalihe.Name = "dgvKriticneZalihe";
            this.dgvKriticneZalihe.ReadOnly = true;
            this.dgvKriticneZalihe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKriticneZalihe.Size = new System.Drawing.Size(392, 118);
            this.dgvKriticneZalihe.TabIndex = 7;
            // 
            // serijskiBrojDataGridViewTextBoxColumn1
            // 
            this.serijskiBrojDataGridViewTextBoxColumn1.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn1.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn1.Name = "serijskiBrojDataGridViewTextBoxColumn1";
            this.serijskiBrojDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lijekoviBindingSource1
            // 
            this.lijekoviBindingSource1.DataMember = "lijekovi";
            this.lijekoviBindingSource1.DataSource = this.kriticneZalihe;
            // 
            // kriticneZalihe
            // 
            this.kriticneZalihe.DataSetName = "kriticneZalihe";
            this.kriticneZalihe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKriticneZalihe
            // 
            this.lblKriticneZalihe.AutoSize = true;
            this.lblKriticneZalihe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKriticneZalihe.Location = new System.Drawing.Point(568, 218);
            this.lblKriticneZalihe.Name = "lblKriticneZalihe";
            this.lblKriticneZalihe.Size = new System.Drawing.Size(121, 20);
            this.lblKriticneZalihe.TabIndex = 9;
            this.lblKriticneZalihe.Text = "Kritične zalihe";
            // 
            // lijekoviTableAdapter1
            // 
            this.lijekoviTableAdapter1.ClearBeforeFill = true;
            // 
            // grbTrazilica
            // 
            this.grbTrazilica.Controls.Add(this.btnTrazi);
            this.grbTrazilica.Controls.Add(this.txtTrazi);
            this.grbTrazilica.Location = new System.Drawing.Point(583, 0);
            this.grbTrazilica.Name = "grbTrazilica";
            this.grbTrazilica.Size = new System.Drawing.Size(377, 50);
            this.grbTrazilica.TabIndex = 12;
            this.grbTrazilica.TabStop = false;
            this.grbTrazilica.Text = "Tražilica";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrazi.Location = new System.Drawing.Point(292, 17);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(21, 19);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(243, 20);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrazi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(265, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategorije selektiranog";
            // 
            // FormLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTrazilica);
            this.Controls.Add(this.lblKriticneZalihe);
            this.Controls.Add(this.dgvKriticneZalihe);
            this.Controls.Add(this.dataGridLijekoviKategorije);
            this.Controls.Add(this.btnLijekIzbrisi);
            this.Controls.Add(this.btnLijekoviIzmjeni);
            this.Controls.Add(this.btnLijekoviNatrag);
            this.Controls.Add(this.btnLijekoviNovi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLijekovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lijekovi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLijekovi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLijekoviKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekovihaskategorijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKriticneZalihe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriticneZalihe)).EndInit();
            this.grbTrazilica.ResumeLayout(false);
            this.grbTrazilica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet appotekaDBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSetTableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.Button btnLijekoviNovi;
        private System.Windows.Forms.Button btnLijekoviNatrag;
        private System.Windows.Forms.Button btnLijekoviIzmjeni;
        private System.Windows.Forms.Button btnLijekIzbrisi;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridLijekoviKategorije;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource lijekovihaskategorijeBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter lijekovi_has_kategorijeTableAdapter;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource1;
        private appotekaDBDataSet2TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter1;
        private System.Windows.Forms.DataGridView dgvKriticneZalihe;
        private kriticneZalihe kriticneZalihe;
        private System.Windows.Forms.BindingSource lijekoviBindingSource1;
        private kriticneZaliheTableAdapters.lijekoviTableAdapter lijekoviTableAdapter1;
        private System.Windows.Forms.Label lblKriticneZalihe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopunskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox grbTrazilica;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label label1;
    }
}

