
function finalPrice() {
     let itemList_lang = document.getElementById("languages");
     let collection_lang = itemList_lang.selectedOptions;
     var temp = 0;
     var arrPrice = new Array(400 ,400 , 500, 500, 600, 800);

     if(document.getElementById('fMain').time.value != "") {
          document.fMain.outputTextarea.value = "Для изучения выбран : \n";
          for (var i = 0; i < collection_lang.length; i++) {
               document.fMain.outputTextarea.value += collection_lang[i].label + "язык по " + arrPrice[document.getElementById("experience").selectedIndex] + "руб. за час\n";
          }
          for(let i = 0; i < collection_lang.length; i++) {
               temp += arrPrice[document.getElementById("experience").selectedIndex];
               //console.log(parseInt(collection_lang[i].value));
          }
          document.fMain.outputTextarea.value += "итого:" + (temp * document.fMain.time.value);
     } else {
          alert("CHOTA NI TAK");
     }
     /*
               for (var i = 0; i < collection_lang.length; i++) {
                    document.fMain.outputTextarea.value += collection_lang[i].label + "язык по " + arrPrice[i] + "руб. за час\n";
                    temp += arrPrice[i];
                    console.log(arrPrice[i]);
               }

     if (document.getElementById('fMain').time.value != "") {
          document.fMain.outputTextarea.value = "Для изучения выбран : \n";
          document.fMain.outputTextarea.value += "итого:" + (temp * document.fMain.time.value);
     } else {
          alert("CHOTA NI TAK");
     }
     */
}


function priсpreOne_hour() {
     if (document.getElementById("experience").selectedIndex < 2) {
          document.fMain.cost.value = "400 руб.";
     } else if (document.getElementById("experience").selectedIndex < 4) {
          document.fMain.cost.value = "500 руб.";
     } else if (document.getElementById("experience").selectedIndex < 5) {
          document.fMain.cost.value = "600 руб.";
     } else {
          document.fMain.cost.value = "800 руб.";
     }
}

function isNumber(n) {
     return /[\D]/.test(n);
}

function calcDisabled() {
     if (!isNumber(document.getElementById('fMain').time.value)) {
          document.getElementById('fMain').calc.disabled = false;
     } else {
          alert("MOJNA TOLKA CIFRI")
     }
}
