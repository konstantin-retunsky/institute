using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Metropolis : Town {
    protected int averageSalary;
    protected int percentageOfPoverty;

    public Metropolis ( ) {
      averageSalary = 0;
      mortality = 0;
    }
    public Metropolis ( int averageSalary, int percentageOfPoverty, int population,
                      int mortality, int number, bool officialStatus, string name, int area )
                      : base( population, mortality, number, officialStatus, name, area ) {
      this.averageSalary = averageSalary;
      this.percentageOfPoverty = percentageOfPoverty;
    }

    public void SetAverageSalary ( int averageSalary ) {
      this.averageSalary = averageSalary;
    }
    public void SetPercentageOfPoverty ( int percentageOfPoverty ) {
      this.percentageOfPoverty = percentageOfPoverty;
    }

    public int GetAverageSalary ( ) {
      return averageSalary;
    }
    public int GetPercentageOfPoverty ( ) {
      return percentageOfPoverty;
    }

    public override string Info ( ) {
      return string.Format( "Название города: {0};\nПлащадь: {1};\n" +
          "Cтатуса мегаполиса: {2};\nНомер Области: {3};\n" +
          "Численность населения: {4};\nСмертность: {5};\n" +
          "Средняя заработная плата: {6};\nПроцент бедности: {7}.\n",
          name, area, officialStatus, number, population, mortality, averageSalary, percentageOfPoverty );
    }
  }
}
