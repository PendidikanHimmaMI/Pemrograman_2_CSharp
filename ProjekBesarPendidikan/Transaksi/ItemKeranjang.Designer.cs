namespace ProjekBesarPendidikan.Transaksi
{
    partial class ItemKeranjang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpJamSelesai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpJamMulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamaPlayStation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtpJamSelesai);
            this.panel1.Controls.Add(this.dtpJamMulai);
            this.panel1.Controls.Add(this.lblHarga);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNamaPlayStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 246);
            this.panel1.TabIndex = 1;
            // 
            // dtpJamSelesai
            // 
            this.dtpJamSelesai.AutoRoundedCorners = true;
            this.dtpJamSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamSelesai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamSelesai.Checked = true;
            this.dtpJamSelesai.CustomFormat = "HH:mm";
            this.dtpJamSelesai.FillColor = System.Drawing.Color.White;
            this.dtpJamSelesai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpJamSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJamSelesai.Location = new System.Drawing.Point(322, 120);
            this.dtpJamSelesai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpJamSelesai.MinDate = new System.DateTime(2025, 5, 27, 0, 0, 0, 0);
            this.dtpJamSelesai.Name = "dtpJamSelesai";
            this.dtpJamSelesai.ShowUpDown = true;
            this.dtpJamSelesai.Size = new System.Drawing.Size(169, 37);
            this.dtpJamSelesai.TabIndex = 15;
            this.dtpJamSelesai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpJamSelesai.Value = new System.DateTime(2025, 5, 27, 0, 0, 0, 0);
            this.dtpJamSelesai.ValueChanged += new System.EventHandler(this.dtpJamSelesai_ValueChanged);
            // 
            // dtpJamMulai
            // 
            this.dtpJamMulai.AutoRoundedCorners = true;
            this.dtpJamMulai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamMulai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamMulai.Checked = true;
            this.dtpJamMulai.CustomFormat = "HH:mm";
            this.dtpJamMulai.FillColor = System.Drawing.Color.White;
            this.dtpJamMulai.FocusedColor = System.Drawing.Color.White;
            this.dtpJamMulai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpJamMulai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.dtpJamMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJamMulai.Location = new System.Drawing.Point(31, 120);
            this.dtpJamMulai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpJamMulai.MinDate = new System.DateTime(2025, 5, 27, 0, 0, 0, 0);
            this.dtpJamMulai.Name = "dtpJamMulai";
            this.dtpJamMulai.ShowUpDown = true;
            this.dtpJamMulai.Size = new System.Drawing.Size(169, 37);
            this.dtpJamMulai.TabIndex = 14;
            this.dtpJamMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpJamMulai.Value = new System.DateTime(2025, 5, 27, 0, 0, 0, 0);
            this.dtpJamMulai.ValueChanged += new System.EventHandler(this.dtpJamMulai_ValueChanged);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.White;
            this.lblHarga.Location = new System.Drawing.Point(316, 174);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(0, 31);
            this.lblHarga.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Harga :";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.AutoRoundedCorners = true;
            this.btnMin.BorderColor = System.Drawing.Color.Red;
            this.btnMin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMin.FillColor = System.Drawing.Color.Red;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btnMin.Location = new System.Drawing.Point(285, 43);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(47, 28);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "---";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jam Selesai :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jam Mulai :";
            // 
            // lblNamaPlayStation
            // 
            this.lblNamaPlayStation.AutoSize = true;
            this.lblNamaPlayStation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPlayStation.ForeColor = System.Drawing.Color.White;
            this.lblNamaPlayStation.Location = new System.Drawing.Point(26, 40);
            this.lblNamaPlayStation.Name = "lblNamaPlayStation";
            this.lblNamaPlayStation.Size = new System.Drawing.Size(0, 31);
            this.lblNamaPlayStation.TabIndex = 6;
            // 
            // ItemKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Controls.Add(this.panel1);
            this.Name = "ItemKeranjang";
            this.Size = new System.Drawing.Size(534, 246);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamaPlayStation;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpJamMulai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpJamSelesai;
    }
}
