using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Formpeminjaman : Form
    {
        private PerpustakaanService service;

        public Formpeminjaman()
        {
            InitializeComponent();
            service = new PerpustakaanService();
            LoadData();
        }

        private void LoadData()
        {
            dgvanggota.DataSource = service.GetAllAnggota();
            dgvbuku.DataSource = service.GetAllBuku();
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidanggota.Text) ||
                string.IsNullOrWhiteSpace(txtidbuku.Text))
            {
                MessageBox.Show("ID Anggota dan ID Buku harus diisi!");
                return;
            }

            if (!int.TryParse(txtidanggota.Text, out int idAnggota))
            {
                MessageBox.Show("ID Anggota harus berupa angka!");
                return;
            }

            if (!int.TryParse(txtidbuku.Text, out int idBuku))
            {
                MessageBox.Show("ID Buku harus berupa angka!");
                return;
            }

            if (!CekAnggotaAda(idAnggota))
            {
                MessageBox.Show("ID Anggota tidak ditemukan!");
                return;
            }

            if (!CekBukuTersedia(idBuku))
            {
                MessageBox.Show("Buku tidak tersedia atau ID tidak ditemukan!");
                return;
            }

            service.PinjamBuku(idAnggota, idBuku);
            MessageBox.Show("Peminjaman berhasil! Buku harus dikembalikan dalam 7 hari.");

            LoadData();
            txtidanggota.Clear();
            txtidbuku.Clear();
        }

        private bool CekAnggotaAda(int idAnggota)
        {
            var anggotaList = service.GetAllAnggota();
            foreach (Anggota anggota in anggotaList)
            {
                if (anggota.Id == idAnggota)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CekBukuTersedia(int idBuku)
        {
            string[] statusValid = { "Tersedia" };

            var bukuList = service.GetAllBuku();
            foreach (Buku buku in bukuList)
            {
                if (buku.Id == idBuku && statusValid[0] == buku.Status)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
