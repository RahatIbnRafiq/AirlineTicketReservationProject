// Fig. 5.15: ContinueTest.cs
// Using the continue statement in a for structure.

using System;
using System.Windows.Forms;

namespace ContinueTestSpace
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class ContinueTest
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         string output = "";

         for ( int count = 1; count <= 10; count++ )
         {
            if ( count == 5 )
               continue;       // skip remaining code in loop
            // only if count == 5

            output += count + " ";
         }

         output += "\nUsed continue to skip printing 5";
      
         MessageBox.Show( output, "Using the continue statement",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class ContinueTest

} // end namespace ContinueTestSpace

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

