// Fig. 15.1: StringConstructor.cs
// Demonstrating String class constructors.

using System;
using System.Windows.Forms;

namespace StringConstructor
{
   /// <summary>
   /// test several String class constructors
   /// </summary>
   class StringConstructor
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main( string[] args )
      {
         string output;
         string originalString, string1, string2, 
			 string3, string4;

         char[] characterArray = 
            { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };

         // string initialization
         originalString = "Welcome to C# programming!";
         string1 = originalString;
         string2 = new string( characterArray );
         string3 = new string( characterArray, 6, 3 );
         string4 = new string( 'C', 5 );

         output = "string1 = " + "\"" + string1 + "\"\n" +
            "string2 = " + "\"" + string2 + "\"\n" +
            "string3 = " + "\"" + string3 + "\"\n" +
            "string4 = " + "\"" + string4 + "\"\n";

         MessageBox.Show( output, "String Class Constructors",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringConstructor
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