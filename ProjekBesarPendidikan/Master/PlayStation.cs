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

namespace ProjekBesarPendidikan.Master
{
    public partial class PlayStation: Form
    {
        private DashboardAdmin admin;

        public PlayStation(DashboardAdmin dashboardAdmin)
        {
            admin = dashboardAdmin;
            InitializeComponent();
            showDgv();
        }

        private void showDgv()
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            cmd = new SqlCommand("EXEC dbo.rps_getListPlayStation", connect);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PlayStation");
            dgvPlayStation.DataSource = ds.Tables["PlayStation"];

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
        }


        private void showDgv(String search)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            cmd = new SqlCommand("EXEC dbo.rps_getListPlayStation @search = '" + search + "'", connect);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PlayStation");
            dgvPlayStation.DataSource = ds.Tables["PlayStation"];
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
                SqlConnection connect = new SqlConnection(connectionString);

                connect.Open();
                SqlCommand cmd = new SqlCommand("EXEC rps_setStatusPlayStation @pst_id = '" + id + "'");

                cmd.Connection = connect;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dihapus!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
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
            ShowFormInPanel(new PlayStationCreate(admin));
        }

        private void txtCariPlaystation_TextChanged(object sender, EventArgs e)
        {
            showDgv(txtCariPlaystation.Text);
        }
    }
}
