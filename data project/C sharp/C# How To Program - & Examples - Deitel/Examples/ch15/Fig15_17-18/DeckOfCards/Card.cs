// Fig. 15.17: Card.cs
// Stores suit and face information on each card.

using System;

namespace DeckOfCards
{
   /// <summary>
   /// the representation of a card
   /// </summary>
   public class Card
   {
      private string face;
      private string suit;

      public Card( string faceValue, 
         string suitValue )
      {
         face = faceValue;
         suit = suitValue;

      } // end constructor

      public override string ToString()
      {
         return face + " of " + suit;

      } // end method ToString

   } // end class Card
}

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