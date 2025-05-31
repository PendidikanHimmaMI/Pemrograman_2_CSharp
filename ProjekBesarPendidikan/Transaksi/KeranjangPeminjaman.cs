using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBox;
using System.Data.SqlClient;

namespace ProjekBesarPendidikan.Transaksi
{
    public partial class KeranjangPeminjaman: UserControl
    {
        public KeranjangPeminjaman()
        {
            InitializeComponent();
            ComboBoxDataShow();
        }

        private List<TrDetailPeminjamanPlayStation> GetAllDetailPeminjaman()
        {
            List<TrDetailPeminjamanPlayStation> hasil = new List<TrDetailPeminjamanPlayStation>();

            foreach (Control control in pnlTengah.Controls)
            {
                if (control is ItemKeranjang item)
                {
                    // Ambil list dari masing-masing ItemKeranjang dan gabungkan
                    hasil.AddRange(item.DetailPeminjamanList);
                }
            }

            return hasil;
        }


        private void btnBayar_Click(object sender, EventArgs e)
        {
            List<TrDetailPeminjamanPlayStation> semuaDetail = GetAllDetailPeminjaman();

            if (String.IsNullOrWhiteSpace(txtNamaPelanggan.Text) || String.IsNullOrWhiteSpace(txtNoTelp.Text) || String.IsNullOrWhiteSpace(txtTunai.Text) || cbMetodePembayaran.SelectedIndex == -1)
            {
                RJMessageBox.Show("Semua Data Wajib Terisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string connectionString = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        using (SqlCommand cmd = new SqlCommand("rps_createTransaksiPenyewaan", connect))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@kry_id", 8);
                            cmd.Parameters.AddWithValue("@mpb_id", cbMetodePembayaran.SelectedIndex);
                            cmd.Parameters.AddWithValue("@pps_nama_penyewa", txtNamaPelanggan.Text);
                            cmd.Parameters.AddWithValue("@pps_no_hp_penyewa", txtNoTelp.Text);
                            cmd.Parameters.AddWithValue("@pps_total_harga", Decimal.Parse(lblTotalBayar.Text.Substring(2)));
                            cmd.Parameters.AddWithValue("@created_by", "admin");

                            SqlParameter detailParam = cmd.Parameters.AddWithValue("@DetailPenyewaan", ConvertToDetailTable(semuaDetail));
                            detailParam.SqlDbType = SqlDbType.Structured;
                            detailParam.TypeName = "dbo.DetailPenyewaanType";

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connect.Close();
                        
                    }
                }
                catch (SqlException ex)
                {
                    RJMessageBox.Show("Error : " + ex.Message, "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public Panel PanelTengah
        {
            get { return pnlTengah; }
        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamaPelanggan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoTelp_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlTengah.Controls.Count == 0)
            {
                lblTotalBayar.Text = "Rp0,00";
            }
            else
            {
                Decimal totalHarga = 0;

                foreach (Control control in pnlTengah.Controls)
                {
                    if (control is ItemKeranjang item)
                    {
                        List<TrDetailPeminjamanPlayStation> detail = item.DetailPeminjamanList;

                        foreach (var d in detail)
                        {
                            totalHarga += d.JumlahHarga;
                        }
                    }
                }
                lblTotalBayar.Text = "Rp" + totalHarga;
            }
        }

        private void ComboBoxDataShow()
        {
            string connectionString = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = "SELECT mpb_id, mpb_nama FROM rps_msmetodepembayaran";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbMetodePembayaran.DataSource = dt;
                        cbMetodePembayaran.DisplayMember = "mpb_nama";
                        cbMetodePembayaran.ValueMember = "mpb_id";
                    }
                }

                connect.Close();
            }

        }

        private void KeranjangPeminjaman_Load(object sender, EventArgs e)
        {
            cbMetodePembayaran.SelectedIndex = -1;
        }

        private DataTable ConvertToDetailTable(List<TrDetailPeminjamanPlayStation> details)
        {
            DataTable table = new DataTable();
            table.Columns.Add("pst_id", typeof(int));
            table.Columns.Add("dps_waktu_mulai", typeof(DateTime));
            table.Columns.Add("dps_waktu_selesai", typeof(DateTime));
            table.Columns.Add("dps_jumlah_harga", typeof(decimal));

            foreach (var detail in details)
            {
                table.Rows.Add(detail.PlayStationId, detail.WaktuMulai, detail.WaktuSelesai, detail.JumlahHarga);
            }

            return table;
        }
    }
}