<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="../css/style.css">
</head>
<body>

    <?php
        session_start(); 
        include("ketnoi.php");
        $User = $Pass = "";

       
        if (isset($_POST["txtUser"]) && isset($_POST["txtPass"])) {
            $User = $_POST["txtUser"];
            $Pass = md5($_POST["txtPass"]); 

            
            if ($User == "" || $Pass == "") {
                echo "<script>alert('Bạn phải nhập tên tài khoản và mật khẩu');</script>";
            } else {
                
                $sql = "SELECT * FROM tbthanhvien WHERE taikhoan = '$User' AND matkhau = '$Pass'";
                $query = mysqli_query($conn, $sql);

                if (mysqli_num_rows($query) == 0) {
                    echo "<script>alert('Username hoặc Password không đúng, vui lòng nhập lại');</script>";
                } else {
                    $row = mysqli_fetch_assoc($query);

                    
                    if ($row["quyen"] == 0) { 
                        $_SESSION["lguser"] = true;
                        $_SESSION["Matv"] = $row["matv"];
                        $_SESSION["Hoten"] = $row["hoten"];
                        $_SESSION["Email"] = $row["email"];
                        header("location: Trangchu.php");
                        exit;
                    } elseif ($row["quyen"] == 1) { 
                        echo "<script>alert('Tài khoản hoặc mật khẩu không chính xác');</script>";
                    }
                }
            }
        }
    ?>

    <div class="khung">
        <form action="" name="form1" method="post">
            <div class="form-group">
                <h2>ĐĂNG NHẬP</h2>
                <label for="" class="label">Username</label>
                <input type="text" name="txtUser" class="form-control">
            </div>
            <div class="form-group">
                <label for="" class="label">Password</label>
                <input type="password" name="txtPass" class="form-control">
            </div>
            <div class="form-group">
                <button type="submit" class="button">Đăng nhập</button>
                <button type="reset" class="button">Reset</button>
            </div>
        </form>
        <div style="margin-top: 110px; text-align: center;">Bạn chưa có tài khoản, bấm vào đây để:  
            <a href="Dangky.php"><b>Đăng ký</b></a>.</div>
        <div style="margin: 5px 0px; text-align: center;">Quên mật khẩu, bấm vào đây để: 
            <a href="Quenmatkhau.php"><b>Lấy lại</b></a>. 
        </div>
    </div>

</body>
</html>
