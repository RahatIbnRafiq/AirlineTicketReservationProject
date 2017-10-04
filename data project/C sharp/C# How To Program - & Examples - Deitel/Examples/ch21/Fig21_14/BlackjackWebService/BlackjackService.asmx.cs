// Fig. 21.14: BlackjackService.asmx.cs
// Blackjack Web Service which manipulates a deck of cards.

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace BlackjackWebService
{
   [ WebService( 
        Namespace = "http://www.deitel.com/csphtp1/ch21/",
        Description = "A Web service that provides methods " +
        "to manipulate a deck of cards." ) ]
   public class BlackjackService : System.Web.Services.WebService
   {
		public BlackjackService()
		{
			InitializeComponent();
		}

      #region Component Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
      }
		#endregion

      // deal new card
      [ WebMethod( EnableSession = true,
           Description = "Deal a new card from the deck." ) ]
      public string DealCard()
      {
         string card = "2 2";

         // get client's deck
         ArrayList deck = ( ArrayList ) Session[ "deck" ];
         card = ( string ) deck[ 0 ];
         deck.RemoveAt( 0 );
         return card;

      } // end method DealCard

      [ WebMethod( EnableSession = true,
           Description = "Create and shuffle a deck of cards." ) ]
      public void Shuffle()
      {
         Random randomObject = new Random();
         
         ArrayList deck = new ArrayList();

         // generate all possible cards
         for ( int i = 1; i < 14; i++ ) 
         {
            for ( int j = 0; j < 4; j++ ) 
            {
               deck.Add( i + " " + j ); 
            }
         }

         // swap each card with another card randomly
         for ( int i = 0; i < deck.Count; i++ )
         {
            int newIndex = randomObject.Next( deck.Count );
            object temporary = deck[ i ]; 
            deck[ i ] = deck[ newIndex ];
            deck[ newIndex ] = temporary;
         }
         
         // add this deck to user's session state
         Session[ "deck" ] = deck;
      }

      // computes value of hand
      [ WebMethod ( Description = "Compute a " +
           "numerical value for the current hand." ) ]
      public int CountCards( string dealt )
      {
         // split string containing cards
         char[] tab = { '\t' };
         string[] cards = dealt.Split( tab );
         int total = 0, face, aceCount = 0;

         foreach ( string drawn in cards )
         {
            // get face of card
            face = 
               Int32.Parse( drawn.Substring(
               0, drawn.IndexOf( " " ) ) );
            
            switch ( face )
            {
                  // if ace, increment number of aces in hand
               case 1:
                  aceCount++;
                  break;

                  // if Jack, Queen or King, add 10 to total
               case 11:  case 12:  case 13:
                  total += 10;
                  break;

                  // otherwise, add value of face
               default:
                  total += face;
                  break;

            } // end switch

         } // end foreach
         
         // if any aces, calculate optimum total
         if ( aceCount > 0 )
         {
            // if it is possible to count one ace as 11, and rest
            // 1 each, do so; otherwise, count all aces as 1 each
            if ( total + 11 + aceCount - 1 <= 21 )
               total += 11 + aceCount - 1;
            else
               total += aceCount;
         }

         return total;

      }  // end method CountCards

   } // end class BlackjackService

} // end namespace BlackjackWebService

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
