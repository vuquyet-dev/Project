<?php
    include('../admin/ketnoi.php'); // Kết nối cơ sở dữ liệu
    session_start();
    ob_start();

    // Truy vấn dữ liệu từ bảng lienhe
    $query = "SELECT diachi, sodienthoai, email FROM lienhe LIMIT 1"; // Giới hạn 1 dòng (giả sử chỉ có 1 dòng thông tin liên hệ)
    $result = mysqli_query($conn, $query);

    // Kiểm tra và lấy dữ liệu
    $contact = mysqli_fetch_assoc($result);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
            color: #333;
        }
        ul {
            
        }   
        img{
            width: 100%;
            border-radius: 30px;
        }
        .header {
            background-color: #333;
            color: #fff;
            padding: 20px;
            text-align: center;
        }
        .header h1 {
            margin: 0;
            font-size: 2.5em;
        }
        .header p {
            margin: 5px 0;
        }
        nav {
            background-color: #444;
            
            text-align: center;
        }
        nav a {
            color: #fff;
            margin: 0 15px;
            text-decoration: none;
            font-weight: bold;
        }
        /* nav a:hover {
            text-decoration: underline;
        } */
        section {
            padding: 20px;
            max-width: 1000px;
            margin: 0 auto;
        }
        .intro, .specialties, .services, .contact {
            margin-bottom: 30px;
        }
        h2 {
            color: #444;
            border-bottom: 2px solid #e0e0e0;
            padding-bottom: 5px;
        }
        .specialties ul {
            list-style: none;
            padding: 0;
        }
        .specialties li {
            padding: 5px 0;
        }
        .services {
            background-color: #f0f0f0;
            padding: 15px;
            border-radius: 5px;
        }
        footer {
            background-color: #333;
            color: #fff;
            text-align: center;
            padding: 20px;
            margin-top: 30px;
        }
    </style>
</head>
<body>
        <?php include('../giaodien/TieuDe.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <div class = "header">
            <h1>La Lumière</h1>
            <p>Nơi ẩm thực và sự sang trọng hội tụ</p>
        </div>
        <section id="intro" class="intro">
            <img src="../images/gioi_thieu_chi_tiet.jpg" alt="Giới thiệu">
        <h2>Giới thiệu</h2>
        <p>La Lumière là nhà hàng 5 sao nổi tiếng tại trung tâm thành phố, nơi hội tụ những món ăn tinh tế, không gian đẳng cấp và dịch vụ hoàn hảo. Với đội ngũ đầu bếp hàng đầu và phong cách phục vụ chuyên nghiệp, chúng tôi cam kết mang đến cho quý khách những trải nghiệm ẩm thực đáng nhớ.</p>
        <p>Nhà hàng không chỉ là nơi thưởng thức bữa ăn mà còn là không gian lý tưởng để tổ chức các sự kiện đặc biệt, từ tiệc cưới, họp mặt gia đình cho đến các buổi hội nghị sang trọng.</p>
        </section>
        <section id="specialties" class="specialties">
            <h2>Đặc sản của chúng tôi</h2>
            <ul style = "background: none;">
                <li>Cocktail sáng tạo từ các nguyên liệu thượng hạng</li>
                <li>Các món hải sản và thịt cao cấp, chế biến với phong cách đa dạng</li>
                <li>Món tráng miệng độc đáo, kết hợp hương vị truyền thống và hiện đại</li>
                <li>Bộ sưu tập rượu vang phong phú, được tuyển chọn từ khắp nơi trên thế giới</li>
            </ul>
            <p>Mỗi món ăn tại La Lumière được chế biến từ những nguyên liệu tươi ngon nhất, mang đến hương vị tinh tế và đậm chất nghệ thuật.</p>
        </section>
        <section id="services" class="services">
            <h2>Dịch vụ nổi bật</h2>
            <p>La Lumière cung cấp các dịch vụ đặc biệt để đáp ứng mọi nhu cầu của khách hàng:</p>
            <ul style = "background: none;">
                <li>Dịch vụ đặt bàn trực tuyến tiện lợi</li>
                <li>Không gian riêng tư cho các buổi tiệc và hội nghị</li>
                <li>Thực đơn theo yêu cầu, bao gồm các lựa chọn ăn kiêng</li>
                <li>Nhạc sống hàng đêm tạo không khí thư giãn</li>
            </ul>
        </section>
        <section id="contact" class="contact">
            <h2>Liên hệ với chúng tôi</h2>
            <p><strong>Địa chỉ:</strong><?php echo $contact['diachi']; ?></p>
            <p><strong>Số điện thoại:</strong>  <?php echo $contact['sodienthoai']; ?></p>
            <p><strong>Email:</strong><?php echo $contact['email']; ?></p>
            <p>Hãy đến và trải nghiệm sự khác biệt tại La Lumière, nơi mỗi bữa ăn đều là một câu chuyện nghệ thuật!</p>
        </section>
        <?php include('../giaodien/Footer.php'); ?>
</body>
</html>
