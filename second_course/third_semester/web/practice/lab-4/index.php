<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>lab-4</title>
</head>
<body style="margin: auto;">
<form method="post">
    <div class="input-text" style="width: max-content; margin: auto; margin-top: 150px">
        <label for="word" style="color: red;font-size: 1.5em;">Введите текст:</label>
        <br>
        <textarea cols="80" rows="5" name="input-text" style=" border: 0; color: green; font-size: 1.2em;font-family: "
                  Calibri;">
        Дана строока. Словом текста считается любая последовательность букв русского алфавита; между соседними словами -
        не менее одного пробела, за последним словом – точка. Удалить из строки те слова, которые
        содержат двойные согласные буквы." Теест текста.
        </textarea>
        <hr style="color: red; size: 5px; ">
        <input type="submit" name="button-result" value="result">
    </div>
</form>
</body>
</html>
<?php
	
	//	8
	//    Дана строока. Словом текста считается любая последовательность
	//    букв русского алфавита; между соседними словами - не менее одного
	//    пробела, за последним словом – точка. Удалить из строки те слова, которые
	//    содержат двойные согласные буквы.
	
	$buttonResult = $_POST[ "button-result" ];
	
	if ( isset( $buttonResult ) ) {
		
		$inputText = $_POST[ "input-text" ];
		$patternText = "/((\s+|)[А-я]+)+\.?/u";
		$patternWord = "/[^А-я]+/u";
		$patternVowels = "/([аоиеёэыуюяАОИЕЭЫУЮЯЁ])\1/u";
		echo $inputText . "<br>";
		
		preg_match (
			$patternText,
			$inputText,
			$string
		);
		
		$string = $string[ 0 ];

		
		$words = preg_split (
			$patternWord,
			$string,
			-1
		);
		
		
		for ( $i = 1; $i < count ( $words ); $i++ ) {
			if ( preg_match ( $patternVowels, $words[ $i ] ) ) {
				$inputText = str_replace (
				        $words[$i],
                  "",
                  $inputText
                );
			}
		}
		echo $inputText . "<br>";
	}
?>