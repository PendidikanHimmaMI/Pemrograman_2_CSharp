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
    public partial class PlayStationCreate: Form
    {
        DashboardAdmin admin;
        public PlayStationCreate()
        {
            InitializeComponent();
        }

        public PlayStationCreate(DashboardAdmin admin)
        {
            InitializeComponent();
            this.admin = admin;
            ComboBoxDataShow();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;";
                SqlConnection connect = new SqlConnection(connectionString);

                connect.Open();
                SqlCommand cmd = new SqlCommand("DECLARE @tempId INT;" +
                                                "SELECT @tempId = jps_id FROM rps_msjenisplaystation WHERE jps_nama = '" + cbJenisPlaystation.Text + "';" +
                                                "EXEC rps_createPlayStation @jps_id = @tempId, @pst_serial_number = '" + txtSerialNumber.Text + "', @pst_merk = '" + txtMerk.Text + "', @pst_harga_per_jam = " + Convert.ToDecimal(txtHargaPerJam.Text) + ", @pst_created_by = 'admin'");

                cmd.Connection = connect;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
                cbJenisPlaystation.Text = null;
                txtMerk.Text = "";
                txtSerialNumber.Text = "";
                txtHargaPerJam.Text = "";
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PlayStation(admin));
        }

        private void PlayStationCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
