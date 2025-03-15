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
    <title>Sửa Tin Tức</title>
    <?php
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0;
        }
        .khung-anh {
            width: 200px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <?php
        $ID = isset($_GET['id']) ? $_GET['id'] : 0;
        $db = "SELECT * FROM tintuc WHERE id = '$ID'";
        $query = mysqli_query($conn, $db);

        if(mysqli_num_rows($query) == 0) {
            echo "Không tìm thấy tin tức cần sửa.";
        } else {
            $result = mysqli_fetch_array($query);
    ?>
    <div class="khung">
        <div class="form-group">
            <h2>SỬA TIN TỨC</h2>
            <div id="imgContainer" class="khung-anh">
                <img src="../images/TinTuc/<?php echo $result['hinhanh']; ?>" alt="Hình tin tức">
            </div>
        </div>
        <form name="suatintuc" action="Xuly_SuaTinTuc.php?id=<?php echo $result['id']; ?>" method="post" enctype="multipart/form-data">
            <div class="form-group">
                <label class="label">Mã Tin Tức</label>
                <input type="text" id="txtMatin" name="txtMatin" class="form-control" readonly value="<?php echo $result['id']; ?>">
            </div>
            <div class="form-group">
                <label class="label">Tiêu Đề</label>
                <input type="text" id="txtTieude" name="txtTieude" class="form-control" value="<?php echo $result['tieude']; ?>">
            </div>
            <div class="form-group">
                <label class="label">Nội Dung</label>
                <textarea id="txtNoidung" name="txtNoidung" rows="5" cols="10" class="form-control"><?php echo $result['noidung']; ?></textarea>
            </div>
            <div class="form-group">
                <label class="label">Ngày Đăng</label>
                <input type="date" id="txtNgaydang" name="txtNgaydang" class="form-control" value="<?php echo date('Y-m-d', strtotime($result['ngaydang'])); ?>">
            </div>
            <div class="form-group">
                <label class="label">Hình Ảnh</label>
                <input type="file" id="filHinh" name="filHinh" class="form-control">
            </div>
            <div class="form-group" style="text-align: center;">
                <button type="submit" class="button">Sửa Tin</button>
                <button type="reset" class="button">Reset</button>
            </div>
        </form>
        <script>
            const fileInput = document.getElementById('filHinh');
            const imgContainer = document.getElementById('imgContainer');

            fileInput.addEventListener('change', function(){
                const file = fileInput.files[0];
                const reader = new FileReader();
                reader.onload = function(e) {
                    const imgUrl = e.target.result;
                    imgContainer.innerHTML = '<img src="' + imgUrl + '" alt="Tin Tức">';
                };
                reader.readAsDataURL(file);
            });
        </script>
    </div>
    <?php } ?>
    <?php include('../giaodien/Footer.php'); ?>
</body>
</html>
