using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {
  class Place {
    protected string name;
    protected int area;

    public Place ( ) {
      name = "No data";
      area = 0;
    }

    public Place ( string name, int area ) {
      this.name = name;
      this.area = area;
    }

    public void SetName ( string name ) {
      this.name = name;
    }
    public void SetArea ( int area ) {
      this.area = area;
    }

    public string GetName ( ) {
      return name;
    }
    public int GetArea ( ) {
      return area;
    }

    public virtual string Info ( ) {
      return string.Format( "Страна: {0};\nПлащадь: {1}.\n", name, area );
    }
  }
}
