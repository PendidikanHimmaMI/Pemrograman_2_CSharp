namespace ProjekBesarPendidikan.Transaksi
{
    partial class KeranjangPeminjaman
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAtas = new System.Windows.Forms.Panel();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblKeranjang = new System.Windows.Forms.Label();
            this.pnlPembayaran = new System.Windows.Forms.Panel();
            this.pnlTengah = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBawah = new System.Windows.Forms.Panel();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.txtKembalian = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTunai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMetodePembayaran = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaPelanggan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlAtas.SuspendLayout();
            this.pnlPembayaran.SuspendLayout();
            this.pnlBawah.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlAtas);
            this.flowLayoutPanel1.Controls.Add(this.pnlPembayaran);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 1163);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlAtas
            // 
            this.pnlAtas.Controls.Add(this.guna2Shapes2);
            this.pnlAtas.Controls.Add(this.lblKeranjang);
            this.pnlAtas.Location = new System.Drawing.Point(3, 3);
            this.pnlAtas.Name = "pnlAtas";
            this.pnlAtas.Size = new System.Drawing.Size(576, 179);
            this.pnlAtas.TabIndex = 0;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.guna2Shapes2.FillColor = System.Drawing.Color.White;
            this.guna2Shapes2.Location = new System.Drawing.Point(-239, 146);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(922, 17);
            this.guna2Shapes2.TabIndex = 10;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 80;
            // 
            // lblKeranjang
            // 
            this.lblKeranjang.AutoSize = true;
            this.lblKeranjang.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeranjang.ForeColor = System.Drawing.Color.White;
            this.lblKeranjang.Location = new System.Drawing.Point(126, 30);
            this.lblKeranjang.Name = "lblKeranjang";
            this.lblKeranjang.Size = new System.Drawing.Size(258, 65);
            this.lblKeranjang.TabIndex = 9;
            this.lblKeranjang.Text = "Keranjang";
            this.lblKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPembayaran
            // 
            this.pnlPembayaran.Controls.Add(this.pnlTengah);
            this.pnlPembayaran.Controls.Add(this.pnlBawah);
            this.pnlPembayaran.Location = new System.Drawing.Point(3, 188);
            this.pnlPembayaran.Name = "pnlPembayaran";
            this.pnlPembayaran.Size = new System.Drawing.Size(626, 972);
            this.pnlPembayaran.TabIndex = 1;
            // 
            // pnlTengah
            // 
            this.pnlTengah.AutoScroll = true;
            this.pnlTengah.Location = new System.Drawing.Point(3, 3);
            this.pnlTengah.Name = "pnlTengah";
            this.pnlTengah.Size = new System.Drawing.Size(572, 316);
            this.pnlTengah.TabIndex = 1;
            // 
            // pnlBawah
            // 
            this.pnlBawah.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBawah.Controls.Add(this.btnBayar);
            this.pnlBawah.Controls.Add(this.txtKembalian);
            this.pnlBawah.Controls.Add(this.label4);
            this.pnlBawah.Controls.Add(this.txtTunai);
            this.pnlBawah.Controls.Add(this.label3);
            this.pnlBawah.Controls.Add(this.cbMetodePembayaran);
            this.pnlBawah.Controls.Add(this.label1);
            this.pnlBawah.Controls.Add(this.txtNamaPelanggan);
            this.pnlBawah.Controls.Add(this.txtNoTelp);
            this.pnlBawah.Controls.Add(this.lblTotalBayar);
            this.pnlBawah.Controls.Add(this.label2);
            this.pnlBawah.Controls.Add(this.guna2Shapes1);
            this.pnlBawah.Location = new System.Drawing.Point(-1, 250);
            this.pnlBawah.Name = "pnlBawah";
            this.pnlBawah.Size = new System.Drawing.Size(579, 687);
            this.pnlBawah.TabIndex = 0;
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBayar.AutoRoundedCorners = true;
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBayar.FillColor = System.Drawing.Color.White;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btnBayar.Location = new System.Drawing.Point(170, 556);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(243, 48);
            this.btnBayar.TabIndex = 37;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // txtKembalian
            // 
            this.txtKembalian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKembalian.AutoRoundedCorners = true;
            this.txtKembalian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKembalian.DefaultText = "";
            this.txtKembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKembalian.Enabled = false;
            this.txtKembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKembalian.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembalian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtKembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKembalian.Location = new System.Drawing.Point(159, 465);
            this.txtKembalian.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKembalian.PlaceholderText = "Rp. 0.000,00";
            this.txtKembalian.SelectedText = "";
            this.txtKembalian.Size = new System.Drawing.Size(415, 45);
            this.txtKembalian.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kembalian";
            // 
            // txtTunai
            // 
            this.txtTunai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTunai.AutoRoundedCorners = true;
            this.txtTunai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTunai.DefaultText = "";
            this.txtTunai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTunai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTunai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTunai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtTunai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunai.Location = new System.Drawing.Point(159, 397);
            this.txtTunai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTunai.Name = "txtTunai";
            this.txtTunai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTunai.PlaceholderText = "Rp. 0.000,00";
            this.txtTunai.SelectedText = "";
            this.txtTunai.Size = new System.Drawing.Size(415, 45);
            this.txtTunai.TabIndex = 32;
            this.txtTunai.TextChanged += new System.EventHandler(this.txtTunai_TextChanged);
            this.txtTunai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTunai_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tunai";
            // 
            // cbMetodePembayaran
            // 
            this.cbMetodePembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMetodePembayaran.AutoRoundedCorners = true;
            this.cbMetodePembayaran.BackColor = System.Drawing.Color.Transparent;
            this.cbMetodePembayaran.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodePembayaran.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMetodePembayaran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMetodePembayaran.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cbMetodePembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.cbMetodePembayaran.ItemHeight = 30;
            this.cbMetodePembayaran.Location = new System.Drawing.Point(328, 324);
            this.cbMetodePembayaran.Name = "cbMetodePembayaran";
            this.cbMetodePembayaran.Size = new System.Drawing.Size(246, 36);
            this.cbMetodePembayaran.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Metode Pembayaran :";
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaPelanggan.AutoRoundedCorners = true;
            this.txtNamaPelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPelanggan.DefaultText = "";
            this.txtNamaPelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaPelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaPelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtNamaPelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPelanggan.Location = new System.Drawing.Point(18, 250);
            this.txtNamaPelanggan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNamaPelanggan.MaxLength = 100;
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNamaPelanggan.PlaceholderText = "Nama Pelanggan";
            this.txtNamaPelanggan.SelectedText = "";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(556, 45);
            this.txtNamaPelanggan.TabIndex = 28;
            this.txtNamaPelanggan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaPelanggan_KeyPress);
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoTelp.AutoRoundedCorners = true;
            this.txtNoTelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoTelp.DefaultText = "";
            this.txtNoTelp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoTelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoTelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoTelp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoTelp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoTelp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtNoTelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoTelp.Location = new System.Drawing.Point(18, 184);
            this.txtNoTelp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNoTelp.MaxLength = 100;
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNoTelp.PlaceholderText = "Nomor Telepon";
            this.txtNoTelp.SelectedText = "";
            this.txtNoTelp.Size = new System.Drawing.Size(556, 45);
            this.txtNoTelp.TabIndex = 27;
            this.txtNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTelp_KeyPress);
            this.txtNoTelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNoTelp_MouseClick);
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.ForeColor = System.Drawing.Color.White;
            this.lblTotalBayar.Location = new System.Drawing.Point(404, 129);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBayar.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Bayar :";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(-180, 75);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(849, 17);
            this.guna2Shapes1.TabIndex = 24;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // KeranjangPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "KeranjangPeminjaman";
            this.Size = new System.Drawing.Size(582, 1163);
            this.Load += new System.EventHandler(this.KeranjangPeminjaman_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlAtas.ResumeLayout(false);
            this.pnlAtas.PerformLayout();
            this.pnlPembayaran.ResumeLayout(false);
            this.pnlBawah.ResumeLayout(false);
            this.pnlBawah.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlAtas;
        private System.Windows.Forms.Label lblKeranjang;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private System.Windows.Forms.Panel pnlPembayaran;
        private System.Windows.Forms.Panel pnlBawah;
        private Guna.UI2.WinForms.Guna2TextBox txtKembalian;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTunai;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbMetodePembayaran;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaPelanggan;
        private Guna.UI2.WinForms.Guna2TextBox txtNoTelp;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private System.Windows.Forms.FlowLayoutPanel pnlTengah;
    }
}
