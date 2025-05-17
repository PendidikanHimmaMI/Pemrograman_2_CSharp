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

        public PlayStationUpdate()
        {

        }

        public PlayStationUpdate(DashboardAdmin dashboardAdmin, int id, int jps_id, string merk, string serialNumber, Decimal hargaPerJam)
        {
            PlayStationUpdate playStationUpdate = new PlayStationUpdate();
            this.admin = dashboardAdmin;
            this.id = id;
            InitializeComponent();
            ComboBoxDataShow();

            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);

            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT jps_nama FROM rps_msjenisplaystation WHERE jps_id = " + jps_id);
            cmd.Connection = connect;
            cbJenisPlaystation.Text = (string)cmd.ExecuteScalar();
            connect.Close();
            txtMerk.Text = merk;
            txtSerialNumber.Text = serialNumber;
            txtHargaPerJam.Text = hargaPerJam.ToString();
        }

        private void ComboBoxDataShow()
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;


            string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            cmd = new SqlCommand("SELECT jps_nama FROM rps_msjenisplaystation", connect);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cbJenisPlaystation.Items.Add(rd[0].ToString());
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
            ShowFormInPanel(new PlayStation(admin));
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    //Ambil jps_id berdasarkan jps_nama
                    SqlCommand getIdCmd = new SqlCommand("SELECT jps_id FROM rps_msjenisplaystation WHERE jps_nama = @jps_nama", connect);
                    getIdCmd.Parameters.AddWithValue("@jps_nama", cbJenisPlaystation.Text);

                    object result = getIdCmd.ExecuteScalar();

                    int tempId = Convert.ToInt32(result);

                    //Update data pakai stored procedure
                    SqlCommand cmd = new SqlCommand("EXEC rps_updatePlayStation @pst_id, @jps_id, @pst_serial_number, @pst_merk, @pst_harga_per_jam, @pst_modif_by", connect);
                    cmd.Parameters.AddWithValue("@pst_id", this.id);
                    cmd.Parameters.AddWithValue("@jps_id", tempId);
                    cmd.Parameters.AddWithValue("@pst_serial_number", txtSerialNumber.Text);
                    cmd.Parameters.AddWithValue("@pst_merk", txtMerk.Text);
                    cmd.Parameters.AddWithValue("@pst_harga_per_jam", Convert.ToDecimal(txtHargaPerJam.Text));
                    cmd.Parameters.AddWithValue("@pst_modif_by", "admin");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diperbarui!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
