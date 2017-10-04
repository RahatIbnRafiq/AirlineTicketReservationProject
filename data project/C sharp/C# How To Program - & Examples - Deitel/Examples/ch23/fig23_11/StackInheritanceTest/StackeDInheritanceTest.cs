// Fig. 23.11: StackInheritanceTest.cs
// Testing class StackInheritance.

using System;
using StackInheritanceLibrary;
using LinkedListLibrary;

namespace StackInheritanceTest
{
   // demonstrate functionality of class StackInheritance
   class StackInheritanceTest
   {
      static void Main( string[] args )
      {
         StackInheritance stack = new StackInheritance();

         // create objects to store in the stack
         bool aBoolean = true;
         char aCharacter = '$';
         int anInteger = 34567;
         string aString = "hello";

         // use method Push to add items to stack
         stack.Push( aBoolean );
         stack.Print();
         stack.Push( aCharacter );
         stack.Print();
         stack.Push( anInteger );
         stack.Print();
         stack.Push( aString );
         stack.Print();

         // remove items from stack
         try 
         {         
            while ( true ) 
            {
               object removedObject = stack.Pop();
               Console.WriteLine( removedObject + " popped" );
               stack.Print();
            }
         }

            // if exception occurs, print stack trace
         catch ( EmptyListException emptyListException ) 
         {
            Console.Error.WriteLine( 
               emptyListException.StackTrace );
         }
      
      } // end method Main
	
   } // end class StackInheritanceTest
}

/**************************************************************************
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
 *************************************************************************/
