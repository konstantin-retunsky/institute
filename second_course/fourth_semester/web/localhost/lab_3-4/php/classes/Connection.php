<?php
	
	class Connection {
		private $localhost;
		private $login;
		private $password;
		private $database;
		public  $link;
		
		function __construct() {
			$this->SetConnectDatabase();
			$this->link = mysqli_connect( "localhost", "bogeyman", "qwerty", "lab-3" )
			or die( "Ошибка " . mysqli_error( $this->link ) );
		}
		
		public function SetConnectDatabase(
			$localhost = "localhost", $login = "bogeyman",
			$password = "qwerty", $database = "lab-3"
		) {
			$this->localhost = $localhost;
			$this->login = $login;
			$this->password = $password;
			$this->database = $database;
		}
		
		public function GetConnectDatabase() {
			return $this->localhost . $this->login . $this->password . $this->database;
		}
		
		public function SignUp( $login, $password, $email ) {
			$query = "INSERT INTO users VALUES('$login', '$password','$email')";
			mysqli_query( $this->link, $query ) or die( "Ошибка " . mysqli_error( $this->link ) );
			return true;
		}
		
		public function LoginIn( $login, $password ) {
			$query = $this->link->query(
				"SELECT username, password FROM `users` where username = '$login' and password = '$password'"
			);
			$search_user = mysqli_fetch_row( $query );
			return $search_user[ 0 ] == $login & $search_user[ 1 ] == $password
				? true
				: false;
		}
	}

?>