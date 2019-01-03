-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2019 at 01:07 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `connectcsharptomysql`
--
CREATE DATABASE IF NOT EXISTS `connectcsharptomysql` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `connectcsharptomysql`;

-- --------------------------------------------------------

--
-- Table structure for table `biodata`
--

CREATE TABLE `biodata` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `gender` varchar(15) NOT NULL,
  `date_born` varchar(30) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `biodata`
--

INSERT INTO `biodata` (`id`, `name`, `gender`, `date_born`, `phone`, `address`) VALUES
(1, 'Richie P.', 'Male', '24 October 1998', '+6289606403383', 'Jln. ngehe Gang asd No 24444'),
(2, 'Prila F. L.', 'Female', '22 July 1994', '+6281916231777', 'Jln. Pulau Sebatik No. 32'),
(3, 'Agusta Gde', 'Male', '30 September 1994', '+6239238649832', 'Jln. asdhasd Gang aklsdnaskj No 213.'),
(4, 'Mang Pastra', 'Male', '13 April 1992', '+6289606678999', 'Jl. ajnfsdjfnsdjkf 1894723 GG akdsnsakj 2'),
(11, 'Testing', 'Male', '10 May 1996', '+6289347326', 'kjsdhf');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `biodata`
--
ALTER TABLE `biodata`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `biodata`
--
ALTER TABLE `biodata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
