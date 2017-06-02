<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Rent_HouseWeb.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0">
    <meta name="description" content="Flatfy Free Flat and Responsive HTML5 Template ">
    <meta name="author" content="">

    <title>Rent House</title>

    <!-- Bootstrap core CSS -->
    <link href="assets/frontend/css/bootstrap.min.css" rel="stylesheet">
 
    <!-- Custom Google Web Font -->
    <link href="assets/frontend/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,100italic,300italic,400italic,700italic,900italic' rel='stylesheet' type='text/css'>
	<link href='http://fonts.googleapis.com/css?family=Arvo:400,700' rel='stylesheet' type='text/css'>
	
    <!-- Custom CSS-->
    <link href="assets/frontend/css/general.css" rel="stylesheet">
	
	 <!-- Owl-Carousel -->
    <link href="assets/frontend/css/custom.css" rel="stylesheet">
	<link href="assets/frontend/css/owl.carousel.css" rel="stylesheet">
    <link href="assets/frontend/css/owl.theme.css" rel="stylesheet">
	<link href="assets/frontend/css/style.css" rel="stylesheet">
	<link href="assets/frontend/css/animate.css" rel="stylesheet">
	
	<!-- Magnific Popup core CSS file -->
	<link rel="stylesheet" href="assets/frontend/css/magnific-popup.css"> 
	
	<script src="assets/frontend/js/modernizr-2.8.3.min.js"></script>  <!-- Modernizr /-->
	<!--[if IE 9]>
		<script src="js/PIE_IE9.js"></script>
	<![endif]-->
	<!--[if lt IE 9]>
		<script src="js/PIE_IE678.js"></script>
	<![endif]-->

	<!--[if lt IE 9]>
		<script src="js/html5shiv.js"></script>
	<![endif]-->

</head>

<body id="home">

	<!-- Preloader -->
	<div id="preloader">
		<div id="status"></div>
	</div>
	
	<!-- FullScreen -->
    <div class="intro-header">
		<div class="col-xs-12 text-center abcen1">
			<h1 class="h1_home wow fadeIn" data-wow-delay="0.4s">Rent House</h1>
			<h3 class="h3_home wow fadeIn" data-wow-delay="0.6s">Feel Like Home</h3>
			<ul class="list-inline intro-social-buttons">
				<!--<li><a href="#login" class="btn  btn-lg mybutton_cyano wow fadeIn" data-wow-delay="0.8s"><span class="network-name">Admin Login</span></a>
				</li>
				 <li id="download" ><a href="#downloadlink" class="btn  btn-lg mybutton_standard wow swing wow fadeIn" data-wow-delay="1.2s"><span class="network-name">Sign In</span></a>
				</li>-->
			</ul>
		</div>    
        <!-- /.container -->
		<div class="col-xs-12 text-center abcen wow fadeIn">
			<div class="button_down "> 
				<a class="imgcircle wow bounceInUp" data-wow-duration="1.5s"  href="#whyus"> <img class="img_scroll" src="assets/frontend/img/icon/circle.png" alt=""> </a>
			</div>
		</div>
    </div>
	
	<!-- NavBar-->
	<nav class="navbar-default" role="navigation">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="#home">Rent House</a>
			</div>

			<div class="collapse navbar-collapse navbar-right navbar-ex1-collapse">
				<ul class="nav navbar-nav">
					
					<li class="menuItem"><a href="#whyus">Why Choose Us?</a></li>
					<li class="menuItem"><a href="#renthouse">Rent House</a></li>
					<li class="menuItem"><a href="#facilities">Facility</a></li>
					<li class="menuItem"><a href="#type">Type Room</a></li>
					<li class="menuItem"><a href="#available">Available Room</a></li>
					<!--<li class="menuItem"><a href="#login">Admin Login</a></li>-->
					<li class="menuItem"><a href="#contact">Contact</a></li>
				</ul>
			</div>
		   
		</div>
	</nav> 
	
	<!-- What is -->
	<div id="whyus" class="content-section-b" style="border-top: 0">
		<div class="container">

			<div class="col-md-6 col-md-offset-3 text-center wrap_title">
				<h2>Why Choose Us?</h2>
				<p class="lead" style="margin-top:0">Rent House - Feel Like Home</p>
				
			</div>
			
			<div class="row">
			
				
				<div class="col-sm-4 wow fadeInDown text-center">
				  <img  class="rotate" src="assets/frontend/img/icon/trusted.png" alt="Generic placeholder image">
				   <h3>Trusted</h3>
					<p class="lead">Our Rent House is Trusted by many customer because we have good services, facilities and security </p>
				  <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
				</div><!-- /.col-lg-4 -->
			
			
				<div class="col-sm-4  wow fadeInDown text-center">
				  <img class="rotate" src="assets/frontend/img/icon/rate.png" alt="Generic placeholder image">
				  <h3>Facilites</h3>
				  <p class="lead">We have all the facilities that customer need like 24 hours wifi, clean shared kitchen, and wide parking area</p>
				 <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
				</div><!-- /.col-lg-4 -->
				
				<div class="col-sm-4 wow fadeInDown text-center">
				  <img  class="rotate" src="assets/frontend/img/icon/location.png" alt="Generic placeholder image">
				   <h3>Strategic Location</h3>
				   <p class="lead"> Our location near University of Indonesia, Margonda Road, Restaurants and Public Facility </p>
				   <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
				</div><!-- /.col-lg-4 -->
				
			</div><!-- /.row -->
		</div>
	</div>
	
	<!-- Use it -->
    <div id ="renthouse" class="content-section-a">

        <div class="container">
			
            <div class="row">
			
				<div class="col-sm-6 pull-right wow fadeInRightBig">
                    <img class="img-responsive " src="assets/frontend/img/kost.jpg" alt="">
                </div>
				
                <div class="col-sm-6 wow fadeInLeftBig"  data-animation-delay="200">   
                    <h3 class="section-heading">Rent House</h3>
					<div class="sub-title lead3">Feel Like Home</div>
                    <p class="lead">
						Rent House is a rent house that makes the customer feels like home when they stay in rent house. 
						We have so many facilities that support all of customer's need. If you want to rent, you can visit us in this address. Please, click this visit button!
					</p>

					 <p>
					 <a class="btn btn-embossed btn-info" href="#contact" role="button">Visit Us</a></p>
				</div>   
            </div>
        </div>
        <!-- /.container -->
    </div>

    <div id="facilities" class="content-section-b"> 
		
		<div class="container">
            <div class="row">
                <div class="col-sm-6 wow fadeInLeftBig">
                     <div id="owl-demo-1" class="owl-carousel">
						<a href="assets/frontend/img/f1.jpg" class="image-link">
							<div class="item">
								<img  class="img-responsive img-rounded" src="assets/frontend/img/f1.jpg" alt="">
							</div>
						</a>
						<a href="assets/frontend/img/f2.jpg" class="image-link">
							<div class="item">
								<img  class="img-responsive img-rounded" src="assets/frontend/img/f2.jpg" alt="">
							</div>
						</a>
						<a href="assets/frontend/img/f3.jpg" class="image-link">
							<div class="item">
								<img  class="img-responsive img-rounded" src="assets/frontend/img/f3.jpg" alt="">
							</div>
						</a>
					</div>       
                </div>
				
                <div class="col-sm-6 wow fadeInRightBig"  data-animation-delay="200">   
                    <h3 class="section-heading">Facilities</h3>
					<div class="sub-title lead3">Facilities of Our Rent House</div>
                    <p class="lead">
						We have all the facilities that customer need like 24 hours wifi, clean shared kitchen, and wide parking area
					</p>
				</div>  			
			</div>
        </div>
    </div>
  

	<!-- Screenshot -->
	<div id="type" class="content-section-b">
        <div class="container">
          <div class="row" >
			 <div class="col-md-6 col-md-offset-3 text-center wrap_title ">
				<h2>Galery Type Room</h2>
				<p class="lead" style="margin-top:0">This is galery of our room type</p>
			 </div>
		  </div>
		    <div class="row wow bounceInUp" >
              <div id="owl-demo" class="owl-carousel">
				
				<a href="assets/frontend/img/slide/1.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Dalam, Non Tempat Tidur, AC </h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/1.png" alt="Owl Image">
					</div>
				</a>
				
               <a href="assets/frontend/img/slide/2.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Dalam, Tempat Tidur, AC</h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/2.png" alt="Owl Image">
					</div>
				</a>
				
				<a href="assets/frontend/img/slide/3.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Luar, Tempat Tidur, AC</h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/3.png" alt="Owl Image">
					</div>
				</a>
				
				<a href="assets/frontend/img/slide/1.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Dalam, Tempat Tidur, Non AC</h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/4.png" alt="Owl Image">
					</div>
				</a>
				
               <a href="assets/frontend/img/slide/2.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Luar, Non Tempat Tidur, Non AC</h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/5.png" alt="Owl Image">
					</div>
				</a>
				
				<a href="assets/frontend/img/slide/3.png" class="image-link">
					<div class="item">
						<h5>Kamar Mandi Di Luar</h5><img  class="img-responsive img-rounded" src="assets/frontend/img/slide/6.png" alt="Owl Image">
					</div>
				</a>
              </div>       
          </div>
        </div>


	</div>
	<div id="available" class="content-section-a">
		<div class="container">
			<div class="row">
			
			<div class="col-md-6 col-md-offset-3 text-center wrap_title">
				<h2>Available Room List</h2>
				<p class="lead" style="margin-top:0">This is the table of the available room</p>
			 </div>
			 <div class="col-md-12">
				    <div class="table-responsive">
                        <table class='table table-bordered data' id='data'>
                            <thead>
                            <h4 class="text-center wrap_title">Data Room Type </h4>  
                                <tr>  
                                    <th>Type</th> 
                                    <th>Total</th> 
                                </tr>  
                            </thead>  
                            <tbody runat="server" id="placeHolder">
                                
                            </tbody>
                           </table>
                    </div>
			 </div>
		  </div>
          <div class="row">
			
			<div class="col-md-6 col-md-offset-3 text-center wrap_title">
				<h2>Latest News</h2>
				<p class="lead" style="margin-top:0">News from the My Kost</p>
			 </div>
			 <div class="col-md-12">
				    <div class="row" runat="server" id="placeHolderBerita">
                    <!-- start -->
                   <asp:PlaceHolder runat="server" ID="placeHolderr"></asp:PlaceHolder>
                      <!--<div class="col-sm-6 col-md-4">
                        <div class="thumbnail">
                          <img src="..." alt="...">
                          <div class="caption">
                            <h3>Thumbnail label</h3>
                            <p>...</p>
                            <p><a href="#" class="btn btn-primary" role="button">Button</a> <a href="#" class="btn btn-default" role="button">Button</a></p>
                          </div>
                        </div>
                      </div>-->
                      <!-- sini -->
                    </div>
			 </div>
		  </div>
		  
		</div>
	</div>

    
    
<div id="login" class="content-section-c ">
		<div class="container">
			<div class="row">
			
			<div class="col-md-6 col-md-offset-3 text-center">
				<div class="mockup-content">
                      <a href="login_customer.aspx" class="btn-lg btn-info button">Login for reservation</a>
                      <hr>
                      <a href="register.aspx" class="btn-lg btn-danger button">Don't have account ? Register Here !</a>
				</div>
			</div>	
			</div>
		</div>
	</div>	
	

	
	<!-- Contact -->
	<div id="contact" class="content-section-a">
		<div class="container">
			<div class="row">
			
			<div class="col-md-6 col-md-offset-3 text-center wrap_title">
				<h2>Contact Us</h2>
				<p class="lead" style="margin-top:0">Rent House</p>
			</div>
			
			<!--<form role="form" action="" method="post" >
				<div class="col-md-6">
					<div class="form-group">
						<label for="InputName">Your Name</label>
						<div class="input-group">
							<input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>
							<span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
						</div>
					</div>
					
					<div class="form-group">
						<label for="InputEmail">Your Email</label>
						<div class="input-group">
							<input type="email" class="form-control" id="InputEmail" name="InputEmail" placeholder="Enter Email" required  >
							<span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
						</div>
					</div>
					
					<div class="form-group">
						<label for="InputMessage">Message</label>
						<div class="input-group">
							<textarea name="InputMessage" id="InputMessage" class="form-control" rows="5" required></textarea>
							<span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
						</div>
					</div>

					<input type="submit" name="submit" id="submit" value="Submit" class="btn wow tada btn-embossed btn-primary pull-right">
				</div>
			</form>-->
			
			<hr class="featurette-divider hidden-lg">
				<div class="col-md-5 col-md-push-1 address">
					<address>
					<h3>Rent House Location</h3>
					<p class="lead"><a href="https://www.google.com/maps/preview?ie=UTF-8&q=The+Pentagon&fb=1&gl=us&hq=1400+Defense+Pentagon+Washington,+DC+20301-1400&cid=12647181945379443503&ei=qmYfU4H8LoL2oATa0IHIBg&ved=0CKwBEPwSMAo&safe=on">Jl. H. Amat No. 20 <br>
					Kukusan Teknik</a><br>
					Depok, West Java<br>
					Phone: 021-7655123</p>
					</address>

                    <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d1528.8165726027642!2d106.81997738963952!3d-6.360436225386488!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sid!4v1482903194143" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>

					<!--<h3>Social</h3>
					<li class="social"> 
					<a href="#"><i class="fa fa-facebook-square fa-size"> </i></a>
					<a href="#"><i class="fa  fa-twitter-square fa-size"> </i> </a> 
					<a href="#"><i class="fa fa-google-plus-square fa-size"> </i></a>
					<a href="#"><i class="fa fa-flickr fa-size"> </i> </a>
					</li>-->
				</div>
			</div>
		</div>
	</div>
	
	
	
    <footer>
      <div class="container">
          <div class="col-md-12">
          <div class="col-md-10">
          <br>
           CopyRight @2016 Rent House. M. Hudya Ramadhana & Mutia Ayu Dianita
           <br>
           <br>
	   </div>
       <div class="col-md-2">
       <br>
       <a href="Login.aspx">| Admin Login</a>
       </div>
          </div> <!-- /col-xs-7 -->

        </div>
    </footer>

    <!-- JavaScript -->
    <script src="assets/frontend/js/jquery-1.10.2.js"></script>
    <script src="assets/frontend/js/bootstrap.js"></script>
	<script src="assets/frontend/js/owl.carousel.js"></script>
	<script src="assets/frontend/js/script.js"></script>
	<!-- StikyMenu -->
	<script src="assets/frontend/js/stickUp.min.js"></script>
	<script type="text/javascript">
	    jQuery(function ($) {
	        $(document).ready(function () {
	            $('.navbar-default').stickUp();

	        });
	    });
	
	</script>
	<!-- Smoothscroll -->
	<script type="text/javascript" src="assets/frontend/js/jquery.corner.js"></script> 
	<script src="assets/frontend/js/wow.min.js"></script>
	<script>
	    new WOW().init();
	</script>
	<script src="assets/frontend/js/classie.js"></script>
	<script src="assets/frontend/js/uiMorphingButton_inflow.js"></script>
	<!-- Magnific Popup core JS file -->
	<script src="assets/frontend/js/jquery.magnific-popup.js"></script> 
</body>

</html>

