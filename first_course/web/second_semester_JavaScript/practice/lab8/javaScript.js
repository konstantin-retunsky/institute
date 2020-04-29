function check() {

   // Фамилия Имя Отчество (текстовое поле от 3-х до 40 символов без цифр, первая буква каждого слова заглавная)
   // checked radio
   //Адрес (текстовое поле в формате г. XXXXX, ул. XXXXX, кв. XXX)
   //Адрес электронной почты
   var fullName = (document.fMain.fullName.value.match(new RegExp(/[А-Я]/g)) || []).length;
   var address = (document.fMain.address.value.match(new RegExp(/(г.|ул.|кв.)+\s+\S+/g)) || []).length;
   var phone = (document.fMain.phone.value.match(new RegExp(/\d/g)) || []).length;
   var email = /^[A-z\d\.]+@[A-z]+\.([a-z]{2,5})$/;
   var quantity = !(/\D/.test(document.fMain.quantityProduct.value));
   if (document.fMain.snils.value.length > 8) {
      var snils = document.fMain.snils.value.match(/\d/g).join("");
   }

   if (document.fMain.fullName.value.length >= 3 &
      document.fMain.fullName.value.length <= 40 &
      fullName >= 3 &
      address >= 3 &
      phone == 11 &
      email.test(document.fMain.email.value) &
      quantity &
      document.fMain.quantityProduct.value != "" &
      document.fMain.radioTown.value != "" &
      checkSnils(snils)) {
      document.fMain.send.disabled = false;
   } else {
      document.fMain.send.disabled = true;
   }
 
   /* некрасиваю часть кода :D*/ {
      // red for fullName
      if (document.fMain.fullName.value.length >= 3 &
         document.fMain.fullName.value.length <= 40 &
         fullName >= 3) {
         document.fMain.fullName.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.fullName.style.boxShadow = "0px 0px 5px red";
      }

      //red for address 
      if (address == 3) {
         document.fMain.address.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.address.style.boxShadow = "0px 0px 5px red";
      }

      //red for phone
      if (phone >= 11) {
         document.fMain.phone.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.phone.style.boxShadow = "0px 0px 5px red";
      }

      //red for  quantity
      if (quantity & document.fMain.quantityProduct.value != "") {
         document.fMain.quantityProduct.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.quantityProduct.style.boxShadow = "0px 0px 5px red";
      }

      // red for  email
      if (email.test(document.fMain.email.value)) {
         document.fMain.email.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.email.style.boxShadow = "0px 0px 5px red";
      }

      // red for  radioTown
      if (document.fMain.radioTown.value != "") {
         for(let i = 0; i < document.fMain.radioTown.length; i++) {
            document.fMain.radioTown[i].style.boxShadow = "0 0 10px green";
        }
      } else {
        for(let i = 0; i < document.fMain.radioTown.length; i++) {
            document.fMain.radioTown[i].style.boxShadow = "0 0 10px red";
        }
      }

      // red for  snils
      if (checkSnils(snils)) {
         document.fMain.snils.style.boxShadow = "0px 0px 5px green";
      } else {
         document.fMain.snils.style.boxShadow = "0px 0px 5px red";
      }
      console.log(email.test(document.fMain.email.value));
   }
}

function checkSnils(checkedValue, fieldName) {

   if (checkedValue == undefined) {
      return false;
   }
   var checkSum = parseInt(checkedValue.slice(9), 10);

   var sum = (checkedValue[0] * 9 + checkedValue[1] * 8 + checkedValue[2] * 7 + checkedValue[3] * 6 + checkedValue[4] * 5 + checkedValue[5] * 4 + checkedValue[6] * 3 + checkedValue[7] * 2 + checkedValue[8] * 1);

   if (sum < 100 && sum == checkSum) {
      return true;
   } else if ((sum == 100 || sum == 101) && checkSum == 0) {
      return true;
   } else if (sum > 101 && (sum % 101 == checkSum || (sum % 101 == 100 && checkSum == 0))) {
      return true;
   } else {
      return false;
   }
}