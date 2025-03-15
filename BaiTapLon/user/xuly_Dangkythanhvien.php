<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng ký thành viên</title>
</head>
<body>
    <?php 
        include("ketnoi.php");
        $Hoten = $User = $Pass = $Gioitinh = $Ngaysinh = $Diachi = $Dienthoai = $Email = "";
        
        if(isset($_POST["txtHoten"])) $Hoten = $_POST["txtHoten"];
        if(isset($_POST["txtUser"])) $User = $_POST["txtUser"];
        if(isset($_POST["txtPass"])) $Pass = md5($_POST["txtPass"]);
        if(isset($_POST["radGioitinh"])) $Gioitinh = $_POST["radGioitinh"];
        if(isset($_POST["txtNgaysinh"])) $Ngaysinh = $_POST["txtNgaysinh"];
        if(isset($_POST["txtDiachi"])) $Diachi = $_POST["txtDiachi"];
        if(isset($_POST["txtDienthoai"])) $Dienthoai = $_POST["txtDienthoai"];
        if(isset($_POST["txtEmail"])) $Email = $_POST["txtEmail"];

        $sql = "SELECT * FROM tbthanhvien WHERE taikhoan = '$User'";
        $result = mysqli_query($conn, $sql);

        if(mysqli_num_rows($result) > 0) {
            echo '<script>alert("Tài khoản này đã tồn tại. Vui lòng nhập lại!");
            window.location = "DangKy.php";</script>';
            die();
        } else {
            $sql1 = "SELECT * FROM tbthanhvien WHERE email = '$Email'";
            $result1 = mysqli_query($conn, $sql1);

            if(mysqli_num_rows($result1) > 0) {
                echo '<script>alert("Email này đã tồn tại. Vui lòng nhập lại!");
                window.location = "DangKy.php";</script>';
                die();
            } else {
                $chen = "INSERT INTO tbthanhvien (hoten, taikhoan, matkhau, gioitinh, ngaysinh, diachi, dienthoai, email) 
                         VALUES (N'{$Hoten}', N'{$User}', N'{$Pass}', N'{$Gioitinh}', N'{$Ngaysinh}', N'{$Diachi}', N'{$Dienthoai}', N'{$Email}')";
                
                if(mysqli_query($conn, $chen)) {
                    echo '<script>alert("Đăng ký thành công");
                    window.location = "DangNhap.php";</script>';
                } else {
                    echo '<script>alert("Có lỗi trong quá trình xử lý");
                    window.location = "DangKy.php";</script>';
                }
            }
        }
    ?>
</body>
</html>
