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
    <title>Document</title>

    <?php
        if(($_SESSION["lguser"] == null) || ($_SESSION["lguser"] == "")) {
            header("location:DangNhap.php");
        }
    ?>

    <link rel="stylesheet" href="../css/style_DSthemsuaxoa.css">
</head>
<body>

        <?php include('../giaodienuser/TieuDe.php'); ?>
        <?php include('../giaodienuser/MenuNgang.php'); ?>
        <article>
            <h1>THÔNG TIN CÁC ĐỒ UỐNG</h1>
            <div>
               
                <div>
                    <form action="4xuly_TimDoUong.php" method="get" class="timkiem">
                        <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                        <input type="submit" value="Tìm kiếm">
                    </form>
                </div>
            </div>
            
            <?php
                $db = "SELECT douong.id as ID,
                        douong.tenmon as Tenmon,
                        douong.gia as Gia,
                        douong.thanhphan as Thanhphan,
                        douong.thongtinmon as Thongtinmon,
                        douong.hinhanh as Hinhanh,
                        loaidouong.loaimon as Loaimon
                        FROM douong
                        INNER JOIN loaidouong ON douong.loaimon = loaidouong.loaimon ";
                $result = mysqli_query($conn, $db); 

                if(mysqli_num_rows($result) == 0) {
                    echo "Chưa có món ăn nào";
                } else {
                    while($row = mysqli_fetch_array($result)) { ?>
                        <div class="khungsp">
                            <div class="tt"><?php echo $row['ID']; ?></div>
                            <img src="../images/Douong/<?php echo $row['Hinhanh'] ?>" alt="Image">
                            <div class="thongtin">
                                <h2><?php echo $row['Tenmon']; ?></h2>
                                <p>
                                    <b>Thành phần:</b> <?php echo $row['Thanhphan']; ?><br>
                                    <b>Thông tin món:</b> <?php echo $row['Thongtinmon']; ?><br> 
                                </p>
                                <p><b>Loại món:</b> <?php echo $row['Loaimon']; ?> &nbsp;&nbsp;|  <b>Giá:</b> <?php echo number_format($row['Gia'], 0, ',', '.'); ?>đ</p>
                            </div>
                        </div>
                    <?php }
                }
            ?>
                
            </div>
        </article>
        <?php include('../giaodienuser/Footer.php'); ?>
</body>
</html>

