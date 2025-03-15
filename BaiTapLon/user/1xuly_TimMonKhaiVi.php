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
    <link rel="stylesheet" href="./css/giaodientrangchu.css">
    <?php
        if(($_SESSION["lguser"] == null) || ($_SESSION["lguser"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
    <link rel="stylesheet" href="./css/style.css">
    <link rel="stylesheet" href="../css/style_DSthemsuaxoa.css">
</head>
<body>

        <?php include('../giaodienuser/Tieude.php'); ?>
        <?php include('../giaodienuser/MenuNgang.php'); ?>
        <article>
            <h1>THÔNG TIN CÁC MÓN KHAI VỊ</h1>
            <div>
                
                <div>
                    <form action="1xuly_TimMonKhaiVi.php" method="get" class="timkiem">
                        <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                        <input type="submit" value="Tìm kiếm">
                    </form>
                </div>
            </div>
        
            <?php
                $tk = $_GET['timkiem'];
                $db = "SELECT monkhaivi.id as ID,
                        monkhaivi.tenmon as Tenmon,
                        monkhaivi.gia as Gia,
                        monkhaivi.thanhphan as Thanhphan,
                        monkhaivi.thongtinmon as Thongtinmon,
                        monkhaivi.hinhanh as Hinhanh,
                        loaimonkhaivi.loaimon as Loaimon
                        FROM monkhaivi
                        INNER JOIN loaimonkhaivi ON monkhaivi.loaimon = loaimonkhaivi.loaimon
                            WHERE monkhaivi.tenmon LIKE '%$tk%' 
                            OR loaimonkhaivi.loaimon LIKE '%$tk%' 
                            OR monkhaivi.gia LIKE '%$tk%'";
                $result = mysqli_query($conn, $db); 

                if(mysqli_num_rows($result) == 0) {
                    echo "Không tìm thấy sản phẩm nào  ";
                } else {
                    while($row = mysqli_fetch_array($result)) { ?>
                        <div class="khungsp">
                            <div class="tt"><?php echo $row['ID']; ?></div>
                            <img src="../images/Monkhaivi/<?php echo $row['Hinhanh'] ?>" alt="Image">
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
