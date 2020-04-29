var arrPrice = new Array(451000, 1200, 4500, 12000, 16000);
var arrIndex = new Array();
var arrName_id = new Array('imgAuto', 'imgMat', 'imgProtect', 'imgTeres', 'imgDiscs');

function textArea() {
     var sum = new Number(0);
     var temp = new Number(0);

     for (let i = 0; i < 5; i++) {
          if (document.getElementsByTagName('input')[i].checked) {
               document.fMain.textAreaasd.value += +arrPrice[i];
               temp++;
               sum += +arrPrice[i];
          }
     }
     if (sum == 484700) {
          sum = 436230;
     }

     for (let i = 0; i < document.getElementsByTagName('input').length - 2; i++) {
          if (document.getElementsByTagName('input')[i].checked & !arrIndex.includes(i)) {
               arrIndex.push(i);
          }
     }

     for (let i = 0; i < arrIndex.length; i++) {
          document.getElementById(arrName_id[arrIndex[i]]).style.visibility = "visible";
          document.getElementById(arrName_id[arrIndex[i]]).style.zIndex = i;
     }

     for (let i = 0; i < arrIndex.length; i++) {
          if (!document.getElementsByTagName('input')[arrIndex[i]].checked) {
               arrIndex.splice(i, 1);
          }
     }

     for (let i = 0; i < document.getElementsByTagName('input').length - 2; i++) {
          if (document.getElementsByTagName('input')[i].checked == false) {
               document.getElementById(arrName_id[i]).style.visibility = "hidden";
               document.getElementById(arrName_id[i]).style.zIndex = 1;
          }

     }

     for (let i = 0; i < arrIndex.length; i++) {
          console.log(arrIndex[i]);
     }
     console.log("\n\n");

     document.fMain.textAreaasd.value = sum;
}

function calc() {
     let result = "";
     arrProduct = new Array("Базовая комплектация: ", "Коврики: ", "Защита картера: ", "Зимние шины: ", "Литые диски: ");

     for (let i = 0; i < 5; i++) {
          if (document.getElementsByTagName('input')[i].checked) {
               result += arrProduct[i] + arrPrice[i] + "\n";
          }
     }
     alert(result);
} 