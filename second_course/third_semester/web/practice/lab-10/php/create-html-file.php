<?php
	
	
	$writeFile             = "";
	$pathProjectnDirectory = "C:\\xampp\\htdocs\\lab-10";
	$readFile              = "";
	$patternHtml           = "<!doctype html>
                          <html lang=\"en\">
                          <head>
                            <meta charset=\"UTF-8\">
                            <meta name=\"viewport\"
                                  content=\"width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0\">
                            <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">
                            <title>lab-10</title>
                            <link rel=\"stylesheet\" href=\"css/style.css\">
                          </head>
                          <body>";
	
	for ( $i = 1; $i < 11; $i++ ) {
		$readFile = iconv (
			'WINDOWS-1251',
			'UTF-8',
			file_get_contents ( "$pathProjectnDirectory\\text\\Текст-$i.txt" )
		);
		
		$readFile = $patternHtml
		            . $readFile
		            . "<img src='php/statistics-counting.php' style='display: none;'>"
		            . "</body> </html>";
		
		file_put_contents ( "$pathProjectnDirectory\\index-$i.html", $readFile );
		
		$readFile  = file ( "$pathProjectnDirectory\\text\\Текст-$i.txt" );
		$writeFile .= $readFile[ 0 ];
	}
	
	file_put_contents ( "$pathProjectnDirectory\\text\\main-content.txt", $writeFile );
	
	
	
	if ( !file_exists ( "statistic.txt" ) ) {
		file_put_contents ( "$pathProjectnDirectory\\php\\script-main-content.php", "" );
		fopen ( "$pathProjectnDirectory\\text\\statistic.txt", "a" );
		file_put_contents ( "$pathProjectnDirectory\\text\\statistic.txt", "0#0#0#0#0#0#0#0#0#0#0" );
		
		$readFile      = file ( "$pathProjectnDirectory\\text\\main-content.txt" );
		$countReadFile = count ( $readFile );
		
		for ( $i = 0; $i < $countReadFile; $i++ ) {
			$readFile[ $i ] = "<p>" . iconv ( 'WINDOWS-1251', 'UTF-8', $readFile[ $i ] ) . "</p>";
		}
		
		$readFile = join ( "\n", $readFile );
		file_put_contents (
			"$pathProjectnDirectory\\main-content.html",
			$patternHtml . "<img src='php/script-main-content.php' style='display: none;'>$readFile<script src='javascript/script.js'></script></body></html>"
		);
	}

?>