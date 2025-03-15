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
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>

    <link rel="stylesheet" href="../css/style_DSthemsuaxoa.css">
</head>
<body>

        <?php include('../giaodien/TieuDe.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <article>
            <h1>THÔNG TIN CÁC MÓN TRÁNG MIỆNG</h1>
            <div>
                <div class="themmoi">
                    <a href="3Them_MonTrangMieng.php">Thêm Món</a>
                </div>
                <div>
                    <form action="3xuly_TimMonTrangMieng.php" method="get" class="timkiem">
                        <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                        <input type="submit" value="Tìm kiếm">
                    </form>
                </div>
            </div>
            
            <?php
                $db = "SELECT montrangmieng.id as ID,
                        montrangmieng.tenmon as Tenmon,
                        montrangmieng.gia as Gia,
                        montrangmieng.thanhphan as Thanhphan,
                        montrangmieng.thongtinmon as Thongtinmon,
                        montrangmieng.hinhanh as Hinhanh,
                        loaimontrangmieng.loaimon as Loaimon
                        FROM montrangmieng
                        INNER JOIN loaimontrangmieng ON montrangmieng.loaimon = loaimontrangmieng.loaimon ";
                $result = mysqli_query($conn, $db); 

                if(mysqli_num_rows($result) == 0) {
                    echo "Chưa có món ăn nào";
                } else {
                    while($row = mysqli_fetch_array($result)) { ?>
                        <div class="khungsp">
                            <div class="tt"><?php echo $row['ID']; ?></div>
                            <img src="../images/Montrangmieng/<?php echo $row['Hinhanh'] ?>" alt="Image">
                            <div class="thongtin">
                                <h2><?php echo $row['Tenmon']; ?></h2>
                                <p>
                                    <b>Thành phần:</b> <?php echo $row['Thanhphan']; ?><br>
                                    <b>Thông tin món:</b> <?php echo $row['Thongtinmon']; ?><br> 
                                </p>
                                <p><b>Loại món:</b> <?php echo $row['Loaimon']; ?> &nbsp;&nbsp;|  <b>Giá:</b> <?php echo number_format($row['Gia'], 0, ',', '.'); ?>đ</p>
                            </div>
                            <div class="sua">
                                <a style="text-decoration: none;" href="3Sua_MonTrangMieng.php?id=<?php echo $row['ID']; ?>">Sửa</a>
                            </div>
                            <div class="xoa">
                                <a style="text-decoration: none;" href="3Xoa_MonTrangMieng.php?id=<?php echo $row['ID']; ?>" onclick="return confirm('Bạn có chắc muốn xóa món này không?');">Xóa</a>
                            </div>
                        </div>
                    <?php }
                }
            ?>
                
            </div>
        </article>
        <?php include('../giaodien/Footer.php'); ?>
</body>
</html>
