

















let str = new String();
let temp = new Number();
let index = new Number();
$('.content-list').click(function() {
   str = this.childNodes[0].data;
   if(index == this.attributes.value.value) {
      temp++;
   }
   if(index == this.attributes.value.value & $('.content-list').css(["display"]).display == 'block') {
      $('.content-headline').css('display','none');
      $('.content-text').css('display','none');
   } else {
      $('.content-headline').css('display','block');
      $('.content-text').text(str + " lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya")
   }
   $('.content-headline').text(this.childNodes[0].data);
   
   if(temp == 2) {
      temp = 0;
      $('.content-headline').css('display','block');
   }
   index = this.attributes.value.value;
});

$('.content-headline').click(function(){
   if($('.content-text').css(["display"]).display == 'none') {
      $('.content-text').css('display','block');
      $('.content-text').text(str + " lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya,lya lya lya lya, bla bla bla, lya lya lya")
   } else if($('.content-text').css(["display"]).display == 'block') {
      $('.content-text').css('display','none');
   }
});
