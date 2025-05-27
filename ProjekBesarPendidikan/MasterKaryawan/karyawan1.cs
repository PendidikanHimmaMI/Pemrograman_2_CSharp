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
    }
}
