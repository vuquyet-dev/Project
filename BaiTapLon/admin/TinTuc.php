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
    <title>Danh sách Tin tức</title>
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
        <h1>THÔNG TIN TIN TỨC</h1>
        <div>
            <div class="themmoi">
                <a href="Them_TinTuc.php">Thêm Tin Tức</a>
            </div>
            <div>
                <form action="Xuly_TimTinTuc.php" method="get" class="timkiem">
                    <input type="text" name="timkiem" placeholder="Nhập từ khóa...">
                    <input type="submit" value="Tìm kiếm">
                </form>
            </div>
        </div>
        
        <?php
            $query = "SELECT tintuc.id as ID,
                             tintuc.tieude as Tieude,
                             tintuc.noidung as Noidung,
                             tintuc.hinhanh as Hinhanh,
                             tintuc.ngaydang as Ngaydang
                      FROM tintuc 
                      ORDER BY tintuc.ngaydang DESC";
            $result = mysqli_query($conn, $query);

            if(mysqli_num_rows($result) == 0) {
                echo "Chưa có tin tức nào";
            } else {
                while($row = mysqli_fetch_array($result)) { ?>
                    <div class="khungsp">
                        <div class="tt"><?php echo $row['ID']; ?></div>
                        <img src="../images/TinTuc/<?php echo $row['Hinhanh'] ?>" alt="Image">
                        <div class="thongtin">
                            <h2><?php echo $row['Tieude']; ?></h2>
                            <p><?php echo mb_strimwidth($row['Noidung'], 0, 150, "..."); ?></p>
                            <p><b>Ngày đăng:</b> <?php echo date("d/m/Y", strtotime($row['Ngaydang'])); ?></p>
                        </div>
                        <div class="sua">
                            <a style="text-decoration: none;" href="Sua_TinTuc.php?id=<?php echo $row['ID']; ?>">Sửa</a>
                        </div>
                        <div class="xoa">
                            <a style="text-decoration: none;" href="Xoa_TinTuc.php?id=<?php echo $row['ID']; ?>" onclick="return confirm('Bạn có chắc muốn xóa tin này không?');">Xóa</a>
                        </div>
                    </div>
                <?php }
            }
        ?>
    </article>
    <?php include('../giaodien/Footer.php'); ?>
</body>
</html>
