<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>lab-9</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

<a href=""></a>
<form action="index.php" method="post"
      style="margin: auto; width: 500px; height: min-content; padding: 10px; margin-top: 100px; ">
    <h2 style="color: darkcyan">Home page</h2>
    <input type="submit" value="random-banner" name="random-banner"
           style="border: none; background-color: darkcyan; color: white; padding: 5px; border-radius: 5px;">
    <br>
    <br>
	
	
	<?php
		
		$statisticFile = "statistic-site.txt";
		if ( ! file_exists ( $statisticFile ) ) {
			touch ( $statisticFile );
			file_put_contents ( $statisticFile,
			                    "0#0#0#0#0\n0#0#0#0#0\n0#0#0#0#0\n0" );
		}
		
		require_once ( 'script.php' );
		
		//создание рандомного баннера и регистрация баннера в счетчике
		if ( isset( $_POST[ "random-banner" ] ) ) {
			$randomNumber = random_int ( 1, 5 );
			setcookie ( 'random-number', $randomNumber );
			
			$nameImg = "0$randomNumber.gif";
			echo "<input type='submit' name='click-banner'  value='' style='width: 125px; height: 125px; background-image: url( $nameImg );' ></input>";
			
			WriteStatistic ( 0, $randomNumber, $statisticFile );
			WriteStatistic ( 3, 1, $statisticFile );
		}
		
		// создание сайтов для баннера
		if ( isset( $_POST[ "click-banner" ] ) ) {
			$randomNumber = $_COOKIE[ 'random-number' ];
			$patternFile  = "pattern-site.php";
			$newFile      = "index-$randomNumber.php";
			$contentFile  = "Текст0$randomNumber.txt";
			
			if ( ! is_file ( $newFile ) ) {
				copy ( $patternFile, $newFile );
				
				$writeContent = file_get_contents ( $contentFile );
				$writeContent = iconv ( 'WINDOWS-1251', 'UTF-8', $writeContent )
				                . "</body></html> " . '<?php include "script.php"; ?>';
				
				file_put_contents (
					$newFile,
					$writeContent,
					FILE_APPEND
				); //file_put_contents
				
			}
			
			WriteStatistic ( 1, $randomNumber, $statisticFile );
			echo "<script> document.location.href = 'http://localhost/lab-9/index-$randomNumber.php'; </script>";
		}
		
		echo "<table><caption>CTR, CTI и CTB</caption>";
		echo "<tr>
                   <td>Название сайта</td>
                   <td>Количество показов</td>
                   <td>Количество кликов</td>
                   <td>Количество заказов</td>
                   <td>CTR</td>
                   <td>CTI</td>
                   <td>CTB</td>
                  </tr>";
		
		$readStatistic = file_get_contents ( $statisticFile );
		$readStatistic = preg_split (
			"/\n+/",
			$readStatistic,
			-1
		); //preg_split
		for ( $i = 0 ; $i < count ( $readStatistic ) ; $i++ ) {
			$readStatistic[ $i ] = explode ( "#", $readStatistic[ $i ] );
		}
		
		for ( $i = 0 ; $i < 5 ; $i++ ) {
			echo "<tr>";
			
			$view     = $readStatistic[ 0 ][ $i ];
			$click    = $readStatistic[ 1 ][ $i ];
			$order    = $readStatistic[ 2 ] [ $i ];
			$clickAll = $readStatistic[ 3 ][ 0 ];
			$CTR      = ( $click != 0 & $view != 0 ) ?
				round ( $click / $view * 100, 2 ) :
				0;
			$CTI      = ( $click != 0 & $clickAll != 0 ) ?
				round ( $click / $clickAll * 100, 2 ) :
				0;
			$CTB      = ( $order != 0 & $click != 9 ) ?
				round ( $order / $click * 100, 2 ) :
				0;
			
			for ( $j = 0 ; $j < 7 ; $j++ ) {
				if ( $j == 0 ) {
					$indexName = $i + 1;
					echo "<td>index-$indexName.php</td>";
				} else if ( $j == 1 ) {
					echo "<td>$view</td>";
				} else if ( $j == 2 ) {
					echo "<td>$click</td>";
				} else if ( $j == 3 ) {
					echo "<td>$order</td>";
				} else if ( $j == 4 ) {
					echo "<td>$CTR</td>";
				} else if ( $j == 5 ) {
					echo "<td>$CTI</td>";
				} else if ( $j == 6 ) {
					echo "<td>$CTB</td>";
				}
			}
			
			echo "</tr>";
		}
		
		
		echo "</table>";
	
	?>

</form>

</body>
</html>