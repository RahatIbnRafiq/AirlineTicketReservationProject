// Fig. 5.14: BreakTest.cs
// Using the break statement in a for structure.

using System;
using System.Windows.Forms;

namespace BreakTestSpace
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class BreakTest
   {
      static void Main( string[] args  )
      {
         //
         // TODO: Add code to start application here
         //

         string output = "";
         int count;

         for ( count = 1; count <= 10; count++ )
         {
            if ( count == 5 )
               break;           // skip remaining code in loop 
            // if count == 5

            output += count + " ";

         } // end for loop

         output += "\nBroke out of loop at count = " + count;

         MessageBox.Show( output, "Demonstrating the break statement",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class BreakTest

} // end namespace BreakTestSpace
 
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
