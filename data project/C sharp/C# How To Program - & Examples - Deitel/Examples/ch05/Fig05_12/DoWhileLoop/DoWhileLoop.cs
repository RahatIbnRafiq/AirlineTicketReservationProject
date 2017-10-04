// Fig. 5.12: DoWhileLoop.cs
// The do/while repetition structure.

using System;

namespace DoWhileLoopSpace
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class DoWhileLoop
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //
         int counter = 1;
      
         do 
         {
            Console.WriteLine( counter );
            counter++;
         }while ( counter <= 5 );

      } // end method Main

   } // end class DoWhileLoop

} // end namespace DoWhileLoopSpace

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