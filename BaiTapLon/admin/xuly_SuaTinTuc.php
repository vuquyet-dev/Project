<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Xử lý Sửa Tin Tức</title>
</head>
<body>
    <?php
        include('ketnoi.php');
        $query = "";

        // Khai báo các biến để lưu trữ thông tin
        $idTinTuc = $tieuDe = $loaiTin = $noiDung = "";
        $hinhAnh = "";

        // Kiểm tra nếu dữ liệu được gửi qua POST
        if (!empty($_POST)) {
            $idTinTuc = $_POST['txtIdTinTuc'];  // ID tin tức
            $tieuDe = $_POST['txtTieuDe'];     // Tiêu đề tin
            $loaiTin = $_POST['selLoaiTin'];   // Loại tin
            $noiDung = $_POST['txtNoiDung'];   // Nội dung tin
        }

        // Kiểm tra xem hình ảnh có được gửi hay không
        if (isset($_FILES['filHinh']['name']) && $_FILES['filHinh']['name'] != "") {
            $hinhAnh = $_FILES['filHinh']['name']; // Lấy tên file hình ảnh
            $targetDir = '../images/';            // Đường dẫn thư mục lưu hình
            $targetFile = $targetDir . basename($hinhAnh);

            // Di chuyển file hình ảnh vào thư mục
            move_uploaded_file($_FILES['filHinh']['tmp_name'], $targetFile);

            // Câu lệnh SQL với cập nhật hình ảnh
            $query = "UPDATE tintuc SET 
                      tieude = '{$tieuDe}', loaitin = '{$loaiTin}', 
                      noidung = '{$noiDung}', hinhanh = '{$hinhAnh}' 
                      WHERE id = '{$idTinTuc}'";
        } else {
            // Câu lệnh SQL không cập nhật hình ảnh
            $query = "UPDATE tintuc SET 
                      tieude = '{$tieuDe}', loaitin = '{$loaiTin}', 
                      noidung = '{$noiDung}' 
                      WHERE id = '{$idTinTuc}'";
        }

        // Thực thi câu lệnh SQL
        $result = mysqli_query($conn, $query);

        // Kiểm tra kết quả
        if ($result) {
            echo '<script language="javascript">alert("Cập nhật tin tức thành công.");
                  window.location = "DanhSach_TinTuc.php";</script>';
        } else {
            echo '<script language="javascript">alert("Có lỗi trong quá trình xử lý. Vui lòng thử lại.");
                  window.location = "Sua_TinTuc.php?id=' . $idTinTuc . '";</script>';
        }

        // Đóng kết nối
        mysqli_close($conn);
    ?>
</body>
</html>
