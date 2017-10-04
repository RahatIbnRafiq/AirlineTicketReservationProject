// Fig. 4.7: Average1.cs
// Class average with counter-controlled repetition.

using System;

namespace csphtp1.ch04.fig04_07 
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Average1
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int total,          // sum of grades
            gradeCounter,   // number of grades entered
            gradeValue,     // grade value
            average;        // average of all grades

         // initialization phase
         total = 0;          // clear total
         gradeCounter = 1;   // prepare to loop

         // processing phase
         while ( gradeCounter <= 10 )  // loop 10 times
         {
            // prompt for input and read grade from user
            Console.Write( "Enter integer grade: " );

            // read input and convert to integer
            gradeValue = Int32.Parse( Console.ReadLine() );

            // add gradeValue to total
            total = total + gradeValue;

            // add 1 to gradeCounter
            gradeCounter = gradeCounter + 1;
         }

         // termination phase
         average = total / 10;  // integer division

         // display average of exam grades
         Console.WriteLine( "\nClass average is {0}", average );
    
      } // end Main
   
   } // end class Average1

} // end namespace csphtp1.ch04.fig04_07

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
