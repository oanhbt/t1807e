<html>
	<head>
	</head>
	<body>
		<form action="form.php" method="POST">
			What's your name ?
			<input type="text" name="user" />
			<input type="submit" value="Send" />
		</form>
		
		
		<form action="form.php" method="POST">
			What's your number ?
			<input type="text" name="number" />
			<input type="submit" value="Send" />
		</form>
		
		
		<form action="upload.php" method="POST" enctype="multipart/form-data">
			What's your file ?
			<input type="file" name="photo" />
			<input type="submit" value="Send" />
		</form>
	</body>
</html>
<?php
	if(isset($_POST["user"])) {
		$name = $_POST["user"];
		echo "Hello ".$name ;
	} 
	
	if(isset($_POST["number"])) {
		$number = $_POST["number"];
		echo "This is: ".$number ;
		include_once "../helloworld/cal.php";
		add($number);
	} 
?>