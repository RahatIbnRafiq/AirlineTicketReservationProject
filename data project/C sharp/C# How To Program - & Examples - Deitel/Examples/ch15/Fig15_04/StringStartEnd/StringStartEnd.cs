// Fig. 15.4: StringStartEnd.cs
// Demonstrating StartsWith and EndsWith methods.

using System;
using System.Windows.Forms;

namespace StringStartEnd
{
   /// <summary>
   /// testing StartsWith and EndsWith
   /// </summary>
   class StringStartEnd
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string[] strings = 
            { "started", "starting", "ended", "ending" };
         string output = "";

         //test every string to see if it starts with "st"
         for ( int i = 0; i < strings.Length; i++ )

            if ( strings[ i ].StartsWith( "st" ) )
               output += "\"" + strings[ i ] + "\"" +
                  " starts with \"st\"\n";

         output += "\n";

         // test every string to see if it ends with "ed"
         for ( int i = 0; i < strings.Length; i ++ )

            if ( strings[ i ].EndsWith( "ed" ) )
               output += "\"" + strings[ i ] + "\"" +
                  " ends with \"ed\"\n";

         MessageBox.Show( output, "Demonstrating StartsWtih and " +
            "EndsWith methods", MessageBoxButtons.OK, 
            MessageBoxIcon.Information );

      } // end method Main

   } // end class StringStartEnd
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