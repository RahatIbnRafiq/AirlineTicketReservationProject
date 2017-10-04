// Fig. 15.5: StringHashCode.cs
// Demonstrating method GetHashCode of class String.

using System;
using System.Windows.Forms;

namespace StringHashCode
{
   /// <summary>
   /// testing the GetHashCode method
   /// </summary>
   class StringHashCode
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {

         string string1 = "hello";
         string string2 = "Hello";
         string output;

         output = "The hash code for \"" + string1 +
            "\" is " + string1.GetHashCode() + "\n";

         output += "The hash code for \"" + string2 +
            "\" is " + string2.GetHashCode() + "\n";

         MessageBox.Show( output, "Demonstrating String " +
            "method GetHashCode",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringHashCode
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
