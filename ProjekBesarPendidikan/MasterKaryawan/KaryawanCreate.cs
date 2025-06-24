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

namespace ProjekBesarPendidikan.MasterKaryawan
{
    public partial class KaryawanCreate: Form
    {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        


        public KaryawanCreate()
        {
            InitializeComponent();
        }

        public KaryawanCreate(DashboardAdmin dashboardAdmin)
        {
            this.admin = dashboardAdmin;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            karyawan1 form = new karyawan1(admin);
            admin.pnl_filForm.Controls.Clear();
            admin.pnl_filForm.Tag = null;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            admin.pnl_filForm.Controls.Add(form);
            admin.pnl_filForm.Tag = form;
            form.Show();
            form.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string kesalahan = "";
            string nama = tbNama.Text.Trim();
            string alamat = tbAlamat.Text.Trim();
            string no_hp = tbHp.Text.Trim();
            string email = tbEmail.Text.Trim();
            string posisi = cbPosisi.Text.Trim();
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();
            string createdBy = "Admin"; // atau bisa ambil dari login session

            // Validasi input
            if (string.IsNullOrWhiteSpace(nama))
            {
                kesalahan += "\nNama Karyawan tidak boleh kosong.";
            }
            if (string.IsNullOrWhiteSpace(alamat))
            {
                kesalahan += "\nAlamat tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(no_hp))
            {
                kesalahan += "\nNo Telepon tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                kesalahan += "\nEmail tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(posisi))
            {
                kesalahan += "\nPosisi tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                kesalahan += "\nUsername tidak boleh kosong. ";
            }

            if (!string.IsNullOrWhiteSpace(kesalahan))
            {
                MessageBox.Show(kesalahan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("rps_createKaryawan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@kry_nama", nama);
                        cmd.Parameters.AddWithValue("@kry_posisi", posisi);
                        cmd.Parameters.AddWithValue("@kry_alamat", alamat);
                        cmd.Parameters.AddWithValue("@kry_no_hp", no_hp);
                        cmd.Parameters.AddWithValue("@kry_email", email);
                        cmd.Parameters.AddWithValue("@kry_username", username);
                        cmd.Parameters.AddWithValue("@kry_password", password);
                        cmd.Parameters.AddWithValue("@kry_created_by", createdBy);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Data Karyawan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Kembali ke form sebelumnya
                        btn_back_Click(sender, e);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_bersihkan_Click(object sender, EventArgs e)
        {
            tbAlamat.Text = "";
            tbEmail.Text = "";
            tbHp.Text = "";
            tbNama.Text = "";
            tbPassword.Text = "";
            tbUserName.Text = "";
            cbPosisi.SelectedItem =null;
        }
    }
}
