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
        $id = $diachi = $mota = $thongtin = $hinhanh = "";
        if(isset($_POST["txtMacoso"]))  $id = $_POST['txtMacoso'];
        if(isset($_POST["txtDiachi"]))   $diachi = $_POST['txtDiachi'];
        if(isset($_POST["txtMota"]))  $mota = $_POST['txtMota'];
        if(isset($_POST["txtThongtin"])) $thongtin = $_POST['txtThongtin'];
        if(isset($_POST["filHinh"]))   $hinhanh = $_POST['filHinh'];
        // $hinhanh = './images/'.$hinh;

        $sql = "SELECT * FROM cosonhahang WHERE id = '$id'";

        $result = mysqli_query($conn, $sql);

        if(mysqli_num_rows($result) > 0)
        {
            echo '<script language = "javascript">alert("Mã này đã có. Vui lòng nhập lại!");
            window.location = "5Them_KhongGianNhaHang.php";</script>';

            die();
        }
        else{
            $chen = "INSERT INTO cosonhahang(id, diachi, mota, hinhanh, thongtinlienlac) 
         VALUES ('{$id}', '{$diachi}', '{$mota}', '{$thongtin}', '{$hinhanh}')";
            $chen = mysqli_query($conn, $chen);
            if($chen){
                echo '<script language = "javascript">alert("Thêm mới thành công!");
                window.location = "5DS_KhongGianNhaHang.php";</script>';
            }
            else{
                echo '<script language = "javascript">alert("Lỗi thêm mới!");
                window.location = "5Them_KhongGianNhaHang.php";</script>';
            }
        }
    ?>
</body>
</html>