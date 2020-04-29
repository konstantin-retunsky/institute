using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork {
  class N2 {
    private string _name;
    private int _value;
    public N2 ( string Name ) {
      _name = Name;
      _value = 10;
    }
    public string Name {
      get {
        return _name;
      }
    }
    public int Val {
      get {
        return _value;
      }
      set {
        SetN2( value );
      }
    }
    public bool Odd {
      get {
        return Val % 2 == 1;
      }
    }
    public int D1 {
      get {
        return Val / 10;
      }
      set {
        if ( value >= 1 && value <= 9 )
          Val = value * 10 + D2;
      }
    }
    public int D2 {
      get {
        return Val % 10;
      }
      set {
        if ( value >= 0 && value <= 9 )
          Val = D1 * 10 + value;
      }
    }
    public void SetN2 ( int value ) {
      if ( value >= 10 && value <= 99 )
        _value = value;
    }
    public void Swap ( ) {
      Val = D2 * 10 + D1;
    }
    public bool LessThen ( N2 d ) {
      return Val < d.Val;
    }
    public string Info ( ) {
      string result = string.Format(
                "Двузначное число '{0}'={1}. Цифры {2} и {3}.",
                Name, Val, D1, D2);
      if ( Odd )
        result += " Нечётное";
      else
        result += " Чётное";
      return result;
    }
    public void Show ( ) {
      Console.WriteLine( Info( ) );
    }

    //ТЗ
    public bool IsSimm ( N2 d ) {
      return Val == d.Val;
    }
    public int DigSum {
      get {
        return D1 + D2;
      }
      set {
        if ( value > 0 & value < 19 ) {
          for ( int i = 10; i < 100; i++ ) {
            if ( D1 + D2 == value )
              Val = Val;
            else
              Val = i;
          }
        }
      }
    }

    public bool DigSimple {
      get {
        if ( Val > 1 ) {
          // в цикле перебираем числа от 2 до n - 1
          for ( int i = 2; i < Val; i++ )
            if ( Val % i == 0 ) // если n делится без остатка на i - возвращаем false (число не простое)
              return false;

          // если программа дошла до данного оператора, то возвращаем true (число простое) - проверка пройдена
          return true;
        } else // иначе возвращаем false (число не простое)
          return false;
      }
    }
  }
}
