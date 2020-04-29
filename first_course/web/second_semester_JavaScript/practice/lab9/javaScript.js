function result() {

   var fonts = ["italic", "bold", "underline"];
   var pic = [
      ["malevich-1.jpg", "malevich-2.jpg", "malevich-3.jpg"],
      ["escher-1.jpg", "escher-2.jpg", "escher-3.jpg"],
      ["milligan-1.jpg", "milligan-2.jpg", "milligan-3.jpg"],
   ];

   // ну шо, создадим левое окошко ? ;D

   var win = window.open("", "win", 'top=100, left=500,width=500, height=550', "scrollbars=no");

   // Костыль
   if (win.document.body.childElementCount > 0) {
      win.close();
      var win = window.open("", "win", 'top=100, left=500,width=500, height=550', "scrollbars=no");
   }

   win.document.write('<html><head><title>ПИКЧА ЕЕ</title><link rel="stylesheet" type="text/css" href="style.css"></head><body>');

   var mainDiv = win.document.createElement('div');
   var headline = win.document.createElement("span");
   var img = win.document.createElement("img");
   var btn = win.document.createElement("button");
   var text = document.createTextNode(document.fMain.input.value);

   // кнопка
   btn.innerHTML = "Close";
   btn.onclick = function () {
      win.close();
      //mainDiv.parentNode.removeChild(mainDiv);
   }

   //курсив
   if (document.fMain.chbFontItalics.checked) {
      headline.style.fontStyle = "italic";
   } else {
      headline.style.fontStyle = "normal";
   }

   //Подчеркивание
   if (document.fMain.chbTextDecoration.checked) {
      headline.style.textDecoration = "underline";
   } else {
      headline.style.textDecoration = "none";
   }

   //Жирный
   if (document.fMain.chbFontBold.checked) {
      headline.style.fontWeight = "bold";
   } else {
      headline.style.fontWeight = "normal";
   }

   img.src = "img/" + pic[document.fMain.painter.value][document.fMain.radio.value];
   mainDiv.id = 'mainDiv';
   win.document.body.style.backgroundColor = "greenyellow";

   headline.appendChild(text);
   mainDiv.appendChild(headline);
   mainDiv.appendChild(img);
   mainDiv.appendChild(btn);
   win.document.body.appendChild(mainDiv);

   //console.log(document.body.childElementCount);
   // создание левого дива

   //костыль
   if(document.body.childElementCount > 2) {
      //document.getElementById('mainDiv').parentNode.removeChild(mainDiv);
      //document.getElementsByTagName('div').parentNode.removeChild(mainDiv);
      console.log(document.getElementById('mainDiv'));
      document.getElementById('mainDiv').remove();
      console.log("asd");
   }
   

   mainDiv = document.createElement('div');
   headline = document.createElement("span");
   img = document.createElement("img");
   btn = document.createElement("button");
   text = document.createTextNode(document.fMain.input.value);

   // кнопка
   btn.innerHTML = "Close";

   btn.onclick = function () {
      //win.close();
      mainDiv.parentNode.removeChild(mainDiv);
   }

   //курсив
   if (document.fMain.chbFontItalics.checked) {
      headline.style.fontStyle = "italic";
   } else {
      headline.style.fontStyle = "normal";
   }

   //Подчеркивание
   if (document.fMain.chbTextDecoration.checked) {
      headline.style.textDecoration = "underline";
   } else {
      headline.style.textDecoration = "none";
   }

   //Жирный
   if (document.fMain.chbFontBold.checked) {
      headline.style.fontWeight = "bold";
   } else {
      headline.style.fontWeight = "normal";
   }

   img.src = "img/" + pic[document.fMain.painter.value][document.fMain.radio.value];
   mainDiv.id = 'mainDiv';
   mainDiv.style.backgroundColor = "greenyellow";

   headline.appendChild(text);
   mainDiv.appendChild(headline);
   mainDiv.appendChild(img);
   mainDiv.appendChild(btn);
   document.body.appendChild(mainDiv);
}