// Fig. 8.3: RestrictedAccess.cs
// Demonstrate compiler errors from attempt to access 
// private class members.

namespace RestrictedAccess
{
   class RestrictedAccess
   {
      // main entry point for application
      static void Main( string[] args )
      {
         Time1 time = new Time1();

         time.hour = 7;
         time.minute = 15;
         time.second = 30;
      }

   } // end class RestrictedAccess
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
