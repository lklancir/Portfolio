namespace Appoteka_v2._0
{
    partial class FormKategorije
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
            this.idKategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            this.btnKategorijeNatrag = new System.Windows.Forms.Button();
            this.btnKategorijeNovi = new System.Windows.Forms.Button();
            this.btnKategorijeIzmjeni = new System.Windows.Forms.Button();
            this.btnKategorijeIzbrisi = new System.Windows.Forms.Button();
            this.dataGridKategorije = new System.Windows.Forms.DataGridView();
            this.lijekoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridLadice = new System.Windows.Forms.DataGridView();
            this.lblLijekovi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLadice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategorijeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategorijeLijekovaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idKategorijeDataGridViewTextBoxColumn
            // 
            this.idKategorijeDataGridViewTextBoxColumn.DataPropertyName = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.HeaderText = "ID kategorije";
            this.idKategorijeDataGridViewTextBoxColumn.Name = "idKategorijeDataGridViewTextBoxColumn";
            this.idKategorijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // kategorijeLijekovaBindingSource
            // 
            this.kategorijeLijekovaBindingSource.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource.DataSource = this.appotekaDBDataSet1;
            // 
            // appotekaDBDataSet1
            // 
            this.appotekaDBDataSet1.DataSetName = "appotekaDBDataSet1";
            this.appotekaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeLijekovaTableAdapter
            // 
            this.kategorijeLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // btnKategorijeNatrag
            // 
            this.btnKategorijeNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorijeNatrag.Location = new System.Drawing.Point(16, 319);
            this.btnKategorijeNatrag.Name = "btnKategorijeNatrag";
            this.btnKategorijeNatrag.Size = new System.Drawing.Size(90, 40);
            this.btnKategorijeNatrag.TabIndex = 1;
            this.btnKategorijeNatrag.Text = "Natrag";
            this.btnKategorijeNatrag.UseVisualStyleBackColor = true;
            this.btnKategorijeNatrag.Click += new System.EventHandler(this.btnKategorijeNatrag_Click);
            // 
            // btnKategorijeNovi
            // 
            this.btnKategorijeNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorijeNovi.Location = new System.Drawing.Point(12, 196);
            this.btnKategorijeNovi.Name = "btnKategorijeNovi";
            this.btnKategorijeNovi.Size = new System.Drawing.Size(75, 32);
            this.btnKategorijeNovi.TabIndex = 2;
            this.btnKategorijeNovi.Text = "Novi";
            this.btnKategorijeNovi.UseVisualStyleBackColor = true;
            this.btnKategorijeNovi.Click += new System.EventHandler(this.btnKategorijeNovi_Click);
            // 
            // btnKategorijeIzmjeni
            // 
            this.btnKategorijeIzmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorijeIzmjeni.Location = new System.Drawing.Point(144, 196);
            this.btnKategorijeIzmjeni.Name = "btnKategorijeIzmjeni";
            this.btnKategorijeIzmjeni.Size = new System.Drawing.Size(75, 32);
            this.btnKategorijeIzmjeni.TabIndex = 3;
            this.btnKategorijeIzmjeni.Text = "Izmjeni";
            this.btnKategorijeIzmjeni.UseVisualStyleBackColor = true;
            this.btnKategorijeIzmjeni.Click += new System.EventHandler(this.btnKategorijeIzmjeni_Click);
            // 
            // btnKategorijeIzbrisi
            // 
            this.btnKategorijeIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorijeIzbrisi.Location = new System.Drawing.Point(280, 196);
            this.btnKategorijeIzbrisi.Name = "btnKategorijeIzbrisi";
            this.btnKategorijeIzbrisi.Size = new System.Drawing.Size(75, 32);
            this.btnKategorijeIzbrisi.TabIndex = 4;
            this.btnKategorijeIzbrisi.Text = "Izbriši";
            this.btnKategorijeIzbrisi.UseVisualStyleBackColor = true;
            this.btnKategorijeIzbrisi.Click += new System.EventHandler(this.btnKategorijeIzbrisi_Click);
            // 
            // dataGridKategorije
            // 
            this.dataGridKategorije.AllowUserToAddRows = false;
            this.dataGridKategorije.AllowUserToDeleteRows = false;
            this.dataGridKategorije.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKategorije.Location = new System.Drawing.Point(454, 36);
            this.dataGridKategorije.MultiSelect = false;
            this.dataGridKategorije.Name = "dataGridKategorije";
            this.dataGridKategorije.ReadOnly = true;
            this.dataGridKategorije.Size = new System.Drawing.Size(394, 169);
            this.dataGridKategorije.TabIndex = 5;
            // 
            // lijekoviBindingSource1
            // 
            this.lijekoviBindingSource1.DataMember = "lijekovi";
            this.lijekoviBindingSource1.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridLadice
            // 
            this.dataGridLadice.AllowUserToAddRows = false;
            this.dataGridLadice.AllowUserToDeleteRows = false;
            this.dataGridLadice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridLadice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLadice.Location = new System.Drawing.Point(454, 241);
            this.dataGridLadice.MultiSelect = false;
            this.dataGridLadice.Name = "dataGridLadice";
            this.dataGridLadice.ReadOnly = true;
            this.dataGridLadice.Size = new System.Drawing.Size(363, 118);
            this.dataGridLadice.TabIndex = 6;
            // 
            // lblLijekovi
            // 
            this.lblLijekovi.AutoSize = true;
            this.lblLijekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLijekovi.Location = new System.Drawing.Point(454, 13);
            this.lblLijekovi.Name = "lblLijekovi";
            this.lblLijekovi.Size = new System.Drawing.Size(140, 20);
            this.lblLijekovi.TabIndex = 7;
            this.lblLijekovi.Text = "Lijekovi u kategoriji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(454, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv ladice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategorije";
            // 
            // FormKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLijekovi);
            this.Controls.Add(this.dataGridLadice);
            this.Controls.Add(this.dataGridKategorije);
            this.Controls.Add(this.btnKategorijeIzbrisi);
            this.Controls.Add(this.btnKategorijeIzmjeni);
            this.Controls.Add(this.btnKategorijeNovi);
            this.Controls.Add(this.btnKategorijeNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKategorije";
            this.Text = "Kategorije lijekova";
            this.Load += new System.EventHandler(this.FormKategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLadice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.Button btnKategorijeNatrag;
        private System.Windows.Forms.Button btnKategorijeNovi;
        private System.Windows.Forms.Button btnKategorijeIzmjeni;
        private System.Windows.Forms.Button btnKategorijeIzbrisi;
        private System.Windows.Forms.DataGridView dataGridKategorije;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridLadice;
        private System.Windows.Forms.Label lblLijekovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}