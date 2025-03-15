<?php
    session_start();
    ob_start();
    //include('ketnoi.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
  <link rel="stylesheet" href="../css/giaodientrangchu.css">
  <link rel="stylesheet" href="../css/style.css">
  <script type = "text/javascript" language = "javascript">
    function kiemtra(){
      var password = "", confirm = "";
      var hoten = "", user = "", diachi = "", email = "";
      hoten = document.getElementById("txtHoten");
      user = document.getElementById("txtUser1");
      password = document.getElementById("txtPass1");
      confirm = document.getElementById("txtConfirm");
      diachi = document.getElementById("txtDiachi");
      email = document.getElementById("txtEmail");
      if(hoten.value == ""){
        alert("Bạn không được để trống ô họ tên, nhập lại");
        hoten.focus();
        return false;
      }
      else{
        if(user.value == ""){
          alert("Bạn không được để trống ô Username, nhập lại");
          user.focus();
          return false;
        }
        else{
          if(password.value == ""){
            alert("Bạn không được để trống ô Mật khẩu, nhập lại");
            password.focus();
            return false;
          }
          else{
            if(password.value.length < 8){
              alert("Mật khẩu phải 8 ký tự trở lên, nhập lại");
              password.focus();
              return false;
            }
            else{
              if(confirm.value != password.value){
                alert("Mật khẩu và xác nhận mật khẩu không giống nhau, nhập lại");
                confirm.focus();
                return false;
              }
              else{
                if(diachi.value == ""){
                  alert("Bạn không được để trống ô Địa chỉ, nhập lại");
                  diachi.focus();
                  return false;
                }
                else{
                  if(email.value == ""){
                    alert("Bạn không được để trống ô Email, nhập lại");
                    email.focus();
                    return false;
                  }
                  else{
                    ktEmail = /^\w(\.?[\w+])*@\w(\.?[\w+])*\.[a-z]{2,4}$/i;
                    if(!ktEmail.test(email.value)){
                      alert("Bạn nhập không đúng định dang mail");
                      email.focus();
                      return false;
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  </script>
</head>
<body>
<div class="khung">
        <h2>ĐĂNG KÝ THÀNH VIÊN</h2>
        <form name = "dangKyThanhVien" action="xuly_Dangkythanhvien.php" method="post" onsubmit = "return kiemtra()">
          <div class="form-group">
            <label for="" class="label">Họ và tên</label>
            <input type="text" id = "txtHoten" name = "txtHoten" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Username</label>
            <input type="text" id = "txtUser1" name = "txtUser" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Password</label>
            <input type="password" id = "txtPass1" name = "txtPass" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Confirm Password</label>
            <input type="password" id = "txtConfirm" name = "txtConfirm" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Giới tính</label>
            <div class="form-rad">
            <input type="radio" id = "radNam" name = "radGioitinh"  value = "Nam"> <p>Nam </p>
            <input type="radio" id = "radNu" name = "radGioitinh"  value = "Nữ" ><p>Nữ </p>
            <input type="radio" id = "radkhac" name = "radGioitinh"  value = "Khác" ><p>Khác </p>
            </div>
          </div>
          <div class="form-group">
            <label for="" class="label">Ngày sinh</label>
            <input type="date" name = "txtNgaysinh" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Địa chỉ</label>
            <input type="text" id = "txtDiachi" name = "txtDiachi" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Điện thoại</label>
            <input type="text" name = "txtDienthoai" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Email</label>
            <input type="text" id = "txtEmail" name = "txtEmail" class = "form-control" >
          </div>
          <div class="form-group">
            <label for="" class="label">Quyền</label>
            <select name="cmbQuyen" class = "form-control">
              <option value="0">Thành viên</option>
              <option value="1">Quản trị</option>
            </select>
          </div>
          <div class="form-group">
            <button type = "submit" class = "button">Đăng ký</button>
            <button type = "reset" class = "button">Reset</button>
          </div>
          
        </form>
      </div>

</body>
</html>