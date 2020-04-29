
var kostil = new Number();
var kostil2 = new Number();

var createMouseover;
var createMouseout;

//exel - div  - upper side bar {
for(let i = 0; i < 5; i++) {
   let exel = document.createElement('div');
   let text = document.createTextNode("crowbar-" + "1." + i);

   exel.classList.add('exel-' + (i+1));
   exel.setAttribute("value", i);

   exel.appendChild(text);
   document.getElementById('fMain').appendChild(exel);

   // create img for exel-div
   createMouseover = exel.addEventListener("mouseover", function() {
      let crowbar = document.createElement('img');
      crowbar.setAttribute("src", "img/crowbar-1." + this.attributes.value.value + ".jpg");
      crowbar.classList.add("crowbarImg-" + this.attributes.value.value);

      crowbar.style.width = "500px";
      crowbar.style.height = "349px";
      crowbar.style.position = "absolute";

      exel.addEventListener("mouseout", function() {
         crowbar.style.display = "none";
            kostil  = this.attributes.value.value;
            kostil2 = this.attributes.value.value;
      });

      document.getElementById('fMain').appendChild(crowbar);
   });
}

var interval;
function start() {
   // for(let i = 1; i < 6; i++) {
   //    document.getElementsByClassName("exel-" + i).setAttribute('mouseover', 'data-temp-1');
   //    document.getElementsByClassName("exel-" + i).setAttribute('mouseout', 'data-temp-2');
   // }

   interval = setInterval(function startInterval() {
      kostil++;
      if(kostil > 4) {
         console.log(kostil);
         kostil = 0;
      }

      let crowbar = document.createElement('img');
      crowbar.setAttribute("src", "img/crowbar-1." + kostil + ".jpg");

      crowbar.style.width = "500px";
      crowbar.style.height = "349px";
      crowbar.style.position = "absolute";

      document.getElementById('fMain').appendChild(crowbar);
   }, 1000);
}

function stop() {
   clearInterval(interval);
   if((kostil2 - 1) < 0) {
      kostil2 = 4;
   } else {
      --kostil2;
   }
   // for(let i = 1; i < 6; i++) {
   //    document.getElementsByClassName("exel-" + i).setAttribute('data-temp-1', 'mouseover' );
   //    document.getElementsByClassName("exel-" + i).setAttribute('data-temp-2', 'mouseout' );
   // }
   let crowbar = document.createElement('img');
   crowbar.setAttribute("src", "img/crowbar-1." + kostil2 + ".jpg");

   crowbar.style.width = "500px";
   crowbar.style.height = "349px";
   crowbar.style.position = "absolute";

   document.getElementById('fMain').appendChild(crowbar);
   console.log(document.getElementsByClassName("exel-3"));
}













// create img for exel-div

// for(let i = 0; i < 5; i++) {
//    let crowbar = document.createElement('img');
//    crowbar.setAttribute("src", "img/crowbar-1." + i + ".jpg");

//    crowbar.classList.add("crowbarImg-" + i);
//    crowbar.style.display = "none";
//    crowbar.style.width = "500px";
//    crowbar.style.height = "349px";
//    crowbar.style.position = "absolute";

//    // changes for mouseover & mouseout


//    document.getElementById('fMain').appendChild(crowbar);
// }


