using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan.Transaksi
{
    public partial class ItemKeranjang: UserControl
    {
        TrDetailPeminjamanPlayStation dataSementara = new TrDetailPeminjamanPlayStation();
        List<TrDetailPeminjamanPlayStation> list = new List<TrDetailPeminjamanPlayStation>();

        public List<TrDetailPeminjamanPlayStation> DetailPeminjamanList
        {
            get { return list; }
        }

        public ItemKeranjang(String namaPlayStation, String harga, int idPlayStation)
        {
            InitializeComponent();

            int start = harga.IndexOf("Rp") + 2;
            int end = harga.IndexOf(" / Jam");

            dataSementara.PlayStationId = idPlayStation;
            dataSementara.NamaPlayStation = lblNamaPlayStation.Text = namaPlayStation;
            dataSementara.Harga = Decimal.Parse(harga.Substring(start, end - start).Trim());
            lblHarga.Text = "Rp0,00";
        }

        private void dtpJamSelesai_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJamSelesai.Value.Hour == 0 && dtpJamSelesai.Value.Minute == 0)
            {
                lblHarga.Text = "Rp0,00";
            }
            else
            {
                int cariId = 0;

                if (list.Count > 0)
                {
                    cariId = list.FindIndex(item => item.PlayStationId == dataSementara.PlayStationId);
                    list[cariId].WaktuSelesai = dtpJamSelesai.Value;

                    TimeSpan durasi = list[cariId].WaktuSelesai - list[cariId].WaktuMulai;
                    list[cariId].Durasi = Convert.ToDecimal(durasi.TotalHours);
                    list[cariId].JumlahHarga = list[cariId].Harga * list[cariId].Durasi;
                }
                else
                {
                    list.Add(new TrDetailPeminjamanPlayStation(dataSementara.PlayStationId, dataSementara.NamaPlayStation, dtpJamMulai.Value, dtpJamSelesai.Value, dataSementara.Harga));
                }
                lblHarga.Text = "Rp" + list[cariId].JumlahHarga;
            }
        }

        private void dtpJamMulai_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJamSelesai.Value.Hour == 0 && dtpJamSelesai.Value.Minute == 0)
            {
                lblHarga.Text = "Rp0,00";
            }
            else
            {
                int cariId = 0;

                if (list.Count > 0)
                {
                    cariId = list.FindIndex(item => item.PlayStationId == dataSementara.PlayStationId);
                    list[cariId].WaktuMulai = dtpJamMulai.Value;

                    TimeSpan durasi = list[cariId].WaktuSelesai - list[cariId].WaktuMulai;
                    list[cariId].Durasi = Convert.ToDecimal(durasi.TotalHours);
                    list[cariId].JumlahHarga = list[cariId].Harga * list[cariId].Durasi;
                }
                else
                {
                    list.Add(new TrDetailPeminjamanPlayStation(dataSementara.PlayStationId, dataSementara.NamaPlayStation, dtpJamMulai.Value, dtpJamSelesai.Value, dataSementara.Harga));
                }
                lblHarga.Text = "Rp" + list[cariId].JumlahHarga;
            }
        }
    }
}
