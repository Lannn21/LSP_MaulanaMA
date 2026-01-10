namespace PerpusLSP
{
    public class Anggota
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }

        public Anggota(int id, string nama, string alamat)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
        }
    }
}
