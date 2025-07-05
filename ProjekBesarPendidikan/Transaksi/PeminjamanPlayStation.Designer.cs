namespace ProjekBesarPendidikan.Transaksi
{
    partial class PeminjamanPlayStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeminjamanPlayStation));
            this.flData = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCariPlaystation = new Guna.UI2.WinForms.Guna2TextBox();
            this.p_filter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSortOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSortColumn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Filter = new Guna.UI2.WinForms.Guna2Button();
            this.timer_filter = new System.Windows.Forms.Timer(this.components);
            this.p_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flData
            // 
            this.flData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.flData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flData.AutoScroll = true;
            this.flData.Location = new System.Drawing.Point(0, 93);
            this.flData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flData.Name = "flData";
            this.flData.Size = new System.Drawing.Size(795, 557);
            this.flData.TabIndex = 0;
            // 
            // txtCariPlaystation
            // 
            this.txtCariPlaystation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariPlaystation.BackColor = System.Drawing.Color.Transparent;
            this.txtCariPlaystation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtCariPlaystation.BorderRadius = 16;
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
            this.txtCariPlaystation.Location = new System.Drawing.Point(39, 33);
            this.txtCariPlaystation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCariPlaystation.Name = "txtCariPlaystation";
            this.txtCariPlaystation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.txtCariPlaystation.PlaceholderText = "Cari...";
            this.txtCariPlaystation.SelectedText = "";
            this.txtCariPlaystation.Size = new System.Drawing.Size(438, 35);
            this.txtCariPlaystation.TabIndex = 12;
            this.txtCariPlaystation.Tag = "";
            this.txtCariPlaystation.TextOffset = new System.Drawing.Point(7, 0);
            this.txtCariPlaystation.TextChanged += new System.EventHandler(this.txtCariPlaystation_TextChanged);
            // 
            // p_filter
            // 
            this.p_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_filter.Controls.Add(this.label4);
            this.p_filter.Controls.Add(this.cbSortOrder);
            this.p_filter.Controls.Add(this.btn_clear);
            this.p_filter.Controls.Add(this.label5);
            this.p_filter.Controls.Add(this.cbSortColumn);
            this.p_filter.Location = new System.Drawing.Point(499, 76);
            this.p_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p_filter.MaximumSize = new System.Drawing.Size(188, 232);
            this.p_filter.MinimumSize = new System.Drawing.Size(159, 10);
            this.p_filter.Name = "p_filter";
            this.p_filter.ShadowDecoration.Depth = 15;
            this.p_filter.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.p_filter.Size = new System.Drawing.Size(188, 10);
            this.p_filter.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sorting start";
            // 
            // cbSortOrder
            // 
            this.cbSortOrder.BackColor = System.Drawing.Color.White;
            this.cbSortOrder.BorderColor = System.Drawing.Color.White;
            this.cbSortOrder.BorderRadius = 6;
            this.cbSortOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cbSortOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cbSortOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortOrder.ItemHeight = 30;
            this.cbSortOrder.Location = new System.Drawing.Point(22, 121);
            this.cbSortOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSortOrder.Name = "cbSortOrder";
            this.cbSortOrder.Size = new System.Drawing.Size(136, 36);
            this.cbSortOrder.TabIndex = 4;
            this.cbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbSortOrder_SelectedIndexChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.BorderRadius = 6;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(32, 192);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 27);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sorting By Column";
            // 
            // cbSortColumn
            // 
            this.cbSortColumn.BackColor = System.Drawing.Color.White;
            this.cbSortColumn.BorderColor = System.Drawing.Color.White;
            this.cbSortColumn.BorderRadius = 6;
            this.cbSortColumn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortColumn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cbSortColumn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortColumn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cbSortColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortColumn.ItemHeight = 30;
            this.cbSortColumn.Location = new System.Drawing.Point(21, 46);
            this.cbSortColumn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSortColumn.Name = "cbSortColumn";
            this.cbSortColumn.Size = new System.Drawing.Size(137, 36);
            this.cbSortColumn.TabIndex = 0;
            this.cbSortColumn.SelectedIndexChanged += new System.EventHandler(this.cbSortColumn_SelectedIndexChanged);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.BorderRadius = 15;
            this.btn_Filter.BorderThickness = 2;
            this.btn_Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Filter.FillColor = System.Drawing.Color.White;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_Filter.Location = new System.Drawing.Point(486, 33);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(10)))), ((int)(((byte)(122)))));
            this.btn_Filter.Size = new System.Drawing.Size(156, 37);
            this.btn_Filter.TabIndex = 13;
            this.btn_Filter.Text = "Sort && Filter";
            this.btn_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // timer_filter
            // 
            this.timer_filter.Tick += new System.EventHandler(this.timer_filter_Tick);
            // 
            // PeminjamanPlayStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.p_filter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txtCariPlaystation);
            this.Controls.Add(this.flData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PeminjamanPlayStation";
            this.Text = "Peminjaman PlayStation";
            this.p_filter.ResumeLayout(false);
            this.p_filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flData;
        private Guna.UI2.WinForms.Guna2TextBox txtCariPlaystation;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel p_filter;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortOrder;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortColumn;
        private Guna.UI2.WinForms.Guna2Button btn_Filter;
        private System.Windows.Forms.Timer timer_filter;
    }
}