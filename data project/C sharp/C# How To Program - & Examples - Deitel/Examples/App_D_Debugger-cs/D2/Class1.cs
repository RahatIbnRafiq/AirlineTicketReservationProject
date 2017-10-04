// Fig. D.2: DebugExample.cs
// Sample program to debug.

using System;

namespace Debug
{
   class DebugExample
   {
      static void Main( string[] args )
      {     
         int x = 10;

         Console.Write( "The value of " + x + " factorial is: " );

         // loop to determine x factorial, contains logic error
         for ( int i = x; i >= 0; i-- )
            x *= i;

         Console.Write( x );

         Console.ReadLine(); // delay program exit

      } // end main

   } // end class DebugExample

} // end namespace Debug


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