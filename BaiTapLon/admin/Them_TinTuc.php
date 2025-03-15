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
    <title>Thêm Tin Tức</title>
    <link rel="stylesheet" href="../css/giaodientrangchu.css">
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0;
        }
        .khung-anh {
            width: 100px;
            height: 100px;
            margin-left: 5px;
            position: absolute;
            top: 5px;
            right: 50px;
        }
    </style>
<?php
    if (($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
        header("location:DangNhap.php");
    }
?>
<script language="javascript">
    function kiemtratintuc() {
        var tieude = document.getElementById("txtTieude");
        var noidung = document.getElementById("txtNoidung");
        var ngaydang = document.getElementById("txtNgaydang");
        var hinh = document.getElementById("filHinh");
        
        if (tieude.value == "") {
            alert("Bạn phải nhập Tiêu đề, Nhập lại!");
            tieude.focus();
            return false;
        } else if (noidung.value == "") {
            alert("Nội dung không được để trống, nhập lại!");
            noidung.focus();
            return false;
        } else if (ngaydang.value == "") {
            alert("Ngày đăng không được để trống, nhập lại!");
            ngaydang.focus();
            return false;
        } else if (hinh.value == "") {
            alert("Bạn chưa chọn hình, nhập lại!");
            hinh.focus();
            return false;
        }
        return true;
    }
</script>
</head>
<body>
    <div class="container">
        <?php include('../giaodien/TieuDe.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <div class="khung">
            <div class="form-group" style="margin-bottom: 40px">
                <h2>THÊM MỚI TIN TỨC</h2>
                <div id="imgContainer" class="khung-anh"></div>
            </div>
            <form name="themtintuc" action="Xuly_ThemTinTuc.php" method="post" enctype="multipart/form-data" onsubmit="return kiemtratintuc()">
                <div class="form-group">
                    <label class="label">Tiêu Đề</label>
                    <input type="text" id="txtTieude" name="txtTieude" class="form-control">
                </div>
                <div class="form-group">
                    <label class="label">Nội Dung</label>
                    <textarea id="txtNoidung" name="txtNoidung" rows="5" cols="10" class="form-control"></textarea>
                </div>
                <div class="form-group">
                    <label class="label">Ngày Đăng</label>
                    <input type="date" id="txtNgaydang" name="txtNgaydang" class="form-control">
                </div>
                <div class="form-group">
                    <label class="label">Hình</label>
                    <input type="file" id="filHinh" name="filHinh" class="form-control">
                </div>
                <div class="form-group" style="text-align: center;">
                    <button type="submit" class="button">Thêm Tin</button>
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
                        imgContainer.innerHTML = '<img src="' + imgUrl + '" alt="Tin Tức">';
                    };
                    reader.readAsDataURL(file);
                });
            </script>
        </div>
        <?php include('../giaodien/Footer.php'); ?>
    </div>
</body>
</html>
