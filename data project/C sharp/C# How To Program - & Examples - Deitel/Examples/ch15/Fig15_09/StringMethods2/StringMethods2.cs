// Fig. 15.9: StringMiscellaneous2.cs
// Demonstrating String methods Replace, ToLower, ToUpper, Trim, 
// ToString and ToCharArray.

using System;
using System.Windows.Forms;

namespace StringMethods2
{
   /// <summary>
   /// Summary description for StringMethods2.
   /// </summary>
   class StringMethods2
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string string1 = "cheers!";
         string string2 = "GOOD BYE ";
         string string3 = "   spaces   ";
         string output;

         output = "string1 = \"" + string1 + "\"\n" +
            "string2 = \"" + string2 + "\"\n" +
            "string3 = \"" + string3 + "\"";

         // call method Replace
         output += "\n\nReplacing \"e\" with \"E\" in string1: \"" +
            string1.Replace( 'e', 'E' ) + "\"";

         // call ToLower and ToUpper
         output += "\n\nstring1.ToUpper() = \"" +
            string1.ToUpper() + "\"\nstring2.ToLower() = \"" +
            string2.ToLower() + "\"";

         // call Trim method
         output += "\n\nstring3 after trim = \"" +
            string3.Trim() + "\"";

         // call ToString method
         output += "\n\nstring1 = \"" + string1.ToString() + "\"";

         MessageBox.Show( output, "Demonstrating various string methods",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringMethods2
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