// Fig. 7.4: SumArray.cs
// Computing the sum of the elements in an array.

using System;
using System.Windows.Forms;

namespace SumArray
{
   /// <summary>
   /// Summary description for SumArray.
   /// </summary>
   class SumArray
   {
      // main entry point for application
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         int total = 0;

         for ( int i = 0; i < a.Length; i++ )
            total += a[ i ];

         MessageBox.Show( "Total of array elements: " + total,
            "Sum the elements of an array",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end Main

   } // end class SumArray

} // end namespace SumArray

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
