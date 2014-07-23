namespace Appoteka_v2._0
{
    partial class FormKategorijaLadica
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
            this.idLadiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ladice1 = new Appoteka_v2._0.ladice1();
            this.ladiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladiceBS1 = new Appoteka_v2._0.ladiceBS1();
            this.ladiceTableAdapter = new Appoteka_v2._0.ladiceBS1TableAdapters.ladiceTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idLadiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladiceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ladice2 = new Appoteka_v2._0.ladice2();
            this.ladiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ladiceBS2 = new Appoteka_v2._0.ladiceBS2();
            this.ladiceTableAdapter1 = new Appoteka_v2._0.ladiceBS2TableAdapters.ladiceTableAdapter();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.ladiceTableAdapter2 = new Appoteka_v2._0.ladice1TableAdapters.ladiceTableAdapter();
            this.ladiceTableAdapter3 = new Appoteka_v2._0.ladice2TableAdapters.ladiceTableAdapter();
            this.ladiceBS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1BindingSource)).BeginInit();
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
            this.idLadiceDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ladiceBindingSource2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(290, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(258, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idLadiceDataGridViewTextBoxColumn
            // 
            this.idLadiceDataGridViewTextBoxColumn.DataPropertyName = "IdLadice";
            this.idLadiceDataGridViewTextBoxColumn.HeaderText = "ID ladice";
            this.idLadiceDataGridViewTextBoxColumn.Name = "idLadiceDataGridViewTextBoxColumn";
            this.idLadiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            this.kapacitetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ladiceBindingSource2
            // 
            this.ladiceBindingSource2.DataMember = "ladice";
            this.ladiceBindingSource2.DataSource = this.ladice1;
            // 
            // ladice1
            // 
            this.ladice1.DataSetName = "ladice1";
            this.ladice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladiceBindingSource
            // 
            this.ladiceBindingSource.DataMember = "ladice";
            this.ladiceBindingSource.DataSource = this.ladiceBS1;
            // 
            // ladiceBS1
            // 
            this.ladiceBS1.DataSetName = "ladiceBS1";
            this.ladiceBS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladiceTableAdapter
            // 
            this.ladiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLadiceDataGridViewTextBoxColumn1,
            this.kapacitetDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.ladiceBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(255, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // idLadiceDataGridViewTextBoxColumn1
            // 
            this.idLadiceDataGridViewTextBoxColumn1.DataPropertyName = "IdLadice";
            this.idLadiceDataGridViewTextBoxColumn1.HeaderText = "ID ladice";
            this.idLadiceDataGridViewTextBoxColumn1.Name = "idLadiceDataGridViewTextBoxColumn1";
            this.idLadiceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn1
            // 
            this.kapacitetDataGridViewTextBoxColumn1.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.kapacitetDataGridViewTextBoxColumn1.Name = "kapacitetDataGridViewTextBoxColumn1";
            this.kapacitetDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ladiceBindingSource3
            // 
            this.ladiceBindingSource3.DataMember = "ladice";
            this.ladiceBindingSource3.DataSource = this.ladice2;
            // 
            // ladice2
            // 
            this.ladice2.DataSetName = "ladice2";
            this.ladice2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladiceBindingSource1
            // 
            this.ladiceBindingSource1.DataMember = "ladice";
            this.ladiceBindingSource1.DataSource = this.ladiceBS2;
            // 
            // ladiceBS2
            // 
            this.ladiceBS2.DataSetName = "ladiceBS2";
            this.ladiceBS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladiceTableAdapter1
            // 
            this.ladiceTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(239, 168);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 36);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsi.Location = new System.Drawing.Point(461, 201);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(87, 30);
            this.btnZavrsi.TabIndex = 3;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(12, 201);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(87, 30);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // ladiceTableAdapter2
            // 
            this.ladiceTableAdapter2.ClearBeforeFill = true;
            // 
            // ladiceTableAdapter3
            // 
            this.ladiceTableAdapter3.ClearBeforeFill = true;
            // 
            // ladiceBS1BindingSource
            // 
            this.ladiceBS1BindingSource.DataSource = this.ladiceBS1;
            this.ladiceBS1BindingSource.Position = 0;
            // 
            // FormKategorijaLadica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 236);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKategorijaLadica";
            this.Text = "FormKategorijaLadica";
            this.Load += new System.EventHandler(this.FormKategorijaLadica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ladiceBS1 ladiceBS1;
        private System.Windows.Forms.BindingSource ladiceBindingSource;
        private ladiceBS1TableAdapters.ladiceTableAdapter ladiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ladiceBS2 ladiceBS2;
        private System.Windows.Forms.BindingSource ladiceBindingSource1;
        private ladiceBS2TableAdapters.ladiceTableAdapter ladiceTableAdapter1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnOdustani;
        private ladice1 ladice1;
        private System.Windows.Forms.BindingSource ladiceBindingSource2;
        private ladice1TableAdapters.ladiceTableAdapter ladiceTableAdapter2;
        private ladice2 ladice2;
        private System.Windows.Forms.BindingSource ladiceBindingSource3;
        private ladice2TableAdapters.ladiceTableAdapter ladiceTableAdapter3;
        private System.Windows.Forms.BindingSource ladiceBS1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLadiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLadiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn1;
    }
}