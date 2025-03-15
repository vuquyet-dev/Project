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
        if(($_SESSION["lgadmin"] == null) || ($_SESSION["lgadmin"] == "")) {
            header("location:DangNhap.php");
        }
    ?>
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0;
        }
        .khung-anh {
            width: 100px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <?php 
        $ID = isset($_GET['id']) ? $_GET['id'] : 0;
        $db = "SELECT * FROM montrangmieng WHERE id = '$ID'";
        $query = mysqli_query($conn, $db);
        if(mysqli_num_rows($query) == 0){
            echo "Chưa có món ăn cần sửa";
        } else {
            $result = mysqli_fetch_array($query);
            ?>
            <div class="khung">
                
                <div class="form-group" style="margin-bottom: 70px;">
                    <h2>SỬA MÓN ĂN</h2>
                    <div id="imgContainer" class="khung-anh"><img src="../images/Montrangmieng/<?php echo $result['hinhanh'];?>" alt="Món ăn"></div>
                </div>
                <form name="suamonan" action="3xuly_SuaMonTrangMieng.php?id=<?php echo $result['id'];?>" method="post" enctype="multipart/form-data">
                    <div class="form-group">
                        <label class="label">Mã món</label>
                        <input type="text" id="txtMamon" name="txtMamon" class="form-control" readonly value="<?php echo $result['id']; ?>">
                    </div>
                    <div class="form-group">
                        <label class="label">Tên món</label>
                        <input type="text" id="txtTenmon" name="txtTenmon" class="form-control" value="<?php echo $result['tenmon']; ?>">
                    </div>
                    <div class="form-group">
                        <label class="label">Loại món</label>
                        <?php
                            $db = "SELECT * FROM loaimontrangmieng";
                            $query = mysqli_query($conn, $db);
                            if(mysqli_num_rows($query) > 0) {
                        ?>
                            <select id="selLoaimon" name="selLoaimon" style="font-size: 16px;" class="form-control">
                                <option value="">-- Chọn loại món --</option>
                                <?php while($row = mysqli_fetch_array($query)) { ?>
                                    <option value="<?php echo $row['loaimon']; ?>" <?php echo ($row['loaimon'] == $result['loaimon']) ? 'selected' : ''; ?>>
                                        <?php echo $row['loaimon']; ?>
                                    </option>
                                <?php } ?>
                            </select>
                        <?php } ?>
                    </div>
                    <div class="form-group">
                        <label class="label">Đơn giá</label>
                        <input type="number" id="txtDongia" name="txtDongia" class="form-control" value="<?php echo $result['gia']; ?>">
                    </div>
                    <div class="form-group">
                        <label class="label">Thành phần</label>
                        <textarea id="txtTpdd" name="txtTpdd" rows="3" cols="10" class="form-control"><?php echo $result['thanhphan']; ?></textarea>
                    </div>
                    <div class="form-group">
                        <label class="label">Thông tin món</label>
                        <textarea id="txtThongtin" name="txtThongtin" rows="3" cols="10" class="form-control"><?php echo $result['thongtinmon']; ?></textarea>
                    </div>
                    <div class="form-group">
                        <label class="label">Hình</label>
                        <input type="file" id="filHinh" name="filHinh" class="form-control">
                    </div>
                    <div class="form-group" style="text-align: center;">
                        <button type="submit" class="button">Sửa món</button>
                        <button type="reset" class="button">Reset</button>
                    </div>
                    
                </form>
                <script>
                    const fileInput = document.getElementById('filHinh');
                    const imgContainer = document.getElementById('imgContainer');

                    fileInput.addEventListener('change', function(){
                        const file = fileInput.files[0];
                        const reader = new FileReader();
                        reader.onload = function(e){
                            const imgUrl = e.target.result;
                            imgContainer.innerHTML = '<img src="' + imgUrl + '" alt="Product Image">';
                        };
                        reader.readAsDataURL(file);
                    });
                </script>
            </div>
    <?php } ?>
    </div>
        <?php include('../giaodien/Footer.php'); ?>
    </div>
</body>
</html>
