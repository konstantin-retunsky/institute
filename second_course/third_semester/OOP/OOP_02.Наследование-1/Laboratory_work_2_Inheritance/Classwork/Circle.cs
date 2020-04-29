using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork {
  sealed class Circle : Point {
    private double r;

    public Circle ( ) {
      r = 1;
    }

    public Circle ( int x, int y, int r ) : base( x, y ) {
      this.r = r;
    }

    public void SetSquare ( double value ) {
      if ( value > 0 )
        r = Math.Sqrt( value / Math.PI );
    }

    public double GetSquare ( ) {
      return Math.PI * r * r;
    }

    public double RoFrom ( Circle circle ) {
      return Math.Sqrt( Math.Pow( ( circle.x - this.x ), 2 ) + Math.Pow( ( circle.y - this.y ), 2 ) );
    }

    public new string Info ( ) {
      return string.Format( "Круг ({0,5:F1},{1,5:F1}  ), R = {2,5:F1}", x, y, r );
    }


  }
}
