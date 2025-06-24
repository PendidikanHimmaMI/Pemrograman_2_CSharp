namespace ProjekBesarPendidikan.Laporan
{
    partial class LaporanTrs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.exportPDF = new Guna.UI2.WinForms.Guna2Button();
            this.db_RentalPlayStationDataSet1 = new ProjekBesarPendidikan.Db_RentalPlayStationDataSet1();
            this.dbRentalPlayStationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_RentalPlayStationDataSet2 = new ProjekBesarPendidikan.Db_RentalPlayStationDataSet2();
            this.rpstrpenyewaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rps_trpenyewaanTableAdapter = new ProjekBesarPendidikan.Db_RentalPlayStationDataSet2TableAdapters.rps_trpenyewaanTableAdapter();
            this.db_RentalPlayStationDataSet3 = new ProjekBesarPendidikan.Db_RentalPlayStationDataSet3();
            this.vwlistTransaksiPenyewaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_listTransaksiPenyewaanTableAdapter = new ProjekBesarPendidikan.Db_RentalPlayStationDataSet3TableAdapters.vw_listTransaksiPenyewaanTableAdapter();
            this.ppstanggaltransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpb_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppsnamapenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppsnohppenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppstotalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRentalPlayStationDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstrpenyewaanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwlistTransaksiPenyewaanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ppstanggaltransaksiDataGridViewTextBoxColumn,
            this.mpb_nama,
            this.ppsnamapenyewaDataGridViewTextBoxColumn,
            this.ppsnohppenyewaDataGridViewTextBoxColumn,
            this.ppstotalhargaDataGridViewTextBoxColumn});
            this.dgvReport.DataSource = this.vwlistTransaksiPenyewaanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReport.Location = new System.Drawing.Point(1, 104);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Size = new System.Drawing.Size(798, 347);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvReport.ThemeStyle.ReadOnly = false;
            this.dgvReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReport.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // exportPDF
            // 
            this.exportPDF.BorderRadius = 20;
            this.exportPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exportPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.exportPDF.ForeColor = System.Drawing.Color.White;
            this.exportPDF.Location = new System.Drawing.Point(594, 30);
            this.exportPDF.Name = "exportPDF";
            this.exportPDF.Size = new System.Drawing.Size(180, 45);
            this.exportPDF.TabIndex = 1;
            this.exportPDF.Text = "Export to PDF";
            this.exportPDF.Click += new System.EventHandler(this.exportPDF_Click);
            // 
            // db_RentalPlayStationDataSet1
            // 
            this.db_RentalPlayStationDataSet1.DataSetName = "Db_RentalPlayStationDataSet1";
            this.db_RentalPlayStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbRentalPlayStationDataSet1BindingSource
            // 
            this.dbRentalPlayStationDataSet1BindingSource.DataSource = this.db_RentalPlayStationDataSet1;
            this.dbRentalPlayStationDataSet1BindingSource.Position = 0;
            // 
            // db_RentalPlayStationDataSet2
            // 
            this.db_RentalPlayStationDataSet2.DataSetName = "Db_RentalPlayStationDataSet2";
            this.db_RentalPlayStationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpstrpenyewaanBindingSource
            // 
            this.rpstrpenyewaanBindingSource.DataMember = "rps_trpenyewaan";
            this.rpstrpenyewaanBindingSource.DataSource = this.db_RentalPlayStationDataSet2;
            // 
            // rps_trpenyewaanTableAdapter
            // 
            this.rps_trpenyewaanTableAdapter.ClearBeforeFill = true;
            // 
            // db_RentalPlayStationDataSet3
            // 
            this.db_RentalPlayStationDataSet3.DataSetName = "Db_RentalPlayStationDataSet3";
            this.db_RentalPlayStationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwlistTransaksiPenyewaanBindingSource
            // 
            this.vwlistTransaksiPenyewaanBindingSource.DataMember = "vw_listTransaksiPenyewaan";
            this.vwlistTransaksiPenyewaanBindingSource.DataSource = this.db_RentalPlayStationDataSet3;
            // 
            // vw_listTransaksiPenyewaanTableAdapter
            // 
            this.vw_listTransaksiPenyewaanTableAdapter.ClearBeforeFill = true;
            // 
            // ppstanggaltransaksiDataGridViewTextBoxColumn
            // 
            this.ppstanggaltransaksiDataGridViewTextBoxColumn.DataPropertyName = "pps_tanggal_transaksi";
            this.ppstanggaltransaksiDataGridViewTextBoxColumn.HeaderText = "pps_tanggal_transaksi";
            this.ppstanggaltransaksiDataGridViewTextBoxColumn.Name = "ppstanggaltransaksiDataGridViewTextBoxColumn";
            // 
            // mpb_nama
            // 
            this.mpb_nama.DataPropertyName = "mpb_nama";
            this.mpb_nama.HeaderText = "mpb_nama";
            this.mpb_nama.Name = "mpb_nama";
            // 
            // ppsnamapenyewaDataGridViewTextBoxColumn
            // 
            this.ppsnamapenyewaDataGridViewTextBoxColumn.DataPropertyName = "pps_nama_penyewa";
            this.ppsnamapenyewaDataGridViewTextBoxColumn.HeaderText = "pps_nama_penyewa";
            this.ppsnamapenyewaDataGridViewTextBoxColumn.Name = "ppsnamapenyewaDataGridViewTextBoxColumn";
            // 
            // ppsnohppenyewaDataGridViewTextBoxColumn
            // 
            this.ppsnohppenyewaDataGridViewTextBoxColumn.DataPropertyName = "pps_no_hp_penyewa";
            this.ppsnohppenyewaDataGridViewTextBoxColumn.HeaderText = "pps_no_hp_penyewa";
            this.ppsnohppenyewaDataGridViewTextBoxColumn.Name = "ppsnohppenyewaDataGridViewTextBoxColumn";
            // 
            // ppstotalhargaDataGridViewTextBoxColumn
            // 
            this.ppstotalhargaDataGridViewTextBoxColumn.DataPropertyName = "pps_total_harga";
            this.ppstotalhargaDataGridViewTextBoxColumn.HeaderText = "pps_total_harga";
            this.ppstotalhargaDataGridViewTextBoxColumn.Name = "ppstotalhargaDataGridViewTextBoxColumn";
            // 
            // Laporan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportPDF);
            this.Controls.Add(this.dgvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRentalPlayStationDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstrpenyewaanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RentalPlayStationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwlistTransaksiPenyewaanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvReport;
        private System.Windows.Forms.BindingSource dbRentalPlayStationDataSet1BindingSource;
        private Db_RentalPlayStationDataSet1 db_RentalPlayStationDataSet1;
        private Guna.UI2.WinForms.Guna2Button exportPDF;
        private Db_RentalPlayStationDataSet2 db_RentalPlayStationDataSet2;
        private System.Windows.Forms.BindingSource rpstrpenyewaanBindingSource;
        private Db_RentalPlayStationDataSet2TableAdapters.rps_trpenyewaanTableAdapter rps_trpenyewaanTableAdapter;
        private Db_RentalPlayStationDataSet3 db_RentalPlayStationDataSet3;
        private System.Windows.Forms.BindingSource vwlistTransaksiPenyewaanBindingSource;
        private Db_RentalPlayStationDataSet3TableAdapters.vw_listTransaksiPenyewaanTableAdapter vw_listTransaksiPenyewaanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppstanggaltransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpb_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppsnamapenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppsnohppenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppstotalhargaDataGridViewTextBoxColumn;
    }
}