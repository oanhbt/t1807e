<?php
	function getValue($key) {
		return $_POST[$key];
	}
	
	if(isset($_POST["number1"]) && isset($_POST["number2"])) {
		$number1 = getValue("number1");
		$number2 = getValue("number2");
		$operators = getValue("operator");		
		//var_dump($operator);		
		foreach($operators as $operator) {
			if($operator == "add") {
				$result = $number1 + $number2;
			} else if($operator == "sub") {
				$result = $number1 - $number2;
			} else if($operator == "div") {
				if($number2 != 0) {
					$result = $number1 / $number2;
				}
			} else if($operator == "mul") {
				$result = $number1 * $number2;
			}
			
			echo "$number1 $operator $number2 : $result";
			echo "<br/>";
		}
	} 
?>