# PerpusLSP - Sistem Manajemen Perpustakaan

Aplikasi desktop manajemen perpustakaan menggunakan C# Windows Forms dan MySQL database.

## Fitur Utama

- **Login Admin**: Autentikasi untuk admin dengan username dan password
- **Manajemen Anggota**: Tambah dan kelola data anggota perpustakaan
- **Manajemen Buku**: Tambah dan kelola koleksi buku perpustakaan
- **Peminjaman Buku**: Proses peminjaman buku oleh anggota (durasi 7 hari)
- **Pengembalian Buku**: Proses pengembalian buku yang dipinjam
- **Katalog Buku**: Tampilan daftar semua buku perpustakaan
- **Riwayat Peminjaman**: Melihat riwayat transaksi peminjaman

## Teknologi yang Digunakan

- **Framework**: .NET 10.0 Windows Forms
- **Database**: MySQL
- **Library**: MySql.Data v9.5.0
- **Language**: C# 

## Struktur Database

Database `perpustakaan` memiliki 3 tabel utama:

### Tabel `anggota`
- `id` (INT, PRIMARY KEY, AUTO_INCREMENT)
- `nama` (VARCHAR(100))
- `alamat` (VARCHAR(200))

### Tabel `buku`
- `id` (INT, PRIMARY KEY, AUTO_INCREMENT)
- `judul` (VARCHAR(200))
- `pengarang` (VARCHAR(100))
- `tahun` (INT)
- `status` (VARCHAR(20), default: 'Tersedia')

### Tabel `peminjaman`
- `id` (INT, PRIMARY KEY, AUTO_INCREMENT)
- `anggota_id` (INT, FOREIGN KEY → anggota.id)
- `buku_id` (INT, FOREIGN KEY → buku.id)
- `tanggal_pinjam` (DATE)
- `tanggal_kembali` (DATE)
- `tanggal_dikembalikan` (DATE, nullable)
- `status` (VARCHAR(20), default: 'Dipinjam')

## Instalasi dan Konfigurasi

### Prasyarat
- .NET 10.0 SDK atau lebih tinggi
- MySQL Server
- Visual Studio 2022 atau IDE C# lainnya

### Langkah Instalasi

1. **Clone atau Download Repository**
   ```bash
   git clone <repository-url>
   cd PerpusLSP
   ```

2. **Setup Database**
   - Buka MySQL client atau phpMyAdmin
   - Import file `perpustakaan.sql`
   ```bash
   mysql -u root -p < perpustakaan.sql
   ```

3. **Konfigurasi Koneksi Database**
   - Buka file `DBUtil.cs`
   - Sesuaikan connection string dengan konfigurasi MySQL Anda
   ```csharp
   private static string conn = "server=localhost;database=perpustakaan;uid=root;pwd=;";
   ```

4. **Restore NuGet Packages**
   ```bash
   dotnet restore
   ```

5. **Build Project**
   ```bash
   dotnet build
   ```

6. **Run Aplikasi**
   ```bash
   dotnet run
   ```
   Atau jalankan melalui Visual Studio dengan menekan F5

## Kredensial Login

### Admin
- **Username**: `admin`
- **Password**: `admin123`

### User Anggota
Anggota dapat langsung mengakses katalog buku tanpa login

## Struktur Project

```
PerpusLSP/
├── Models/
│   ├── Anggota.cs              # Model data anggota
│   ├── Buku.cs                 # Model data buku
│   └── Peminjaman.cs           # Model data peminjaman
├── Forms/
│   ├── Login.cs                # Form login
│   ├── FormDashboard.cs        # Dashboard admin
│   ├── Formanggota.cs          # Form tambah anggota
│   ├── Formbuku.cs             # Form tambah buku
│   ├── Formpeminjaman.cs       # Form peminjaman buku
│   ├── Formkatalog.cs          # Form katalog buku
│   └── Formriwayat.cs          # Form riwayat peminjaman
├── Services/
│   └── PerpustakaanService.cs  # Business logic layer
├── Utilities/
│   └── DBUtil.cs               # Database connection utility
├── Program.cs                  # Entry point aplikasi
├── perpustakaan.sql            # Database schema & data
├── PerpusLSP.csproj            # Project configuration
└── PerpusLSP.sln               # Solution file
```

## Validasi Input

### Form Anggota
- Nama: Hanya boleh berisi huruf dan spasi
- Nama dan Alamat: Tidak boleh kosong

### Form Buku
- Judul, Pengarang, Tahun: Tidak boleh kosong
- Tahun: Harus berupa angka

### Form Peminjaman
- ID Anggota dan ID Buku: Harus dipilih/diisi
- Validasi ketersediaan buku sebelum peminjaman

## Alur Kerja Aplikasi

1. **Login sebagai Admin** → Akses ke dashboard admin dengan semua fitur
2. **Tambah Anggota** → Input data anggota baru ke sistem
3. **Tambah Buku** → Input data buku baru ke koleksi perpustakaan
4. **Peminjaman** → Admin memproses peminjaman buku oleh anggota
5. **Katalog** → Melihat daftar semua buku dengan status ketersediaan
6. **Riwayat** → Melihat dan memproses pengembalian buku
7. **User Anggota** → Dapat langsung melihat katalog buku tanpa login

## Fitur Khusus

- **Auto-update Status Buku**: Status buku otomatis berubah menjadi "Tidak Tersedia" saat dipinjam dan "Tersedia" saat dikembailkan
- **Durasi Peminjaman**: Otomatis 7 hari dari tanggal pinjam
- **Validasi Pengembalian**: Cek apakah buku sudah dikembalikan sebelumnya
- **Data Sample**: Database sudah terisi dengan 6 anggota dan 6 buku untuk testing

## Troubleshooting

### Error Koneksi Database
- Pastikan MySQL Server sudah berjalan
- Cek username, password, dan nama database di `DBUtil.cs`
- Pastikan database `perpustakaan` sudah dibuat

### Error Build
- Pastikan .NET 10.0 SDK sudah terinstall
- Jalankan `dotnet restore` untuk restore NuGet packages
- Cek compatibility Windows Forms dengan OS Anda

### Error MySQL.Data
- Install package MySql.Data versi 9.5.0
```bash
dotnet add package MySql.Data --version 9.5.0
```


