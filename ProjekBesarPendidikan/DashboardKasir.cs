using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan
{
    public partial class DashboardKasir : Form
    {
        public DashboardKasir()
        {
            InitializeComponent();
        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            
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
        }
    }
}
