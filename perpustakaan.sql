CREATE DATABASE IF NOT EXISTS perpustakaan;
USE perpustakaan;


CREATE TABLE IF NOT EXISTS anggota (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  nama VARCHAR(100) NOT NULL,
  alamat VARCHAR(200) NOT NULL
);


CREATE TABLE IF NOT EXISTS buku (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  judul VARCHAR(200) NOT NULL,
  pengarang VARCHAR(100) NOT NULL,
  tahun INT(11) NOT NULL,
  status VARCHAR(20) DEFAULT 'Tersedia'
);


CREATE TABLE IF NOT EXISTS peminjaman (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  anggota_id INT(11) NOT NULL,
  buku_id INT(11) NOT NULL,
  tanggal_pinjam DATE NOT NULL,
  tanggal_kembali DATE NOT NULL,
  tanggal_dikembalikan DATE NULL,
  status VARCHAR(20) DEFAULT 'Dipinjam',
  FOREIGN KEY (anggota_id) REFERENCES anggota(id),
  FOREIGN KEY (buku_id) REFERENCES buku(id)
);

INSERT INTO anggota (nama, alamat) VALUES 
('alif', 'mojokerto'),
('aya', 'jalan yos sudarso'),
('olan', 'jl kemanggisan'),
('alex', 'jl kesayangan'),
('heru', 'jl manisrenggo'),
('Ole', 'Citraland');

INSERT INTO buku (judul, pengarang, tahun, status) VALUES 
('Hamlet', 'Shakespeare', 1623, 'Tidak Tersedia'),
('Robin Hood', 'Howard Pyle', 1883, 'Tersedia'),
('Harry Potter 1', 'J. K. Rowling', 1997, 'Tersedia'),
('Harry Potter 2', 'J. K. Rowling', 1998, 'Tersedia'),
('Proklamasi', 'Soekarno', 1945, 'Tersedia'),
('Koala Kumal', 'Raditya Dika', 2015, 'Tersedia');

