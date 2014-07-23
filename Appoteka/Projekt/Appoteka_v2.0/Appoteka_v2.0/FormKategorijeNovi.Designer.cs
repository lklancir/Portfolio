namespace Appoteka_v2._0
{
    partial class FormKategorijeNovi
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
            this.textKategorijaNaziv = new System.Windows.Forms.TextBox();
            this.textKategorijaOpis = new System.Windows.Forms.TextBox();
            this.btnKategorijeNoviSpremi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLadiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladice2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladice2 = new Appoteka_v2._0.ladice2();
            this.btnDodajLadicu = new System.Windows.Forms.Button();
            this.ladiceBS1 = new Appoteka_v2._0.ladiceBS1();
            this.ladiceBS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladiceTableAdapter = new Appoteka_v2._0.ladice2TableAdapters.ladiceTableAdapter();
            this.btnIzbriši = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // textKategorijaNaziv
            // 
            this.textKategorijaNaziv.Location = new System.Drawing.Point(71, 20);
            this.textKategorijaNaziv.Name = "textKategorijaNaziv";
            this.textKategorijaNaziv.Size = new System.Drawing.Size(205, 20);
            this.textKategorijaNaziv.TabIndex = 3;
            // 
            // textKategorijaOpis
            // 
            this.textKategorijaOpis.Location = new System.Drawing.Point(71, 48);
            this.textKategorijaOpis.Multiline = true;
            this.textKategorijaOpis.Name = "textKategorijaOpis";
            this.textKategorijaOpis.Size = new System.Drawing.Size(297, 76);
            this.textKategorijaOpis.TabIndex = 5;
            // 
            // btnKategorijeNoviSpremi
            // 
            this.btnKategorijeNoviSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorijeNoviSpremi.Location = new System.Drawing.Point(293, 279);
            this.btnKategorijeNoviSpremi.Name = "btnKategorijeNoviSpremi";
            this.btnKategorijeNoviSpremi.Size = new System.Drawing.Size(75, 32);
            this.btnKategorijeNoviSpremi.TabIndex = 6;
            this.btnKategorijeNoviSpremi.Text = "Spremi";
            this.btnKategorijeNoviSpremi.UseVisualStyleBackColor = true;
            this.btnKategorijeNoviSpremi.Click += new System.EventHandler(this.btnKategorijeNoviSpremi_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.DataSource = this.ladiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(264, 143);
            this.dataGridView1.TabIndex = 8;
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
            // ladiceBindingSource
            // 
            this.ladiceBindingSource.DataMember = "ladice";
            this.ladiceBindingSource.DataSource = this.ladice2BindingSource;
            // 
            // ladice2BindingSource
            // 
            this.ladice2BindingSource.DataSource = this.ladice2;
            this.ladice2BindingSource.Position = 0;
            // 
            // ladice2
            // 
            this.ladice2.DataSetName = "ladice2";
            this.ladice2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajLadicu
            // 
            this.btnDodajLadicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajLadicu.Location = new System.Drawing.Point(293, 145);
            this.btnDodajLadicu.Name = "btnDodajLadicu";
            this.btnDodajLadicu.Size = new System.Drawing.Size(75, 45);
            this.btnDodajLadicu.TabIndex = 9;
            this.btnDodajLadicu.Text = "Dodaj ladicu";
            this.btnDodajLadicu.UseVisualStyleBackColor = true;
            this.btnDodajLadicu.Click += new System.EventHandler(this.btnDodajLadicu_Click);
            // 
            // ladiceBS1
            // 
            this.ladiceBS1.DataSetName = "ladiceBS1";
            this.ladiceBS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladiceBS1BindingSource
            // 
            this.ladiceBS1BindingSource.DataSource = this.ladiceBS1;
            this.ladiceBS1BindingSource.Position = 0;
            // 
            // ladiceTableAdapter
            // 
            this.ladiceTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbriši.Location = new System.Drawing.Point(293, 196);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(75, 45);
            this.btnIzbriši.TabIndex = 10;
            this.btnIzbriši.Text = "Izbriši ladicu";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // FormKategorijeNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 314);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnDodajLadicu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKategorijeNoviSpremi);
            this.Controls.Add(this.textKategorijaOpis);
            this.Controls.Add(this.textKategorijaNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKategorijeNovi";
            this.Text = "Nova kategorija lijeka";
            this.Activated += new System.EventHandler(this.FormKategorijeNovi_Activated);
            this.Load += new System.EventHandler(this.FormKategorijeNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBS1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKategorijaNaziv;
        private System.Windows.Forms.TextBox textKategorijaOpis;
        private System.Windows.Forms.Button btnKategorijeNoviSpremi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajLadicu;
        private System.Windows.Forms.BindingSource ladiceBS1BindingSource;
        private ladiceBS1 ladiceBS1;
        private System.Windows.Forms.BindingSource ladice2BindingSource;
        private ladice2 ladice2;
        private System.Windows.Forms.BindingSource ladiceBindingSource;
        private ladice2TableAdapters.ladiceTableAdapter ladiceTableAdapter;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLadiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
    }
}