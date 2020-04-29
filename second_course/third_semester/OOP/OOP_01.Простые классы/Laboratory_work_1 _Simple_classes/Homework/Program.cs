using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Program {
    static void Main ( string [ ] args ) {
      //8	«Компьютер»	Размер RAM, HDD, частота CPU.

      Computer computer = new Computer();
      computer.ShowInfo( );
      computer.AddRAM( 4 );
      computer.AddHDD( 1024 );
      computer.AddCPU( 1000 );
      computer.ShowInfo( );
      computer.ClearHDD( );

      Console.ReadKey( );
    }
  }
}
