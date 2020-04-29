using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Region : Place {
    protected int number;
    protected bool officialStatus;

    public Region ( ) {
      number = 0;
      officialStatus = false;
    }
    public Region ( int number, bool officialStatus, string name, int area ) : base( name, area ) {
      this.number = number;
      this.officialStatus = officialStatus;
    }

    public void SetNumber ( int number ) {
      this.number = number;
    }
    public void SetOfficialStatus ( bool officialStatus ) {
      this.officialStatus = officialStatus;
    }

    public int GetNumber ( ) {
      return number;
    }
    public bool GetOfficialStatus ( ) {
      return officialStatus;
    }

    public override string Info ( ) {
      return string.Format( "Название Области: {0};\nПлащадь: {1};\n" +
          "Статус Области: {2};\nНомер Области: {3}.\n", name, area, officialStatus, number );
    }
  }
}
