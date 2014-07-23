namespace Appoteka_v2._0
{
    partial class FormHzzoProvjeriBroj
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
            this.textKlijentIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textKlijentPrezime = new System.Windows.Forms.TextBox();
            this.textKlijentOib = new System.Windows.Forms.TextBox();
            this.textKlijentZdrastvena = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idReceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIstekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPodizanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hzzoReceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoDBDataSet = new Appoteka_v2._0.HzzoDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hzzoLijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoKlijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoKlijentTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter();
            this.hzzoReceptTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoReceptTableAdapter();
            this.hzzoLijekoviTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoLijekoviTableAdapter();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnProvjeriBrojIzlaz = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoReceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoLijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // textKlijentIme
            // 
            this.textKlijentIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKlijentIme.Location = new System.Drawing.Point(138, 30);
            this.textKlijentIme.Name = "textKlijentIme";
            this.textKlijentIme.ReadOnly = true;
            this.textKlijentIme.Size = new System.Drawing.Size(198, 26);
            this.textKlijentIme.TabIndex = 1;
            this.textKlijentIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textKlijentIme_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(392, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(392, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zdrastvena";
            // 
            // textKlijentPrezime
            // 
            this.textKlijentPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKlijentPrezime.Location = new System.Drawing.Point(138, 73);
            this.textKlijentPrezime.Name = "textKlijentPrezime";
            this.textKlijentPrezime.ReadOnly = true;
            this.textKlijentPrezime.Size = new System.Drawing.Size(198, 26);
            this.textKlijentPrezime.TabIndex = 6;
            // 
            // textKlijentOib
            // 
            this.textKlijentOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKlijentOib.Location = new System.Drawing.Point(513, 30);
            this.textKlijentOib.Name = "textKlijentOib";
            this.textKlijentOib.ReadOnly = true;
            this.textKlijentOib.Size = new System.Drawing.Size(198, 26);
            this.textKlijentOib.TabIndex = 7;
            // 
            // textKlijentZdrastvena
            // 
            this.textKlijentZdrastvena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKlijentZdrastvena.Location = new System.Drawing.Point(513, 74);
            this.textKlijentZdrastvena.Name = "textKlijentZdrastvena";
            this.textKlijentZdrastvena.ReadOnly = true;
            this.textKlijentZdrastvena.Size = new System.Drawing.Size(198, 26);
            this.textKlijentZdrastvena.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReceptaDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumIstekaDataGridViewTextBoxColumn,
            this.datumPodizanjaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hzzoReceptBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 168);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(544, 124);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseUp);
            // 
            // idReceptaDataGridViewTextBoxColumn
            // 
            this.idReceptaDataGridViewTextBoxColumn.DataPropertyName = "idRecepta";
            this.idReceptaDataGridViewTextBoxColumn.HeaderText = "ID recepta";
            this.idReceptaDataGridViewTextBoxColumn.Name = "idReceptaDataGridViewTextBoxColumn";
            this.idReceptaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            this.datumIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "datumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            this.datumPocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIstekaDataGridViewTextBoxColumn
            // 
            this.datumIstekaDataGridViewTextBoxColumn.DataPropertyName = "datumIsteka";
            this.datumIstekaDataGridViewTextBoxColumn.HeaderText = "Datum isteka";
            this.datumIstekaDataGridViewTextBoxColumn.Name = "datumIstekaDataGridViewTextBoxColumn";
            this.datumIstekaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumPodizanjaDataGridViewTextBoxColumn
            // 
            this.datumPodizanjaDataGridViewTextBoxColumn.DataPropertyName = "datumPodizanja";
            this.datumPodizanjaDataGridViewTextBoxColumn.HeaderText = "Datum podizanja";
            this.datumPodizanjaDataGridViewTextBoxColumn.Name = "datumPodizanjaDataGridViewTextBoxColumn";
            this.datumPodizanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hzzoReceptBindingSource
            // 
            this.hzzoReceptBindingSource.DataMember = "hzzoRecept";
            this.hzzoReceptBindingSource.DataSource = this.hzzoDBDataSet;
            // 
            // hzzoDBDataSet
            // 
            this.hzzoDBDataSet.DataSetName = "HzzoDBDataSet";
            this.hzzoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hzzoLijekoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(591, 168);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(262, 124);
            this.dataGridView1.TabIndex = 10;
            // 
            // serijskiBrojDataGridViewTextBoxColumn1
            // 
            this.serijskiBrojDataGridViewTextBoxColumn1.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn1.HeaderText = "Serijski broj lijeka";
            this.serijskiBrojDataGridViewTextBoxColumn1.Name = "serijskiBrojDataGridViewTextBoxColumn1";
            this.serijskiBrojDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hzzoLijekoviBindingSource
            // 
            this.hzzoLijekoviBindingSource.DataMember = "hzzoLijekovi";
            this.hzzoLijekoviBindingSource.DataSource = this.hzzoDBDataSetBindingSource;
            // 
            // hzzoDBDataSetBindingSource
            // 
            this.hzzoDBDataSetBindingSource.DataSource = this.hzzoDBDataSet;
            this.hzzoDBDataSetBindingSource.Position = 0;
            // 
            // hzzoKlijentBindingSource
            // 
            this.hzzoKlijentBindingSource.DataMember = "hzzoKlijent";
            this.hzzoKlijentBindingSource.DataSource = this.hzzoDBDataSet;
            // 
            // hzzoKlijentTableAdapter
            // 
            this.hzzoKlijentTableAdapter.ClearBeforeFill = true;
            // 
            // hzzoReceptTableAdapter
            // 
            this.hzzoReceptTableAdapter.ClearBeforeFill = true;
            // 
            // hzzoLijekoviTableAdapter
            // 
            this.hzzoLijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(735, 424);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(133, 56);
            this.btnIzdavanjeRacuna.TabIndex = 11;
            this.btnIzdavanjeRacuna.Text = "Izdavanje racuna";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnIzdavanjeRacuna.Click += new System.EventHandler(this.btnIzdavanjeRacuna_Click);
            // 
            // btnProvjeriBrojIzlaz
            // 
            this.btnProvjeriBrojIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProvjeriBrojIzlaz.Location = new System.Drawing.Point(21, 441);
            this.btnProvjeriBrojIzlaz.Name = "btnProvjeriBrojIzlaz";
            this.btnProvjeriBrojIzlaz.Size = new System.Drawing.Size(113, 39);
            this.btnProvjeriBrojIzlaz.TabIndex = 12;
            this.btnProvjeriBrojIzlaz.Text = "Izlaz";
            this.btnProvjeriBrojIzlaz.UseVisualStyleBackColor = true;
            this.btnProvjeriBrojIzlaz.Click += new System.EventHandler(this.btnProvjeriBrojIzlaz_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.lijekoviBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(388, 351);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(323, 129);
            this.dataGridView3.TabIndex = 13;
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            this.serijskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet2BindingSource;
            // 
            // appotekaDBDataSet2BindingSource
            // 
            this.appotekaDBDataSet2BindingSource.DataSource = this.appotekaDBDataSet2;
            this.appotekaDBDataSet2BindingSource.Position = 0;
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
            // btnDodajStavku
            // 
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavku.Location = new System.Drawing.Point(126, 309);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(130, 45);
            this.btnDodajStavku.TabIndex = 14;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "HZZO recepti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(587, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lijekovi na receptu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(384, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recepti u pripremi";
            // 
            // FormHzzoProvjeriBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnProvjeriBrojIzlaz);
            this.Controls.Add(this.btnIzdavanjeRacuna);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textKlijentZdrastvena);
            this.Controls.Add(this.textKlijentOib);
            this.Controls.Add(this.textKlijentPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKlijentIme);
            this.Name = "FormHzzoProvjeriBroj";
            this.Text = "FormHzzoProvjeriBroj";
            this.Load += new System.EventHandler(this.FormHzzoProvjeriBroj_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHzzoProvjeriBroj_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoReceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoLijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HzzoDBDataSet hzzoDBDataSet;
        private System.Windows.Forms.BindingSource hzzoKlijentBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter hzzoKlijentTableAdapter;
        private System.Windows.Forms.TextBox textKlijentIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKlijentPrezime;
        private System.Windows.Forms.TextBox textKlijentOib;
        private System.Windows.Forms.TextBox textKlijentZdrastvena;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hzzoReceptBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoReceptTableAdapter hzzoReceptTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hzzoDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource hzzoLijekoviBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoLijekoviTableAdapter hzzoLijekoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIstekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPodizanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnProvjeriBrojIzlaz;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource appotekaDBDataSet2BindingSource;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}