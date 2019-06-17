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
  <?php 
  session_start(); 
  if(isset($_SESSION['user_name'])) {
	  header('Location: ' . "homepage.php");
  }
  
  ?>
  
	<div class="row my-3">	
		<div class="col-md-8">
			<form action="login_process.php" method="POST">
				<div class="form-group">
					<label for="email">Name:</label>
					<input type="name" class="form-control" id="name" name="name">
				</div>
				<div class="form-group">
					<label for="pwd">Password:</label>
					<input type="password" class="form-control" name="pwd">
				</div>
	 
			  <button type="submit" class="btn btn-primary">Login</button>
			</form>
		</div>
	</div>
  </body>
 </html>