
// инпуты формы
let formMain = document.getElementsByTagName('form');
let fullNameUser = document.getElementById('full-name-user');
let nameUser = document.getElementById('name-user');
let ageUser = document.getElementById('age-user');
let interesUser = document.getElementsByClassName('interes-user');
let wishesUser = document.getElementById('wishes-user');

// btn sumbint
let btnSubmit = document.querySelector('button[type="submit"]');

btnSubmit.onclick = function() {
   //Создаем новое окно и выводим туда всю инфу
   let newWindow = window.open("","","top=500,left=500,width=600");

   //Создаем элементы нового окна
   newWindow.document.body.style.cssText = "background-color:#FCFDB6;";

   let mainTitle = newWindow.document.createElement('h1');
   mainTitle.textContent = "Информация о покупателе";
   mainTitle.style.cssText = "color:#D35B2E;text-align:center;";
   newWindow.document.body.appendChild(mainTitle);

   let mainDiv = newWindow.document.createElement('div');
   mainDiv.style.cssText = "width:500px;border: solid 3px white; background-color: #FEFEE1;margin:auto;";
   newWindow.document.body.appendChild(mainDiv);

   let mainDivDt = newWindow.document.createElement("dt");
   mainDiv.appendChild(mainDivDt);

   // создаем элемент dd и выводим Фамилию пользователя
   let fullNameDD = newWindow.document.createElement("dd");
   fullNameDD.innerHTML = "Фамилия:" + '<span style="color:blue">'+ fullNameUser.value +"</span>";
   mainDivDt.appendChild(fullNameDD);

   // создаем элемент dd и выводим Имя пользователя
   let nameDD = newWindow.document.createElement('dd');
   nameDD.innerHTML = "Имя:" + '<span style="color:blue">'+ nameUser.value +"</span>";
   mainDivDt.appendChild(nameDD);

   // возраст пользователя
   let selectedAge = document.getElementById('age-user').options[document.getElementById('age-user').options.selectedIndex].text;
   let ageDD = newWindow.document.createElement('dd');
   ageDD.innerHTML = "Возрастная группа:" + '<span style="color:blue">'+ selectedAge +"</span>";
   mainDivDt.appendChild(ageDD);

   // как давно этот пользователь с нами
   let newOldUser = document.getElementById('old-new-user').labels[0].textContent;
   let newOldDD = newWindow.document.createElement('dd');
   newOldDD.innerHTML = '<span style="color:blue">'+ newOldUser +"</span>";
   mainDivDt.appendChild(newOldDD);

   // Товары, представляющие интерес
   let interesUserDD = newWindow.document.createElement('dd');
   interesUserDD.innerHTML = '<u>'+"Товары, представляющие интерес:"+'</u> + <br>'
   let interesUserUl = newWindow.document.createElement('ul');
   for(let i = 0; i < 5; i++) {
      if(document.getElementsByClassName('interes-user')[i].checked) {
         let li = newWindow.document.createElement('li');
         li.innerHTML += document.getElementsByClassName('interes-user')[i].labels[0].textContent;
         interesUserUl.appendChild(li);
      }
   }

   interesUserDD.appendChild(interesUserUl);
   mainDivDt.appendChild(interesUserDD);
};