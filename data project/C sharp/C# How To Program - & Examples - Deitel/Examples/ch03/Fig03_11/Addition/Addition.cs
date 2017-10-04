// Fig. 3.11: Addition.cs
// An addition program.
 
using System;

namespace AdditionProgram
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Addition
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         string firstNumber,   // first string entered by user
            secondNumber;  // second string entered by user

         int number1,          // first number to add
            number2,          // second number to add
            sum;              // sum of number1 and number2

         // prompt for and read first number from user as string
         Console.Write( "Please enter the first integer: " );
         firstNumber = Console.ReadLine();
      
         // read second number from user as string
         Console.Write( "\nPlease enter the second integer: " );
         secondNumber = Console.ReadLine();

         // convert numbers from type string to type int
         number1 = Int32.Parse( firstNumber );
         number2 = Int32.Parse( secondNumber );
      
         // add numbers
         sum = number1 + number2;

         // display results
         Console.WriteLine( "\nThe sum is {0}.", sum );
        
      } // end method Main

   } // end class Addition

} // end namespace AdditionProgram

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