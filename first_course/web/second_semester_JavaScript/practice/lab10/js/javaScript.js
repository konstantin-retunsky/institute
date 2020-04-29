// костыли
var kostil = true;
var indexMouseout = new Number();
let indexInterval = new Number();
let btnStop = new Number();

// styles for crowbar
function styleCrowbar(a) {
   a.style.width = "500px";
   a.style.height = "349px";
   a.style.position = "absolute";
}

// create top bar into form(.fMain)
for (let i = 0; i < 5; i++) {
   let exel = document.createElement('div');
   let text = document.createTextNode("crowbar-" + "1." + i);

   exel.id = 'exel-' + i;
   exel.setAttribute("value", i);

   exel.appendChild(text);
   document.getElementById('fMain').appendChild(exel);

   // create img via exel-div
   createMouseover = exel.addEventListener("mouseover", function () {
      if(kostil) {

      let crowbar = document.createElement('img');
      crowbar.setAttribute("src", "img/crowbar-1." + this.attributes.value.value + ".jpg");
      crowbar.id = "crowbarImg-" + this.attributes.value.value;
      crowbar.classList.add('delet');

      styleCrowbar(crowbar);

      exel.addEventListener("mouseout", function () {
         indexMouseout = this.attributes.value.value;
         if(kostil) {
            $("img").remove();
         }
      });

      document.getElementById('fMain').appendChild(crowbar);
   }
   });
}

function start() {
      if (kostil) {
      kostil = false;
      indexInterval = +indexMouseout;
      btnStop = +indexMouseout - 1;

      interval = setInterval(function startInterval() {

         indexInterval++;
         if (indexInterval > 4) {
            indexInterval = 0;
         }

         let crowbar = document.createElement('img');
         crowbar.setAttribute("src", "img/crowbar-1." + indexInterval + ".jpg");

         styleCrowbar(crowbar);

         document.getElementById('fMain').appendChild(crowbar);

      }, 1000);
   }
}

function stop() {
   kostil = true;

   clearInterval(interval);
   if ((btnStop - 1) < 0) {
      btnStop = 4;
      console.log("eeeBoy");
      console.log(btnStop);
   }

   let crowbar = document.createElement('img');
   crowbar.setAttribute("src", "img/crowbar-1." + btnStop + ".jpg");

   styleCrowbar(crowbar);

   document.getElementById('fMain').appendChild(crowbar);
}