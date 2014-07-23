namespace Appoteka_v2._0
{
    partial class FormLijekoviNovi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLijekoviNoviSpremi = new System.Windows.Forms.Button();
            this.btnLijekoviNoviIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSerijskiBroj = new System.Windows.Forms.TextBox();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.textProizvodac = new System.Windows.Forms.TextBox();
            this.textCijenaKupovna = new System.Windows.Forms.TextBox();
            this.textCijenaProdajna = new System.Windows.Forms.TextBox();
            this.textDopunsko = new System.Windows.Forms.TextBox();
            this.textKolicina = new System.Windows.Forms.TextBox();
            this.dateRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzbrisiKategoriju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLijekoviNoviSpremi
            // 
            this.btnLijekoviNoviSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekoviNoviSpremi.Location = new System.Drawing.Point(447, 321);
            this.btnLijekoviNoviSpremi.Name = "btnLijekoviNoviSpremi";
            this.btnLijekoviNoviSpremi.Size = new System.Drawing.Size(87, 37);
            this.btnLijekoviNoviSpremi.TabIndex = 0;
            this.btnLijekoviNoviSpremi.Text = "Završi";
            this.btnLijekoviNoviSpremi.UseVisualStyleBackColor = true;
            this.btnLijekoviNoviSpremi.Click += new System.EventHandler(this.btnLijekoviNoviSpremi_Click);
            // 
            // btnLijekoviNoviIzlaz
            // 
            this.btnLijekoviNoviIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijekoviNoviIzlaz.Location = new System.Drawing.Point(29, 321);
            this.btnLijekoviNoviIzlaz.Name = "btnLijekoviNoviIzlaz";
            this.btnLijekoviNoviIzlaz.Size = new System.Drawing.Size(84, 37);
            this.btnLijekoviNoviIzlaz.TabIndex = 1;
            this.btnLijekoviNoviIzlaz.Text = "Odustani";
            this.btnLijekoviNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnLijekoviNoviIzlaz.Click += new System.EventHandler(this.btnLijekoviNoviIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serijski broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proizvođač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(276, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cijena kupovna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(276, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cijena prodajna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(276, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rok trajanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Količina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(276, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dopunsko (%)";
            // 
            // textSerijskiBroj
            // 
            this.textSerijskiBroj.Location = new System.Drawing.Point(110, 28);
            this.textSerijskiBroj.Name = "textSerijskiBroj";
            this.textSerijskiBroj.Size = new System.Drawing.Size(138, 20);
            this.textSerijskiBroj.TabIndex = 12;
            this.textSerijskiBroj.Leave += new System.EventHandler(this.textSerijskiBroj_Leave);
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(110, 59);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(138, 20);
            this.textNaziv.TabIndex = 13;
            // 
            // textProizvodac
            // 
            this.textProizvodac.Location = new System.Drawing.Point(110, 92);
            this.textProizvodac.Name = "textProizvodac";
            this.textProizvodac.Size = new System.Drawing.Size(138, 20);
            this.textProizvodac.TabIndex = 14;
            // 
            // textCijenaKupovna
            // 
            this.textCijenaKupovna.Location = new System.Drawing.Point(396, 59);
            this.textCijenaKupovna.Name = "textCijenaKupovna";
            this.textCijenaKupovna.Size = new System.Drawing.Size(126, 20);
            this.textCijenaKupovna.TabIndex = 15;
            this.textCijenaKupovna.Leave += new System.EventHandler(this.textCijenaKupovna_Leave);
            // 
            // textCijenaProdajna
            // 
            this.textCijenaProdajna.Location = new System.Drawing.Point(396, 93);
            this.textCijenaProdajna.Name = "textCijenaProdajna";
            this.textCijenaProdajna.Size = new System.Drawing.Size(126, 20);
            this.textCijenaProdajna.TabIndex = 16;
            this.textCijenaProdajna.Leave += new System.EventHandler(this.textCijenaProdajna_Leave);
            // 
            // textDopunsko
            // 
            this.textDopunsko.Location = new System.Drawing.Point(396, 124);
            this.textDopunsko.Name = "textDopunsko";
            this.textDopunsko.Size = new System.Drawing.Size(126, 20);
            this.textDopunsko.TabIndex = 18;
            this.textDopunsko.Leave += new System.EventHandler(this.textDopunsko_Leave);
            // 
            // textKolicina
            // 
            this.textKolicina.Location = new System.Drawing.Point(110, 123);
            this.textKolicina.Name = "textKolicina";
            this.textKolicina.Size = new System.Drawing.Size(138, 20);
            this.textKolicina.TabIndex = 17;
            this.textKolicina.Leave += new System.EventHandler(this.textKolicina_Leave);
            // 
            // dateRokTrajanja
            // 
            this.dateRokTrajanja.Location = new System.Drawing.Point(396, 26);
            this.dateRokTrajanja.Name = "dateRokTrajanja";
            this.dateRokTrajanja.Size = new System.Drawing.Size(126, 20);
            this.dateRokTrajanja.TabIndex = 21;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.kategorijeLijekovaBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(29, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Size = new System.Drawing.Size(219, 100);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdKategorije";
            this.Column1.HeaderText = "Id kategorije";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(304, 186);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(75, 46);
            this.btnDodajKategoriju.TabIndex = 23;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(28, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kategorije";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(338, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Osvježi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzbrisiKategoriju
            // 
            this.btnIzbrisiKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiKategoriju.Location = new System.Drawing.Point(304, 240);
            this.btnIzbrisiKategoriju.Name = "btnIzbrisiKategoriju";
            this.btnIzbrisiKategoriju.Size = new System.Drawing.Size(75, 46);
            this.btnIzbrisiKategoriju.TabIndex = 26;
            this.btnIzbrisiKategoriju.Text = "Izbriši kategoriju";
            this.btnIzbrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnIzbrisiKategoriju.Click += new System.EventHandler(this.btnIzbrisiKategoriju_Click);
            // 
            // FormLijekoviNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 370);
            this.Controls.Add(this.btnIzbrisiKategoriju);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateRokTrajanja);
            this.Controls.Add(this.textDopunsko);
            this.Controls.Add(this.textKolicina);
            this.Controls.Add(this.textCijenaProdajna);
            this.Controls.Add(this.textCijenaKupovna);
            this.Controls.Add(this.textProizvodac);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.textSerijskiBroj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLijekoviNoviIzlaz);
            this.Controls.Add(this.btnLijekoviNoviSpremi);
            this.Name = "FormLijekoviNovi";
            this.Text = "Novi lijek";
            this.Activated += new System.EventHandler(this.FormLijekoviNovi_Activated);
            this.Load += new System.EventHandler(this.FormLijekoviNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLijekoviNoviSpremi;
        private System.Windows.Forms.Button btnLijekoviNoviIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSerijskiBroj;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.TextBox textProizvodac;
        private System.Windows.Forms.TextBox textCijenaKupovna;
        private System.Windows.Forms.TextBox textCijenaProdajna;
        private System.Windows.Forms.TextBox textDopunsko;
        private System.Windows.Forms.TextBox textKolicina;
        private System.Windows.Forms.DateTimePicker dateRokTrajanja;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnIzbrisiKategoriju;
    }
}