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
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
    <link rel="stylesheet" href="./css/style.css">
    <link rel="stylesheet" href="../css/style_DSthemsuaxoa.css">
</head>
<body>

        <?php include('../giaodien/Tieude.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <article>
            <h1>THÔNG TIN CÁC CƠ SỞ NHÀ HÀNG</h1>
            <div>
                <div class="themmoi">
                    <a href="5Them_KhongGianNhaHang.php">Thêm Cơ Sở</a>
                </div>
                <div>
                    <form action="5xuly_TimKhongGianNhaHang.php" method="get" class="timkiem">
                        <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                        <input type="submit" value="Tìm kiếm">
                    </form>
                </div>
            </div>
        
            <?php
                $tk = $_GET['timkiem'];
                $db = "SELECT cosonhahang.id as ID,
                        cosonhahang.diachi as Diachi,
                        cosonhahang.mota as Mota,
                        cosonhahang.hinhanh as Hinhanh,
                        cosonhahang.thongtinlienlac as Thongtinlienlac,
                        FROM cosonhahang
                            WHERE cosonhahang.diachi LIKE '%$tk%' 
                            OR loaicosonhahang.mota LIKE '%$tk%' 
                            OR cosonhahang.thongtinlienlac LIKE '%$tk%'";
                $result = mysqli_query($conn, $db); 

                if(mysqli_num_rows($result) == 0) {
                    echo "Không tìm thấy cơ sở nào  ";
                } else {
                    while($row = mysqli_fetch_array($result)) { ?>
                        <div class="khungsp">
                            <div class="tt"><?php echo $row['ID']; ?></div>
                            <img src="../images/Khonggian/<?php echo $row['Hinhanh'] ?>" alt="Image">
                            <div class="thongtin">
                                <h2><?php echo $row['Diachi']; ?></h2>
                                <p>
                                    Mô tả: <?php echo $row['Mota']; ?><br>
                                    Thông tin liên lạc: <?php echo $row['Thongtinlienlac']; ?>
                                </p>
                            </div>
                            <div class="sua">
                                <a style="text-decoration: none;" href="5Sua_KhongGianNhaHang.php?id=<?php echo $row['ID']; ?>">Sửa</a>
                            </div>
                            <div class="xoa">
                                <a style="text-decoration: none;" href="5Xoa_KhongGianNhaHang.php?id=<?php echo $row['ID']; ?>" onclick="return confirm('Bạn có chắc muốn xóa món này không?');">Xóa</a>
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
