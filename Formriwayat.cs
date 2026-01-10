using System;
using System.Linq;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Formriwayat : Form
    {
        private PerpustakaanService service;

        public Formriwayat()
        {
            InitializeComponent();
            service = new PerpustakaanService();
            TampilkanData();
        }

        private void TampilkanData()
        {
            dgvriwayat.DataSource = null;
            dgvriwayat.DataSource = service.GetDaftarPeminjaman();
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidpeminjam.Text) ||
                string.IsNullOrWhiteSpace(txtidbuku.Text))
            {
                MessageBox.Show("ID Peminjaman dan ID Buku harus diisi!");
                return;
            }

            if (!int.TryParse(txtidpeminjam.Text, out int idPeminjaman))
            {
                MessageBox.Show("ID Peminjaman harus berupa angka!");
                return;
            }

            if (!int.TryParse(txtidbuku.Text, out int idBuku))
            {
                MessageBox.Show("ID Buku harus berupa angka!");
                return;
            }

            try
            {
                service.KembalikanBuku(idPeminjaman, idBuku);
                MessageBox.Show("Buku berhasil dikembalikan!");
                TampilkanData();
                txtidpeminjam.Clear();
                txtidbuku.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
