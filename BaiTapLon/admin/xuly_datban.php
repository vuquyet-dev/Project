<?php
    include('ketnoi.php');
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $ten_khach_hang = $_POST['ten_khach_hang'];
        $so_dien_thoai = $_POST['so_dien_thoai'];
        $ngay_dat = $_POST['ngay_dat'];
        $gio_dat = $_POST['gio_dat'];
        $so_luong_khach = $_POST['so_luong_khach'];
        $ghi_chu = $_POST['ghi_chu'];
        $soban_id = $_POST['soban_id'];

        // Thực hiện insert thông tin đặt bàn vào bảng datban
        $sql = "INSERT INTO datban (ten_khach_hang, so_dien_thoai, ngay_dat, gio_dat, so_luong_khach, ghi_chu, soban_id) 
                VALUES ('$ten_khach_hang', '$so_dien_thoai', '$ngay_dat', '$gio_dat', '$so_luong_khach', '$ghi_chu', '$soban_id')";
        if (mysqli_query($conn, $sql)) {
            // Cập nhật trạng thái bàn đã được đặt
            $update_ban = "UPDATE soban SET trang_thai = 'da_dat' WHERE id = '$soban_id'";
            mysqli_query($conn, $update_ban);
            echo "Đặt bàn thành công!";
            header("Location: HienThiDatBan.php");
        } else {
            echo "Lỗi: " . $sql . "<br>" . mysqli_error($conn);
        }
    }
?>
