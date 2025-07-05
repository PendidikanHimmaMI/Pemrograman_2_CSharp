using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekBesarPendidikan.Master
{
    public partial class JenisPlayStationCreate : Form
    {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";

        public JenisPlayStationCreate()
        {
            InitializeComponent();
        }
        private DashboardAdmin admin;
        private String nameKry;


        public JenisPlayStationCreate(DashboardAdmin dashboardAdmin, String nameKry)
        {
            InitializeComponent();
            this.admin = dashboardAdmin;
            this.nameKry = nameKry;
        }

        private void txt_tahun_rilis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_max_pemain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            JenisPlayStation form = new JenisPlayStation(admin, nameKry);
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
            string kesalahan = null;
            string createdBy = "Shofi";




            if (string.IsNullOrWhiteSpace(txt_nama.Text))
            {
                kesalahan += "\nNama tidak boleh kosong.";
            }

            if (string.IsNullOrWhiteSpace(txt_deskripsi.Text))
            {
                kesalahan += "\nDeskripsi tidak boleh kosong.";
            }

            if (string.IsNullOrWhiteSpace(txt_tahun_rilis.Text))
            {
                kesalahan += "\nTahun Rilis tidak boleh kosong.";
            }

            if (string.IsNullOrWhiteSpace(txt_max_pemain.Text))
            {
                kesalahan += "\nMax Pemain tidak boleh kosong.";
            }

            //if (string.IsNullOrWhiteSpace(createdBy))
            //{
            //    MessageBox.Show("\nCreated By tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if (kesalahan != "")
            {
                MessageBox.Show(kesalahan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("rps_createJenisPlayStation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@jps_nama", txt_nama.Text);
                        cmd.Parameters.AddWithValue("@jps_tahun_rilis", txt_tahun_rilis.Text);
                        cmd.Parameters.AddWithValue("@jps_max_pemain", txt_max_pemain.Text);
                        cmd.Parameters.AddWithValue("@jps_deskripsi", txt_deskripsi.Text);
                        cmd.Parameters.AddWithValue("@jps_created_by", createdBy);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                     

                        MessageBox.Show("Jenis PlayStation berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_nama.Text = "";
            txt_deskripsi.Text = "";
            txt_tahun_rilis.Text = "";
            txt_max_pemain.Text = "";
        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
