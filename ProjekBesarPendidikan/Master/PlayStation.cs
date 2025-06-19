using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CustomMessageBox;
using System.Windows.Forms.VisualStyles;

namespace ProjekBesarPendidikan.Master
{
    public partial class PlayStation: Form
    {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        private String nameKry;

        public PlayStation(DashboardAdmin dashboardAdmin, String nameKry)
        {
            InitializeComponent();
            admin = dashboardAdmin;
            this.nameKry = nameKry;
            showDgv(null, "aktif", "pst_id", "ASC");
            initComboBoxFilters();
            RefreshFilteredData();
        }

        private void initComboBoxFilters()
        {
            // Status ComboBox
            var statusItems = new Dictionary<string, string>
    {
        { "Aktif", "Aktif" },
        { "Tidak Aktif", "Tidak Aktif" }
    };
            cbSortStatus.DataSource = new BindingSource(statusItems, null);
            cbSortStatus.DisplayMember = "Key";
            cbSortStatus.ValueMember = "Value";
            cbSortStatus.SelectedIndex = 0;

            // Sort Column ComboBox
            var sortColumnItems = new Dictionary<string, string>
    {
        { "ID", "pst_id" },
        { "Merk", "pst_merk" },
        { "Serial Number", "pst_serial_number" },
        { "Status", "pst_status" },
        { "Dibuat Oleh", "pst_created_by" },
        { "Tanggal Dibuat", "pst_created_date" },
        { "Diubah Oleh", "pst_modif_by" },
        { "Tanggal Diubah", "pst_modif_date" }
    };
            cbSortColumn.DataSource = new BindingSource(sortColumnItems, null);
            cbSortColumn.DisplayMember = "Key";
            cbSortColumn.ValueMember = "Value";
            cbSortColumn.SelectedIndex = 0;

            // Sort Order ComboBox
            var sortOrderItems = new Dictionary<string, string>
    {
        { "Naik (A-Z)", "ASC" },
        { "Turun (Z-A)", "DESC" }
    };
            cbSortOrder.DataSource = new BindingSource(sortOrderItems, null);
            cbSortOrder.DisplayMember = "Key";
            cbSortOrder.ValueMember = "Value";
            cbSortOrder.SelectedIndex = 0;
        }

        private void showDgv()
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            SqlDataReader rd;

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            //cmd = new SqlCommand("EXEC dbo.rps_getListPlayStation @search = null, @status = null, @jps_id = null, @sortColumn = 'pst_id', @sortOrder = 'ASC'", connect);
            cmd = new SqlCommand("dbo.rps_getListPlayStation", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dgvPlayStation.DataSource = dt;
            cmd.Parameters.AddWithValue("@search", null);
            cmd.Parameters.AddWithValue("@status", null);
            cmd.Parameters.AddWithValue("@jps_id", null);
            cmd.Parameters.AddWithValue("@sortColumn", "pst_id");
            cmd.Parameters.AddWithValue("@sortOrder", "ASC");

            dgvPlayStation.Columns["No"].HeaderText = "No";
            dgvPlayStation.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_id"].HeaderText = "ID";
            dgvPlayStation.Columns["pst_id"].Visible = false;
            dgvPlayStation.Columns["jps_id"].HeaderText = "ID Jenis";
            dgvPlayStation.Columns["jps_id"].Visible = false;
            dgvPlayStation.Columns["pst_merk"].HeaderText = "Nama";
            dgvPlayStation.Columns["pst_Merk"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_serial_number"].HeaderText = "No. Serial";
            dgvPlayStation.Columns["pst_serial_number"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["jps_nama"].HeaderText = "Jenis";
            dgvPlayStation.Columns["jps_nama"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_harga_per_jam"].HeaderText = "Harga";
            dgvPlayStation.Columns["pst_harga_per_jam"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_harga_per_jam"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlayStation.Columns["pst_status"].HeaderText = "Status";
            dgvPlayStation.Columns["pst_status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_created_date"].HeaderText = "Tanggal Dibuat";
            dgvPlayStation.Columns["pst_created_date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_created_by"].HeaderText = "Dibuat Oleh";
            dgvPlayStation.Columns["pst_created_by"].Visible = false;
            dgvPlayStation.Columns["pst_modif_by"].HeaderText = "Diubah Oleh";
            dgvPlayStation.Columns["pst_modif_by"].Visible = false;
            dgvPlayStation.Columns["pst_modif_date"].HeaderText = "Tanggal Diubah";
            dgvPlayStation.Columns["pst_modif_date"].Visible = false;
            dgvPlayStation.Columns["jps_max_pemain"].HeaderText = "Max Pemain";
            dgvPlayStation.Columns["jps_max_pemain"].Visible = false;

            bool editExists = dgvPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
            bool deleteExists = dgvPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");

            if (!editExists)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dgvPlayStation.Columns.Add(editButton);
            }

            if (!deleteExists)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dgvPlayStation.Columns.Add(deleteButton);
            }
            dgvPlayStation.CellFormatting += DgvPlayStation_CellFormatting;

            dgvPlayStation.Refresh();
            connect.Close();
        }

        private void DgvPlayStation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //string status = dgvPlayStation.Rows[e.RowIndex].Cells["pst_status"].Value?.ToString();

            //if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Edit")
            //{
            //    if (status == "aktif")
            //    {
            //        e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\edit.png");
            //    }
            //    else if (status == "tidak aktif")
            //    {
            //        e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\restore.png");
            //    }

            //    e.FormattingApplied = true;
            //}

            //else if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Delete")
            //{
            //    if (status == "aktif")
            //    {
            //        e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\delete.png");
            //        e.FormattingApplied = true;
            //    }
            //}

            //if (dgvPlayStation.Columns[e.ColumnIndex].Name == "pst_harga_per_jam" && e.Value != null)
            //{
            //    if (decimal.TryParse(e.Value.ToString(), out decimal harga))
            //    {
            //        e.Value = "Rp" + harga.ToString("N2");
            //        e.FormattingApplied = true;
            //    }
            //}

            if (e.RowIndex < 0) return;

            string status = dgvPlayStation.Rows[e.RowIndex].Cells["pst_status"].Value?.ToString()?.ToLower();

            if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (status == "aktif")
                    e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\edit.png");
                else if (status == "tidak aktif")
                    e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\restore.png");

                e.FormattingApplied = true;
            }
            else if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Delete" && status == "aktif")
            {
                e.Value = Image.FromFile("E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\delete.png");
                e.FormattingApplied = true;
            }

            if (dgvPlayStation.Columns[e.ColumnIndex].Name == "pst_harga_per_jam" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal harga))
                {
                    e.Value = "Rp" + harga.ToString("N2");
                    e.FormattingApplied = true;
                }
            }
        }

        //private void showDgv(String search, String sortStatus, String sortColumn, String sortOrder)
        //{
        //    SqlCommand cmd;
        //    SqlDataAdapter da;
        //    DataTable dt;
        //    SqlDataReader rd;

        //    string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
        //    SqlConnection connect = new SqlConnection(connectionString);
        //    connect.Open();

        //    cmd = new SqlCommand("dbo.rps_getListPlayStation", connect);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    // Parameter HARUS ditambahkan sebelum Fill()
        //    cmd.Parameters.AddWithValue("@search", search ?? (object)DBNull.Value);
        //    cmd.Parameters.AddWithValue("@status", sortStatus ?? (object)DBNull.Value);
        //    cmd.Parameters.AddWithValue("@jps_id", DBNull.Value);
        //    cmd.Parameters.AddWithValue("@sortColumn", sortColumn ?? "pst_id");
        //    cmd.Parameters.AddWithValue("@sortOrder", sortOrder ?? "ASC");

        //    da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    dgvPlayStation.DataSource = dt;

        //dgvPlayStation.Columns["No"].HeaderText = "No";
        //    dgvPlayStation.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_id"].HeaderText = "ID";
        //    dgvPlayStation.Columns["pst_id"].Visible = false;
        //    dgvPlayStation.Columns["jps_id"].HeaderText = "ID Jenis";
        //    dgvPlayStation.Columns["jps_id"].Visible = false;
        //    dgvPlayStation.Columns["pst_merk"].HeaderText = "Nama";
        //    dgvPlayStation.Columns["pst_Merk"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_serial_number"].HeaderText = "No. Serial";
        //    dgvPlayStation.Columns["pst_serial_number"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["jps_nama"].HeaderText = "Jenis";
        //    dgvPlayStation.Columns["jps_nama"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_harga_per_jam"].HeaderText = "Harga";
        //    dgvPlayStation.Columns["pst_harga_per_jam"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_harga_per_jam"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //    dgvPlayStation.Columns["pst_status"].HeaderText = "Status";
        //    dgvPlayStation.Columns["pst_status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvPlayStation.Columns["pst_created_date"].HeaderText = "Tanggal Dibuat";
        //    dgvPlayStation.Columns["pst_created_date"].Visible = false;
        //    dgvPlayStation.Columns["pst_created_by"].HeaderText = "Dibuat Oleh";
        //    dgvPlayStation.Columns["pst_created_by"].Visible = false;
        //    dgvPlayStation.Columns["pst_modif_by"].HeaderText = "Diubah Oleh";
        //    dgvPlayStation.Columns["pst_modif_by"].Visible = false;
        //    dgvPlayStation.Columns["pst_modif_date"].HeaderText = "Tanggal Diubah";
        //    dgvPlayStation.Columns["pst_modif_date"].Visible = false;
        //    dgvPlayStation.Columns["jps_max_pemain"].HeaderText = "Max Pemain";
        //    dgvPlayStation.Columns["jps_max_pemain"].Visible = false;


        //    bool deleteExists;
        //    bool editExists = false;

        //    String deletePath = "E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\delete.png";
        //    String editPath = "E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\edit.png";
        //    String restorePath = "E:\\Org\\Himma\\Pemrograman_2_CSharp\\ProjekBesarPendidikan\\Icon\\restore.png";


        //    editExists = dgvPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
        //    deleteExists = dgvPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");

        //    if (sortStatus.Equals("Tidak Aktif"))
        //    {
        //        dgvPlayStation.Columns.Remove("Delete");
        //    }

        //    if (!editExists)
        //    {
        //        DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
        //        editImageColumn.Name = "Edit";
        //        editImageColumn.HeaderText = "";
        //        editImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //        dgvPlayStation.Columns.Add(editImageColumn);
        //    }

        //    if (!deleteExists)
        //    {
        //        DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
        //        deleteImageColumn.Name = "Edit";
        //        deleteImageColumn.HeaderText = "";
        //        deleteImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //        dgvPlayStation.Columns.Add(deleteImageColumn);
        //    }

        //    dgvPlayStation.CellFormatting += DgvPlayStation_CellFormatting;
        //    dgvPlayStation.Refresh();
        //    connect.Close();
        //}

        private void showDgv(string search, string sortStatus, string sortColumn, string sortOrder)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                cmd = new SqlCommand("dbo.rps_getListPlayStation", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@search", string.IsNullOrWhiteSpace(search) ? DBNull.Value : (object)search);
                cmd.Parameters.AddWithValue("@status", string.IsNullOrWhiteSpace(sortStatus) ? DBNull.Value : (object)sortStatus);
                cmd.Parameters.AddWithValue("@jps_id", DBNull.Value);
                cmd.Parameters.AddWithValue("@sortColumn", sortColumn ?? "pst_id");
                cmd.Parameters.AddWithValue("@sortOrder", sortOrder ?? "ASC");

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }

            dgvPlayStation.DataSource = dt;

            // Header & style kolom
            dgvPlayStation.Columns["No"].HeaderText = "No";
            dgvPlayStation.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlayStation.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_id"].HeaderText = "ID";
            dgvPlayStation.Columns["pst_id"].Visible = false;
            dgvPlayStation.Columns["jps_id"].HeaderText = "ID Jenis";
            dgvPlayStation.Columns["jps_id"].Visible = false;
            dgvPlayStation.Columns["pst_merk"].HeaderText = "Nama";
            dgvPlayStation.Columns["pst_Merk"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_serial_number"].HeaderText = "No. Serial";
            dgvPlayStation.Columns["pst_serial_number"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["jps_nama"].HeaderText = "Jenis";
            dgvPlayStation.Columns["jps_nama"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_harga_per_jam"].HeaderText = "Harga";
            dgvPlayStation.Columns["pst_harga_per_jam"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_harga_per_jam"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlayStation.Columns["pst_status"].HeaderText = "Status";
            dgvPlayStation.Columns["pst_status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlayStation.Columns["pst_created_date"].HeaderText = "Tanggal Dibuat";
            dgvPlayStation.Columns["pst_created_date"].Visible = false;
            dgvPlayStation.Columns["pst_created_by"].HeaderText = "Dibuat Oleh";
            dgvPlayStation.Columns["pst_created_by"].Visible = false;
            dgvPlayStation.Columns["pst_modif_by"].HeaderText = "Diubah Oleh";
            dgvPlayStation.Columns["pst_modif_by"].Visible = false;
            dgvPlayStation.Columns["pst_modif_date"].HeaderText = "Tanggal Diubah";
            dgvPlayStation.Columns["pst_modif_date"].Visible = false;
            dgvPlayStation.Columns["jps_max_pemain"].HeaderText = "Max Pemain";
            dgvPlayStation.Columns["jps_max_pemain"].Visible = false;

            // Format kolom
            if (dgvPlayStation.Columns.Count > 0)
            {
                dgvPlayStation.Columns[0].Width = 40;
                dgvPlayStation.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (DataGridViewColumn col in dgvPlayStation.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // Hapus kolom lama jika ada
            if (dgvPlayStation.Columns.Contains("Edit"))
                dgvPlayStation.Columns.Remove("Edit");
            if (dgvPlayStation.Columns.Contains("Delete"))
                dgvPlayStation.Columns.Remove("Delete");

            // Tambahkan kolom gambar
            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Name = "Edit";
            editCol.HeaderText = "";
            editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPlayStation.Columns.Add(editCol);

            if (sortStatus.ToLower() == "aktif")
            {
                DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
                deleteCol.Name = "Delete";
                deleteCol.HeaderText = "";
                deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvPlayStation.Columns.Add(deleteCol);
            }

            // Pasang event handler hanya sekali
            dgvPlayStation.CellFormatting -= DgvPlayStation_CellFormatting;
            dgvPlayStation.CellFormatting += DgvPlayStation_CellFormatting;

            dgvPlayStation.Refresh();
        }



        private void dgvPlayStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvPlayStation.Columns[e.ColumnIndex].Name;
            string status = dgvPlayStation.Rows[e.RowIndex].Cells["pst_status"].Value?.ToString()?.ToLower();

            // Tombol Edit & Restore (satu kolom: "Edit")
            if (columnName == "Edit")
            {
                if (status == "aktif")
                {
                    // Edit data
                    int id = Convert.ToInt32(dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value);
                    int jps_id = Convert.ToInt32(dgvPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value);
                    string merk = dgvPlayStation.Rows[e.RowIndex].Cells["pst_merk"].Value.ToString();
                    string serialNumber = dgvPlayStation.Rows[e.RowIndex].Cells["pst_serial_number"].Value.ToString();
                    Decimal hargaPerJam = Convert.ToDecimal(dgvPlayStation.Rows[e.RowIndex].Cells["pst_harga_per_jam"].Value.ToString());
                    ShowFormInPanel(new PlayStationUpdate(admin, id, jps_id, merk, serialNumber, hargaPerJam));
                }
                else
                {
                    // Restore data
                    string id = dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value.ToString();
                    string nama = dgvPlayStation.Rows[e.RowIndex].Cells["pst_merk"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Apakah kamu yakin ingin pulihkan " + nama, "Validation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        setPlayStationStatus(Convert.ToInt32(id), status);
                        showDgv(null, "aktif", "pst_id", "ASC");
                    }
                }
            }

            // Tombol Delete (berbeda kolom)
            else if (columnName == "Delete")
            {
                if (status != "aktif")
                {
                    return;
                }
                string id = dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value.ToString();
                string nama = dgvPlayStation.Rows[e.RowIndex].Cells["pst_merk"].Value.ToString();

                DialogResult confirm = RJMessageBox.Show("Apakah kamu yakin ingin menghapus " + nama, "Warning", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    setPlayStationStatus(Convert.ToInt32(id), status);
                    showDgv(null, "aktif", "pst_id", "ASC");
                }
            }
        }

        private void setPlayStationStatus(int id, String status)
        {
            try
            {
                string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("rps_setStatusPlayStation", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pst_id", SqlDbType.Int));
                        cmd.Parameters["@pst_id"].Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                if (status == "aktif")
                {
                    RJMessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Data berhasil dipulihkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                RJMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFormInPanel(Form form)
        {
            admin.pnl_filForm.Controls.Clear();
            admin.pnl_filForm.Tag = null;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            admin.pnl_filForm.Controls.Add(form);
            admin.pnl_filForm.Tag = form;
            form.Show();
            form.Enabled = true;
        }
        
        private void btnTambahData_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PlayStationCreate(admin, nameKry));
        }

        private void txtCariPlaystation_TextChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }
        

        bool p_filterExpand = false;
        private void timer_filter_Tick(object sender, EventArgs e)
        {
            if (!p_filterExpand)
            {
                if (p_filter.Height < 285)
                {
                    p_filter.Height += 12;
                    p_filter.ShadowDecoration.Enabled = true;
                }
                else
                {
                    p_filter.Height = 285;
                    timer_filter.Stop();
                    p_filterExpand = true;
                }
            }
            else
            {
                if (p_filter.Height > 12)
                {
                    p_filter.Height -= 12;
                }
                else
                {
                    p_filter.Height = 12;
                    p_filter.ShadowDecoration.Enabled = false;
                    timer_filter.Stop();
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            p_filterExpand = !p_filterExpand;
            timer_filter.Start();
        }

        private void cbSortStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }

        private void cbSortColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }

        private void cbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }

        private void RefreshFilteredData()
        {
            string search = txtCariPlaystation.Text.Trim();
            if (cbSortStatus.SelectedItem == null || cbSortColumn.SelectedItem == null || cbSortOrder.SelectedItem == null)
                return;

            string sortStatus = ((KeyValuePair<string, string>)cbSortStatus.SelectedItem).Value;
            string sortColumn = ((KeyValuePair<string, string>)cbSortColumn.SelectedItem).Value;
            string sortOrder = ((KeyValuePair<string, string>)cbSortOrder.SelectedItem).Value;
            showDgv(search, sortStatus, sortColumn, sortOrder);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            if (cbSortStatus.Items.Count > 0)
                cbSortStatus.SelectedIndex = 0;
            else
                cbSortStatus.SelectedItem = null;

            if (cbSortColumn.Items.Count > 0)
                cbSortColumn.SelectedIndex = 0;
            else
                cbSortColumn.SelectedItem = null;

            if (cbSortOrder.Items.Count > 0)
                cbSortOrder.SelectedIndex = 0;
            else
                cbSortOrder.SelectedItem = null;
        }

        private void dgvPlayStation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Delete")
            {
                string status = dgvPlayStation.Rows[e.RowIndex].Cells["pst_status"].Value?.ToString()?.ToLower();

                if (status != "aktif")
                {
                    // Kosongkan tampilan tombol Edit
                    e.PaintBackground(e.CellBounds, true);
                    e.Handled = true;
                }
            }
        }
    }
}
