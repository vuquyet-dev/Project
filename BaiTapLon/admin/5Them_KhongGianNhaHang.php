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
    <title>Thêm không gian nhà hàng</title>
    <link rel="stylesheet" href="../css/giaodientrangchu.css">
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0px;
        }
        .khung-anh {
            width: 60px;
            height: 60px;
            margin-left: 5px;
            position: absolute;
            top: 5px;
            right: 50px;
        }
    </style>
<?php
    if (($_SESSION["lgadmin"]==null) || ($_SESSION["lgadmin"]=="")) {
        header("location:DangNhap.php");
    }
?>
<script>
    function kiemTraThem() {
        const macoso = document.getElementById("txtMacoso").value;
        const diachi = document.getElementById("txtDiachi").value;
        const mota = document.getElementById("txtMota").value;
        const thongtin = document.getElementById("txtThongtin").value;
        const hinh = document.getElementById("filHinh").value;

        if (macoso === "") {
            alert("Vui lòng nhập mã cơ sở.");
            return false;
        } else if (diachi === "") {
            alert("Vui lòng nhập địa chỉ.");
            return false;
        } else if (mota === "") {
            alert("Vui lòng nhập mô tả.");
            return false;
        } else if (thongtin === "") {
            alert("Vui lòng nhập thông tin liên lạc.");
            return false;
        } else if (hinh === "") {
            alert("Vui lòng chọn hình ảnh.");
            return false;
        }
        return true;
    }
</script>
<div class="container">
        <?php include('../giaodien/TieuDe.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <div class="khung">
            <div class="form-group" style="margin-bottom: 40px;">
                <h2>THÊM KHÔNG GIAN NHÀ HÀNG</h2>
                <div id="imgContainer" class="khung-anh"></div>
            </div>
            <form name="themkhonggian" action="1xuly_ThemKhongGianNhaHang.php" method="post" enctype="multipart/form-data" onsubmit="return kiemTraThem()">
                <div class="form-group">
                    <label class="label">Mã cơ sở</label>
                    <input type="text" id="txtMacoso" name="txtMacoso" class="form-control">
                </div>
                <div class="form-group">
                    <label class="label">Địa chỉ</label>
                    <input type="text" id="txtDiachi" name="txtDiachi" class="form-control">
                </div>
                <div class="form-group">
                    <label class="label">Mô tả</label>
                    <textarea id="txtMota" name="txtMota" rows="3" cols="10" class="form-control"></textarea>
                </div>
                <div class="form-group">
                    <label class="label">Thông tin liên lạc</label>
                    <textarea id="txtThongtin" name="txtThongtin" rows="3" cols="10" class="form-control"></textarea>
                </div>
                <div class="form-group">
                    <label class="label">Hình ảnh</label>
                    <input type="file" id="filHinh" name="filHinh" class="form-control">
                </div>
                <div class="form-group" style="text-align: center;">
                    <button type="submit" class="button">Thêm Không Gian</button>
                    <button type="reset" class="button">Reset</button>
                </div>
            </form>
            <script>
                const fileInput = document.getElementById('filHinh');
                const imgContainer = document.getElementById('imgContainer');
                fileInput.addEventListener('change', function() {
                    const file = fileInput.files[0];
                    const reader = new FileReader();
                    reader.onload = function(e) {
                        const imgUrl = e.target.result;
                        imgContainer.innerHTML = '<img src="' + imgUrl + '" alt="Preview Image">';
                    };
                    reader.readAsDataURL(file);
                });
            </script>
        </div>
        <?php include('../giaodien/Footer.php'); ?>
    </div>
        
</html>