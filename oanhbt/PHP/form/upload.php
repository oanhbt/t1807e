<?php
	//var_dump($_FILES);
	$path = "";
	if(isset($_FILES['photo'])) {
		if(  $_FILES['photo']['error'] == 0  ) {
			//move sang thu muc upload
			$name = $_FILES['photo']['name'];
			
			$arr = explode(".", $name);
			$ext = $arr[count($arr) - 1];
			
			$tmp_name = $_FILES['photo']['tmp_name'];
			
			$path = "upload\\Oanh.".$ext;
			move_uploaded_file($tmp_name, $path);
			
		}
	}
	
	//echo "<img src='$path' />";
	echo dirname(__FILE__)."\\".$path;
?>