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

        private KeranjangPeminjaman keranjangParent;

        public ItemKeranjang(String namaPlayStation, String harga, int idPlayStation, KeranjangPeminjaman keranjang)
        {
            InitializeComponent();

            this.keranjangParent = keranjang;

            int start = harga.IndexOf("Rp") + 2;
            int end = harga.IndexOf(" / Jam");

            dataSementara.PlayStationId = idPlayStation;
            dataSementara.NamaPlayStation = lblNamaPlayStation.Text = namaPlayStation;
            dataSementara.Harga = Decimal.Parse(harga.Substring(start, end - start).Trim());
            lblHarga.Text = "Rp0,00";

            //dtpJamMulai.Format = DateTimePickerFormat.Time;
            //dtpJamMulai.ShowUpDown = true;
            //dtpJamSelesai.Format = DateTimePickerFormat.Time;
            //dtpJamSelesai.ShowUpDown = true;
        }

        private void UpdateHarga()
        {
            if (dtpJamSelesai.Value <= dtpJamMulai.Value)
            {
                lblHarga.Text = "Rp0,00";
                return;
            }

            TimeSpan durasi = dtpJamSelesai.Value - dtpJamMulai.Value;
            decimal totalJam = Convert.ToDecimal(durasi.TotalHours);
            decimal jumlahHarga = totalJam * dataSementara.Harga;

            lblHarga.Text = "Rp" + jumlahHarga.ToString("N2");

            int index = list.FindIndex(item => item.PlayStationId == dataSementara.PlayStationId);
            if (index >= 0)
            {
                list[index].WaktuMulai = dtpJamMulai.Value;
                list[index].WaktuSelesai = dtpJamSelesai.Value;
                list[index].Durasi = totalJam;
                list[index].JumlahHarga = jumlahHarga;
            }
            else
            {
                list.Add(new TrDetailPeminjamanPlayStation(
                    dataSementara.PlayStationId,
                    dataSementara.NamaPlayStation,
                    dtpJamMulai.Value,
                    dtpJamSelesai.Value,
                    dataSementara.Harga
                ));
            }

            keranjangParent?.hitungTotalHarga();
        }

        private void dtpJamSelesai_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJamSelesai.Value.Hour == 0 && dtpJamSelesai.Value.Minute == 0 && dtpJamMulai.Value.Hour == 0 && dtpJamMulai.Value.Minute == 0)
            {
                lblHarga.Text = "Rp0,00";
            }
            //else
            //{
            //    int cariId = 0;

            //    if (list.Count > 0)
            //    {
            //        cariId = list.FindIndex(item => item.PlayStationId == dataSementara.PlayStationId);
            //        list[cariId].WaktuSelesai = dtpJamSelesai.Value;

            //        TimeSpan durasi = list[cariId].WaktuSelesai - list[cariId].WaktuMulai;
            //        list[cariId].Durasi = Convert.ToDecimal(durasi.TotalHours);
            //        list[cariId].JumlahHarga = list[cariId].Harga * list[cariId].Durasi;
            //    }
            //    else
            //    {
            //        list.Add(new TrDetailPeminjamanPlayStation(dataSementara.PlayStationId, dataSementara.NamaPlayStation, dtpJamMulai.Value, dtpJamSelesai.Value, dataSementara.Harga));
            //    }
            //    lblHarga.Text = "Rp" + list[cariId].JumlahHarga;
            //}

            if (dtpJamSelesai.Value < dtpJamMulai.Value)
            {
                RJMessageBox.Show("Waktu selesai harus lebih lama dari waktu mulai!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateHarga();
            keranjangParent?.hitungTotalHarga();
        }

        private void dtpJamMulai_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJamSelesai.Value.Hour == 0 && dtpJamSelesai.Value.Minute == 0 && dtpJamMulai.Value.Hour == 0 && dtpJamMulai.Value.Minute == 0)
            {
                lblHarga.Text = "Rp0,00";
            }
            //else
            //{
            //    int cariId = 0;

            //    if (list.Count > 0)
            //    {
            //        cariId = list.FindIndex(item => item.PlayStationId == dataSementara.PlayStationId);
            //        list[cariId].WaktuMulai = dtpJamMulai.Value;

            //        TimeSpan durasi = list[cariId].WaktuSelesai - list[cariId].WaktuMulai;
            //        list[cariId].Durasi = Convert.ToDecimal(durasi.TotalHours);
            //        list[cariId].JumlahHarga = list[cariId].Harga * list[cariId].Durasi;
            //    }
            //    else
            //    {
            //        list.Add(new TrDetailPeminjamanPlayStation(dataSementara.PlayStationId, dataSementara.NamaPlayStation, dtpJamMulai.Value, dtpJamSelesai.Value, dataSementara.Harga));
            //    }
            //    lblHarga.Text = "Rp" + list[cariId].JumlahHarga;
            //}

            if (dtpJamMulai.Value > dtpJamSelesai.Value)
            {
                RJMessageBox.Show("Waktu mulai harus lebih awal dari waktu selesai!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateHarga();
            keranjangParent?.hitungTotalHarga();
        }

        public int IdPlayStation
        {
            get { return dataSementara.PlayStationId; }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
            keranjangParent?.hitungTotalHarga();
        }
    }
}
