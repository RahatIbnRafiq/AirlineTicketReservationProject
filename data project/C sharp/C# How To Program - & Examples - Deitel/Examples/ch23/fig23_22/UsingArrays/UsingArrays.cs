// Fig. 23.22: UsingArray.cs
// Using Array class to perform common array manipulations.

using System;
using System.Windows.Forms;
using System.Collections;

namespace UsingArray
{
   // demonstrate algorithms of class Array
   class UsingArray
   {
      private int[] intValues = { 1, 2, 3, 4, 5, 6 };
      private double[] doubleValues = 
         { 8.4, 9.3, 0.2, 7.9, 3.4 };
      private int[] intValuesCopy;
      private string output; 

      // method to build and display program output
      public void Start()
      {
         intValuesCopy = new int[ intValues.Length ];
               
         output = "Initial array values:\n";
         PrintArray(); // output initial array contents

         // sort doubleValues
         Array.Sort( doubleValues );

         // copy intValues into intValuesCopy
         Array.Copy( intValues, intValuesCopy, 
            intValues.Length );

         output += "\nArray values after Sort and Copy:\n";
         PrintArray(); // output array contents
         output += "\n";
      
         // search for 5 in intValues
         int result = Array.BinarySearch( intValues, 5 );
         output += 
            ( result >= 0 ? "5 found at element " + result :
            "5 not found" ) + " in intValues\n";

         // search for 8763 in intValues
         result = Array.BinarySearch( intValues, 8763 );
         output += 
            ( result >= 0 ? "8763 found at element " + result :
            "8763 not found" ) + " in intValues";

         MessageBox.Show( output, "Using Class Array",
            MessageBoxButtons.OK, MessageBoxIcon.Information );
      }
      
      // append array content to output string
      private void PrintArray()
      {
         output += "doubleValues: ";

         foreach ( double element in doubleValues )
            output += element + " ";

         output += "\nintValues: ";

         foreach ( int element in intValues )
            output += element + " ";

         output += "\nintValuesCopy: ";

         foreach ( int element in intValuesCopy )
            output += element + " ";

         output += "\n";
      }

      // main entry point for application
      static void Main( string[] args )
      {
         UsingArray application = new UsingArray();

         application.Start();
      }

   } // end class UsingArray
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
