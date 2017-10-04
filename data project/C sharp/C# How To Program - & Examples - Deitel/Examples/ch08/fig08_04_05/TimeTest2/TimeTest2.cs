// Fig. 8.5: TimeTest2.cs
// Using overloaded constructors.

using System;
using System.Windows.Forms;

namespace TimeTest2
{
   // TimeTest2 demonstrates constructors of class Time2
   class TimeTest2
   {
      // main entry point for application
      static void Main(string[] args)
      {
         Time2 time1, time2, time3, time4, time5, time6;

         time1 = new Time2();               // 00:00:00
         time2 = new Time2( 2 );            // 02:00:00
         time3 = new Time2( 21, 34 );       // 21:34:00
         time4 = new Time2( 12, 25, 42 );   // 12:25:42
         time5 = new Time2( 27, 74, 99 );   // 00:00:00
         time6 = new Time2( time4 );        // 12:25:42

         String output = "Constructed with: " +
            "\ntime1: all arguments defaulted" +
            "\n\t" + time1.ToUniversalString() +
            "\n\t" + time1.ToStandardString();

         output += "\ntime2: hour specified; minute and " +
            "second defaulted" +
            "\n\t" + time2.ToUniversalString() +
            "\n\t" + time2.ToStandardString();

         output += "\ntime3: hour and minute specified; " +
            "second defaulted" +
            "\n\t" + time3.ToUniversalString() +
            "\n\t" + time3.ToStandardString();

         output += "\ntime4: hour, minute, and second specified" +
            "\n\t" + time4.ToUniversalString() +
            "\n\t" + time4.ToStandardString();

         output += "\ntime5: all invalid values specified" +
            "\n\t" + time5.ToUniversalString() +
            "\n\t" + time5.ToStandardString();

         output += "\ntime6: Time2 object time4 specified" +
            "\n\t" + time6.ToUniversalString() +
            "\n\t" + time6.ToStandardString();

         MessageBox.Show( output,
            "Demonstrating Overloaded Constructors" );

      } // end method Main

   } // end class TimeTest2
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
