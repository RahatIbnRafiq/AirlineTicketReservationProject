// Fig. 5.1: WhileCounter.cs
// Counter-controlled repetition

using System;

namespace csphtp1.ch05.fig05_01
{
   /// <summary>
   /// Summary description for WhileCounter.
   /// </summary>
   class WhileCounter
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         int counter = 1;        // initialization

         while ( counter <= 5 )  // repetition condition
         {
            Console.WriteLine( counter );
            counter++;           // increment

         } // end while

      } // end method Main

   } // end class WhileCounter

} // end namespace csphtp1.ch05.fig05_01

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