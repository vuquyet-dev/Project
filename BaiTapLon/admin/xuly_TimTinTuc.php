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
    <title>Tìm kiếm Tin Tức</title>
    <link rel="stylesheet" href="./css/giaodientrangchu.css">
    <link rel="stylesheet" href="./css/style.css">
    <link rel="stylesheet" href="../css/style_DSthemsuaxoa.css">
    <?php
        if (($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
</head>
<body>
    <?php include('../giaodien/Tieude.php'); ?>
    <?php include('../giaodien/MenuNgang.php'); ?>

    <article>
        <h1>Kết Quả Tìm Kiếm Tin Tức</h1>
        <div>
            <div class="themmoi">
                <a href="Them_TinTuc.php">Thêm Tin Tức</a>
            </div>
            <div>
                <form action="xuly_TimTinTuc.php" method="get" class="timkiem">
                    <input type="text" name="timkiem" placeholder="Nhập từ khóa..." value="<?php echo isset($_GET['timkiem']) ? $_GET['timkiem'] : ''; ?>">
                    <input type="submit" value="Tìm kiếm">
                </form>
            </div>
        </div>

        <?php
            // Lấy từ khóa tìm kiếm
            $tk = isset($_GET['timkiem']) ? $_GET['timkiem'] : '';
            
            // Truy vấn cơ sở dữ liệu
            $sql = "SELECT tintuc.id AS ID, 
                           tintuc.tieude AS TieuDe, 
                           tintuc.loaitin AS LoaiTin, 
                           tintuc.noidung AS NoiDung, 
                           tintuc.hinhanh AS HinhAnh 
                    FROM tintuc
                    WHERE tintuc.tieude LIKE '%$tk%' 
                       OR tintuc.loaitin LIKE '%$tk%' 
                       OR tintuc.noidung LIKE '%$tk%'";
            $result = mysqli_query($conn, $sql);

            // Kiểm tra kết quả truy vấn
            if (mysqli_num_rows($result) == 0) {
                echo "<p>Không tìm thấy kết quả nào phù hợp với từ khóa <b>'$tk'</b>.</p>";
            } else {
                while ($row = mysqli_fetch_array($result)) { ?>
                    <div class="khungsp">
                        <div class="tt"><?php echo $row['ID']; ?></div>
                        <img src="../images/TinTuc/<?php echo $row['HinhAnh']; ?>" alt="Image">
                        <div class="thongtin">
                            <h2><?php echo $row['TieuDe']; ?></h2>
                            <p>
                                <b>Loại tin:</b> <?php echo $row['LoaiTin']; ?><br>
                                <b>Nội dung:</b> <?php echo substr($row['NoiDung'], 0, 100); ?>...
                            </p>
                        </div>
                        <div class="sua">
                            <a style="text-decoration: none;" href="Sua_TinTuc.php?id=<?php echo $row['ID']; ?>">Sửa</a>
                        </div>
                        <div class="xoa">
                            <a style="text-decoration: none;" href="Xoa_TinTuc.php?id=<?php echo $row['ID']; ?>" onclick="return confirm('Bạn có chắc muốn xóa tin tức này không?');">Xóa</a>
                        </div>
                    </div>
                <?php }
            }

            // Đóng kết nối
            mysqli_close($conn);
        ?>
    </article>
    <?php include('../giaodien/Footer.php'); ?>
</body>
</html>
