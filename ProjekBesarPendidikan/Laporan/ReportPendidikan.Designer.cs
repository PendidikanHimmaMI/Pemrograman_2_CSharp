namespace ProjekBesarPendidikan.Laporan
{
    partial class ReportPendidikan
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
            this.vwlistTransaksiPenyewaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReport = new ProjekBesarPendidikan.dsReport();
            this.vw_listTransaksiPenyewaanTableAdapter = new ProjekBesarPendidikan.dsReportTableAdapters.vw_listTransaksiPenyewaanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwlistTransaksiPenyewaanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwlistTransaksiPenyewaanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjekBesarPendidikan.reportWizardPendidikan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1392, 876);
            this.reportViewer1.TabIndex = 0;
            // 
            // vwlistTransaksiPenyewaanBindingSource
            // 
            this.vwlistTransaksiPenyewaanBindingSource.DataMember = "vw_listTransaksiPenyewaan";
            this.vwlistTransaksiPenyewaanBindingSource.DataSource = this.dsReport;
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.EnforceConstraints = false;
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_listTransaksiPenyewaanTableAdapter
            // 
            this.vw_listTransaksiPenyewaanTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPendidikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 900);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportPendidikan";
            this.Text = "ReportPendidikan";
            this.Load += new System.EventHandler(this.ReportPendidikan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwlistTransaksiPenyewaanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsReport dsReport;
        private System.Windows.Forms.BindingSource vwlistTransaksiPenyewaanBindingSource;
        private dsReportTableAdapters.vw_listTransaksiPenyewaanTableAdapter vw_listTransaksiPenyewaanTableAdapter;
    }
}