// Fig. 5.8: Interest.cs
// Calculating compound interest.

using System;
using System.Windows.Forms;

namespace InterestSpace
{
   /// <summary>
   /// Summary description for Interest.
   /// </summary>
   class Interest
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         decimal amount, principal = ( decimal ) 1000.00; 
         double rate = .05;
         string output;

         output = "Year\tAmount on deposit\n";
        
         for ( int year = 1; year <=10; year++ )
         {
            amount = principal * 
               ( decimal ) Math.Pow( 1.0 + rate, year );
         
            output += year + "\t" + 
               String.Format( "{0:C}", amount) + "\n";
         }

         MessageBox.Show( output, "Compound Interest", 
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class Interest

} // end namespace InterestSpace

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
