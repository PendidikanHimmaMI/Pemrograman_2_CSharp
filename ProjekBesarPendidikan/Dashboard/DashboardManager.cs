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
using System.Windows.Forms.DataVisualization.Charting;
using ToastNotifications;

namespace ProjekBesarPendidikan.Dashboard
{
    public partial class DashboardManager : Form
    {
        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        private DashboardAdmin admin;
        private int tahun, bulan;

        public DashboardManager()
        {
            InitializeComponent();
        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        public DashboardManager(DashboardAdmin dashboardAdmin)
        {
            admin = dashboardAdmin;
            InitializeComponent();
            // Ambil tahun saat ini
            int tahunSekarang = DateTime.Now.Year;

            // Isi ComboBox dengan tahun dari 2000 hingga tahun saat ini
            for (int tahun = 2000; tahun <= tahunSekarang; tahun++)
            {
                cbTahun.Items.Add(tahun);
            }

            //menambahkan tahun dan bulan sekarang menjadi default
            tahun = DateTime.Now.Year;
            bulan = DateTime.Now.Month;
            Chart("select * from dbo.fn_Top5PlaystationPalingSeringDisewa(" + tahun + ", " + bulan + ")", "Top5");
            Chart("select * from dbo.fn_Top5MetodePembayaranPalingSeringDipakai(" + tahun + ", " + bulan + ")", "Jenis");
            Chart("select * from dbo.fn_Top5KaryawanPalingSeringTransaksi('" + tahun + "','" + bulan + "')", "Karyawan");
            Chart("select * from dbo.fn_Top5JenisPlaystationPalingSeringDisewa('" + tahun + "','" + bulan + "')", "JenisPS");
            Chart("select * from dbo.fn_TotalTransaksiHarian('" + tahun + "','" + bulan + "')", "TransaksiHarian");
            Chart("select * from dbo.fn_PendapatanHarian('" + tahun + "','" + bulan + "')", "PendapatanHarian");


            label();
        }

        public void label()
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            cmd = new SqlCommand("select * from dbo.fn_RekapPenyewaanBulanan('" + tahun + "','" + bulan + "' )", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Motor");
            dt = ds.Tables["Motor"];
            TotalPendapatan.Text = dt.Rows[0][1].ToString();
            TotalPenyewaan.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        //untuk melakukan refresh
        private void RefreshPieCharts()
        {
            // Clear chart data before refreshing
            pieTop5PS.Series.Clear();
            pieTop5JenisPembayaran.Series.Clear();
            pieTop5JenisPS.Series.Clear();
            pieTop5Karyawan.Series.Clear();
            BarTotalPendapatanHarian.Series.Clear();
            BarTotalTransaksiHarian.Series.Clear();

            // Call updated PieChart with current bulan and tahun
            if (tahun != 0 && bulan != 0)
            {
                Chart("select * from dbo.fn_Top5PlaystationPalingSeringDisewa(" + tahun + ", " + bulan + ")", "Top5");
                Chart("select * from dbo.fn_Top5MetodePembayaranPalingSeringDipakai(" + tahun + ", " + bulan + ")", "Jenis");
                Chart("select * from dbo.fn_Top5KaryawanPalingSeringTransaksi('" + tahun + "','" + bulan + "')", "Karyawan");
                Chart("select * from dbo.fn_Top5JenisPlaystationPalingSeringDisewa('" + tahun + "','" + bulan + "')", "JenisPS");
                Chart("select * from dbo.fn_TotalTransaksiHarian('" + tahun + "','" + bulan + "')", "TransaksiHarian");
                Chart("select * from dbo.fn_PendapatanHarian('" + tahun + "','" + bulan + "')", "PendapatanHarian");
            }
            label();
        }
        public void Chart(String mycmd, string jenis)
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            cmd = new SqlCommand(mycmd, conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Motor");
            dt = ds.Tables["Motor"];
            Series series = new Series("Tanggal");

            //melakukan pemilahan untuk mana yang pie mana yang bar
            if (jenis.Equals("PendapatanHarian") || jenis.Equals("TransaksiHarian"))
            {
                series.ChartType = SeriesChartType.Column; 
            }
            else
            {
                series.ChartType = SeriesChartType.Pie;
            }

            // Looping melalui semua baris dalam tabel
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nama = dt.Rows[i][0].ToString(); // Mengambil nama kategori
                double jumlah = Convert.ToDouble(dt.Rows[i][1]); // Mengambil nilai jumlah

                series.Points.AddXY(nama, jumlah); // Menambahkan data ke chart
            }

            //untuk menampilkan persentase
            if (series.ChartType == SeriesChartType.Pie)
            {
                series.Label = "#PERCENT";                // Menampilkan persentase
                series["PieLabelStyle"] = "Outside";      // Label di luar lingkaran
                series["PieLineColor"] = "Black";         // Warna garis penunjuk ke label
            }


            //melakukan pemilihan antara pie
            if (jenis.Equals("Top5"))
            {
                if (dt.Rows.Count == 0)
                {
                    pieTop5PS.Titles[0].Visible = false;
                }
                else
                {
                    pieTop5PS.Titles[0].Visible = true;
                }
                    pieTop5PS.Series.Add(series);
            }
            else if (jenis.Equals("Jenis"))
            {
                if (dt.Rows.Count == 0)
                {
                    pieTop5JenisPembayaran.Titles[0].Visible = false;
                }
                else
                {
                    pieTop5JenisPembayaran.Titles[0].Visible= true;
                }
                    pieTop5JenisPembayaran.Series.Add(series);
            }else if (jenis.Equals("Karyawan"))
            {
                if (dt.Rows.Count == 0)
                {
                    pieTop5Karyawan.Titles[0].Visible = false;
                }
                else
                {
                    pieTop5Karyawan.Titles[0].Visible = true;
                }
                pieTop5Karyawan.Series.Add(series);
            }else if (jenis.Equals("JenisPS"))
            {
                if (dt.Rows.Count == 0)
                {
                    pieTop5JenisPS.Titles[0].Visible = false;
                }
                else
                {
                    pieTop5JenisPS.Titles[0].Visible = true;
                }
                pieTop5JenisPS.Series.Add(series);
            }else if (jenis.Equals("PendapatanHarian"))
            {
                if (dt.Rows.Count == 0)
                {
                    BarTotalPendapatanHarian.Titles[0].Visible = false;
                    BarTotalPendapatanHarian.Legends[0].Enabled = false;

                }
                else
                {
                    BarTotalPendapatanHarian.Titles[0].Visible = true;
                    BarTotalPendapatanHarian.Legends[0].Enabled = true;
                }
                BarTotalPendapatanHarian.Series.Add(series);
            }
            else if (jenis.Equals("TransaksiHarian"))
            {
                if (dt.Rows.Count == 0)
                {
                    BarTotalTransaksiHarian.Titles[0].Visible = false;
                    BarTotalTransaksiHarian.Legends[0].Enabled = false;

                }
                else
                {
                    BarTotalTransaksiHarian.Titles[0].Visible = true;
                    BarTotalTransaksiHarian.Legends[0].Enabled = true;

                }
                BarTotalTransaksiHarian.Series.Add(series);
            }
            conn.Close();
        }

        private void LabelCB_Click(object sender, EventArgs e)
        {
            cbBulan.DroppedDown = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            cbTahun.DroppedDown = true;
        }

        private void cbBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBulan.Hide();

            switch (cbBulan.SelectedItem?.ToString())
            {
                case "Januari": bulan = 1; break;
                case "Februari": bulan = 2; break;
                case "Maret": bulan = 3; break;
                case "April": bulan = 4; break;
                case "Mei": bulan = 5; break;
                case "Juni": bulan = 6; break;
                case "Juli": bulan = 7; break;
                case "Agustus": bulan = 8; break;
                case "September": bulan = 9; break;
                case "Oktober": bulan = 10; break;
                case "November": bulan = 11; break;
                case "Desember": bulan = 12; break;
                default:
                    bulan = 0; // Nilai default jika tidak ada yang cocok
                    break;
            }
            RefreshPieCharts();
        }

        private void cbTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTahun.Hide();
            if (int.TryParse(cbTahun.SelectedItem?.ToString(), out int parsedTahun))
            {
                tahun = parsedTahun;
            }
            else
            {
                tahun = 0; // Nilai default jika parsing gagal
            }
            RefreshPieCharts();
        }
    }
}
