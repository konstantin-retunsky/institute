
function result() {

   // inputted date in text 
   var startDate = document.fMain.startDate.value.split(/\D/);
   var finalDate = document.fMain.finalDate.value.split(/\D/);

   // для нестандартный ввода даты - 2/3/19 
   if (startDate[2].length != 4) {
      if (startDate[2] > 19) {
         startDate[2] = "19" + startDate[2];
      } else {
         startDate[2] = "20" + startDate[2];
      }
   }
  
   
   // OSTOROJNO KOStiL
   startDate[1]++;
   finalDate[2]++;
   
   // create date 
   var dateOne  = new Date(startDate[2], startDate[0]-1, startDate[1]);  // js kakashka 
   var dateTwo  = new Date(finalDate[0], finalDate[1]-1, finalDate[2]);
   var coustDay = new Number();
   
   

   console.log(dateOne.getDate() - 1);
   
   if (dateOne < dateTwo) {
      // number of days
      if (document.fMain.rbDeterminant[0].checked) {
         for (let day = dateOne; day <= dateTwo; day.setDate(day.getDate() + 1)) {
               console.log(day);
               coustDay++;
               
         }
      }
      // number of days off
      else if (document.fMain.rbDeterminant[1].checked) {         
         for (let day = dateOne; day <= dateTwo; day.setDate(day.getDate() + 1)) {
            console.log(day.getDay());
            if (day.getDay() == 0 | day.getDay() == 1) {
               coustDay++;
            }
         }
      }
      // number of working days
      else if (document.fMain.rbDeterminant[2].checked) {
         for (let day = dateOne; day <= dateTwo; day.setDate(day.getDate() + 1)) {
            if(day.getDay() != 0 & day.getDay() != 1) {
               coustDay++;
            }
         }
      }
      // Total weeks
      else if (document.fMain.rbDeterminant[3].checked) {
         var bubble = new Number();
         var boolean = false;
         for (let day = dateOne; day <= dateTwo; day.setDate(day.getDate() + 1)) {
            console.log(day.getDate());
            if (day.getDay() == 2) {
               boolean = true;
            }
            if (boolean == true) {
               bubble++;
            }
            if (bubble == 7) {
               bubble = 0;
               coustDay++;
               boolean = false;
            }
         }
      }
      // Number of full months
      else if (document.fMain.rbDeterminant[4].checked) {
         var tempDate  = new Date(startDate[2], startDate[0]-1, startDate[1] + 1);
         var bubble = new Number();
         var boolean = false;

         for (let day = dateOne; day <= dateTwo; day.setDate(day.getDate()+1)) {
            
            //console.log(day.getDate() - 1);
            console.log(day.getDate()-1);
            
            if (boolean == true & (day.getDate()-1) == 1) {
               coustDay++;
               console.log("yes");
               boolean = false;
            }

            if ((day.getDate()-1) == 1) {
               boolean = true;
               console.log("EEE");
               
            }
            
            
         }
      //    
      //   var months;
      //     months = (dateOne.getFullYear() - dateOne.getFullYear()) * 12;
      //     months -= dateOne.getMonth() + 1;
      //     months += dateTwo.getMonth();
      //     coustDay = months <= 0 ? 0 : months;
      }

      if(startDate[0] == "2" | startDate[0] == "02") {
         if(startDate[1] > 29) {
            alert("Tak nezya");
            coustDay = 0;
         } else if ((dateOne.getDate() - 1) == 1) {
            alert("Tak nezya tip visokosniy");
            coustDay = 0;
            return 0;
         }
      }

     document.fMain.output.value = coustDay;
   } else {
      alert("dataOne > dataTwo");
   }
   // coust day finish 
}