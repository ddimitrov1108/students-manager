-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране:  6 май 2022 в 20:38
-- Версия на сървъра: 10.4.21-MariaDB
-- Версия на PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `students_manager`
--
drop database if exists students_manager;
create database students_manager;
use students_manager;

-- --------------------------------------------------------

--
-- Структура на таблица `edu_degree_types`
--

CREATE TABLE `edu_degree_types` (
  `id` int(11) NOT NULL,
  `degree` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `edu_degree_types`
--

INSERT INTO `edu_degree_types` (`id`, `degree`) VALUES
(1, 'Bachelor'),
(2, 'Masters'),
(3, 'PHD');

-- --------------------------------------------------------

--
-- Структура на таблица `edu_forms`
--

CREATE TABLE `edu_forms` (
  `id` int(11) NOT NULL,
  `form` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `edu_forms`
--

INSERT INTO `edu_forms` (`id`, `form`) VALUES
(1, 'full-time'),
(2, 'part-time'),
(3, 'abroad');

-- --------------------------------------------------------

--
-- Структура на таблица `edu_specialties`
--

CREATE TABLE `edu_specialties` (
  `id` int(11) NOT NULL,
  `specialty` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `edu_specialties`
--

INSERT INTO `edu_specialties` (`id`, `specialty`) VALUES
(1, 'Computer Science'),
(2, 'Software Engineering'),
(3, 'Data Analytics'),
(4, 'Computer Information Systems'),
(5, 'Information Technology'),
(6, 'Management Information Systems');

-- --------------------------------------------------------

--
-- Структура на таблица `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `facultyNumber` int(11) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `phoneNumber` varchar(20) NOT NULL,
  `degreeId` int(11) NOT NULL,
  `specialtyId` int(11) NOT NULL,
  `formId` int(11) NOT NULL,
  `year` int(11) NOT NULL,
  `gpa` double NOT NULL,
  `updated_at` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `students`
--

INSERT INTO `students` (`id`, `facultyNumber`, `firstName`, `lastName`, `phoneNumber`, `degreeId`, `specialtyId`, `formId`, `year`, `gpa`, `updated_at`, `created_at`) VALUES
(1, 1111111, 'Daniel', 'Dimitrov', '+1111111111', 1, 1, 2, 3, 5.14, '2022-03-14 23:38:09', '2022-03-14 21:38:09'),
(39, 19623347, 'Stoqn', 'Stoqnov', '0886161231', 2, 3, 1, 4, 6, '2022-04-30 16:42:56', '2022-04-30 09:14:56'),
(42, 19623346, 'Stefan', 'test', 'test123', 3, 2, 2, 3, 3, '2022-05-04 22:21:24', '2022-04-30 13:48:07'),
(44, 1, 't1', 't', 't', 1, 1, 1, 3, 5, '2022-05-04 22:20:26', '2022-05-04 19:20:22'),
(45, 196233452, 't', 't', 't', 1, 1, 1, 2, 2, '2022-05-06 21:32:04', '2022-05-06 18:32:04');

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `email` varchar(60) NOT NULL,
  `password` varchar(255) NOT NULL,
  `isAdmin` tinyint(1) NOT NULL,
  `updated_at` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`id`, `firstName`, `lastName`, `email`, `password`, `isAdmin`, `updated_at`, `created_at`) VALUES
(1, 'Daniel', 'Dimitrov', 'ddimitrov1108@gmail.com', '$2b$10$ycwTa4c7sGW0Aa3gCroFkuuVlloYD2eoaEUoum/9Y1T1m2JS5Anhu', 1, '2022-03-12 18:14:18', '2022-03-12 16:14:18'),
(2, 'Stoqn', 'Stoqnov', 'susu2606@gmail.com', '$2b$10$iXyLCjAnJxI6QE8tBjDcjeKGeKK9xUAlkmyhHgyyUDJpfdas8x6SG', 0, '2022-03-12 18:15:12', '2022-03-12 16:15:12');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `edu_degree_types`
--
ALTER TABLE `edu_degree_types`
  ADD PRIMARY KEY (`id`);

--
-- Индекси за таблица `edu_forms`
--
ALTER TABLE `edu_forms`
  ADD PRIMARY KEY (`id`);

--
-- Индекси за таблица `edu_specialties`
--
ALTER TABLE `edu_specialties`
  ADD PRIMARY KEY (`id`);

--
-- Индекси за таблица `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`),
  ADD KEY `degreeId` (`degreeId`),
  ADD KEY `specialtyId` (`specialtyId`),
  ADD KEY `formId` (`formId`);

--
-- Индекси за таблица `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `edu_degree_types`
--
ALTER TABLE `edu_degree_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `edu_forms`
--
ALTER TABLE `edu_forms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `edu_specialties`
--
ALTER TABLE `edu_specialties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`degreeId`) REFERENCES `edu_degree_types` (`id`),
  ADD CONSTRAINT `students_ibfk_2` FOREIGN KEY (`specialtyId`) REFERENCES `edu_specialties` (`id`),
  ADD CONSTRAINT `students_ibfk_3` FOREIGN KEY (`formId`) REFERENCES `edu_forms` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
