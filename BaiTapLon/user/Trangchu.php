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
    <title>Trang chủ</title>
    <link rel="stylesheet" href="../css/giaodientrangchu.css">
</head>
<body >
    <?php include('../giaodienuser/Tieude.php'); ?>
    <?php include('../giaodienuser/MenuNgang.php'); ?>
    <?php include('../giaodienuser/AnhGioiThieu.php'); ?>
    <div class="container">
        <?php include('../giaodienuser/ContentGioiThieu.php'); ?>
        <hr style = "border: solid 1px #ccc; width: 600px; margin-top: 100px;">
        <?php include('../giaodienuser/MenuMonAn.php'); ?>
    </div>
    <?php include('../giaodienuser/KhongGian.php'); ?>
    <div class="container">
        <?php include('../giaodienuser/Theodoi.php'); ?>
        <hr style = "border: solid 1px #ccc; width: 600px; margin-top: 100px;">
    </div>
    <div class="container">
        <?php include('../giaodienuser/LienHe.php'); ?>
        
    </div>
    <?php include('../giaodienuser/Map.php'); ?>
    <?php include('../giaodienuser/Footer.php'); ?>
</body>
</html>