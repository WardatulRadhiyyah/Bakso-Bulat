-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 29 Apr 2021 pada 03.22
-- Versi server: 10.4.18-MariaDB
-- Versi PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `baksobulat`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `menu_bakso`
--

CREATE TABLE `menu_bakso` (
  `id` int(11) NOT NULL,
  `Menu` varchar(50) NOT NULL,
  `Harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `menu_bakso`
--

INSERT INTO `menu_bakso` (`id`, `Menu`, `Harga`) VALUES
(1, 'Bakso Keju', 22000),
(2, 'Bakso Urat ', 25000),
(3, 'Bakso Pedas ', 23000),
(4, 'Bakso Cuanki', 20000),
(5, 'Bakso Biasa ', 15000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `menu_bakso`
--
ALTER TABLE `menu_bakso`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `menu_bakso`
--
ALTER TABLE `menu_bakso`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
