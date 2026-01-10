using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Formbuku : Form
    {
        public Formbuku()
        {
            InitializeComponent();
        }

        private void btnsimpanbuku_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtjudul.Text) ||
                string.IsNullOrWhiteSpace(txtpengarang.Text) ||
                string.IsNullOrWhiteSpace(txttahunbuku.Text))
            {
                MessageBox.Show("Judul, Pengarang, dan Tahun harus diisi!");
                return;
            }

            if (!int.TryParse(txttahunbuku.Text, out int tahun))
            {
                MessageBox.Show("Tahun harus berupa angka!");
                return;
            }

            var service = new PerpustakaanService();
            service.TambahBuku(
                new Buku(0, txtjudul.Text, txtpengarang.Text, tahun, "Tersedia")
            );

            MessageBox.Show("Buku tersimpan");

            txtjudul.Clear();
            txtpengarang.Clear();
            txttahunbuku.Clear();
        }
    }
}
