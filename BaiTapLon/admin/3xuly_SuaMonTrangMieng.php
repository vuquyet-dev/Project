<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        include('ketnoi.php');
        $chen1;
        $mamon = $tenmon = $loaimon = "";
        $dongia = 0;
        $tpdd = $thongtin = $hinh = "";
        if(!empty($_POST)){
            $mamon = $_POST['txtMamon'];
            $tenmon = $_POST['txtTenmon'];
            $loaimon = $_POST['selLoaimon'];
            $dongia = (int)$_POST['txtDongia'];
            $tpdd = $_POST['txtTpdd'];
            $thongtin = $_POST['txtThongtin'];
        }
        if(isset($_POST['filHinh'])){
            $hinh = $_POST['filHinh'];
        }
        if($hinh == ""){
            $chen1 = "update montrangmieng set 
            tenmon = '{$tenmon}', loaimon = '{$loaimon}',
            gia = '{$dongia}', thanhphan = '{$tpdd}', 
            thongtinmon = '{$thongtin}' where id = '{$mamon}'";
        }
        else{
            $hinhanh = '../images/'.$hinh;
            $chen1 = "update montrangmieng set 
            tenmon = '{$tenmon}', loaimon = '{$loaimon}',
            gia = '{$dongia}', thanhphan = '{$tpdd}', 
            thongtinmon = '{$thongtin}', hinhanh = '{$hinhanh}' where id = '{$mamon}'";
        }
        $chen = mysqli_query($conn, $chen1);
        if($chen){
            echo '<script language = "javascript">alert("Sửa món thành công");
            window.location = "3DS_MonTrangMieng.php";</script>';
        }
        else{
            echo '<script language = "javascript">alert("Có lỗi trong quá trình xử lý");
            window.location = "3Sua_MonTrangMieng.php";</script>';
        }
    ?>
</body>
</html>