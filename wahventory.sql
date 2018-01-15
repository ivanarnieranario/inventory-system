-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 12, 2017 at 05:40 AM
-- Server version: 10.1.22-MariaDB
-- PHP Version: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wahventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbagitem`
--

CREATE TABLE `tblbagitem` (
  `bagitem_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `bag_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '1',
  `property_no` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `item_condition` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblbags`
--

CREATE TABLE `tblbags` (
  `bag_id` int(11) NOT NULL,
  `bag_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbldepreciation`
--

CREATE TABLE `tbldepreciation` (
  `depreciation_id` int(11) NOT NULL,
  `salvage_value` double NOT NULL DEFAULT '0',
  `lifespan` int(11) NOT NULL DEFAULT '0',
  `depreciation` double NOT NULL DEFAULT '0',
  `book_value` double DEFAULT '0',
  `current_percent` double DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbldispose`
--

CREATE TABLE `tbldispose` (
  `dispose_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `holder_name` varchar(255) NOT NULL,
  `property_no` varchar(255) NOT NULL,
  `dispose_option` int(11) NOT NULL,
  `date_dispose` date NOT NULL,
  `reason` varchar(255) DEFAULT NULL,
  `remarks` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblfrom`
--

CREATE TABLE `tblfrom` (
  `from_id` int(11) NOT NULL,
  `from_name` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblholders`
--

CREATE TABLE `tblholders` (
  `holder_id` int(11) NOT NULL,
  `holder_name` varchar(255) NOT NULL,
  `isemployee` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblinventory`
--

CREATE TABLE `tblinventory` (
  `inventory_id` int(11) NOT NULL,
  `property_no` varchar(255) NOT NULL,
  `status_id` int(11) NOT NULL,
  `holder_id` int(11) NOT NULL,
  `date_received` date NOT NULL DEFAULT '0000-00-00',
  `remarks` text,
  `item_id` int(11) NOT NULL,
  `isreturn` tinyint(4) NOT NULL,
  `islost` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblitem`
--

CREATE TABLE `tblitem` (
  `item_id` int(11) NOT NULL,
  `isdonated` char(1) NOT NULL,
  `price` double DEFAULT '0',
  `details` text NOT NULL,
  `depreciation_id` int(11) DEFAULT NULL,
  `date_procured` date NOT NULL DEFAULT '0000-00-00',
  `available` tinyint(1) NOT NULL,
  `from_id` int(11) NOT NULL,
  `property_no` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblitemtype`
--

CREATE TABLE `tblitemtype` (
  `itemtype_id` int(11) NOT NULL,
  `type_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstatus`
--

CREATE TABLE `tblstatus` (
  `status_id` int(11) NOT NULL,
  `status_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstatus`
--

INSERT INTO `tblstatus` (`status_id`, `status_name`) VALUES
(3, 'Defective'),
(2, 'Not Working'),
(1, 'Working');

-- --------------------------------------------------------

--
-- Table structure for table `tbltechbag`
--

CREATE TABLE `tbltechbag` (
  `techbag_id` int(11) NOT NULL,
  `action_bag` varchar(255) NOT NULL,
  `travelinfo_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `property_no` varchar(255) NOT NULL,
  `item_condition` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbltravelinfo`
--

CREATE TABLE `tbltravelinfo` (
  `travelinfo_id` int(11) NOT NULL,
  `holder_id` int(11) NOT NULL,
  `bag_id` int(11) NOT NULL,
  `travel_location` varchar(255) NOT NULL,
  `from_date` date NOT NULL,
  `to_date` date NOT NULL,
  `isdone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbltype`
--

CREATE TABLE `tbltype` (
  `type_id` int(11) NOT NULL,
  `type_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `user_id` int(11) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `fullcontrol` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`user_id`, `fullname`, `username`, `password`, `fullcontrol`) VALUES
(1, 'Admin, Administrator', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbagitem`
--
ALTER TABLE `tblbagitem`
  ADD PRIMARY KEY (`bagitem_id`),
  ADD UNIQUE KEY `property_no` (`property_no`),
  ADD KEY `item_id` (`item_id`),
  ADD KEY `bag_id` (`bag_id`);

--
-- Indexes for table `tblbags`
--
ALTER TABLE `tblbags`
  ADD PRIMARY KEY (`bag_id`),
  ADD UNIQUE KEY `bag_name` (`bag_name`);

--
-- Indexes for table `tbldepreciation`
--
ALTER TABLE `tbldepreciation`
  ADD PRIMARY KEY (`depreciation_id`);

--
-- Indexes for table `tbldispose`
--
ALTER TABLE `tbldispose`
  ADD PRIMARY KEY (`dispose_id`),
  ADD UNIQUE KEY `property_no` (`property_no`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `tblfrom`
--
ALTER TABLE `tblfrom`
  ADD PRIMARY KEY (`from_id`),
  ADD UNIQUE KEY `from_name` (`from_name`);

--
-- Indexes for table `tblholders`
--
ALTER TABLE `tblholders`
  ADD PRIMARY KEY (`holder_id`),
  ADD UNIQUE KEY `holder_name` (`holder_name`);

--
-- Indexes for table `tblinventory`
--
ALTER TABLE `tblinventory`
  ADD PRIMARY KEY (`inventory_id`),
  ADD KEY `status_id` (`status_id`),
  ADD KEY `holder_id` (`holder_id`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `tblitem`
--
ALTER TABLE `tblitem`
  ADD PRIMARY KEY (`item_id`),
  ADD UNIQUE KEY `property_no` (`property_no`),
  ADD KEY `depreciation_id` (`depreciation_id`),
  ADD KEY `from_id` (`from_id`);

--
-- Indexes for table `tblitemtype`
--
ALTER TABLE `tblitemtype`
  ADD PRIMARY KEY (`itemtype_id`),
  ADD KEY `type_id` (`type_id`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `tblstatus`
--
ALTER TABLE `tblstatus`
  ADD PRIMARY KEY (`status_id`),
  ADD UNIQUE KEY `status_name` (`status_name`);

--
-- Indexes for table `tbltechbag`
--
ALTER TABLE `tbltechbag`
  ADD PRIMARY KEY (`techbag_id`),
  ADD KEY `travelinfo_id` (`travelinfo_id`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `tbltravelinfo`
--
ALTER TABLE `tbltravelinfo`
  ADD PRIMARY KEY (`travelinfo_id`),
  ADD KEY `holder_id` (`holder_id`),
  ADD KEY `bag_id` (`bag_id`);

--
-- Indexes for table `tbltype`
--
ALTER TABLE `tbltype`
  ADD PRIMARY KEY (`type_id`),
  ADD UNIQUE KEY `type_name` (`type_name`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbagitem`
--
ALTER TABLE `tblbagitem`
  MODIFY `bagitem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `tblbags`
--
ALTER TABLE `tblbags`
  MODIFY `bag_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `tbldepreciation`
--
ALTER TABLE `tbldepreciation`
  MODIFY `depreciation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
--
-- AUTO_INCREMENT for table `tbldispose`
--
ALTER TABLE `tbldispose`
  MODIFY `dispose_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `tblfrom`
--
ALTER TABLE `tblfrom`
  MODIFY `from_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `tblholders`
--
ALTER TABLE `tblholders`
  MODIFY `holder_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `tblinventory`
--
ALTER TABLE `tblinventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
--
-- AUTO_INCREMENT for table `tblitem`
--
ALTER TABLE `tblitem`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
--
-- AUTO_INCREMENT for table `tblitemtype`
--
ALTER TABLE `tblitemtype`
  MODIFY `itemtype_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT for table `tblstatus`
--
ALTER TABLE `tblstatus`
  MODIFY `status_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbltechbag`
--
ALTER TABLE `tbltechbag`
  MODIFY `techbag_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `tbltravelinfo`
--
ALTER TABLE `tbltravelinfo`
  MODIFY `travelinfo_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbltype`
--
ALTER TABLE `tbltype`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblbagitem`
--
ALTER TABLE `tblbagitem`
  ADD CONSTRAINT `tblbagitem_ibfk_1` FOREIGN KEY (`bag_id`) REFERENCES `tblbags` (`bag_id`),
  ADD CONSTRAINT `tblbagitem_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `tblitem` (`item_id`);

--
-- Constraints for table `tbldispose`
--
ALTER TABLE `tbldispose`
  ADD CONSTRAINT `tbldispose_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `tblitem` (`item_id`);

--
-- Constraints for table `tblinventory`
--
ALTER TABLE `tblinventory`
  ADD CONSTRAINT `tblinventory_ibfk_1` FOREIGN KEY (`holder_id`) REFERENCES `tblholders` (`holder_id`),
  ADD CONSTRAINT `tblinventory_ibfk_2` FOREIGN KEY (`status_id`) REFERENCES `tblstatus` (`status_id`),
  ADD CONSTRAINT `tblinventory_ibfk_3` FOREIGN KEY (`item_id`) REFERENCES `tblitem` (`item_id`);

--
-- Constraints for table `tblitem`
--
ALTER TABLE `tblitem`
  ADD CONSTRAINT `tblitem_ibfk_1` FOREIGN KEY (`from_id`) REFERENCES `tblfrom` (`from_id`),
  ADD CONSTRAINT `tblitem_ibfk_2` FOREIGN KEY (`depreciation_id`) REFERENCES `tbldepreciation` (`depreciation_id`);

--
-- Constraints for table `tblitemtype`
--
ALTER TABLE `tblitemtype`
  ADD CONSTRAINT `tblitemtype_ibfk_1` FOREIGN KEY (`type_id`) REFERENCES `tbltype` (`type_id`),
  ADD CONSTRAINT `tblitemtype_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `tblitem` (`item_id`);

--
-- Constraints for table `tbltechbag`
--
ALTER TABLE `tbltechbag`
  ADD CONSTRAINT `tbltechbag_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `tblitem` (`item_id`),
  ADD CONSTRAINT `tbltechbag_ibfk_2` FOREIGN KEY (`travelinfo_id`) REFERENCES `tbltravelinfo` (`travelinfo_id`);

--
-- Constraints for table `tbltravelinfo`
--
ALTER TABLE `tbltravelinfo`
  ADD CONSTRAINT `tbltravelinfo_ibfk_1` FOREIGN KEY (`holder_id`) REFERENCES `tblholders` (`holder_id`),
  ADD CONSTRAINT `tbltravelinfo_ibfk_2` FOREIGN KEY (`bag_id`) REFERENCES `tblbags` (`bag_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
