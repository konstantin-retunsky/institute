
function result(){

     var widthRoom   = document.calculate.widthRoom.value;
     var lengthRoom  = document.calculate.lengthRoom.value;
     var heightRoom  = document.calculate.heightRoom.value;
     var widthRoll   = document.calculate.widthRoll.value;
     var lengthRoll  = document.calculate.lengthRoll.value;

     var elements = document.calculate.getElementsByTagName('input');
     for(let i = 0; i < elements.length-2; i++ ) {
          if(elements[i].value == "") {
     		alert('заполнены не все поля');
               break;
	     } else if (isNaN(elements[i].value) == true) {
               alert('isNaN');
               break;
          } else {
               document.calculate.numberRoll.value = ((widthRoom+lengthRoom)*2)*(heightRoom/(widthRoll*lengthRoll));
          }
     }
}

function test() {

     var widthRoom   = document.calculate.widthRoom.value;
     var lengthRoom  = document.calculate.lengthRoom.value;
     var heightRoom  = document.calculate.heightRoom.value;
     var widthRoll   = document.calculate.widthRoll.value;
     var lengthRoll  = document.calculate.lengthRoll.value;

          if(widthRoom == "" | lengthRoom == ""|
             heightRoom == ""| widthRoll == ""| lengthRoll == "") {
                 document.calculate.btnResult.disabled = true;
          } else {
               document.calculate.btnResult.disabled = false;
          }
}
