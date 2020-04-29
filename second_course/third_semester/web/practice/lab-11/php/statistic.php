<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>statistic padge</title>
</head>
<body>

<a href="../index.html">back</a>

</body>
</html>

<?php
	
	$mediumMale     = array (
		'medium_height' => 0,
		'medium_weight' => 0,
		'medium_age'    => 0
	);
	$mediumFemale   = array (
		'medium_height' => 0,
		'medium_weight' => 0,
		'medium_age'    => 0
	);
	$quantityMale   = array (
		'total_amount'        => 0,
		'below_medium_height' => 0,
		'below_medium_weight' => 0,
		'below_medium_age'    => 0,
		'medium_height'       => 0,
		'medium_weight'       => 0,
		'medium_age'          => 0,
		'above_medium_height' => 0,
		'above_medium_weight' => 0,
		'above_medium_age'    => 0,
	);
	$quantityFemale = array (
		'total_amount'        => 0,
		'below_medium_height' => 0,
		'below_medium_weight' => 0,
		'below_medium_age'    => 0,
		'medium_height'       => 0,
		'medium_weight'       => 0,
		'medium_age'          => 0,
		'above_medium_height' => 0,
		'above_medium_weight' => 0,
		'above_medium_age'    => 0,
	);
	
	// высчитываем среднее значение по возрасту, росту и весу. И бщее количество женщинин и мужчин
	$newDatabase = file ( '../database/new_database.txt' );
	$nowDate     = new DateTime( 'now' );
	
	for ( $i = 0; $i < count ( $newDatabase ); $i++ ) {
		
		$row      = explode ( ';', $newDatabase[ $i ] );
		$interval = $nowDate -> diff ( new DateTime( $row[ 9 ] ) );
		$age      = $interval -> format ( '%y' );
		
		if ( $row[ 4 ] == 1 ) {
			$quantityMale[ 'total_amount' ]++;
			$mediumMale[ 'medium_height' ] += $row[ 13 ];
			$mediumMale[ 'medium_weight' ] += $row[ 12 ];
			$mediumMale [ 'medium_age' ]   += $age;
		} else if ( $row[ 4 ] == 0 ) {
			$quantityFemale[ 'total_amount' ]++;
			$mediumFemale[ 'medium_height' ] += $row[ 13 ];
			$mediumFemale[ 'medium_weight' ] += $row[ 12 ];
			$mediumFemale[ 'medium_age' ]    += $age;
		}
		
	}
	
	foreach ( $mediumMale as &$value ) {
		$value = round ( $value / $quantityMale[ 'total_amount' ] );
	}
	foreach ( $mediumFemale as &$value ) {
		$value = round ( $value / $quantityFemale[ 'total_amount' ] );
	}
	
	$oldestPerson    = array ( 'index' => 0, 'age' => '06.08.2019' );
	$youngestPerson  = array ( 'index' => 0, 'age' => '06.08.1723' );
	$emailsAddresses = array ();
	$nowDate         = new DateTime( 'now' );
	$holidayDays     = array ();
	// 4 - пол, 13 - рост, вес - 12, 9 - дата рождения
	//b.	Вывести имя, телефон и полный адрес самого пожилого и самого молодого человека.
	for ( $i = 0; $i < count ( $newDatabase ); $i++ ) {
		
		$row = explode ( ';', $newDatabase[ $i ] );
		
		//d.	Вывести имена людей, родившихся в праздничные дни: 01.01, 07.01, 14.02, 23.02, 08.03, 01.05, 31.12 с группировкой по дате.
		$patternHolidayDay = '/01\.01|07\.01|14\.02|23\.02|08\.03|01\.05|31\.12/';
		if ( preg_match ( $patternHolidayDay, $row[ 9 ] ) ) {
			
			preg_match ( $patternHolidayDay, $row[ 9 ], $keyHolidayDays );
			$keyHolidayDays = $keyHolidayDays[ 0 ];
			
			if ( preg_match ( $patternHolidayDay, $row[ 9 ] ) ) {
				if ( !array_key_exists ( $keyHolidayDays, $holidayDays ) ) {
//					array_push ( $holidayDays, $keyHolidayDays );
					$holidayDays[ $keyHolidayDays ] = $row[ 1 ];
					
				} else {
					$holidayDays[ $keyHolidayDays ] .= ', ' . $row[ 1 ];
				}
			}
		}
		
		
		// выясняем кто самый старый, а кто самый молодой
		if ( strtotime ( $row[ 9 ] ) < strtotime ( $oldestPerson[ 'age' ] ) ) {
			$oldestPerson[ 'age' ]   = $row[ 9 ];
			$oldestPerson[ 'index' ] = $i;
		}
		if ( strtotime ( $row[ 9 ] ) > strtotime ( $youngestPerson[ 'age' ] ) ) {
			$youngestPerson[ 'age' ]   = $row[ 9 ];
			$youngestPerson[ 'index' ] = $i;
		}
		
		// количество клиентов каждого почтового сервера.
		$patternMailServer = '/(?<=@).+(?=\.)/';
		if ( preg_match ( $patternMailServer, $row[ 7 ] ) ) {
			preg_match ( $patternMailServer, $row[ 7 ], $mailServer );
			$mailServer = $mailServer[ 0 ];
			
			if ( !array_key_exists ( $mailServer, $emailsAddresses ) ) {
				$emailsAddresses[ $mailServer ] = 1;
			} else {
				$emailsAddresses[ $mailServer ]++;
			}
		}
		
		// подсчитываем количество женщин и мужчин, которые имеют рост, вес и возраст “ниже среднего”, “средний”, “выше среднего” для каждой характеристики
		$interval = $nowDate -> diff ( new DateTime( $row[ 9 ] ) );
		$age      = $interval -> format ( '%y' );
		
		if ( $row[ 4 ] == 1 ) { // male
			
			if ( $row[ 13 ] > $mediumMale[ 'medium_height' ] ) {
				$quantityMale[ 'above_medium_height' ]++;
			} else if ( $row[ 13 ] < $mediumMale[ 'medium_height' ] ) {
				$quantityMale[ 'below_medium_height' ]++;
			} else if ( $row[ 13 ] == $mediumMale[ 'medium_height' ] ) {
				$quantityMale[ 'medium_height' ]++;
			}
			
			if ( $row[ 12 ] > $mediumMale[ 'medium_weight' ] ) {
				$quantityMale[ 'above_medium_weight' ]++;
			} else if ( $row[ 12 ] < $mediumMale[ 'medium_weight' ] ) {
				$quantityMale[ 'below_medium_weight' ]++;
			} else if ( $row[ 12 ] == $mediumMale[ 'medium_weight' ] ) {
				$quantityMale[ 'medium_weight' ]++;
			}
			
			if ( $age > $mediumMale[ 'medium_age' ] ) {
				$quantityMale[ 'above_medium_age' ]++;
			} else if ( $age < $mediumMale[ 'medium_age' ] ) {
				$quantityMale[ 'below_medium_age' ]++;
			} else if ( $age == $mediumMale[ 'medium_age' ] ) {
				$quantityMale[ 'medium_age' ]++;
			}
			
		} else if ( $row[ 4 ] == 0 ) { //female
			
			if ( $row[ 13 ] > $mediumFemale[ 'medium_height' ] ) {
				$quantityFemale[ 'above_medium_height' ]++;
			} else if ( $row[ 13 ] < $mediumFemale[ 'medium_height' ] ) {
				$quantityFemale[ 'below_medium_height' ]++;
			} else if ( $row[ 13 ] == $mediumFemale[ 'medium_height' ] ) {
				$quantityFemale[ 'medium_height' ]++;
			}
			
			if ( $row[ 12 ] > $mediumFemale[ 'medium_weight' ] ) {
				$quantityFemale[ 'above_medium_weight' ]++;
			} else if ( $row[ 12 ] < $mediumFemale[ 'medium_weight' ] ) {
				$quantityFemale[ 'below_medium_weight' ]++;
			} else if ( $row[ 12 ] == $mediumFemale[ 'medium_weight' ] ) {
				$quantityFemale[ 'medium_weight' ]++;
			}
			
			if ( $age > $mediumFemale[ 'medium_age' ] ) {
				$quantityFemale[ 'above_medium_age' ]++;
			} else if ( $age < $mediumFemale[ 'medium_age' ] ) {
				$quantityFemale[ 'below_medium_age' ]++;
			} else if ( $age == $mediumFemale[ 'medium_age' ] ) {
				$quantityFemale[ 'medium_age' ]++;
			}
			
		}
	} // конец цикла для подсчеат статистики
	
	//b.	Вывести имя, телефон и полный адрес самого пожилого и самого молодого человека.
	$oldestPerson = $newDatabase[ $oldestPerson[ 'index' ] ];
	$oldestPerson = explode ( ';', $oldestPerson );
	$oldestPerson = $oldestPerson[ 1 ] . ', ' . $oldestPerson[ 8 ] . ', ' . $oldestPerson[ 5 ] . ', '
	                . $oldestPerson[ 6 ];
	
	$youngestPerson = $newDatabase[ $youngestPerson[ 'index' ] ];
	$youngestPerson = explode ( ';', $youngestPerson );
	$youngestPerson = $youngestPerson[ 1 ] . ', ' . $youngestPerson[ 8 ] . ', ' . $youngestPerson[ 5 ] . ', '
	                  . $youngestPerson[ 6 ];
	
	//	a.	Найти количество женщин и мужчин, определить средний рост, вес и возраст для каждой категории. Определить количество женщин и мужчин, которые имеют рост, вес и
	// возраст “ниже среднего”, “средний”, “выше среднего” для каждой характеристики, в рамках каждой группы.
	//  b.	Вывести имя, телефон и полный адрес самого пожилого и самого молодого человека. c.	Найти количество клиентов каждого почтового сервера.
	//	c.	Найти количество клиентов каждого почтового сервера.                                                                                                                                                                                                                                                                                                                                                                                                   d.	Вывести имена людей, родившихся в праздничные дни: 01.01, 07.01, 14.02, 23.02, 08.03, 01.05, 31.12 с группировкой по дате.
	//	d.	Вывести имена людей, родившихся в праздничные дни: 01.01, 07.01, 14.02, 23.02, 08.03, 01.05, 31.12 с группировкой по дате.
	
    echo "<br>";
	ksort ( $holidayDays );
	foreach ( $holidayDays as $key => $line ) {
		echo 'День: ' . $key . ' ' . $line . "<br>";
	}
	echo '<br>';
	foreach ( $emailsAddresses as $key => $line ) {
		echo 'почтовый сервер: ' . $key . ", количество пользователей: " . $line . "<br>";
	}
	echo "<br>";
	echo 'самый старый юзер: ' . $oldestPerson;
	echo '<br>';
	echo 'самый молодой юзер: ' . $youngestPerson;
	echo '<br>';
	echo '<br>';
	
	echo "<br>";
	
	echo "Общее количество женщин: " . $quantityFemale['total_amount'] . "<br>";
	echo "Средний рост женщин: " . $mediumFemale['medium_height'] . "<br>";
	echo "Средний вес женщин: " . $mediumFemale['medium_weight'] . "<br>";
	echo "Средний возраст женщин: " . $mediumFemale['medium_age'] . "<br>";
	echo 'Количество женщин ниже среднего роста: ' . $quantityFemale['below_medium_height'] . "<br>";
	echo 'Количество женщин среднего роста: ' . $quantityFemale['medium_height'] . "<br>";
	echo 'Количество женщин выше среднего роста: ' . $quantityFemale['above_medium_height'] . "<br>";
	
	echo 'Количество женщин ниже среднего веса: ' . $quantityFemale['below_medium_weight'] . "<br>";
	echo 'Количество женщин среднего веса: ' . $quantityFemale['medium_weight'] . "<br>";
	echo 'Количество женщин выше среднего веса: ' . $quantityFemale['above_medium_weight'] . "<br>";
	
	echo 'Количество женщин ниже среднего возраста: ' . $quantityFemale['below_medium_age'] . "<br>";
	echo 'Количество женщин среднего возраста: ' . $quantityFemale['medium_age'] . "<br>";
	echo 'Количество женщин выше среднего возраста: ' . $quantityFemale['above_medium_age'] . "<br>";
	
	echo '<br>';
	
	echo "Общее количество мужчин: " . $quantityMale['total_amount'] . "<br>";
	echo "Средний рост мужчин: " . $mediumMale['medium_height'] . "<br>";
	echo "Средний вес мужчин: " . $mediumMale['medium_weight'] . "<br>";
	echo "Средний возраст мужчин: " . $mediumMale['medium_age'] . "<br>";
	echo 'Количество мужчин ниже среднего роста: ' . $quantityMale['below_medium_height'] . "<br>";
	echo 'Количество мужчин среднего роста: ' . $quantityMale['medium_height'] . "<br>";
	echo 'Количество мужчин выше среднего роста: ' . $quantityMale['above_medium_height'] . "<br>";
	
	echo 'Количество мужчин ниже среднего веса: ' . $quantityMale['below_medium_weight'] . "<br>";
	echo 'Количество мужчин среднего веса: ' . $quantityMale['medium_weight'] . "<br>";
	echo 'Количество мужчин выше среднего веса: ' . $quantityMale['above_medium_weight'] . "<br>";
	
	echo 'Количество мужчин ниже среднего возраста: ' . $quantityMale['below_medium_age'] . "<br>";
	echo 'Количество мужчин среднего возраста: ' . $quantityMale['medium_age'] . "<br>";
	echo 'Количество мужчин выше среднего возраста: ' . $quantityMale['above_medium_age'] . "<br>";
	
	
//	foreach ( $quantityFemale as $key => $line ) {
//		echo 'female_' . $key . " " . $line . "<br>";
//	}
//	echo '<br>';
//	foreach ( $quantityMale as $key => $line ) {
//		echo 'male_' . $key . " " . $line . "<br>";
//	}
//	echo "<br>";
//	foreach ( $mediumMale as $key => $line ) {
//		echo 'male_' . $key . " " . $line . "<br>";
//	}
//	echo "<br>";
//	foreach ( $mediumFemale as $key => $line ) {
//		echo 'female_' . $key . " " . $line . "<br>";
//	}


?>