// Fig. 15.6: StringIndexMethods.cs
// Using String searching methods.

using System;
using System.Windows.Forms;

namespace StringIndexMethods
{
   /// <summary>
   /// testing indexing capabilities of strings
   /// </summary>
   class StringIndexMethods
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string letters = "abcdefghijklmabcdefghijklm";
         string output = "";
         char[] searchLetters = { 'c', 'a', '$' };

         // test IndexOf to locate a character in a string
         output += "'c' is located at index " +
            letters.IndexOf( 'c' );

         output += "\n'a' is located at index " +
            letters.IndexOf( 'a', 1 );

         output += "\n'$' is located at index " +
            letters.IndexOf( '$', 3, 5 );

         // test LastIndexOf to find a character in a string
         output += "\n\nLast 'c' is located at " +
            "index " + letters.LastIndexOf( 'c' );

         output += "\nLast 'a' is located at index " +
            letters.LastIndexOf( 'a', 25 );

         output += "\nLast '$' is located at index " +
            letters.LastIndexOf( '$', 15, 5 );

         // test IndexOf to locate a substring in a string
         output += "\n\n\"def\" is located at" +
            " index " + letters.IndexOf( "def" );

         output += "\n\"def\" is located at index " +
            letters.IndexOf( "def", 7 );

         output += "\n\"hello\" is located at index " +
            letters.IndexOf( "hello", 5, 15 );

         // test LastIndexOf to find a substring in a string
         output += "\n\nLast \"def\" is located at index " +
            letters.LastIndexOf( "def" );

         output += "\nLast \"def\" is located at " +
            letters.LastIndexOf( "def", 25 );

         output += "\nLast \"hello\" is located at index " +
            letters.LastIndexOf( "hello", 20, 15 );

         // test IndexOfAny to find first occurrence of character
         // in array
         output += "\n\nFirst occurrence of 'c', 'a', '$' is " +
            "located at " + letters.IndexOfAny( searchLetters );

         output += "\nFirst occurrence of 'c, 'a' or '$' is " +
            "located at " + letters.IndexOfAny( searchLetters, 7 );

         output += "\nFirst occurrence of 'c', 'a' or '$' is " +
            "located at " + letters.IndexOfAny( searchLetters, 20, 5 );

         // test LastIndexOfAny to find last occurrence of character
         // in array
         output += "\n\nLast occurrence of 'c', 'a' or '$' is " +
            "located at " + letters.LastIndexOfAny( searchLetters );

         output += "\nLast occurrence of 'c', 'a' or '$' is " +
            "located at " + letters.LastIndexOfAny( searchLetters, 1 );

         output += "\nLast occurrence of 'c', 'a' or '$' is " +
            "located at " + letters.LastIndexOfAny( searchLetters, 25, 5 );

         MessageBox.Show( output, "Demonstrating class index methods",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StringIndexMethods
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