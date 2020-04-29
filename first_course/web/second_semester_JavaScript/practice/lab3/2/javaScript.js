
function calcForm() {

     let bool = false;

     for(let i = 0; i < 4; i++) {
          if(document.fMain.rbMC[i].checked ) {
               bool = true;
          } else if(document.fMain.rbAS[i].checked) {
               bool = true;
          } else if(document.fMain.rbPA[i].checked) {
               bool = true;
          } else if(document.fMain.rbNM[i].checked) {
               bool = true;
          }
     }
     if(bool == false & document.fMain.nameTeacher != "") {
          alert(404);
     }

     var beznumber = parseInt(document.fMain.rbMC.value) + parseInt(document.fMain.rbAS.value) + parseInt(document.fMain.rbPA.value) + parseInt(document.fMain.rbNM.value)

     //var test = document.getElementsByClassName('rbclass');
     if(bool == true & document.fMain.nameTeacher.value != "") {
          document.fMain.textArea.value = " Преподаватель: " + document.fMain.nameTeacher.value;
          for (let i = 0; i < 4; i++) {
               if(document.fMain.rbMC[i].checked ) {

                    document.fMain.textArea.value += "\n Полученные оценки: " + document.fMain.rbMC.value;

               }
          }
          for (let i = 0; i < 4; i++) {
               if(document.fMain.rbMC[i].checked ) {

                    document.fMain.textArea.value += " " + document.fMain.rbAS.value;

               }
          }
          for (let i = 0; i < 4; i++) {
               if(document.fMain.rbMC[i].checked ) {

                    document.fMain.textArea.value += " " + document.fMain.rbPA.value;
                    ;
               }
          }
          for (let i = 0; i < 4; i++) {
               if(document.fMain.rbMC[i].checked ) {

                    document.fMain.textArea.value += " " + document.fMain.rbNM.value;

               }
          }
          document.fMain.textArea.value += "\n Общее количество баллов: " + beznumber;
          document.fMain.textArea.value += "\n Качество преподавателя " + beznumber/4;

     } else {
          alert("asd");
     }
}
