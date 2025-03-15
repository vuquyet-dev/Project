<?php
    include('ketnoi.php');
    if (isset($_GET['id'])) {
        $id = $_GET['id'];

        // Lấy thông tin số bàn từ bảng datban
        $sql = "SELECT soban_id FROM datban WHERE id = '$id'";
        $result = mysqli_query($conn, $sql);
        $row = mysqli_fetch_assoc($result);
        $soban_id = $row['soban_id'];

        // Cập nhật trạng thái bàn trở lại 'trong'
        $update_ban = "UPDATE soban SET trang_thai = 'trong' WHERE id = '$soban_id'";
        mysqli_query($conn, $update_ban);

        // Xóa thông tin đặt bàn
        $sql_delete = "DELETE FROM datban WHERE id = '$id'";
        mysqli_query($conn, $sql_delete);

        echo "Giải phóng bàn thành công!";
        header("Location: HienThiDatBan.php");
    }
?>
