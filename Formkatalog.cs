using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerpusLSP
{
    public partial class Formkatalog : Form
    {
        private List<Buku> bukuList;
        private List<Buku> allBuku;

        public Formkatalog(List<Buku> daftarBuku)
        {
            InitializeComponent();
            allBuku = daftarBuku;
            bukuList = daftarBuku;
            LoadKatalog();
        }

        private void LoadKatalog()
        {
            dgvkatalog.DataSource = null;
            dgvkatalog.DataSource = bukuList;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                bukuList = allBuku;
            }
            else
            {
                bukuList = new List<Buku>();
                foreach (Buku buku in allBuku)
                {
                    if (buku.Judul.ToLower().Contains(keyword))
                    {
                        bukuList.Add(buku);
                    }
                }
            }

            LoadKatalog();
        }
    }
}
