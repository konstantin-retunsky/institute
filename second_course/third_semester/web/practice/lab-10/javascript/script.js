







let bubble = $.cookie('bubble');    // Получение cookie с именем kittens:

let p = $('p');

for (let i = 0; i < p.length; i++) {
    p[i].style.fontSize = ( (i * 0.1) * bubble)  + "em";
    console.log(p[i].style.fontSize);
    console.log(p[i]);
}


$('.site').click(function () {
    let indexClickSite = this.innerText.replace(/\D+/, "");
    $.cookie('index-click-site', indexClickSite);    // Получение cookie с именем kittens:
});

