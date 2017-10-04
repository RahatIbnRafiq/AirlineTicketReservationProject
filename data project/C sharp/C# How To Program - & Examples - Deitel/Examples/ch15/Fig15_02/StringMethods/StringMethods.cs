// Fig. 15.2: StringMethods.cs
// Using the indexer, property Length and method CopyTo
// of class String.

using System;
using System.Windows.Forms;

namespace StringMethods
{
   /// <summary>
   /// Summary description for StringMethods.
   /// </summary>
   class StringMethods
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string string1, output;
         char[] characterArray;

         string1 = "hello there";
         characterArray = new char[ 5 ];

         // output string
         output = 
            "string1: \"" + string1 + "\"";

         // test Length property
         output += "\nLength of string1: " + string1.Length;

         // loop through character in string1 and display
         // reversed
         output += "\nThe string reversed is: ";

         for ( int i = string1.Length - 1; i >= 0; i-- )
            output += string1[ i ];

         // copy characters from string1 into characterArray
         string1.CopyTo( 0, characterArray, 0, 5 );
         output += "\nThe character array is: ";

         for ( int i = 0 ; i < characterArray.Length; i++ )
            output += characterArray[ i ];

         MessageBox.Show( output, "Demonstrating the string " +
            "Indexer, Length Property and CopyTo method",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringMethods
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