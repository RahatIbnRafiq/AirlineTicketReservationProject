// Fig 23.5: ListTest.cs 
// Testing class List.

using System;
using LinkedListLibrary;

namespace ListTest
{
   // class to test List class functionality
   class ListTest
   {
      static void Main( string[] args )
      {
         List list = new List();  // create List container

         // create data to store in List
         bool aBoolean = true;
         char aCharacter = '$' ;
         int anInteger =  34567 ;
         string aString = "hello";

         // use List insert methods
         list.InsertAtFront( aBoolean );
         list.Print();
         list.InsertAtFront( aCharacter );
         list.Print();
         list.InsertAtBack( anInteger );
         list.Print();
         list.InsertAtBack( aString );
         list.Print();

         // use List remove methods
         object removedObject;
      
         // remove data from list and print after each removal
         try 
         {
            removedObject = list.RemoveFromFront();
            Console.WriteLine( removedObject + " removed" );
            list.Print();

            removedObject = list.RemoveFromFront();
            Console.WriteLine( removedObject + " removed" );
            list.Print();

            removedObject = list.RemoveFromBack();
            Console.WriteLine( removedObject + " removed" );
            list.Print();

            removedObject = list.RemoveFromBack();
            Console.WriteLine( removedObject + " removed" );
            list.Print();
         }

            // process exception if list empty when attempt is 
            // made to remove item
         catch ( EmptyListException emptyListException ) 
         {
            Console.Error.WriteLine( "\n" + emptyListException );
         } 
      
      } // end method Main
   
   } // end class ListTest
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