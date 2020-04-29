<?php
	require_once ( "classes/DatabaseDump.php" );
	
	
	$oldbase = file ( '../database/oldbase.txt' );
	$errors  = array ( "email" => 0, "gender" => 0, "phone" => 0, "address" => 0 );
	
	// индексы столбцов
	// 0 - rowindex, 1 - name, 2 - Отчество, 3 - фамилия, 4 - пол, 5 - город, 6 - область
	// 7 - email, 8 - phone, 9 - Date of Birth, 10 - Должность, 11 - Компания,
	// 12 - Вес, 13 - рост, 14 - Почтовый адрес, 15 - Почтовый индекс, 16 - Код страны
	
	for ( $i = 0; $i < count ( $oldbase ); $i++ ) {
		
		$line = explode ( ',', $oldbase[ $i ] );
		
		if ( DatabaseDump ::MatchesEmail ( $line[ 7 ] ) ) { // line[ 7 ] - email
			DatabaseDump ::FixEmail ( $line[ 7 ], true );
		} else {
			DatabaseDump ::FixEmail ( $line[ 7 ], false );
			$errors[ 'email' ]++;
		}
		
		if ( DatabaseDump ::MatchesGender ( $line[ 4 ] ) ) { //line[ 4 ] - пол
			DatabaseDump ::FixGender ( $line[ 4 ] );
		} else {
			DatabaseDump ::FixGender ( $line[ 4 ] );
			$errors[ 'gender' ]++;
		}
		
		if ( DatabaseDump ::MatchesPhone ( $line[ 8 ] ) ) { // line[ 8 ] - phone
			DatabaseDump ::FixPhone ( $line[ 8 ] );
		} else {
			DatabaseDump ::FixPhone ( $line[ 8 ] );
			$errors[ 'phone' ]++;
		}
		
		if ( DatabaseDump ::MatchesAddress ( $line[ 14 ] ) ) { //line[ 14 ] - почтовый адрес
			DatabaseDump ::FixAddress ( $line[ 14 ], true );
		} else {
			DatabaseDump ::FixAddress ( $line[ 14 ], false );
			$errors[ 'address' ]++;
		}
		
		DatabaseDump ::FixRowIndex ( $line[ 0 ] ); // line[ 0 ] - индекс строки
		DatabaseDump ::FixDate ( $line[ 9 ] );     // line[ 9 ] - дата рождения
		DatabaseDump ::FixWeight ( $line[ 12 ] );  // line[ 12 ] - Вес
		
		$line          = join ( ';', $line );
		$oldbase[ $i ] = $line;
		
		
	}
	file_put_contents ( '../database/errors.txt', join ('#',$errors) );
	file_put_contents ( '../database/new_database.txt', $oldbase );


?>