<!DOCTYPE html>
<html lang="en">

  <head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Shop Homepage - Start Bootstrap Template</title>

    <!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">

	<!-- jQuery library -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>

	<!-- Popper JS -->
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>

	<!-- Latest compiled JavaScript -->
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>

  </head>

  <body>
  
  <?php include "array.php"; ?>
  
	<!-- Grey with black text -->
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <ul class="navbar-nav">
  
  <?php 
	//for($i = 0; $i < 4; $i++) {    
	foreach($links as $lnk ) {
  ?>
    <li class="nav-item">
      <a class="nav-link" href="#"><?php echo $lnk ?></a>
    </li>
	<?php } ?>
  </ul>
</nav>

<div class="row my-3">
	<div class="col-md-4">
		<ul class="list-group">
		<?php foreach($categories as $cate) {    ?>
		  <li class="list-group-item"> <?php echo $cate ?></li>
		<?php } ?>
		</ul>
	</div>
	<div class="col-md-8">
		<div class="row">
		
			<?php for($i = 0; $i < count($list_profile); $i++ ) {   
				$profile = $list_profile[$i];
			?>
			
			<div class="col-md-4">
				<div class="card" >
				  <img style="width: 180px;margin-bottom: 0; height:100px" class="card-img-top " 
				  src="<?php echo $profile["img"]?>" 
				  alt="Card image">
				  <div class="card-body">
					<h4 class="card-title"><?php echo $profile["name"]?></h4>
					<p class="card-text"><?php echo $profile["des"]?></p>
					<a href="#" class="btn btn-primary">See Profile</a>
				  </div>
				</div>
			</div>
			
			<?php } ?>
			
		</div>
	</div>
</div>

  </body>
 </html>