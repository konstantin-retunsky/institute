<?php
	
	
	if ( isset( $_GET[ 'database_conversion' ] ) & !file_exists ( '../database/new_database.txt' ) ) {
		include ( $_SERVER[ 'DOCUMENT_ROOT' ] . '//lab-11//php//database_conversion.php' );
		header ( 'Location:../index.html' );
	} else if ( isset( $_GET[ 'delete-new_datebase' ] ) & file_exists ( '../database/new_database.txt' ) ) {
		unlink ( '../database/new_database.txt' );
		header ( 'Location:../index.html' );
	} else if ( isset( $_GET[ 'show-statistic' ] ) ) {
		header ( 'Location:../php/statistic.php' );
	} else if ( isset( $_GET[ 'show-city-residents' ] ) ) {
		
		$newDatabase = file ( '../database/new_database.txt' );
		$nowDate     = new DateTime( 'now' );
		$output      = array ();
		
		for ( $i = 0; $i < count ( $newDatabase ); $i++ ) {
			
			$row      = explode ( ';', $newDatabase[ $i ] );
			$interval = $nowDate -> diff ( new DateTime( $row[ 9 ] ) );
			$age      = $interval -> format ( '%y' );
			$row[ 9 ] = $age;
			
			if ( $row[ 6 ] == $_GET[ 'input-text' ] ) {
				
				$output[ $row[ 1 ] ] = '0';
				$keyOutput           = $row[ 1 ];
				
				if ( $row[ 4 ] == 1 ) {
					$row[ 1 ] = "<span style='color: lightskyblue;'>$row[1]</span>";
				} else if ( $row[ 4 ] == 0 ) {
					$row[ 1 ] = "<span style='color: pink;'>$row[1]</span>";
				}
				
				$output[ $keyOutput ] = join ( ';', $row );
			}
		}
		
		ksort ( $output );
		
		foreach ( $output as $str ) {
			echo $str . "<br>";
		}
		
	} else {
		header ( 'Location:../index.html' );
	}



?>