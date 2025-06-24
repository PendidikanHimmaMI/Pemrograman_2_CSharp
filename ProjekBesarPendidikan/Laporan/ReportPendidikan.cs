using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan.Laporan
{
    public partial class ReportPendidikan : Form
    {
        public ReportPendidikan()
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
        }

        private void ReportPendidikan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsReport.vw_listTransaksiPenyewaan' table. You can move, or remove it, as needed.
            this.vw_listTransaksiPenyewaanTableAdapter.Fill(this.dsReport.vw_listTransaksiPenyewaan);

            this.reportViewer1.RefreshReport();
        }
    }
}
