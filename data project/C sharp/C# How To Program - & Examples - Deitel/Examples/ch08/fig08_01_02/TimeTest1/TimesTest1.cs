// Fig. 8.2: TimeTest1.cs
// Demonstrating class Time1.

using System;
using System.Windows.Forms;

namespace TimeTest1
{
   // TimeTest1 uses creates and uses a Time1 object
   class TimeTest1
	{
		// main entry point for application
		static void Main( string[] args )
		{
         Time1 time = new Time1();  // calls Time1 constructor
         string output;

         // assign string representation of time to output
         output = "Initial universal time is: " +
            time.ToUniversalString() +
            "\nInitial standard time is: " +
            time.ToStandardString();

         // attempt valid time settings
         time.SetTime( 13, 27, 6 );

         // append new string representations of time to output
         output += "\n\nUniversal time after SetTime is: " +
            time.ToUniversalString() +
            "\nStandard time after SetTime is: " +
            time.ToStandardString();

         // attempt invalid time settings
         time.SetTime( 99, 99, 99 );

         output += "\n\nAfter attempting invalid settings: " +
            "\nUniversal time: " + time.ToUniversalString() +
            "\nStandard time: " + time.ToStandardString();

         MessageBox.Show( output, "Testing Class Time1" );
      
      } // end method Main

	} // end class TimeTest1
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