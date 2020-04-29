using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork {
  class Program {
    static void Main ( string [ ] args ) {
      N2 a = new N2("A");
      a.Show( );
      N2 b = new N2("B");
      b.Show( );
      a.Val = 54;
      a.Show( );
      b.Val = -17;
      b.Show( );
      a.D2 = 15;
      a.Show( );
      b.D1 = 8;
      b.Show( );
      a.Swap( );
      a.Show( );
      b.Swap( );
      b.Show( );
      Console.WriteLine( "A<B - {0}", a.LessThen( b ) );
      Console.WriteLine( "B<A - {0}", b.LessThen( a ) );

      Console.WriteLine( "==============================" );
      Console.WriteLine( "B==A - {0}", b.IsSimm( a ) );
      a.Show( );
      Console.WriteLine( "a.DigSum = " + a.DigSum );
      a.DigSum = 13;
      a.Show( );
      Console.WriteLine( "a.DigSum = " + a.DigSum );
      Console.WriteLine( "a.DigSimple = " + a.DigSimple );


      Console.ReadKey( );
    }
  }
}
