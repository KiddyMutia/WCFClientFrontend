﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerhome.aspx.cs" Inherits="Rent_HouseWeb.customerhome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<title>My Kost | Home</title>
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
<!-- Mainly scripts -->
<script src="assets/backend/js/jquery.metisMenu.js"></script>
<script src="assets/backend/js/jquery.slimscroll.min.js"></script>
<!-- Custom and plugin javascript -->
<link href="assets/backend/css/custom.css" rel="stylesheet">
<script src="assets/backend/js/custom.js"></script>
<script src="assets/backend/js/screenfull.js"></script>
<!--data tables-->
        <link rel="stylesheet" type="text/css" href="assets/backend/css/jquery.dataTables.css">
        <link rel="stylesheet" type="text/css" href="assets/backend/css/dataTables.bootstrap.css">
        <script type="text/javascript" src="assets/backend/js/jquery.js"></script>
        <script type="text/javascript" src="assets/backend/js/jquery.dataTables.js"></script>
<!--skycons-icons-->
<script src="assets/backend/js/skycons.js"></script>
<!--//skycons-icons-->
</head>
<body>
<div id="wrapper">

<!----->
        <nav class="navbar-default navbar-static-top" role="navigation">
             <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
               <h1> <a class="navbar-brand" href="customerhome.aspx">Rent House</a></h1>         
			   </div>
			 <div class=" border-bottom">
        	<div class="full-left">
        	  <section class="full-top">
				<button id="toggle"><i class="fa fa-arrows-alt"></i></button>	
			</section>
            <div class="clearfix"> </div>
           </div>
     
       
            <!-- Brand and toggle get grouped for better mobile display -->
		 
		   <!-- Collect the nav links, forms, and other content for toggling -->
		    <div class="drop-men" >
		        <ul class=" nav_1">
					<li class="dropdown">
		              <a href="#" class="dropdown-toggle dropdown-at" data-toggle="dropdown"><span class=" name-caret">Hello, <asp:Label ID="customer_name2" runat="server"></asp:Label></span><img src="assets/backend/images/admin2.png"></a>
		              </ul>
		            </li>
		           
		        </ul>
		     </div><!-- /.navbar-collapse -->
			<div class="clearfix">
       
     </div>
	  
		    <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                <ul class="nav" id="side-menu">
				
                    <li>
                        <a href="customerhome.aspx" class=" hvr-bounce-to-right"><i class="fa fa-dashboard nav_icon "></i><span class="nav-label">Dashboard</span> </a>
                    </li>
                   
                    <li>
                        <a href="customer_listroom.aspx" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Reservation</span><span class="fa arrow"></span></a>
                    </li>
                    <li>
                        <a href="customer_list_transaction.aspx" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Transaction List</span><span class="fa arrow"></span></a>
                    </li>
                   
                </ul>
            </div>
			</div>
        </nav>
        <div id="page-wrapper" class="gray-bg dashbard-1">
       <div class="content-main">
 
  		<!--banner-->	
		    <div class="banner">
		   
				<h2>
				<a href="adminhome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Dashboard</span>
				</h2>
		    </div>
		<!--//banner-->
		<!--content-->
		<div class="content-top">
			
			
			<div class="col-md-12 ">
				<div class="content-top-1">
				
					<div class="table-responsive">
                        <form id="Form1" runat="server">
                            <p>Hello, <asp:Label ID="customer_name" runat="server"></asp:Label> Welcome Back ! If you want to logout, click button below</p>
                            <br />
                            <asp:Button ID="Button1" CssClass="btn btn-sm btn-danger" Text="Logout" OnClick="btn_logoutClick" runat="server" />
                        </form>
                    </div>
				
				</div>
				<div class="clearfix"> </div>
			</div>
			
		<div class="clearfix"> </div>
		</div>
		<!---->
	
  
		
		<!----->
		
		<!--//content-->


	 
		<!---->
<div class="copy">
            <p> &copy; 2016 Mutia And Hudya. All Rights Reserved</p>
	    </div>
		</div>
		<div class="clearfix"> </div>
       </div>
     </div>
<!---->
<!--scrolling js-->
	<script src="assets/backend/js/jquery.nicescroll.js"></script>
	<script src="assets/backend/js/scripts.js"></script>
	<!--//scrolling js-->
	<script src="assets/backend/js/bootstrap.min.js"> </script>
     <script type="text/javascript">
         $(document).ready(function () {
             $('.data').DataTable();
         });
        </script>
</body>
</html>


