using CustomMessageBox;
using Microsoft.IdentityModel.Tokens;
using ProjekBesarPendidikan.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToastNotifications;

namespace ProjekBesarPendidikan
{
    public partial class JenisPlayStation : Form
    {
        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        private String nameKry;
        public JenisPlayStation(DashboardAdmin dashboardAdmin, String nameKry)
        {
            InitializeComponent();
            admin = dashboardAdmin;
            dgv_JenisPlayStation.CellClick += dgv_JenisPlayStation_CellClick;
            this.Name = nameKry;
            var statusItems = new Dictionary<string, string>
            {
                { "Aktif", "Aktif" },
                { "Tidak Aktif", "Tidak Aktif" }
            };

            cb_SortStatus.DataSource = new BindingSource(statusItems, null);
            cb_SortStatus.DisplayMember = "Key";
            cb_SortStatus.ValueMember = "Value";
            cb_SortStatus.SelectedIndex = 0;

            // Sort Column ComboBox using Dictionary as DataSource
            var sortColumnItems = new Dictionary<string, string>
            {
                { "ID", "jps_id" },
                { "Nama", "jps_nama" },
                { "Deskripsi", "jps_deskripsi" },
                { "Status", "jps_status" },
                { "Dibuat Oleh", "jps_created_by" },
                { "Tanggal Dibuat", "jps_created_date" },
                { "Diubah Oleh", "jps_modif_by" },
                { "Tanggal Diubah", "jps_modif_date" }
            };

            cb_SortColumn.DataSource = new BindingSource(sortColumnItems, null);
            cb_SortColumn.DisplayMember = "Key";
            cb_SortColumn.ValueMember = "Value";
            cb_SortColumn.SelectedIndex = 0;

            // Sort Order ComboBox using Dictionary as DataSource
            var sortOrderItems = new Dictionary<string, string>
            {
                { "Naik (A-Z)", "ASC" },
                { "Turun (Z-A)", "DESC" }
            };

            cb_SortOrder.DataSource = new BindingSource(sortOrderItems, null);
            cb_SortOrder.DisplayMember = "Key";
            cb_SortOrder.ValueMember = "Value";
            cb_SortOrder.SelectedIndex = 0;
            LoadData();
        }

        private void Produk_EnabledChanged(object sender, EventArgs e)
        {

            var statusItems = new Dictionary<string, string>
            {
                { "Aktif", "Aktif" },
                { "Tidak Aktif", "Tidak Aktif" }
            };

            cb_SortStatus.DataSource = new BindingSource(statusItems, null);
            cb_SortStatus.DisplayMember = "Key";
            cb_SortStatus.ValueMember = "Value";
            cb_SortStatus.SelectedIndex = 0;

            // Sort Column ComboBox using Dictionary as DataSource
            var sortColumnItems = new Dictionary<string, string>
            {
                { "ID", "jps_id" },
                { "Nama", "jps_nama" },
                { "Deskripsi", "jps_deskripsi" },
                { "Status", "jps_status" },
                { "Dibuat Oleh", "jps_created_by" },
                { "Tanggal Dibuat", "jps_created_date" },
                { "Diubah Oleh", "jps_modif_by" },
                { "Tanggal Diubah", "jps_modif_date" }
            };

            cb_SortColumn.DataSource = new BindingSource(sortColumnItems, null);
            cb_SortColumn.DisplayMember = "Key";
            cb_SortColumn.ValueMember = "Value";
            cb_SortColumn.SelectedIndex = 0;

            // Sort Order ComboBox using Dictionary as DataSource
            var sortOrderItems = new Dictionary<string, string>
            {
                { "Naik (A-Z)", "ASC" },
                { "Turun (Z-A)", "DESC" }
            };

            cb_SortOrder.DataSource = new BindingSource(sortOrderItems, null);
            cb_SortOrder.DisplayMember = "Key";
            cb_SortOrder.ValueMember = "Value";
            cb_SortOrder.SelectedIndex = 0;
            LoadData();
        }

        private void Produk_Load(object sender, EventArgs e)
        {

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

        private void LoadData(string search = null, string status = null, string sortColumn = "jps_id", string sortOrder = "ASC")
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                try
                {
                    // Hapus kolom tombol jika sudah ada
                    if (dgv_JenisPlayStation.Columns.Contains("Edit"))
                        dgv_JenisPlayStation.Columns.Remove("Edit");
                    if (dgv_JenisPlayStation.Columns.Contains("Delete"))
                        dgv_JenisPlayStation.Columns.Remove("Delete");
                    if (dgv_JenisPlayStation.Columns.Contains("Restore"))
                        dgv_JenisPlayStation.Columns.Remove("Restore");

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("rps_getListJenisPlayStation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                        cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv_JenisPlayStation.DataSource = dt;

                        bool editExists = dgv_JenisPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
                        bool deleteExists = dgv_JenisPlayStation.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");
                        dgv_JenisPlayStation.Columns["No"].HeaderText = "No";
                        dgv_JenisPlayStation.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["jps_id"].HeaderText = "ID";
                        dgv_JenisPlayStation.Columns["jps_nama"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["jps_tahun_rilis"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["jps_max_pemain"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["jps_deskripsi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_JenisPlayStation.Columns["jps_status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgv_JenisPlayStation.Columns["jps_id"].Visible = false;
                        dgv_JenisPlayStation.Columns["jps_nama"].HeaderText = "Nama";

                        dgv_JenisPlayStation.Columns["jps_tahun_rilis"].HeaderText = "Tahun Rilis";
                        dgv_JenisPlayStation.Columns["jps_tahun_rilis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgv_JenisPlayStation.Columns["jps_max_pemain"].HeaderText = "Max Pemain";
                        dgv_JenisPlayStation.Columns["jps_max_pemain"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgv_JenisPlayStation.Columns["jps_deskripsi"].HeaderText = "Deskripsi";
                        dgv_JenisPlayStation.Columns["jps_status"].HeaderText = "Status";
                        dgv_JenisPlayStation.Columns["jps_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        dgv_JenisPlayStation.Columns["jps_created_by"].HeaderText = "Dibuat Oleh";
                        dgv_JenisPlayStation.Columns["jps_created_by"].Visible = false;
                        dgv_JenisPlayStation.Columns["jps_created_date"].HeaderText = "Tanggal Dibuat";
                        dgv_JenisPlayStation.Columns["jps_created_date"].Visible = false;
                        dgv_JenisPlayStation.Columns["jps_modif_by"].HeaderText = "Diubah Oleh";
                        dgv_JenisPlayStation.Columns["jps_modif_by"].Visible = false;
                        dgv_JenisPlayStation.Columns["jps_modif_date"].HeaderText = "Tanggal Diubah";
                        dgv_JenisPlayStation.Columns["jps_modif_date"].Visible = false;



                        string editPath = @"D:\KEGIATAN_KULIAH\HIMMA_PENDIDIKAN\PROJEK_KECIL_PENDIDIKAN\Pemrograman_2_CSharp\ProjekBesarPendidikan\Icon\edit.png";
                        Image editIcon = Image.FromFile(editPath);

                        string deletePath = @"D:\KEGIATAN_KULIAH\HIMMA_PENDIDIKAN\PROJEK_KECIL_PENDIDIKAN\Pemrograman_2_CSharp\ProjekBesarPendidikan\Icon\delete.png";
                        Image deleteIcon = Image.FromFile(deletePath);

                        string restorePath = @"D:\KEGIATAN_KULIAH\HIMMA_PENDIDIKAN\PROJEK_KECIL_PENDIDIKAN\Pemrograman_2_CSharp\ProjekBesarPendidikan\Icon\restore.png";
                        Image restoreIcon = Image.FromFile(restorePath);

                        if (status.IsNullOrEmpty())
                        {
                            status = "Aktif";
                        }

                        if (status.Equals("Aktif"))
                        {
                            if (!editExists)
                            {
                                DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
                                editColumn.Name = "Edit";
                                editColumn.HeaderText = "Aksi";
                                editColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                editColumn.Image = editIcon;
                                dgv_JenisPlayStation.Columns.Add(editColumn);
                            }

                            if (!deleteExists)
                            {
                                DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
                                deleteColumn.Name = "Delete";
                                deleteColumn.HeaderText = "";
                                deleteColumn.Image = deleteIcon;
                                dgv_JenisPlayStation.Columns.Add(deleteColumn);
                            }
                            dgv_JenisPlayStation.Columns["Edit"].Width = 25;
                            dgv_JenisPlayStation.Columns["Delete"].Width = 40;

                            dgv_JenisPlayStation.RowTemplate.Height = 40;

                            ((DataGridViewImageColumn)dgv_JenisPlayStation.Columns["Edit"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                            ((DataGridViewImageColumn)dgv_JenisPlayStation.Columns["Delete"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                        else
                        {
                            if (!dgv_JenisPlayStation.Columns.Contains("Restore"))
                            {
                                DataGridViewImageColumn restoreColumn = new DataGridViewImageColumn();
                                {
                                    restoreColumn.Name = "Restore";
                                    restoreColumn.HeaderText = "";
                                    restoreColumn.Image = restoreIcon;
                                    dgv_JenisPlayStation.Columns.Add(restoreColumn);
                                }

                            }
                            dgv_JenisPlayStation.Columns["Restore"].Width = 40;

                            dgv_JenisPlayStation.RowTemplate.Height = 40;

                            ((DataGridViewImageColumn)dgv_JenisPlayStation.Columns["Restore"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void ToggleJenisPlayStationStatus(int id)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("rps_setStatusJenisPlayStation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@jps_id", SqlDbType.Int) { Value = id });

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    RJMessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("General Error: " + ex.Message);
                }
            }
        }


        private void dgv_JenisPlayStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv_JenisPlayStation.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int id = Convert.ToInt32(dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value);
                    string nama = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_nama"].Value.ToString();
                    string desc = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_deskripsi"].Value.ToString();
                    int year = Convert.ToInt32(dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_tahun_rilis"].Value);
                    int max = Convert.ToInt32(dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_max_pemain"].Value);
                    string status = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_status"].Value.ToString();

                    if (status == "Aktif")
                    {
                        ShowFormInPanel(new JenisPlayStationUpdate(admin, id, nama, desc, max, year, nameKry));
                    }
                    else
                    {
                        DialogResult confirm = RJMessageBox.Show("You can`t edit this Jenis Play Station, try to restore it if you want to edit this data", "Warning", MessageBoxButtons.OK);
                    }
                    //this.Hide();
                }

                else if (dgv_JenisPlayStation.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string id = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value.ToString();
                    string nama = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_nama"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Are you sure want to delete " + nama, "Warning", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        ToggleJenisPlayStationStatus(Convert.ToInt32(dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value));
                        LoadData();
                    }
                }
                else if (dgv_JenisPlayStation.Columns[e.ColumnIndex].Name == "Restore")
                {
                    string id = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value.ToString();
                    string nama = dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_nama"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Are you sure want to restore " + nama, "Warning", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        ToggleJenisPlayStationStatus(Convert.ToInt32(dgv_JenisPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value));
                        LoadData();
                    }
                }
            }
        }
        public void clear()
        {
            if (cb_SortStatus.Items.Count > 0)
                cb_SortStatus.SelectedIndex = 0;
            else
                cb_SortStatus.SelectedItem = null;

            if (cb_SortColumn.Items.Count > 0)
                cb_SortColumn.SelectedIndex = 0;
            else
                cb_SortColumn.SelectedItem = null;

            if (cb_SortOrder.Items.Count > 0)
                cb_SortOrder.SelectedIndex = 0;
            else
                cb_SortOrder.SelectedItem = null;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            p_filterExpand = !p_filterExpand;
            timer_filter.Start();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                if (e.KeyChar != '\b' && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_MinPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_Search_IconRightClick(object sender, EventArgs e)
        {
        }
        private void txt_KeyPressNomor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new JenisPlayStationCreate(admin, nameKry));

            this.Hide();
        }

        private void cb_SortStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cb_SortColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cb_SortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string search = txt_Search.Text;

            string status = cb_SortStatus.SelectedItem != null
                ? ((KeyValuePair<string, string>)cb_SortStatus.SelectedItem).Value
                : null;

            string sortColumn = cb_SortColumn.SelectedItem != null
                ? ((KeyValuePair<string, string>)cb_SortColumn.SelectedItem).Value
                : "jps_id";

            string sortOrder = cb_SortOrder.SelectedItem != null
                ? ((KeyValuePair<string, string>)cb_SortOrder.SelectedItem).Value
                : "ASC";

            LoadData(search, status, sortColumn, sortOrder);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Global_MouseDown(object sender, MouseEventArgs e)
        {
            // Convert to form coordinates
            Point clickPoint = this.PointToClient(Cursor.Position);

            if (!p_Filter.Bounds.Contains(clickPoint))
            {
                if (!p_Filter.Bounds.Contains(e.Location))
                {
                    if (p_filterExpand)
                    {
                        timer_filter.Start();
                    }
                }
            }
        }

        private void p_Filter_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadData()
        {
            if (cb_SortColumn.SelectedValue != null && cb_SortOrder.SelectedValue != null)
            {
                // Ambil nilai Value dengan cara aman
                var selectedSortColumn = ((KeyValuePair<string, string>)cb_SortColumn.SelectedItem).Value;
                var selectedSortOrder = ((KeyValuePair<string, string>)cb_SortOrder.SelectedItem).Value;

                LoadData( txt_Search.Text.Trim(), cb_SortStatus.SelectedValue.ToString(), selectedSortColumn, selectedSortOrder);

            }
        }

        bool p_filterExpand = false;
        private void timer_filter_Tick(object sender, EventArgs e)
        {
            if (!p_filterExpand)
            {
                if (p_Filter.Height < 285)
                {
                    p_Filter.Height += 12;
                    p_Filter.ShadowDecoration.Enabled = true;
                }
                else
                {
                    p_Filter.Height = 285;
                    timer_filter.Stop();
                    p_filterExpand = true;
                }
            }
            else
            {
                if (p_Filter.Height > 12)
                {
                    p_Filter.Height -= 12;
                }
                else
                {
                    p_Filter.Height = 12;
                    p_Filter.ShadowDecoration.Enabled = false;
                    timer_filter.Stop();
                }
            }


        }

        private void cb_SortStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();

        }

        private void cb_SortColumn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();

        }

        private void cb_SortOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();

        }

        private void btn_clearF_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void RegisterMouseClickHandlers(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl != p_Filter)
                {
                    ctrl.MouseDown += Global_MouseDown;
                }

                // Recursively register for nested controls
                if (ctrl.HasChildren)
                {
                    RegisterMouseClickHandlers(ctrl);
                }
            }
        }

        private void btn_Filter_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
