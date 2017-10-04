// Fig 7.3: InitArray.cs
// Different ways of initializing arrays.

using System;
using System.Windows.Forms;

namespace InitArray
{
   /// <summary>
   /// Summary description for InitArray.
   /// </summary>
   class InitArray
   {
      // main entry point for application
      static void Main( string[] args )
      {
         string output = "";

         int[] x;            // declare reference to an array
         x = new int[ 10 ];  // dynamically allocate array and set
                             // default values

         // initializer list specifies number of elements
         // and value of each element
         int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

         const int ARRAY_SIZE = 10; // named constant
         int[] z;                   // reference to int array

         // allocate array of ARRAY_SIZE (i.e., 10) elements
         z = new int[ ARRAY_SIZE ];

         // set the values in the array
         for ( int i = 0; i < z.Length; i++ )
            z[ i ] = 2 + 2 * i;

         output += "Subscript\tArray x\tArray y\tArray z\n";

         // output values for each array
         for ( int i = 0; i < ARRAY_SIZE; i++ )
            output += i + "\t" + x[ i ] + "\t" + y[ i ] + 
               "\t" + z[ i ] + "\n";

         MessageBox.Show( output, 
            "Initializing an array of int values", 
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end Main

   } // end class InitArray

} // end namespace InitArray

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
