using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  sealed class Computer {
    private int ram;
    private int hdd;
    private int cpu;

    public int RAM {
      get => ram; set => ram = value <= 0 ? 1 : value;
    }
    public int HDD {
      get => hdd; set => hdd = value <= 0 ? 1 : value;
    }
    public int CPU {
      get => cpu; set => cpu = value <= 0 ? 1 : value;
    }

    public Computer ( ) {
      RAM = 4;
      HDD = 1024;
      CPU = 1666;
    }

    public void ShowInfo ( ) {
      Console.WriteLine( "Размер оперативной памяти: " + RAM +
          ", Объем памяти: " + HDD + ", Частота центрального процессора: " + CPU + "." );
    }

    public void AddRAM ( int size ) {
      RAM += size;
    }

    public void AddHDD ( int size ) {
      HDD += size;
    }

    public void AddCPU ( int size ) {
      CPU += size;
    }

    public void ClearHDD ( ) {
      Console.WriteLine( "Диск очищен!" );
    }
  }
}
