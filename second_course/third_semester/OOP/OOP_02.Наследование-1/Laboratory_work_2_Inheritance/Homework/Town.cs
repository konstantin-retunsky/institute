using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Town : Region {
    protected int population;
    protected int mortality;

    public Town ( ) {
      population = 0;
      mortality = 0;
    }
    public Town ( int population, int mortality, int number,
                    bool officialStatus, string name, int area )
                        : base( number, officialStatus, name, area ) {
      this.population = population;
      this.mortality = mortality;
    }

    public void SetPopulation ( int population ) {
      this.population = population;
    }
    public void SetMortality ( int mortality ) {
      this.mortality = mortality;
    }

    public int GetPopulation ( ) {
      return population;
    }
    public int GetMortality ( ) {
      return mortality;
    }

    public override string Info ( ) {
      return string.Format( "Название города: {0} ;\nПлащадь: {1};\n" +
          "Потверждение статуса года: {2};\nНомер Области: {3};\n" +
          "Численность населения: {4};\nСмертность: {5}.\n",
          name, area, officialStatus, number, population, mortality );
    }
  }
}
