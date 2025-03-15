<?php
// Tạo danh sách các đường dẫn đến các ảnh trong thư mục
$images = glob("../images/gioithieu/*.jpg"); // Tìm tất cả các file .jpg trong thư mục images
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Horizontal Image Slideshow</title>
    <link rel="stylesheet" href="../css/AnhGioiThieu.css">
    <style>
        /* Hiệu ứng Fade cho mỗi ảnh */
        <?php foreach ($images as $index => $image): ?>
        #slideshow-container img:nth-child(<?php echo $index + 1; ?>) {
            animation-delay: <?php echo $index * 4; ?>s;
        }
        <?php endforeach; ?>
    </style>
</head>
<body>
    <div id="slideshow-container">
        <div id="slideshow">
            <?php foreach ($images as $image): ?>
                <img src="<?php echo $image; ?>" alt="Slideshow Image">
            <?php endforeach; ?>
        </div>
    </div>

    <script>
        // Tạo một mảng chứa các hình ảnh từ PHP
        let images = <?php echo json_encode($images); ?>;
        let currentIndex = 0;
        const slideshow = document.getElementById('slideshow');
        const imageWidth = 500; // Chiều rộng của mỗi ảnh

        // Hàm thay đổi ảnh với hiệu ứng trượt ngang
        function changeImage() {
            currentIndex = (currentIndex + 1) % images.length; // Chuyển sang ảnh kế tiếp
            slideshow.style.left = -currentIndex * imageWidth + 'px'; // Cập nhật vị trí của slideshow
        }

        // Cài đặt thay đổi ảnh mỗi 3 giây
        setInterval(changeImage, 3000); // 3000ms = 3 giây
    </script>
</body>
</html>