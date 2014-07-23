namespace Appoteka_v2._0
{
    partial class FormNarudzbeNovi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNaruzbeDatum = new System.Windows.Forms.DateTimePicker();
            this.btnNarudzbeNoviSpremi = new System.Windows.Forms.Button();
            this.btnNarudzbeNoviIzlaz = new System.Windows.Forms.Button();
            this.comboBoxDobavljac = new System.Windows.Forms.ComboBox();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.comboBoxZaposlenik = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter();
            this.zaposleniciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.lijekoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textNarudzbeIznos = new System.Windows.Forms.TextBox();
            this.lijekoviBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobavljač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zaposlenik";
            // 
            // dateTimeNaruzbeDatum
            // 
            this.dateTimeNaruzbeDatum.Location = new System.Drawing.Point(120, 35);
            this.dateTimeNaruzbeDatum.Name = "dateTimeNaruzbeDatum";
            this.dateTimeNaruzbeDatum.Size = new System.Drawing.Size(190, 20);
            this.dateTimeNaruzbeDatum.TabIndex = 5;
            // 
            // btnNarudzbeNoviSpremi
            // 
            this.btnNarudzbeNoviSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeNoviSpremi.Location = new System.Drawing.Point(606, 361);
            this.btnNarudzbeNoviSpremi.Name = "btnNarudzbeNoviSpremi";
            this.btnNarudzbeNoviSpremi.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeNoviSpremi.TabIndex = 6;
            this.btnNarudzbeNoviSpremi.Text = "Izdaj";
            this.btnNarudzbeNoviSpremi.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviSpremi.Click += new System.EventHandler(this.btnNarudzbeNoviSpremi_Click);
            // 
            // btnNarudzbeNoviIzlaz
            // 
            this.btnNarudzbeNoviIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbeNoviIzlaz.Location = new System.Drawing.Point(31, 360);
            this.btnNarudzbeNoviIzlaz.Name = "btnNarudzbeNoviIzlaz";
            this.btnNarudzbeNoviIzlaz.Size = new System.Drawing.Size(75, 36);
            this.btnNarudzbeNoviIzlaz.TabIndex = 7;
            this.btnNarudzbeNoviIzlaz.Text = "Izlaz";
            this.btnNarudzbeNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviIzlaz.Click += new System.EventHandler(this.btnNarudzbeNoviIzlaz_Click);
            // 
            // comboBoxDobavljac
            // 
            this.comboBoxDobavljac.DataSource = this.dobavljaciBindingSource;
            this.comboBoxDobavljac.DisplayMember = "naziv";
            this.comboBoxDobavljac.FormattingEnabled = true;
            this.comboBoxDobavljac.Location = new System.Drawing.Point(121, 79);
            this.comboBoxDobavljac.Name = "comboBoxDobavljac";
            this.comboBoxDobavljac.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDobavljac.TabIndex = 9;
            this.comboBoxDobavljac.ValueMember = "IdDobavljac";
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxZaposlenik
            // 
            this.comboBoxZaposlenik.DataSource = this.zaposleniciBindingSource;
            this.comboBoxZaposlenik.DisplayMember = "prezime";
            this.comboBoxZaposlenik.FormattingEnabled = true;
            this.comboBoxZaposlenik.Location = new System.Drawing.Point(121, 121);
            this.comboBoxZaposlenik.Name = "comboBoxZaposlenik";
            this.comboBoxZaposlenik.Size = new System.Drawing.Size(189, 21);
            this.comboBoxZaposlenik.TabIndex = 10;
            this.comboBoxZaposlenik.ValueMember = "OIB";
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
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
            // lijekoviBindingSource1
            // 
            this.lijekoviBindingSource1.DataMember = "lijekovi";
            this.lijekoviBindingSource1.DataSource = this.appotekaDBDataSet2;
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
            // textNarudzbeIznos
            // 
            this.textNarudzbeIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textNarudzbeIznos.Location = new System.Drawing.Point(542, 122);
            this.textNarudzbeIznos.Name = "textNarudzbeIznos";
            this.textNarudzbeIznos.Size = new System.Drawing.Size(139, 22);
            this.textNarudzbeIznos.TabIndex = 11;
            // 
            // lijekoviBindingSource4
            // 
            this.lijekoviBindingSource4.DataMember = "lijekovi";
            this.lijekoviBindingSource4.DataSource = this.appotekaDBDataSet2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(372, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjezi.Location = new System.Drawing.Point(487, 361);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(78, 36);
            this.btnOsvjezi.TabIndex = 14;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(436, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ukupan iznos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.proizvodacDataGridViewTextBoxColumn1,
            this.cijenaKupovnaDataGridViewTextBoxColumn1,
            this.kolicina,
            this.iznos});
            this.dataGridView2.DataSource = this.lijekoviBindingSource4;
            this.dataGridView2.Location = new System.Drawing.Point(31, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(650, 176);
            this.dataGridView2.TabIndex = 16;
            // 
            // serijskiBrojDataGridViewTextBoxColumn1
            // 
            this.serijskiBrojDataGridViewTextBoxColumn1.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn1.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn1.Name = "serijskiBrojDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // proizvodacDataGridViewTextBoxColumn1
            // 
            this.proizvodacDataGridViewTextBoxColumn1.DataPropertyName = "proizvodac";
            this.proizvodacDataGridViewTextBoxColumn1.HeaderText = "Proizvođač";
            this.proizvodacDataGridViewTextBoxColumn1.Name = "proizvodacDataGridViewTextBoxColumn1";
            // 
            // cijenaKupovnaDataGridViewTextBoxColumn1
            // 
            this.cijenaKupovnaDataGridViewTextBoxColumn1.DataPropertyName = "cijenaKupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn1.HeaderText = "Kupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn1.Name = "cijenaKupovnaDataGridViewTextBoxColumn1";
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
            // FormNarudzbeNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 412);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNarudzbeIznos);
            this.Controls.Add(this.comboBoxZaposlenik);
            this.Controls.Add(this.comboBoxDobavljac);
            this.Controls.Add(this.btnNarudzbeNoviIzlaz);
            this.Controls.Add(this.btnNarudzbeNoviSpremi);
            this.Controls.Add(this.dateTimeNaruzbeDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormNarudzbeNovi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Nova narudžba";
            this.Activated += new System.EventHandler(this.FormNarudzbeNovi_Activated);
            this.Load += new System.EventHandler(this.FormNarudzbeNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNaruzbeDatum;
        private System.Windows.Forms.Button btnNarudzbeNoviSpremi;
        private System.Windows.Forms.Button btnNarudzbeNoviIzlaz;
        private System.Windows.Forms.ComboBox comboBoxDobavljac;
        private System.Windows.Forms.ComboBox comboBoxZaposlenik;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource1;
        private System.Windows.Forms.BindingSource lijekoviBindingSource2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource3;
        private System.Windows.Forms.TextBox textNarudzbeIznos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.BindingSource lijekoviBindingSource4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
    }
}