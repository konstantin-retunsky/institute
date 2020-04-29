




<?php
	//	setcookie ("test-cookie", "EEEEEEEEE--BOOOY");
	// Лабораторная работа. Облако тэгов.
	// 1. Создать 10 статичных html-документов, содержащих информацию приложенных текстовых файлов. В каждый документ поместить скрипт, регистрирующий во внешнем файле количество загрузок этого документа (счетчик).
	// 2. Создать текстовый файл, содержащий список html-документов, к каждому из которых поставлены в соответствие ключевые слова, характеризующие его содержание.
	// 3. Создать html-документ, содержащий скрипт, который выводит перечисленные ключевые слова, набранные шрифтом разного размера. Чем чаще открывался соответствующий файл, тем больше размер шрифта.
	$pathStatisticFile = "C:\\xampp\\htdocs\\lab-10\\text\\statistic.txt";
	$indexClickSite    = $_COOKIE[ 'index-click-site' ] - 1;
	$readFile          = file_get_contents ( "C:\\xampp\\htdocs\\lab-10\\text\\statistic.txt" );
	
	$writeContens = explode (
		'#',
		$readFile
	);
	
	$writeContens[ $indexClickSite ]++;
	
	$writeContens = join ( "#",$writeContens );
	
	file_put_contents ( $pathStatisticFile, $writeContens );
?>