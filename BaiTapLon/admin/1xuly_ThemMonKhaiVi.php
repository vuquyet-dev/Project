<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        include("ketnoi.php");
        $mamon = $tenmon = $loaimon = "";
        $dongia = 0;
        $tpdd = $thongtin = $hinh = "";
        if(isset($_POST["txtMamon"]))  $mamon = $_POST["txtMamon"];
        if(isset($_POST["txtTenmon"]))  $tenmon = $_POST["txtTenmon"];
        if(isset($_POST["selLoaimon"]))  $loaimon = $_POST["selLoaimon"];
        if(isset($_POST["txtDongia"]))  $dongia = (int)$_POST["txtDongia"];
        if(isset($_POST["txtTpdd"]))  $tpdd = $_POST["txtTpdd"];
        if(isset($_POST["txtThongtin"]))  $thongtin = $_POST["txtThongtin"];
        if(isset($_POST["filHinh"]))  $hinh = $_POST["filHinh"];
        // $hinhanh = './images/'.$hinh;

        $sql = "SELECT * FROM monkhaivi WHERE id = '$mamon'";

        $result = mysqli_query($conn, $sql);

        if(mysqli_num_rows($result) > 0)
        {
            echo '<script language = "javascript">alert("Mã này đã có. Vui lòng nhập lại!");
            window.location = "1Them_MonKhaiVi.php";</script>';

            die();
        }
        else{
            $chen = "INSERT INTO monkhaivi(id, tenmon, loaimon, gia, thanhphan, thongtinmon, hinhanh) 
         VALUES ('{$mamon}', '{$tenmon}', '{$loaimon}', '{$dongia}', '{$tpdd}', '{$thongtin}', '{$hinh}')";
            $chen = mysqli_query($conn, $chen);
            if($chen){
                echo '<script language = "javascript">alert("Thêm mới thành công!");
                window.location = "1DS_MonKhaiVi.php";</script>';
            }
            else{
                echo '<script language = "javascript">alert("Lỗi thêm mới!");
                window.location = "1Them_MonKhaiVi.php";</script>';
            }
        }
    ?>
</body>
</html>