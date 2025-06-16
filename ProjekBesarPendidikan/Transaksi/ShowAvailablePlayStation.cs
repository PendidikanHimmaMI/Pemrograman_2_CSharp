using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjekBesarPendidikan.Transaksi
{
    public partial class ShowAvailablePlayStation : UserControl
    {
        private KeranjangPeminjaman keranjangPeminjaman;
        public ShowAvailablePlayStation(int rowsCount, KeranjangPeminjaman keranjangPeminjaman)
        {
            InitializeComponent();
            this.keranjangPeminjaman = keranjangPeminjaman;
            showData(rowsCount);
        }
        
        public ShowAvailablePlayStation(int rowsCount, KeranjangPeminjaman keranjangPeminjaman, String search, String sortColumn, String sortOrder)
        {
            InitializeComponent();
            this.keranjangPeminjaman = keranjangPeminjaman;
            showData(rowsCount, search, sortColumn, sortOrder);
        }

        private void ShowAvailablePlayStation_Load(object sender, EventArgs e)
        {
        }

        public void showData(int i)
        {
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("rps_getListPlayStation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", null);
                    cmd.Parameters.AddWithValue("@status", null);
                    cmd.Parameters.AddWithValue("@jps_id", null);
                    cmd.Parameters.AddWithValue("@sortColumn", "pst_id");
                    cmd.Parameters.AddWithValue("@sortOrder", "ASC");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > i && i >= 0)
                    {
                        DataRow row = dt.Rows[i];

                        // Tampilkan ke label atau kontrol lainnya (sesuaikan nama label/kontrolmu)
                        lblIdPlayStation.Text = row["pst_id"].ToString();
                        lblMerkPlayStation.Text = "- " + row["pst_merk"].ToString();
                        lblJenisPlayStation.Text = "- " + row["jps_nama"].ToString();
                        lblMaxOrang.Text = "- Max " + row["jps_max_pemain"].ToString() + " Pemain";
                        lblHarga.Text = "- Rp" + row["pst_harga_per_jam"].ToString() + " / Jam";
                        lblNamaPlayStation.Text = row["pst_serial_number"].ToString();
                        lblNamaPlayStation.Left = (ShpData.Width - lblNamaPlayStation.Width) / 2;
                    }

                }

                connection.Close();
            }
        }

        public void showData(int i, String search, String sortColumn, String sortOrder)
        {
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("rps_getListPlayStation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@status", null);
                    cmd.Parameters.AddWithValue("@jps_id", null);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > i && i >= 0)
                    {
                        DataRow row = dt.Rows[i];

                        // Tampilkan ke label atau kontrol lainnya (sesuaikan nama label/kontrolmu)
                        lblIdPlayStation.Text = row["pst_id"].ToString();
                        lblMerkPlayStation.Text = "- " + row["pst_merk"].ToString();
                        lblJenisPlayStation.Text = "- " + row["jps_nama"].ToString();
                        lblMaxOrang.Text = "- Max " + row["jps_max_pemain"].ToString() + " Pemain";
                        lblHarga.Text = "- Rp" + row["pst_harga_per_jam"].ToString() + " / Jam";
                        lblNamaPlayStation.Text = row["pst_serial_number"].ToString();
                        lblNamaPlayStation.Left = (ShpData.Width - lblNamaPlayStation.Width) / 2;
                    }

                }

                connection.Close();
            }
        }

        private void btnTambahDatakeKeranjang_Click(object sender, EventArgs e)
        {
            var item = new ItemKeranjang(lblNamaPlayStation.Text, lblHarga.Text, Int32.Parse(lblIdPlayStation.Text));
            this.keranjangPeminjaman.PanelTengah.Controls.Add(item);
        }
    }
}