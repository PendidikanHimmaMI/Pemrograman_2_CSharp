using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace ProjekBesarPendidikan
{
    public partial class Login : Form
    {
        private string Connection = "Server=127.0.0.4,9210;Initial Catalog=Db_RentalPlayStation;TrustServerCertificate=true;user id=Pendidikan;password=123";
        Notification notification;
        public Login()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) {
                notification = new Notification("Warning", "All fields must be filled.");
                notification.Show();
                return;
            }

            using (SqlConnection conn = new SqlConnection(Connection)) {
                try {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("rps_loginKaryawan", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                // Success: you can retrieve values here
                                int kryId = Convert.ToInt32(reader["kry_id"]);
                                string kryNama = reader["kry_nama"].ToString();
                                string kryPosisi = reader["kry_posisi"].ToString();
                                string kryStatus = reader["kry_status"].ToString();
                                string kryUsername = reader["kry_username"].ToString();

                                notification = new Notification("Success", $"Welcome, {kryNama} ({kryPosisi})!");
                                notification.Show();
                                IntoDashboard(kryPosisi, kryId, kryNama);
                            }
                        }
                    }
                } catch (SqlException ex) {
                    notification = new Notification("Error", ex.Message);
                    notification.Show();
                } finally {
                    txtPassword.Text = string.Empty;
                    txtUsername.Text = string.Empty;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public void IntoDashboard(string ROLE, int id, string Name) {
            notification = new Notification("Info", "Login Successfully");
            switch (ROLE) {
                case "Admin":
                    DashboardAdmin admin = new DashboardAdmin(this, id, Name);
                    notification.Show();
                    admin.Show();
                    this.Hide();
                    Thread.Sleep(5);
                    admin.Enabled = true;
                    break;
                case "Kasir":
                    DashboardKasir kasir = new DashboardKasir(this, id, Name);
                    notification.Show();
                    kasir.Show();
                    this.Hide();
                    Thread.Sleep(5);
                    kasir.Enabled = true;
                    break;
                default:
                    notification = new Notification("Info", "Permision Invalid");
                    break;
            }
        }
    }
}
