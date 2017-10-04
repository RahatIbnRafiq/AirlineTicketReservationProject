// Fig. 15.10: StringBuilderConstructor.cs
// Demonstrating StringBuilder class constructors.

using System;
using System.Windows.Forms;
using System.Text;

namespace StringBuilderConstructor
{
   /// <summary>
   /// Summary description for StringBuilderConstructor.
   /// </summary>
   class StringBuilderConstructor
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         StringBuilder buffer1, buffer2, buffer3;
         string output;

         buffer1 = new StringBuilder();
         buffer2 = new StringBuilder( 10 );
         buffer3 = new StringBuilder( "hello" );

         output = "buffer1 = \"" + buffer1.ToString() + "\"\n";

         output += "buffer2 = \"" + buffer2.ToString() + "\"\n";

         output += "buffer3 = \"" + buffer3.ToString() + "\"\n";

         MessageBox.Show( output, "Demonstrating StringBuilder class constructors",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringBuilderConstructor
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