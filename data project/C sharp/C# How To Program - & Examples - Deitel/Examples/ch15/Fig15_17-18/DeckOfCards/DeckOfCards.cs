// Fig. 15.18: DeckOfCards.cs
// Simulating card drawing and shuffling.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DeckOfCards
{
   /// <summary>
   /// provides the functionality for the form
   /// </summary>
   public class deckForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button dealButton;
      private System.Windows.Forms.Button shuffleButton;
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Label statusLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private Card[] deck = new Card[ 52 ];
      private int currentCard;

      public deckForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dealButton = new System.Windows.Forms.Button();
         this.shuffleButton = new System.Windows.Forms.Button();
         this.displayLabel = new System.Windows.Forms.Label();
         this.statusLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // dealButton
         // 
         this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.dealButton.Location = new System.Drawing.Point(48, 24);
         this.dealButton.Name = "dealButton";
         this.dealButton.Size = new System.Drawing.Size(120, 56);
         this.dealButton.TabIndex = 0;
         this.dealButton.Text = "Deal Card";
         this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
         // 
         // shuffleButton
         // 
         this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.shuffleButton.Location = new System.Drawing.Point(248, 24);
         this.shuffleButton.Name = "shuffleButton";
         this.shuffleButton.Size = new System.Drawing.Size(120, 56);
         this.shuffleButton.TabIndex = 1;
         this.shuffleButton.Text = "Shuffle Cards";
         this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
         // 
         // displayLabel
         // 
         this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayLabel.Location = new System.Drawing.Point(112, 96);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(168, 24);
         this.displayLabel.TabIndex = 2;
         this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // statusLabel
         // 
         this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.statusLabel.Location = new System.Drawing.Point(128, 144);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(136, 24);
         this.statusLabel.TabIndex = 3;
         this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // deckForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(408, 181);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.statusLabel,
                                                                      this.displayLabel,
                                                                      this.shuffleButton,
                                                                      this.dealButton});
         this.Name = "deckForm";
         this.Text = "Card Dealling Program";
         this.Load += new System.EventHandler(this.deckForm_Load);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new deckForm());
      }

      // handles form at load time
      private void deckForm_Load(object sender, System.EventArgs e)
      {
         string[] faces = { "Ace", "Deuce", "Three", "Four",
                             "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                             "Jack", "Queen", "King" };

         string[] suits = { "Hearts", "Diamonds", "Clubs",
                             "Spades" };

         // no cards have been drawn
         currentCard = -1;

         // initialize deck
         for ( int i = 0; i < deck.Length; i++ )
            deck[ i ] = new Card( faces[ i % 13 ], suits[ i % 4 ] );

      } // end method deckForm_Load

      // handles dealButton Click
      private void dealButton_Click(object sender, System.EventArgs e)
      {
         Card dealt = DealCard();

         // if dealt card is null, then no cards left
         // player must shuffle cards
         if ( dealt != null )
         {
            displayLabel.Text = dealt.ToString();
            statusLabel.Text = "Card #: " + currentCard;
         }
         else
         {
            displayLabel.Text = "NO MORE CARDS TO DEAL";
            statusLabel.Text = "Shuffle cards to continue";
         }  
      }

      // shuffle cards
      private void Shuffle()
      {
         Random randomNumber = new Random();
         Card temporaryValue;

         currentCard = -1;

         // swap each card with random card
         for ( int i = 0; i < deck.Length; i++ )
         {
            int j = randomNumber.Next( 52 );

            // swap cards
            temporaryValue = deck[ i ];
            deck[ i ] = deck[ j ];
            deck[ j ] = temporaryValue;
         }

         dealButton.Enabled = true;

      } // end method Shuffle

      private Card DealCard()
      {
         // if there is a card to deal then deal it
         // otherwise signal that cards need to be shuffled by
         // disabling dealButton and returning null
         if ( currentCard + 1 < deck.Length )
         {
            currentCard++;
            return deck[ currentCard ];
         }
         else
         {
            dealButton.Enabled = false;
            return null;
         }

      } // end method DealCard

      // handles shuffleButton Click
      private void shuffleButton_Click(object sender, System.EventArgs e)
      {
         displayLabel.Text = "SHUFFLING...";
         Shuffle();
         displayLabel.Text = "DECK IS SHUFFLED";

      } // end method shuffleButton_Click

   } // end class deckForm
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