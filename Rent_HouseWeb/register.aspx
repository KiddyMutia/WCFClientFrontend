<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Rent_HouseWeb.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
  <title>My Kost | Register User</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>
<body>
    
  <!-- Navbar Atas -->
   <nav class="navbar navbar-default">
    <div class="container-fluid">
      <div class="navbar-header">
        <a class="navbar-brand" href="index.aspx">My Kost</a>
      </div>
    </div>
  </nav>


<div class="container" style="">

  <div class="container col-md-6">
    <h2>User Regist</h2>
	<hr>
	<form action="#" method="post">
      <div class="form-group">
        <label for="email">Email</label>
        <input type="email" class="form-control" id="email" placeholder="Input Email" name="email" required="required" runat="server">
      </div>
      <div class="form-group">
        <label for="password">Password</label>
        <input type="password" class="form-control" id="password" placeholder="Input Password" name="password" required="">
      </div>
	  <div class="form-group">
        <label for="nama">Nama</label>
        <input type="text" class="form-control" id="nama" placeholder="Input Name" name="nama" required="required">
      </div>
	  <div class="form-group">
        <label for="nama">Phone Number</label>
        <input type="text" class="form-control" id="phone" placeholder="Input Phone Number" name="nama" required="required">
      </div>
	  <div class="form-group">
        <label for="nama">Birthdate</label>
        <input type="text" class="form-control" id="nama" placeholder="(YYYY-MM-DD)" name="nama" required="required">
      </div>
	  <div class="form-group">
        <label for="nama">Card Type</label>
        <select type="text" class="form-control" id="nama" name="nama" >
			<option value="KTP"> KTP </option>
			<option value="KTM"> KTM </option>
		</select>
      </div>
	  <div class="form-group">
        <label for="nama">Card Number</label>
        <input type="text" class="form-control" id="nama" placeholder="Input Card Number" name="nama" required="required">
      </div>
	  <div class="form-group">
        <label for="nama">Address</label>
        <textarea type="text" class="form-control" id="nama" placeholder="Input Card Number" name="nama" required="required"></textarea>
      </div>
      <button type="submit" class="btn btn-default">Register</button>
    </form>
  </div>

</div>

<!-- footer -->
	<footer class="footer">
	<br>
	<hr>
		<div class="container">
			<p class="text-muted">2017 | My Kost</p>
		</div>
	</footer>

</body>
</html>
