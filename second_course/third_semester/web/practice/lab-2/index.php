<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>lab-2</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>

<form method="post" style="margin: auto;width: min-content">

    <label for="size-array" >Введите размерность массива</label>
    <input type="text" name="size-array" id="">

    <br>

    <label for="range">Введите диапазон</label>
    <input type="text" name="range" id="">


    <input type="submit" name="done" value="calc">
</form>
</body>
</html>

<?php

    $lengthRandomNumbers = $_POST["size-array"];
    $rangeTextValue = $_POST['range'];
    $patternCheck = "/^(\d|\-){1}(?# первое вхождение числа, отрицатеьлны и не отрицательны )((\d+(\,|\.){1}\d+)|\d{0,})(?# числа могут быть дробными)((\D{1}\-{1})|\D{1})(?# середина может включать разделитель и \-)((\d+(\,|\.){1}\d+)$|\d+$)(?# числа так же могут быть дробными, ну и конечно же проверка на что-бы оканчивалось на число)/";
    $buttonDone = $_POST['done'];

    // заполнение массива заданной рандомными числами, диапазон и длина массива вводит пользователь
    if (isset($buttonDone) &
        $lengthRandomNumbers > 0 &
            preg_match($patternCheck, $rangeTextValue )   ) {

        $randomNumbers = array();
        $randomRange = preg_split("/(?<=\d)(?!\,|\.)\D{1}/", $rangeTextValue);

        for($i = 0; $i < $lengthRandomNumbers; $i++) {
            array_push($randomNumbers, rand($randomRange[0], $randomRange[1]));
        }

        $minNumber       = $randomNumbers[0];
        $sumBubble       = 0;
        $sum             = 0;
        $negativeNumbers = array();
        $positiveNumbers = array();

        for ($i = 0; $i < count( $randomNumbers); $i++){

            // Преобразовать массив таким образом, чтобы сначала располагались все элементы, модуль которых не превышает единицу, а потом — все остальные.
            if(abs( $randomNumbers[$i]) <= 1) {
                array_push($negativeNumbers, $randomNumbers[$i]);
            } else {
                array_push($positiveNumbers, $randomNumbers[$i]);
            }

            // минимальное число
            if($minNumber > $randomNumbers[$i]) {
                $minNumber = $randomNumbers[$i];
            }

            // Сумму элементов массива, расположенных между первым и вторым отрицательными элементами
            if($randomNumbers[$i] < 0) {
                $sumBubble++;
                continue;
            }
            if($sumBubble == 1) {
                $sum += $randomNumbers[$i];
            }
        }

        echo "Начальный массив:";
        echo "<br>";
        print_r($randomNumbers);
        echo "<br>";

        echo "Минимальное число:";
        echo "<br>";
        print_r($minNumber);
        echo "<br>";

        echo "Сумму элементов массива, расположенных между первым и вторым отрицательными элементами:";
        echo "<br>";
        print_r($sum);
        echo "<br>";

        echo "Преобразовать массив таким образом, чтобы сначала располагались все элементы, модуль которых не превышает единицу, а потом — все остальные:";
        echo "<br>";
        print_r(array_merge($negativeNumbers, $positiveNumbers));

    } else  {
        print_r("Ошибка");
    }

?>
