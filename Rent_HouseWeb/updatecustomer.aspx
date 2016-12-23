<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatecustomer.aspx.cs" Inherits="Rent_HouseWeb.updatecustomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<title>Rent House Admin Panel | Home</title>
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
		<script>
		    $(function () {
		        $('#supported').text('Supported/allowed: ' + !!screenfull.enabled);

		        if (!screenfull.enabled) {
		            return false;
		        }



		        $('#toggle').click(function () {
		            screenfull.toggle($('#container')[0]);
		        });



		    });
		</script>

<!----->

<!--pie-chart--->
<script src="assets/backend/js/pie-chart.js" type="text/javascript"></script>
 <script type="text/javascript">

     $(document).ready(function () {
         $('#demo-pie-1').pieChart({
             barColor: '#3bb2d0',
             trackColor: '#eee',
             lineCap: 'round',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });

         $('#demo-pie-2').pieChart({
             barColor: '#fbb03b',
             trackColor: '#eee',
             lineCap: 'butt',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });

         $('#demo-pie-3').pieChart({
             barColor: '#ed6498',
             trackColor: '#eee',
             lineCap: 'square',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });


     });

    </script>
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
               <h1> <a class="navbar-brand" href="adminhome.aspx">Rent House</a></h1>         
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
		              <a href="#" class="dropdown-toggle dropdown-at" data-toggle="dropdown"><span class=" name-caret">Hello, <asp:Label ID="lbl_name" runat="server"></asp:Label></span><img src="assets/backend/images/admin2.png"></a>
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
                        <a href="adminhome.aspx" class=" hvr-bounce-to-right"><i class="fa fa-dashboard nav_icon "></i><span class="nav-label">Dashboards</span> </a>
                    </li>
                   
                    <li>
                        <a href="#" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Customer</span><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li><a href="addcustomer.aspx" class=" hvr-bounce-to-right"> <i class="fa fa-area-chart nav_icon"></i>Add Customer</a></li>
                            <li><a href="customerlist.aspx" class=" hvr-bounce-to-right"><i class="fa fa-map-marker nav_icon"></i>Customer List</a></li>
					   </ul>
                    </li>
					<li>
                        <a href="#" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Room</span><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li><a href="addroom.aspx" class=" hvr-bounce-to-right"><i class="fa fa-map-marker nav_icon"></i>Add Room</a></li>
							<li><a href="roomlist.aspx" class=" hvr-bounce-to-right"><i class="fa fa-file-text-o nav_icon"></i>Room List</a></li>
					   </ul>
                    </li>
					<li>
                        <a href="#" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Room Type</span><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li><a href="addroomtype.aspx" class=" hvr-bounce-to-right"> <i class="fa fa-area-chart nav_icon"></i>Add Room Type</a></li>
                            <li><a href="roomtypelist.aspx" class=" hvr-bounce-to-right"><i class="fa fa-map-marker nav_icon"></i>Room Type List</a></li>
					   </ul>
                    </li>
					<li>
                        <a href="#" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Transaction</span><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li><a href="rentin.aspx" class=" hvr-bounce-to-right"> <i class="fa fa-area-chart nav_icon"></i>Rent In</a></li>
							<li><a href="transactionlist.aspx" class=" hvr-bounce-to-right"><i class="fa fa-map-marker nav_icon"></i>Transaction List</a></li>
					   </ul>
                    </li>
					<li>
                        <a href="#" class=" hvr-bounce-to-right"><i class="fa fa-indent nav_icon"></i> <span class="nav-label">Monthly Paid</span><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li><a href="addmonthlypaid.aspx" class=" hvr-bounce-to-right"> <i class="fa fa-area-chart nav_icon"></i>Add Monthly Paid</a></li>
                            <li><a href="monthlypaidlist.aspx" class=" hvr-bounce-to-right"><i class="fa fa-map-marker nav_icon"></i>Transaction List</a></li>
					   </ul>
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
				<a href="index.html">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Dashboard</span>
				</h2>
		    </div>
		<!--//banner-->
		<!--content-->
		<div class="content-top">
			
			
			<div class="col-md-12 ">
				
				
					<div class="grid-form1">
                        <h3 id="forms-horizontal">Horizontal form</h3>
                        <form id="Form1" class="form-horizontal" runat="server">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-2 control-label hor-form">ID Customer</label>
                            <div class="col-sm-10">
                              <asp:TextBox disabled type="text" CssClass="form-control" ID="tb_id" placeholder="Name of Customer" runat="server"></asp:TextBox>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="inputEmail3" class="col-sm-2 control-label hor-form">Name</label>
                            <div class="col-sm-10">
                              <asp:TextBox type="text" CssClass="form-control" ID="tb_name" placeholder="Name of Customer" runat="server"></asp:TextBox>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="inputPassword3" class="col-sm-2 control-label hor-form">Card Type</label>
                            <div class="col-sm-10">
                              <asp:DropDownList type="text" CssClass="form-control" ID="cb_type" placeholder="Name of Customer" runat="server">
                                <asp:ListItem Value="KTP" Text="KTP"></asp:ListItem>
                                <asp:ListItem Value="KTM" Text="KTM"></asp:ListItem>
                              </asp:DropDownList>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="inputEmail3" class="col-sm-2 control-label hor-form">Card Number</label>
                            <div class="col-sm-10">
                              <asp:TextBox type="text" CssClass="form-control" ID="tb_number" placeholder="Number of Card" runat="server"></asp:TextBox>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="inputEmail3" class="col-sm-2 control-label hor-form">Phone Number</label>
                            <div class="col-sm-10">
                              <asp:TextBox type="text" CssClass="form-control" ID="tb_phone" placeholder="Phone Number" runat="server"></asp:TextBox>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="inputEmail3" class="col-sm-2 control-label hor-form">Address</label>
                            <div class="col-sm-10">
                              <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="tb_address" placeholder="Address" runat="server"></asp:TextBox>
                            </div>
                          </div>
                        <hr />
                          <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                              <asp:Button ID="Button1" CssClass="btn btn-default" Text="Save" OnClick="btn_saveClick" runat="server" />
                            </div>
                          </div>
                        </form>
                     </div>
				</div>
				<div class="clearfix"> </div>
			
			
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

