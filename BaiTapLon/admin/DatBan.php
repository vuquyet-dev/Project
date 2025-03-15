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
    <title>Đặt Bàn</title>
    <link rel="stylesheet" href="../css/giaodientrangchu.css">
    <link rel="stylesheet" href="../css/style.css">
</head>
<body>
<div class="container">
    <?php include('../giaodien/TieuDe.php'); ?>
    <?php include('../giaodien/MenuNgang.php'); ?>
    <article>
        <h1>ĐẶT BÀN</h1>
        <form action="xuly_DatBan.php" method="post">
            <div class="form-group">
                <label class="label">Tên khách hàng</label>
                <input type="text" name="ten_khach_hang" class="form-control" required>
            </div>
            <div class="form-group">
                <label class="label">Số điện thoại</label>
                <input type="text" name="so_dien_thoai" class="form-control" required>
            </div>
            <div class="form-group">
                <label class="label">Ngày đặt</label>
                <input type="date" name="ngay_dat" class="form-control" required>
            </div>
            <div class="form-group">
                <label class="label">Giờ đặt</label>
                <input type="time" name="gio_dat" class="form-control" required>
            </div>
            <div class="form-group">
                <label class="label">Số lượng khách</label>
                <input type="number" name="so_luong_khach" class="form-control" required>
            </div>
            <div class="form-group">
                <label class="label">Ghi chú</label>
                <textarea name="ghi_chu" rows="3" class="form-control"></textarea>
            </div>
            <div class="form-group"  style = "margin-top: 100px;">
                <label class="label">Chọn số bàn</label>
                <select name="soban_id" class="form-control" required>
                    <option value="">-- Chọn bàn --</option>
                    <?php
                        $db = "SELECT * FROM soban WHERE trang_thai = 'trong'";
                        $query = mysqli_query($conn, $db);
                        while ($row = mysqli_fetch_array($query)) { ?>
                            <option value="<?php echo $row['id']; ?>"><?php echo "Bàn " . $row['so_ban']; ?></option>
                    <?php } ?>
                </select>
            </div>
            <div class="form-group" style="text-align: center;">
                <button type="submit" class="button">Đặt Bàn</button>
                <button type="reset" class="button">Reset</button>
            </div>
        </form>
    </article>
</div>
<?php include('../giaodien/Footer.php'); ?>
</body>
</html>
