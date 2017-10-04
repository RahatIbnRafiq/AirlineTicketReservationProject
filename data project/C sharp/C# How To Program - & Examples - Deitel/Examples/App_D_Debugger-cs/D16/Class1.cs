// Fig. D.16: MethodDebugExample.cs
// Demonstrates debugging methods.

using System;

namespace Debug
{

   // provides methods on which to demonstrate 
   // Visual Studio’s debug tools
   class MethodDebug
   {
      // entry point for application
      static void Main( string[] args )
      {
         // display MyMethod return values
         for ( int i = 0; i < 10; i++ )
            Console.WriteLine( MyMethod( i ) );

         Console.ReadLine();
      } // end method main

      // perform calculation
      static int MyMethod( int x )
      {
         return ( x * x ) - ( 3 * x ) + 7;
      } // end method MyMethod

      // method with logic error
      static int BadMethod( int x )
      {
         return 1 / ( x - x );
      } // end method BadMethod

   } // end class MethodDebug

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