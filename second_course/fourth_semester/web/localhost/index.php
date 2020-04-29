<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Web</title>
	<style>
		.Da {
			color: blue;
		}

		.Net {
			color: red;
		}

		.X3 {
			text-decoration: underline;
			font-style: italic;
		}

		.A {
			color: green;
		}

		.Bl {
			padding: 8px;
			width: 38vh;
			border: solid 1px;
		}
	</style>
</head>
<body>
<form action="" method="post">
	<input type="file" name="input" id=""> <br>
	<select name="sort" id="">
		<option value="1"> в алфавитном порядке по фамилии</option>
		<option value="2"> сортировка по возрасту</option>
	</select> <br>
	<input type="submit" value="Send" name="send">
</form>
</body>
</html>

<?php
	$input = "";
	if( isset( $_POST[ 'input' ] ) ) {
		$input = file_get_contents( $_POST[ 'input' ] );
	}
	
	if( $_POST[ 'send' ] ) {
		
		preg_match( "/<table.*table>/s", $input, $table );
		preg_match( "/<div.*<\/div>/", $input, $header );
		$header = $header[ 0 ];
		$table = strip_tags( $table[ 0 ] );
		$table = preg_split( "/\n/", $table );
		$table = array_slice( $table, 2 );
		$table = array_slice( $table, 0, count( $table ) - 1 );
		
		$name = array();
		$surname = array();
		$patronymic = array();
		$date = array();
		$age = array();
		
		for( $i = 0; $i < count( $table ); $i++ ) {
			
			$table[ $i ] = preg_split( "/\s/", $table[ $i ], -1, PREG_SPLIT_NO_EMPTY );
			$table[ $i ][ 2 ] = preg_replace( '/[.|,|:]/', '', $table[ $i ][ 2 ] );
			array_push( $surname, $table[ $i ][ 0 ] );
			array_push( $name, $table[ $i ][ 1 ] );
			array_push( $patronymic, $table[ $i ][ 2 ] );
			array_push( $date, $table[ $i ][ 3 ] );
			$currentDate = new DateTime();
			$Diff = $currentDate->diff( new DateTime( $table[ $i ][ 3 ] ) );
			array_push( $age, $Diff->y );
		}
		
		if( $_POST[ 'sort' ] == 1 ) {
			array_multisort( $surname, $name, $patronymic, $date, $age );
		} else if( $_POST[ 'sort' ] == 2 ) {
			array_multisort( $age, $surname, $name, $patronymic, $date );
		}
		
		$output = "";
		for( $i = 0; $i < count( $name ); $i++ ) {
			$output .= "$surname $name $patronymic $date\n";
		}
		file_put_contents( 'output.txt', $output );
		
		echo "<h1>$header</h1>";
		
		for( $i = 0; $i < count( $name ); $i++ ) {
			echo "<p> <span style='color: blue'>$patronymic[$i] $name[$i]</span> <span style='color: red'> $surname[$i]</span> <span style='text-decoration: underline; font-style: italic'> $age[$i]</span> </p>";
		}
		
	}
?>



