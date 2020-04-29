<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/style.css">
    <title>lab-7</title>
</head>
<body>
<img src="Снимок.JPG" alt="">
<form method="post">

    <input type="date" name="input-date" value="2019-09-09">

    <select name="what-to-search">
        <option value="/\d+/u">цифровые</option>
        <option value="/чемпионат/u">чемпионат</option>
        <option value="/устройство/u">устройство</option>
        <option value="/хоккеист/u">хоккеист</option>
    </select>
    <input type="submit" name="result">

</form>

</body>
<script src="js/main.js"></script>
</html>


<?php
	//	2. Форма:
	// - селект "Дата" (год месяц день)
	// - поле ввода Найти (цифровые, чемпионат, устройство, хоккеист)
	//
	// Вывести на экран рубрики и тексты статей, содержащих заданное слово (хотя бы раз).
	// В случае отсутствия вывести "Найдено 0 статей".
 
	if ( isset( $_POST[ "result" ] ) ) {
		
		$inputDate = $_POST[ "input-date" ];
		$patternText = $_POST[ "what-to-search" ];
		
		$path = "C:\\xampp\\htdocs\\lab-7\\" . preg_replace ( "/-/", "", $inputDate, -1 );
		$files = scandir ( $path );
		$boolean = true;
		
		foreach ( $files as $file ) {
			$file = $path . "\\" . $file;
			if ( is_file ( $file ) ) {
				$file = file_get_contents ( $file );
				if ( preg_match ( $patternText, $file ) ) {
					echo $file . "<br> <br>";
					$boolean = false;
				}
			}
		}
		
		if ( $boolean ) {
			echo "Найдено 0 статей";
		}
		
	}
?>