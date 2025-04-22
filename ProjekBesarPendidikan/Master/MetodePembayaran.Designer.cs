using System.Threading;
using System;
using System.Windows.Forms;

namespace ProjekBesarPendidikan {
    partial class MetodePembayaran {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.p_Filter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_clearF = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_SortType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Filter = new Guna.UI2.WinForms.Guna2Button();
            this.Gpnl_Data = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgv_MetodePembayaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timer_filter = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.p_Filter.SuspendLayout();
            this.Gpnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MetodePembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txt_Search.BorderRadius = 20;
            this.txt_Search.BorderThickness = 4;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txt_Search.IconRightSize = new System.Drawing.Size(30, 30);
            this.txt_Search.Location = new System.Drawing.Point(210, 38);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txt_Search.PlaceholderText = "Cari...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShortcutsEnabled = false;
            this.txt_Search.Size = new System.Drawing.Size(730, 46);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.IconRightClick += new System.EventHandler(this.txt_Search_IconRightClick);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_add);
            this.guna2CustomGradientPanel1.Controls.Add(this.p_Filter);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_Filter);
            this.guna2CustomGradientPanel1.Controls.Add(this.Gpnl_Data);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_Search);
            this.guna2CustomGradientPanel1.CustomizableEdges.BottomLeft = false;
            this.guna2CustomGradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(7, 100);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1180, 678);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_add.BorderRadius = 20;
            this.btn_add.BorderThickness = 4;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_add.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_add.Location = new System.Drawing.Point(22, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_add.Size = new System.Drawing.Size(180, 46);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Tambah Data";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // p_Filter
            // 
            this.p_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Filter.Controls.Add(this.btn_clearF);
            this.p_Filter.Controls.Add(this.label13);
            this.p_Filter.Controls.Add(this.cb_SortType);
            this.p_Filter.Location = new System.Drawing.Point(933, 89);
            this.p_Filter.MaximumSize = new System.Drawing.Size(212, 130);
            this.p_Filter.MinimumSize = new System.Drawing.Size(212, 12);
            this.p_Filter.Name = "p_Filter";
            this.p_Filter.ShadowDecoration.Depth = 15;
            this.p_Filter.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.p_Filter.Size = new System.Drawing.Size(212, 12);
            this.p_Filter.TabIndex = 9;
            // 
            // btn_clearF
            // 
            this.btn_clearF.BackColor = System.Drawing.Color.White;
            this.btn_clearF.BorderRadius = 6;
            this.btn_clearF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clearF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clearF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btn_clearF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearF.ForeColor = System.Drawing.Color.White;
            this.btn_clearF.Location = new System.Drawing.Point(26, 87);
            this.btn_clearF.Name = "btn_clearF";
            this.btn_clearF.Size = new System.Drawing.Size(158, 33);
            this.btn_clearF.TabIndex = 3;
            this.btn_clearF.Text = "Clear";
            this.btn_clearF.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sorting By Type";
            // 
            // cb_SortType
            // 
            this.cb_SortType.BackColor = System.Drawing.Color.White;
            this.cb_SortType.BorderColor = System.Drawing.Color.White;
            this.cb_SortType.BorderRadius = 6;
            this.cb_SortType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(203)))));
            this.cb_SortType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_SortType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_SortType.ItemHeight = 30;
            this.cb_SortType.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Min Point"});
            this.cb_SortType.Location = new System.Drawing.Point(26, 42);
            this.cb_SortType.Name = "cb_SortType";
            this.cb_SortType.Size = new System.Drawing.Size(158, 36);
            this.cb_SortType.TabIndex = 0;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.BorderRadius = 20;
            this.btn_Filter.BorderThickness = 4;
            this.btn_Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Filter.FillColor = System.Drawing.Color.White;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_Filter.Location = new System.Drawing.Point(948, 38);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.Size = new System.Drawing.Size(197, 46);
            this.btn_Filter.TabIndex = 8;
            this.btn_Filter.Text = "Sort & Filter";
            this.btn_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // Gpnl_Data
            // 
            this.Gpnl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpnl_Data.BackColor = System.Drawing.Color.White;
            this.Gpnl_Data.BorderRadius = 6;
            this.Gpnl_Data.Controls.Add(this.dgv_MetodePembayaran);
            this.Gpnl_Data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.Location = new System.Drawing.Point(22, 116);
            this.Gpnl_Data.Name = "Gpnl_Data";
            this.Gpnl_Data.Size = new System.Drawing.Size(1142, 546);
            this.Gpnl_Data.TabIndex = 1;
            // 
            // dgv_MetodePembayaran
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_MetodePembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MetodePembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MetodePembayaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MetodePembayaran.ColumnHeadersHeight = 4;
            this.dgv_MetodePembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MetodePembayaran.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_MetodePembayaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_MetodePembayaran.Location = new System.Drawing.Point(17, 15);
            this.dgv_MetodePembayaran.Name = "dgv_MetodePembayaran";
            this.dgv_MetodePembayaran.RowHeadersVisible = false;
            this.dgv_MetodePembayaran.Size = new System.Drawing.Size(1106, 515);
            this.dgv_MetodePembayaran.TabIndex = 0;
            this.dgv_MetodePembayaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_MetodePembayaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_MetodePembayaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_MetodePembayaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_MetodePembayaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_MetodePembayaran.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_MetodePembayaran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_MetodePembayaran.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_MetodePembayaran.ThemeStyle.ReadOnly = false;
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_MetodePembayaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // timer_filter
            // 
            this.timer_filter.Interval = 1;
            this.timer_filter.Tick += new System.EventHandler(this.timer_filter_Tick);
            // 
            // MetodePembayaranCreate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetodePembayaranCreate";
            this.Text = "Produk";
            this.Load += new System.EventHandler(this.Produk_Load);
            this.EnabledChanged += new System.EventHandler(this.Produk_EnabledChanged);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.p_Filter.ResumeLayout(false);
            this.p_Filter.PerformLayout();
            this.Gpnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MetodePembayaran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel p_Filter;
        private Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortType;
        private Guna.UI2.WinForms.Guna2Button btn_Filter;
        private System.Windows.Forms.Timer timer_filter;
        private Guna.UI2.WinForms.Guna2Button btn_clearF;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Gpnl_Data;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_MetodePembayaran;
    }
}