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

namespace ProjekBesarPendidikan.Master {
    public partial class MetodePembayaranCreate : Form {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        private String nameKry;
        public MetodePembayaranCreate() {
            InitializeComponent();
        }

        public MetodePembayaranCreate(DashboardAdmin dashboardAdmin,String nameKry) {
            InitializeComponent();
            this.admin = dashboardAdmin;
            this.nameKry = nameKry;
        }

        private void btn_back_Click(object sender, EventArgs e) {
            MetodePembayaran form = new MetodePembayaran(admin, nameKry);
            admin.pnl_filForm.Controls.Clear();
            admin.pnl_filForm.Tag = null;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            admin.pnl_filForm.Controls.Add(form);
            admin.pnl_filForm.Tag = form;
            form.Show();
            form.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e) {
            string nama = txt_nama.Text.Trim();
            string deskripsi = txt_deskripsi.Text.Trim();
            string createdBy = nameKry.ToString(); 

            // Validasi input
            if (string.IsNullOrWhiteSpace(nama)) {
                MessageBox.Show("Nama metode pembayaran tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(createdBy)) {
                MessageBox.Show("Created By tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                using (SqlConnection conn = new SqlConnection(Connection)) {
                    using (SqlCommand cmd = new SqlCommand("rps_createMetodePembayaran", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mpb_nama", nama);
                        cmd.Parameters.AddWithValue("@mpb_deskripsi", deskripsi);
                        cmd.Parameters.AddWithValue("@mpb_created_by", createdBy);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Metode pembayaran berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Kembali ke form sebelumnya
                        btn_back_Click(sender, e);
                    }
                }
            } catch (SqlException ex) {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
