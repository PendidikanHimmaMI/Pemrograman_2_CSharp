using CustomMessageBox;
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
    public partial class karyawan1: Form
    {

        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;


        public karyawan1(DashboardAdmin dashboardAdmin)
        {
            admin = dashboardAdmin;
            InitializeComponent();
            MunculDgv("exec[dbo].[rps_getListKaryawan]");
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

        private void MunculDgv(String comend)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;

            // 1. Hapus kolom Edit dan Delete dulu (jika ada)
            if (dgv_Karyawan.Columns.Contains("Edit"))
                dgv_Karyawan.Columns.Remove("Edit");

            if (dgv_Karyawan.Columns.Contains("Delete"))
                dgv_Karyawan.Columns.Remove("Delete");


            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            cmd = new SqlCommand(comend, conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Karyawan");
            dgv_Karyawan.DataSource = ds;
            dgv_Karyawan.DataMember = "Karyawan";   

            //melakukan penyembunyian data
            dgv_Karyawan.Columns[1].Visible = false; // Menyembunyikan kolom 1
            dgv_Karyawan.Columns[9].Visible = false; // Menyembunyikan kolom 9
            dgv_Karyawan.Columns[10].Visible = false; // Menyembunyikan kolom 10
            dgv_Karyawan.Columns[11].Visible = false; // Menyembunyikan kolom 11
            dgv_Karyawan.Columns[12].Visible = false; // Menyembunyikan kolom 12
            dgv_Karyawan.Columns[13].Visible = false; // Menyembunyikan kolom 13

            ////melakukan penamaan data
            dgv_Karyawan.Columns[2].HeaderText = "Nama Karyawan";
            dgv_Karyawan.Columns[3].HeaderText = "Posisi";
            dgv_Karyawan.Columns[4].HeaderText = "Alamat";
            dgv_Karyawan.Columns[5].HeaderText = "No Telepone";
            dgv_Karyawan.Columns[6].HeaderText = "Email";
            dgv_Karyawan.Columns[7].HeaderText = "Status";
            dgv_Karyawan.Columns[8].HeaderText = "User Name";

            //melakukan penjarakan antar data
            dgv_Karyawan.Columns[0].Width = 40;

            //mengatur agar rata tengah
            dgv_Karyawan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgv_Karyawan.Refresh();
            conn.Close();

            // Add buttons column only once
            // Add buttons only if they don't exist
            bool editExists = dgv_Karyawan.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
            bool deleteExists = dgv_Karyawan.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");

            //menambahkan sebuah button
            if (!editExists)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dgv_Karyawan.Columns.Add(editButton);
            }

            if (!deleteExists)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dgv_Karyawan.Columns.Add(deleteButton);
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
                    string no_hp = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_email"].Value.ToString();
                    string email = dgv_Karyawan.Rows[e.RowIndex].Cells["kry_no_hp"].Value.ToString();
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
                        MunculDgv("exec[dbo].[rps_getListKaryawan]"); // Refresh table
                    }
                }
            }
        }

        private void LoadData(string search = null, string status = null, string sortColumn = "mpb_id", string sortOrder = "ASC")
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("rps_getListMetodePembayaran", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                        cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv_Karyawan.DataSource = dt;

                        // Add buttons column only once
                        // Add buttons only if they don't exist
                        bool editExists = dgv_Karyawan.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
                        bool deleteExists = dgv_Karyawan.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");
                        dgv_Karyawan.Columns["No"].HeaderText = "No";
                        dgv_Karyawan.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_Karyawan.Columns["mpb_id"].HeaderText = "ID";
                        dgv_Karyawan.Columns["mpb_id"].Visible = false;
                        dgv_Karyawan.Columns["mpb_nama"].HeaderText = "Nama";
                        dgv_Karyawan.Columns["mpb_deskripsi"].HeaderText = "Deskripsi";
                        dgv_Karyawan.Columns["mpb_status"].HeaderText = "Status";
                        dgv_Karyawan.Columns["mpb_created_by"].HeaderText = "Dibuat Oleh";
                        dgv_Karyawan.Columns["mpb_created_date"].HeaderText = "Tanggal Dibuat";
                        dgv_Karyawan.Columns["mpb_modif_by"].HeaderText = "Diubah Oleh";
                        dgv_Karyawan.Columns["mpb_modif_by"].Visible = false;
                        dgv_Karyawan.Columns["mpb_modif_date"].HeaderText = "Tanggal Diubah";
                        dgv_Karyawan.Columns["mpb_modif_date"].Visible = false;

                        if (!editExists)
                        {
                            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                            editButton.Name = "Edit";
                            editButton.HeaderText = "";
                            editButton.Text = "Edit";
                            editButton.UseColumnTextForButtonValue = true;
                            dgv_Karyawan.Columns.Add(editButton);
                        }

                        if (!deleteExists)
                        {
                            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                            deleteButton.Name = "Delete";
                            deleteButton.HeaderText = "";
                            deleteButton.Text = "Delete";
                            deleteButton.UseColumnTextForButtonValue = true;
                            dgv_Karyawan.Columns.Add(deleteButton);
                        }

                        dgv_Karyawan.CellFormatting += DgvKaryawan_CellFormatting;

                    }
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void DgvKaryawan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Karyawan.Columns[e.ColumnIndex].Name == "Delete")
            {
                string status = dgv_Karyawan.Rows[e.RowIndex].Cells["mpb_status"].Value?.ToString();
                if (status != null && status.ToLower() == "aktif")
                {
                    e.Value = "Delete";
                }
                else
                {
                    e.Value = "restore";
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
            MunculDgv("exec [dbo].[rps_getListKaryawan] @search = '" + txt_Search.Text + "'");
        }

        //---------------------------------------------------------------
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
                : "mpb_id";

            string sortOrder = cb_SortOrder.SelectedItem != null
                ? ((KeyValuePair<string, string>)cb_SortOrder.SelectedItem).Value
                : "ASC";

            LoadData(search, status, sortColumn, sortOrder);
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

        private void Gpnl_Data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_filter_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
