
// nameTag имя дива, name Id - присвоение id, nameClass -присвоение класса
function createElem(nameTag, nameId, nameClass) {
   if (nameTag != undefined) {
      let element = document.createElement(nameTag);
      document.body.appendChild(element);

      if(nameClass != undefined) {
         element.classList.add(nameClass);
      }
      if (nameId != undefined) {
         element.id = nameId;
      }
      return element;
   }
}

createElem(asd,asd,asd,asd)

// выборка по id,class,nameTag
function selectElem(nameElem) {
   if (nameElem[0] == '.') {
      let elem = document.getElementsByClassName(nameElem.slice(1))
      return elem;
   } else if (nameElem[0] == '#') {
      let elem = document.getElementById(nameElem.slice(1));
      return elem;
   } else {
      let elem = document.getElementsByTagName(nameElem);
      return elem;
   }
}