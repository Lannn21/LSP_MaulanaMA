using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "admin" && password == "admin123")
            {
                this.Hide();
                FormDashboard dashboard = new FormDashboard();
                dashboard.ShowDialog();  
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Username / password admin salah!");
            }
        }
        private void btnanggota_Click(object sender, EventArgs e)
        {
            var service = new PerpustakaanService();
            var daftarBuku = service.GetAllBuku();

            Formkatalog katalog = new Formkatalog(daftarBuku);
            katalog.Show();
        }
    }
}
