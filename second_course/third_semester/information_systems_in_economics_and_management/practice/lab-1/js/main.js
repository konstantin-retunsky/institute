



$('#create-table').click(function () {
  CreateOneTable();
  CreateTwoTable();
}); //click

function CreateTwoTable() {
  let inputSize = parseInt($('#input-size-matrix').val());
  for (let i = 0; i < inputSize + 4; i++) {
    $(".two-table").append("<tr id=table-two-tr-" + i + "></tr>");
  }

  $('#table-two-tr-0').append("<td rowspan='2'> Группа показателей сравниваемых вариантов</td>  <td colspan='3'>Автоматизированный способ</td>    <td colspan='3'>Неавтоматизированный Способ </td>");
  $('#table-two-tr-1').append("<td>баллы</td><td>индекс балло-зна-чимости</td><td>взвешен-ный балл</td><td>баллы</td><td>Индекс балло-знa-чимости</td><td>взвешен-ный балл</td>");

  for( let i = 1; i < 8; i++) {
    $('#table-two-tr-2').append("<td>" + i + "</td>");  
  }

  let lengthRow = inputSize + 4;

  for( let i = 3; i < inputSize + 4; i++ ) {
    for( let j = 0; j < 7; j++ ) {
      if(i === lengthRow - 1) {
        if(j === 3 | j === 6) {
          $('#table-two-tr-' + i).append("<td > <input type='number' disabled style='width: 50px;' id='table-two-" + i + "-" + j + "'> </td>");    
        } else {
          $('#table-two-tr-' + i).append("<td ></td>");  
        }
      } else if( j === 0 ) {
        $('#table-two-tr-' + i).append("<td > <input type='text' id='table-two-" + i + "-" + j + "'> </td>");  
      } else if ( j === 1 | j === 4 ) {
        $('#table-two-tr-' + i).append("<td > <input type='number' style='width: 50px;' id='table-two-" + i + "-" + j + "'> </td>");  
        $("#table-two-" + i + "-" + j ).change(function (){
          if( $( "#table-two-" + i + "-" + j ).val() >= 10 ) {
            $("#table-two-" + i + "-" + j ).css("box-shadow", "0 0 10px red");
          } else {
            $("#table-two-" + i + "-" + j ).css("box-shadow", "0 0 10px green");
          }
        });
      } else {
        $('#table-two-tr-' + i).append("<td > <input type='text' style='width: 50px;' disabled id='table-two-" + i + "-" + j + "'> </td>");  
      }
    }
  }
}

function CreateOneTable() {
  let inputSize = parseInt($('#input-size-matrix').val());
  let regexIsNum = /^\d+$/;

  if (regexIsNum.test(inputSize)) {
    $('#calculate').prop('disabled', false);

    if ($('.one-table').children().length !== 0) {
      $('.one-table').empty();
    }

    let inputSize = parseInt($('#input-size-matrix').val());
    for (let i = 0; i < inputSize + 3; i++) {
      $(".one-table").append("<tr id=tr-" + i + "></tr>");
    }

    $('#tr-0').append("<td rowspan='2'>Группа показателей</td>  <td colspan='" + inputSize + "'>Группы показателей</td>    <td rowspan='2'>Сумма ряда</td>    <td rowspan='2'>Индекс балло-значимости</td>");
    $('#tr-' + ( inputSize + 2 )).append( '<td colspan="' + ( inputSize + 1 ) + '"></td><td><input disabled style="width: 50px;" type="text" id="total-1" ></td><td><input style="width: 50px;" disabled type="text" id="total-2" ></td>');

    for (let i = 0; i < inputSize; i++) {
      $('#tr-1').append("<td>" + (i + 1) + "</td>");
    }

    for (let i = 0; i < inputSize; i++) {

      let indexMatrix = i + 2;

      for (let j = 0; j < inputSize + 3; j++) {
        if ((inputSize) < j) {
          $('#tr-' + indexMatrix ).append("<td><input disabled style='width: 50px;' type='text' id='text-box-" + i + "-" + j + "'></td>");
        } else {

          $('#tr-' + indexMatrix ).append("<td><input style='width: 50px;' type='text' id='text-box-" + i + "-" + j + "'></td>");
        }

        if (i === (j - 1)) {

          $('#text-box-' + i + "-" + j).val(0);
          $('#text-box-' + i + "-" + j).prop('disabled', true);
        } else if ((i !== j - 1 & j !== 0)) {
          $('#text-box-' + i + "-" + j).change(function () {
            let ij_Plus_ji = parseInt($('#text-box-' + i + "-" + j).val()) + parseInt($('#text-box-' + (j - 1) + "-" + (i + 1)).val());

            if (ij_Plus_ji !== 10) {
              $('#text-box-' + i + "-" + j).css("box-shadow", "0 0 10px red");
              $('#text-box-' + (j - 1) + "-" + (i + 1)).css("box-shadow", "0 0 10px red");
            } else {
              $('#text-box-' + i + "-" + j).css("box-shadow", "0 0 10px green");
              $('#text-box-' + (j - 1) + "-" + (i + 1)).css("box-shadow", "0 0 10px green");
            }
          });
        }
      }
    }
  } else {
    $('#calculate').prop('disabled', true);
    alert("Введите целочисленное число");
  }
} //CreateOneTable

$('#calculate-two').click( function () {
  // table-two-3-1
  // table-two-3-2
  let inputSize = parseInt($('#input-size-matrix').val());
  let sumOne = 0;
  let sumTwo = 0;

  for(let i = 3; i < inputSize + 3; i++ ) {
    let textBox1 =  $("#table-two-" + i + "-1").val() ;
    let textBox2 =  $("#table-two-" + i + "-2").val() ;
    $("#table-two-" + i + "-3").val( (Math.round(textBox1 * textBox2 * 100) / 100));
    sumOne += textBox1 * textBox2;

    let textBox3 =  $("#table-two-" + i + "-4").val();
    let textBox4 =  $("#table-two-" + i + "-5").val();
    $("#table-two-" + i + "-6").val( (Math.round(textBox3 * textBox4 * 100) / 100));
    sumTwo += textBox3 * textBox4;
  }
  $("#table-two-" + ( inputSize + 3 ) + "-3").val(sumOne);
  $("#table-two-" + ( inputSize + 3 ) + "-6").val(sumTwo);

  let result = Math.round( sumOne / sumTwo * 100 - 100 ) ;
  if( result >= 0 ) {
    $( '.main' ).append("<p id='result'>" + 'Таким образом,  по автоматизированному варианту сумма взвешенных баллов составляет ' + sumOne + ' - это на ' + result + '% больше cуммы взвешенных баллов неавтоматизированного варианта, а следовательно, автоматизация данных функций оправдана' + "</p>");
  } else {
    $( '.main' ).append("<p id='result'>" + 'Таким образом, по автоматизированному варианту сумма взвешенных баллов составляет ' + sumOne + ' - это на ' + Math.abs(result) + '% меньше cуммы взвешенных баллов неавтоматизированного варианта, а следовательно, автоматизация данных функций не оправдана' + "</p>");
  }
  console.log(Math.round(58.23232323));
  console.log(Math.round(result));
  console.log(result);

  
  

  
  
});

$('#calculate').click(function () {

  

  let inputSize = parseInt($('#input-size-matrix').val());
  let checkedIsTextBox = true;
  for (let i = 0; i < inputSize; i++) {
    for (let j = 1; j < inputSize + 1; j++) {
      if (i !== j - 1) {
        let ij_Plus_ji = parseInt($('#text-box-' + i + "-" + j).val()) + parseInt($('#text-box-' + (j - 1) + "-" + (i + 1)).val());
        if (ij_Plus_ji !== 10) {
          checkedIsTextBox = false;
        }
      }
    }
  }
  
  
  
  if (!checkedIsTextBox) {
    alert("Данные введены некорректно");
  } else {

    let sumAllLine = 0;
    let arraySumLine = new Array();

    for (let i = 0; i < inputSize; i++) {
      let sumLine = 0;
      for (let j = 1; j <= inputSize; j++) {
        sumLine += parseInt($('#text-box-' + i + "-" + j).val());

      }
      arraySumLine.push(sumLine);
      sumAllLine += sumLine;
      $('#text-box-' + i + "-" + (inputSize + 1)).val(sumLine);
    }
    $('#total-1').val(sumAllLine);
    $('#total-2').val("1.00");

    for (let i = 0; i < inputSize; i++) {
      let output = arraySumLine[i] / sumAllLine;
      $('#text-box-' + i + "-" + (inputSize + 2)).val(Math.round(output * 100) / 100);

    }
    for( let i = 3; i < inputSize + 3; i++) {
      let output = arraySumLine[i - 3] / sumAllLine;
      $("#table-two-" + i + "-" + 2).val(Math.round(output * 100) / 100);
      $("#table-two-" + i + "-" + 5).val(Math.round(output * 100) / 100);
    }
    
    for (let i = 3; i < inputSize + 3; i++) {    
      $('#table-two-' + i + "-" + 0).val( $('#text-box-' + ( i - 3 ) + "-" + 0).val() );
    }

    
  }
}); //$('#calculate').click(function())

// <table class="one-table">
//   <tr>
//     <td rowspan="2">Группа показателей<br /></td>
//     <td colspan="4">Группы показателей<br /></td>
//     <td rowspan="2">Сумма ряда<br /></td>
//     <td rowspan="2">Индекс балло-значимости <br /></td>
//   </tr>
//   <tr>
//     <td>1</td>
//     <td>2</td>
//     <td>3</td>
//     <td>4</td>
//   </tr>
//   <tr>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//   </tr>
//   <tr>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//   </tr>
//   <tr>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//   </tr>
//   <tr>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//     <td></td>
//   </tr>
//   <tr>
//     <td colspan="5"></td>
//     <td></td>
//     <td></td>
//   </tr>
// </table>