-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 06, 2020 at 01:04 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_ubayafriedchicken`
--

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE `bank` (
  `IdBank` char(2) NOT NULL,
  `nama` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bank`
--

INSERT INTO `bank` (`IdBank`, `nama`) VALUES
('01', 'Bank Central Asia'),
('02', 'Bank Mandiri');

-- --------------------------------------------------------

--
-- Table structure for table `diskon`
--

CREATE TABLE `diskon` (
  `iddiskon` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `jumlah` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `diskon_notajualdetil`
--

CREATE TABLE `diskon_notajualdetil` (
  `NotaJualDetil_IdNota` char(11) NOT NULL,
  `NotaJualDetil_IdProduk` char(5) NOT NULL,
  `diskon_iddiskon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `jabatan`
--

CREATE TABLE `jabatan` (
  `IdJabatan` char(2) NOT NULL,
  `Nama` char(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jabatan`
--

INSERT INTO `jabatan` (`IdJabatan`, `Nama`) VALUES
('01', 'Manager'),
('02', 'Sekretaris'),
('03', 'Kasir'),
('04', 'Koki'),
('05', 'Staff'),
('06', 'Driver');

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `IdKategori` char(2) NOT NULL,
  `Nama` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`IdKategori`, `Nama`) VALUES
('01', 'Drinks'),
('02', 'Makanan Berat'),
('03', 'Makanan Ringan'),
('04', 'Desserts');

-- --------------------------------------------------------

--
-- Table structure for table `notajual`
--

CREATE TABLE `notajual` (
  `IdNota` char(11) NOT NULL,
  `Tanggal` datetime DEFAULT NULL,
  `IdPegawai` varchar(2) NOT NULL,
  `IdPelanggan` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `notajualdetil`
--

CREATE TABLE `notajualdetil` (
  `IdNota` char(11) NOT NULL,
  `IdProduk` char(5) NOT NULL,
  `Harga` int(11) DEFAULT NULL,
  `Jumlah` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `notajual_has_promo`
--

CREATE TABLE `notajual_has_promo` (
  `IdNota` char(11) NOT NULL,
  `idPromo` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `notajual_reward`
--

CREATE TABLE `notajual_reward` (
  `reward_IdReward` char(2) NOT NULL,
  `NotaJual_IdNota` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `IdPegawai` char(5) NOT NULL,
  `Nama` varchar(45) DEFAULT NULL,
  `TglLahir` date DEFAULT NULL,
  `Alamat` varchar(100) DEFAULT NULL,
  `Gaji` bigint(20) DEFAULT NULL,
  `Username` varchar(8) DEFAULT NULL,
  `Password` varchar(8) DEFAULT NULL,
  `IdJabatan` char(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`IdPegawai`, `Nama`, `TglLahir`, `Alamat`, `Gaji`, `Username`, `Password`, `IdJabatan`) VALUES
('01001', 'Budianto', '1990-10-04', 'Jalan Tenggilis no 103', 10000000, 'budi12', 'budigant', '01'),
('02001', 'Danella', '1992-04-25', 'Jalan Kedong Cowek no 75', 6000000, 'daniella', 'dandan', '02'),
('04001', 'Robert', '1991-10-04', 'Jalan Panjang Jiwo no 23', 5000000, 'roberta2', 'robert12', '04'),
('04002', 'Putriana', '1993-04-25', 'Jalan Durian no 23', 5000000, 'putri', 'putriana', '04'),
('05001', 'Adi', '1992-10-04', 'Jalan Merak no 201', 2000000, 'adi304', 'adiadi', '05'),
('05002', 'Susana', '1994-08-26', 'Jalan Melati no 201', 2000000, 'suzana', 'susanaca', '05'),
('06001', 'Joko', '1995-02-12', 'Jalan Dukuh Kupang no 17', 2000000, 'jokowi', 'jokoswt', '06'),
('06002', 'Andi', '1998-05-25', 'Jalan Setro no 71', 2000000, 'andiandi', 'andigant', '06');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `IdPelanggan` char(5) NOT NULL,
  `Nama` varchar(50) DEFAULT NULL,
  `Alamat` varchar(100) DEFAULT NULL,
  `Telepon` varchar(45) DEFAULT NULL,
  `Saldo` bigint(20) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`IdPelanggan`, `Nama`, `Alamat`, `Telepon`, `Saldo`, `username`, `password`) VALUES
('01', 'Budi Hartono', 'Jalan Ngagel no 21', '081211122222', 0, 'budi123', 'budiganteng'),
('02', 'Ani Budiani', 'Jalan Sawentar no 77 ', '081388888888', 0, 'anicantik', 'anicantikbanget'),
('03', 'Tono Butono', 'Jalan Siwalankerto no 22', '081358564589', 0, 'tono55', 'tonoiyoiyo'),
('04', 'Hendrawan', 'Jalan Tenggilis no 33', '081278693020', 0, 'hendraha', 'hendraganteng');

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `IdProduk` char(5) NOT NULL,
  `Nama` varchar(45) DEFAULT NULL,
  `HargaJual` int(11) DEFAULT NULL,
  `Stok` int(11) DEFAULT NULL,
  `IdKategori` char(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`IdProduk`, `Nama`, `HargaJual`, `Stok`, `IdKategori`) VALUES
('01001', 'Coca Cola', 10000, 100, '01'),
('01002', 'Ice Lemon Tea', 10000, 200, '01'),
('01003', 'Air Mineral', 4000, 1000, '01'),
('01004', 'Milo', 8500, 100, '01'),
('01005', 'Fanta', 10000, 200, '01'),
('01006', 'Sprite', 10000, 200, '01'),
('01007', 'Ice Coffee', 9000, 100, '01'),
('01008', 'Hot Coffee', 10000, 100, '01'),
('02001', 'Ayam Goreng Original', 20000, 100, '02'),
('02002', 'Ayam Goreng Spicy', 20000, 100, '02'),
('02003', 'Nasi', 5000, 100, '02'),
('02004', 'Bubur Ayam', 15000, 100, '02'),
('02005', 'Spaghetti Supreme', 20000, 100, '02'),
('02006', 'Yakiniku Rice', 25000, 100, '02'),
('02007', 'Rice Box', 15000, 100, '02'),
('03001', 'Burger Deluxe', 12000, 100, '03'),
('03002', 'Cheese Burger', 15000, 100, '03'),
('03003', 'Fish Fillet', 12000, 100, '03'),
('03004', 'French Fries ', 15000, 100, '03'),
('04001', 'Pudding', 8000, 100, '04'),
('04002', 'Ice Cream', 10000, 100, '04'),
('04003', 'Waffle', 10000, 100, '04');

-- --------------------------------------------------------

--
-- Table structure for table `reward`
--

CREATE TABLE `reward` (
  `IdReward` char(2) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `jenis_barang` varchar(45) DEFAULT NULL,
  `batas_minimal` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `topup`
--

CREATE TABLE `topup` (
  `idTransaksi` char(2) NOT NULL,
  `Jumlah` bigint(20) DEFAULT NULL,
  `IdPelanggan` varchar(2) NOT NULL,
  `IdBank` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bank`
--
ALTER TABLE `bank`
  ADD PRIMARY KEY (`IdBank`);

--
-- Indexes for table `diskon`
--
ALTER TABLE `diskon`
  ADD PRIMARY KEY (`iddiskon`);

--
-- Indexes for table `diskon_notajualdetil`
--
ALTER TABLE `diskon_notajualdetil`
  ADD PRIMARY KEY (`NotaJualDetil_IdNota`,`NotaJualDetil_IdProduk`,`diskon_iddiskon`),
  ADD KEY `fk_NotaJualDetil_has_diskon_diskon1_idx` (`diskon_iddiskon`),
  ADD KEY `fk_NotaJualDetil_has_diskon_NotaJualDetil1_idx` (`NotaJualDetil_IdNota`,`NotaJualDetil_IdProduk`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`IdJabatan`);

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`IdKategori`);

--
-- Indexes for table `notajual`
--
ALTER TABLE `notajual`
  ADD PRIMARY KEY (`IdNota`),
  ADD KEY `fk_NotaJual_Pegawai1_idx` (`IdPegawai`),
  ADD KEY `fk_NotaJual_Pelanggan1_idx` (`IdPelanggan`);

--
-- Indexes for table `notajualdetil`
--
ALTER TABLE `notajualdetil`
  ADD PRIMARY KEY (`IdNota`,`IdProduk`),
  ADD KEY `fk_NotaJual_has_Produk_Produk1_idx` (`IdProduk`),
  ADD KEY `fk_NotaJual_has_Produk_NotaJual_idx` (`IdNota`);

--
-- Indexes for table `notajual_has_promo`
--
ALTER TABLE `notajual_has_promo`
  ADD PRIMARY KEY (`IdNota`,`idPromo`),
  ADD KEY `fk_NotaJual_has_promo_promo1_idx` (`idPromo`),
  ADD KEY `fk_NotaJual_has_promo_NotaJual1_idx` (`IdNota`);

--
-- Indexes for table `notajual_reward`
--
ALTER TABLE `notajual_reward`
  ADD PRIMARY KEY (`reward_IdReward`,`NotaJual_IdNota`),
  ADD KEY `fk_reward_has_NotaJual_NotaJual1_idx` (`NotaJual_IdNota`),
  ADD KEY `fk_reward_has_NotaJual_reward1_idx` (`reward_IdReward`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`IdPegawai`),
  ADD KEY `fk_Pegawai_Jabatan1_idx` (`IdJabatan`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`IdPelanggan`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`IdProduk`),
  ADD KEY `fk_Produk_Kategori1_idx` (`IdKategori`);

--
-- Indexes for table `reward`
--
ALTER TABLE `reward`
  ADD PRIMARY KEY (`IdReward`);

--
-- Indexes for table `topup`
--
ALTER TABLE `topup`
  ADD PRIMARY KEY (`idTransaksi`,`IdPelanggan`,`IdBank`),
  ADD KEY `fk_Transaksi_Pelanggan1_idx` (`IdPelanggan`),
  ADD KEY `fk_Transaksi_Bank1_idx` (`IdBank`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `diskon_notajualdetil`
--
ALTER TABLE `diskon_notajualdetil`
  ADD CONSTRAINT `fk_NotaJualDetil_has_diskon_NotaJualDetil1` FOREIGN KEY (`NotaJualDetil_IdNota`,`NotaJualDetil_IdProduk`) REFERENCES `notajualdetil` (`IdNota`, `IdProduk`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_NotaJualDetil_has_diskon_diskon1` FOREIGN KEY (`diskon_iddiskon`) REFERENCES `diskon` (`iddiskon`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notajual`
--
ALTER TABLE `notajual`
  ADD CONSTRAINT `fk_NotaJual_Pegawai1` FOREIGN KEY (`IdPegawai`) REFERENCES `pegawai` (`IdPegawai`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_NotaJual_Pelanggan1` FOREIGN KEY (`IdPelanggan`) REFERENCES `pelanggan` (`IdPelanggan`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notajualdetil`
--
ALTER TABLE `notajualdetil`
  ADD CONSTRAINT `fk_NotaJual_has_Produk_NotaJual` FOREIGN KEY (`IdNota`) REFERENCES `notajual` (`IdNota`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_NotaJual_has_Produk_Produk1` FOREIGN KEY (`IdProduk`) REFERENCES `produk` (`IdProduk`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notajual_has_promo`
--
ALTER TABLE `notajual_has_promo`
  ADD CONSTRAINT `fk_NotaJual_has_promo_NotaJual1` FOREIGN KEY (`IdNota`) REFERENCES `notajual` (`IdNota`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_NotaJual_has_promo_promo1` FOREIGN KEY (`idPromo`) REFERENCES `reward` (`IdReward`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notajual_reward`
--
ALTER TABLE `notajual_reward`
  ADD CONSTRAINT `fk_reward_has_NotaJual_NotaJual1` FOREIGN KEY (`NotaJual_IdNota`) REFERENCES `notajual` (`IdNota`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_reward_has_NotaJual_reward1` FOREIGN KEY (`reward_IdReward`) REFERENCES `reward` (`IdReward`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD CONSTRAINT `fk_Pegawai_Jabatan1` FOREIGN KEY (`IdJabatan`) REFERENCES `jabatan` (`IdJabatan`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `produk`
--
ALTER TABLE `produk`
  ADD CONSTRAINT `fk_Produk_Kategori1` FOREIGN KEY (`IdKategori`) REFERENCES `kategori` (`IdKategori`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `topup`
--
ALTER TABLE `topup`
  ADD CONSTRAINT `fk_Transaksi_Bank1` FOREIGN KEY (`IdBank`) REFERENCES `bank` (`IdBank`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Transaksi_Pelanggan1` FOREIGN KEY (`IdPelanggan`) REFERENCES `pelanggan` (`IdPelanggan`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
