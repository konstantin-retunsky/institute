

<?php
	
	
	Class Database {
		
		////		Вариант 1. Справочник достопримечательностей города
		////		Разделитель полей |, разделитель строк #
		////		1.	Функция принимает параметры: имя пользователя и пароль. Производится подключение к базе данных.
		////        Функция возвращает сообщение «Подключение успешно» либо «Ошибка» в зависимости от результата подключения.
		////    2.	Функция принимает идентификатор достопримечательности, возвращает описание достопримечательности с иллюстрацией.
		////    3.	Функция принимает параметр: год,  возвращает описание достопримечательности, где этот год упоминается.
		
		public $user;
		public $password;
		public $host;
		public $database;
		
		function __construct ( $user = null, $password = null, $host = 'localhost', $database = 'lab-1' ) {
			$this -> user     = $user;
			$this -> password = $password;
			$this -> host     = $host;
			$this -> database = $database;
		}
		
		public function Connection () {
			return @mysqli_connect ( $this -> host, $this -> user, $this -> password, $this -> database )
				? "Подключение произошло успешно" : "Ошибка";
		}
		
		public function SearchDatabase ( $value ) {
			
			$mysqli = new mysqli( "localhost", $this -> user, $this -> password, "lab-1" );
			$res    = $mysqli -> query ( "SELECT * FROM `var-1`" );
			
			if ( strlen ( $value ) > 2 ) {
				
				$countRows = mysqli_num_rows ( $res ); // количество полученных строк
				
				for ( $i = 0; $i < $countRows; $i++ ) {
					$row = mysqli_fetch_row ( $res );
					if ( preg_match ( '/' . $value . '/', $row[ 1 ] ) ) {
						Database ::PrintPage ( $i + 1, $row );
					}
				}
				
			} else {
				$row = $res -> fetch_all ();
				Database ::PrintPage ( $value, $row[ $value - 1] );
			}
			
		}
		
		private static function PrintPage ( $index, $array ) {
			echo '<div style="margin: auto; width: 800px; height: min-content;">';
			echo "<h1>" . $array[ 0 ] . "</h1>";
			echo "<p>" . $array[ 1 ] . "</p>";
			echo "<img src='../images/t0$index.jpg'>";
			echo "<br>";
			echo "<a href='../database.html'>Back</a>";
			echo "</div>";
		}
		
	}

?>

