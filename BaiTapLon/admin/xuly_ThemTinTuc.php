<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Xử lý Thêm Tin Tức</title>
</head>
<body>
    <?php
        include("ketnoi.php");

        // Khai báo các biến
        $idTinTuc = $tieuDe = $loaiTin = $noiDung = $hinhAnh = "";

        // Lấy thông tin từ form
        if (isset($_POST["txtIdTinTuc"])) $idTinTuc = $_POST["txtIdTinTuc"];
        if (isset($_POST["txtTieuDe"])) $tieuDe = $_POST["txtTieuDe"];
        if (isset($_POST["selLoaiTin"])) $loaiTin = $_POST["selLoaiTin"];
        if (isset($_POST["txtNoiDung"])) $noiDung = $_POST["txtNoiDung"];

        // Xử lý file hình ảnh nếu có tải lên
        if (isset($_FILES["filHinh"]["name"]) && $_FILES["filHinh"]["name"] != "") {
            $hinhAnh = $_FILES["filHinh"]["name"];
            $targetDir = '../images/';
            $targetFile = $targetDir . basename($hinhAnh);

            // Di chuyển file vào thư mục đích
            move_uploaded_file($_FILES["filHinh"]["tmp_name"], $targetFile);
        }

        // Kiểm tra xem ID tin tức đã tồn tại trong cơ sở dữ liệu chưa
        $sql = "SELECT * FROM tintuc WHERE id = '$idTinTuc'";
        $result = mysqli_query($conn, $sql);

        if (mysqli_num_rows($result) > 0) {
            echo '<script language="javascript">alert("ID tin tức này đã tồn tại. Vui lòng nhập lại!");
            window.location = "Them_TinTuc.php";</script>';
            die();
        } else {
            // Thêm dữ liệu vào bảng tin tức
            $insertSql = "INSERT INTO tintuc (id, tieude, loaitin, noidung, hinhanh) 
                          VALUES ('{$idTinTuc}', '{$tieuDe}', '{$loaiTin}', '{$noiDung}', '{$hinhAnh}')";
            $insertResult = mysqli_query($conn, $insertSql);

            if ($insertResult) {
                echo '<script language="javascript">alert("Thêm mới tin tức thành công!");
                window.location = "DanhSach_TinTuc.php";</script>';
            } else {
                echo '<script language="javascript">alert("Lỗi khi thêm mới tin tức. Vui lòng thử lại!");
                window.location = "Them_TinTuc.php";</script>';
            }
        }

        // Đóng kết nối
        mysqli_close($conn);
    ?>
</body>
</html>
