<html>
	<head>
	</head>
	<body>		
		<a href="tinhtoan_.php?number1=3&number2=10">click me</a>
		
		<form action="tinhtoan_.php" method="POST">
			Number 1:
			<input type="text" name="number1" />
			<br/>
			Number 2:
			<input type="text" name="number2" />
			<br/>
			Operator: 
			<!--<select name="operator">
				<option value="add">Add</option>
				<option value="sub">Sub</option>
				<option value="div">Div</option>
				<option value="mul">Mul</option>
			</select>-->
			
			<input type="checkbox" name="operator[]" value="add"/>Add
			<input type="checkbox" name="operator[]" value="sub"/>Sub
			<input type="checkbox" name="operator[]" value="div"/>Div
			<input type="checkbox" name="operator[]" value="mul"/>Mul
			<br/>
			<input type="submit" value="Send" />
		</form>
	</body>
</html>
