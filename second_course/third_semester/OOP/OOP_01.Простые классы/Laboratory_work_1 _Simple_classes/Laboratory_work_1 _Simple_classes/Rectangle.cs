using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1__Simple_classes {
  sealed class Rectangle {
    private int width;
    private int height;

    public int Width {
      get => width; set => width = value <= 0 ? 1 : value;
    }
    public int Height {
      get => height; set => height = value <= 0 ? 1 : value;
    }

    public Rectangle ( ) {
      Width = 1;
      Height = 1;
    }

    public void Set ( int w, int h ) {
      if ( w > 0 & h > 0 ) {
        Width = w;
        Height = h;
      }
    }

    public int Square ( ) {
      return ( int ) Width * ( int ) Height;
    }

    public void SetSquare ( int square ) {
      int c = (int)Math.Sqrt(square / (Height * Width));
      Width *= c;
      Height *= c;
    }

    public string Info ( ) {
      return "Ширина: " + Width + ", Длина: " + Height + ", Площадь: " + Width * Height + ".";
    }

    public bool EqualityOfRectangles ( Rectangle rectangle ) {
      if ( Width == rectangle.Width & Height == rectangle.Height )
        return true;
      return false;
    }
  }
}
