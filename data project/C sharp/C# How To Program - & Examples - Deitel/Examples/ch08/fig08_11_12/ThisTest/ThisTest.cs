// Fig. 8.12: ThisTest.cs
// Using the this reference.

using System;
using System.Windows.Forms;

namespace ThisTest
{
   // ThisTest class definition
   class ThisTest
   {
      // main entry point for application
      static void Main(string[] args)
      {
         Time4 time = new Time4( 12, 30, 19 );
        
         MessageBox.Show( time.BuildString(), 
            "Demonstrating the \"this\" Reference" );
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
