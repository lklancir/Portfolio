﻿namespace Appoteka_v2._0
{
    partial class ReportDobavljaci
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.dobavljaciTableAdapter1 = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dobavljaciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Appoteka_v2._0.ReportDobavljaci.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1017, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobavljaciTableAdapter1
            // 
            this.dobavljaciTableAdapter1.ClearBeforeFill = true;
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
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 395);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDobavljaci";
            this.Text = "ReportDobavljaci";
            this.Load += new System.EventHandler(this.ReportDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter1;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter;
    }
}