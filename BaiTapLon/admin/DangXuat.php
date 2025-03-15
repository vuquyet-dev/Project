<?php
session_start();
ob_start();
require_once("../xuly/ketnoi.php");
?>
<?php
    unset($_SESSION["login"]);
    $_SESSION["lgadmin"] = null;
    $_SESSION["htadmin"] = null;
    header("location:DangNhap.php");
?>