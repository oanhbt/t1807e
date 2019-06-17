<?php session_start(); ?>
<html>
	<head>
	</head>
	<body>
		<form action="add.php" method="POST" enctype="multipart/form-data">
			Image ?
			<input type="file" name="photo" />
			<br/>
			name (*) ?
			<input type="text" name="name" required />
			<br/>
			Description ?
			<input type="text" name="des" />
			<br/>
			<input type="submit" value="Send" />
		</form>
	</body>
</html>
<?php
	if(isset($_POST["name"])) {
		$name = $_POST["name"];
		$des = $_POST["des"];
		
		$path = "";
		if(isset($_FILES['photo'])) {
			if(  $_FILES['photo']['error'] == 0  ) {
				//move sang thu muc upload
				$name_img = $_FILES['photo']['name'];				
				$tmp_name = $_FILES['photo']['tmp_name'];				
				$path = "upload\\".$name_img;
				move_uploaded_file($tmp_name, $path);				
			}
		}
		$a = array(
			"img" => $path, 
			"name" => $name, 
			"des" => $des);
		$ll = $_SESSION['ds_profile'];
		$ll[] = $a;
		$_SESSION['ds_profile'] = $ll;
	} 
?>