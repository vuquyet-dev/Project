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
    <title>Thêm mới sữa</title>
    <link rel="stylesheet" href="../css/giaodientrangchu.css">
    <link rel="stylesheet" href="../css/style.css">
    <style type="text/css">
        img {
            max-width: 100%;
            height: auto;
            margin-top: 0px;
        }
        .khung-anh {
            width: 60px;
            height: 60px;
            margin-left: 5px;
            position: absolute;
            top: 5px;
            right: 50px;
        }
    </style>
<?php
    if (($_SESSION["lgadmin"]==null) || ($_SESSION["lgadmin"]=="")) {
        header("location:DangNhap.php");
    }
?>
<script language="javascript">
    function HienThi() {
        var duongdan = window.document.myForm.filHinh.value;
        if(duongdan!="") {
            window.document.myForm.anh.src="hinh/" + duongdan;
        }
    }
    function kiemtrasua() {
        var tenmon="", mamon="", thongtin="", hinh="";
        var loaimon ="", dongia="", tpdd="";
        mamon=document.getElementById("txtMamon");
        tenmon=document.getElementById("txtTenmon");
        loaimon=document.getElementById("selLoaimon");
        dongia=document.getElementById("txtDongia");
        tpdd=document.getElementById("txtTpdd");
        thongtin=document.getElementById("txtThongtin");
        hinh=document.getElementById("filHinh");
        if(mamon.value=="") {
            alert("Bạn phải nhập Mã món, Nhập lại!");
            mamon.focus();
            return false;
        } else {
            if(tenmon.value=="") {
                alert("Bạn không được để trống ô tên món, nhập lại!");
                tenmon.focus();
                return false;
            } else {
                if(loaimon.value=="") {
                    alert("Bạn chưa chọn loại món, chọn lại!");
                    loaimon.focus();
                    return false;
                } else {
                    if(dongia.value=="") {
                        alert("Bạn chưa chọn đơn giá, chọn lại!");
                        dongia.focus();
                        return false;
                    } else {
                        if(tpdd.value=="") {
                            alert("Thành phần dinh dưỡng không được để trống, nhập lại!");
                            tpdd.focus();
                            return false;
                        } else {
                            if(thongtin.value=="") {
                                alert("Thông tin không được để trống, nhập lại!");
                                thongtin.focus();
                                return false;
                            } else {
                                if(hinh.value=="") {
                                    alert("Bạn chưa chọn hình, nhập lại!");
                                    hinh.focus();
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
</script>
<div class="container">
        <?php include('../giaodien/TieuDe.php'); ?>
        <?php include('../giaodien/MenuNgang.php'); ?>
        <div class="khung">
        <div class="form-group" style = "margin-bottom: 40px">
            <h2>THÊM MỚI ĐỒ UỐNG</h2>
            <div id = "imgContainer" class = "khung-anh"></div>
        </div>
        <form name="themmon" action = "4xuly_ThemDouong.php" method="post" onsubmit = "return kiemtrasua()">
            <div class="form-group">
                <label class="label">Mã món</label>
                <input type="text" id="txtMamon" name="txtMamon" class="form-control">
            </div>
            <div class="form-group">
                <label class="label">Tên món</label>
                <input type="text" id="txtTenmon" name="txtTenmon" class="form-control">
            </div>
            <div class="form-group">
                <label class="label">Loại món</label>
                <?php
                    $db = "SELECT * FROM loaidouong";
                    $query = mysqli_query($conn, $db);
                    if(mysqli_num_rows($query) > 0) {
                ?>
                    <select id="selLoaimon" name="selLoaimon" style="font-size: 16px;" class="form-control">
                        <option value="">-- Chọn loại món --</option>
                        <?php while($row = mysqli_fetch_array($query)) { ?>
                            <option value = "<?php echo $row['loaimon']; ?>">
                                <?php echo $row['loaimon']; ?>
                            </option>
                        <?php } ?>
                    </select>
                <?php } ?>
            </div>
            <div class="form-group">
                <label class="label">Đơn giá</label>
                <input type="number" id="txtDongia" name="txtDongia" class="form-control">
            </div>
            <div class="form-group">
                <label class="label">Thành phần</label>
                <textarea id="txtTpdd" name="txtTpdd" rows="3" cols="10" class="form-control"></textarea>
            </div>
            <div class="form-group">
                <label class="label">Thông tin món</label>
                <textarea id="txtThongtin" name="txtThongtin" rows="3" cols="10" class="form-control"></textarea>
            </div>
            <div class="form-group">
                <label class="label">Hình</label>
                <input type="file" id="filHinh" name="filHinh" class="form-control">
            </div>
            <div class="form-group" style="text-align: center;">
                <button type="submit" class="button">Thêm món</button>
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
                    imgContainer.innerHTML = '<img src = "${imgUrl}" alt = "Product Image">';
                };
                reader.readAsDataURL(file);
            });
            
        </script>
        
    </div>
        <?php include('../giaodien/Footer.php'); ?>
    </div>
        
</html>