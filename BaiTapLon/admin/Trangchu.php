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
    <?php include('../giaodien/Tieude.php'); ?>
    <?php include('../giaodien/MenuNgang.php'); ?>
    <?php include('../giaodien/AnhGioiThieu.php'); ?>
    <div class="container">
        <?php include('../giaodien/ContentGioiThieu.php'); ?>
        <hr style = "border: solid 1px #ccc; width: 600px; margin-top: 100px;">
        <?php include('../giaodien/MenuMonAn.php'); ?>
    </div>
    <?php include('../giaodien/KhongGian.php'); ?>
    <div class="container">
        <?php include('../giaodien/Theodoi.php'); ?>
        <hr style = "border: solid 1px #ccc; width: 600px; margin-top: 100px;">
    </div>
    <div class="container">
        <?php include('../giaodien/LienHe.php'); ?>
        
    </div>
    <?php include('../giaodien/Map.php'); ?>
    <?php include('../giaodien/Footer.php'); ?>
</body>
</html>