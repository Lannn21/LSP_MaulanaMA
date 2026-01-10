using MySql.Data.MySqlClient;

namespace PerpusLSP
{
    public class PerpustakaanService
    {
        public void TambahAnggota(Anggota a)
        {
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO anggota(nama, alamat) VALUES(@n, @a)", conn);
                cmd.Parameters.AddWithValue("@n", a.Nama);
                cmd.Parameters.AddWithValue("@a", a.Alamat);
                cmd.ExecuteNonQuery();
            }
        }

        public void TambahBuku(Buku b)
        {
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO buku(judul, pengarang, tahun, status) VALUES(@j, @p, @t, @s)", conn);

                cmd.Parameters.AddWithValue("@j", b.Judul);
                cmd.Parameters.AddWithValue("@p", b.Pengarang);
                cmd.Parameters.AddWithValue("@t", b.Tahun);
                cmd.Parameters.AddWithValue("@s", b.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void PinjamBuku(int idAnggota, int idBuku)
        {
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                DateTime tanggalPinjam = DateTime.Now;
                DateTime tanggalKembali = tanggalPinjam.AddDays(7);

                var cmd = new MySqlCommand(@"
            INSERT INTO peminjaman 
            (anggota_id, buku_id, tanggal_pinjam, tanggal_kembali, tanggal_dikembalikan, status) 
            VALUES(@a, @b, @p, @k, NULL, 'Dipinjam')", conn);
                cmd.Parameters.AddWithValue("@a", idAnggota);
                cmd.Parameters.AddWithValue("@b", idBuku);
                cmd.Parameters.AddWithValue("@p", tanggalPinjam);
                cmd.Parameters.AddWithValue("@k", tanggalKembali);
                cmd.ExecuteNonQuery();

                var update = new MySqlCommand(
                    "UPDATE buku SET status='Tidak Tersedia' WHERE id=@id", conn);
                update.Parameters.AddWithValue("@id", idBuku);
                update.ExecuteNonQuery();
            }
        }


        public List<Buku> GetAllBuku()
        {
            List<Buku> list = new List<Buku>();

            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM buku", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Buku(
                            dr.GetInt32("id"),
                            dr.GetString("judul"),
                            dr.GetString("pengarang"),
                            dr.GetInt32("tahun"),
                            dr.GetString("status")
                        ));
                    }
                }
            }

            return list;
        }
        public List<Anggota> GetAllAnggota()
        {
            List<Anggota> list = new List<Anggota>();
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM anggota", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Anggota(
                            dr.GetInt32("id"),
                            dr.GetString("nama"),
                            dr.GetString("alamat")
                        ));
                    }
                }
            }
            return list;
        }
        public List<Peminjaman> GetDaftarPeminjaman()
        {
            var list = new List<Peminjaman>();
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(@"
            SELECT p.id, a.nama AS NamaPeminjam, b.id AS IdBuku, 
                   b.judul AS NamaBuku, p.tanggal_pinjam AS TanggalPinjam, 
                   p.tanggal_kembali AS TanggalKembali, 
                   p.tanggal_dikembalikan AS TanggalDikembalikan,
                   p.status AS Status
            FROM peminjaman p
            JOIN anggota a ON p.anggota_id = a.id
            JOIN buku b ON p.buku_id = b.id
            ORDER BY p.id ASC", conn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Peminjaman
                        {
                            Id = dr.GetInt32("id"),
                            NamaPeminjam = dr.GetString("NamaPeminjam"),
                            IdBuku = dr.GetInt32("IdBuku"),
                            NamaBuku = dr.GetString("NamaBuku"),
                            TanggalPinjam = dr.GetDateTime("TanggalPinjam"),
                            TanggalKembali = dr.GetDateTime("TanggalKembali"),
                            TanggalDikembalikan = dr.IsDBNull(dr.GetOrdinal("TanggalDikembalikan"))
                                ? (DateTime?)null
                                : dr.GetDateTime("TanggalDikembalikan"),
                            Status = dr.GetString("Status")
                        });
                    }
                }
            }
            return list;
        }

        public void KembalikanBuku(int idPeminjaman, int idBuku)
        {
            using (var conn = DBUtil.GetConnection())
            {
                conn.Open();

                // Cek data peminjaman dan statusnya
                var cekQuery = new MySqlCommand(
                    "SELECT buku_id, status FROM peminjaman WHERE id=@id", conn);
                cekQuery.Parameters.AddWithValue("@id", idPeminjaman);

                using (var dr = cekQuery.ExecuteReader())
                {
                    if (!dr.Read())
                    {
                        throw new Exception("Data peminjaman tidak ditemukan!");
                    }

                    int bukuIdDiPeminjaman = dr.GetInt32("buku_id");
                    string status = dr.GetString("status");

                    if (bukuIdDiPeminjaman != idBuku)
                    {
                        throw new Exception("ID Buku tidak sesuai dengan data peminjaman!");
                    }

                    if (status == "Dikembalikan")
                    {
                        throw new Exception("Buku ini sudah dikembalikan sebelumnya!");
                    }
                }

                // Proses pengembalian
                var updatePeminjaman = new MySqlCommand(@"
            UPDATE peminjaman 
            SET status='Dikembalikan', tanggal_dikembalikan=@tgl 
            WHERE id=@id", conn);
                updatePeminjaman.Parameters.AddWithValue("@tgl", DateTime.Now);
                updatePeminjaman.Parameters.AddWithValue("@id", idPeminjaman);
                updatePeminjaman.ExecuteNonQuery();

                var updateBuku = new MySqlCommand(
                    "UPDATE buku SET status='Tersedia' WHERE id=@id", conn);
                updateBuku.Parameters.AddWithValue("@id", idBuku);
                updateBuku.ExecuteNonQuery();
            }
        }


    }
}
