namespace MuhasebeProjesi
{
    partial class Form10
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
            this.muhasebeDataSet1 = new MuhasebeProjesi.muhasebeDataSet1();
            this.senetvecekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senetvecekTableAdapter = new MuhasebeProjesi.muhasebeDataSet1TableAdapters.senetvecekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senetvecekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.senetvecekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MuhasebeProjesi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // muhasebeDataSet1
            // 
            this.muhasebeDataSet1.DataSetName = "muhasebeDataSet1";
            this.muhasebeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // senetvecekBindingSource
            // 
            this.senetvecekBindingSource.DataMember = "senetvecek";
            this.senetvecekBindingSource.DataSource = this.muhasebeDataSet1;
            // 
            // senetvecekTableAdapter
            // 
            this.senetvecekTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 373);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senetvecekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource senetvecekBindingSource;
        private muhasebeDataSet1 muhasebeDataSet1;
        private muhasebeDataSet1TableAdapters.senetvecekTableAdapter senetvecekTableAdapter;
    }
}