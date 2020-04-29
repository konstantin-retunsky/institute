/*1.	Разработайте программу “Фотография”, которая демонстрирует использование компонента Radio. Программа вычисляет стоимость заказа печати фотографий в зависимости от их размера.
2.	Рекомендуемая компоновка формы программы представлена на рисунке.

3.	Значения свойств компонентов radio приведены в таблице.
Свойство	Значение	Цена (Матовая/Глянцевая, руб)
Radio1	9x12	8,5 / 10,0
Radio2	10х15	10,0 / 11,5
Radio2	18х24	15,5 / 17,0
При создании группы переключателей их атрибут name должен иметь одно и то же имя, то есть переключатели образуют группу.
Поскольку переключателей может быть много, то при прикреплении к ним обработчика события надо пробежаться по всему массиву переключателей, который можно получить по имени группы:
for (var i = 0; i < имя_формы.имя_поля.length; i++) {
   if(имя_поля.checked) {выполняемые действия}; }
Каждый переключатель имеет свойство checked, которое возвращает значение true, если переключатель выбран. Например, отметим первый переключатель:
имя_формы.имя_поля[0].checked = true;
4.	Программа должна выдавать сообщение об ошибке, если поле «Количество» заполнено не корректно. Поле «Количество» должно быть с проверкой вводимых данных для предотвращения ввода нечисловых значений. Используйте событие onKeyPress для проверки введенных значений:
onKeyPress = if ((event.keyCode < 48) || (event.keyCode > 57)) event.returnValue = false;
*/
function isNumber(n) {
      return /[\D]/.test(n);
      //  return /^-?[\d.]+(?:e-?\d+)?$/.test(n);
}
function result() {
     // 9x12	8,5 / 10,0
     // 10х15	10,0 / 11,5
     // 18х24	15,5 / 17,0
     var arrPrice_matt   = [8.5, 10, 15.5];
     var arrPrice_glossy = [10, 11.5, 17]

          if(document.pricePhoto.rbPaper[0].checked & !isNumber(document.pricePhoto.textAmount.value)) {
               for(let i = 0; i < 3; i++) {
                    if(document.pricePhoto.rbForm[i].checked) {
                         document.pricePhoto.test.value = "Цена фотографии: " + arrPrice_matt[i] + "р." +
                                                          "\nКоличество:     " + document.pricePhoto.textAmount.value + "шт." +
                                                          "\nСумма заказа:    " + arrPrice_matt[i] * document.pricePhoto.textAmount.value + "р.";
                         break;
                    }
               }
          } else if(document.pricePhoto.rbPaper[1].checked & !isNumber(document.pricePhoto.textAmount.value)) {
               for(let i = 0; i < 3; i++) {
                    if(document.pricePhoto.rbForm[i].checked) {
                         document.pricePhoto.test.value = "Цена фотографии: " + arrPrice_glossy[i] + "р." +
                                                          "\nКоличество:     " + document.pricePhoto.textAmount.value + "шт." +
                                                          "\nСумма заказа:    " + arrPrice_glossy[i] * document.pricePhoto.textAmount.value + "р.";
                         break;
                    }
               }
          }
          else {
               alert(404);
          }
}
