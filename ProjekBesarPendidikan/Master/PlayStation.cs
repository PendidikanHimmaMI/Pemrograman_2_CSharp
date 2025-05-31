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
            showDgv();
        }

        //public PlayStation(DashboardKasir dashboardKasir)
        //{
        //    kasir = dashboardKasir;
        //    InitializeComponent();
        //    showDgv();
        //}

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
            if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Delete")
            {
                string status = dgvPlayStation.Rows[e.RowIndex].Cells["pst_status"].Value?.ToString();
                if (status != null && status.ToLower() == "aktif")
                {
                    e.Value = "Delete"; // Show button
                }
                else
                {
                    e.Value = "restore"; // Hide button text (looks like disabled)
                }
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


        private void showDgv(String search)
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

            cmd.Parameters.AddWithValue("@search", search);
            cmd.Parameters.AddWithValue("@status", null);
            cmd.Parameters.AddWithValue("@jps_id", null);
            cmd.Parameters.AddWithValue("@sortColumn", "pst_id");
            cmd.Parameters.AddWithValue("@sortOrder", "ASC");

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dgvPlayStation.DataSource = dt;
            
            dgvPlayStation.Refresh();
            connect.Close();
        }

        private void dgvPlayStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Edit Button
                if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int id = Convert.ToInt32(dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value);
                    int jps_id = Convert.ToInt32(dgvPlayStation.Rows[e.RowIndex].Cells["jps_id"].Value);
                    string merk = dgvPlayStation.Rows[e.RowIndex].Cells["pst_merk"].Value.ToString();
                    string serialNumber = dgvPlayStation.Rows[e.RowIndex].Cells["pst_serial_number"].Value.ToString();
                    Decimal hargaPerJam = Convert.ToDecimal(dgvPlayStation.Rows[e.RowIndex].Cells["pst_harga_per_jam"].Value.ToString());
                    ShowFormInPanel(new PlayStationUpdate(admin, id, jps_id, merk, serialNumber, hargaPerJam));

                }

                //Delete Button
                else if (dgvPlayStation.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string id = dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value.ToString();
                    string nama = dgvPlayStation.Rows[e.RowIndex].Cells["pst_merk"].Value.ToString();

                    DialogResult confirm = RJMessageBox.Show("Are you sure want to delete " + nama, "Warning", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        setPlayStationStatus(Convert.ToInt32(dgvPlayStation.Rows[e.RowIndex].Cells["pst_id"].Value));
                        showDgv(); // Refresh table
                    }
                }
            }
        }

        private void setPlayStationStatus(int id)
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

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            showDgv(txtCariPlaystation.Text);
        }



    }
}
