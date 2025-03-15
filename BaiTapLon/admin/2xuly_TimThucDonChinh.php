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
            <h1>THÔNG TIN CÁC MÓN THỰC ĐƠN CHÍNH</h1>
            <div>
                <div class="themmoi">
                    <a href="2Them_ThucDonChinh.php">Thêm Món</a>
                </div>
                <div>
                    <form action="2xuly_TimThucDonChinh.php" method="get" class="timkiem">
                        <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                        <input type="submit" value="Tìm kiếm">
                    </form>
                </div>
            </div>
        
            <?php
                $tk = $_GET['timkiem'];
                $db = "SELECT thucdonchinh.id as ID,
                        thucdonchinh.tenmon as Tenmon,
                        thucdonchinh.gia as Gia,
                        thucdonchinh.thanhphan as Thanhphan,
                        thucdonchinh.thongtinmon as Thongtinmon,
                        thucdonchinh.hinhanh as Hinhanh,
                        loaithucdonchinh.loaimon as Loaimon
                        FROM thucdonchinh
                        INNER JOIN loaithucdonchinh ON thucdonchinh.loaimon = loaithucdonchinh.loaimon
                            WHERE thucdonchinh.tenmon LIKE '%$tk%' 
                            OR loaithucdonchinh.loaimon LIKE '%$tk%' 
                            OR thucdonchinh.gia LIKE '%$tk%'";
                $result = mysqli_query($conn, $db); 

                if(mysqli_num_rows($result) == 0) {
                    echo "Không tìm thấy sản phẩm nào  ";
                } else {
                    while($row = mysqli_fetch_array($result)) { ?>
                        <div class="khungsp">
                            <div class="tt"><?php echo $row['ID']; ?></div>
                            <img src="../images/Thucdonchinh/<?php echo $row['Hinhanh'] ?>" alt="Image">
                            <div class="thongtin">
                                <h2><?php echo $row['Tenmon']; ?></h2>
                                <p>
                                    <b>Thành phần:</b> <?php echo $row['Thanhphan']; ?><br>
                                    <b>Thông tin món:</b> <?php echo $row['Thongtinmon']; ?><br> 
                                </p>
                                <p><b>Loại món:</b> <?php echo $row['Loaimon']; ?> &nbsp;&nbsp;|  <b>Giá:</b> <?php echo number_format($row['Gia'], 0, ',', '.'); ?>đ</p>
                            </div>
                            <div class="sua">
                                <a style="text-decoration: none;" href="2Sua_ThucDonChinh.php?id=<?php echo $row['ID']; ?>">Sửa</a>
                            </div>
                            <div class="xoa">
                                <a style="text-decoration: none;" href="2Xoa_ThucDonChinh.php?id=<?php echo $row['ID']; ?>" onclick="return confirm('Bạn có chắc muốn xóa món này không?');">Xóa</a>
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
