using CustomMessageBox;
using Guna.UI2.WinForms;
using ProjekBesarPendidikan.Master;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToastNotifications;

namespace ProjekBesarPendidikan{
    public partial class MetodePembayaran : Form {
        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        public MetodePembayaran(DashboardAdmin dashboardAdmin) {
            admin = dashboardAdmin;
            InitializeComponent();
        }

        private void Produk_EnabledChanged(object sender, EventArgs e) {
            LoadData();
        }
        private void Produk_Load(object sender, EventArgs e) {

        }

        private void autoId() {
        }


        private void ShowFormInPanel(Form form) {
            admin.pnl_filForm.Controls.Clear();
            admin.pnl_filForm.Tag = null;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            admin.pnl_filForm.Controls.Add(form);
            admin.pnl_filForm.Tag = form;
            form.Show();
            form.Enabled = true;
        }

        private void LoadData(string search = null, string status = null, string sortColumn = "mpb_id", string sortOrder = "ASC") {
            using (SqlConnection conn = new SqlConnection(Connection)) {
                try {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("rps_getListMetodePembayaran", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                        cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv_MetodePembayaran.DataSource = dt;

                        // Add buttons column only once
                        // Add buttons only if they don't exist
                        dgv_MetodePembayaran.CellClick += dgv_MetodePembayaran_CellClick;
                        bool editExists = dgv_MetodePembayaran.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Edit");
                        bool deleteExists = dgv_MetodePembayaran.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Delete");

                        if (!editExists) {
                            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                            editButton.Name = "Edit";
                            editButton.HeaderText = "";
                            editButton.Text = "Edit";
                            editButton.UseColumnTextForButtonValue = true;
                            dgv_MetodePembayaran.Columns.Add(editButton);
                        }

                        if (!deleteExists) {
                            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                            deleteButton.Name = "Delete";
                            deleteButton.HeaderText = "";
                            deleteButton.Text = "Delete";
                            deleteButton.UseColumnTextForButtonValue = true;
                            dgv_MetodePembayaran.Columns.Add(deleteButton);
                        }


                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void dgv_MetodePembayaran_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                // Edit Button
                if (dgv_MetodePembayaran.Columns[e.ColumnIndex].Name == "Edit") {
                    int id = Convert.ToInt32(dgv_MetodePembayaran.Rows[e.RowIndex].Cells["mpb_id"].Value);
                    string nama = dgv_MetodePembayaran.Rows[e.RowIndex].Cells["mpb_nama"].Value.ToString();
                    string desc = dgv_MetodePembayaran.Rows[e.RowIndex].Cells["mpb_deskripsi"].Value.ToString();
                    MessageBox.Show(id+nama+desc);
                    ShowFormInPanel(new MetodePembayaranUpdate(admin,id,nama,desc));

                }

                // Delete Button
                else if (dgv_MetodePembayaran.Columns[e.ColumnIndex].Name == "Delete") {
                    string id = dgv_MetodePembayaran.Rows[e.RowIndex].Cells["mpb_id"].Value.ToString();
                    DialogResult confirm = MessageBox.Show("Are you sure to delete ID: " + id + "?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes) {
                        //DeleteData(id);
                        LoadData(); // Refresh table
                    }
                }
            }
        }



        private void filter() {

        }
        private bool isUpdatePosition = false;

      
        private void btn_ExcData_Click(object sender, EventArgs e) {

        }
        public void clear(bool reset = false) {
            autoId();
            isUpdatePosition = false;
            if (reset)LoadData();
        }

        private void btn_Filter_Click(object sender, EventArgs e) {
            timer_filter.Start();
        }

        bool p_filterExpand = false;
        private void timer_filter_Tick(object sender, EventArgs e) {
            if (!p_filterExpand) {
                if (p_Filter.Height < 130) {
                    p_Filter.Height += 12;
                    p_Filter.ShadowDecoration.Enabled = true;
                } else {
                    p_Filter.Height = 130;
                    timer_filter.Stop();
                    p_filterExpand = true;
                }
            } else {
                if (p_Filter.Height > 12) {
                    p_Filter.Height -= 12;
                } else {
                    p_Filter.Height = 12;
                    p_Filter.ShadowDecoration.Enabled = false;
                    timer_filter.Stop();
                    p_filterExpand = false;
                }
            }

        }

        private void txt_Search_Enter(object sender, EventArgs e) {
            filter();
        }

        private void btn_clear_Click(object sender, EventArgs e) {
            cb_SortType.Text = null;
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                if (e.KeyChar != '\b' && e.KeyChar != ' ') {
                    e.Handled = true;
                }
            }
        }

        private void txt_MinPoint_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e) {
            clear();
        }

        private void txt_Search_IconRightClick(object sender, EventArgs e) {
            filter();
        }
        private void txt_KeyPressNomor(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                filter();
            }
        }

        private void btn_add_Click(object sender, EventArgs e) {
            ShowFormInPanel(new MetodePembayaranCreate(admin));
        }
    }
}
