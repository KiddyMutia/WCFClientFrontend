<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_customer.aspx.cs" Inherits="Rent_HouseWeb.login_customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>My Kost | Customer Login</title>
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


<div class="container" style=" ">

  <div class="container col-md-6">
    <h2>User Login</h2>
	<form action="#" method="post" runat="server">
      <div class="form-group">
        <label for="email">Email</label>
        <input type="text" class="form-control" id="emailfromuser" placeholder="Masukkan Email" name="email" required="required" runat="server">
      </div>
      <div class="form-group">
        <label for="password">Password</label>
        <input type="password" class="form-control" id="passwordfromuser" placeholder="Masukkan Password" name="password" required="" runat="server">
      </div>
      <asp:Button type="submit" CssClass="btn btn-info" Text="Login" OnClick="btn_loginClick" runat="server"></asp:Button>
    </form>
  </div>

</div>

<!-- footer -->
	<footer class="footer">
	<br>
	<hr>
		<div class="container">
			<p class="text-muted">Anak IT - Kami memulai program dengan "Hello World"</p>
		</div>
	</footer>
</body>
</html>
