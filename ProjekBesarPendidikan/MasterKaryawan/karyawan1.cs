using CustomMessageBox;
using Microsoft.IdentityModel.Tokens;
using ProjekBesarPendidikan.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace ProjekBesarPendidikan.MasterKaryawan
{
    public partial class karyawan1 : Form
    {

        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;


        public karyawan1(DashboardAdmin dashboardAdmin)
        {
            admin = dashboardAdmin;
            InitializeComponent();
            MunculDgv("[dbo].[rps_getListKaryawan]", "");
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
                { "ID", "kry_id" },
                { "Nama", "kry_nama" },
                { "Posisi", "kry_posisi" }, // Periksa apakah ada kolom "kry_deskripsi" di tabel karyawan Anda.
                { "Alamat", "kry_alamat" },
                { "No Telepon", "kry_no_hp" },
                { "Email", "kry_email" },
                { "Dibuat Oleh", "kry_created_by" },
                { "Tanggal Dibuat", "kry_created_date" },
                { "Diubah Oleh", "kry_modif_by" },
                { "Tanggal Diubah", "kry_modif_date" }
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

            // Panggil MunculDgv setelah inisialisasi ComboBoxes
            MunculDgv("[dbo].[rps_getListKaryawan]", ""); // Atau panggil ApplyFilters() jika sudah dimodifikasi


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

        private void MunculDgv(string spName, string search, string status = null, string sortColumn = "kry_id", string sortOrder = "ASC")
        {
            // Hapus kolom tombol jika sudah ada
            if (dgv_Karyawan.Columns.Contains("Edit"))
                dgv_Karyawan.Columns.Remove("Edit");
            if (dgv_Karyawan.Columns.Contains("Delete"))
                dgv_Karyawan.Columns.Remove("Delete");
            if (dgv_Karyawan.Columns.Contains("Restore"))
                dgv_Karyawan.Columns.Remove("Restore");

            using (SqlConnection conn = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter jika dibutuhkan oleh stored procedure
                    cmd.Parameters.AddWithValue("@Search", search);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Karyawan");

                        dgv_Karyawan.DataSource = ds;
                        dgv_Karyawan.DataMember = "Karyawan";

                        // Sembunyikan kolom tertentu
                        if (dgv_Karyawan.Columns.Count > 13)
                        {
                            dgv_Karyawan.Columns[1].Visible = false;
                            dgv_Karyawan.Columns[9].Visible = false;
                            dgv_Karyawan.Columns[10].Visible = false;
                            dgv_Karyawan.Columns[11].Visible = false;
                            dgv_Karyawan.Columns[12].Visible = false;
                            dgv_Karyawan.Columns[13].Visible = false;
                        }

                        // Ganti header kolom
                        if (dgv_Karyawan.Columns.Count > 8)
                        {
                            dgv_Karyawan.Columns[2].HeaderText = "Nama Karyawan";
                            dgv_Karyawan.Columns[3].HeaderText = "Posisi";
                            dgv_Karyawan.Columns[4].HeaderText = "Alamat";
                            dgv_Karyawan.Columns[5].HeaderText = "No Telepon";
                            dgv_Karyawan.Columns[6].HeaderText = "Email";
                            dgv_Karyawan.Columns[7].HeaderText = "Status";
                            dgv_Karyawan.Columns[8].HeaderText = "User Name";
                        }

                        // Format kolom
                        if (dgv_Karyawan.Columns.Count > 0)
                        {
                            dgv_Karyawan.Columns[0].Width = 40;
                            dgv_Karyawan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            foreach (DataGridViewColumn col in dgv_Karyawan.Columns)
                            {
                                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            }
                        }

                        dgv_Karyawan.Refresh();
                    }
                }
            }
            if (status.IsNullOrEmpty())
            {
                status = "Aktif";
            }
                if (status.Equals("Aktif"))
            {
                // Tambahkan kolom tombol Edit dan Delete jika belum ada
                if (!dgv_Karyawan.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dgv_Karyawan.Columns.Add(editButton);
                }

                if (!dgv_Karyawan.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dgv_Karyawan.Columns.Add(deleteButton);
                }
            }else
            {
               
                if (!dgv_Karyawan.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                    {
                        Name = "Restore",
                        HeaderText = "",
                        Text = "Restore",
                        UseColumnTextForButtonValue = true
                    };
                    dgv_Karyawan.Columns.Add(deleteButton);
                }
            }
        }


        public karyawan1()
        {
            InitializeComponent();
        }

        private void dgv_Karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Karyawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Edit Button
                if (dgv_Karyawan.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int id = Convert.ToInt32(dgv_Karyawan.Rows[e.RowIndex].Cells["kry_id"].Value);
                    string nama = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_nama"].Value.ToString();
                    string posisi = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_posisi"].Value.ToString();
                    string alamat = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_alamat"].Value.ToString();
                    string no_hp = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_no_hp"].Value.ToString();
                    string email = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_email"].Value.ToString();
                    string username = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_username"].Value.ToString();
                    string password = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_password"].Value.ToString();
                    ShowFormInPanel(new KaryawanUpdate(admin, id, nama, posisi, alamat, no_hp, email, username, password));

                }

                // Delete Button
                else if (dgv_Karyawan.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dgv_Karyawan.Rows[e.RowIndex].Cells["kry_id"].Value);
                    string nama = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_nama"].Value.ToString();
                    string posisi = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_posisi"].Value.ToString();
                    string alamat = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_alamat"].Value.ToString();
                    string no_hp = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_email"].Value.ToString();
                    string email = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_no_hp"].Value.ToString();
                    string username = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_username"].Value.ToString();
                    string password = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_password"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Are you sure want to delete " + nama, "Warning", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        ToggleKaryawan(Convert.ToInt32(dgv_Karyawan.Rows[e.RowIndex].Cells["kry_id"].Value));
                        MunculDgv("[dbo].[rps_getListKaryawan]", ""); // Refresh table
                    }
                }

                // Delete Button
                else if (dgv_Karyawan.Columns[e.ColumnIndex].Name == "Restore")
                {
                    int id = Convert.ToInt32(dgv_Karyawan.Rows[e.RowIndex].Cells["kry_id"].Value);
                    string nama = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_nama"].Value.ToString();
                    string posisi = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_posisi"].Value.ToString();
                    string alamat = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_alamat"].Value.ToString();
                    string no_hp = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_email"].Value.ToString();
                    string email = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_no_hp"].Value.ToString();
                    string username = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_username"].Value.ToString();
                    string password = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_password"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Are you sure want to Restore " + nama, "Warning", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        ToggleKaryawan(Convert.ToInt32(dgv_Karyawan.Rows[e.RowIndex].Cells["kry_id"].Value));
                        MunculDgv("[dbo].[rps_getListKaryawan]", ""); // Refresh table
                    }
                }
            }
        }

        //unutuk melakukan penghapusan merubah status
        private void ToggleKaryawan(int id)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("rps_setStatusKaryawan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameter with explicit type
                        cmd.Parameters.Add(new SqlParameter("@kry_id", SqlDbType.Int) { Value = id });

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new KaryawanCreate(admin));
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            timer_filter.Start();
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
                    p_filterExpand = false;
                }
            }

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
                : "kry_id";

            string sortOrder = cb_SortOrder.SelectedItem != null
                ? ((KeyValuePair<string, string>)cb_SortOrder.SelectedItem).Value
                : "ASC";

            //LoadData(search, status, sortColumn, sortOrder);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the click is outside the panel
            if (!p_Filter.Bounds.Contains(e.Location))
            {
                if (p_filterExpand)
                {
                    timer_filter.Start();
                }
            }
            MessageBox.Show("Clicked outside the panel!");
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

        private void cb_SortStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cb_SortColumn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }


        private void cb_SortOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            if (cb_SortColumn.SelectedValue != null && cb_SortOrder.SelectedValue != null)
            {
                // Ambil nilai Value dengan cara aman
                var selectedSortColumn = ((KeyValuePair<string, string>)cb_SortColumn.SelectedItem).Value;
                var selectedSortOrder = ((KeyValuePair<string, string>)cb_SortOrder.SelectedItem).Value;

                MunculDgv("rps_getListKaryawan", txt_Search.Text.Trim(), cb_SortStatus.SelectedValue.ToString(), selectedSortColumn, selectedSortOrder);

            }
        }

        private void btn_Filter_Click_1(object sender, EventArgs e)
        {
            timer_filter.Start();
        }

        private void timer_filter_Tick_1(object sender, EventArgs e)
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
                    p_filterExpand = false;
                }
            }

        }

        private void cb_SortStatus_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cb_SortStatus_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cb_SortColumn_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            LoadData();

        }

        private void cb_SortOrder_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btn_clearF_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void p_Filter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}