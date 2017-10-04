// Fig. 8.19: AssemblyTest.cs
// Using class Time3 from assembly TimeLibrary.

using System;
using TimeLibrary;

namespace AssemblyTest
{
   // AssemblyTest class definition
   class AssemblyTest
   {
      // main entry point for application
      static void Main( string[] args )
      {
         Time3 time = new Time3( 13, 27, 6 );

         Console.WriteLine( 
            "Standard time: {0}\nUniversal time: {1}\n",
            time.ToStandardString(), time.ToUniversalString() );
      }
   }
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
