<?php 
$test = $_POST[ "terminal__text" ]; 
preg_match (
	"/([А-я]+)/u",
	$test, 
	$array 
); 	
var_dump ($array); ?>
?>
