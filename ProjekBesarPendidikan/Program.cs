using ProjekBesarPendidikan.MasterKaryawan;
using ProjekBesarPendidikan.Transaksi;
using ProjekBesarPendidikan.Laporan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new DashboardKasir());
            //Application.Run(new ReportPendidikan());
        }
    }
}
