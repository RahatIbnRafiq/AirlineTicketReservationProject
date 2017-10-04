// Fig. 8.11: Time4.cs
// Class Time4 provides overloaded constructors.

using System;

namespace ThisTest
{
   // Time4 class definition
   public class Time4 : Object
   {
      private int hour;    // 0-23
      private int minute;  // 0-59
      private int second;  // 0-59

      // constructor
      public Time4( int hour, int minute, int second ) 
      { 
         this.hour = hour;
         this.minute = minute;
         this.second = second;
      }

      // create string using this and implicit references
      public string BuildString()
      {
         return "this.ToStandardString(): " + 
            this.ToStandardString() + 
            "\nToStandardString(): " + ToStandardString();
      }

      // convert time to standard-time (12-hour) format string
      public string ToStandardString()
      {
         return String.Format( "{0}:{1:D2}:{2:D2} {3}",
            ( ( this.hour == 12 || this.hour == 0 ) ? 12 : 
            this.hour % 12 ), this.minute, this.second,
            ( this.hour < 12 ? "AM" : "PM" ) );
      }      

   } // end class Time4
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
