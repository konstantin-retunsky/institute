using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork {
  class Time24 {
    private int hour;
    private int min;

    public int Hour {
      get => hour; set => hour = value < 0 | value > 24 ? 0 : value;
    }
    public int Min {
      get => min; set => min = value < 0 | value > 60 ? 0 : value;
    }
    public double HourR {
      get => Hour + ( ( double ) Min / 100 );
    }
    public string DayTime {
      get {
        if ( Hour >= 0 & Hour <= 5 )
          return "Ночь";
        else if ( Hour > 5 & Hour <= 12 )
          return "Утро";
        else if ( Hour > 12 & Hour <= 16 )
          return "День";
        else
          return "Вечер";
      }
    }

    public Time24 ( int hour ) {
      Hour = hour;
      Min = 0;
    }

    public void Assign ( Time24 time24 ) {
      Hour = time24.Hour;
      Min = time24.Min;
    }

    public bool Compare ( Time24 time24 ) => Hour == time24.Hour & Min == time24.Min;

    public void NextMin ( ) {
      if ( Min + 1 > 60 ) {
        Min = 0;
        Hour += 1;
      } else
        Min += 1;
    }

    public void PredMin ( ) {
      if ( Min - 1 < 0 ) {
        Min = 0;
        Hour -= 1;
      } else
        Min -= 1;
    }

    public double HourBetween ( Time24 time24 ) => Math.Abs( HourR - time24.HourR );

    public int MinBetween ( Time24 time24 ) => Math.Abs( Min - time24.Min );

    public Time24 TimeRemain ( Time24 time24 ) {
      Time24 timeRemain = new Time24(0);
      timeRemain.Hour = Math.Abs( Hour - time24.Hour );
      timeRemain.Min = Math.Abs( Min - time24.Min );
      return timeRemain;
    }

    public void NearHour ( ) {
      if ( Min >= 30 )
        Hour += 1;
      else
        Hour -= 1;
      Min = 0;
    }

    public string Info ( ) {
      string nullS = "0";
      return "Время " + ( Hour < 10 ? nullS + Hour : "" + Hour ) + ":" +
          ( Min < 10 ? nullS + Min : "" + Min ) + " => " + DayTime + ".";
    }

    public void Show ( ) => Console.WriteLine( Info( ) );

    //Доп задание  // + три своих метода (типа void, типа Time24 и любого типа)
    public void NextTime ( Time24 time24 ) {
      int hour = default,
                min = Min + time24.Min;
      if ( min > 60 )
        hour = Hour + 1 + time24.Hour;
      else
        hour = Hour + time24.Hour;
      if ( hour > 24 )
        hour -= 24;
      if ( min > 60 )
        min -= 60;
      Hour = hour;
      Min = time24.Min;
    }

    public string Time12 ( ) {
      Time24 time12 = new Time24(Hour > 12 ? Hour - 12 : Hour);
      time12.Min = Min;
      string nullS = "0";
      return "Время " + ( time12.Hour < 10 ? nullS + time12.Hour : "" + time12.Hour ) + ":" +
          ( time12.Min < 10 ? nullS + time12.Min : "" + time12.Min ) + ".";
    }

    public Time24 NextHour ( int hour ) {
      hour += Hour;
      while ( hour > 24 ) {
        hour -= 24;
      }
      Time24 time24 = new Time24(hour);
      time24.Min = Min;
      return time24;
    }
  }
}
