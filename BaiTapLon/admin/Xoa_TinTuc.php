<?php
    session_start();
    ob_start();
    include('ketnoi.php');
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Xóa Tin Tức</title>
    <?php
        // Kiểm tra xem admin đã đăng nhập hay chưa
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
</head>
<body>
    <?php
        // Lấy ID của tin tức cần xóa từ URL
        $ID = isset($_GET['id']) ? $_GET['id'] : 0;

        // Kiểm tra ID hợp lệ
        if ($ID != 0) {
            // Câu lệnh SQL để xóa tin tức
            $db = "DELETE FROM tintuc WHERE id = '$ID'";
            $xoa = mysqli_query($conn, $db);

            // Kiểm tra kết quả xóa
            if ($xoa) {
                echo '<script language="javascript">alert("Tin tức đã được xóa thành công."); window.location = "DanhSach_TinTuc.php";</script>';
            } else {
                echo '<script language="javascript">alert("Xóa tin tức thất bại. Vui lòng thử lại."); window.location = "DanhSach_TinTuc.php";</script>';
            }
        } else {
            echo '<script language="javascript">alert("ID tin tức không hợp lệ."); window.location = "DanhSach_TinTuc.php";</script>';
        }

        // Đóng kết nối
        mysqli_close($conn);
    ?>
</body>
</html>
