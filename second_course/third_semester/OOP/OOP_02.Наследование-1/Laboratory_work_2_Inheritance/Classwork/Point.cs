using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork {
  class Point {
    protected double x, y;

    public Point ( ) {
      x = 0;
      y = 0;
    }

    public Point ( int x, int y ) {
      this.x = x;
      this.y = y;
    }

    public void Move ( int dx, int dy ) {
      x += dx;
      y += dy;
    }

    public void Simm ( ) {
      x *= -1;
      y *= -1;
    }

    public double RoFrom ( Point point ) {
      return Math.Sqrt( ( Math.Pow( ( point.x - this.x ), 2 ) + Math.Pow( ( point.y - this.y ), 2 ) ) );
    }

    public string Info ( ) {
      return string.Format( "Точка ({0,5:F1},{1,5:F1}  )", x, y );
    }


  }
}
