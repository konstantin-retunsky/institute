<?php

	//connection------------------------------------------------------------------------------------------
	
//	require_once( "classes/Connection.php" );
//	$input_get = isset( $_GET[ 'connection' ] ) ? json_decode( $_GET[ 'connection' ] ) : null;
//	$connection = new Connection();
//
//	echo $input_get->email == null ?
//		$connection->LoginIn( $input_get->login, $input_get->password ) :
//		$connection->SignUp( $input_get->login, $input_get->password, $input_get->email );
//
//	if( $input_get->email != null ) {
//		mkdir( "../database/users/$input_get->login" );
//		copy( "../database/users/unregistered/basket_information.json", "../database/users/$input_get->login/basket_information.json" );
//	}
	
	//	print_r(true);
//	if( isset( $_GET[ "connection" ] ) ) {
//		echo $connection->SignUp('');
//	} else if( $_GET[ "login_in" ] ) {
//		echo $connection->LoginIn();
//	}

//	$link = mysqli_connect( "localhost", "bogeyman", "qwerty", "lab-3" )
//	or die( "Ошибка " . mysqli_error( $link ) );
//
//	if( isset( $_GET[ "sign_up" ] ) ) {
//
//		$sign_up = json_decode($_GET[ "sign_up" ]);
//
//		$query = "INSERT INTO users VALUES('" . $sign_up->login . "', '" . $sign_up->password . "','" . $sign_up->email . "')";
//		$result = mysqli_query( $link, $query ) or die( "Ошибка " . mysqli_error( $link ) );
//		mysqli_close( $link );
//
//		echo "true";
//
//	} else if( isset( $_GET[ "login_in" ] ) ) {
//
//
//		$login_in = json_decode( $_GET[ 'login_in' ] );
//
//		$link = mysqli_connect( "localhost", "bogeyman", "qwerty", "lab-3" );
//		$select_table = $link->query( "SELECT username, password FROM `users` where username = '" . $login_in->login . "'" );
//		$login_pass = mysqli_fetch_row( $select_table );
//		if(
//			mysqli_num_rows( $select_table ) == 1 &
//			$login_pass[ 0 ] == $login_in->login
//		) {
//			echo "true";
//		} else {
//			echo "false";
//		}
//
//		mysqli_close( $link );
//	}
//	$basket_information = file_get_contents( '../database/basket_information.json' );
//	$basket_information = json_decode( $basket_information );
//	var_dump($basket_information->checked_click[0]);
//	for( $row_index = 0; $row_index < 17; $row_index++ ) {
//		echo $basket_information->checked_click[$row_index] . "<br>";
//	}//	var_dump($_COOKIE);
//		$link = mysqli_connect( "localhost", "bogeyman", "qwerty", "lab-3" );
//
//		$query = "DELETE FROM users Where username Like '%'";
//		$result = mysqli_query( $link, $query ) or die( "Ошибка " . mysqli_error( $link ) );
//		mysqli_close( $link );

	//script-----------------------------------------------------------------------------------------------
	//	$read_basket_info = file_exists( $path_users . $connected_user ) ? mkdir( $path_users . $connected_user ) : "";

//		$input = isset( $_GET[ 'cart_info' ] ) ? json_decode( $_GET[ 'cart_info' ] ) : null;
//	if( !file_exists( '../database/basket_information.json' ) ) {
//
//		$basket_information = [
//			'checked_click' => [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ],
//			'quantity'      => [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ]
//		];
//		$basket_information[ 'checked_click' ][ $input->index_item ] = $input->checked_click;
//
//		file_put_contents( '../database/basket_information.json', json_encode( $basket_information ) );
//
//	} else  {
//
//		$basket_information = file_get_contents(
//			" ../database / basket_information . json"
//		);
//		$basket_information = json_decode( $basket_information );
//		$basket_information->checked_click[ $input->index_item ] = $input->checked_click;
//
//
//		file_put_contents( '../database/basket_information.json', json_encode( $basket_information ) );
//	}
?>