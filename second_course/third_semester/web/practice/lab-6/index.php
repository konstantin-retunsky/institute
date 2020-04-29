<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
<form class="terminal" action="index.php" method="post">
    <div class="terminal__header">
            <span class="terminal__header--title">
                bogeyman@bogeyman-pc
            </span>
        <img class="header__icons--size" src="images/icons/close.svg">
        <img class="header__icons--size" src="images/icons/maximize.svg">
        <img class="header__icons--size" src="images/icons/minimize.svg">
    </div>
    <textarea class="terminal__text" cols="68" rows="16" name="terminal__text" autofocus><?php
				if ( isset( $_POST[ "result" ] ) ) {
					echo $_POST[ "terminal__text" ] . "\n" . "bogeyman@bogeyman-pc:~&nbsp";
				}
			?></textarea>
    <input type="submit" value="kostil" class="kostil" name="result">
</form>
</body>
<script src="javascript/jquery-3.4.1.min.js"></script>
<script src="javascript/jquery-ui-1.12.1.js"></script>
<script src="javascript/main.js"></script>
</html>

<?php
	
	//Пользователю предлагается ввести на странице имя некоторого каталога и данные запроса.В зависимости от запроса
	// - удалить из заданного каталога все файлы, имеющие расширение на заданную букву;
	// - выдать на экран содержимое файла с заданным именем заданного каталога, если он не пуст;
	// - переименовать файлы заданного каталога с именами, начинающимися на заданную букву.
	
	if ( isset( $_POST[ "result" ] ) ) {
		
		$inputText = $_POST[ "terminal__text" ];
		
		$patternLastCode = "/bogeyman@bogeyman-pc:~.+$/u";
		$patternDeleteUserName = "/bogeyman@bogeyman-pc:~\s/u";
		$patternComand = "/[a-z]+(?=\s)/";
		$patternPath = "/[a-z]+\s/";
		
		$path = "";
		//		$patternPath = "/(?<=\s).+/";
		
		preg_match (
			$patternLastCode,
			$inputText,
			$terminalCode
		); //preg_match
		
		$terminalCode = preg_replace (
			$patternDeleteUserName,
			"",
			$terminalCode
		); //preg_replace
		
		preg_match (
			$patternComand,
			$terminalCode[ 0 ],
			$terminalComand
		); //preg_match
		
		$terminalComand = $terminalComand[ 0 ];
		
		$path = preg_replace (
			$patternPath,
			"",
			$terminalCode,
			1
		); //preg_replace
		
		$path = $path[ 0 ];
		
		
		if ( $terminalComand == "rm" ) {
			
			$path = str_replace (
				'\\',
				'\\\\',
				$path
			); //preg_replace
			
			$path = preg_replace (
				"/\s+/",
				"",
				$path,
				-1
			); //preg_replace
			
			$files = glob ( $path );
			foreach ( $files as $file ) {
				unlink ( $file );
			}
			
			
		} else if ( $terminalComand === "cat" ) {
			
			// Вывод текста из файла
			$catFile = file_get_contents ( $path );
			echo "<script type='text/javascript'>alert('$catFile');</script>";
			
		} else if ( $terminalComand === "mv" ) {
			
			// Ренейм
			$startName = preg_replace (
				"/\s.+/u",
				"",
				$path
			); //preg_replace
			
			$finishName = preg_replace (
				"/.+\s/",
				"",
				$path
			); //preg_replace
			
			rename ( $startName, $finishName );
			
		} else if ( $terminalComand === "touch" ) {
			
			// Создание файла
			touch ( $path );
			
		} else if ( $terminalComand === "mkdir" ) {
			
			// Создание директории
			mkdir ( $path );
			
		} else if ( $terminalComand == "ls" ) {
			
			// Вывод информации о дириктории
			$openDirectory = opendir ( $path );
			
			while ( $file = readdir ( $openDirectory ) ) {
				print "$file <br>";
			} //while
			
			closedir ( $openDirectory );
		}
	}
?>

