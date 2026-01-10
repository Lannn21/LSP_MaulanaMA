using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Formanggota : Form
    {
        public Formanggota()
        {
            InitializeComponent();
        }

        private void txtnamaanggota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; 
                MessageBox.Show("Nama hanya boleh berisi huruf!");
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnamaanggota.Text) ||
                string.IsNullOrWhiteSpace(txtalamatanggota.Text))
            {
                MessageBox.Show("Nama dan Alamat harus diisi!");
                return;
            }

            var service = new PerpustakaanService();
            service.TambahAnggota(
                new Anggota(0, txtnamaanggota.Text, txtalamatanggota.Text)
            );

            MessageBox.Show("Anggota tersimpan");

            txtnamaanggota.Clear();
            txtalamatanggota.Clear();
        }
    }
}
