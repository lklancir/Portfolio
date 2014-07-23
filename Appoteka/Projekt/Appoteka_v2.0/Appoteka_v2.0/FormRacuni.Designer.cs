namespace Appoteka_v2._0
{
    partial class FormRacuni
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
            this.idrRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.racunTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.racunTableAdapter();
            this.btnRacuniNatrag = new System.Windows.Forms.Button();
            this.btnRacuniNovi = new System.Windows.Forms.Button();
            this.btnRacuniIzmijeni = new System.Windows.Forms.Button();
            this.btnRacunIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
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
            this.idrRacunaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // idrRacunaDataGridViewTextBoxColumn
            // 
            this.idrRacunaDataGridViewTextBoxColumn.DataPropertyName = "IdrRacuna";
            this.idrRacunaDataGridViewTextBoxColumn.HeaderText = "ID računa";
            this.idrRacunaDataGridViewTextBoxColumn.Name = "idrRacunaDataGridViewTextBoxColumn";
            this.idrRacunaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // btnRacuniNatrag
            // 
            this.btnRacuniNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuniNatrag.Location = new System.Drawing.Point(22, 335);
            this.btnRacuniNatrag.Name = "btnRacuniNatrag";
            this.btnRacuniNatrag.Size = new System.Drawing.Size(94, 39);
            this.btnRacuniNatrag.TabIndex = 1;
            this.btnRacuniNatrag.Text = "Natrag";
            this.btnRacuniNatrag.UseVisualStyleBackColor = true;
            this.btnRacuniNatrag.Click += new System.EventHandler(this.btnRacuniNatrag_Click);
            // 
            // btnRacuniNovi
            // 
            this.btnRacuniNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuniNovi.Location = new System.Drawing.Point(509, 52);
            this.btnRacuniNovi.Name = "btnRacuniNovi";
            this.btnRacuniNovi.Size = new System.Drawing.Size(75, 39);
            this.btnRacuniNovi.TabIndex = 2;
            this.btnRacuniNovi.Text = "Novi";
            this.btnRacuniNovi.UseVisualStyleBackColor = true;
            this.btnRacuniNovi.Click += new System.EventHandler(this.btnRacuniNovi_Click);
            // 
            // btnRacuniIzmijeni
            // 
            this.btnRacuniIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuniIzmijeni.Location = new System.Drawing.Point(509, 124);
            this.btnRacuniIzmijeni.Name = "btnRacuniIzmijeni";
            this.btnRacuniIzmijeni.Size = new System.Drawing.Size(75, 39);
            this.btnRacuniIzmijeni.TabIndex = 3;
            this.btnRacuniIzmijeni.Text = "Provjeri";
            this.btnRacuniIzmijeni.UseVisualStyleBackColor = true;
            this.btnRacuniIzmijeni.Click += new System.EventHandler(this.btnRacuniIzmijeni_Click);
            // 
            // btnRacunIzbrisi
            // 
            this.btnRacunIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacunIzbrisi.Location = new System.Drawing.Point(509, 196);
            this.btnRacunIzbrisi.Name = "btnRacunIzbrisi";
            this.btnRacunIzbrisi.Size = new System.Drawing.Size(75, 39);
            this.btnRacunIzbrisi.TabIndex = 4;
            this.btnRacunIzbrisi.Text = "Izbriši";
            this.btnRacunIzbrisi.UseVisualStyleBackColor = true;
            this.btnRacunIzbrisi.Click += new System.EventHandler(this.btnRacunIzbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Računi";
            // 
            // FormRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRacunIzbrisi);
            this.Controls.Add(this.btnRacuniIzmijeni);
            this.Controls.Add(this.btnRacuniNovi);
            this.Controls.Add(this.btnRacuniNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FormRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private appotekaDBDataSet2TableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.Button btnRacuniNatrag;
        private System.Windows.Forms.Button btnRacuniNovi;
        private System.Windows.Forms.Button btnRacuniIzmijeni;
        private System.Windows.Forms.Button btnRacunIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}