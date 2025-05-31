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
using ToastNotifications;

namespace ProjekBesarPendidikan.Dashboard
{
    public partial class Dashboardadmin: Form
    {
        private Notification toastNotification;
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";

        public Dashboardadmin()
        {
            InitializeComponent();
            label();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private int Playstation;

        public void label()
        {
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            SqlDataReader rd;
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM dbo.fn_GetDataMasterSummary();", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Motor");
            dt = ds.Tables["Motor"];
            LbPlaystation.Text = dt.Rows[1][1].ToString();
            lbJenisPs.Text = dt.Rows[0][1].ToString();
            lbKaryawan.Text = dt.Rows[2][1].ToString();
            lbMetodePembayaran.Text = dt.Rows[3][1].ToString();
            conn.Close();
        }
    }
}
