using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan.Transaksi
{

    public class TrDetailPeminjamanPlayStation
    {
        public TrDetailPeminjamanPlayStation(int playStationId, string namaPlayStation, DateTime waktuMulai, DateTime waktuSelesai, Decimal harga)
        {
            PlayStationId = playStationId;
            NamaPlayStation = namaPlayStation;
            WaktuMulai = waktuMulai;
            WaktuSelesai = waktuSelesai;
            TimeSpan durasi = WaktuSelesai - WaktuMulai;
            Durasi = Convert.ToDecimal(durasi.TotalHours);
            Harga = harga;
            JumlahHarga = Harga * Durasi;
        }

        public TrDetailPeminjamanPlayStation() { }

        public int PlayStationId { get; set; }
        public string NamaPlayStation { get; set; }
        public DateTime WaktuMulai { get; set; }
        public DateTime WaktuSelesai { get; set; }
        public decimal Harga { get; set; }
        public decimal JumlahHarga { get; set; }
        public Decimal Durasi { get; set; }
    }
}
