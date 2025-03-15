<?php
session_start();
ob_start();
require_once("../xuly/ketnoi.php");
?>
<?php
    unset($_SESSION["login"]);
    $_SESSION["lguser"] = null;
    $_SESSION["htuser"] = null;
    header("location:DangNhap.php");
?>