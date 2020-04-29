function ButtonStartCalculation() {
   InsideSidebar();
   DrawingTree();
}

$('#input-text').keypress(function (e) {
   if (e.ctrlKey && e.keyCode == 13) {
      InsideSidebar();
      DrawingTree();
   }
});

// скрытие элементов после старата и создание элементов таблицы в saidbar
function InsideSidebar() {
   $("#form-main").css("display", "none");
   $(".open-btn,.back-btn").css("display", "block");
   $("#clone-text ").text($("#input-text").val());
   document.getElementById("sidebar--table").innerHTML = "";

   let textValue = $("#input-text").val();

   let createTd = document.createElement("tr");

   let createTrCharacters = document.createElement("td");
   let createTrQuantity = document.createElement("td");
   let createTrCharactersCode = document.createElement("td");

   createTrCharacters.textContent = "Символ";
   createTrQuantity.textContent = "Частота";
   createTrCharactersCode.textContent = "Код";

   createTd.appendChild(createTrCharacters);
   createTd.appendChild(createTrQuantity);
   createTd.appendChild(createTrCharactersCode);

   document.getElementById("sidebar--table").appendChild(createTd);


   if ($('.headline').text() == "Алгоритм Шеннона-Фано") {
      let elementsOfShannonFano = ShannonFano(textValue);

      for (let i = 0; i < elementsOfShannonFano[0].length; i++) {

         let createTd = document.createElement("tr");

         let createTrCharacters = document.createElement("td");
         let createTrQuantity = document.createElement("td");
         let createTrCharactersCode = document.createElement("td");

         createTrCharacters.textContent = elementsOfShannonFano[0][i];
         createTrQuantity.textContent = elementsOfShannonFano[1][i];
         createTrCharactersCode.textContent = elementsOfShannonFano[2][i];

         createTd.appendChild(createTrCharacters);
         createTd.appendChild(createTrQuantity);
         createTd.appendChild(createTrCharactersCode);

         document.getElementById("sidebar--table").appendChild(createTd);
      }
   } else if ($('.headline').text() == "Алгоритм Хаффмана") {

      let elementsHuffman = Huffman(textValue);

      for (let i = 0; i < elementsHuffman[0].length; i++) {

         let createTd = document.createElement("tr");

         let createTrCharacters = document.createElement("td");
         let createTrQuantity = document.createElement("td");
         let createTrCharactersCode = document.createElement("td");

         createTrCharacters.textContent = elementsHuffman[0][i];
         createTrQuantity.textContent = elementsHuffman[1][i];
         createTrCharactersCode.textContent = elementsHuffman[2][i];

         createTd.appendChild(createTrCharacters);
         createTd.appendChild(createTrQuantity);
         createTd.appendChild(createTrCharactersCode);

         document.getElementById("sidebar--table").appendChild(createTd);
      }
   }

}


function ChangeAlgorithm() {
   if ($('.headline').text() == "Алгоритм Шеннона-Фано") {
      $('.headline').text("Алгоритм Хаффмана");
   } else if ($('.headline').text() == "Алгоритм Хаффмана") {
      $('.headline').text("Алгоритм Шеннона-Фано");
   }
}
// sidebar toggle
function OpenNav() {
   document.getElementById("mySidebar").style.width = "270px";
   $(".back-btn,.open-btn").css("display", "none");
}

function CloseNav() {
   document.getElementById("mySidebar").style.width = "0";
   $(".back-btn,.open-btn").css("display", "block");
}

// btn exit
function BackButton() {
   $("#form-main").css("display", "block");
   $(".back-btn,.open-btn").css("display", "none");

   document.getElementsByClassName("tree-main")[0].innerHTML = "";
   document.getElementsByClassName("tree-main")[0].remove();
}


// resize textarea
$('#input-text').autoResize();


/*
   Algorithm Shannon Fano
*/
function ShannonFano(textValue) {

   let characters = new Array();
   let charactersCode = new Array();
   let quantity = new Array();

   ArrayFilling(textValue, characters, quantity, charactersCode);
   CharactersEncoding(quantity, characters);
   return [characters, quantity, charactersCode];

   function CharactersEncoding(arrayQuantity, arrayCharacters) {

      let rightCharacters = new Array();
      let leftCharacters = new Array();
      let rightQuantity = new Array();
      let leftQuantity = new Array();
      let halfSum = Math.trunc(SumArray(arrayQuantity) / 2);
      let bubble = 0;

      for (let i = 0; i < arrayQuantity.length; i++) {
         if (bubble < halfSum & i !== arrayQuantity.length - 1) {
            bubble += arrayQuantity[i];

            rightQuantity.push(arrayQuantity[i]);
            rightCharacters.push(arrayCharacters[i]);
            charactersCode[characters.indexOf(arrayCharacters[i])] += "1";
         } else {
            leftQuantity.push(arrayQuantity[i]);
            leftCharacters.push(arrayCharacters[i]);
            charactersCode[characters.indexOf(arrayCharacters[i])] += "0";
         }
      }

      if (rightQuantity.length !== 1) {
         CharactersEncoding(rightQuantity, rightCharacters);
      }

      if (leftQuantity.length !== 1) {
         CharactersEncoding(leftQuantity, leftCharacters);
      }
   }
}

function ArrayFilling(textValue, characters, quantity, charactersCode) {
   for (let i = 0; i < textValue.length; i++) {
      if (!characters.includes(textValue[i])) {
         characters.push(textValue[i]);
         quantity.push(+1);
         charactersCode.push("");
      } else {
         quantity[characters.indexOf(textValue[i])] += 1;
      }
   }
}
function SumArray(array) {
   return array.reduce((a, b) => a + b, 0);
}

/*
   Algorithm Huffman
*/

function Huffman(inputText) {
   let quantity = new Array();
   let characters = new Array();
   let charactersCode = new Array();
   let indexDrawingTree = new Array();
   let arrayBool;
   let arrayToDraw;
   let quantityClone;
   let charactersClone;
   let arrayToDrawQuantity;


   ArrayFilling(inputText, characters, quantity, charactersCode);
   sortBubbleOne();
   arrayToDraw = characters.slice().reverse();
   arrayBool = charactersCode.slice();
   arrayToDrawQuantity = quantity.slice().reverse();
   quantityClone = quantity.slice();
   charactersClone = characters.slice();


   for (let i = 1; i < quantity.length; i++) {

      for (let j = 0; j < charactersClone[0].length; j++) {
         charactersCode[characters.indexOf(charactersClone[0][j])] = "1" + charactersCode[characters.indexOf(charactersClone[0][j])];
      }
      for (let j = 0; j < charactersClone[1].length; j++) {
         charactersCode[characters.indexOf(charactersClone[1][j])] = "0" + charactersCode[characters.indexOf(charactersClone[1][j])];
      }

      indexDrawingTree.push(arrayToDraw.indexOf(charactersClone[0]));
      indexDrawingTree.push(arrayToDraw.indexOf(charactersClone[1]));

      arrayBool[arrayToDraw.indexOf(charactersClone[0])] = 1;
      arrayBool[arrayToDraw.indexOf(charactersClone[1])] = 0;

      charactersClone[1] = charactersClone[0] + charactersClone[1];
      quantityClone[1] = quantityClone[0] + quantityClone[1];


      quantityClone.shift();
      charactersClone.shift();

      arrayBool.push("");
      arrayToDraw.push(charactersClone[0]);
      indexDrawingTree.push(arrayToDraw.indexOf(charactersClone[0]));
      arrayToDrawQuantity.push(quantityClone[0]);
      sortBubbleTwo(quantityClone, charactersClone);
   }


   function sortBubbleTwo(arrayQuantity, arrayCharacters) {
      let temp1;
      let temp2;
      for (let i = arrayQuantity.length - 1; i > 0; i--) {
         let counter = 0;
         for (let j = 0; j < i; j++) {
            if (arrayQuantity[j] > arrayQuantity[j + 1]) {
               temp1 = arrayQuantity[j];
               arrayQuantity[j] = arrayQuantity[j + 1];
               arrayQuantity[j + 1] = temp1;

               temp2 = arrayCharacters[j];
               arrayCharacters[j] = arrayCharacters[j + 1];
               arrayCharacters[j + 1] = temp2;
               counter++;
            }
         }
         if (counter == 0) {
            break;
         }
      }
   };

   function sortBubbleOne() {
      let temp1;
      let temp2;
      let temp3;

      for (let i = quantity.length - 1; i > 0; i--) {
         let counter = 0;
         for (let j = 0; j < i; j++) {
            if (quantity[j] > quantity[j + 1]) {
               temp1 = quantity[j];
               quantity[j] = quantity[j + 1];
               quantity[j + 1] = temp1;

               temp2 = characters[j];
               characters[j] = characters[j + 1];
               characters[j + 1] = temp2;

               temp3 = charactersCode[j];
               charactersCode[j] = charactersCode[j + 1];
               charactersCode[j + 1] = temp3;

               counter++;
            }
         }
         if (counter == 0) {
            break;
         }
      }
   };
   return new Array(characters, quantity, charactersCode, arrayToDraw, arrayToDrawQuantity, arrayBool, indexDrawingTree);
}


function DrawingTree() {

   if ($('.headline').text() == "Алгоритм Шеннона-Фано") {
      /*
      создание массивов для рисовки дерева
      */
      let textValue = $("#input-text").val();
      let elementsOfShannonFano = ShannonFano(textValue);

      //max length stick
      let maxLengthStick = new Number();
      for (let i = 0; i < elementsOfShannonFano[2].length; i++) {
         if (elementsOfShannonFano[2][i].length > maxLengthStick) {
            maxLengthStick = elementsOfShannonFano[2][i].length;
         }
      }

      let mainTree = document.createElement('div');
      let rowTree = document.createElement('div');
      let cellTree = document.createElement('div');
      mainTree.className = "tree-main";
      rowTree.className = "row-tree-" + 1;
      rowTree.style.display = "flex";
      rowTree.style.margin = "auto";
      cellTree.classList = "rows-tree";
      cellTree.style.fontSize = "1em";
      cellTree.innerHTML = "Частота:" + SumArray(elementsOfShannonFano[1]) + "<br>" + "Слово: " + "<span>" + elementsOfShannonFano[0].join("") + "</span>" + "<br>+";
      rowTree.appendChild(cellTree);
      mainTree.appendChild(rowTree);

      let arrStick = new Array();
      let singleStick = "";
      let rightStick = "";
      let leftStick = "";
      let lastElement = elementsOfShannonFano[2][0][0];

      for (let i = 0; i < maxLengthStick; i++) {

         arrStick.push(new Array());

         for (let j = 0; j < elementsOfShannonFano[0].length; j++) {
            if (elementsOfShannonFano[2][j][i] === lastElement & elementsOfShannonFano[2][j][i] !== undefined) {
               singleStick += elementsOfShannonFano[0][j];
            } else if (elementsOfShannonFano[2][j][i] !== lastElement &
               elementsOfShannonFano[2][j][i] !== undefined &
               singleStick.length !== 0) {

               lastElement = elementsOfShannonFano[2][j][i];
               arrStick[i].push(singleStick);
               singleStick = "";
               singleStick += elementsOfShannonFano[0][j];
            } else if (elementsOfShannonFano[2][j][i] === undefined & singleStick.length !== 0) {
               arrStick[i].push(singleStick);
               lastElement = "";
               singleStick = "";
            } else if (singleStick.length === 0 & elementsOfShannonFano[2][j][i] !== undefined) {
               lastElement = elementsOfShannonFano[2][j][i];
               singleStick += elementsOfShannonFano[0][j];
            }
         }
         if (singleStick.length !== 0) {
            arrStick[i].push(singleStick);
            singleStick = "";
         }
      }

      /*
         создается див, внуторь которого создаются дивы в которых находятся элементы деления метода, основной див флексовый, а далее вложенным дивам присваевается номера сторк
      */
      let rowIndex = 2;
      for (let i = 0; i < arrStick.length; i++) {

         rowTree = document.createElement("div");
         rowTree.className = "row-tree-" + rowIndex;
         rowTree.style.display = "flex";
         rowTree.style.margin = "auto";
         rowTree.style.gridRow = rowIndex;
         rowTree.style.width = "max-content";
         rowIndex++;

         for (let j = 0; j < arrStick[i].length; j++) {
            cellTree = document.createElement('div');
            cellTree.classList = "cell-tree";
            cellTree.innerHTML = "Частота: " + ThisSumQuantity(arrStick[i][j]) + "<br>" + "Слово: " + "<span>" + arrStick[i][j] + "</span>" + "<br> +" +
               elementsOfShannonFano[2][elementsOfShannonFano[0].indexOf(arrStick[i][j][0])][rowIndex - 3];
            rowTree.appendChild(cellTree);
         }
         mainTree.appendChild(rowTree);
      }

      function ThisSumQuantity(string) {
         let valueSum = 0;
         for (let i = 0; i < string.length; i++) {
            valueSum += elementsOfShannonFano[1][elementsOfShannonFano[0].indexOf(string[i])];
         }
         return valueSum;
      }

      document.body.appendChild(mainTree);

      let leftAuto = (parseInt(document.documentElement.clientWidth) - parseInt($('.tree-main').width())) / 2;
      $(".tree-main").css("left", leftAuto);

      /*
         чертим линии между ветками
      */

      let canvas = document.createElement("canvas");
      canvas.id = "canvas-drawing-tree";
      canvas.width = $(".tree-main").width();
      canvas.height = $(".tree-main").height();
      canvas.style.position = "absolute";
      let ctx = canvas.getContext("2d");

      let kostil = 0;
      for (let i = rowIndex - 1; i > 0; i--) {
         kostil = i - 1;
         rowTree = $(".row-tree-" + i + " > div > span");
         let rowTreeOneLevelUp = $(".row-tree-" + kostil + " > div > span");
         let rowTreeWidth = $(".row-tree-" + i).children();
         let rowTreeOneLevelUpWidth = $(".row-tree-" + kostil).children();

         for (let j = rowTree.length - 1; j >= 0; j--) {
            let oneWordTree = rowTree[j].textContent;

            for (let k = rowTreeOneLevelUp.length - 1; k >= 0; k--) {
               let oneWordOneLevelUp = rowTreeOneLevelUp[k].textContent;

               if (oneWordOneLevelUp.includes(oneWordTree)) {
                  let RowTreeTop = rowTree[j].offsetTop - 25;
                  let rowTreeLeft = rowTree[j].offsetLeft - 5;

                  let rowTreeTopOneLevelUp = rowTreeOneLevelUp[k].offsetTop + rowTreeOneLevelUpWidth[k].offsetHeight / 2 + 8;
                  let rowTreeLeftOneLevelUp = rowTreeOneLevelUp[k].offsetLeft;

                  ctx.beginPath();
                  ctx.strokeStyle = "#4caf50";
                  ctx.lineWidth = 2;
                  ctx.moveTo(rowTreeLeftOneLevelUp, rowTreeTopOneLevelUp);
                  ctx.lineTo(rowTreeLeft, RowTreeTop);
                  ctx.stroke();
               }
            }
         }
      }

      mainTree.appendChild(canvas);
   } else if ($('.headline').text() == "Алгоритм Хаффмана") {
      let textValue = $("#input-text").val();
      let elementsHuffman = Huffman(textValue);

      // length rows
      let lengthRows = new Array(new Array(), new Array());
      let rowIndex = 1;
      for(let i = 0; i < elementsHuffman[3].length; i++) {
         if(!lengthRows[1].includes(elementsHuffman[3][i].length) ) {
            lengthRows[0].push(rowIndex);
            lengthRows[1].push(elementsHuffman[3][i].length);
            rowIndex++;
         }
      }

      // creating line items
      let mainTree = document.createElement('div');
      let rowTree = document.createElement('div');
      document.body.appendChild(mainTree);
      mainTree.className = "tree-main";

      for(let i = 0; i < lengthRows[0].length; i++ ) {
         rowTree = document.createElement('div');
         rowTree.className = "row-tree-" + lengthRows[0][i];
         rowTree.style.display = "flex";
         rowTree.style.margin = "auto";
         mainTree.appendChild(rowTree);
      }

      for(let i = 0; i < elementsHuffman[3].length;i++) {
         let cellTree = document.createElement('div');
         cellTree.classList = "rows-tree";
         cellTree.style.fontSize = "1em";
         for(let j = 0; j < lengthRows[0].length; j++) {
            if(lengthRows[1][j] == elementsHuffman[3][i].length) {
               rowTree = document.getElementsByClassName("row-tree-" + lengthRows[0][j])[0];
            }
         }
         cellTree.innerHTML = "Частота: " + elementsHuffman[4][i] + "<br>" + "Слово: " + "<span>" + elementsHuffman[3][i] + "</span>" + "<br>+" + elementsHuffman[5][i];

         rowTree.appendChild(cellTree);
      }

      let leftAuto = (parseInt(document.documentElement.clientWidth) - parseInt($('.tree-main').width())) / 2;
      $(".tree-main").css("left", leftAuto);

      /*
         чертим линии между ветками
      */

      let canvas = document.createElement("canvas");
      canvas.id = "canvas-drawing-tree";
      canvas.width = $(".tree-main").width();
      canvas.height = $(".tree-main").height();
      canvas.style.position = "absolute";
      let ctx = canvas.getContext("2d");


      let elementsHtmlTreeMain =  $(".tree-main > div > .rows-tree");

      let kostil1 = 0;
      let kostil2 = 0;

      let indexOne = 0;
      let indexTwo = 1;
      let indexThree = 2;
      for(let i = 0 ; i < elementsHuffman[6].length / 3; i++) {

         ctx.strokeStyle = "#4caf50";
         ctx.lineWidth = 2;

         let oneElementPositionTop = elementsHtmlTreeMain[elementsHuffman[6][indexOne]].offsetTop + 68;
         let oneElementPositionLeft = elementsHtmlTreeMain[elementsHuffman[6][indexOne]].offsetLeft + 50;

         let twoElementPositionTop = elementsHtmlTreeMain[elementsHuffman[6][indexTwo]].offsetTop + 68;
         let twoElementPositionLeft = elementsHtmlTreeMain[elementsHuffman[6][indexTwo]].offsetLeft + 50;

         let bottomElementPosotionTop = elementsHtmlTreeMain[elementsHuffman[6][indexThree]].offsetTop;
         let bottomElementPosotionLeft = elementsHtmlTreeMain[elementsHuffman[6][indexThree]].offsetLeft + 50;


         ctx.beginPath();
         ctx.moveTo(oneElementPositionLeft, oneElementPositionTop);
         ctx.lineTo(bottomElementPosotionLeft, bottomElementPosotionTop);
         ctx.stroke();

         ctx.beginPath();
         ctx.moveTo(twoElementPositionLeft, twoElementPositionTop);
         ctx.lineTo(bottomElementPosotionLeft, bottomElementPosotionTop);
         ctx.stroke();
         console.log(elementsHtmlTreeMain[elementsHuffman[6][i]]);
         console.log(elementsHtmlTreeMain[elementsHuffman[6][i + 1]]);
         console.log(elementsHtmlTreeMain[elementsHuffman[6][i + 2]]);
         console.log("i = " + i );
         indexOne += 3;
         indexTwo += 3;
         indexThree += 3;
      }

      mainTree.appendChild(canvas);
   }
}
