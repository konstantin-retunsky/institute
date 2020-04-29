<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>

<form method="post">
    <input type="submit" name="done">
</form>

</body>
</html>

<?php
	//    Вариант 2.
	//    Содержимое левого меню, на голубом фоне («Что такое РНР?», «Возможности PHP», …).
	//    Каждый пункт меню — с новой строки.
	//    В конце указать количество слов «PHP».
	
	
	if ( isset( $_POST[ "done" ] ) ) {
		$path = "C:\\xampp\\htdocs\\lab-8\\index.html";
		$patternTeg = "/(<span\sclass=\"navText2\">.+<\/span>)+/u";
		
		$loadedFile = file_get_contents ( $path );
		
		preg_match_all (
			$patternTeg,
			$loadedFile,
			$output
		);
		
		
		$phpWordCount = 0;
		
		foreach ( $output[ 0 ] as $str ) {
		 
			echo $str . "<br>";
			
			if ( preg_match ( "/PHP/u", $str ) ) {
				$phpWordCount++;
			}
		}
		
		echo "<br> Количество сторк: " . count ($output[0]);
		echo "<br> Количество PHP: " . $phpWordCount;
	}
	
	
	
	// через localhost
	//	$path = "C:\\xampp\\htdocs\\lab-8\\index.html";
	//
	//
	//
	//	$dom = new DOMDocument();
	//
	//	$html_string =  file_get_contents ($path) ;
	//
	//	$dom -> loadHTML ( $html_string );
	//
	//	$documentElement = $dom -> documentElement;
	//
	//	$xpath = new DOMXpath( $dom );
	//	$tables = $xpath -> query ( "//h2[contains(@class,'ee')]" );
	//
	//
	//	for ( $i = 0; $i < $tables -> length; $i++ ) {
	//		echo $tables -> item ( $i ) -> nodeValue . PHP_EOL;
	//	}
?>