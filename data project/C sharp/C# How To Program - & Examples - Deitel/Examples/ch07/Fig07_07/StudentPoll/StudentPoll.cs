// Fig. 7.7: StudentPoll.cs
// A student poll program.

using System;
using System.Windows.Forms;

namespace StudentPoll
{
   /// <summary>
   /// Summary description for StudentPoll.
   /// </summary>
   class StudentPoll
   {
      // main entry point for application
      static void Main( string[] args )
      {
         int[] responses = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1,
            6, 3, 8, 6, 10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7,
            5, 6, 6, 5, 6, 7, 5, 6, 4, 8, 6, 8, 10 };

         int[] frequency = new int[ 11 ];
         string output = "";

         // increment the frequency for each response
         for ( int answer = 0; answer < responses.Length; answer++ )
            ++frequency[ responses[ answer ] ];

         output += "Rating\tFrequency\n";

         // output results
         for ( int rating = 1; rating < frequency.Length; rating++ )
            output += rating + "\t" + frequency[ rating ] + "\n";

         MessageBox.Show( output, "Student poll program", 
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class StudentPoll

} // end namespace StudentPoll

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