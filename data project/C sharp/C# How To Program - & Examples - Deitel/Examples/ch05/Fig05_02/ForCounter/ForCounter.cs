// Fig. 5.2: ForCounter.cs
// Counter-controlled repetition with the for structure.

using System;

namespace csphtp1.ch05.fig05_02
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class ForCounter
   {
      static void Main( string[] args )
      {
         //
         // TODO: Add code to start application here
         //

         // initialization, repetition condition and incrementing
         // are all included in the for structure
         for ( int counter = 1; counter <= 5; counter++ )
            Console.WriteLine( counter );

      } // end of method Main
	
   } // end of class ForCounter

} // end of namespace csphtp1.ch05.fig05_02

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