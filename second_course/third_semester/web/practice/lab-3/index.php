<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>lab-3</title>


</head>
<body style="margin: auto; color: #999999; background-color: rgb(51,51,51)">

    <form method="post" style="width: 500px; margin: auto; margin-top: 100px; border: solid 1px #999999; padding: 40px; text-align: center;">
        <label for="size-array">текстовое поле для ввода размерности массива:</label>
        <br>
        <input type="text" name="size-array" style="border: solid 0px #999999;">
        <br>
        <label for="range-numbers">текстовое поле для установки диапазона значений элементов:</label>
        <br>
        <input type="text" name="range-numbers" style="border: solid 0px #999999;">
        <br>
        <input type="submit" name="done" value="calc" style="margin-top: 10px;width: 100px; height: 30px; background-color: #999999; border: 0px; border-radius: 5px 5px 5px 5px; color: blanchedalmond; cursor: pointer;">
    </form>

</body>
</html>


<?php

    $sizeArray = $_POST["size-array"];
    $buttonDone = $_POST['done'];
    $rangeNumbers = $_POST['range-numbers'];
    $patternCheckRange = "/^(\d|\-){1}(?# первое вхождение числа, отрицатеьлны и не отрицательны )((\d+(\,|\.){1}\d+)|\d{0,})(?# числа могут быть дробными)((\D{1}\-{1})|\D{1})(?# середина может включать разделитель и \-)((\d+(\,|\.){1}\d+)$|\d+$)(?# числа так же могут быть дробными, ну и конечно же проверка на что-бы оканчивалось на число)/";
    $patternCheckSize = "/(?<=\d)(?!\,|\.)\D{1}/";

    if(isset($buttonDone) &
        preg_match($patternCheckRange, $rangeNumbers ) &
            preg_match($patternCheckSize, $sizeArray)      ) {

        $patternSplitSizeArray = "/\D{1}(?# делим через все кроме цифр)/";
        $patternSplitRangeNumbers = "/(?<=\d)(?!\,|\.)\D{1}(?# деление с учетом отрицательных чисел)/";
        $sizeArray = preg_split($patternSplitSizeArray, $sizeArray);
        $rangeNumbers = preg_split($patternSplitRangeNumbers, $rangeNumbers);

        $arrayRandomNumbers = array( array(), array() );

        echo "<table style='margin: auto; margin-top: 40px;'>";

        $maxNum = array(0,"");
        for($i = 0; $i < (int)$sizeArray[0]; $i++) { // sizeArray[0]  => первое введенное число => строки
            echo "<tr>";
            for($j = 0; $j < (int)$sizeArray[1]  ; $j++) { // sizeArray[1]  => второе введенное число => колоны

                $arrayRandomNumbers[$i][$j] =  rand($rangeNumbers[0], $rangeNumbers[1]);
                $rgb = rand(0, 255) . "," . rand(0, 255) . "," . rand(0, 255);
                $randomColor = "rgb(" . $rgb . ")" ;
                $randomColorBackground =  "rgba(" . $rgb . ",0.2" . ")";

                echo "<td style='width: 30px; height: 30px; text-align: center; color:" . $randomColor . "; background-color: " . $randomColorBackground . "; border: solid 1px " . $randomColor . ";'>";
                    echo $arrayRandomNumbers[$i][$j];
                    if( $j == (int)$sizeArray[1] - $i - 1 &
                            $maxNum[0] < $arrayRandomNumbers[$i][$j]) {

                            $maxNum[0] = $arrayRandomNumbers[$i][$j];
                            $maxNum[1] =  "строка: " . ($i+1)."<br>"."столбец: " . ($j+1);
                    }
                echo "</td>";
            }
            echo "</tr>";
        }

        echo "</table>";

        echo "<div style='width: max-content; margin: auto; margin-top: 50px; border: #999999 1px solid; padding: 20px 70px;'>";
            echo  "максимальное число: " . $maxNum[0] . "<br>" . $maxNum[1];
        echo "</div>";


//        var_dump($sizeArray);
//        echo "<br>";
//        var_dump($rangeNumbers);
//        echo "<br>";
//        var_dump($arrayRandomNumbers);
    }

?>