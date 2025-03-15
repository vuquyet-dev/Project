-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 18, 2024 lúc 02:45 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `ql_nhahang`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cosonhahang`
--

CREATE TABLE `cosonhahang` (
  `id` int(11) NOT NULL,
  `diachi` varchar(255) NOT NULL,
  `mota` text DEFAULT NULL,
  `hinhanh` varchar(255) DEFAULT NULL,
  `thongtinlienlac` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `cosonhahang`
--

INSERT INTO `cosonhahang` (`id`, `diachi`, `mota`, `hinhanh`, `thongtinlienlac`) VALUES
(1, 'Số 1, Lê Thái Tổ, Hoàn Kiếm, Hà Nội', 'Nhà hàng nằm ngay trung tâm với tầm nhìn ra Hồ Gươm, mang phong cách kiến trúc cổ điển pha lẫn hiện đại.', 'ho_guom.jpg', '0123456789 - hoguom@restaurant.com'),
(2, 'Số 123, Đường Bạch Đằng, Quận Hải Châu, Thành phố Đà Nẵng', 'Nhà hàng bên sông Hàn với không gian thoáng mát, phù hợp cho các buổi tối lãng mạn và sự kiện gia đình.', 'da_nang.jpg', '0234567890 - danang@restaurant.com'),
(3, 'Tầng 81, Landmark 81, Số 208, Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP. Hồ Chí Minh', 'Nhà hàng sang trọng tại tầng cao nhất của Landmark 81, nơi thực khách có thể ngắm toàn cảnh thành phố.', 'landmark81.jpg', '0345678901 - landmark81@restaurant.com'),
(4, 'Số 20, Đường Hạ Long, Bãi Cháy, Thành phố Hạ Long, Tỉnh Quảng Ninh', 'Nhà hàng ven biển với không gian mở và thiết kế hòa quyện với thiên nhiên, tầm nhìn hướng vịnh Hạ Long.', 'ha_long.jpg', '0456789012 - halong@restaurant.com');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `datban`
--

CREATE TABLE `datban` (
  `id` int(11) NOT NULL,
  `ten_khach_hang` varchar(255) DEFAULT NULL,
  `so_dien_thoai` varchar(20) DEFAULT NULL,
  `ngay_dat` date DEFAULT NULL,
  `gio_dat` time DEFAULT NULL,
  `so_luong_khach` int(11) DEFAULT NULL,
  `ghi_chu` text DEFAULT NULL,
  `soban_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `datban`
--

INSERT INTO `datban` (`id`, `ten_khach_hang`, `so_dien_thoai`, `ngay_dat`, `gio_dat`, `so_luong_khach`, `ghi_chu`, `soban_id`) VALUES
(1, 'Quyết', '3123456789', '2024-10-30', '20:26:00', 2, 'sfdgsdfg', 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `douong`
--

CREATE TABLE `douong` (
  `id` int(11) NOT NULL,
  `tenmon` varchar(150) NOT NULL,
  `loaimon` varchar(50) NOT NULL,
  `gia` varchar(10) NOT NULL,
  `thanhphan` text NOT NULL,
  `thongtinmon` text NOT NULL,
  `hinhanh` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `douong`
--

INSERT INTO `douong` (`id`, `tenmon`, `loaimon`, `gia`, `thanhphan`, `thongtinmon`, `hinhanh`) VALUES
(1, 'Margarita', 'Cocktail', '125000', 'Tequila, Triple Sec, nước chanh', 'Cocktail Margarita tươi mát, vị chanh dịu ngọt', 'margarita.jpg'),
(2, 'Cosmopolitan', 'Cocktail', '150000', 'Vodka, Cointreau, nước ép nam việt quất, nước chanh', 'Cocktail Cosmopolitan hiện đại và phong cách', 'cosmopolitan.jpg'),
(3, 'Daiquiri', 'Cocktail', '140000', 'Rum, nước chanh, đường', 'Daiquiri cổ điển, vị chua ngọt hài hòa', 'daiquiri.jpg'),
(4, 'Martini', 'Cocktail', '160000', 'Gin, Vermouth', 'Martini thanh lịch, kết hợp Gin và Vermouth hoàn hảo', 'martini.jpg'),
(5, 'Mojito', 'Cocktail', '130000', 'Rum, lá bạc hà, nước soda, đường, nước chanh', 'Mojito mát lạnh, hương vị bạc hà sảng khoái', 'mojito.jpg'),
(6, 'Nước ép cam', 'Nước ép', '75000', 'Cam tươi', 'Nước ép cam tươi nguyên chất, giàu vitamin C', 'nuoc_ep_cam.jpg'),
(7, 'Nước ép cà rốt', 'Nước ép', '60000', 'Cà rốt tươi', 'Nước ép cà rốt tươi, tốt cho sức khỏe và làn da', 'nuoc_ep_carot.jpg'),
(8, 'Nước ép dưa hấu', 'Nước ép', '70000', 'Dưa hấu tươi', 'Nước ép dưa hấu ngọt mát, giải nhiệt', 'nuoc_ep_dua_hau.jpg'),
(9, 'Nước ép táo', 'Nước ép', '80000', 'Táo tươi', 'Nước ép táo tươi, giàu chất chống oxy hóa', 'nuoc_ep_tao.jpg'),
(10, 'Nước ép ổi', 'Nước ép', '65000', 'Ổi tươi', 'Nước ép ổi ngọt thơm, giàu vitamin C', 'nuoc_ep_oi.jpg'),
(11, 'Bia Tiger', 'Bia', '45000', 'Lúa mạch, hoa bia', 'Bia Tiger truyền thống, vị đậm đà', 'bia_tiger.jpg'),
(12, 'Bia Heineken', 'Bia', '50000', 'Lúa mạch, hoa bia', 'Bia Heineken nổi tiếng, hương vị đặc trưng', 'bia_heineken.jpg'),
(13, 'Bia Budweiser', 'Bia', '55000', 'Lúa mạch, hoa bia', 'Bia Budweiser với hương vị mạnh mẽ', 'bia_budweiser.jpg'),
(14, 'Bia Sapporo', 'Bia', '60000', 'Lúa mạch, hoa bia', 'Bia Sapporo từ Nhật Bản, nhẹ nhàng và tinh tế', 'bia_sapporo.jpg'),
(15, 'Bia Corona', 'Bia', '75000', 'Lúa mạch, hoa bia', 'Bia Corona kết hợp hoàn hảo với chanh tươi', 'bia_corona.jpg'),
(16, 'Cà phê đen', 'Cà phê', '10000', 'Cà phê nguyên chất, nước', 'Cà phê đen đậm đà, vị truyền thống', 'cafe_den.jpg'),
(17, 'Cà phê sữa', 'Cà phê', '12500', 'Cà phê, sữa đặc', 'Cà phê sữa thơm ngon, đậm đà', 'cafe_sua.jpg'),
(18, 'Espresso', 'Cà phê', '20000', 'Espresso nguyên chất', 'Cà phê Espresso đậm đặc, giàu hương vị', 'espresso.jpg'),
(19, 'Americano', 'Cà phê', '15000', 'Espresso, nước nóng', 'Cà phê Americano nhẹ nhàng và thanh mát', 'americano.jpg'),
(20, 'Latte', 'Cà phê', '25000', 'Espresso, sữa tươi', 'Latte mịn màng với lớp sữa ấm áp', 'latte.jpg'),
(21, 'Trà sữa trân châu', 'Trà', '15000', 'Trà đen, sữa, trân châu', 'Trà sữa kèm trân châu dai ngon', 'tra_sua_tran_chau.jpg'),
(22, 'Trà đào cam sả', 'Trà', '17500', 'Trà, đào, cam, sả', 'Trà đào cam sả thơm mát', 'tra_dao_cam_sa.jpg'),
(23, 'Trà chanh', 'Trà', '10000', 'Trà, chanh, đường', 'Trà chanh thanh mát', 'tra_chanh.jpg'),
(24, 'Trà nhài', 'Trà', '12000', 'Trà nhài, mật ong', 'Trà nhài thơm ngát và ngọt ngào', 'tra_nhai.jpg'),
(25, 'Trà bạc hà', 'Trà', '14000', 'Trà xanh, bạc hà', 'Trà bạc hà thanh mát và sảng khoái', 'tra_bac_ha.jpg'),
(26, 'Rượu vang đỏ', 'Rượu', '500000', 'Nho đỏ', 'Rượu vang đỏ cao cấp, hương vị đậm đà', 'ruou_vang_do.jpg'),
(27, 'Rượu vang trắng', 'Rượu', '480000', 'Nho trắng', 'Rượu vang trắng thanh mát, hương vị nhẹ nhàng', 'ruou_vang_trang.jpg'),
(28, 'Champagne', 'Rượu', '600000', 'Nho', 'Champagne sang trọng, thích hợp cho các buổi tiệc', 'champagne.jpg'),
(29, 'Whiskey', 'Rượu', '700000', 'Ngũ cốc', 'Whiskey cao cấp, vị mạnh mẽ', 'whiskey.jpg'),
(30, 'Tequila', 'Rượu', '650000', 'Cây thùa xanh', 'Tequila độc đáo, vị cay nồng', 'tequila.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaidouong`
--

CREATE TABLE `loaidouong` (
  `id` int(11) NOT NULL,
  `loaimon` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `loaidouong`
--

INSERT INTO `loaidouong` (`id`, `loaimon`) VALUES
(1, 'Cocktail'),
(2, 'Nước ép'),
(3, 'Bia'),
(4, 'Cà phê'),
(5, 'Trà'),
(6, 'Rượu');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaimonkhaivi`
--

CREATE TABLE `loaimonkhaivi` (
  `id` int(11) NOT NULL,
  `loaimon` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `loaimonkhaivi`
--

INSERT INTO `loaimonkhaivi` (`id`, `loaimon`) VALUES
(1, 'Soup'),
(2, 'Salad'),
(3, 'Gỏi/Nộm');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaimontrangmieng`
--

CREATE TABLE `loaimontrangmieng` (
  `id` int(11) NOT NULL,
  `loaimon` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `loaimontrangmieng`
--

INSERT INTO `loaimontrangmieng` (`id`, `loaimon`) VALUES
(1, 'Bánh Ngọt'),
(2, 'Kem Lạnh'),
(3, 'Trái Cây'),
(4, 'Chè Truyền Thống');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaithucdonchinh`
--

CREATE TABLE `loaithucdonchinh` (
  `id` int(11) NOT NULL,
  `loaimon` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `loaithucdonchinh`
--

INSERT INTO `loaithucdonchinh` (`id`, `loaimon`) VALUES
(1, 'Thịt Bò Cao Cấp'),
(2, 'Thịt Lợn Thượng Hạng'),
(3, 'Hải Sản Tươi Sống'),
(4, 'Set Thực Đơn Sang Trọng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `monkhaivi`
--

CREATE TABLE `monkhaivi` (
  `id` int(11) NOT NULL,
  `tenmon` varchar(150) NOT NULL,
  `loaimon` varchar(50) NOT NULL,
  `gia` varchar(10) NOT NULL,
  `thanhphan` text NOT NULL,
  `thongtinmon` text NOT NULL,
  `hinhanh` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `monkhaivi`
--

INSERT INTO `monkhaivi` (`id`, `tenmon`, `loaimon`, `gia`, `thanhphan`, `thongtinmon`, `hinhanh`) VALUES
(1, 'Soup Bí Đỏ', 'Soup', '90000', 'Bí đỏ, kem tươi, hạt bí, hành tây', 'Soup bí đỏ sánh mịn, thơm ngon với vị ngọt tự nhiên từ bí đỏ, kết hợp với kem tươi.', 'soup_bi_do.jpg'),
(2, 'Salad Caesar', 'Salad', '110000', 'Rau xà lách, phô mai parmesan, sốt Caesar, bánh mì nướng', 'Salad Caesar giòn tươi với phô mai parmesan và bánh mì nướng, dùng kèm sốt đặc biệt.', 'salad_caesar.jpg'),
(3, 'Gỏi Cuốn Tôm Thịt', 'Gỏi/Nộm', '85000', 'Bánh tráng, tôm, thịt heo, rau sống, bún', 'Gỏi cuốn thanh mát, tươi ngon với tôm, thịt heo và rau sống, ăn kèm nước chấm đậm đà.', 'goi_cuon_tom_thit.jpg'),
(4, 'Soup Cua', 'Soup', '130000', 'Thịt cua, bột năng, trứng, ngò rí', 'Soup cua nóng hổi, sánh mịn, đầy ắp thịt cua tươi ngon và hương vị hấp dẫn.', 'soup_cua.jpg'),
(5, 'Salad Nga', 'Salad', '95000', 'Khoai tây, cà rốt, xúc xích, mayonnaise', 'Salad Nga béo ngậy với khoai tây, cà rốt và xúc xích, hòa quyện trong sốt mayonnaise.', 'salad_nga.jpg'),
(6, 'Gỏi Đu Đủ Thái', 'Gỏi/Nộm', '100000', 'Đu đủ xanh, tôm khô, đậu phộng, ớt', 'Gỏi đu đủ Thái cay nồng, giòn sần sật, tràn đầy hương vị chua cay ngọt.', 'goi_du_du_thai.jpg'),
(7, 'Soup Gà Nấm', 'Soup', '120000', 'Thịt gà, nấm hương, ngò rí, hành lá', 'Soup gà nấm bổ dưỡng, ngọt thanh từ thịt gà và nấm hương, rất thích hợp làm món khai vị.', 'soup_ga_nam.jpg'),
(8, 'Salad Trái Cây', 'Salad', '105000', 'Táo, nho, dưa hấu, cam, sữa chua', 'Salad trái cây tươi mát, ngọt dịu với nhiều loại quả mọng và sữa chua.', 'salad_trai_cay.jpg'),
(9, 'Gỏi Sứa', 'Gỏi/Nộm', '115000', 'Sứa, rau thơm, đậu phộng, nước mắm chua ngọt', 'Gỏi sứa giòn giòn, đậm đà với rau thơm và nước mắm chua ngọt hấp dẫn.', 'goi_sua.jpg'),
(10, 'Salad Bò Xé', 'Salad', '140000', 'Thịt bò, rau xà lách, dưa leo, hành tây, sốt chua ngọt', 'Salad bò xé mềm ngon, kết hợp rau củ tươi giòn và sốt chua ngọt đặc trưng.', 'salad_bo_xe.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `montrangmieng`
--

CREATE TABLE `montrangmieng` (
  `id` int(11) NOT NULL,
  `tenmon` varchar(100) NOT NULL,
  `loaimon` varchar(50) NOT NULL,
  `gia` varchar(10) NOT NULL,
  `thanhphan` text NOT NULL,
  `thongtinmon` text NOT NULL,
  `hinhanh` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `montrangmieng`
--

INSERT INTO `montrangmieng` (`id`, `tenmon`, `loaimon`, `gia`, `thanhphan`, `thongtinmon`, `hinhanh`) VALUES
(1, 'Bánh Tiramisu Cao Cấp', 'Bánh Ngọt', '180000', 'Bánh, cà phê, mascarpone', 'Tiramisu truyền thống với hương vị cà phê đậm đà và kem mascarpone mềm mại.', 'tiramisu.jpg'),
(2, 'Bánh Socola Lava', 'Bánh Ngọt', '200000', 'Socola, trứng, bơ', 'Bánh socola lava với nhân socola chảy, món tráng miệng hoàn hảo cho những tín đồ yêu thích socola.', 'socola_lava.jpg'),
(3, 'Bánh Cheesecake New York', 'Bánh Ngọt', '170000', 'Phô mai, kem, đường', 'Cheesecake New York với lớp phô mai béo ngậy, món ăn không thể thiếu cho bữa tiệc.', 'cheesecake_ny.jpg'),
(4, 'Bánh Su Kem', 'Bánh Ngọt', '120000', 'Bột, kem', 'Bánh su kem ngọt ngào với nhân kem béo ngậy.', 'banh_su.jpg'),
(5, 'Bánh Bông Lan Trái Cây', 'Bánh Ngọt', '130000', 'Bột, trái cây, kem', 'Bánh bông lan trái cây nhẹ nhàng, phù hợp cho những buổi tiệc nhẹ.', 'banh_bong_lan.jpg'),
(6, 'Kem Gelato Ý', 'Kem Lạnh', '150000', 'Sữa, đường, trái cây', 'Kem Gelato Ý mịn màng với hương vị trái cây tươi mát.', 'gelato.jpg'),
(7, 'Kem Dừa Tươi', 'Kem Lạnh', '110000', 'Dừa, sữa, đường', 'Kem dừa tươi mát lạnh, món tráng miệng hoàn hảo cho ngày hè.', 'kem_dua.jpg'),
(8, 'Kem Tự Chọn', 'Kem Lạnh', '150000', 'Sữa, trái cây, topping', 'Kem tự chọn với đa dạng hương vị và topping hấp dẫn.', 'kem_tu_chon.jpg'),
(9, 'Kem Trái Cây Mix', 'Kem Lạnh', '130000', 'Trái cây, sữa', 'Kem trái cây mix với hương vị tươi mát từ trái cây tự nhiên.', 'kem_trai_cay_mix.jpg'),
(10, 'Mousse Chocolate Đen', 'Kem Lạnh', '160000', 'Socola, kem', 'Mousse chocolate đen với vị đắng nhẹ và độ béo ngậy.', 'mousse_chocolate.jpg'),
(11, 'Trái Cây Tươi Nguyên Chất', 'Trái Cây', '120000', 'Trái cây tươi', 'Trái cây tươi nguyên chất, món ăn bổ dưỡng và thanh mát.', 'trai_cay_tươi.jpg'),
(12, 'Salad Trái Cây', 'Trái Cây', '140000', 'Trái cây, mật ong', 'Salad trái cây tươi ngon, hương vị ngọt ngào và dễ chịu.', 'salad_trai_cay.jpg'),
(13, 'Trái Cây Xay Sinh Tố', 'Trái Cây', '130000', 'Trái cây, sữa', 'Trái cây xay sinh tố thơm ngon, món uống giải khát tuyệt vời.', 'sinh_to_trai_cay.jpg'),
(14, 'Trái Cây Nướng Mật Ong', 'Trái Cây', '150000', 'Trái cây, mật ong', 'Trái cây nướng mật ong với hương vị caramel, món ăn mới lạ.', 'trai_cay_nuong.jpg'),
(15, 'Trái Cây Nhiệt Đới', 'Trái Cây', '140000', 'Trái cây nhiệt đới', 'Trái cây nhiệt đới tươi mát, món ăn đầy màu sắc và bổ dưỡng.', 'trai_cay_nhiet_doi.jpg'),
(16, 'Chè Bà Ba', 'Chè Truyền Thống', '100000', 'Đậu xanh, nước cốt dừa', 'Chè Bà Ba thơm ngon với hương vị dừa béo ngậy.', 'che_ba_ba.jpg'),
(17, 'Chè Sương Sa Hạt Lựu', 'Chè Truyền Thống', '130000', 'Sương sa, hạt lựu, nước cốt dừa', 'Chè sương sa hạt lựu ngọt ngào và thơm mát.', 'che_suong_sa.jpg'),
(18, 'Chè Đậu Xanh Nước Cốt Dừa', 'Chè Truyền Thống', '120000', 'Đậu xanh, nước cốt dừa', 'Chè đậu xanh nước cốt dừa béo ngậy, món ăn nhẹ nhàng cho bữa tiệc.', 'che_dau_xanh.jpg'),
(19, 'Chè Khúc Bạch', 'Chè Truyền Thống', '140000', 'Sữa, hạnh nhân, trái cây', 'Chè khúc bạch thơm ngon, món ăn tuyệt vời cho mùa hè.', 'che_khuc_bach.jpg'),
(20, 'Chè Trái Cây Nhiệt Đới', 'Chè Truyền Thống', '150000', 'Trái cây, nước cốt dừa', 'Chè trái cây nhiệt đới với hương vị tươi mới, món ăn ngon miệng.', 'che_trai_cay.jpg');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `soban`
--

CREATE TABLE `soban` (
  `id` int(11) NOT NULL,
  `so_ban` int(11) DEFAULT NULL,
  `trang_thai` enum('trong','da_dat') DEFAULT 'trong'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `soban`
--

INSERT INTO `soban` (`id`, `so_ban`, `trang_thai`) VALUES
(1, 1, 'trong'),
(2, 2, 'da_dat'),
(3, 3, 'trong'),
(4, 4, 'trong'),
(5, 5, 'trong'),
(6, 6, 'trong'),
(7, 7, 'trong'),
(8, 8, 'trong'),
(9, 9, 'trong'),
(10, 10, 'trong'),
(11, 11, 'trong'),
(12, 12, 'trong'),
(13, 13, 'trong'),
(14, 14, 'trong'),
(15, 15, 'trong');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbthanhvien`
--

CREATE TABLE `tbthanhvien` (
  `id` int(11) NOT NULL,
  `hoten` varchar(50) NOT NULL,
  `taikhoan` varchar(50) NOT NULL,
  `matkhau` varchar(50) NOT NULL,
  `gioitinh` enum('Nam','Nữ','Khác') NOT NULL,
  `ngaysinh` date DEFAULT NULL,
  `diachi` varchar(255) DEFAULT NULL,
  `dienthoai` varchar(10) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `quyen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `tbthanhvien`
--

INSERT INTO `tbthanhvien` (`id`, `hoten`, `taikhoan`, `matkhau`, `gioitinh`, `ngaysinh`, `diachi`, `dienthoai`, `email`, `quyen`) VALUES
(6, 'Vũ Quyết DZ', 'quyet', '25d55ad283aa400af464c76d713c07ad', 'Nam', '2003-12-07', 'Hải Dương', '0359795335', 'quyetq781@gmail.com', 1),
(7, 'Đệ Phông', 'phong', '25d55ad283aa400af464c76d713c07ad', 'Nam', '2024-11-07', 'Dân Tộc', '0987654321', 'dephong@gmail.com', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thucdonchinh`
--

CREATE TABLE `thucdonchinh` (
  `id` int(11) NOT NULL,
  `tenmon` varchar(100) NOT NULL,
  `loaimon` varchar(50) NOT NULL,
  `gia` varchar(10) NOT NULL,
  `thanhphan` text NOT NULL,
  `thongtinmon` text NOT NULL,
  `hinhanh` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `thucdonchinh`
--

INSERT INTO `thucdonchinh` (`id`, `tenmon`, `loaimon`, `gia`, `thanhphan`, `thongtinmon`, `hinhanh`) VALUES
(1, 'Thịt Bò Wagyu A5 nướng', 'Thịt Bò Cao Cấp', '500000', 'Bò Wagyu A5, muối Himalaya', 'Thịt bò Wagyu A5 nướng với hương vị đậm đà và độ mềm hoàn hảo.', 'wagyu_a5.jpg'),
(2, 'Thịt Bò Thăn sốt tiêu đen', 'Thịt Bò Cao Cấp', '380000', 'Thịt thăn bò, sốt tiêu đen', 'Thịt bò thăn sốt tiêu đen, món ăn lôi cuốn cho những tín đồ ẩm thực.', 'than_bo_tieu_den.jpg'),
(3, 'Bò Cuộn Nấm Truffle', 'Thịt Bò Cao Cấp', '420000', 'Bò, nấm truffle, rau tươi', 'Bò cuộn nấm truffle, món ăn thượng hạng tinh tế và hấp dẫn.', 'cuon_nam_truffle.jpg'),
(4, 'Sườn Bò BBQ', 'Thịt Bò Cao Cấp', '450000', 'Sườn bò, sốt BBQ', 'Sườn bò nướng BBQ, món ăn nổi bật với vị ngọt thơm.', 'suon_bo_bqq.jpg'),
(5, 'Bít Tết Bò Angus', 'Thịt Bò Cao Cấp', '390000', 'Bít tết bò Angus, sốt rượu', 'Bít tết bò Angus được chế biến hoàn hảo với sốt rượu vang.', 'bit_tet_angus.jpg'),
(6, 'Thịt Lợn Xông Khói', 'Thịt Lợn Thượng Hạng', '220000', 'Thịt lợn, gia vị', 'Thịt lợn xông khói mang đến hương vị đặc trưng và đậm đà.', 'lon_xong_khoi.jpg'),
(7, 'Thịt Lợn Nướng Ngũ Vị', 'Thịt Lợn Thượng Hạng', '200000', 'Thịt lợn, gia vị ngũ vị hương', 'Thịt lợn nướng ngũ vị, món ăn truyền thống đầy quyến rũ.', 'lon_nuong_ngu_vi.jpg'),
(8, 'Sườn Lợn Nướng Mật Ong', 'Thịt Lợn Thượng Hạng', '240000', 'Sườn lợn, mật ong', 'Sườn lợn nướng mật ong, vị ngọt tự nhiên và thơm ngon.', 'suon_lon_mat_ong.jpg'),
(9, 'Thăn Lợn Sốt Nấm', 'Thịt Lợn Thượng Hạng', '210000', 'Thịt thăn lợn, nấm, sốt kem', 'Thăn lợn sốt nấm, hương vị béo ngậy và quyến rũ.', 'than_lon_sot_nam.jpg'),
(10, 'Thịt Lợn Quay Giòn', 'Thịt Lợn Thượng Hạng', '250000', 'Thịt lợn, gia vị', 'Thịt lợn quay giòn tan, món ăn không thể thiếu trong bữa tiệc.', 'lon_quay_gion.jpg'),
(11, 'Hải Sản Tươi Sống', 'Hải Sản Tươi Sống', '600000', 'Tôm hùm, cá tươi, mực', 'Hải sản tươi sống với hương vị biển cả, món ăn đặc sắc.', 'hai_san_tươi_song.jpg'),
(12, 'Cá Hồi Xông Khói', 'Hải Sản Tươi Sống', '350000', 'Cá hồi, gia vị', 'Cá hồi xông khói với hương thơm quyến rũ, món ăn hấp dẫn.', 'ca_hoi_xong_khoi.jpg'),
(13, 'Mực Nướng Tỏi', 'Hải Sản Tươi Sống', '300000', 'Mực, tỏi, gia vị', 'Mực nướng tỏi, món ăn thơm ngon, phù hợp với khẩu vị người Việt.', 'muc_nuong_toi.jpg'),
(14, 'Tôm Hùm Nướng Bơ', 'Hải Sản Tươi Sống', '700000', 'Tôm hùm, bơ, tỏi', 'Tôm hùm nướng bơ tỏi, sự kết hợp hoàn hảo cho bữa tiệc sang trọng.', 'tom_hum_nuong_bo.jpg'),
(15, 'Hàu Nướng Phô Mai', 'Hải Sản Tươi Sống', '320000', 'Hàu, phô mai, gia vị', 'Hàu nướng phô mai, món ăn độc đáo và sang trọng.', 'hau_nuong_pho_mai.jpg'),
(16, 'Set Thực Đơn Thượng Hạng', 'Set Thực Đơn Sang Trọng', '800000', 'Gồm bò, lợn, hải sản', 'Set thực đơn đặc biệt với sự kết hợp hoàn hảo của thịt bò, thịt lợn và hải sản.', 'set_thuc_don_thuong_hang.jpg'),
(17, 'Set Hải Sản Sang Trọng', 'Set Thực Đơn Sang Trọng', '850000', 'Hải sản cao cấp', 'Set hải sản tươi ngon, món ăn tuyệt vời cho những tín đồ yêu thích ẩm thực biển.', 'set_hai_san_sang_trong.jpg'),
(18, 'Combo Thịt Nướng Cao Cấp', 'Set Thực Đơn Sang Trọng', '900000', 'Thịt bò, thịt lợn, rau củ', 'Combo thịt nướng đa dạng với các loại thịt thượng hạng.', 'combo_thit_nuong.jpg'),
(19, 'Set Món Châu Á', 'Set Thực Đơn Sang Trọng', '650000', 'Món chính châu Á', 'Set thực đơn với các món ăn châu Á sang trọng và tinh tế.', 'set_mon_chau_a.jpg'),
(20, 'Bộ Thực Đơn Cổ Điển', 'Set Thực Đơn Sang Trọng', '780000', 'Các món cổ điển', 'Bộ thực đơn cổ điển với hương vị đặc trưng, thích hợp cho mọi dịp.', 'bo_thuc_don_co_dien.jpg'),
(21, 'Món Tráng Miệng Đặc Biệt', 'Set Thực Đơn Sang Trọng', '150000', 'Chocolate, trái cây', 'Món tráng miệng đặc biệt với chocolate và trái cây tươi ngon.', 'mon_trang_mieng.jpg'),
(22, 'Gà Nướng Sốt Mật Ong', 'Set Thực Đơn Sang Trọng', '180000', 'Gà, mật ong, gia vị', 'Gà nướng sốt mật ong, món ăn đầy hương vị cho bữa tối lãng mạn.', 'ga_nuong_mat_ong.jpg'),
(23, 'Thịt Bò Cuộn Nấm', 'Thịt Bò Cao Cấp', '430000', 'Thịt bò, nấm, rau', 'Thịt bò cuộn nấm thơm ngon, món ăn đặc sắc trong thực đơn.', 'bo_cuon_nam.jpg'),
(24, 'Sò Điệp Nướng Bơ Tỏi', 'Hải Sản Tươi Sống', '320000', 'Sò điệp, bơ, tỏi', 'Sò điệp nướng bơ tỏi, món ăn thanh tao và quyến rũ.', 'so_diep_nuong_bo.jpg'),
(25, 'Cá Chiên Xù sốt Chanh', 'Hải Sản Tươi Sống', '250000', 'Cá tươi, sốt chanh', 'Cá chiên xù sốt chanh tươi ngon, món ăn nhẹ nhàng và thanh khiết.', 'ca_chien_xu.jpg'),
(26, 'Mực Xào Nấm', 'Hải Sản Tươi Sống', '270000', 'Mực, nấm, rau củ', 'Mực xào nấm, món ăn bổ dưỡng và đầy màu sắc.', 'muc_xao_nam.jpg'),
(27, 'Thịt Lợn Quay Giòn', 'Thịt Lợn Thượng Hạng', '300000', 'Thịt lợn, gia vị', 'Thịt lợn quay giòn tan, hấp dẫn và đầy hương vị.', 'lon_quay.jpg'),
(28, 'Bò Sốt Vang', 'Thịt Bò Cao Cấp', '400000', 'Thịt bò, sốt vang', 'Bò sốt vang đậm đà, món ăn ấm áp cho những bữa tiệc đông.', 'bo_sot_vang.jpg'),
(29, 'Nem Rán Hải Sản', 'Set Thực Đơn Sang Trọng', '220000', 'Bánh đa nem, hải sản', 'Nem rán hải sản giòn rụm, món ăn tuyệt vời cho mọi bữa tiệc.', 'nem_ran_hai_san.jpg'),
(30, 'Món Tráng Miệng Tiramisu', 'Set Thực Đơn Sang Trọng', '160000', 'Bánh tiramisu', 'Món tráng miệng tiramisu mềm mại, món ăn ngọt ngào cho bữa tiệc.', 'tiramisu.jpg');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `cosonhahang`
--
ALTER TABLE `cosonhahang`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `datban`
--
ALTER TABLE `datban`
  ADD PRIMARY KEY (`id`),
  ADD KEY `soban_id` (`soban_id`);

--
-- Chỉ mục cho bảng `douong`
--
ALTER TABLE `douong`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `loaidouong`
--
ALTER TABLE `loaidouong`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `loaimonkhaivi`
--
ALTER TABLE `loaimonkhaivi`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `loaimontrangmieng`
--
ALTER TABLE `loaimontrangmieng`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `loaithucdonchinh`
--
ALTER TABLE `loaithucdonchinh`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `monkhaivi`
--
ALTER TABLE `monkhaivi`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `montrangmieng`
--
ALTER TABLE `montrangmieng`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `soban`
--
ALTER TABLE `soban`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `so_ban` (`so_ban`);

--
-- Chỉ mục cho bảng `tbthanhvien`
--
ALTER TABLE `tbthanhvien`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `taikhoan` (`taikhoan`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Chỉ mục cho bảng `thucdonchinh`
--
ALTER TABLE `thucdonchinh`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `cosonhahang`
--
ALTER TABLE `cosonhahang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `datban`
--
ALTER TABLE `datban`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `douong`
--
ALTER TABLE `douong`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- AUTO_INCREMENT cho bảng `loaidouong`
--
ALTER TABLE `loaidouong`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `loaimonkhaivi`
--
ALTER TABLE `loaimonkhaivi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `loaimontrangmieng`
--
ALTER TABLE `loaimontrangmieng`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `loaithucdonchinh`
--
ALTER TABLE `loaithucdonchinh`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `monkhaivi`
--
ALTER TABLE `monkhaivi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT cho bảng `montrangmieng`
--
ALTER TABLE `montrangmieng`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- AUTO_INCREMENT cho bảng `soban`
--
ALTER TABLE `soban`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT cho bảng `tbthanhvien`
--
ALTER TABLE `tbthanhvien`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT cho bảng `thucdonchinh`
--
ALTER TABLE `thucdonchinh`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=223;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `datban`
--
ALTER TABLE `datban`
  ADD CONSTRAINT `datban_ibfk_1` FOREIGN KEY (`soban_id`) REFERENCES `soban` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
