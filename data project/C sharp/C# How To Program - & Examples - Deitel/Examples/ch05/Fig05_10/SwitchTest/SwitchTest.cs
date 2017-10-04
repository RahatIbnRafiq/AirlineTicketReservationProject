// Fig. 5.10: SwitchTest.cs
// Counting letter grades. 

using System;

namespace SwitchTestSpace
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class SwitchTest
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         char grade;      // one grade
         int aCount = 0,  // number of As
            bCount = 0,   // number of Bs
            cCount = 0,   // number of Cs
            dCount = 0,   // number of Ds
            fCount = 0;   // number of Fs

         for ( int i = 1; i <= 10; i++ )
         {
            Console.Write( "Enter a letter grade: " );
         
            grade = Char.Parse( Console.ReadLine() );
         
            switch ( grade )
            {
               case 'A':   // grade is uppercase A
               case 'a':   // or lowercase a
                  ++aCount;
                  break;
         
               case 'B':   // grade is uppercase B
               case 'b':   // or lowercase b
                  ++bCount;
                  break;
         
               case 'C':   // grade is uppercase C
               case 'c':   // or lowercase c
                  ++cCount;
                  break;
         
               case 'D':   // grade is uppercase D
               case 'd':   // or lowercase d
                  ++dCount;
                  break;
         
               case 'F':   // grade is uppercase F
               case 'f':   // or lowercase f
                  ++fCount;
                  break;

               default:    // processes all other characters
                  Console.WriteLine( 
                     "Incorrect letter grade entered." +
                     "\nEnter a new grade" );
                  i--;
                  break;

            } // end switch

         } // end for

         Console.WriteLine( 
            "\nTotals for each letter grade are:\nA: {0}" +
            "\nB: {1}\nC: {2}\nD: {3}\nF: {4}", aCount, bCount,
            cCount, dCount, fCount );
       
      } // end method Main

   } // end class SwitchTest

} // end namespace SwitchTestSpace

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
