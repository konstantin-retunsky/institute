<?php
	
	function WriteStatistic ( $functionIndex, $siteIndex, $path ) {
		
		$readStatisticFile = file_get_contents ( $path );
		$readStatisticFile = preg_split (
			"/\n+/",
			$readStatisticFile,
			-1
		); //preg_split
		
		$readStatisticFile[ $functionIndex ] = preg_split (
			"/#/",
			$readStatisticFile[ $functionIndex ],
			-1
		); //preg_split
		
		$siteIndex--;
		
		$readStatisticFile[ $functionIndex ][ $siteIndex ]++;
		$readStatisticFile[ $functionIndex ] = join ( $readStatisticFile[ $functionIndex ], "#" );
		
		file_put_contents ( $path, join ( $readStatisticFile, "\n" ) );
		$siteIndex++;
	}
	
	if ( isset( $_POST[ 'order' ] ) ) {
		$pathStatisticFile = "statistic-site.txt";
		$indexArray = preg_replace ( "/\D+/", "", basename ( $_SERVER[ "SCRIPT_NAME" ] ) );
		WriteStatistic ( 2, $indexArray, $pathStatisticFile );
		
		echo "<script> document.location.href = 'http://localhost/lab-9/index.php'; </script>";
	}
?>