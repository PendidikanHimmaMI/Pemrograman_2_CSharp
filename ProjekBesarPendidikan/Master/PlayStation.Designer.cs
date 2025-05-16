namespace ProjekBesarPendidikan.Master
{
    partial class PlayStation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayStation));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.p_Filter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_SortStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SortOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_clearF = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_SortColumn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Gpnl_Data = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgvPlayStation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTambahData = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariPlaystation = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.p_Filter.SuspendLayout();
            this.Gpnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayStation)).BeginInit();
            this.SuspendLayout();
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
            this.guna2CustomGradientPanel1.Controls.Add(this.txtCariPlaystation);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTambahData);
            this.guna2CustomGradientPanel1.Controls.Add(this.p_Filter);
            this.guna2CustomGradientPanel1.Controls.Add(this.Gpnl_Data);
            this.guna2CustomGradientPanel1.CustomizableEdges.BottomLeft = false;
            this.guna2CustomGradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(10, 101);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1180, 678);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // p_Filter
            // 
            this.p_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Filter.Controls.Add(this.label2);
            this.p_Filter.Controls.Add(this.cb_SortStatus);
            this.p_Filter.Controls.Add(this.label1);
            this.p_Filter.Controls.Add(this.cb_SortOrder);
            this.p_Filter.Controls.Add(this.btn_clearF);
            this.p_Filter.Controls.Add(this.label13);
            this.p_Filter.Controls.Add(this.cb_SortColumn);
            this.p_Filter.Location = new System.Drawing.Point(933, 89);
            this.p_Filter.MaximumSize = new System.Drawing.Size(212, 285);
            this.p_Filter.MinimumSize = new System.Drawing.Size(212, 12);
            this.p_Filter.Name = "p_Filter";
            this.p_Filter.ShadowDecoration.Depth = 15;
            this.p_Filter.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.p_Filter.Size = new System.Drawing.Size(212, 12);
            this.p_Filter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorting By Status";
            // 
            // cb_SortStatus
            // 
            this.cb_SortStatus.BackColor = System.Drawing.Color.White;
            this.cb_SortStatus.BorderColor = System.Drawing.Color.White;
            this.cb_SortStatus.BorderRadius = 6;
            this.cb_SortStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SortStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cb_SortStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_SortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_SortStatus.ItemHeight = 30;
            this.cb_SortStatus.Location = new System.Drawing.Point(29, 42);
            this.cb_SortStatus.Name = "cb_SortStatus";
            this.cb_SortStatus.Size = new System.Drawing.Size(158, 36);
            this.cb_SortStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sorting start";
            // 
            // cb_SortOrder
            // 
            this.cb_SortOrder.BackColor = System.Drawing.Color.White;
            this.cb_SortOrder.BorderColor = System.Drawing.Color.White;
            this.cb_SortOrder.BorderRadius = 6;
            this.cb_SortOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cb_SortOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_SortOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_SortOrder.ItemHeight = 30;
            this.cb_SortOrder.Location = new System.Drawing.Point(29, 190);
            this.cb_SortOrder.Name = "cb_SortOrder";
            this.cb_SortOrder.Size = new System.Drawing.Size(158, 36);
            this.cb_SortOrder.TabIndex = 4;
            // 
            // btn_clearF
            // 
            this.btn_clearF.BackColor = System.Drawing.Color.White;
            this.btn_clearF.BorderRadius = 6;
            this.btn_clearF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clearF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clearF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_clearF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearF.ForeColor = System.Drawing.Color.White;
            this.btn_clearF.Location = new System.Drawing.Point(28, 237);
            this.btn_clearF.Name = "btn_clearF";
            this.btn_clearF.Size = new System.Drawing.Size(158, 33);
            this.btn_clearF.TabIndex = 3;
            this.btn_clearF.Text = "Clear";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sorting By Column";
            // 
            // cb_SortColumn
            // 
            this.cb_SortColumn.BackColor = System.Drawing.Color.White;
            this.cb_SortColumn.BorderColor = System.Drawing.Color.White;
            this.cb_SortColumn.BorderRadius = 6;
            this.cb_SortColumn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SortColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortColumn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cb_SortColumn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortColumn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_SortColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_SortColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_SortColumn.ItemHeight = 30;
            this.cb_SortColumn.Location = new System.Drawing.Point(28, 116);
            this.cb_SortColumn.Name = "cb_SortColumn";
            this.cb_SortColumn.Size = new System.Drawing.Size(158, 36);
            this.cb_SortColumn.TabIndex = 0;
            // 
            // Gpnl_Data
            // 
            this.Gpnl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpnl_Data.BackColor = System.Drawing.Color.White;
            this.Gpnl_Data.BorderRadius = 25;
            this.Gpnl_Data.Controls.Add(this.dgvPlayStation);
            this.Gpnl_Data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.Location = new System.Drawing.Point(22, 116);
            this.Gpnl_Data.Name = "Gpnl_Data";
            this.Gpnl_Data.Size = new System.Drawing.Size(1142, 546);
            this.Gpnl_Data.TabIndex = 1;
            // 
            // dgvPlayStation
            // 
            this.dgvPlayStation.AllowUserToAddRows = false;
            this.dgvPlayStation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPlayStation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayStation.ColumnHeadersHeight = 20;
            this.dgvPlayStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayStation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlayStation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayStation.Location = new System.Drawing.Point(48, 35);
            this.dgvPlayStation.Name = "dgvPlayStation";
            this.dgvPlayStation.ReadOnly = true;
            this.dgvPlayStation.RowHeadersVisible = false;
            this.dgvPlayStation.RowHeadersWidth = 51;
            this.dgvPlayStation.Size = new System.Drawing.Size(1040, 463);
            this.dgvPlayStation.TabIndex = 0;
            this.dgvPlayStation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayStation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayStation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayStation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayStation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayStation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayStation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayStation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayStation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlayStation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayStation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayStation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayStation.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvPlayStation.ThemeStyle.ReadOnly = true;
            this.dgvPlayStation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayStation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayStation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayStation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayStation.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPlayStation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayStation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayStation_CellClick);
            // 
            // btnTambahData
            // 
            this.btnTambahData.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahData.BorderColor = System.Drawing.Color.Transparent;
            this.btnTambahData.BorderRadius = 20;
            this.btnTambahData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btnTambahData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTambahData.ForeColor = System.Drawing.Color.White;
            this.btnTambahData.Location = new System.Drawing.Point(22, 41);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(230, 51);
            this.btnTambahData.TabIndex = 10;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // txtCariPlaystation
            // 
            this.txtCariPlaystation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariPlaystation.BackColor = System.Drawing.Color.Transparent;
            this.txtCariPlaystation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtCariPlaystation.BorderRadius = 19;
            this.txtCariPlaystation.BorderThickness = 2;
            this.txtCariPlaystation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariPlaystation.DefaultText = "";
            this.txtCariPlaystation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariPlaystation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariPlaystation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariPlaystation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariPlaystation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariPlaystation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtCariPlaystation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtCariPlaystation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariPlaystation.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCariPlaystation.IconLeft")));
            this.txtCariPlaystation.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtCariPlaystation.Location = new System.Drawing.Point(274, 41);
            this.txtCariPlaystation.Name = "txtCariPlaystation";
            this.txtCariPlaystation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtCariPlaystation.PlaceholderText = "Cari...";
            this.txtCariPlaystation.SelectedText = "";
            this.txtCariPlaystation.Size = new System.Drawing.Size(596, 51);
            this.txtCariPlaystation.TabIndex = 11;
            this.txtCariPlaystation.Tag = "";
            this.txtCariPlaystation.TextOffset = new System.Drawing.Point(7, 0);
            this.txtCariPlaystation.TextChanged += new System.EventHandler(this.txtCariPlaystation_TextChanged);
            // 
            // PlayStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayStation";
            this.Text = "PlayStation";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.p_Filter.ResumeLayout(false);
            this.p_Filter.PerformLayout();
            this.Gpnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel p_Filter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortStatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortOrder;
        private Guna.UI2.WinForms.Guna2Button btn_clearF;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortColumn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Gpnl_Data;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayStation;
        private Guna.UI2.WinForms.Guna2Button btnTambahData;
        private Guna.UI2.WinForms.Guna2TextBox txtCariPlaystation;
    }
}