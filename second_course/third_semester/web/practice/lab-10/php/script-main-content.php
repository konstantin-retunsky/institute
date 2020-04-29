










<?php

	$pathStatisticFile = "C:\\xampp\\htdocs\\lab-10\\text\\statistic.txt";
	$readFile = file_get_contents ($pathStatisticFile);
	$readFile = explode ("#", $readFile);
	$readFile[10] = $readFile[10] + 0.05;
//	var_dump ($_COOKIE["bubble"]);
	setcookie ("bubble", $readFile[10], time () + 60 * 60 * 24 * 365, "/lab-10");
	
//	var_dump ( $readFile);
	file_put_contents ($pathStatisticFile, join ("#", $readFile));

?>