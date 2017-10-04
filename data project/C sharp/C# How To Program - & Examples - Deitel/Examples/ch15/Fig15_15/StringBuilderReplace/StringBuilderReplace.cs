// Fig. 15.15: StringBuilderReplace.cs
// Demonstrating method Replace.

using System;
using System.Windows.Forms;
using System.Text;

namespace StringBuilderReplace
{
   /// <summary>
   /// testing the Replace method
   /// </summary>
   class StringBuilderReplace
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         StringBuilder builder1 = 
            new StringBuilder( "Happy Birthday Jane" );

         StringBuilder builder2 = 
            new StringBuilder( "good bye greg" );

         string output = "Before replacements:\n" +
            builder1.ToString() + "\n" + builder2.ToString();

         builder1.Replace( "Jane", "Greg" );
         builder2.Replace( 'g', 'G', 0, 5 );

         output += "\n\nAfter replacements:\n" +
            builder1.ToString() + "\n" + builder2.ToString();

         MessageBox.Show( output, "Using StringBuilder method Replace",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringBuilderReplace
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