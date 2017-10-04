// Fig. 7.5: Histogram.cs
// Using data to create a histogram.

using System;
using System.Windows.Forms;

namespace Histogram
{
   /// <summary>
   /// Summary description for Histogram.
   /// </summary>
   class Histogram
   {
      // main entry point for application
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int[] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };
         string output = "";

         output += "Element\tvalue\tHistogram\n";

         // build output
         for ( int i = 0; i < n.Length; i++ )
         {
            output += "\n" + i + "\t" + n[ i ] + "\t";

            for ( int j = 1; j <= n[ i ]; j++ ) // print a bar
               output += "*";
         }

         MessageBox.Show( output, "Histogram Printing Program",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end Main

   } // end class Histogram

} // end namespace Histogram

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