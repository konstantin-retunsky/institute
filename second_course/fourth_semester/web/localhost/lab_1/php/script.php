<?php
	
	
	//	require ( '../php/classes/Database.php' );
	
	////		Вариант 1. Справочник достопримечательностей города
	////		Разделитель полей |, разделитель строк #
	////		1.	Функция принимает параметры: имя пользователя и пароль. Производится подключение к базе данных.
	////        Функция возвращает сообщение «Подключение успешно» либо «Ошибка» в зависимости от результата подключения.
	////    2.	Функция принимает идентификатор достопримечательности, возвращает описание достопримечательности с иллюстрацией.
	////    3.	Функция принимает параметр: год,  возвращает описание достопримечательности, где этот год упоминается.
	
	function Connection ( $host, $user, $password, $database ) {
		return @mysqli_connect ( $host, $user, $password, $database )
			? "Подключение произошло успешно" : "Ошибка";
	}
	
	function SearchIndex ( $value, $user, $password ) {
		
		$mysqli = new mysqli( "localhost", $user, $password, "lab-1" );
		$res    = $mysqli -> query ( "SELECT * FROM `var-1`" );
		
		$row = $res -> fetch_all ();
		PrintPage ( $value, $row[ $value - 1 ] );
		
	}
	
	function SearchDate ( $value, $user, $password ) {
		
		$mysqli = new mysqli( "localhost", $user, $password, "lab-1" );
		$res    = $mysqli -> query ( "SELECT * FROM `var-1`" );
		
		$countRows = mysqli_num_rows ( $res );
		
		for ( $i = 0; $i < $countRows; $i++ ) {
			$row = mysqli_fetch_row ( $res );
			if ( preg_match ( '/' . $value . '/', $row[ 1 ] ) ) {
				PrintPage ( $i + 1, $row );
			}
		}
	}
	
	//	function SearchDatabase ( $value, $user, $password ) {
	//
	//		$mysqli = new mysqli( "localhost", $user, $password, "lab-1" );
	//		$res    = $mysqli -> query ( "SELECT * FROM `var-1`" );
	//
	//		if ( strlen ( $value ) > 2 ) {
	//
	//			$countRows = mysqli_num_rows ( $res ); // количество полученных строк
	//
	//			for ( $i = 0; $i < $countRows; $i++ ) {
	//				$row = mysqli_fetch_row ( $res );
	//				if ( preg_match ( '/' . $value . '/', $row[ 1 ] ) ) {
	//					PrintPage ( $i + 1, $row );
	//				}
	//			}
	//
	//		} else {
	//			$row = $res -> fetch_all ();
	//			PrintPage ( $value, $row[ $value - 1 ] );
	//		}
	//
	//	}
	
	function PrintPage ( $index, $array ) {
		echo '<div style="margin: auto; width: 800px; height: min-content;">';
		echo "<h1>" . $array[ 0 ] . "</h1>";
		echo "<p>" . $array[ 1 ] . "</p>";
		echo "<img src='../images/t0$index.jpg'>";
		echo "<br>";
		echo "<a href='../database.html'>Back</a>";
		echo "</div>";
	}
	
	
	$inputUser     = $_POST[ 'login' ];    // имя пользователя
	$inputPassword = $_POST[ 'password' ]; // пароль
	
	
	if ( isset( $_POST[ 'database_connection' ] ) ) {
		$connection = Connection ( "localhost", $inputUser, $inputPassword, "lab-1" );
		if ( $connection == 'Ошибка' ) {
			echo "<script>alert('" . $connection . "'); document.location.href = \"../index.html\";</script>";
		} else {
			setcookie ( "login", $inputUser );
			setcookie ( "password", $inputPassword );
			echo "<script>alert('" . $connection . "');document.location.href = \"../database.html\";</script>";
		}
		
	} else if ( isset( $_POST[ 'show_info' ] ) ) {
		$inputNum = $_POST[ 'input' ];
		
		$inputUser     = $_COOKIE[ 'login' ];
		$inputPassword = $_COOKIE[ 'password' ];
		
		if ( strlen ( $inputNum ) > 2 ) {
			SearchIndex ( $inputNum, $inputUser, $inputPassword );
		} else {
			SearchDate ( $inputNum, $inputUser, $inputPassword );
		}
//		SearchDatabase ( $inputNum, $inputUser, $inputPassword );
	}


?>
