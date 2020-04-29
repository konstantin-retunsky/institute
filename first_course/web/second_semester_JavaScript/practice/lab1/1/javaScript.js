
function result ()  {
     var infRadiobtn;
     var infName;
     var infSurname;
     var infAge;
     var infWishes;

     if(bal !=0) {

     }

     var infInteres = [];

     var arrayInteres = ["Книги","Музыка и CD","Программное обеспечение",
                         "Концелярские товары","Сувениры"];

     infName    = document.profile.textSurname.value;
	infSurname = document.profile.textName.value;
	infAge     = document.profile.age.options[profile.age.selectedIndex].value;

     if(document.profile.rb[0].checked) {
          infRadiobtn = "Зарегестрированный покупатель";
     } else if(document.profile.rb[1].checked) {
          infRadiobtn = "Впервые пользуюсь услугами магазина";
     }

     for(let i = 0; i < 5; i++ ) {
          if(document.profile.chb[i].checked) {
               infInteres.push(arrayInteres[i]);
          }
     }
/*
     if(document.profile.chb[0].checked) {
          infInteres.push(arrayInteres[0]);
     }
     if (document.profile.chb[1].checked) {
          infInteres.push(arrayInteres[1]);
     }
     if (document.profile.chb[2].checked) {
          infInteres.push(arrayInteres[2]);
     }
     if (document.profile.chb[3].checked) {
          infInteres.push(arrayInteres[3]);
     }
     if (document.profile.chb[4].checked) {
          infInteres.push(arrayInteres[4]);
     }
*/

     infOther  = document.profile.other.value;
     infWishes = document.profile.wishes.value;

     document.write('<body style = "background: yellow; color: blue;">' +
                    '<h1 style = "color: red; text-align: center;">Информация о покупателе</h1>'+
                    '<div style = "width: 500px; height: 500px; background: white; margin: auto; padding: 10px 10px 10px 10px"; font-size: 1.7em;>'+

                    '<p style = "color: grey;" >Фамилия: <p/> ' + infSurname + "<br/>"+
                    '<p style = "color: grey;" >Имя: <p/> ' + infName + "<br/>"+
                    '<p style = "color: grey;" >Возрастная группа:<p/> ' + infAge + "<br/>"+
                    /*+ infRadiobtn +"<br/>"+
                    +'<p style = "color: grey; text-decoration: underline;">Товары представляющие интерес:<p/><br/>'+
                    +'<ul>'+
                    +'<li>'  + infInteres + "<br/>" + infOther +  '</li>'+ "<br/>" +
                    +'</ul>'+
                    +infWishes+ */
                    '<div/>'+
                    '<body/>');
     document.write(infRadiobtn);
     document.write('<p style = "color: grey; text-decoration: underline;">Товары представляющие интерес:<p/><br/>');
     for(let i = 0; i < infInteres.length; i++) {
          document.write( '<li>'+ infInteres[i]+'</li>'  );
     }
     document.write('<br/><p style = "color: grey; text-decoration: underline;">пожелания покупателя<p/><br/>');
     document.write(infWishes);

}
