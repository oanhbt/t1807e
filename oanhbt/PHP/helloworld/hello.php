<html>
	<head>
		<style>
			p {
				color: red;
			}		
			div {
				border: 1px solid black;
				padding: 10px;
			}
		</style>
	</head>
	<body>
		<p>
			<?php echo "Hello Oanh"; ?>
		</p>
		<hr/>
		<div>
		<?php
			$username = 'I\'m Oanh'; 
			echo "Wellcome $username";
			echo "<br/>";
			echo 'Wellcome $username '.$username." ....";
			
			$number1 = 10;
			$number2 = 20;
			$total = $number1 + $number2;
			echo "<br/>";
			echo "Kết quả phép cộng của $number1 và $number2 là $total";
			
			echo "<br/>";
			
			echo "this is ".__LINE__." file:".__FILE__;
			
			if($total < 10) {
				//0 -> 9
			} else if($total >= 10 && $total <= 20) {
				//10->20
			} else {
				//20->
			}
			echo "<br/>";
			$count = 1;
			for(; $count < 10;  ) {
				echo "$count";
				$count++;
			}
			echo "<br/>";
		?>
		<?php
			include "cal.php";
			if(function_exists("add")) {
				add(10);
				echo "<br/>";
				
				$x = add_(10, 20);
				echo "$x";
			} else {
				echo "Ham add ko ton tai.";
			}
		?>
		</div>
	</body>
</html>