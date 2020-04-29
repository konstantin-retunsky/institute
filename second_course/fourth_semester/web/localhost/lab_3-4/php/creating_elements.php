<?php
	
	require_once( "classes/CreateElement.php" );
	
	$what_create_get = isset( $_GET[ 'what_create' ] ) ? $_GET[ 'what_create' ] : null;
	$connected_user = $_COOKIE[ 'connected_user' ];
	
	$basket_information = file_get_contents( "../database/users/$connected_user/basket_information.json" );
	$basket_information = json_decode( $basket_information );
	
	$database = new mysqli( "localhost", "bogeyman", "qwerty", "lab-3" );
	$select_table = $database->query( "SELECT * FROM `goods`" );
	$count_rows = mysqli_num_rows( $select_table );
	
	if( $what_create_get == "home_products" ) {
		
		echo "<h2>Товары</h2>";
		echo "<div class=\"products\">";
		for( $row_index = 0; $row_index < $count_rows - 1; $row_index++ ) {
			$row = mysqli_fetch_row( $select_table );
			array_push( $row, $basket_information->checked_click[ $row_index ] );
			echo CreateElement::ProductItem( $row, $row_index );
		}
		echo "</div>";
		
	} else if( $what_create_get == "shop_basket" ) {
		
		$total_price = 0;
		echo "<div class=\"shopping-cart\">";
		echo "<div class=\"title\">Shopping Basket</div>";
		for( $row_index = 0; $row_index < $count_rows - 1; $row_index++ ) {
			$row = mysqli_fetch_row( $select_table );
			if( $basket_information->checked_click[ $row_index ] == 1 ) {
				$total_price += $row[ 3 ];
				echo CreateElement::ShooppingBasket( $row, $row_index );
			}
		}
		echo "<div class=\"total-cost\">Общая сумма: <span id=\"total_price\">$total_price</span></div>";
		echo "</div>";
		
		echo "<script>alert('complited')</script>";
	}


?>