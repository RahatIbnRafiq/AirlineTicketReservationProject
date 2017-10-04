// Fig. 4.11: Analysis.cs
// Analysis of Examination Results.

using System;

namespace csphtp1.ch04.fig04_11
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Analysis
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //
	   
         int passes = 0,            // number of passes
            failures = 0,          // number of failures
            student = 1,           // student counter
            result;                // one exam result

         // process 10 students; counter-controlled loop
         while ( student <= 10 ) 
         {
            Console.WriteLine( "Enter result (1=pass, 2=fail)" );
            result = Int32.Parse( Console.ReadLine() );

            if ( result == 1 )
               passes = passes + 1;
         
            else 
               failures = failures + 1;

            student = student + 1;
         }

         // termination phase
         Console.WriteLine();
         Console.WriteLine( "Passed: " + passes );
         Console.WriteLine( "Failed: " + failures );

         if ( passes > 8 )
            Console.WriteLine( "Raise Tuition\n" );
     
      } // end of method Main

   } // end of class Analysis

} // end of namespace csphtp1.ch04.fig04_11

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
