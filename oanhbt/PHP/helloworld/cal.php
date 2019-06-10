<?php
	function add($number) {
		$f = 1;
		$s1 = 0; $s2 = 0; $s3 = 0; $s4 = 0;
		for($i = 1; $i <= $number; $i++) {
			$f *= $i;
			if($i %2 != 0) {
				$s1 += $i;
			} else {
				$s2 += $i;
			}
			$s4 += ($i * $i);
		}
		echo "$f <br/>";
		echo "$s2 <br/>";
		echo "$s2 <br/>";
		echo "$s3 <br/>";
		echo "$s4 <br/>";
	}
	
	function add_($a, $b) {
		return $a + $b;
	}	
?>