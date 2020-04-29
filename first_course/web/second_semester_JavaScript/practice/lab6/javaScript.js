function btnDisabled() {
     if (document.fMain.inputText.value == "") {
          document.getElementById("btnResult").disabled = true;
     } else {
          document.getElementById("btnResult").disabled = false;
     }
}

function result() {
     var inputText  = document.fMain.inputText.value.split(' ');
     var editedText;
     var maxLength  = new Number(0);
     var minLength  = new Number(inputText[0].length);

     // search in string. max length| min length | vowels str
     if (document.fMain.rbSearch.value == 1) {
          //search max num
          for (let i = 0; i < inputText.length; i++) {
               if (inputText[i].length > maxLength) {
                    maxLength = inputText[i].length;   
               }
          }//replace vowels
          for(let i = 0; i < inputText.length; i++) {
               if(inputText[i].length == maxLength & document.fMain.changes.checked) {
                    inputText[i] = inputText[i].replace(/[аоиеыэяую]/ig, document.fMain.changeText.value);
               }
          }
     } else if (document.fMain.rbSearch.value == 2) { 
          //search min num
          for (let i = 0; i < inputText.length; i++) {
               if (inputText[i].length < minLength) {
                    minLength = inputText[i].length;
               }
          }//replace vowels
          for(let i = 0; i < inputText.length; i++) {
               if(inputText[i].length == minLength & document.fMain.changes.checked) {
                    inputText[i] = inputText[i].replace(/[аоиеыэяую]/ig, document.fMain.changeText.value);
               }
          }
     } else if (document.fMain.rbSearch.value == 3) {
          //The same number of vowels and consonants
          for(let i = 0; i < inputText.length; i++) {
               let vowels = (inputText[i].match(new RegExp(/[аоиеыэяую]/, 'ig'))||[].length).length;
               let wordLength = inputText[i].length;
              
               if(vowels == 1) {
                     
               } else if (wordLength % vowels === 0) {
                    inputText[i] = inputText[i].replace(/[аоиеыэяую]/ig, document.fMain.changeText.value);
               }
          }
     } else {
          alert("Выберите харак. для выб. в стр.")
     }

     // reincarnation of the words
     if(document.fMain.notSpaces.checked) {
          editedText = inputText.join("");
     } else {
          editedText = inputText.join(" ");
     }

     // number of replacements
     document.fMain.resultText.value = editedText;
     if(document.fMain.counter.checked) {
          document.fMain.quantity.value = (editedText.match(new RegExp(document.fMain.changeText.value, 'gi'))||[].length).length;
     } else {
          document.fMain.quantity.value = "";
     }
     
     

     
     /*
     Метод concat() объединяет две строки:
     var hello = "Привет ";
     var world = "мир";
     hello = hello.concat(world);
     document.write(hello); // Привет мир
     var regexp = /лю/;
     var str ="eee здес что-то будет написано для"
     var array = str.split(' ');
     console.log( str.search( /то/i ) ); // 0
    for(let i = 0; i < array.length; i++) {
          console.log(array[i]);
    }
     var test = ["asd", "asdbbb", "eeeeboy", "else", "good"];
     console.log(test[0]);
     */
}