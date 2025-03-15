<?php
    session_start();
    ob_start();
    include('ketnoi.php');
    if (($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
        header("location:DangNhap.php");
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Danh Sách Đặt Bàn</title>
    <style>
        h1 {
            width: 80%;
            margin: 20px auto 0;
            height: 40px;
            line-height: 40px;
            background-color: peachpuff;
            color: chocolate;
            font-weight: bolder;
            text-align: center;
            border: 1px solid #A1A1A1;
        }
        article {
            background-image: url(../images/background.jpg);
        }
        a.button {
            width: 150px;
            height: 30px;
            border-radius: 10px;
            border: solid 1px;
            background: peachpuff;
            /* box-shadow: inset 0 0 10px peachpuff; */
            font-size: 20px;
            margin: 20px 0 10px 120px;
            padding: 5px;
            text-align: center;
            float: left;
            line-height: 30px;
            text-decoration: none;
            color: chocolate;
            font-weight: bold;
        }
        table.table {
            margin: 100px auto 0;
            color: chocolate;
        }
        td>a {
            text-decoration: none;
            font-weight: bold;
            color: aqua;
        }
    </style>
    
    
    
</head>
<body>

    <?php include('../giaodien/TieuDe.php'); ?>
    <?php include('../giaodien/MenuNgang.php'); ?>

    <article>
        <h1>Danh Sách Đặt Bàn</h1>

        <!-- Nút Đặt Bàn chuyển đến DatBan.php -->
        <div class="themmoi">
            <a href="DatBan.php" class="button">Đặt Bàn</a>
        </div>

        <table class="table" border="1" cellspacing="0" cellpadding="5">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Tên khách hàng</th>
                    <th>Số điện thoại</th>
                    <th>Ngày đặt</th>
                    <th>Giờ đặt</th>
                    <th>Số bàn</th>
                    <th>Số lượng khách</th>
                    <th>Ghi chú</th>
                    <th>Trạng thái</th>
                    <th>Hành động</th>
                </tr>
            </thead>
            <tbody>
                <?php
                    // Lấy danh sách các đặt bàn từ cơ sở dữ liệu
                    $db = "SELECT datban.id AS datban_id,
                                  datban.ten_khach_hang,
                                  datban.so_dien_thoai,
                                  datban.ngay_dat,
                                  datban.gio_dat,
                                  datban.so_luong_khach,
                                  datban.ghi_chu,
                                  soban.so_ban,
                                  soban.trang_thai AS trang_thai_ban
                            FROM datban
                            INNER JOIN soban ON datban.soban_id = soban.id
                            WHERE soban.trang_thai = 'da_dat'";  // Chỉ lấy bàn đã đặt
                    $query = mysqli_query($conn, $db);

                    // Kiểm tra nếu có đặt bàn
                    if (mysqli_num_rows($query) == 0) {
                        echo "<tr><td colspan='10'>Chưa có đặt bàn nào</td></tr>";
                    } else {
                        while ($row = mysqli_fetch_assoc($query)) { ?>
                            <tr>
                                <td><?php echo $row['datban_id']; ?></td>
                                <td><?php echo $row['ten_khach_hang']; ?></td>
                                <td><?php echo $row['so_dien_thoai']; ?></td>
                                <td><?php echo $row['ngay_dat']; ?></td>
                                <td><?php echo $row['gio_dat']; ?></td>
                                <td><?php echo $row['so_ban']; ?></td>
                                <td><?php echo $row['so_luong_khach']; ?></td>
                                <td><?php echo $row['ghi_chu']; ?></td>
                                <td><?php echo $row['trang_thai_ban'] == 'da_dat' ? 'Đã đặt' : 'Trống'; ?></td>
                                <td>
                                    <a href="Checkout.php?id=<?php echo $row['datban_id']; ?>" onclick="return confirm('Bạn có chắc muốn check out bàn này không?');">Checkout</a>
                                </td>
                            </tr>
                        <?php }
                    }
                ?>
            </tbody>
        </table>
    </article>

    <?php include('../giaodien/Footer.php'); ?>

</body>
</html>
