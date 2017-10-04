// Fig. 4.9: Average2.cs
// Class average with sentinel-controlled repetition.

using System;

namespace csphtp1.ch04.fig04_09
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Average2
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int total,           // sum of grades
            gradeCounter,    // number of grades entered
            gradeValue;      // grade value

         double average;      // average of all grades

         // initialization phase
         total = 0;           // clear total
         gradeCounter = 0;    // prepare to loop

         // processing phase
         // prompt for input and convert to integer
         Console.Write( "Enter Integer Grade, -1 to Quit: " );
         gradeValue = Int32.Parse( Console.ReadLine() );

         // loop until a -1 is entered by user
         while ( gradeValue != -1 )
         {
            // add gradeValue to total
            total = total + gradeValue;

            // add 1 to gradeCounter
            gradeCounter = gradeCounter + 1;

            // prompt for input and read grade from user
            // convert grade from string to integer
            Console.Write( "Enter Integer Grade, -1 to Quit: " );
            gradeValue = Int32.Parse( Console.ReadLine() );

         } // end while

         // termination phase
         if ( gradeCounter != 0 ) 
         {

            average = ( double ) total / gradeCounter;

            // display average of exam grades
            Console.WriteLine( "\nClass average is {0}", average );

         }
         else
         {
            Console.WriteLine( "No grades were entered." );
         }

      } // end method Main
   
   } // end class Average2

} // end namespace csphtp1.ch04.fig04_09

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