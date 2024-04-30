-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2024 at 04:19 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ordinario`
--

-- --------------------------------------------------------

--
-- Table structure for table `auction`
--

CREATE TABLE `auction` (
  `AuctionID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `startingbid` bigint(20) NOT NULL,
  `currentbid` bigint(20) NOT NULL DEFAULT 0,
  `enddate` date NOT NULL,
  `auctionstatus` varchar(10) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `auction`
--

INSERT INTO `auction` (`AuctionID`, `ItemID`, `startingbid`, `currentbid`, `enddate`, `auctionstatus`) VALUES
(2, 8, 6180, 7000, '2024-10-19', 'Active'),
(3, 10, 7210, 0, '2024-09-30', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustID` int(10) NOT NULL,
  `CustFname` varchar(15) NOT NULL,
  `CustLname` varchar(10) NOT NULL,
  `CustContact` varchar(11) NOT NULL,
  `CustAddress` varchar(30) NOT NULL,
  `CustStatus` varchar(10) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustID`, `CustFname`, `CustLname`, `CustContact`, `CustAddress`, `CustStatus`) VALUES
(3, 'Ver', 'Borje', '09380422898', 'Pamorangon', 'Active'),
(4, 'Michael', 'Borje', '09123519944', 'Pamorangon', 'Active'),
(5, 'Sean', 'Borje', '09123457890', 'Pamorangon', 'Active'),
(6, 'Taichi', 'Yamada', '09091112222', 'Gubat', 'Active'),
(7, 'Roberto', 'Escobar', '09564760112', 'Mancruz', 'Active'),
(8, 'Robin', 'Hood', '09091234567', 'Pamorangon', 'Active'),
(9, 'Arden', 'De Ramos', '09876543215', 'Calasgasan', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(15) NOT NULL,
  `ItemValue` varchar(15) NOT NULL,
  `ItemType` int(11) NOT NULL,
  `Status` varchar(10) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`ItemID`, `ItemName`, `ItemValue`, `ItemType`, `Status`) VALUES
(6, 'Omega', 'n/a', 3, 'Active'),
(7, 'Tala', 'n/a', 2, 'Redeemed'),
(8, 'Rolex', 'n/a', 3, 'Auctioned'),
(9, 'Cartier', 'n/a', 2, 'Active'),
(10, 'Rolex', 'n/a', 3, 'Auctioned');

-- --------------------------------------------------------

--
-- Table structure for table `itemtypes`
--

CREATE TABLE `itemtypes` (
  `ItemTypeID` int(11) NOT NULL,
  `ItemTypeName` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `itemtypes`
--

INSERT INTO `itemtypes` (`ItemTypeID`, `ItemTypeName`) VALUES
(1, 'Ring'),
(2, 'Necklace'),
(3, 'Watch');

-- --------------------------------------------------------

--
-- Table structure for table `pawncards`
--

CREATE TABLE `pawncards` (
  `PcardID` int(11) NOT NULL,
  `PawnDate` date NOT NULL,
  `MaturityDate` date NOT NULL,
  `ExpiryDate` date NOT NULL,
  `LoanAmount` int(11) NOT NULL,
  `Balance` int(11) NOT NULL,
  `Cnum` int(11) NOT NULL,
  `Itemnum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pawncards`
--

INSERT INTO `pawncards` (`PcardID`, `PawnDate`, `MaturityDate`, `ExpiryDate`, `LoanAmount`, `Balance`, `Cnum`, `Itemnum`) VALUES
(5, '2024-04-18', '2024-05-18', '2024-09-18', 8240, 7290, 4, 6),
(6, '2024-04-18', '2024-05-18', '2024-08-14', 1030, 0, 3, 7),
(7, '2024-04-19', '2024-05-19', '2024-09-19', 6180, 5230, 3, 8),
(8, '2024-04-21', '2024-05-21', '2024-08-21', 10300, 10300, 6, 9),
(9, '2024-04-30', '2024-05-30', '2024-08-30', 7210, 7210, 7, 10);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `TransactionID` int(11) NOT NULL,
  `Cno` int(11) NOT NULL,
  `Itemno` int(11) NOT NULL,
  `T_amount` int(11) NOT NULL,
  `T_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`TransactionID`, `Cno`, `Itemno`, `T_amount`, `T_Date`) VALUES
(2, 3, 7, 1000, '2024-04-20'),
(3, 4, 6, 1000, '2024-04-20'),
(4, 3, 7, 30, '2024-04-20'),
(5, 3, 7, 1030, '2024-04-20'),
(6, 3, 7, 1030, '2024-04-20'),
(7, 3, 7, 1030, '2024-04-20'),
(8, 3, 8, 1000, '2024-04-24');

-- --------------------------------------------------------

--
-- Table structure for table `transfers`
--

CREATE TABLE `transfers` (
  `Tnum` int(11) NOT NULL,
  `Inum` int(11) NOT NULL,
  `Anum` int(11) NOT NULL,
  `ItemTransferDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transfers`
--

INSERT INTO `transfers` (`Tnum`, `Inum`, `Anum`, `ItemTransferDate`) VALUES
(2, 8, 2, '2024-04-30'),
(3, 10, 3, '2024-04-30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auction`
--
ALTER TABLE `auction`
  ADD PRIMARY KEY (`AuctionID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustID`),
  ADD UNIQUE KEY `CustID_2` (`CustID`),
  ADD KEY `CustID` (`CustID`),
  ADD KEY `CustID_3` (`CustID`),
  ADD KEY `CustID_4` (`CustID`),
  ADD KEY `CustID_5` (`CustID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `itemtypes`
--
ALTER TABLE `itemtypes`
  ADD PRIMARY KEY (`ItemTypeID`);

--
-- Indexes for table `pawncards`
--
ALTER TABLE `pawncards`
  ADD PRIMARY KEY (`PcardID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransactionID`);

--
-- Indexes for table `transfers`
--
ALTER TABLE `transfers`
  ADD PRIMARY KEY (`Tnum`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auction`
--
ALTER TABLE `auction`
  MODIFY `AuctionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `itemtypes`
--
ALTER TABLE `itemtypes`
  MODIFY `ItemTypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pawncards`
--
ALTER TABLE `pawncards`
  MODIFY `PcardID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransactionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `transfers`
--
ALTER TABLE `transfers`
  MODIFY `Tnum` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
