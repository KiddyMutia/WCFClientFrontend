<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Rent_HouseWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<title>Rent House Admin Panel | Login</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Minimal Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="assets/backend/css/bootstrap.min.css" rel='stylesheet' type='text/css' />
<!-- Custom Theme files -->
<link href="assets/backend/css/style.css" rel='stylesheet' type='text/css' />
<link href="assets/backend/css/font-awesome.css" rel="stylesheet"> 
<script src="assets/backend/js/jquery.min.js"> </script>
<script src="assets/backend/js/bootstrap.min.js"> </script>
</head>
<body>
	<div class="login">
		<h1><a href="#">Rent House Admin Panel </a></h1>
		<div class="login-bottom">
			<h2>Login</h2>
			<form runat="server">
			<div class="col-md-6">
            
				<div class="login-mail">
                    <asp:TextBox type="text" ID="tb_username" placeholder="Username" required="" runat="server"></asp:TextBox>
					<i class="fa fa-user"></i>
				</div>
				<div class="login-mail">
					<asp:TextBox type="password" ID="tb_password" placeholder="Password" required="" runat="server"></asp:TextBox>
					<i class="fa fa-lock"></i>
				</div>
			</div>
			<div class="col-md-6 login-do">
				<label class="hvr-shutter-in-horizontal login-sub">
                    <asp:Button type="submit" value="login" OnClick="btn_loginClick" Text="Login" runat="server" />
					</label>
                    <br />
                    <br />
                    <asp:Label ID="lbl_error" CssClass="label label-danger" role="danger" runat="server"></asp:Label>
			</div>
			
			<div class="clearfix"> </div>
			</form>
		</div>
	</div>
		<!---->
<div class="copy-right">
            <p> &copy; 2016 M Hudya Ramadhana & Mutia Ayu Dianita. All Rights Reserved</p>	    </div>  
<!---->
<!--scrolling js-->
	<script src="assets/backend/js/jquery.nicescroll.js"></script>
	<script src="assets/backend/js/scripts.js"></script>
	<!--//scrolling js-->
</body>
</html>

