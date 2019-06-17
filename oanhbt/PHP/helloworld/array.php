<?php
	//session_start();
	
	$links = array("Home", "About", "Contact us", "Feedback", "Product");
	$categories = array("laptop", "Tivi", "PC");
	
	if(isset($_SESSION['ds_profile'])) {
		$list_profile = $_SESSION['ds_profile'];
	} else {
		$list_profile = array(
			array(
				"img" => "https://www.w3schools.com/bootstrap4/img_avatar1.png",
				"name" => "Bui Oanh",
				"des" => "Some example text."
			),
			array(
				"img" => "https://www.w3schools.com/bootstrap4/img_avatar2.png",
				"name" => "Bui Oanh 2",
				"des" => "asfsaf."
			),
			array(
				"img" => "https://www.w3schools.com/bootstrap4/img_avatar3.png",
				"name" => "Bui Oanh 3",
				"des" => "fe6rtytry."
			),
			array(
				"img" => "https://www.w3schools.com/bootstrap4/img_avatar4.png",
				"name" => "Bui Oanh 4",
				"des" => "dt dtd ."
			)	
		);
		$_SESSION['ds_profile'] = $list_profile;
	}
	
?>