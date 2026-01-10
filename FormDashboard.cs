using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void btnanggota_Click(object sender, EventArgs e)
        {
            var form = new Formanggota();
            form.ShowDialog();
        }

        private void btnbuku_Click(object sender, EventArgs e)
        {
            var form = new Formbuku();
            form.ShowDialog();
        }

        private void btnpinjam_Click(object sender, EventArgs e)
        {
            var form = new Formpeminjaman();
            form.ShowDialog();
        }

        private void btnkatalog_Click(object sender, EventArgs e)
        {
            var service = new PerpustakaanService();
            var daftarBuku = service.GetAllBuku();
            var form = new Formkatalog(daftarBuku);
            form.ShowDialog();
        }
        private void btnriwayat_Click(object sender, EventArgs e)
        {
            var form = new Formriwayat();
            form.ShowDialog();
        }
    }
}
