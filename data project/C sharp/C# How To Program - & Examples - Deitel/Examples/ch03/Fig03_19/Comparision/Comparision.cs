// Fig. 3.19: Comparison.cs
// Using if statements, relational operators and equality
// operators.

using System;

namespace ComparisonApplication
{
   /// <summary>
   /// Summary description for Comparison.
   /// </summary>
   class Comparison
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int number1,           // first number to add
            number2;           // second number to add
      
         // read in first number from user as a string
         Console.Write( "Please enter first integer: " );
         number1 = Int32.Parse( Console.ReadLine() );

         // read in second number from user as a string
         Console.Write( "\nPlease enter second integer: " );
         number2 = Int32.Parse( Console.ReadLine() );

         if ( number1 == number2 )
            Console.WriteLine( number1 + " == " + number2 );

         if ( number1 != number2 )
            Console.WriteLine( number1 + " != " + number2 );

         if ( number1 < number2 )
            Console.WriteLine( number1 + " < " + number2 );
       
         if ( number1 > number2 )
            Console.WriteLine( number1 + " > " +  number2 );
       
         if ( number1 <= number2 )
            Console.WriteLine( number1 + " <= " + number2 );

         if ( number1 >= number2 )
            Console.WriteLine( number1 + " >= " + number2 );
      
      } // end method Main

   } // end class Comparison
     
} // end namespace ComparisonApplication

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