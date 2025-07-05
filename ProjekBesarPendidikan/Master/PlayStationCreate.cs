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
    public partial class PlayStationCreate: Form
    {
        private DashboardAdmin admin;
        private String nameKry;
        public PlayStationCreate()
        {
            InitializeComponent();
        }

        public PlayStationCreate(DashboardAdmin admin, String nameKry)
        {
            InitializeComponent();
            this.admin = admin;
            this.nameKry = nameKry;
            ComboBoxDataShow();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtHargaPerJam.Text) || String.IsNullOrWhiteSpace(txtMerk.Text) || String.IsNullOrWhiteSpace(txtSerialNumber.Text) || cbJenisPlaystation.SelectedIndex == -1)
            {
                RJMessageBox.Show("Semua data wajib diisi!", "Validasi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        using (SqlCommand cmd = new SqlCommand("rps_createPlayStation", connect))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@jps_id", cbJenisPlaystation.SelectedValue);
                            cmd.Parameters.AddWithValue("@pst_serial_number", txtSerialNumber.Text);
                            cmd.Parameters.AddWithValue("@pst_merk", txtMerk.Text);
                            cmd.Parameters.AddWithValue("@pst_harga_per_jam", Convert.ToDecimal(txtHargaPerJam.Text));
                            cmd.Parameters.AddWithValue("@pst_created_by", "admin");

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                ShowFormInPanel(new PlayStation(admin, nameKry));
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

        private void PlayStationCreate_Load(object sender, EventArgs e)
        {
            cbJenisPlaystation.SelectedIndex = -1;
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtMerk.Text = "";
            txtSerialNumber.Text = "";
            txtHargaPerJam.Text = "";
            cbJenisPlaystation.SelectedIndex = -1;
        }
    }
}
