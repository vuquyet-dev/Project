<?php
    include('../admin/ketnoi.php'); // Kết nối cơ sở dữ liệu

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
    <link rel="stylesheet" href="../css/LienHe.css">
    <title>Contact</title>
</head>
<body>
    <div id="contact" class="content">
        <h2 class="section-heading">CONTACT</h2>
        <p class="section-sub-heading">Drop a note!</p>
        
        <div class="row contact-content">
            <!-- Hiển thị thông tin liên hệ từ cơ sở dữ liệu -->
            <div class="col col-half contact-info">
                <p><i class="fa-solid fa-location-dot"></i> <?php echo $contact['diachi']; ?></p>
                <p><i class="fa-solid fa-phone"></i> Phone: <?php echo $contact['sodienthoai']; ?></p>
                <p><i class="fa-solid fa-envelope"></i> Email: <?php echo $contact['email']; ?></p>
            </div>
            <div class="col col-half contact-form">
                <form action="">
                    <div class="row">
                        <div class="col col-half">
                            <input type="text" placeholder="Name" class="form-control" required>
                        </div>
                        <div class="col col-half">
                            <input type="email" placeholder="Email" class="form-control" required>
                        </div>
                    </div>
                    <div class="row mt-8">
                        <div class="col col-full">
                            <input type="text" placeholder="Message" class="form-control" required>
                        </div>
                    </div>
                    <input type="submit" value="SEND" class="btn mt-16 pull-right">
                </form>
            </div>
        </div>
    </div>
</body>
</html>