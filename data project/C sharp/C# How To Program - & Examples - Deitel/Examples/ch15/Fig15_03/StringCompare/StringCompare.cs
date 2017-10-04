// Fig. 15.3: StringCompare.cs
// Comparing strings.

using System;
using System.Windows.Forms;

namespace StringCompare
{
   /// <summary>
   /// compare a number of strings
   /// </summary>
   class StringCompare
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string string1 = "hello";
         string string2 = "good bye";
         string string3 = "Happy Birthday";
         string string4 = "happy birthday";
         string output;

         // output values of four strings
         output = "string1 = \"" + string1 + "\"" +
            "\nstring2 = \"" + string2 + "\"" +
            "\nstring3 = \"" + string3 + "\"" +
            "\nstring4 = \"" + string4 + "\"\n\n";

         // test for equality using Equals method
         if ( string1.Equals( "hello" ) )
            output += "string1 equals \"hello\"\n";
         else
            output += "string1 does not equal \"hello\"\n";

         // test for equality with ==
         if ( string1 == "hello" )
            output += "string1 equals \"hello\"\n";
         else
            output += "string1 does not equal \"hello\"\n";

         // test for equality comparing case
         if ( string.Equals( string3, string4 ) )
            output += "string3 equals string4\n";
         else
            output += "string3 does not equal string4\n";

         // test CompareTo
         output += "\nstring1.CompareTo( string2 ) is " +
            string1.CompareTo( string2 ) + "\n" +
            "string2.CompareTo( string1 ) is " +
            string2.CompareTo( string1 ) + "\n" +
            "string1.CompareTo( string1 ) is " +
            string1.CompareTo( string1 ) + "\n" +
            "string3.CompareTo( string4 ) is " +
            string3.CompareTo( string4 ) + "\n" +
            "string4.CompareTo( string3 ) is " +
            string4.CompareTo( string3 ) + "\n\n";

         MessageBox.Show( output, "Demonstrating string " +
            "comparisons", MessageBoxButtons.OK, 
            MessageBoxIcon.Information );

      } // end method Main

   } // end class StringCompare
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