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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekBesarPendidikan.MasterKaryawan
{
    public partial class KaryawanUpdate : Form
    {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        public KaryawanUpdate()
        {
            InitializeComponent();
        }

        int id;//untuk melakukan pengambilan data id
        public KaryawanUpdate(DashboardAdmin dashboardAdmin, int id, string name, string posisi, string alamat, string no_hp, string email, string username, string password)
        {
            this.admin = dashboardAdmin;
            this.id = id;
            InitializeComponent();
            tbNama.Text = name;
            tbAlamat.Text = alamat;
            tbEmail.Text = email;
            tbHp.Text = no_hp;
            cbPosisi.Text = posisi;
            tbUserName.Text = username;
            tbPassword.Text = password;
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
            string kesalahan ="";
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
                kesalahan += "Nama Karyawan tidak boleh kosong.";
            }
            if (string.IsNullOrWhiteSpace(alamat))
            {
                kesalahan += "Alamat tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(no_hp))
            {
                kesalahan += "No Telepon tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                kesalahan += "Email tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(posisi))
            {
                kesalahan += "Posisi tidak boleh kosong. ";
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                kesalahan += "Username tidak boleh kosong. ";
            }
            
            if (!string.IsNullOrWhiteSpace(kesalahan))
            {
                MessageBox.Show(kesalahan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            if (string.IsNullOrWhiteSpace(createdBy))
            {
                MessageBox.Show("Created By tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("rps_updateKaryawan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@kry_id", id);
                        cmd.Parameters.AddWithValue("@kry_nama", nama);
                        cmd.Parameters.AddWithValue("@kry_posisi", posisi);
                        cmd.Parameters.AddWithValue("@kry_alamat", alamat);
                        cmd.Parameters.AddWithValue("@kry_no_hp", no_hp);
                        cmd.Parameters.AddWithValue("@kry_email", email);
                        cmd.Parameters.AddWithValue("@kry_username", username);
                        cmd.Parameters.AddWithValue("@kry_password", password);
                        cmd.Parameters.AddWithValue("@kry_modif_by", createdBy);

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

       
    }
}
