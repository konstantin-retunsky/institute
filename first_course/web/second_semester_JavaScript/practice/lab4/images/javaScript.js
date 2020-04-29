var arrPrice = new Array(451000, 1200, 4500, 12000, 16000);
var arr = new Array();

function textArea() {
     var sum = new Number(0);
     var temp = new Number(0);
     for(let i = 0; i < 5; i++ ) {

          if(document.getElementsByTagName('input')[i].checked){
               document.fMain.textAreaasd.value += +arrPrice[i];
               temp++;
               sum += +arrPrice[i];
          }
          if(sum == 484700) {
               sum = 436230;
          }
     }

     for(let i = 0; i < 5; i++) {
          if(document.getElementsByTagName('input')[i].checked & !arr.includes(i)) {
                    arr.push(i);
          }
     }
     for(let i = 0; i< arr.length; i++) {
          console.log(arr[i]);
     }


     document.fMain.textAreaasd.value = sum;
}
function calc() {
     let result = "";
     arrProduct = new Array("Базовая комплектация: ","Коврики: ", "Защита картера: ","Зимние шины: ","Литые диски: ");
     for(let i = 0; i < 5; i++) {
          if(document.getElementsByTagName('input')[i].checked) {
               result += arrProduct[i] + arrPrice[i] + "\n";
          }
     }
     alert(result);
}


function chboxImg1() {
     if (document.getElementsByTagName('input')[0].checked) {
          document.getElementById('imgAuto').style.visibility = "visible";
          document.getElementById('imgProtect').style.visibility = "hidden";
          document.getElementById('imgMat').style.visibility = "hidden";
          document.getElementById('imgTeres').style.visibility = "hidden";
          document.getElementById('imgDiscs').style.visibility = "hidden";
     } else {
          document.getElementById('imgAuto').style.visibility = "hidden";
     }
}
function chboxImg2() {
     if (document.getElementsByTagName('input')[1].checked) {
          document.getElementById('imgMat').style.visibility = "visible";
          document.getElementById('imgProtect').style.visibility = "hidden";
          document.getElementById('imgAuto').style.visibility = "hidden";
          document.getElementById('imgTeres').style.visibility = "hidden";
          document.getElementById('imgDiscs').style.visibility = "hidden";
     } else {
          document.getElementById('imgMat').style.visibility = "hidden";
     }
}
function chboxImg3() {
     if (document.getElementsByTagName('input')[2].checked) {
          document.getElementById('imgProtect').style.visibility = "visible";
          document.getElementById('imgMat').style.visibility = "hidden";
          document.getElementById('imgAuto').style.visibility = "hidden";
          document.getElementById('imgTeres').style.visibility = "hidden";
          document.getElementById('imgDiscs').style.visibility = "hidden";
     } else {
          document.getElementById('imgProtect').style.visibility = "hidden";
     }
}
function chboxImg4() {
     if (document.getElementsByTagName('input')[3].checked) {
          document.getElementById('imgTeres').style.visibility = "visible";
          document.getElementById('imgProtect').style.visibility = "hidden";
          document.getElementById('imgAuto').style.visibility = "hidden";
          document.getElementById('imgMat').style.visibility = "hidden";
          document.getElementById('imgDiscs').style.visibility = "hidden";
     } else {
          document.getElementById('imgTeres').style.visibility = "hidden";
     }
}
function chboxImg5() {
     if (document.getElementsByTagName('input')[4].checked) {
          document.getElementById('imgDiscs').style.visibility = "visible";
          document.getElementById('imgProtect').style.visibility = "hidden";
          document.getElementById('imgAuto').style.visibility = "hidden";
          document.getElementById('imgTeres').style.visibility = "hidden";
          document.getElementById('imgMat').style.visibility = "hidden";
     } else {
          document.getElementById('imgDiscs').style.visibility = "hidden";
     }
}
