<?php
	
	$myArr = array("John", "Mary", "Peter", "Sally");
	
	$myJSON = json_encode($myArr);
	
	$test = '{"item-one":"test-1","item-two":["ee","ee2"]}';
	$test = json_decode ($test);
	
	var_dump ($test);
	echo $myJSON;
?>