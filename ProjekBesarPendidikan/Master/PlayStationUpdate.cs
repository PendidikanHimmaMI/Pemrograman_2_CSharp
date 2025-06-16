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

namespace ProjekBesarPendidikan.Master
{
    public partial class PlayStationUpdate: Form
    {
        private DashboardAdmin admin;
        public int id;
        private String nameKry;
        public PlayStationUpdate(DashboardAdmin dashboardAdmin, String nameKry)
        {
            this.admin = dashboardAdmin;
            this.nameKry = nameKry;
            InitializeComponent();
            ComboBoxDataShow();
        }

        public PlayStationUpdate(DashboardAdmin dashboardAdmin, int id, int jps_id, string merk, string serialNumber, Decimal hargaPerJam)
        {
            PlayStationUpdate playStationUpdate = new PlayStationUpdate(admin, nameKry);
            this.admin = dashboardAdmin;
            this.id = id;
            InitializeComponent();
            ComboBoxDataShow();

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);

            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT jps_nama FROM [dbo].[rps_getByIdJenisPlayStation] ("+jps_id+")" );
            cmd.Connection = connect;
            cbJenisPlaystation.Text = (string)cmd.ExecuteScalar();
            connect.Close();
            txtMerk.Text = merk;
            txtSerialNumber.Text = serialNumber;
            txtHargaPerJam.Text = hargaPerJam.ToString();
        }

        private void ComboBoxDataShow()
        {
            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = "SELECT jps_id, jps_nama FROM rps_msjenisplaystation";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbJenisPlaystation.DataSource = dt;
                        cbJenisPlaystation.DisplayMember = "jps_nama";
                        cbJenisPlaystation.ValueMember = "jps_id";
                    }
                }

                connect.Close();
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PlayStation(admin, nameKry));
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using(SqlCommand cmd = new SqlCommand("rps_updatePlayStation", connect)){
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pst_id", this.id);
                        cmd.Parameters.AddWithValue("@jps_id", cbJenisPlaystation.SelectedValue);
                        cmd.Parameters.AddWithValue("@pst_serial_number", txtSerialNumber.Text);
                        cmd.Parameters.AddWithValue("@pst_merk", txtMerk.Text);
                        cmd.Parameters.AddWithValue("@pst_harga_per_jam", Convert.ToDecimal(txtHargaPerJam.Text));
                        cmd.Parameters.AddWithValue("@pst_modif_by", "admin");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil diperbarui!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                    cbJenisPlaystation.SelectedIndex = -1;
                    txtMerk.Clear();
                    txtSerialNumber.Clear();
                    txtHargaPerJam.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayStationUpdate_Load(object sender, EventArgs e)
        {
        }
    }
}
