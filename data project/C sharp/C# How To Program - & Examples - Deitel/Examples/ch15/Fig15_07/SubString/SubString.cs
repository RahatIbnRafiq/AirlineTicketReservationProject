// Fig. 15.7: SubString.cs
// Demonstrating the String Substring method.

using System;
using System.Windows.Forms;

namespace SubString
{
   /// <summary>
   /// creating substrings
   /// </summary>
   class SubString
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string letters = "abcdefghijklmabcdefghijklm";
         string output = "";

         // invoke Substring method and pass it one parameter
         output += "Substring from index 20 to end is \"" +
            letters.Substring( 20 ) + "\"\n";

         // invoke Substring method and pass it two parameters
         output += "Substring from index 0 to 6 is \"" +
            letters.Substring( 0, 6 ) + "\"";

         MessageBox.Show( output, 
            "Demonstrating String method Substring",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class SubString
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
