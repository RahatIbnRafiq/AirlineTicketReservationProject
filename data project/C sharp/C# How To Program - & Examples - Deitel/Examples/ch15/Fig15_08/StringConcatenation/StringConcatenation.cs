// Fig. 15.8: SubConcatination.cs
// Demonstrating String class ConCat method.

using System;
using System.Windows.Forms;

namespace StringConcatenation
{
   /// <summary>
   /// Summary description for StringConcatenation.
   /// </summary>
   class StringConcatenation
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string string1 = "Happy ";
         string string2 = "Birthday";
         string output;

         output = "string1 = \"" + string1 + "\"\n" +
            "string2 = \"" + string2 + "\"";

         output += "\n\nResult of String.Concat( string1, string2 ) = " +
            String.Concat( string1, string2 );

         output += "\nstring1 after concatenation = " + string1;

         MessageBox.Show( output, "Demonstrating String method Concat",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main
      
   } // end class StringConcatenation
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