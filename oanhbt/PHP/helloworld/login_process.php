<?php
	session_start();
	$name = $_POST['name'];
	$pwd = $_POST['pwd'];
		
	if($name == "admin" && $pwd == "admin") {
		$_SESSION['user_name'] = $name;
		header('Location: ' . "homepage.php");
	} else {
		header('Location: ' . "login.php?msg='Mời nhập lại.'");
	}
?>