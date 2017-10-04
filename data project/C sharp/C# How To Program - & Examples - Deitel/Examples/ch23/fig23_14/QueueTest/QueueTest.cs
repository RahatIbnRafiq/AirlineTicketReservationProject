// Fig. 23.14: QueueTest.cs
// Testing class QueueInheritance.

using System;
using QueueInheritanceLibrary;
using LinkedListLibrary;

namespace QueueTest
{
   // demonstrate functionality of class QueueInheritance
   class QueueTest
   {
      static void Main( string[] args )
      {
         QueueInheritance queue = new QueueInheritance();

         // create objects to store in the stack
         bool aBoolean = true;
         char aCharacter = '$';
         int anInteger = 34567;
         string aString = "hello";

         // use method Enqueue to add items to queue
         queue.Enqueue( aBoolean );
         queue.Print();
         queue.Enqueue( aCharacter );
         queue.Print();
         queue.Enqueue( anInteger );
         queue.Print();
         queue.Enqueue( aString );
         queue.Print();

         // use method Dequeue to remove items from queue
         object removedObject = null;

         // remove items from queue
         try 
         {
            while ( true ) 
            {
               removedObject = queue.Dequeue();
               Console.WriteLine( removedObject + " dequeue" );
               queue.Print();
            }
         }

            // if exception occurs, print stack trace
         catch ( EmptyListException emptyListException ) 
         {
            Console.Error.WriteLine( 
               emptyListException.StackTrace );
         }
    
      } // end method Main
	
   } // end class QueueTest
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