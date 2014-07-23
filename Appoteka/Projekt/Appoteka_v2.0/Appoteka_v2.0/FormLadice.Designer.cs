namespace Appoteka_v2._0
{
    partial class FormLadice
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
            this.ladiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.ladiceTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.ladiceTableAdapter();
            this.btnLadiceNatrag = new System.Windows.Forms.Button();
            this.btnLadiceNovi = new System.Windows.Forms.Button();
            this.btnLadiceIzmijeni = new System.Windows.Forms.Button();
            this.btnLadiceIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).BeginInit();
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
            this.idLadiceDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ladiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(291, 165);
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
            // ladiceBindingSource
            // 
            this.ladiceBindingSource.DataMember = "ladice";
            this.ladiceBindingSource.DataSource = this.appotekaDBDataSet2BindingSource;
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
            // ladiceTableAdapter
            // 
            this.ladiceTableAdapter.ClearBeforeFill = true;
            // 
            // btnLadiceNatrag
            // 
            this.btnLadiceNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLadiceNatrag.Location = new System.Drawing.Point(21, 206);
            this.btnLadiceNatrag.Name = "btnLadiceNatrag";
            this.btnLadiceNatrag.Size = new System.Drawing.Size(82, 34);
            this.btnLadiceNatrag.TabIndex = 1;
            this.btnLadiceNatrag.Text = "Natrag";
            this.btnLadiceNatrag.UseVisualStyleBackColor = true;
            this.btnLadiceNatrag.Click += new System.EventHandler(this.btnLadiceNatrag_Click);
            // 
            // btnLadiceNovi
            // 
            this.btnLadiceNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLadiceNovi.Location = new System.Drawing.Point(331, 26);
            this.btnLadiceNovi.Name = "btnLadiceNovi";
            this.btnLadiceNovi.Size = new System.Drawing.Size(75, 53);
            this.btnLadiceNovi.TabIndex = 2;
            this.btnLadiceNovi.Text = "Nova ladica";
            this.btnLadiceNovi.UseVisualStyleBackColor = true;
            this.btnLadiceNovi.Click += new System.EventHandler(this.btnLadiceNovi_Click);
            // 
            // btnLadiceIzmijeni
            // 
            this.btnLadiceIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLadiceIzmijeni.Location = new System.Drawing.Point(331, 82);
            this.btnLadiceIzmijeni.Name = "btnLadiceIzmijeni";
            this.btnLadiceIzmijeni.Size = new System.Drawing.Size(75, 53);
            this.btnLadiceIzmijeni.TabIndex = 3;
            this.btnLadiceIzmijeni.Text = "Izmijeni ladicu";
            this.btnLadiceIzmijeni.UseVisualStyleBackColor = true;
            this.btnLadiceIzmijeni.Click += new System.EventHandler(this.btnLadiceIzmijeni_Click);
            // 
            // btnLadiceIzbrisi
            // 
            this.btnLadiceIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLadiceIzbrisi.Location = new System.Drawing.Point(331, 138);
            this.btnLadiceIzbrisi.Name = "btnLadiceIzbrisi";
            this.btnLadiceIzbrisi.Size = new System.Drawing.Size(75, 53);
            this.btnLadiceIzbrisi.TabIndex = 4;
            this.btnLadiceIzbrisi.Text = "Izbriši ladicu";
            this.btnLadiceIzbrisi.UseVisualStyleBackColor = true;
            this.btnLadiceIzbrisi.Click += new System.EventHandler(this.btnLadiceIzbrisi_Click);
            // 
            // FormLadice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 256);
            this.Controls.Add(this.btnLadiceIzbrisi);
            this.Controls.Add(this.btnLadiceIzmijeni);
            this.Controls.Add(this.btnLadiceNovi);
            this.Controls.Add(this.btnLadiceNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLadice";
            this.Text = "Ladice";
            this.Load += new System.EventHandler(this.FormLadice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appotekaDBDataSet2BindingSource;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource ladiceBindingSource;
        private appotekaDBDataSet2TableAdapters.ladiceTableAdapter ladiceTableAdapter;
        private System.Windows.Forms.Button btnLadiceNatrag;
        private System.Windows.Forms.Button btnLadiceNovi;
        private System.Windows.Forms.Button btnLadiceIzmijeni;
        private System.Windows.Forms.Button btnLadiceIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLadiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
    }
}