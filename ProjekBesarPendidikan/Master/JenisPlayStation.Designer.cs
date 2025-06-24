namespace ProjekBesarPendidikan
{
    partial class JenisPlayStation
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
            this.timer_filter = new System.Windows.Forms.Timer(this.components);
            this.Gpnl_Data = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgv_JenisPlayStation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Filter = new Guna.UI2.WinForms.Guna2Button();
            this.cb_SortColumn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_clearF = new Guna.UI2.WinForms.Guna2Button();
            this.cb_SortOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SortStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_Filter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Gpnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JenisPlayStation)).BeginInit();
            this.p_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_filter
            // 
            this.timer_filter.Interval = 1;
            this.timer_filter.Tick += new System.EventHandler(this.timer_filter_Tick);
            // 
            // Gpnl_Data
            // 
            this.Gpnl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpnl_Data.BackColor = System.Drawing.Color.White;
            this.Gpnl_Data.BorderRadius = 6;
            this.Gpnl_Data.Controls.Add(this.dgv_JenisPlayStation);
            this.Gpnl_Data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.Gpnl_Data.Location = new System.Drawing.Point(16, 198);
            this.Gpnl_Data.Margin = new System.Windows.Forms.Padding(2);
            this.Gpnl_Data.Name = "Gpnl_Data";
            this.Gpnl_Data.Size = new System.Drawing.Size(852, 440);
            this.Gpnl_Data.TabIndex = 1;
            // 
            // dgv_JenisPlayStation
            // 
            this.dgv_JenisPlayStation.AllowUserToAddRows = false;
            this.dgv_JenisPlayStation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_JenisPlayStation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_JenisPlayStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_JenisPlayStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_JenisPlayStation.ColumnHeadersHeight = 20;
            this.dgv_JenisPlayStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_JenisPlayStation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_JenisPlayStation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_JenisPlayStation.Location = new System.Drawing.Point(13, 15);
            this.dgv_JenisPlayStation.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_JenisPlayStation.Name = "dgv_JenisPlayStation";
            this.dgv_JenisPlayStation.ReadOnly = true;
            this.dgv_JenisPlayStation.RowHeadersVisible = false;
            this.dgv_JenisPlayStation.RowHeadersWidth = 51;
            this.dgv_JenisPlayStation.Size = new System.Drawing.Size(826, 410);
            this.dgv_JenisPlayStation.TabIndex = 0;
            this.dgv_JenisPlayStation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_JenisPlayStation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_JenisPlayStation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_JenisPlayStation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_JenisPlayStation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_JenisPlayStation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_JenisPlayStation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_JenisPlayStation.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_JenisPlayStation.ThemeStyle.ReadOnly = true;
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_JenisPlayStation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 4;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2Button1.Location = new System.Drawing.Point(19, 136);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.guna2Button1.Size = new System.Drawing.Size(162, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Tambah Data";
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
            this.txt_Search.Location = new System.Drawing.Point(189, 136);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txt_Search.PlaceholderText = "Cari...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShortcutsEnabled = false;
            this.txt_Search.Size = new System.Drawing.Size(494, 46);
            this.txt_Search.TabIndex = 13;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged_1);
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
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_Filter.Location = new System.Drawing.Point(689, 136);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.Size = new System.Drawing.Size(167, 46);
            this.btn_Filter.TabIndex = 8;
            this.btn_Filter.Text = "Sort && Filter    ";
            this.btn_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.btn_Filter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Filter_MouseClick);
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
            this.cb_SortColumn.Location = new System.Drawing.Point(13, 93);
            this.cb_SortColumn.Margin = new System.Windows.Forms.Padding(2);
            this.cb_SortColumn.Name = "cb_SortColumn";
            this.cb_SortColumn.Size = new System.Drawing.Size(130, 36);
            this.cb_SortColumn.TabIndex = 0;
            this.cb_SortColumn.SelectedIndexChanged += new System.EventHandler(this.cb_SortColumn_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sorting By Column";
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
            this.btn_clearF.Location = new System.Drawing.Point(20, 193);
            this.btn_clearF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearF.Name = "btn_clearF";
            this.btn_clearF.Size = new System.Drawing.Size(118, 27);
            this.btn_clearF.TabIndex = 3;
            this.btn_clearF.Text = "Clear";
            this.btn_clearF.Click += new System.EventHandler(this.btn_clearF_Click);
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
            this.cb_SortOrder.Location = new System.Drawing.Point(13, 153);
            this.cb_SortOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cb_SortOrder.Name = "cb_SortOrder";
            this.cb_SortOrder.Size = new System.Drawing.Size(130, 36);
            this.cb_SortOrder.TabIndex = 4;
            this.cb_SortOrder.SelectedIndexChanged += new System.EventHandler(this.cb_SortOrder_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sorting start";
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
            this.cb_SortStatus.Location = new System.Drawing.Point(13, 34);
            this.cb_SortStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cb_SortStatus.Name = "cb_SortStatus";
            this.cb_SortStatus.Size = new System.Drawing.Size(130, 36);
            this.cb_SortStatus.TabIndex = 6;
            this.cb_SortStatus.SelectedIndexChanged += new System.EventHandler(this.cb_SortStatus_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorting By Status";
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
            this.p_Filter.Location = new System.Drawing.Point(689, 182);
            this.p_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.p_Filter.MaximumSize = new System.Drawing.Size(159, 232);
            this.p_Filter.MinimumSize = new System.Drawing.Size(159, 10);
            this.p_Filter.Name = "p_Filter";
            this.p_Filter.ShadowDecoration.Depth = 15;
            this.p_Filter.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.p_Filter.Size = new System.Drawing.Size(159, 10);
            this.p_Filter.TabIndex = 9;
            this.p_Filter.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Filter_Paint);
            // 
            // JenisPlayStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.p_Filter);
            this.Controls.Add(this.Gpnl_Data);
            this.Controls.Add(this.btn_Filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JenisPlayStation";
            this.Text = "JenisPlayStation";
            this.Load += new System.EventHandler(this.Produk_Load);
            this.Gpnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JenisPlayStation)).EndInit();
            this.p_Filter.ResumeLayout(false);
            this.p_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_filter;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Gpnl_Data;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_JenisPlayStation;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_Filter;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortColumn;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btn_clearF;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortOrder;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_SortStatus;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel p_Filter;
    }
}