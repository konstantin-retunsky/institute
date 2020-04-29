using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Program {
    private static string[] text;
    static void Main ( string [ ] args ) {
      // 8) место, область, город, мегаполис;

      // Словарь слов для подстановки в string поля
      text = File.ReadAllLines( "RussianWords.txt", Encoding.Default );

      Place[] p = new Place[5];
      Create( ref p );
      Show( p );
      Transform( p );
      Show( p );
      TransformShow( p );

      Console.ReadKey( );
    }

    private static void TransformShow ( Place [ ] p ) {
      Console.WriteLine( "===========================================" );
      for ( int i = 0; i < p.Length; i++ ) {
        if ( p [ i ] is Metropolis ) {

          Console.WriteLine(
              "\n" + ( ( Metropolis ) p [ i ] ).GetPercentageOfPoverty( ) + "\n"
              + ( ( Metropolis ) p [ i ] ).GetAverageSalary( ) + "\n" 
          );

        } else if ( p [ i ] is Town ) {
          Console.WriteLine(
              "\n" + ( ( Town ) p [ i ] ).GetPopulation( ) + "\n" +
                     ( ( Town ) p [ i ] ).GetMortality( ) + "\n" );
        } else if ( p [ i ] is Region ) {
          Console.WriteLine(
              "\n" + ( ( Region ) p [ i ] ).GetNumber( ) + "\n" +
                     ( ( Region ) p [ i ] ).GetOfficialStatus( ) + "\n" );
        } else {
          Console.WriteLine(
              "\n" + p [ i ].GetName( ) + "\n" +
                     p [ i ].GetArea( ) + "\n" );
        }
      }
    }

    private static void Transform ( Place [ ] p ) {
      Random rnd = new Random();
      for ( int i = 0; i < p.Length; i++ ) {
        if ( p [ i ] is Metropolis ) {
          ( ( Metropolis ) p [ i ] ).SetPercentageOfPoverty( rnd.Next( ) );
          ( ( Metropolis ) p [ i ] ).SetAverageSalary( rnd.Next( ) );
        } else if ( p [ i ] is Town ) {
          ( ( Town ) p [ i ] ).SetPopulation( rnd.Next( ) );
          ( ( Town ) p [ i ] ).SetMortality( rnd.Next( ) );
        } else if ( p [ i ] is Region ) {
          ( ( Region ) p [ i ] ).SetNumber( rnd.Next( ) );
          ( ( Region ) p [ i ] ).SetOfficialStatus( false );
        } else {
          p [ i ].SetName( text [ rnd.Next( 0, 160000 ) ] );
          p [ i ].SetArea( rnd.Next( ) );
        }
      }
    }

    private static void Create ( ref Place [ ] p ) {
      Random rnd = new Random();
      for ( int i = 0; i < p.Length; i++ ) {
        double random = rnd.NextDouble();

        if ( random > 0.7 )
          p [ i ] = new Place( text [ rnd.Next( text.Length ) ], rnd.Next( ) );

        else if ( random > 0.5 )
          p [ i ] = new Region( rnd.Next( 10 ), true, text [ rnd.Next( text.Length ) ], rnd.Next( ) );

        else if ( random > 0.3 )
          p [ i ] = new Town( rnd.Next( ), rnd.Next( ), rnd.Next( ),
              true, text [ rnd.Next( text.Length ) ], rnd.Next( 10 ) );

        else
          p [ i ] = new Metropolis( rnd.Next( ), rnd.Next( ), rnd.Next( ), rnd.Next( ), rnd.Next( ),
              true, text [ rnd.Next( text.Length ) ], rnd.Next( 10 ) );

      }
    }

    private static void Show ( Place [ ] p ) {
      Console.WriteLine( "===========================================" );
      for ( int i = 0; i < p.Length; i++ ) {
        if ( p [ i ] is Metropolis )
          Console.WriteLine( ( ( Metropolis ) p [ i ] ).Info( ) );
        else if ( p [ i ] is Town )
          Console.WriteLine( ( ( Town ) p [ i ] ).Info( ) );
        else if ( p [ i ] is Region )
          Console.WriteLine( ( ( Region ) p [ i ] ).Info( ) );
        else
          Console.WriteLine( p [ i ].Info( ) );
      }
    }
  }
}
