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

namespace ProjekBesarPendidikan.Transaksi
{
    public partial class PeminjamanPlayStation: Form
    {
        private KeranjangPeminjaman keranjang;
        public PeminjamanPlayStation(KeranjangPeminjaman keranjang)
        {
            InitializeComponent();
            this.keranjang = keranjang;
            showData();
        }


        public void showData()
        {
            int jumlahBaris;
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("rps_getListPlayStation", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    jumlahBaris = dt.Rows.Count;
                }
            }

            for (int i = 0; i < jumlahBaris; i++)
            {
                ShowAvailablePlayStation dataShape = new ShowAvailablePlayStation(i, keranjang);
                flData.Controls.Add(dataShape);
            }
        }

    }
}
