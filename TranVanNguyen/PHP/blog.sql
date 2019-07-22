-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 22, 2019 at 12:53 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `blog`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `name`, `created_at`, `updated_at`, `deleted_at`) VALUES
(3, 'cat3', NULL, '2019-07-08 13:43:33', '2019-07-08 13:43:33'),
(5, 'cat1', '2019-06-28 12:07:47', '2019-06-28 12:43:00', '2019-06-28 12:43:00'),
(6, 'cat2', '2019-06-28 12:07:54', '2019-06-28 12:43:26', '2019-06-28 12:43:26'),
(7, 'cat1', '2019-06-28 12:16:36', '2019-06-28 12:45:03', '2019-06-28 12:45:03'),
(8, 'cat1', '2019-06-28 12:50:31', '2019-06-28 12:50:31', NULL),
(9, 'cat2', '2019-07-08 13:50:38', '2019-07-08 13:50:38', NULL),
(10, 'cat3', '2019-07-08 13:50:45', '2019-07-08 13:50:45', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `content` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` int(11) NOT NULL,
  `post_id` bigint(20) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `name`, `email`, `content`, `status`, `post_id`, `created_at`, `updated_at`) VALUES
(1, 'admin', 'tvngiagia@gmail.com', 'aaaaaaaaaaaa', 0, 10, '2019-07-12 14:00:22', '2019-07-19 13:32:41'),
(2, 'nguyen', 'taotaikhoan12321@gmail.com', 'aaaaassssssss', 0, 10, '2019-07-12 14:10:37', '2019-07-19 13:50:22'),
(3, 'sugar fiexd', 'ngquang21@gmail.com', 'asasasasa', 1, 10, '2019-07-12 14:10:50', '2019-07-19 13:32:50'),
(4, 'qweq', 'taotaikhoan12321@gmail.com', 'qweqweqweqw', 0, 8, '2019-07-22 07:14:59', '2019-07-22 07:15:34'),
(5, 'admin', 'taotaikhoan12321@gmail.com', 'aaaaaaaa', 1, 8, '2019-07-22 07:42:09', '2019-07-22 07:42:09'),
(6, 'admin', 'ngquang21@gmail.com', 'adasdasd', 1, 8, '2019-07-22 07:43:36', '2019-07-22 07:43:36');

-- --------------------------------------------------------

--
-- Table structure for table `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2019_06_24_195507_create_posts_table', 2),
(4, '2019_06_24_200804_create_categories_table', 3),
(5, '2019_06_24_200829_create_tags_table', 3),
(6, '2019_06_24_202153_create_tags_table', 4),
(7, '2019_06_24_203202_create_post__categories_table', 5),
(8, '2019_06_24_203218_create_post__tags_table', 5),
(9, '2019_07_12_201035_create_comments_table', 6);

-- --------------------------------------------------------

--
-- Table structure for table `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `user_id` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cover` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `title` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `content` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`id`, `user_id`, `cover`, `title`, `content`, `created_at`, `updated_at`, `status`) VALUES
(1, '1', 'images/2b-15274313985761343111032.jpg', 'My travel', '<p>Hi hi hi!!!!</p>', '2019-07-08 12:26:56', '2019-07-22 08:19:51', 0),
(2, '1', 'images/2b-15274313985761343111032.jpg', 'My travel', '<p>Hi hi hi!!!!</p>', '2019-07-08 12:29:43', '2019-07-08 12:29:43', 0),
(3, '1', 'images/05-15295778480541239561817.jpg', 'My travel', '<p>zzzzzzzz</p>', '2019-07-08 12:32:01', '2019-07-08 12:32:01', 1),
(4, '1', 'images/156258929831531144_1086793218174798_4310382470496256000_n.jpg', 'My travel', '<p>srgdgrgergrg</p>', '2019-07-08 12:34:58', '2019-07-08 12:34:58', 1),
(5, '1', 'images/15625893542-15241235880031554282075.jpg', 'My travel', '<p>srgdgrgergrg</p>', '2019-07-08 12:35:54', '2019-07-08 12:35:54', 1),
(8, '1', 'images/1562594936_2b-15274313985761343111032.jpg', 'My travel', '<p>dfgdfgdgg</p>', '2019-07-08 14:08:56', '2019-07-22 07:56:47', 1),
(9, '1', 'images/1562758057_2b-15274313985761343111032.jpg', 'zzzz', '<p><img alt=\"\" src=\"http://localhost:81/blog/public/photos/1/31531144_1086793218174798_4310382470496256000_n.jpg\" style=\"height:960px; width:768px\" /></p>', '2019-07-10 11:27:37', '2019-07-10 11:27:37', 1),
(10, '1', 'images/1562758493_2b-15274313985761343111032.jpg', 'zzzz', '<p><img alt=\"\" src=\"http://localhost:81/blog/public/photos/1/31531144_1086793218174798_4310382470496256000_n.jpg\" style=\"height:960px; width:768px\" /></p>', '2019-07-10 11:34:53', '2019-07-10 11:34:53', 1);

-- --------------------------------------------------------

--
-- Table structure for table `post__categories`
--

CREATE TABLE `post__categories` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `post_id` bigint(20) NOT NULL,
  `category_id` bigint(20) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `post__categories`
--

INSERT INTO `post__categories` (`id`, `post_id`, `category_id`, `created_at`, `updated_at`) VALUES
(1, 10, 9, '2019-07-10 11:34:53', '2019-07-10 11:34:53');

-- --------------------------------------------------------

--
-- Table structure for table `post__tags`
--

CREATE TABLE `post__tags` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `post_id` bigint(20) NOT NULL,
  `tag_id` bigint(20) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `post__tags`
--

INSERT INTO `post__tags` (`id`, `post_id`, `tag_id`, `created_at`, `updated_at`) VALUES
(1, 2, 1, '2019-07-08 12:29:44', '2019-07-08 12:29:44'),
(2, 3, 2, '2019-07-08 12:32:01', '2019-07-08 12:32:01'),
(3, 4, 1, '2019-07-08 12:34:58', '2019-07-08 12:34:58'),
(4, 5, 1, '2019-07-08 12:35:54', '2019-07-08 12:35:54'),
(5, 6, 2, '2019-07-08 12:44:41', '2019-07-08 12:44:41'),
(6, 7, 1, '2019-07-08 13:05:41', '2019-07-08 13:05:41'),
(7, 8, 1, '2019-07-08 14:08:56', '2019-07-08 14:08:56'),
(8, 8, 2, '2019-07-08 14:08:56', '2019-07-08 14:08:56'),
(9, 10, 2, '2019-07-10 11:34:53', '2019-07-10 11:34:53');

-- --------------------------------------------------------

--
-- Table structure for table `tags`
--

CREATE TABLE `tags` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tags`
--

INSERT INTO `tags` (`id`, `name`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'tag11', '2019-06-28 11:41:59', '2019-06-28 13:05:54', '2019-06-28 13:05:54'),
(2, 'tag2', '2019-06-28 11:42:05', '2019-06-28 11:42:05', NULL),
(3, 'tag3', '2019-06-28 11:42:10', '2019-06-28 11:42:10', NULL),
(4, 'tag22', '2019-07-22 07:50:58', '2019-07-22 07:51:24', '2019-07-22 07:51:24'),
(5, 'tag5', '2019-07-22 07:51:03', '2019-07-22 07:51:03', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `email_verified_at`, `password`, `remember_token`, `created_at`, `updated_at`) VALUES
(1, 'nguyen', 'tvngiagia@gmail.com', NULL, '$2y$10$6aYarkvEIWJsYsThNej1rO.8DIHiQIx/R1vSPjGfrbKJzYCXKVy..', 'iScAm0s1vBXV1mekwxhO7cqyc6r6n50YqCpY9GeARBqKLvFDi0jkmqmMKacg', '2019-06-24 12:40:06', '2019-06-24 12:40:06'),
(2, 'user', 'taotaikhoan12321@gmail.com', NULL, '$2y$10$A5hG//Ej8izXhVtyTAkNRunsH8.Ml8OGuXcq247brzK2MmI5QfEPK', NULL, '2019-07-22 07:13:16', '2019-07-22 07:13:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `post__categories`
--
ALTER TABLE `post__categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `post__tags`
--
ALTER TABLE `post__tags`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tags`
--
ALTER TABLE `tags`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `post__categories`
--
ALTER TABLE `post__categories`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `post__tags`
--
ALTER TABLE `post__tags`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tags`
--
ALTER TABLE `tags`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
