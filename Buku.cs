namespace PerpusLSP
{
    public class Buku
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Pengarang { get; set; }
        public int Tahun { get; set; }
        public string Status { get; set; }

        public Buku(int id, string judul, string pengarang, int tahun, string status = "Tersedia")
        {
            Id = id;
            Judul = judul;
            Pengarang = pengarang;
            Tahun = tahun;
            Status = status;
        }
    }
}
