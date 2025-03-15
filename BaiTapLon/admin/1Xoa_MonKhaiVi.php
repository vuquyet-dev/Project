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
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")){
            header("location:DangNhap.php");
        }
    ?>
</head>
<body>
    <?php
        $ID = isset($_GET['id'])?$_GET['id']:0;
        $db = "delete from monkhaivi where id = '$ID'";
        $xoa = mysqli_query($conn, $db);
        if($xoa){
            echo '<script language = "javascript">alert("Món này đã được xóa");
            window.location = "1DS_MonKhaiVi.php";</script>';
        }
        mysqli_close($conn);
    ?>
</body>
</html>