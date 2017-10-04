// Fig. 15.11: StringBuilderFeatures.cs
// Demonstrating some features of class StringBuilder.

using System;
using System.Windows.Forms;
using System.Text;

namespace StringBuilderFeatures
{
   /// <summary>
   /// some of class StringBuilder’s methods
   /// </summary>
   class StringBuilderFeatures
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         StringBuilder buffer = 
            new StringBuilder( "Hello, how are you?" );

         // use Length and Capacity properties
         string output = "buffer = " + buffer.ToString() +
            "\nLength = " + buffer.Length +
            "\nCapacity = " + buffer.Capacity;

         // use EnsureCapacity method
         buffer.EnsureCapacity( 75 );

         output += "\n\nNew capacity = " +
            buffer.Capacity;

         // truncate StringBuilder by setting Length property
         buffer.Length = 10;

         output += "\n\nNew length = " +
            buffer.Length + "\nbuffer = ";

         // use StringBuilder indexer
         for ( int i = 0; i < buffer.Length; i++ )
            output += buffer[ i ];

         MessageBox.Show( output, "StringBuilder features",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringBuilderFeatures
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