// Fig. 5.5: Sum.cs
// Summation with the for structure.

using System;
using System.Windows.Forms;

namespace csphtp1.ch05.fig05_05
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Sum
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int sum = 0;

         for ( int number = 2; number <= 100; number += 2 )
            sum += number;

         MessageBox.Show( "The sum is " + sum, 
            "Sum Even Integers from 2 to 100",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information );

      } // end of method Main
	
   } // end of class Sum

} // end of namespace csphtp1.ch05.fig05_05

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