<?php
	
	
	require_once( "classes/Connection.php" );
	
	$input_get = isset( $_GET[ 'connection' ] ) ? json_decode( $_GET[ 'connection' ] ) : null;
	
	if( $input_get != null ) {
		$connection = new Connection();
		
		echo $input_get->email == null | $input_get->email == '' ?
			$connection->LoginIn( $input_get->login, $input_get->password ) :
			$connection->SignUp( $input_get->login, $input_get->password, $input_get->email );
		
		if( $input_get->email != null | $input_get->email != '' ) {
			mkdir( "../database/users/$input_get->login" );
			copy(
				"../database/users/unregistered/basket_information.json",
				"../database/users/$input_get->login/basket_information.json"
			);
		}
	}
	
	$cart_info = isset( $_GET[ 'cart_info' ] ) ? json_decode( $_GET[ 'cart_info' ] ) : null;
	
	if( $cart_info != null ) {
		$connected_user = $_COOKIE[ 'connected_user' ];
		$path = "../database/users/$connected_user/basket_information.json";
		
		$basket_information = file_get_contents( $path );
		$basket_information = json_decode( $basket_information );
		$basket_information->checked_click[ $cart_info->index_item ] = $cart_info->checked_click;
		file_put_contents( $path, json_encode( $basket_information ) );
	}

?>