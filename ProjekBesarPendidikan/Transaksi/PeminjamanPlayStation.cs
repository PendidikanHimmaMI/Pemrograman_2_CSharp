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
        public PeminjamanPlayStation()
        {
            InitializeComponent();
            showData();
        }
        public void showData()
        {
            int jumlahBaris;
            using (SqlConnection connection = new SqlConnection("Data Source=127.0.0.4,9210;Initial Catalog=DB_RentalPlaystation;User ID=Pendidikan;Password=123;"))
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
                ShowAvailablePlayStation dataShape = new ShowAvailablePlayStation(i);
                flowLayoutPanel1.Controls.Add(dataShape);
            }
        }
    }
}
