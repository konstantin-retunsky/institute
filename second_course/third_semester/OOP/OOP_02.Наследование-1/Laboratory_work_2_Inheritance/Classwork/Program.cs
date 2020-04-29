using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork {
  class Program {
    static void Main ( string [ ] args ) {
      //Этап первый
      Point pointOne = new Point();
      Circle circleOne = new Circle();
      Point pointTwo = new Point(4, 2);
      Circle circleTwo = new Circle(4, 3, 5);
      Console.WriteLine( pointOne.Info( ) );
      Console.WriteLine( circleOne.Info( ) );
      Console.WriteLine( pointTwo.Info( ) );
      Console.WriteLine( circleTwo.Info( ) );

      //Этап второй
      Console.WriteLine( );
      const int n = 6;  //длина массива
      Point[] p;
      Create( out p, n );
      Show( p );

      //Этап третий
      Console.WriteLine( );
      Transform( p );
      Show( p );

      //Самостоятельно в классе
      Console.WriteLine( );
      SimmTransform( p );
      Show( p );
      RoFromShow( p );

      Console.ReadKey( );
    }

    private static void RoFromShow ( Point [ ] p ) {

      Console.WriteLine( );
      Console.WriteLine( "Таблица растояний" );
      Console.WriteLine( "     0   1   2   3   4   5   " );
      Console.WriteLine( "-------------------------------" );

      for ( int i = 0; i < p.Length; i++ ) {
        Console.Write( i );
        Console.Write( " " );
        for ( int j = 0; j < p.Length; j++ ) {
          double line = p[j].RoFrom(p[i]);
          Console.Write( string.Format( "{0,5:F1}", line ) );
        }
        Console.WriteLine( );
      }
      Console.WriteLine( "-------------------------------" );
    }

    private static void SimmTransform ( Point [ ] p ) {
      for ( int i = 0; i < p.Length; i++ ) {
        p [ i ].Simm( );
      }
    }

    private static void Show ( Point [ ] p ) {
      for ( int i = 0; i < p.Length; i++ ) {
        if ( p [ i ] is Circle )
          Console.WriteLine( "{0,2} - {1}", i, ( ( Circle ) p [ i ] ).Info( ) );
        else
          Console.WriteLine( "{0,2} - {1}", i, p [ i ].Info( ) );
      }
      Console.WriteLine( "-------------------------------" );

    }

    private static void Create ( out Point [ ] p, int n ) {
      p = new Point [ n ];
      Random rnd = new Random();
      for ( int i = 0; i < n; i++ ) {
        if ( rnd.NextDouble( ) < 0.4 )
          p [ i ] = new Point( rnd.Next( 10 ), rnd.Next( 10 ) );
        else
          p [ i ] = new Circle( rnd.Next( 10 ), rnd.Next( 10 ), rnd.Next( 8 ) );
      }
    }

    private static void Transform ( Point [ ] p ) {
      for ( int i = 0; i < p.Length; i++ ) {
        if ( p [ i ] is Circle )
          ( ( Circle ) p [ i ] ).SetSquare( 10 );
        else
          p [ i ].Move( 5, 5 );
      }
    }

  }
}
