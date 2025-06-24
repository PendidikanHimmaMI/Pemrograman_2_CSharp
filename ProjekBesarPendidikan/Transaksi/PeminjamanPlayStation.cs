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

namespace ProjekBesarPendidikan.Transaksi
{
    public partial class PeminjamanPlayStation : Form
    {
        private KeranjangPeminjaman keranjang;
        public PeminjamanPlayStation(KeranjangPeminjaman keranjang)
        {
            InitializeComponent();
            this.keranjang = keranjang;
            showData();
            InitComboBoxes();
            RefreshFilteredData();
        }


        public void showData()
        {
            int jumlahBaris;
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("rps_getListPlayStation", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    jumlahBaris = dt.Rows.Count;
                }
            }

            for (int i = 0; i < jumlahBaris; i++)
            {
                ShowAvailablePlayStation dataShape = new ShowAvailablePlayStation(i, keranjang);
                flData.Controls.Add(dataShape);
            }
        }

        public void showData(String search, String sortOrder, String sortColumn = "pst_merk")
        {
            int jumlahBaris;
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("rps_getListPlayStation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@status", null);
                    cmd.Parameters.AddWithValue("@jps_id", null);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    jumlahBaris = dt.Rows.Count;
                }
            }

            flData.SuspendLayout();
            flData.Controls.Clear();
            for (int i = 0; i < jumlahBaris; i++)
            {
                ShowAvailablePlayStation dataShape = new ShowAvailablePlayStation(i, keranjang, search, sortColumn, sortOrder);
                flData.Controls.Add(dataShape);
            }
            flData.ResumeLayout();
        }


        private void txtCariPlaystation_TextChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }



        bool p_filterExpand = false;
        private void timer_filter_Tick(object sender, EventArgs e)
        {
            if (!p_filterExpand)
            {
                if (p_filter.Height < 285)
                {
                    p_filter.Height += 12;
                    p_filter.ShadowDecoration.Enabled = true;
                }
                else
                {
                    p_filter.Height = 285;
                    timer_filter.Stop();
                    p_filterExpand = true;
                }
            }
            else
            {
                if (p_filter.Height > 12)
                {
                    p_filter.Height -= 12;
                }
                else
                {
                    p_filter.Height = 12;
                    p_filter.ShadowDecoration.Enabled = false;
                    timer_filter.Stop();
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            p_filterExpand = !p_filterExpand;
            timer_filter.Start();
        }

        private void cbSortColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }

        private void cbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilteredData();
        }

        private void InitComboBoxes()
        {
            var sortColumnItems = new Dictionary<string, string>
        {
            { "Merk", "pst_merk" },
            { "Harga", "pst_harga_per_jam" },
        };
            cbSortColumn.DataSource = new BindingSource(sortColumnItems, null);
            cbSortColumn.DisplayMember = "Key";
            cbSortColumn.ValueMember = "Value";
            cbSortColumn.SelectedIndex = 0;

            var sortOrderItems = new Dictionary<string, string>
        {
            { "Naik (A-Z)", "ASC" },
            { "Turun (Z-A)", "DESC" }
        };
            cbSortOrder.DataSource = new BindingSource(sortOrderItems, null);
            cbSortOrder.DisplayMember = "Key";
            cbSortOrder.ValueMember = "Value";
            cbSortOrder.SelectedIndex = 0;
        }

        private void RefreshFilteredData()
        {
            string search = txtCariPlaystation.Text.Trim();
            if (cbSortColumn.SelectedItem == null || cbSortOrder.SelectedItem == null)
                return;

            string sortColumn = ((KeyValuePair<string, string>)cbSortColumn.SelectedItem).Value;
            string sortOrder = ((KeyValuePair<string, string>)cbSortOrder.SelectedItem).Value;
            showData(search, sortOrder, sortColumn);
        }

        public void clear()
        {
            if (cbSortColumn.Items.Count > 0)
                cbSortColumn.SelectedIndex = 0;
            else
                cbSortColumn.SelectedItem = null;

            if (cbSortOrder.Items.Count > 0)
                cbSortOrder.SelectedIndex = 0;
            else
                cbSortOrder.SelectedItem = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
