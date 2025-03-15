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
        $id = $diachi = $mota = $thongtin = $hinhanh = "";
        if(!empty($_POST)){
            $id = $_POST['txtMacoso'];
            $diachi = $_POST['txtDiachi'];
            $mota = $_POST['txtMota'];
            $thongtin = $_POST['txtThongtin'];
            $hinhanh = $_POST['filHinh'];
        }
        if(isset($_POST['filHinh'])){
            $hinh = $_POST['filHinh'];
        }
        if($hinh == ""){
            $chen1 = "UPDATE cosonhahang SET 
                        diachi = '{$diachi}', 
                        mota = '{$mota}', 
                        thongtinlienlac = '{$thongtin}' ,
                      WHERE id = '{$id}'";
        }
        else{
            $hinhanh = '../images/'.$hinh;
            $chen1 =  "UPDATE cosonhahang SET 
            diachi = '{$diachi}', 
            mota = '{$mota}', 
            thongtinlienlac = '{$thongtin}', 
            hinhanh = '{$hinhanh}' 
          WHERE id = '{$id}'";
        }
        $chen = mysqli_query($conn, $chen1);
        if($chen){
            echo '<script language = "javascript">alert("Sửa món thành công");
            window.location = "5DS_KhongGianNhaHang.php";</script>';
        }
        else{
            echo '<script language = "javascript">alert("Có lỗi trong quá trình xử lý");
            window.location = "5Sua_KhongGianNhaHang.php";</script>';
        }
    ?>
</body>
</html>