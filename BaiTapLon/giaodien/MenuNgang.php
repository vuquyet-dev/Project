<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
  <link rel="stylesheet" href="../css/menuMecon.css">
  <link rel="stylesheet" href="../css/giaodientrangchu.css">
</head>
<body>
  <nav>
    <ul>
      <li><a href="../admin/Trangchu.php">Trang chủ</a></li>
      <li><a href="#">Menu</a>
        <ul class="vmenu">
          <li><a href="../admin/1DS_MonKhaiVi.php">Món khai vị</a>
            <!-- <ul>
              <li><a href="#">Soup</a></li>
              <li><a href="#">Salad</a></li>
              <li><a href="#">Gỏi/Nộm</a></li>
            </ul> -->
          </li>
          <li><a href="../admin/2DS_ThucDonChinh.php">Thực đơn chính</a>
            <!-- <ul>
              <li><a href="#">Thịt Bò Cao Cấp</a></li>
              <li><a href="#">Thịt Lợn Thượng Hạng</a></li>
              <li><a href="#">Hải Sản Tươi Sống</a></li>
              <li><a href="#">Set Thực Đơn Sang Trọng</a></li>
            </ul> -->
          </li>
          <li><a href="../admin/3DS_monTrangMieng.php">Món tráng miệng</a>
            <!-- <ul>
              <li><a href="#">Bánh Ngọt</a></li>
              <li><a href="#">Kem Lạnh</a></li>
              <li><a href="#">Trái Cây</a></li>
              <li><a href="#">Chè Truyền Thống</a></li>
            </ul> -->
          </li>
          <li><a href="../admin/4DS_DoUong.php">Đồ uống</a>
            <!-- <ul>
              <li><a href="#">Cocktail</a></li>
              <li><a href="#">Nước ép</a></li>
              <li><a href="#">Bia</a></li>
              <li><a href="#">Cà phê</a></li>
              <li><a href="#">Trà</a></li>
              <li><a href="#">Rượu</a></li>
            </ul> -->
          </li>
        </ul>
      </li>
      
      <li><a href="../admin/5DS_KhongGianNhaHang.php">Không gian nhà hàng</a></li>
      <li><a href="../admin/GioiThieuChiTiet.php">Giới thiệu</a></li>
      <li><a href="../admin/HienThiDatBan.php">Đặt bàn</a></li>
      <li><a href="../admin/TinTuc.php">Tin tức</a></li>
    </ul>
    <div class="chao">
      <span style = "color: #FFFFFF; padding-left: 7px;">Chào bạn</span>
      <span class = "tim"><?php echo $_SESSION['Hoten']; ?></span>
      |<a href="../admin/Dangnhap.php" style = "text-decoration: none; color: white;">
      Đăng xuất</a>
    </div>
  </nav>
</body>
</html>