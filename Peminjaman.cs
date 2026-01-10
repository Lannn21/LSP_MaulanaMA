using System;
using System.Collections.Generic;
using System.Text;

namespace PerpusLSP
{
    public class Peminjaman
    {
        public int Id { get; set; }
        public string NamaPeminjam { get; set; }
        public int IdBuku { get; set; }
        public string NamaBuku { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public DateTime? TanggalDikembalikan { get; set; }
        public string Status { get; set; }
    }
}
