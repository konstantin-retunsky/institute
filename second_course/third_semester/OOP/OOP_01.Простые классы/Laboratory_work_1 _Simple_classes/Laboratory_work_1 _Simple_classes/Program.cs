using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1__Simple_classes {
  class Program {
    static void Main ( string [ ] args ) {

      Rectangle rectangleOne = new Rectangle();
      rectangleOne.Set( 2, 4 );
      Console.WriteLine( rectangleOne.Info( ) );
      rectangleOne.SetSquare( 32 );
      Console.WriteLine( rectangleOne.Info( ) );
      Console.WriteLine( );

      Rectangle rectangleTwo = new Rectangle();
      rectangleTwo.Set( 2, 4 );
      Console.WriteLine( rectangleTwo.Info( ) );
      rectangleTwo.SetSquare( 32 );
      Console.WriteLine( rectangleTwo.Info( ) );
      Console.WriteLine( );

      Console.WriteLine( "Прямоугольники равны: " + rectangleTwo.EqualityOfRectangles( rectangleOne ) );

      Console.ReadKey( );
    }
  }
}
