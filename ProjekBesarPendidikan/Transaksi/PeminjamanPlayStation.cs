using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            tes();
        }
       public void tes()
        {
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                flowLayoutPanel1.Controls.Add(button);
            }
        }
    }
}
