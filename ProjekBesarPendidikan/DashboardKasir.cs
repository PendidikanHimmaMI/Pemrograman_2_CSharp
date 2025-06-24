using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using ProjekBesarPendidikan.Master;
using ProjekBesarPendidikan.Transaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ProjekBesarPendidikan
{
    public partial class DashboardKasir : Form
    {
        public DashboardKasir()
        {
            InitializeComponent();
            viewKeranjang.Visible = false;
        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new Dashboard.DashboardKasir1());
        }
        Login login;
        int idKry;
        String nameKry;
        public DashboardKasir(Login login, int id, String name) {
            InitializeComponent();
            this.login = login;
            this.idKry = id;
            this.nameKry = name;
            ShowFormInPanel(new Dashboard.DashboardKasir1());
        }
        private void ShowFormInPanel(Form form)
        {
            // Hapus form lama dari panel
            if (flContent.Controls.Count > 0)
            {
                System.Windows.Forms.Control oldForm = flContent.Controls[0];
                oldForm.Dispose();
                flContent.Controls.Clear();
            }

            // Tambahkan form baru
            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top;
            form.Anchor = AnchorStyles.Bottom;
            form.Anchor = AnchorStyles.Left;
            form.Anchor = AnchorStyles.Right;
            flContent.Controls.Add(form);
            form.Show();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            btnBeranda.FillColor = Color.White;
            btnBeranda.ForeColor = Color.FromArgb(2, 10, 122);
            btnBeranda.Image = Image.FromFile(@"..\..\Icon\Beranda - Hover.png");

            btnTransaksi.FillColor = Color.FromArgb(2, 10, 122);
            btnTransaksi.ForeColor = Color.White;
            btnTransaksi.Image = Image.FromFile(@"..\..\Icon\Transaksi.png");

            btnLogOut.FillColor = Color.FromArgb(2, 10, 122);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Image.FromFile(@"..\..\Icon\Logout.png");

            lblMenu.Text = "Beranda";
            viewKeranjang.Visible = false;

            ShowFormInPanel(new Dashboard.DashboardKasir1());
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            btnTransaksi.FillColor = Color.White;
            btnTransaksi.ForeColor = Color.FromArgb(2, 10, 122);
            btnTransaksi.Image = Image.FromFile(@"..\..\Icon\Transaksi - Hover.png");

            btnBeranda.FillColor = Color.FromArgb(2, 10, 122);
            btnBeranda.ForeColor = Color.White;
            btnBeranda.Image = Image.FromFile(@"..\..\Icon\Beranda.png");

            btnLogOut.FillColor = Color.FromArgb(2, 10, 122);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Image.FromFile(@"..\..\Icon\Logout.png");

            lblMenu.Text = "Daftar PlayStation";

            // Hapus form lama dari panel
            //if (pnlContent.Controls.Count > 0)
            //{
            //    System.Windows.Forms.Control oldForm = pnlContent.Controls[0];
            //    oldForm.Dispose();
            //    pnlContent.Controls.Clear();
            //}

            // Tambahkan form baru
            //PlayStation playStationForm = new PlayStation(this);
            //playStationForm.TopLevel = false;
            //playStationForm.Dock = DockStyle.Fill;
            //pnlContent.Controls.Add(playStationForm);
            //playStationForm.Show();

            ShowFormInPanel(new PeminjamanPlayStation(viewKeranjang));
            viewKeranjang.BringToFront();
            viewKeranjang.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogOut.FillColor = Color.White;
            btnLogOut.ForeColor = Color.FromArgb(2, 10, 122);
            btnLogOut.Image = Image.FromFile(@"..\..\Icon\Logout - Hover.png");

            btnBeranda.FillColor = Color.FromArgb(2, 10, 122);
            btnBeranda.ForeColor = Color.White;
            btnBeranda.Image = Image.FromFile(@"..\..\Icon\Beranda.png");

            btnTransaksi.FillColor = Color.FromArgb(2, 10, 122);
            btnTransaksi.ForeColor = Color.White;
            btnTransaksi.Image = Image.FromFile(@"..\..\Icon\Transaksi.png");

            viewKeranjang.Visible = false;
            this.Hide(); // Sembunyikan form saat ini
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close(); // Jika Login ditutup, form saat ini ikut ditutup
            login.Show();
        }

        private void viewKeranjang_Load(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {


            lblMenu.Text = "Laporan";
            viewKeranjang.Visible = false;

            ShowFormInPanel(new Laporan.ReportPendidikan());
        }
    }
}
