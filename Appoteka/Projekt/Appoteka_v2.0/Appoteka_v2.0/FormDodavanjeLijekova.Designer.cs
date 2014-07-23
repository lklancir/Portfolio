namespace Appoteka_v2._0
{
    partial class FormDodavanjeLijekova
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
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.lijekoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet3 = new Appoteka_v2._0.DodajLijek();
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.lijekoviTableAdapter1 = new Appoteka_v2._0.appotekaDBDataSet3TableAdapters.lijekoviTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.relationship3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekovi_has_kategorijeTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter();
            this.lijekoviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.relationship3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.relationship1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekovi_has_racunTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekovi_has_racunTableAdapter();
            this.lijekoviBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.btnZavrsiDodajLijek = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource1
            // 
            this.lijekoviBindingSource1.DataMember = "lijekovi";
            this.lijekoviBindingSource1.DataSource = this.appotekaDBDataSet3;
            // 
            // appotekaDBDataSet3
            // 
            this.appotekaDBDataSet3.DataSetName = "appotekaDBDataSet3";
            this.appotekaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajLijek.Location = new System.Drawing.Point(581, 214);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(136, 34);
            this.btnDodajLijek.TabIndex = 2;
            this.btnDodajLijek.Text = "Dodaj";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // lijekoviTableAdapter1
            // 
            this.lijekoviTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.cijenaKupovnaDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dopunskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lijekoviBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(870, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            this.serijskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lijekoviBindingSource4
            // 
            this.lijekoviBindingSource4.DataMember = "lijekovi";
            this.lijekoviBindingSource4.DataSource = this.appotekaDBDataSet2;
            // 
            // relationship3BindingSource
            // 
            this.relationship3BindingSource.DataMember = "Relationship3";
            this.relationship3BindingSource.DataSource = this.lijekoviBindingSource;
            // 
            // lijekovi_has_kategorijeTableAdapter
            // 
            this.lijekovi_has_kategorijeTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource2
            // 
            this.lijekoviBindingSource2.DataMember = "lijekovi";
            this.lijekoviBindingSource2.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekoviBindingSource3
            // 
            this.lijekoviBindingSource3.DataMember = "lijekovi";
            this.lijekoviBindingSource3.DataSource = this.appotekaDBDataSet2;
            // 
            // relationship3BindingSource1
            // 
            this.relationship3BindingSource1.DataMember = "Relationship3";
            this.relationship3BindingSource1.DataSource = this.lijekoviBindingSource;
            // 
            // lijekoviBindingSource5
            // 
            this.lijekoviBindingSource5.DataMember = "lijekovi";
            this.lijekoviBindingSource5.DataSource = this.appotekaDBDataSet2;
            // 
            // relationship1BindingSource
            // 
            this.relationship1BindingSource.DataMember = "Relationship1";
            this.relationship1BindingSource.DataSource = this.lijekoviBindingSource5;
            // 
            // lijekovi_has_racunTableAdapter
            // 
            this.lijekovi_has_racunTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource6
            // 
            this.lijekoviBindingSource6.DataMember = "lijekovi";
            this.lijekoviBindingSource6.DataSource = this.appotekaDBDataSet2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.cijenaProdajna,
            this.kolicina});
            this.dataGridView2.DataSource = this.lijekoviBindingSource7;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 192);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(518, 143);
            this.dataGridView2.TabIndex = 4;
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
            // cijenaProdajna
            // 
            this.cijenaProdajna.DataPropertyName = "cijenaProdajna";
            this.cijenaProdajna.HeaderText = "Prodajna";
            this.cijenaProdajna.Name = "cijenaProdajna";
            this.cijenaProdajna.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // lijekoviBindingSource7
            // 
            this.lijekoviBindingSource7.DataMember = "lijekovi";
            this.lijekoviBindingSource7.DataSource = this.appotekaDBDataSet2;
            // 
            // btnZavrsiDodajLijek
            // 
            this.btnZavrsiDodajLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsiDodajLijek.Location = new System.Drawing.Point(581, 277);
            this.btnZavrsiDodajLijek.Name = "btnZavrsiDodajLijek";
            this.btnZavrsiDodajLijek.Size = new System.Drawing.Size(136, 34);
            this.btnZavrsiDodajLijek.TabIndex = 5;
            this.btnZavrsiDodajLijek.Text = "Završi";
            this.btnZavrsiDodajLijek.UseVisualStyleBackColor = true;
            this.btnZavrsiDodajLijek.Click += new System.EventHandler(this.btnZavrsiDodajLijek_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(12, 357);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 34);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOdustani_MouseClick);
            // 
            // FormDodavanjeLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 405);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnZavrsiDodajLijek);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodajLijek);
            this.Name = "FormDodavanjeLijekova";
            this.Text = "FormDodavanjeLijekova";
            this.Load += new System.EventHandler(this.FormDodavanjeLijekova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.Button btnDodajLijek;
        private DodajLijek appotekaDBDataSet3;
        private System.Windows.Forms.BindingSource lijekoviBindingSource1;
        private appotekaDBDataSet3TableAdapters.lijekoviTableAdapter lijekoviTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource relationship3BindingSource;
        private appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter lijekovi_has_kategorijeTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource4;
        private System.Windows.Forms.BindingSource lijekoviBindingSource2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource3;
        private System.Windows.Forms.BindingSource relationship3BindingSource1;
        private System.Windows.Forms.BindingSource lijekoviBindingSource5;
        private System.Windows.Forms.BindingSource relationship1BindingSource;
        private appotekaDBDataSet2TableAdapters.lijekovi_has_racunTableAdapter lijekovi_has_racunTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource7;
        private System.Windows.Forms.Button btnZavrsiDodajLijek;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopunskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajna;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
    }
}