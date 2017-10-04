// Fig. 8.4: Time2.cs
// Class Time2 provides overloaded constructors.

using System;

namespace TimeTest2
{
   // Time2 class definition
   public class Time2 : Object
   {
      private int hour;    // 0-23
      private int minute;  // 0-59
      private int second;  // 0-59

      // Time2 constructor initializes instance variables to 
      // zero to set default time to midnight
      public Time2()
      {
         SetTime( 0, 0, 0 );
      }

      // Time2 constructor: hour supplied, minute and second
      // defaulted to 0
      public Time2( int hour ) 
      { 
         SetTime( hour, 0, 0 ); 
      }

      // Time2 constructor: hour and minute supplied, second
      // defaulted to 0
      public Time2( int hour, int minute ) 
      { 
         SetTime( hour, minute, 0 );
      }

      // Time2 constructor: hour, minute and second supplied
      public Time2( int hour, int minute, int second ) 
      { 
         SetTime( hour, minute, second ); 
      }

      // Time2 constructor: initialize using another Time2 object
      public Time2( Time2 time )
      {
         SetTime( time.hour, time.minute, time.second );
      }

      // Set new time value in 24-hour format. Perform validity
      // checks on the data. Set invalid values to zero.
      public void SetTime( 
         int hourValue, int minuteValue, int secondValue )
      {
         hour = ( hourValue >= 0 && hourValue  < 24 ) ? 
         hourValue  : 0;
         minute = ( minuteValue >= 0 && minuteValue < 60 ) ?
         minuteValue : 0;
         second = ( secondValue >= 0 && secondValue < 60 ) ? 
         secondValue : 0;
      }

      // convert time to universal-time (24 hour) format string
      public string ToUniversalString()
      {
         return String.Format( 
            "{0:D2}:{1:D2}:{2:D2}", hour, minute, second );
      }

      // convert time to standard-time (12 hour) format string
      public string ToStandardString()
      {
         return String.Format( "{0}:{1:D2}:{2:D2} {3}",
            ( ( hour == 12 || hour == 0 ) ? 12 : hour % 12 ),
            minute, second, ( hour < 12 ? "AM" : "PM" ) );
      }      

   } // end class Time2
}

/*
 ************************************************************************** 
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/
