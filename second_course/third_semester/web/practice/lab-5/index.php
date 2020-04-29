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

</body>
</html>

<?PHP header("Content-Type: text/html; charset=utf-8"); ?>
<?php
	//	Файл input.txt содержит несколько строк текста. Слова в тексте могут разделяться
	//    пробелами и знаками препинания. Переписать текст в файл output.txt, удалив из него все
	//    слова, начинающиеся и заканчивающиеся одной и той же буквой.
	$pathInput = "input.txt";
	$pathOutput = "output.txt";
	$separateWords = "/[\p{Po}\s]+/u";
	
	if (is_file($pathInput)) {
		$inputFile = file_get_contents($pathInput);
		var_dump($inputFile);
		echo "<br>";
		$words = preg_split(
			$separateWords,
			$inputFile
		); // preg_split
		
		for ($i = 0; $i < count($words); $i++) {
			$charArray = preg_split(
				'//u',
				$words[$i],
				-1,
				PREG_SPLIT_NO_EMPTY
			); // preg_split
			
			if (
				count($charArray) > 1 &&
				$charArray[0] == $charArray[count($charArray) - 1]
			) {
				$inputFile = preg_replace(
					"/" . $words[$i] . "/ui",
					"",
					$inputFile
				); // preg_replace
			}
		}
		
		$createFile = fopen("output.txt", 'w') or die("не удалось создать файл");
  
		fwrite($createFile, $inputFile);
		fclose($createFile);
		
		var_dump($inputFile);
	}
?>