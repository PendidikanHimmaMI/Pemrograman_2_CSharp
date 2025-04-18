using CustomMessageBox;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToastNotifications;

namespace ProjekBesarPendidikan{
    public partial class MetodePembayaran : Form {
        private Notification toastNotification;

        public MetodePembayaran() {
            InitializeComponent();
        }

        private void Produk_EnabledChanged(object sender, EventArgs e) {
            autoId();
            LoadData();
        }
        private void Produk_Load(object sender, EventArgs e) {

        }

        private void autoId() {
        }


        private void LoadData() {
           
        }
        private void filter() {

        }
        private bool isUpdatePosition = false;

      
        private void btn_ExcData_Click(object sender, EventArgs e) {

        }
        public void clear(bool reset = false) {
            autoId();
            isUpdatePosition = false;
            if (reset)LoadData();
        }

        private void btn_Filter_Click(object sender, EventArgs e) {
            timer_filter.Start();
        }

        bool p_filterExpand = false;
        private void timer_filter_Tick(object sender, EventArgs e) {
            if (!p_filterExpand) {
                if (p_Filter.Height < 130) {
                    p_Filter.Height += 12;
                    p_Filter.ShadowDecoration.Enabled = true;
                } else {
                    p_Filter.Height = 130;
                    timer_filter.Stop();
                    p_filterExpand = true;
                }
            } else {
                if (p_Filter.Height > 12) {
                    p_Filter.Height -= 12;
                } else {
                    p_Filter.Height = 12;
                    p_Filter.ShadowDecoration.Enabled = false;
                    timer_filter.Stop();
                    p_filterExpand = false;
                }
            }

        }

        private void txt_Search_Enter(object sender, EventArgs e) {
            filter();
        }

        private void btn_clear_Click(object sender, EventArgs e) {
            cb_SortType.Text = null;
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                if (e.KeyChar != '\b' && e.KeyChar != ' ') {
                    e.Handled = true;
                }
            }
        }

        private void txt_MinPoint_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e) {
            clear();
        }

        private void txt_Search_IconRightClick(object sender, EventArgs e) {
            filter();
        }
        private void txt_KeyPressNomor(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                filter();
            }
        }
    }
}
