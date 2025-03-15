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
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0;
        }
        .khung-anh {
            width: 100px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <?php 
        $ID = isset($_GET['id']) ? $_GET['id'] : 0;
        $db = "SELECT * FROM cosonhahang WHERE id = '$ID'";
        $query = mysqli_query($conn, $db);
        if(mysqli_num_rows($query) == 0){
            echo "Chưa có cơ sở cần sửa";
        } else {
            $result = mysqli_fetch_array($query);
            ?>
            <div class="khung">
                
                <div class="form-group" style="margin-bottom: 70px;">
                    <h2>SỬA CƠ SỞ</h2>
                    <div id="imgContainer" class="khung-anh"><img src="../images/Khonggian/<?php echo $result['hinhanh'];?>" alt="Cơ sở"></div>
                </div>
                <form name="suamonan" action="5xuly_SuaKhongGianNhaHang.php?id=<?php echo $result['id'];?>" method="post" enctype="multipart/form-data">
                    <div class="form-group">
                        <label class="label">Mã cơ sở</label>
                        <input type="text" id="txtMacoso" name="txtMacoso" class="form-control" readonly value="<?php echo $result['id']; ?>">
                    </div>
                    <div class="form-group">
                        <label class="label">Địa chỉ</label>
                        <input type="number" id="txtDiachi" name="txtDiachi" class="form-control" value="<?php echo $result['diachi']; ?>">
                    </div>
                    <div class="form-group">
                        <label class="label">Mô tả</label>
                        <textarea id="txtMota" name="txtMota" rows="3" cols="10" class="form-control"><?php echo $result['mota']; ?></textarea>
                    </div>
                    <div class="form-group">
                        <label class="label">Thông tin liên lạc</label>
                        <textarea id="txtThongtin" name="txtThongtin" rows="3" cols="10" class="form-control"><?php echo $result['thongtinlienlac']; ?></textarea>
                    </div>
                    <div class="form-group">
                        <label class="label">Hình</label>
                        <input type="file" id="filHinh" name="filHinh" class="form-control">
                    </div>
                    <div class="form-group" style="text-align: center;">
                        <button type="submit" class="button">Sửa món</button>
                        <button type="reset" class="button">Reset</button>
                    </div>
                    
                </form>
                <script>
                    const fileInput = document.getElementById('filHinh');
                    const imgContainer = document.getElementById('imgContainer');

                    fileInput.addEventListener('change', function(){
                        const file = fileInput.files[0];
                        const reader = new FileReader();
                        reader.onload = function(e){
                            const imgUrl = e.target.result;
                            imgContainer.innerHTML = '<img src="' + imgUrl + '" alt="Product Image">';
                        };
                        reader.readAsDataURL(file);
                    });
                </script>
            </div>
    <?php } ?>
    </div>
        <?php include('../giaodien/Footer.php'); ?>
    </div>
</body>
</html>
