namespace Appoteka_v2._0
{
    partial class FormRacuniNovi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRacuniIznos = new System.Windows.Forms.TextBox();
            this.dateTimeRacuniDatum = new System.Windows.Forms.DateTimePicker();
            this.btnRacuniNoviSpremi = new System.Windows.Forms.Button();
            this.btnRacuniNoviIzlaz = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposleniciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.btnNoviRacunDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ukupan iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zaposlenik";
            // 
            // textRacuniIznos
            // 
            this.textRacuniIznos.Location = new System.Drawing.Point(141, 52);
            this.textRacuniIznos.Name = "textRacuniIznos";
            this.textRacuniIznos.Size = new System.Drawing.Size(200, 20);
            this.textRacuniIznos.TabIndex = 3;
            // 
            // dateTimeRacuniDatum
            // 
            this.dateTimeRacuniDatum.Location = new System.Drawing.Point(141, 17);
            this.dateTimeRacuniDatum.Name = "dateTimeRacuniDatum";
            this.dateTimeRacuniDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRacuniDatum.TabIndex = 4;
            // 
            // btnRacuniNoviSpremi
            // 
            this.btnRacuniNoviSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuniNoviSpremi.Location = new System.Drawing.Point(583, 293);
            this.btnRacuniNoviSpremi.Name = "btnRacuniNoviSpremi";
            this.btnRacuniNoviSpremi.Size = new System.Drawing.Size(91, 33);
            this.btnRacuniNoviSpremi.TabIndex = 5;
            this.btnRacuniNoviSpremi.Text = "Izdaj";
            this.btnRacuniNoviSpremi.UseVisualStyleBackColor = true;
            this.btnRacuniNoviSpremi.Click += new System.EventHandler(this.btnRacuniNoviSpremi_Click);
            // 
            // btnRacuniNoviIzlaz
            // 
            this.btnRacuniNoviIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuniNoviIzlaz.Location = new System.Drawing.Point(22, 293);
            this.btnRacuniNoviIzlaz.Name = "btnRacuniNoviIzlaz";
            this.btnRacuniNoviIzlaz.Size = new System.Drawing.Size(91, 33);
            this.btnRacuniNoviIzlaz.TabIndex = 6;
            this.btnRacuniNoviIzlaz.Text = "Izlaz";
            this.btnRacuniNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnRacuniNoviIzlaz.Click += new System.EventHandler(this.btnRacuniNoviIzlaz_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.zaposleniciBindingSource1;
            this.comboBox1.DisplayMember = "prezime";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "OIB";
            // 
            // zaposleniciBindingSource1
            // 
            this.zaposleniciBindingSource1.DataMember = "zaposlenici";
            this.zaposleniciBindingSource1.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn,
            this.dopunskoDataGridViewTextBoxColumn,
            this.kolicina,
            this.iznos});
            this.dataGridView1.DataSource = this.lijekoviBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(27, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 124);
            this.dataGridView1.TabIndex = 8;
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaProdajnaDataGridViewTextBoxColumn
            // 
            this.cijenaProdajnaDataGridViewTextBoxColumn.DataPropertyName = "cijenaProdajna";
            this.cijenaProdajnaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaProdajnaDataGridViewTextBoxColumn.Name = "cijenaProdajnaDataGridViewTextBoxColumn";
            // 
            // dopunskoDataGridViewTextBoxColumn
            // 
            this.dopunskoDataGridViewTextBoxColumn.DataPropertyName = "dopunsko";
            this.dopunskoDataGridViewTextBoxColumn.HeaderText = "Dopunsko %";
            this.dopunskoDataGridViewTextBoxColumn.Name = "dopunskoDataGridViewTextBoxColumn";
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // iznos
            // 
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
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
            // btnNoviRacunDodaj
            // 
            this.btnNoviRacunDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviRacunDodaj.Location = new System.Drawing.Point(319, 293);
            this.btnNoviRacunDodaj.Name = "btnNoviRacunDodaj";
            this.btnNoviRacunDodaj.Size = new System.Drawing.Size(91, 33);
            this.btnNoviRacunDodaj.TabIndex = 9;
            this.btnNoviRacunDodaj.Text = "Dodaj";
            this.btnNoviRacunDodaj.UseVisualStyleBackColor = true;
            this.btnNoviRacunDodaj.Click += new System.EventHandler(this.btnNoviRacunDodaj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(455, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Osvježi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stavke računa";
            // 
            // FormRacuniNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNoviRacunDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRacuniNoviIzlaz);
            this.Controls.Add(this.btnRacuniNoviSpremi);
            this.Controls.Add(this.dateTimeRacuniDatum);
            this.Controls.Add(this.textRacuniIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRacuniNovi";
            this.Text = "Novi račun";
            this.Activated += new System.EventHandler(this.FormRacuniNovi_Activated_1);
            this.Load += new System.EventHandler(this.FormRacuniNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRacuniIznos;
        private System.Windows.Forms.DateTimePicker dateTimeRacuniDatum;
        private System.Windows.Forms.Button btnRacuniNoviSpremi;
        private System.Windows.Forms.Button btnRacuniNoviIzlaz;
        private System.Windows.Forms.ComboBox comboBox1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.Button btnNoviRacunDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopunskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.Label label4;
    }
}