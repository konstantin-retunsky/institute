








createElem('div').id = "mainDiv";
selectElem('#mainDiv').appendChild(createElem('input')).id = 'inputText';
selectElem('#inputText').setAttribute('placeholder', 'введите новый контакт');
$('#inputText').val('Блаа 99999999999 ko.12.95@gmail.com');




var indexContact = new Number(0);
let regex = /^[А-Я][А-я]+\s[0-9]{11}\s[A-z\d\.]+@[A-z]+\.[a-z]{2,6}$/;
let bool = new Boolean(true);
let kostil2 = true;

$('#inputText').on('keypress', function (e) {
   if (e.which == 13) {

      if($('.contact').length > 0) {
         for(let i = 0; i < $('.contact').length; i++) {
               if(selectElem('#inputText').value == $('#info-'+i).text()) {
                  kostil2 = false;
               }
         }
      }

      if (regex.test(selectElem('#inputText').value) & kostil2) {
         selectElem('#inputText').style.boxShadow = "0 0 5px white";
         selectElem('#mainDiv').appendChild(createElem('div', 'contact-' + indexContact, 'contact'));
         $('#contact-'+indexContact).attr('value', indexContact);
         $('#contact-' + indexContact).html(`<input type='checkbox' class='kostil-${indexContact}' value='${indexContact}' id='checkbox-${indexContact}'></input>` +
                                          `<span id='info-${indexContact}' class='kostil-${indexContact}'>` + selectElem('#inputText').value  + "</span>" +
                                          `<span class='kostil-${indexContact}' id='${"remove-"+indexContact}' value='${indexContact}'>${String.fromCharCode(10006)}</span>`);

         $('#checkbox-' + indexContact).click(function(){
            $(('#contact-' + this.attributes.value.value)).css('box-shadow',"0 0 5px green");
            selectElem('#checkbox-'+this.attributes.value.value).style.visibility = "hidden";
         });
         $('#remove-'+indexContact).click(function(){
            $('#contact-'+ this.attributes.value.value).remove();
            $('#mainDiv').height($('#mainDiv').height() - 38);
         });
         $('#contact-' + indexContact).dblclick(function(){
            //selectElem('#contact-' + this.attributes.value.value).style.display = "none";
            if(bool) {
               console.log(this.attributes.value.value)
               let indexDiv = this.attributes.value.value;
               $('.kostil-' + indexDiv).css('display','none');
               if(!$('#temp').length) {
                  bool = false;
                  selectElem('#contact-' + indexDiv).appendChild(createElem('input', 'temp'));
                  $('#temp').on('keypress',function(e){
                     if(e.which == 13) {
                        if(regex.test(selectElem('#temp').value)) {
                           $('#info-' + indexDiv).text(selectElem('#temp').value);
                        $('.kostil-' + indexDiv).css('display','inline');
                        this.remove();
                        bool = true;
                        }else {
                           selectElem('#temp').style.boxShadow = "0 0 5px red";
                        }
                     }
                  });
               }
            }
         });
         $('#mainDiv').height($('#mainDiv').height() + 38);
         indexContact++;
      } else {
         selectElem('#inputText').style.boxShadow = "0 0 5px red";
      }
   }
});
