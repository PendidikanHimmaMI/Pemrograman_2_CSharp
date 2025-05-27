using CustomMessageBox;
using Guna.UI2.WinForms;
using ProjekBesarPendidikan.Dashboard;
using ProjekBesarPendidikan.MasterKaryawan;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjekBesarPendidikan { 
    public partial class DashboardAdmin : Form {
        public DashboardAdmin() {
            InitializeComponent();
        }
        Login login;
        int idKry;
        String nameKry;
        public DashboardAdmin(Login login,int id,String name) {
            InitializeComponent();
            this.login = login;
            this.idKry = id;
            this.nameKry = name;
        }

        private void ShowFormInPanel(Form form, Guna2Button guna2Button) {
            foreach (Control control in MenuDash.Controls) {
                if (control is Guna2Button button) {
                    button.Checked = false;
                }
            }
            guna2Button.Checked = true;
            if (pnl_filForm.Tag is Form FormPanel) {
                Form form1 = (Form)pnl_filForm.Tag;
                form1.Close();
                pnl_filForm.Controls.Clear();
                pnl_filForm.Tag = null;
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnl_filForm.Controls.Add(form);
            pnl_filForm.Tag = form;
            form.Show();
            form.Enabled = true;
        }

        private void btn_CheckedChanged_Padding(object sender, EventArgs e) {
            Guna2Button guna2Button = (Guna2Button)sender;
            if (guna2Button.Checked) {
                guna2Button.FillColor = Color.White;
                guna2Button.ForeColor = Color.FromArgb(2, 10, 122);
                //guna2Button.ShadowDecoration.Enabled = true;
            } else {
                guna2Button.FillColor = Color.FromArgb(2, 10, 122);
                guna2Button.ForeColor = Color.White;
                //guna2Button.ShadowDecoration.Enabled = false;
            }
        }

        private void btn_Beranda_Click(object sender, EventArgs e) {
            ShowFormInPanel(new Dashboardadmin(this), (Guna2Button)sender);
        }

        private void btn_Logout_Click(object sender, EventArgs e) {

        }

        private void btn_Karyawan_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new karyawan1(this), (Guna2Button)sender);
        }

        private void btn_MetodePembayaran_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new DashboardKasir(this), (Guna2Button)sender);

        }

        private void flp_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_filForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PS_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new DashboardManager(this), (Guna2Button)sender);
        }
    }
}
