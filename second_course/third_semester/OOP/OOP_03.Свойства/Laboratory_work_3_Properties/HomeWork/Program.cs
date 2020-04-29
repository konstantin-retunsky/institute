using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork {
  class Program {
    static void Main ( string [ ] args ) {
      Console.WriteLine( "Созданы два объекта \"Time24\" (\"timeOne\" , \"timeTwo\")." );
      Time24 timeOne = new Time24(0);
      Time24 timeTwo = new Time24(0);
      timeOne.Show( );
      timeTwo.Show( );

      Console.WriteLine( "\nСравнение двух объектов \"Time24\"." );
      Console.WriteLine( timeOne.Compare( timeTwo ) );

      Console.WriteLine( "\nИзменен параметр \"Час\" у объектов \"Time24\"." );
      timeTwo.Hour = 22;
      timeOne.Hour = 14;
      timeOne.Show( );
      timeTwo.Show( );

      Console.WriteLine( "\nПрибавили одну минуту к объету \"timeOne\"." );
      timeOne.NextMin( );
      timeOne.Show( );

      Console.WriteLine( "\nСчитали время в часах (вещ. значение)." );
      Console.WriteLine( timeOne.HourR );

      Console.WriteLine( "\nРазность в часах объекта \"timeTwo\" с \"timeOne\"." );
      Console.WriteLine( timeTwo.HourBetween( timeOne ) );

      Console.WriteLine( "\nРазность в минутах объекта \"timeTwo\" с \"timeOne\"." );
      Console.WriteLine( timeTwo.MinBetween( timeOne ) );

      Console.WriteLine( "\nОтняли одну минуту у объету \"timeOne\"." );
      timeOne.PredMin( );
      timeOne.Show( );
      timeTwo.Show( );

      Console.WriteLine( "\nМетод \"TimeRemain\" – Возвращает объект, представляющий время, \n" +
          "которое осталось  до конца суток от текущего времени (\"timeTwo\" от \"timeOne\")." );
      timeOne.TimeRemain( timeTwo ).Show( );

      Console.WriteLine( "\nЗадали параметр \"Минута\" у объета \"timeOne\"." );
      timeOne.Min = 33;
      timeOne.Show( );

      Console.WriteLine( "\nОкругляет время до ближайшего часа у объета \"timeOne\"." );
      timeOne.NearHour( );
      timeOne.Show( );

      Console.WriteLine( "\nДополнительные задание!" );
      Console.WriteLine( "\nСумируем время обекта \"timeTwo\" к \"timeOne\"." );
      timeOne.Show( );
      timeTwo.Show( );
      timeOne.NextTime( timeTwo );
      timeOne.Show( );

      Console.WriteLine( "\nПреводим время у объета \"timeOne\" в 12-ти часовой формат." );
      timeOne.Show( );
      Console.WriteLine( timeOne.Time12( ) );

      Console.WriteLine( "\nМетод прибавляющий часы (К примеру прибавим 80 часов)." );
      timeOne.NextHour( 80 ).Show( );

      Console.ReadKey( );
    }
  }
}
