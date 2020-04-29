
function result() {

     var num1 = new Number();
     var num2 = new Number();

     num1 = document.rbtnImg.width_num.value;
     num2 = document.rbtnImg.height_num.value;

     var test = document.getElementById('resultTest');



     if(document.rbtnImg.rbtn[0].checked) {
     test.innerHTML =     '<body>'+
                         '<img src = "img1.jpg"  width = "' + num1 + '"  height = "' + num2 + '"  ">' +
                         '<body/>';
     } else if(document.rbtnImg.rbtn[1].checked) {
     test.innerHTML =     '<body>'+
                         '<img src = "img2.jpg"  width = "' + num1 + '"  height = "' + num2 + '"  ">' +
                         '<body/>';
     } else if(document.rbtnImg.rbtn[2].checked) {
     test.innerHTML =    '<body>'+
                         '<img src = "img3.jpg"  width = "' + num1 + '"  height = "' + num2 + '"  ">' +
                         '<body/>';
     }
}
